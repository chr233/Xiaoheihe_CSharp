using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class PostLinkResponse : BasicResponse<PostLinkResultData>
    {
    }

    public sealed class PostLinkResultData : BasicResultData
    {
        [JsonPropertyName("reply_push_state")]
        public ReplyPushStateData ReplyPushState { get; set; } = new();
    }
}
