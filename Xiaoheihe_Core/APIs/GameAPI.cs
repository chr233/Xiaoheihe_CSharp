﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class GameAPI
    {
        public static async Task< GameDetailResponse> GetGameDetail(this XiaoheiheClient xhh, ulong appid)
        {
            return await xhh.GetGameDetail(appid,"steam").ConfigureAwait(false);
        }

        public static async Task< GameDetailResponse> GetGameDetail(this XiaoheiheClient xhh,ulong appid,string platform)
        {
            string subPath = "/game/get_game_detail/";

            Dictionary<string, string> extraParams = new(3)
            {
                { "h_src", "es_general_v1" },
                { "appid", appid.ToString()},
                { "platf", platform },
            };

            GameDetailResponse response =  await xhh.BasicRequest<GameDetailResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }
    }
}
