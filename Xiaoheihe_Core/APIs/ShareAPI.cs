using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class ShareAPI
    {
        /// <summary>
        /// 分享新闻
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<bool> ShareNews(this XiaoheiheClient xhh, uint linkID, int index)
        {
            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            async Task ShareClick()
            {
                string subPath = "/bbs/app/link/share/click";

                Dictionary<string, string> extraParams = new(3)
                {
                    { "h_src", hSrc },
                    { "link_id", linkID.ToString() },
                    { "index", index.ToString() },
                };

                BasicResponse _ = await xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

                return;
            }

            async Task ShareCheck()
            {
                string subPath = "/task/shared/";

                Dictionary<string, string> extraParams = new(2)
                {
                    { "h_src", hSrc },
                    { "shared_type", "normal" },
                };

                BasicResponse _ = await xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

                return;
            }

            try
            {
                await ShareClick().ConfigureAwait(false);
                await ShareCheck().ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 分享评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> ShareComment(this XiaoheiheClient xhh)
        {
            string subPath = "/task/shared/";

            Dictionary<string, string> extraParams = new(1)
            {
                { "shared_type", "BBSComment" },
            };

            BasicResponse response = await xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }
    }
}
