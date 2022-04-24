using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
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
