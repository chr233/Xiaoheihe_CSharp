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
                (HttpMethod.Get, subPath, extendParams);

            return response;
        }

        public static BasicResponse LikeNews(this XiaoheiheClient xhh, uint linkID, bool like)
        {
            return xhh.LikeNews(linkID, 1, like);
        }

        public static BasicResponse LikeNews(this XiaoheiheClient xhh, uint linkID, uint index, bool like)
        {
            string subPath = "/bbs/app/profile/award/link";

            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            Dictionary<string, string> extendParams = new(2)
            {
                { "h_src", hSrc },
                { "index", index.ToString() },
            };

            Dictionary<string, string> formData = new(2)
            {
                { "link_id", linkID.ToString() },
                { "award_type", like ? "1" : "0" },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, extendParams, content);

            return response;
        }
    }
}
