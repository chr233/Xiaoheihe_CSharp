using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class ImageUploadTokenResponse : BasicResponse<ImageUploadTokenResultData>
    {
    }

    public sealed class ImageUploadTokenResultData : BasicResultData
    {
        [JsonPropertyName("credentials")]
        public CredentialsData Credentials { get; set; } = new();

        [JsonPropertyName("expiredTime")]
        public DateTime ExpiredTime { get; set; }

        [JsonPropertyName("expiration")]
        public string Expiration { get; set; } = "";

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("requestId")]
        public string RequestId { get; set; } = "";
    }

    public sealed class CredentialsData
    {
        [JsonPropertyName("tmpSecretKey")]
        public string TmpSecretKey { get; set; } = "";

        [JsonPropertyName("tmpSecretId")]
        public string TmpSecretId { get; set; } = "";

        [JsonPropertyName("sessionToken")]
        public string SessionToken { get; set; } = "";
    }
}
