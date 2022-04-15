using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public class BasicResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("msg")]
        public string Message { get; set; } = "";

        [JsonPropertyName("version")]
        public string Version { get; set; } = "";
    }

    public class BasicResponse<T> : BasicResponse
    {
        [JsonPropertyName("result")]
        public T? Result { get; set; } = default;
    }
}
