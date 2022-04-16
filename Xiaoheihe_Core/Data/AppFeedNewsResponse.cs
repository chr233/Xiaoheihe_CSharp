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
        public HashSet<LinkData> Links { get; set; } = new();
    }

    public sealed class LinkData
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("h_src")]
        public string Hsrc { get; set; } = "";

        [JsonPropertyName("up")]
        public int Up { get; set; }

        [JsonPropertyName("comment_num")]
        public int CommentNum { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("special_type")]
        public int SpecialType { get; set; }

        [JsonPropertyName("link_award_num")]
        public int LinkAwardNum { get; set; }

        [JsonPropertyName("content_type")]
        public int ContentType { get; set; }

        [JsonPropertyName("imgs")]
        public HashSet<string> Imgs { get; set; } = new();

        [JsonPropertyName("modify_at")]
        public DateTime ModifyAt { get; set; }

        [JsonPropertyName("click")]
        public int Click { get; set; }

        [JsonPropertyName("down")]
        public int Down { get; set; }

        [JsonPropertyName("forward_num")]
        public int ForwardNum { get; set; }

        [JsonPropertyName("follow_status")]
        public int FollowStatus { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("linkid")]
        public int LinkID { get; set; }

        [JsonPropertyName("userid")]
        public int UserID { get; set; }

        [JsonPropertyName("is_web")]
        public int IsWeb { get; set; }

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("formated_time")]
        public string FormatedTime { get; set; } = "";

        [JsonPropertyName("link_tag")]
        public int LinkTag { get; set; }

        [JsonPropertyName("has_video")]
        public int HasVideo { get; set; }

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
