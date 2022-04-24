using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class KeyValueData
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = "";

        [JsonPropertyName("value")]
        public string Value { get; set; } = "";
        public override string? ToString()
        {
            return $"{Key} : {Value}";
        }
    }
}
