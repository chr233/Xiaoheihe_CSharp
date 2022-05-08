using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public class BatteryData
    {
        [JsonPropertyName("count")]
        public uint Count { get; set; }

        [JsonPropertyName("enabled")]
        public byte Enabled { get; set; }

        [JsonPropertyName("charged")]
        public bool Charged { get; set; }

        public override string? ToString()
        {
            return $"{Count} {Charged} {Enabled}";
        }
    }

    public sealed class BatteryExData : BatteryData
    {
        [JsonPropertyName("charge_limits")]
        public HashSet<uint> ChargeLimits { get; set; } = new();
    }
}
