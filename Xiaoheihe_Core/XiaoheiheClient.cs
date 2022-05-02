using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Web;
using Xiaoheihe_Core.Converters;
using Xiaoheihe_Core.Data;
using Xiaoheihe_Core.Exceptions;

namespace Xiaoheihe_Core
{
    public class XiaoheiheClient
    {
        internal static Uri XiaoHeiHeAPI { get; } = new("https://api.xiaoheihe.cn");
        internal string Pkey { get; set; }
        public uint HeyboxID { get; private set; }
        public string HeyboxVersion { get; private set; }
        internal Dictionary<string, string> RequestParams { get; set; }
        internal Dictionary<string, string> HttpHeaders { get; private set; }
        internal Uri HkeyServer { get; private set; }
        internal HttpClient HttpForXhh { get; private set; }
        internal HttpClient HttpForHkey { get; private set; }

        internal JsonSerializerOptions JsonOptions { get; private set; } = new();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        /// <param name="version"></param>
        /// <param name="hkeyServer"></param>
        public XiaoheiheClient(Account account, string version, string hkeyServer)
        {
            HttpForXhh = new(new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });

            HttpForHkey = new(new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => {
                    return true;
                }
            });

            uint heyboxID = uint.Parse(account.HeyboxID);

            Pkey = account.Pkey;
            HeyboxID = heyboxID;
            HeyboxVersion = version;
            RequestParams = Utils.DefaultParams(account, version);
            HttpHeaders = Utils.SetDefaultHttpHeaders(HttpForXhh, account.Pkey);
            HkeyServer = new Uri(hkeyServer);

            JsonOptions.Converters.Add(new DateTimeConverter());
            JsonOptions.Converters.Add(new StringIntegerConverter());
        }

        /// <summary>
        /// 计算Hkey
        /// </summary>
        /// <param name="urlPath"></param>
        /// <param name="nonce"></param>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        private async Task<string> CallHkeyServer(string urlPath, string nonce, string timeStamp)
        {
            if (!urlPath.EndsWith("/")) { urlPath += "/"; }

            Uri uri = new(HkeyServer, $"?urlpath={urlPath}&timestamp={timeStamp}&nonce={nonce}");

            HttpRequestMessage request = new(HttpMethod.Get, uri);

            HttpResponseMessage response = HttpForHkey.Send(request);

            string hkey = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return hkey;
        }

        /// <summary>
        /// 构建请求Url
        /// </summary>
        /// <param name="urlPath"></param>
        /// <returns></returns>
        public async Task<Uri> BuildQueryParams(string urlPath)
        {
            return await BuildQueryParamsAsync(urlPath, null).ConfigureAwait(false);
        }

        /// <summary>
        /// 构建请求Url
        /// </summary>
        /// <param name="urlPath"></param>
        /// <param name="extraParams"></param>
        /// <returns></returns>
        public async Task<Uri> BuildQueryParamsAsync(string urlPath, Dictionary<string, string>? extraParams)
        {
            UriBuilder urlBuilder = new(XiaoHeiHeAPI);
            urlBuilder.Path = urlPath;

            Dictionary<string, string> temp = RequestParams.ToDictionary(x => x.Key, x => x.Value);

            if (extraParams != null)
            {
                foreach (KeyValuePair<string, string> item in extraParams)
                {
                    string key = item.Key;
                    if (temp.ContainsKey(key))
                    {
                        temp[key] = item.Value;
                    }
                }
            }

            string nonce = Utils.RandomNonce();
            string timeStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

            string hkey = await CallHkeyServer(urlPath, nonce, timeStamp).ConfigureAwait(false);

            temp["_time"] = timeStamp;
            //temp["time_"] = timeStamp;
            temp["nonce"] = nonce;
            temp["hkey"] = hkey;

            NameValueCollection query = HttpUtility.ParseQueryString(urlBuilder.Query);
            foreach (KeyValuePair<string, string> item in temp)
            {
                string value = item.Value;
                if (!string.IsNullOrEmpty(value))
                {
                    query.Add(item.Key, value);
                }
            }

            urlBuilder.Query = query.ToString();

            return urlBuilder.Uri;
        }

        /// <summary>
        /// 检查返回值
        /// </summary>
        /// <param name="response"></param>
        /// <exception cref="AccountErrorException"></exception>
        private static void CheckResponse(BasicResponse response)
        {
            switch (response.Status.ToLower())
            {
                case "ok":
                    return;
                case "relogin":
                    throw new AccountErrorException(message: response.Message);
                case "failed":
                    if (response.Message == "不能重复赞哦")
                    {
                        return;
                    }
                    throw new XhhCSBaseException(message: response.Message);
                default:
                    throw new UnknownException(message: response.Message);
            }
        }

        /// <summary>
        /// 基础请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="subPath"></param>
        /// <returns></returns>
        public async Task<T> BasicRequest<T>(HttpMethod method, string subPath) where T : BasicResponse
        {
            return await BasicRequest<T>(method, subPath, null, null);
        }

        /// <summary>
        /// 基础请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="subPath"></param>
        /// <param name="extraParams"></param>
        /// <returns></returns>
        public async Task<T> BasicRequest<T>(HttpMethod method, string subPath, Dictionary<string, string> extraParams) where T : BasicResponse
        {
            return await BasicRequest<T>(method, subPath, extraParams, null).ConfigureAwait(false);
        }

        /// <summary>
        /// 基础请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="subPath"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<T> BasicRequest<T>(HttpMethod method, string subPath, HttpContent content) where T : BasicResponse
        {
            return await BasicRequest<T>(method, subPath, null, content).ConfigureAwait(false);
        }

        /// <summary>
        /// 基础请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="subPath"></param>
        /// <param name="extraParams"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="HkeyServerErrorException"></exception>
        /// <exception cref="NullResponseException"></exception>
        public async Task<T> BasicRequest<T>(HttpMethod method, string subPath, Dictionary<string, string>? extraParams, HttpContent? content) where T : BasicResponse
        {
            Uri uri;
            try
            {
                uri = await BuildQueryParamsAsync(subPath, extraParams).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new HkeyServerErrorException(ex.Message);
            }

            HttpRequestMessage request = new(method, uri) { Content = content };

            HttpResponseMessage response = HttpForXhh.Send(request);

            Stream receiveStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            StreamReader readStream = new(receiveStream, Encoding.UTF8);
            string strJson = await readStream.ReadToEndAsync().ConfigureAwait(false);

            T? result = JsonSerializer.Deserialize<T>(strJson, JsonOptions);

            if (result == null) { throw new NullResponseException(); }

            try
            {
                CheckResponse(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public override string? ToString()
        {
            return $"{nameof(XiaoheiheClient)} {HeyboxID} {HeyboxVersion}";
        }
    }
}
