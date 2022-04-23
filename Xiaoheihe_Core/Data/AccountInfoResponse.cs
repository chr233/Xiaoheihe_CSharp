using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class AccountInfoResponse : BasicResponse<AccountInfoResultData>
    {
    }

    public sealed class AccountInfoResultData : BasicResultData
    {
        [JsonPropertyName("profile")]
        public ProfileData Profile { get; set; } = new();

        [JsonPropertyName("account_detail")]
        public XhhUserData AccountDetail { get; set; } = new();
    }

    public sealed class ProfileData
    {
        [JsonPropertyName("education")]
        public string Education { get; set; } = "";

        [JsonPropertyName("career")]
        public string Career { get; set; } = "";

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; } = "";

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";

        [JsonPropertyName("signature")]
        public string Signature { get; set; } = "";

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; } = "";

        [JsonPropertyName("email")]
        public string Email { get; set; } = "";

        [JsonPropertyName("heybox_id")]
        public string HeyboxID { get; set; } = "";

        public override string? ToString()
        {
            return $"[{HeyboxID}] {Nickname}";
        }
    }
}
