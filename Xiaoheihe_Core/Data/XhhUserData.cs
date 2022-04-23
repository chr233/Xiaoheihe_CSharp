using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public class XhhUserData
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; } = "";

        [JsonPropertyName("userid")]
        public string UserID { get; set; } = "";

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";

        [JsonPropertyName("signature")]
        public string Signature { get; set; } = "";

        [JsonPropertyName("level_info")]
        public LevelInfoData LevelInfo { get; set; } = new();

        public override string? ToString()
        {
            return $"[{UserID}] {LevelInfo} {UserName}";
        }
    }
}
