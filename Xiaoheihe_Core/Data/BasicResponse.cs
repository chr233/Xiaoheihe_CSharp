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

        public override string? ToString()
        {
            return $"{Status} \"{Message}\" {Version}";
        }
    }

    public class BasicResponse<T> : BasicResponse where T : BasicResultData
    {
        [JsonPropertyName("result")]
        public T? Result { get; set; }

        public override string? ToString()
        {
            return $"{Status} \"{Message}\" {Version} {typeof(T)}";
        }
    }

    public abstract class BasicResultData
    {
    }
}
