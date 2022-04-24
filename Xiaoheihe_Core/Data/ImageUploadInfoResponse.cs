using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public class ImageUploadInfoResponse : BasicResponse<ImageUploadInfoResultData>
    {
    }

    public class ImageUploadInfoResultData : BasicResultData
    {
        [JsonPropertyName("keys")]
        public HashSet<string> Keys { get; set; } = new();

        [JsonPropertyName("host")]
        public string Host { get; set; } = "";

        [JsonPropertyName("bucket")]
        public string Bucket { get; set; } = "";
    }
}
