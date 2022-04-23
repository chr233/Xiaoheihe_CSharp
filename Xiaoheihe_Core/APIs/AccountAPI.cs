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
        public static AccountInfoResponse GetAccountInfo(this XiaoheiheClient xhh)
        {
            string subPath = "/account/info/";

            AccountInfoResponse response = xhh.BasicRequest<AccountInfoResponse>(HttpMethod.Get, subPath);

            return response;
        }
    }
}
