using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    /// <summary>
    /// 响应基类
    /// </summary>
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

    /// <summary>
    /// 响应基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BasicResponse<T> : BasicResponse
    {
        [JsonPropertyName("result")]
        public T? Result { get; set; }

        public override string? ToString()
        {
            return $"{Status} \"{Message}\" {Version} {typeof(T)}";
        }
    }

    /// <summary>
    /// 响应Result基类
    /// </summary>
    public abstract class BasicResultData
    {
    }
}
