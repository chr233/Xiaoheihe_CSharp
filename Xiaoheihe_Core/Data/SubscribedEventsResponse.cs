using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class SubscribedEventsResponse : BasicResponse<SubscribedEventsResult>
    {
    }

    public sealed class SubscribedEventsResult : BasicResultData
    {
        [JsonPropertyName("moments")]
        public HashSet<MonentData> Moments { get; set; } = new();
    }



    public sealed class MonentData
    {
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; } = default;

        [JsonPropertyName("link")]
        public LinkData Link { get; set; } = new();

        [JsonPropertyName("user")]
        public AccountDetailData User { get; set; } = new();

        [JsonPropertyName("level_info")]
        public LevelInfoData LevelInfo { get; set; } = new();

        [JsonPropertyName("content_type")]
        public string ContentType { get; set; } = "";

        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        [JsonPropertyName("group_type")]
        public string GroupType { get; set; } = "";

        public override string? ToString()
        {
            return $"[{ContentType}] {Link} {Timestamp}";
        }
    }
}
