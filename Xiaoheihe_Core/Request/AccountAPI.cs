using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Xiaoheihe_CShape.Data;

namespace Xiaoheihe_CShape.Request
{
    public static class AccountAPI
    {
        public static AccountInfoResponse GetAccountInfo(this XiaoheiheClient xhh)
        {
            const string subPath = "/account/info/";

            Uri uri = xhh.BuildQueryParams(subPath, null);

            HttpRequestMessage request = new(HttpMethod.Get, uri);

            AccountInfoResponse? response = xhh.BasicRequest<AccountInfoResponse>(request);

            return response??new();
        }


    }
}
