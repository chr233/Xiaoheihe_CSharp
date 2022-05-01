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

            AppFeedNewsResponse response = await xhh.BasicRequest<AppFeedNewsResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<UserEventsResponse> GetSubscribedEvents(this XiaoheiheClient xhh)
        {
            return await xhh.GetSubscribedEvents(0).ConfigureAwait(false);
        }

        /// <summary>
        /// 获取动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static async Task<UserEventsResponse> GetSubscribedEvents(this XiaoheiheClient xhh, uint offset)
        {
            return await xhh.GetSubscribedEvents(offset, "post_link|game_comment|roll_room|followed_event").ConfigureAwait(false);
        }

        /// <summary>
        /// 获取动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static async Task<UserEventsResponse> GetSubscribedEvents(this XiaoheiheClient xhh, uint offset, string filter)
        {
            string subPath = "/bbs/app/profile/subscribed/events";

            Dictionary<string, string> extraParams = new(3)
            {
                { "offset", offset.ToString() },
                { "limit", "30" },
                { "filters", filter },
            };

            UserEventsResponse response = await xhh.BasicRequest<UserEventsResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取分区标签信息
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<FavourTopicResponse> GetFavourTopics(this XiaoheiheClient xhh)
        {
            string subPath = "/maxnews/app/setup/favour";

            Dictionary<string, string> extraParams = new(2)
            {
                { "news_list_group", "control-group" },
                { "news_list_type", "normal" },
            };

            FavourTopicResponse response = await xhh.BasicRequest<FavourTopicResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }


    }
}
