using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class LevelInfoData
    {
        [JsonPropertyName("max_exp")]
        public uint MaxExp { get; set; }

        [JsonPropertyName("coin")]
        public uint Coin { get; set; }

        [JsonPropertyName("exp")]
        public uint Exp { get; set; }

        [JsonPropertyName("level")]
        public uint Level { get; set; }

        public override string? ToString()
        {
            return $"Lv{Level}";
        }
    }
}
