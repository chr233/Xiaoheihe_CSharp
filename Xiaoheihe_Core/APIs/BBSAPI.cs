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
        /// <param name="offset"></param>
        /// <returns></returns>
        public static AppFeedNewsResponse GetFeedNews(this XiaoheiheClient xhh, uint offset)
        {
            return xhh.GetFeedNews(offset, "-1", "timeline", "normal", "control-group");
        }

        /// <summary>
        /// 获取首页新闻流
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <param name="tag"></param>
        /// <param name="recMark"></param>
        /// <param name="newsListType"></param>
        /// <param name="newsListGroup"></param>
        /// <returns></returns>
        public static AppFeedNewsResponse GetFeedNews(this XiaoheiheClient xhh, uint offset, string tag, string recMark, string newsListType, string newsListGroup)
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
