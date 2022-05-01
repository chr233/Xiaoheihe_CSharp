using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class Account
    {
        public string Pkey { get; set; } = "";
        public string HeyboxID { get; set; } = "";
        public string Imei { get; set; } = "";
        public string NickName { get; set; } = "";
        public string Level { get; set; } = "";
        public string OSType { get; set; } = "";
        public string OSVersion { get; set; } = "";
        public string DeviceInfo { get; set; } = "";
        public string Channal { get; set; } = "";

        [JsonIgnore]
        public string Tasks { get; set; } = "";

        [JsonIgnore]
        public string Status { get; set; } = "";

        public override string? ToString()
        {
            return $"[{HeyboxID}] {NickName}";
        }
    }
}
