using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaoheihe_Core.Data;
using static Xiaoheihe_Core.StaticValue;

namespace Xiaoheihe_Core
{
    public static class Utils
    {
        public static Dictionary<string, string> DefaultParams(Account account, string version = DefaultHBVersion)
        {
            if (string.IsNullOrEmpty(account.Imei)) { account.Imei = RandomImei(); }
            if (string.IsNullOrEmpty(version)) { version = DefaultHBVersion; }

            Dictionary<string, string> paramDict = new(25)
            {
                { "type", "" },
                { "h_src", "" },
                { "index", "" },
                { "offset", "" },
                { "limit", "" },
                { "tag", "" },
                { "rec_mark", "" },
                { "news_list_type", "" },
                { "is_first", "" },
                { "news_list_group", "" },
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


        public static string PackageParams(Dictionary<string, string> paramsDict)
        {
            StringBuilder sb = new();

            foreach (KeyValuePair<string, string> item in paramsDict)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    sb.Append($"&{item.Key}={item.Value}");
                }
            }

            return sb.ToString();
        }

        public static string RandomImei()
        {
            string template = "0123456789abcdefghijklmnopqrstuvwxyz";
            Random rand = new();
            StringBuilder imei = new();
            for (int i = 0; i < 16; i++)
            {
                imei.Append(template.Substring(rand.Next(0, template.Length - 1), 1));
            }
            return imei.ToString();
        }

        public static string RandomNonce()
        {
            string template = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new();
            StringBuilder imei = new();
            for (int i = 0; i < 32; i++)
            {
                imei.Append(template.Substring(rand.Next(0, template.Length - 1), 1));
            }
            return imei.ToString();
        }
    }
}
