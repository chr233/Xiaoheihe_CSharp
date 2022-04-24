using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class CommentListResponse : BasicResponse<HashSet<CommentListResultData>>
    {
        [JsonPropertyName("total_page")]
        public uint TotalPage { get; set; }

        [JsonPropertyName("user")]
        public XhhUserDetailData User { get; set; } = new();

    }

    public sealed class CommentListResultData : BasicResultData
    {
        [JsonPropertyName("comment_type")]
        public int CommentType { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("comment_id")]
        public ulong CommentID { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("link")]
        public NewsLinkData Link { get; set; } = new();

        [JsonPropertyName("root_comment_id")]
        public ulong RootCommentID { get; set; }

        [JsonPropertyName("child_num")]
        public uint ChildCount { get; set; }

        [JsonPropertyName("has_img")]
        public byte HasImg { get; set; }

        [JsonPropertyName("is_cy")]
        public byte IsCy { get; set; }

        public override string? ToString()
        {
            if (CommentID == RootCommentID)
            {
                return $"[{CommentID}] {CommentType} {Text}";
            }
            else
            {
                return $"[{RootCommentID}=>{CommentID}] {CommentType} {Text}";
            }
        }
    }

    public sealed class CommentLinkData
    {
        [JsonPropertyName("link_tag")]
        public int LinkTag { get; set; }

        [JsonPropertyName("thumbs")]
        public HashSet<string> Thumbs { get; set; } = new();

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("user")]
        public UsernameData User { get; set; } = new();

        [JsonPropertyName("topic_id")]
        public int TopicID { get; set; }

        [JsonPropertyName("has_video")]
        public byte HasVideo { get; set; }

        [JsonPropertyName("id")]
        public ulong CommentID { get; set; }

        public override string? ToString()
        {
            return $"[{CommentID}] {Title} {User}";
        }
    }

    public sealed class UsernameData
    {
        [JsonPropertyName("username")]
        public string Username { get; set; } = "";

        public override string? ToString()
        {
            return Username;
        }
    }
}
