using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.Request
{
    public static class AccountAPI
    {
        public static AccountInfoResponse GetAccountInfo(this XiaoheiheClient xhh)
        {
            string subPath = "/account/info/";

            AccountInfoResponse response = xhh.BasicRequest<AccountInfoResponse>
                (HttpMethod.Get, subPath, null, null);

            return response;
        }
    }
}
