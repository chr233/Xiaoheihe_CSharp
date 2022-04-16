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
        public int Up { get; set; } = 0;

        [JsonPropertyName("comment_num")]
        public int CommentNum { get; set; } = 0;

        [JsonPropertyName("special_type")]
        public int SpecialType { get; set; } = 0;

        [JsonPropertyName("link_award_num")]
        public int LinkAwardNum { get; set; } = 0;

        [JsonPropertyName("content_type")]
        public int ContentType { get; set; } = 0;

        [JsonPropertyName("imgs")]
        public HashSet<string> Imgs { get; set; } = new();

        [JsonPropertyName("click")]
        public int Click { get; set; } = 0;

        [JsonPropertyName("down")]
        public int Down { get; set; } = 0;

        [JsonPropertyName("forward_num")]
        public int ForwardNum { get; set; } = 0;

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("linkid")]
        public int LinkID { get; set; } = 0;

        [JsonPropertyName("userid")]
        public int UserID { get; set; } = 0;

        [JsonPropertyName("is_web")]
        public int IsWeb { get; set; } = 0;

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("formated_time")]
        public string FormatedTime { get; set; } = "";

        [JsonPropertyName("link_tag")]
        public int LinkTag { get; set; } = 0;

        [JsonPropertyName("has_video")]
        public int HasVideo { get; set; } = 0;

        [JsonPropertyName("post_tag")]
        public string PostTag { get; set; } = "";

        [JsonPropertyName("link_type")]
        public int LinkType { get; set; } = 0;

        [JsonPropertyName("thumbs")]
        public HashSet<string> Thumbs { get; set; } = new();

        public override string? ToString()
        {
            return $"[{ContentType}] {LinkID} {Title}";
        }
    }
}
