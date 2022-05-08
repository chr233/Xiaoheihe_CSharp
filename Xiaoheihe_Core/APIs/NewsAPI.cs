using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class NewsAPI
    {
        /// <summary>
        /// 获取首页新闻流
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<AppFeedNewsResponse> GetFeedNews(this XiaoheiheClient xhh)
        {
            return await xhh.GetFeedNews(0).ConfigureAwait(false);
        }

        /// <summary>
        /// 获取首页新闻流
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static async Task<AppFeedNewsResponse> GetFeedNews(this XiaoheiheClient xhh, uint offset)
        {
            return await xhh.GetFeedNews(offset, "-1", "timeline", "normal", "control-group").ConfigureAwait(false);
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
        public static async Task<AppFeedNewsResponse> GetFeedNews(this XiaoheiheClient xhh, uint offset, string tag, string recMark, string newsListType, string newsListGroup)
        {
            string subPath = "/bbs/app/feeds/news";

            Dictionary<string, string> extraParams = new(5)
            {
                { "offset", offset.ToString() },
                { "limit", "30" },
                { "tag", tag },
                { "rec_mark", recMark },
                { "news_list_type", newsListType },
                { "is_first", offset == 0 ? "1" : "0" },
                { "news_list_group", newsListGroup },

            };

            AppFeedNewsResponse response = await xhh.BasicRequestAsync<AppFeedNewsResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<LinkWebViewResponse> GetNewsContent(this XiaoheiheClient xhh, uint linkID)
        {
            return await xhh.GetNewsContent(linkID, 1).ConfigureAwait(false);
        }

        /// <summary>
        /// 获取文章内容
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<LinkWebViewResponse> GetNewsContent(this XiaoheiheClient xhh, uint linkID, uint index)
        {
            string subPath = "/bbs/app/link/web/view";

            string h_src = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            Dictionary<string, string> extraParams = new(4)
            {
                { "link_id", linkID.ToString() },
                { "return_json", "1" },
                { "index", index.ToString() },
                { "h_src", h_src },
            };

            LinkWebViewResponse response = await xhh.BasicRequestAsync<LinkWebViewResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }
    }
}
