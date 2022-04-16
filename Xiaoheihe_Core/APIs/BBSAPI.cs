using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class BBSAPI
    {
        /// <summary>
        /// 获取首页新闻流
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static AppFeedNewsResponse GetFeedNews(this XiaoheiheClient xhh,
            uint offset = 0, string tag = "-1", string recMark = "timeline", string newsListType = "normal", string newsListGroup = "control-group")
        {
            string subPath = "/bbs/app/feeds/news";

            Dictionary<string, string> extendParams = new(5)
            {
                { "offset", offset.ToString() },
                { "limit", "30" },
                { "tag", tag },
                { "rec_mark", recMark },
                { "news_list_type", newsListType },
                { "is_first", offset == 0 ? "1" : "0" },
                { "news_list_group", newsListGroup },

            };

            AppFeedNewsResponse response = xhh.BasicRequest<AppFeedNewsResponse>
                (HttpMethod.Get, subPath, extendParams, null);

            return response;
        }
    }
}
