using System.Text;
using Xiaoheihe_Core.Data;
using static Xiaoheihe_Core.StaticValue;

namespace Xiaoheihe_Core
{
    public static class Utils
    {
        /// <summary>
        /// 组装默认参数
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static Dictionary<string, string> DefaultParams(Account account)
        {
            return DefaultParams(account, DefaultHBVersion);
        }

        /// <summary>
        /// 组装默认参数
        /// </summary>
        /// <param name="account"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static Dictionary<string, string> DefaultParams(Account account, string version)
        {
            if (string.IsNullOrEmpty(account.Imei)) { account.Imei = RandomImei(); }
            if (string.IsNullOrEmpty(version)) { version = DefaultHBVersion; }

            Dictionary<string, string> paramDict = new(38)
            {
                { "userid", "" },
                { "type", "" },
                { "h_src", "" },
                { "shared_type", "" },
                { "index", "" },
                { "offset", "" },
                { "page", "" },
                { "limit", "" },
                { "filters", "" },
                { "only_cy", "" },
                { "list_type", "" },
                { "older", "" },
                { "newer", "" },
                { "tag", "" },
                { "rec_mark", "" },
                { "news_list_type", "" },
                { "is_first", "" },
                { "news_list_group", "" },
                { "appid", "" },
                { "platf", "" },
                { "sort_filter", "" },
                { "owner_only", "" },
                { "hide_cy", "" },
                { "time_", "" },
                { "heybox_id", account.HeyboxID },
                { "imei", account.Imei },
                { "divice_info", account.DeviceInfo },
                { "os_type", account.OSType },
                { "x_os_type", account.OSType },
                { "x_client_type", "mobile" },
                { "os_version", account.OSVersion },
                { "version", version },
                { "x_app", "heybox" },
                { "_time", "" },
                { "nonce", "" },
                { "hkey", "" },
                { "channal", account.Channal }
            };

            return paramDict;
        }

        /// <summary>
        /// 设置默认请求头
        /// </summary>
        /// <param name="client"></param>
        /// <param name="pkey"></param>
        /// <returns></returns>
        public static Dictionary<string, string> SetDefaultHttpHeaders(HttpClient client, string pkey)
        {
            Dictionary<string, string> headers = new(6)
            {
                { "Host", "api.xiaoheihe.cn" },
                { "Cookie", $"pkey={pkey}" },
                { "Referer", "http://api.maxjia.com/" },
                { "User-Agent", "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.118 Safari/537.36 ApiMaxJia/1.0" },
                { "Accept-Encoding", "gzip, deflate" },
                { "Connection", "close" },

            };

            foreach (KeyValuePair<string, string> header in headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            return headers;
        }

        /// <summary>
        /// 生成随机IMEI
        /// </summary>
        /// <returns></returns>
        public static string RandomImei()
        {
            string template = "0123456789abcdefghijklmnopqrstuvwxyz";
            Random rand = new();
            StringBuilder imei = new();
            for (int i = 0; i < 16; i++)
            {
                imei.Append(template.AsSpan(rand.Next(0, template.Length - 1), 1));
            }
            return imei.ToString();
        }

        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <returns></returns>
        public static string RandomNonce()
        {
            string template = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new();
            StringBuilder imei = new();
            for (int i = 0; i < 32; i++)
            {
                imei.Append(template.AsSpan(rand.Next(0, template.Length - 1), 1));
            }
            return imei.ToString();
        }


        public static string Base64Encode(string text)
        {
            byte[] inArray = Encoding.UTF8.GetBytes(text);
            string b64String = Convert.ToBase64String(inArray);
            return b64String;
        }
    }
}
