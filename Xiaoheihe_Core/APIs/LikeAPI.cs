using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class LikeAPI
    {
        /// <summary>
        /// 点赞或者取消点赞文章
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="like"></param>
        /// <returns></returns>
        private static async Task<BasicResponse> LikeNewsAction(this XiaoheiheClient xhh, ulong linkID, AwardType like)
        {
            return await xhh.LikeNewsAction(linkID, -1, like).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞或者取消点赞文章
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <param name="like"></param>
        /// <returns></returns>
        private static async Task<BasicResponse> LikeNewsAction(this XiaoheiheClient xhh, ulong linkID, int index, AwardType like)
        {
            string subPath = "/bbs/app/profile/award/link";

            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            Dictionary<string, string> extraParams = new(2)
            {
                { "h_src", hSrc },
                { "index", index.ToString() },
            };

            Dictionary<string, string> formData = new(2)
            {
                { "link_id", linkID.ToString() },
                { "award_type", ((int)like).ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = await xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, extraParams, content).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 点赞文章或者新闻或者帖子
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> LikeNews(this XiaoheiheClient xhh, ulong linkID)
        {
            return await xhh.LikeNewsAction(linkID, AwardType.Like).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞文章或者新闻或者帖子
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> LikeNews(this XiaoheiheClient xhh, ulong linkID, int index)
        {
            return await xhh.LikeNewsAction(linkID, index, AwardType.Like).ConfigureAwait(false);
        }

        /// <summary>
        /// 取消点赞文章或者新闻或者帖子
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DislikeNews(this XiaoheiheClient xhh, ulong linkID)
        {
            return await xhh.LikeNewsAction(linkID, AwardType.Cancel).ConfigureAwait(false);
        }

        /// <summary>
        /// 取消点赞文章或者新闻或者帖子
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DislikeNews(this XiaoheiheClient xhh, ulong linkID, int index)
        {
            return await xhh.LikeNewsAction(linkID, index, AwardType.Cancel).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞点踩或者取消点赞评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="commentID"></param>
        /// <param name="like"></param>
        /// <returns></returns>
        private static async Task<BasicResponse> LikeCommentAction(this XiaoheiheClient xhh, ulong linkID, uint commentID, SupportType like)
        {
            return await xhh.LikeCommentAction(linkID, commentID, -1, like).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞点踩或者取消点赞评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <param name="like"></param>
        /// <returns></returns>
        private static async Task<BasicResponse> LikeCommentAction(this XiaoheiheClient xhh, ulong linkID, uint commentID, int index, SupportType like)
        {
            string subPath = "/bbs/app/comment/support";

            string hSrc = Utils.Base64Encode($"bbs_app_feeds__link_id__{linkID}");

            Dictionary<string, string> extraParams = new(1)
            {
                { "index", index.ToString() },
            };

            Dictionary<string, string> formData = new(3)
            {
                { "h_src", hSrc },
                { "comment_id", commentID.ToString() },
                { "support_type", ((int)like).ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = await xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, extraParams, content).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 点赞回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> LikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID)
        {
            return await xhh.LikeCommentAction(linkID, commentID, SupportType.Like).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> LikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID, int index)
        {
            return await xhh.LikeCommentAction(linkID, commentID, index, SupportType.Like).ConfigureAwait(false);
        }

        /// <summary>
        /// 点踩回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DislikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID)
        {
            return await xhh.LikeCommentAction(linkID, commentID, SupportType.Dislike).ConfigureAwait(false);
        }

        /// <summary>
        /// 点踩回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DislikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID, int index)
        {
            return await xhh.LikeCommentAction(linkID, commentID, index, SupportType.Dislike).ConfigureAwait(false);
        }

        /// <summary>
        /// 取消点赞/点踩回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> CanclelikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID)
        {
            return await xhh.LikeCommentAction(linkID, commentID, SupportType.Cancel).ConfigureAwait(false);
        }

        /// <summary>
        /// 取消点赞/点踩回复
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> CanclelikeComment(this XiaoheiheClient xhh, uint linkID, uint commentID, int index)
        {
            return await xhh.LikeCommentAction(linkID, commentID, index, SupportType.Cancel).ConfigureAwait(false);
        }

        /// <summary>
        /// 点赞或者取消点赞游戏评测
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="like"></param>
        /// <returns></returns>
        private static async Task<BasicResponse> LikeGameCommentAction(this XiaoheiheClient xhh, uint linkID, AwardType like)
        {
            string subPath = "/bbs/app/link/game/comment/up";

            string hSrc = Utils.Base64Encode($"follow__link_id__{linkID}");

            Dictionary<string, string> formData = new(3)
            {
                { "link_id", linkID.ToString() },
                { "support_type", ((int)like).ToString() },
                { "h_src", hSrc },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = await xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, content).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 点赞游戏评测
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> LikeGameComment(this XiaoheiheClient xhh, uint linkID)
        {
            return await xhh.LikeGameCommentAction(linkID, AwardType.Like).ConfigureAwait(false);
        }

        /// <summary>
        /// 取消点赞游戏评测
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <returns></returns>
        public static async Task<BasicResponse> DislikeGameComment(this XiaoheiheClient xhh, uint linkID)
        {
            return await xhh.LikeGameCommentAction(linkID, AwardType.Cancel).ConfigureAwait(false);
        }
    }
}
