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
        public static SendCommentsResponse SentComment(this XiaoheiheClient xhh, uint linkID, string comment)
        {
            return xhh.SentComment(linkID, 1, comment, -1, -1, false);
        }

        /// <summary>
        /// 发布评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <param name="comment"></param>
        /// <param name="roomID"></param>
        /// <param name="replyID"></param>
        /// <param name="isCy"></param>
        /// <returns></returns>
        public static SendCommentsResponse SentComment(this XiaoheiheClient xhh, uint linkID, uint index, string comment, int roomID, int replyID, bool isCy)
        {
            string subPath = "/bbs/app/comment/create";

            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            Dictionary<string, string> extendParams = new(2)
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

            SendCommentsResponse response = xhh.BasicRequest<SendCommentsResponse>(HttpMethod.Post, subPath, extendParams, content);

            return response;
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="commentID"></param>
        /// <returns></returns>
        public static BasicResponse DeleteComment(this XiaoheiheClient xhh, long commentID)
        {
            string subPath = "/bbs/app/comment/delete";

            Dictionary<string, string> formData = new(1)
            {
                { "comment_id", commentID.ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, content);

            return response;
        }
    }
}
