using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaoheihe_Core.Data;
using Xiaoheihe_Core;

namespace Xiaoheihe_Core.APIs
{
    public static class ShareAPI
    {
        /// <summary>
        /// 分享新闻
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="linkID"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool ShareNews(this XiaoheiheClient xhh, uint linkID, int index)
        {
            string hSrc = Utils.Base64Encode($"news_feeds_-1__link_id__{linkID}");

            BasicResponse ShareClick()
            {
                string subPath = "/bbs/app/link/share/click";

                Dictionary<string, string> extraParams = new(3)
                {
                    { "h_src", hSrc },
                    { "link_id", linkID.ToString() },
                    { "index", index.ToString() },
                };

                BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams);

                return response;
            }

            BasicResponse ShareCheck()
            {
                string subPath = "/task/shared/";

                Dictionary<string, string> extraParams = new(2)
                {
                    { "h_src", hSrc },
                    { "shared_type", "normal" },
                };

                BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams);

                return response;
            }

            try
            {
                ShareClick();
                ShareCheck();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 分享评论
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        public static BasicResponse ShareComment(this XiaoheiheClient xhh)
        {
            string subPath = "/task/shared/";

            Dictionary<string, string> extraParams = new(1)
            {
                { "shared_type", "BBSComment" },
            };

            BasicResponse response = xhh.BasicRequest<BasicResponse>(HttpMethod.Get, subPath, extraParams);

            return response;
        }
    }
}
