using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class AccountAPI
    {
        /// <summary>
        /// 获取账号详情
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<AccountInfoResponse> GetAccountInfo(this XiaoheiheClient xhh)
        {
            string subPath = "/account/info/";

            AccountInfoResponse response = await xhh.BasicRequest<AccountInfoResponse>(HttpMethod.Get, subPath).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取签到日历
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<TaskSignListResponse> GetTaskSignList(this XiaoheiheClient xhh)
        {
            string subPath = "/task/sign_list/";

            TaskSignListResponse response = await xhh.BasicRequest<TaskSignListResponse>(HttpMethod.Get, subPath).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取任务列表
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<TaskListResponse> GetTaskList(this XiaoheiheClient xhh)
        {
            string subPath = "/task/list/";

            TaskListResponse response = await xhh.BasicRequest<TaskListResponse>(HttpMethod.Get, subPath).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 每日签到
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static async Task<TaskSignResponse> TaskSign(this XiaoheiheClient xhh)
        {
            string subPath = "/task/sign/";

            TaskSignResponse response = await xhh.BasicRequest<TaskSignResponse>(HttpMethod.Get, subPath).ConfigureAwait(false);

            return response;
        }
    }
}
