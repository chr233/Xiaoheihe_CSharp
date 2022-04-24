using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class CommentAPI
    {
        /// <summary>
        /// 发布评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static async Task<SendCommentsResponse> SentComment(this XiaoheiheClient xhh, uint linkID, string comment)
        {
            return await xhh.SentComment(linkID, 1, comment, -1, -1, false).ConfigureAwait(false);
        }

        /// <summary>
        /// 发布评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID">文章ID</param>
        /// <param name="index">主页索引</param>
        /// <param name="comment">评论内容</param>
        /// <param name="roomID"></param>
        /// <param name="replyID">楼中楼主楼ID</param>
        /// <param name="isCy">是否有插眼</param>
        /// <returns></returns>
        public static async Task<SendCommentsResponse> SentComment(this XiaoheiheClient xhh, uint linkID, uint index, string comment, int roomID, int replyID, bool isCy)
        {
            string subPath = "/bbs/app/comment/create";

            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            Dictionary<string, string> extraParams = new(2)
            {
                { "h_src", hSrc },
                { "index", index.ToString() }
            };

            Dictionary<string, string> formData = new(6)
            {
                { "link_id", linkID.ToString() },
                { "text", comment },
                { "room_id", roomID.ToString() },
                { "reply_id", replyID.ToString() },
                { "imgs", "" },
                { "is_cy", isCy ? "1" : "0" },
            };

            FormUrlEncodedContent content = new(formData);

            SendCommentsResponse response = await xhh.BasicRequest<SendCommentsResponse>(HttpMethod.Post, subPath, extraParams, content).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="commentID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DeleteComment(this XiaoheiheClient xhh, long commentID)
        {
            string subPath = "/bbs/app/comment/delete";

            Dictionary<string, string> formData = new(1)
            {
                { "comment_id", commentID.ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = await xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, content).ConfigureAwait(false);

            return response;
        }
    }
}
