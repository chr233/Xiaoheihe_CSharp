using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class GameAPI
    {
        /// <summary>
        /// 获取Steam平台游戏详情
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="appid"></param>
        /// <returns></returns>
        public static async Task<GameDetailResponse> GetGameDetail(this XiaoheiheClient xhh, ulong appid)
        {
            return await xhh.GetGameDetail(appid, "steam").ConfigureAwait(false);
        }

        /// <summary>
        /// 获取游戏详情
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="appid"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public static async Task<GameDetailResponse> GetGameDetail(this XiaoheiheClient xhh, ulong appid, string platform)
        {
            string subPath = "/game/get_game_detail/";

            Dictionary<string, string> extraParams = new(3)
            {
                { "h_src", "es_general_v1" },
                { "appid", appid.ToString() },
                { "platf", platform },
            };

            GameDetailResponse response = await xhh.BasicRequest<GameDetailResponse>(HttpMethod.Get, subPath, extraParams).ConfigureAwait(false);

            return response;
        }
    }
}
