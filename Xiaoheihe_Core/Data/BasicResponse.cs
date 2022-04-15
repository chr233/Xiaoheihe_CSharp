using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xiaoheihe_CShape.Data
{
    public class BasicResponse
    {
        //{"status":"ok","msg":"","version":"1.0","result":{"state":"ignore"}
        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("msg")]
        public string Message { get; set; } = "";

        [JsonPropertyName("version")]
        public string Version { get; set; } = "";
    }
}
