using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class FriendListResponse : BasicResponse<FriendListResultData>
    {
    }

    public sealed class FriendListResultData : BasicResultData
    {
        [JsonPropertyName("filter")]
        public FriendFilterData Filter { get; set; } = new();

        [JsonPropertyName("summary_url")]
        public HashSet<string> SummaryUrl { get; set; } = new();

        [JsonPropertyName("friends")]
        public HashSet<FriendData> Friends { get; set; } = new();

        [JsonPropertyName("follow_cnt")]
        public FollowCountData FollowSum { get; set; } = new();

        [JsonPropertyName("friends_count")]
        public uint FriendsCount { get; set; }

        public override string? ToString()
        {
            return FollowSum.ToString();
        }
    }


    public sealed class FriendFilterData
    {
        [JsonPropertyName("values")]
        public HashSet<FilterValueData> Values { get; set; } = new();
        public override string? ToString()
        {
            return Values.ToString();
        }
    }


    public sealed class FilterValueData
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = "";

        [JsonPropertyName("value")]
        public string Value { get; set; } = "";
        public override string? ToString()
        {
            return $"{Key} : {Value}";
        }
    }

    public sealed class FriendData
    {
        [JsonPropertyName("steamid")]
        public string SteamID { get; set; } = "";

        [JsonPropertyName("has_heybox")]
        public byte HasHeybox { get; set; }

        [JsonPropertyName("is_steam")]
        public byte IsSteam { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";

        [JsonPropertyName("heybox_info")]
        public HeyboxUserFriendListData HeyboxInfo { get; set; } = new();

        [JsonPropertyName("nickname")]
        public string NickName { get; set; } = "";
        public override string? ToString()
        {
            return $"{HeyboxInfo} [{SteamID}] {NickName}";
        }
    }
}
