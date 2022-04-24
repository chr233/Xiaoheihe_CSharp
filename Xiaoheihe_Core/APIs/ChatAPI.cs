using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class ChatAPI
    {
        /// <summary>
        /// 获取和指定用户的聊天记录
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static UserMessageResponse GetUserMessageList(this XiaoheiheClient xhh, uint userID)
        {
            return xhh.GetUserMessageList(userID, 0, false);
        }

        /// <summary>
        /// 获取和指定用户的聊天记录
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="pointer">时间指针</param>
        /// <param name="isNewer">是不是newer, 否则为older</param>
        /// <returns></returns>
        public static UserMessageResponse GetUserMessageList(this XiaoheiheClient xhh, uint userID, uint pointer, bool isNewer)
        {
            string subPath = "/chat/get_message_list/";

            Dictionary<string, string> extendParams = new(2)
            {
                { "userid", userID.ToString() },
            };

            if (pointer != 0)
            {
                extendParams.Add(isNewer ? "newer" : "older", pointer.ToString());
            }

            UserMessageResponse response = xhh.BasicRequest<UserMessageResponse>(HttpMethod.Get, subPath, extendParams);

            return response;
        }

        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static BasicResponse SendMessage(this XiaoheiheClient xhh, uint userID, string text)
        {
            return xhh.SendMessage(userID, text, "");
        }

        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="userID"></param>
        /// <param name="text">消息内容</param>
        /// <param name="img">图片网址</param>
        /// <returns></returns>
        public static BasicResponse SendMessage(this XiaoheiheClient xhh, uint userID, string text, string img)
        {
            string subPath = "/chat/send_message/";

            Dictionary<string, string> extendParams = new(1)
            {
                { "userid", userID.ToString() },
            };

            Dictionary<string, string> formData = new(2)
            {
                { "text", text },
                { "img", img },
            };

            FormUrlEncodedContent content = new(formData);

            BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Post, subPath, extendParams, content);

            return response;
        }
    }
}
