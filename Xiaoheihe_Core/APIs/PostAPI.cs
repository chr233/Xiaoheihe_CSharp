using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class PostAPI
    {
        /// <summary>
        /// 发布动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<PostLinkResponse> PostEvent(this XiaoheiheClient xhh)
        {
            //string subPath = "/bbs/app/api/link/post";

            //Dictionary<string, string> formData = new(4)
            //{
            //    { "draft", "0" },
            //    { "topic_ids", "0" },
            //    { "hashtags", "[]" },
            //    { "link_tag", "21" },
            //    { "text", "ceshi" },
            //    { "desc", "ceshi" },
            //    { "tags", "[]" },
            //};

            //FormUrlEncodedContent content = new(formData);

            throw new NotImplementedException();

            //PostLinkResponse response = await xhh.BasicRequest<PostLinkResponse>(HttpMethod.Post, subPath, content).ConfigureAwait(false);

            //return response;
        }
    }
}
