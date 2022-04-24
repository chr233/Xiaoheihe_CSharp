using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class UserDetailAPI
    {
        /// <summary>
        /// 获取自己的关注的人列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowingList(this XiaoheiheClient xhh)
        {
            return xhh.GetFollowingList(xhh.HeyboxID, 0);
        }

        /// <summary>
        /// 获取关注的人列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowingList(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.GetFollowingList(userID, 0);
        }

        /// <summary>
        /// 获取关注的人列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowingList(this XiaoheiheClient xhh, uint userID, uint offset)
        {
            string subPath = "/bbs/app/profile/following/list";

            Dictionary<string, string> extraParams = new(3)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            FollowListResponse response = xhh.BasicRequest<FollowListResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }

        /// <summary>
        /// 获取自己的粉丝列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowerList(this XiaoheiheClient xhh)
        {
            return xhh.GetFollowerList(xhh.HeyboxID, 0);
        }

        /// <summary>
        /// 获取粉丝列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowerList(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.GetFollowerList(userID, 0);
        }

        /// <summary>
        /// 获取粉丝列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static FollowListResponse GetFollowerList(this XiaoheiheClient xhh, uint userID, uint offset)
        {
            string subPath = "/bbs/app/profile/follower/list";

            Dictionary<string, string> extraParams = new(3)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            FollowListResponse response = xhh.BasicRequest<FollowListResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }

        /// <summary>
        /// 关注或者取关用户
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="isFollow"></param>
        /// <returns></returns>
        private static BasicResponse FollowAction(this XiaoheiheClient xhh, uint userID, bool isFollow)
        {
            string subPath = isFollow ? "/bbs/app/profile/follow/user" : "/bbs/app/profile/follow/user/cancel";

            Dictionary<string, string> formData = new(1)
            {
                { "following_id", userID.ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            FollowListResponse response = xhh.BasicRequest<FollowListResponse>(HttpMethod.Post, subPath, content);

            return response;
        }

        /// <summary>
        /// 关注用户
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static BasicResponse FollowUser(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.FollowAction(userID, true);
        }

        /// <summary>
        /// 取关用户
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static BasicResponse UnfollowUser(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.FollowAction(userID, false);
        }

        /// <summary>
        /// 获取用户动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static UserEventsResponse GetUserEvents(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.GetUserEvents(userID, 0);
        }

        /// <summary>
        /// 获取用户动态
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static UserEventsResponse GetUserEvents(this XiaoheiheClient xhh, uint userID, uint offset)
        {
            string subPath = "/bbs/app/profile/events";

            Dictionary<string, string> extraParams = new(3)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            UserEventsResponse response = xhh.BasicRequest<UserEventsResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }

        /// <summary>
        /// 获取自己的发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh, bool onlyArticle)
        {
            return xhh.GetUserPostLinks(xhh.HeyboxID, onlyArticle);
        }


        /// <summary>
        /// 获取用户发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh, uint userID, bool onlyArticle)
        {
            return xhh.GetUserPostLinks(userID, 0, onlyArticle);
        }


        /// <summary>
        /// 获取用户发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="offset"></param>
        /// <param name="onlyArticle">仅显示文章</param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh, uint userID, uint offset, bool onlyArticle)
        {
            string subPath = "/bbs/app/profile/user/link/list";

            Dictionary<string, string> extraParams = new(4)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            if (onlyArticle)
            {
                extraParams.Add("list_type", "article");
            }

            PostLinkResponse response = xhh.BasicRequest<PostLinkResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }

        /// <summary>
        /// 获取自己的评论列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="onlyCy"></param>
        /// <returns></returns>
        public static CommentListResponse GetUserComments(this XiaoheiheClient xhh, bool onlyCy)
        {
            return xhh.GetUserComments(xhh.HeyboxID, onlyCy, 0);
        }

        /// <summary>
        /// 获取用户评论列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="onlyCy"></param>
        /// <returns></returns>
        public static CommentListResponse GetUserComments(this XiaoheiheClient xhh, uint userID, bool onlyCy)
        {
            return xhh.GetUserComments(userID, onlyCy, 0);
        }

        /// <summary>
        /// 获取用户评论列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="onlyCy">是否插眼</param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static CommentListResponse GetUserComments(this XiaoheiheClient xhh, uint userID, bool onlyCy, uint offset)
        {
            string subPath = "/bbs/app/profile/bbs/comment/list";

            Dictionary<string, string> extraParams = new(4)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
                { "only_cy", onlyCy ? "1" : "0" },
            };

            CommentListResponse response = xhh.BasicRequest<CommentListResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }


    }
}
