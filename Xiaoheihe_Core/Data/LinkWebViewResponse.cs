using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class LinkWebViewResponse : BasicResponse<LinkWebViewResultData>
    {
    }

    public sealed class LinkWebViewResultData : BasicResultData
    {
        [JsonPropertyName("show_user_subscribe_botton")]
        public byte ShowUserSubscribeBotton { get; set; }

        [JsonPropertyName("link")]
        public WebViewLinkData Link { get; set; } = new();
    }

    public sealed class WebViewLinkData
    {
        [JsonPropertyName("special_type")]
        public uint SpecialType { get; set; }

        [JsonPropertyName("declaration")]
        public string Declaration { get; set; } = "";

        [JsonPropertyName("is_article")]
        public byte IsArticle { get; set; }

        [JsonPropertyName("feedback")]
        public HashSet<FeedbackData> Feedback { get; set; } = new();

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("battery")]
        public BatteryData Battery { get; set; } = new();

        [JsonPropertyName("linkid")]
        public uint LinkID { get; set; }

        [JsonPropertyName("topics")]
        public HashSet<TopicData> Topics { get; set; } = new();

        [JsonPropertyName("original")]
        public byte Original { get; set; }

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("release_info")]
        public ReleaseInfoData ReleaseInfo { get; set; } = new();

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("content")]
        public HashSet<ContentData> Content { get; set; } = new();

        [JsonPropertyName("link_tag")]
        public uint LinkTag { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; } = "";

        [JsonPropertyName("poster")]
        public HeyboxUserData Poster { get; set; } = new();

        [JsonPropertyName("h_src")]
        public string HSrc { get; set; } = "";

        [JsonPropertyName("current_user")]
        public HeyboxUserData CurrentUser { get; set; } = new();

        public override string? ToString()
        {
            return $"[{LinkID}] {Title}";
        }
    }

    public sealed class FeedbackData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("options")]
        public HashSet<FeedbackOptionData> Options { get; set; } = new();

        [JsonPropertyName("cate")]
        public string Cate { get; set; } = "";

        public override string? ToString()
        {
            return $"{Cate} {Text}";
        }
    }

    public sealed class FeedbackOptionData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("reason")]
        public uint Reason { get; set; }

        public override string? ToString()
        {
            return $"{Reason} {Text}";
        }
    }

    public sealed class ReleaseInfoData
    {
        [JsonPropertyName("release_val")]
        public uint ReleaseVal { get; set; }

        [JsonPropertyName("current_val")]
        public uint CurrentVal { get; set; }

        [JsonPropertyName("voted")]
        public byte Voted { get; set; }

        public override string? ToString()
        {
            return $"{ReleaseVal} {CurrentVal} {Voted}";
        }
    }

    public sealed class ContentData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [JsonPropertyName("width")]
        public string Width { get; set; } = "";

        [JsonPropertyName("height")]
        public string Height { get; set; } = "";

        public override string? ToString()
        {
            return $"{Type} {Text ?? Url}";
        }
    }
}
