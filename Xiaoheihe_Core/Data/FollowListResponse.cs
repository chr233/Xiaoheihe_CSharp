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

        public override string? ToString()
        {
            return FollowSum.ToString();
        }
    }

    public class FollowListUserData : HeyboxUserData
    {
        [JsonPropertyName("is_follow")]
        public FollowStatus IsFollow { get; set; } = FollowStatus.Unknown;

        [JsonPropertyName("follow_at")]
        public DateTime FollowAt { get; set; }

        public override string? ToString()
        {
            return $"{IsFollow} {FollowAt}";
        }
    }
}
