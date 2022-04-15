using System.Collections;
using System;
using System.Text;
using System.Reflection;
using System.Threading.Channels;
using System.Net.Http;
using System.Web;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Xiaoheihe_CShape.Data;
using System.Text.Json;

namespace Xiaoheihe_CShape
{
    public class XiaoheiheClient
    {
        internal string Pkey { get; set; }
        internal string HeyboxID { get; set; }
        internal Dictionary<string, string> RequestParams { get; set; }
        internal Dictionary<string, string> HttpHeaders { get; set; }
        internal Uri HkeyServer { get; set; }

        internal readonly Uri XiaoHeiHeAPI = new("https://api.xiaoheihe.cn");

        internal HttpClient Http { get; private set; } = new(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip });

        public XiaoheiheClient(Account account, string version, string hkeyServer)
        {
            Pkey = account.Pkey;
            HeyboxID = account.HeyboxID;
            RequestParams = Utils.DefaultParams(account, version);
            HttpHeaders = Utils.SetDefaultHttpHeaders(Http, account.Pkey);
            HkeyServer = new Uri(hkeyServer);
        }


        private string CallHkeyServer(string urlPath, string nonce, string timeStamp)
        {
            if (!urlPath.EndsWith("/")) { urlPath += "/"; }

            Uri uri = new(HkeyServer, $"?urlpath={urlPath}&timestamp={timeStamp}&nonce={nonce}");

            HttpRequestMessage request = new(HttpMethod.Post, uri);

            HttpResponseMessage response = Http.Send(request);

            string hkey = response.Content.ReadAsStringAsync().Result;

            return hkey;
        }


        public Uri BuildQueryParams(string urlPath, Dictionary<string, string>? extendParams = null)
        {
            UriBuilder ub = new(XiaoHeiHeAPI);
            ub.Path = urlPath;

            var temp = RequestParams.ToDictionary(x => x.Key, x => x.Value);

            if (extendParams != null)
            {
                foreach (KeyValuePair<string, string> item in extendParams)
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

            string hkey = CallHkeyServer(urlPath, nonce, timeStamp);

            temp["_time"] = timeStamp;
            temp["time_"] = timeStamp;
            temp["nonce"] = nonce;
            temp["hkey"] = hkey;

            NameValueCollection query = HttpUtility.ParseQueryString(ub.Query);
            foreach (KeyValuePair<string, string> item in temp)
            {
                string value = item.Value;
                if (!string.IsNullOrEmpty(value))
                {
                    query.Add(item.Key, value);
                }
            }

            ub.Query = query.ToString();

            return ub.Uri;
        }

        public T? BasicRequest<T>(HttpRequestMessage request)
        {
            HttpResponseMessage response = Http.Send(request);

            Stream receiveStream = response.Content.ReadAsStreamAsync().Result;
            StreamReader readStream = new (receiveStream, Encoding.UTF8);
            string strJson = readStream.ReadToEnd();

            T? result = JsonSerializer.Deserialize<T>(strJson);

            if(result == null)
            {
                //throw new NullRespo
            }

            return result;
        }

    }
}