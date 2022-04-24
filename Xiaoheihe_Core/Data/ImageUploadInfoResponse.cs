using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class ImageUploadInfoResponse : BasicResponse<ImageUploadInfoResultData>
    {
    }

    public sealed class ImageUploadInfoResultData : BasicResultData
    {
        [JsonPropertyName("keys")]
        public HashSet<string> Keys { get; set; } = new();

        [JsonPropertyName("host")]
        public string Host { get; set; } = "";

        [JsonPropertyName("bucket")]
        public string Bucket { get; set; } = "";
    }
}
