using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public class PostLinkResponse : BasicResponse
    {
        [JsonPropertyName("post_links")]
        public HashSet<PostLinkData> PostLinks { get; set; } = new();

        [JsonPropertyName("user")]
        public XhhUserDetailData User { get; set; } = new();

        [JsonPropertyName("total_page")]
        public uint TotalPage { get; set; }
    }

    public class PostLinkData
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("h_src")]
        public string Hsrc { get; set; } = "";

        [JsonPropertyName("forward_num")]
        public uint ForwardCount { get; set; }

        [JsonPropertyName("comment_num")]
        public uint CommentCount { get; set; }

        [JsonPropertyName("topics")]
        public HashSet<TopicData> Topics { get; set; } = new();

        [JsonPropertyName("is_web")]
        public byte IsWeb { get; set; }

        [JsonPropertyName("special_type")]
        public uint SpecialType { get; set; }

        [JsonPropertyName("is_award_link")]
        public byte IsAwardLink { get; set; }

        [JsonPropertyName("link_award_num")]
        public uint LinkAwardCount { get; set; }

        [JsonPropertyName("imgs")]
        public HashSet<string> Imgs { get; set; } = new();

        [JsonPropertyName("modify_at")]
        public DateTime ModifyAt { get; set; }

        [JsonPropertyName("click")]
        public uint Click { get; set; }

        [JsonPropertyName("is_favour")]
        public byte IsFavour { get; set; }

        [JsonPropertyName("down")]
        public uint Down { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("linkid")]
        public uint LinkID { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("userid")]
        public uint Userid { get; set; }

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("link_tag")]
        public int LinkTag { get; set; }

        [JsonPropertyName("has_video")]
        public byte HasVideo { get; set; }

        [JsonPropertyName("link_type")]
        public int LinkType { get; set; }

        public override string? ToString()
        {
            return $"[{LinkID}] {Title} {Description}";
        }
    }

    public sealed class TopicData
    {
        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("topic_id")]
        public uint TopicID { get; set; }

        public override string? ToString()
        {
            return $"[{TopicID}] {Name}";
        }
    }
}
