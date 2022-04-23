using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class FollowListResponse : BasicResponse
    {
        [JsonPropertyName("follow_cnt")]
        public FollowCountData FollowSum { get; set; } = new();

        [JsonPropertyName("follow_list")]
        public HashSet<FollowListUserData> FollowList { get; set; } = new();

        [JsonPropertyName("summary_url")]
        public HashSet<string> SummaryUrl { get; set; } = new();

    }

    public sealed class FollowCountData
    {
        /// <summary>
        /// 粉丝
        /// </summary>
        [JsonPropertyName("fan_num")]
        public uint FollowerCount { get; set; } = new();

        /// <summary>
        /// 关注的人
        /// </summary>
        [JsonPropertyName("follow_num")]
        public uint FollowingCount { get; set; } = new();

        public override string? ToString()
        {
            return $"粉丝:{FollowerCount} 关注:{FollowingCount}";
        }
    }

    public class FollowListUserData : XhhUserData
    {
        [JsonPropertyName("is_follow")]
        public FollowStatus IsFollow { get; set; } = new();

        [JsonPropertyName("follow_at")]
        public DateTime FollowAt { get; set; } = new();
    }
}
