using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class UserAPI
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
        /// 关注用户
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static BasicResponse FollowUser(this XiaoheiheClient xhh, uint userID)
        {
            string subPath = "/bbs/app/profile/follow/user";

            Dictionary<string, string> formData = new(1)
            {
                { "following_id", userID.ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            FollowListResponse response = xhh.BasicRequest<FollowListResponse>(HttpMethod.Post, subPath, content);

            return response;
        }

        /// <summary>
        /// 取关用户
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static BasicResponse UnfollowUser(this XiaoheiheClient xhh, uint userID)
        {
            string subPath = "/bbs/app/profile/follow/user/cancel";

            Dictionary<string, string> formData = new(1)
            {
                { "following_id", userID.ToString() },
            };

            FormUrlEncodedContent content = new(formData);

            FollowListResponse response = xhh.BasicRequest<FollowListResponse>(HttpMethod.Post, subPath, content);

            return response;
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

            Dictionary<string, string> extendParams = new(3)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            UserEventsResponse response = xhh.BasicRequest<UserEventsResponse>(HttpMethod.Get, subPath, extendParams);

            return response;
        }

        /// <summary>
        /// 获取自己的发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh)
        {
            return xhh.GetUserPostLinks(xhh.HeyboxID);
        }


        /// <summary>
        /// 获取用户发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.GetUserPostLinks(userID, 0);
        }

        /// <summary>
        /// 获取用户发帖列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static PostLinkResponse GetUserPostLinks(this XiaoheiheClient xhh, uint userID, uint offset)
        {
            string subPath = "/bbs/app/profile/user/link/list";

            Dictionary<string, string> extendParams = new(3)
            {
                { "userid", userID.ToString() },
                { "offset", offset.ToString() },
                { "limit", "30" },
            };

            PostLinkResponse response = xhh.BasicRequest<PostLinkResponse>(HttpMethod.Get, subPath, extendParams);

            return response;
        }


    }
}
