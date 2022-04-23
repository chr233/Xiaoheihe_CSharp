using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class AppFeedNewsResponse : BasicResponse<AppFeedNewsResultData>
    {
    }

    public sealed class AppFeedNewsResultData : BasicResultData
    {
        [JsonPropertyName("group")]

        public string Group { get; set; } = "";

        [JsonPropertyName("links")]
        public HashSet<NewsLinkData> Links { get; set; } = new();
    }

    public sealed class NewsLinkData
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("h_src")]
        public string Hsrc { get; set; } = "";

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("comment_num")]
        public uint CommentCount { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("special_type")]
        public int SpecialType { get; set; }

        /// <summary>点赞数量, 跟Up是一样的</summary>
        [JsonPropertyName("link_award_num")]
        public uint LinkAwardCount { get; set; }

        [JsonPropertyName("content_type")]
        public int ContentType { get; set; }

        [JsonPropertyName("imgs")]
        public HashSet<string> Imgs { get; set; } = new();

        [JsonPropertyName("modify_at")]
        public DateTime ModifyAt { get; set; }

        [JsonPropertyName("click")]
        public uint Click { get; set; }

        [JsonPropertyName("down")]
        public uint Down { get; set; }

        [JsonPropertyName("forward_num")]
        public int ForwardCount { get; set; }

        [JsonPropertyName("follow_status")]
        public FollowStatus FollowStatus { get; set; } = FollowStatus.Unknown;

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("linkid")]
        public ulong LinkID { get; set; }

        [JsonPropertyName("userid")]
        public uint UserID { get; set; }

        [JsonPropertyName("is_web")]
        public byte IsWeb { get; set; }

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("formated_time")]
        public string FormatedTime { get; set; } = "";

        [JsonPropertyName("link_tag")]
        public int LinkTag { get; set; }

        [JsonPropertyName("has_video")]
        public byte HasVideo { get; set; }

        [JsonPropertyName("post_tag")]
        public string PostTag { get; set; } = "";

        [JsonPropertyName("link_type")]
        public int LinkType { get; set; }

        [JsonPropertyName("thumbs")]
        public HashSet<string> Thumbs { get; set; } = new();

        public override string? ToString()
        {
            return $"[{ContentType}] {LinkID} {Title}";
        }
    }
}
