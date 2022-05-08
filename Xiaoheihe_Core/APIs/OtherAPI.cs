using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaoheihe_Core;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class OtherAPI
    {
        internal static async Task<BasicResponse> MallLink(this XiaoheiheClient xhh, uint linkID)
        {
            string subPath = "/mall/link/related/sku/";

            Dictionary<string, string> extraParams = new(1)
            {
                { "link_id", linkID.ToString() },
            };

            BasicResponse response = await xhh.BasicRequestAsync<BasicResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }
    }
}
