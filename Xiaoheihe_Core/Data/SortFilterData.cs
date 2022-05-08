using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class SortFilterData
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = "";

        [JsonPropertyName("text")]
        public string Text { get; set; } = "";
    }
}
