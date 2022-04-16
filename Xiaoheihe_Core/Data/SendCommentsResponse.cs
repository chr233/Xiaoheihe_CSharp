using System.ComponentModel.Design;
using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class SendCommentsResponse : BasicResponse<SendCommentsResultData>
    {
    }

    public sealed class SendCommentsResultData : BasicResultData
    {
        [JsonPropertyName("comment")]
        public CommentDataData Comment { get; set; } = new();

        [JsonPropertyName("reply_push_state")]
        public ReplyPushStateData ReplyPushState { get; set; } = new();
    }

    public class CommentDataData
    {
        [JsonPropertyName("comment")]
        public HashSet<CommentData> Comment { get; set; } = new();
    }

    public sealed class CommentData
    {
        [JsonPropertyName("is_support")]
        public int IsSupport { get; set; }

        [JsonPropertyName("replyuser")]
        public XhhUserData? ReplyUser { get; set; }

        [JsonPropertyName("has_more")]
        public int HasMore { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("floor_num")]
        public int FloorNum { get; set; }

        [JsonPropertyName("up")]
        public int Up { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; } = default;

        [JsonPropertyName("is_link_owner")]
        public int IsLinkOwner { get; set; }

        [JsonPropertyName("user")]
        public XhhUserData User { get; set; } = new();

        [JsonPropertyName("commentid")]
        public long Commentid { get; set; }

        [JsonPropertyName("child_num")]
        public int ChildNum { get; set; }

        [JsonPropertyName("is_cy")]
        public int IsCy { get; set; }

        public override string? ToString()
        {
            return $"[{User}] {Text}";
        }
    }

    public sealed class ReplyPushStateData
    {
        [JsonPropertyName("push_type")]
        public int PushType { get; set; }

        [JsonPropertyName("push_state")]
        public int PushState { get; set; }

        [JsonPropertyName("push_type_desc")]
        public string PushTypeDesc { get; set; } = "";

        public override string? ToString()
        {
            return PushTypeDesc;
        }
    }
}
