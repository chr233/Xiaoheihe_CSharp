using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class AccountInfoResponse : BasicResponse<AccountInfoResultData>
    {
    }

    public sealed class AccountInfoResultData
    {
        [JsonPropertyName("profile")]

        public ProfileData Profile { get; set; } = new();

        [JsonPropertyName("account_detail")]
        public AccountDetailData AccountDetail { get; set; } = new();
    }

    public sealed class ProfileData
    {
        [JsonPropertyName("education")]
        public string Education { get; set; } = "";

        [JsonPropertyName("career")]
        public string Career { get; set; } = "";

        [JsonPropertyName("gender")]
        public int Gender { get; set; } = 0;

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
    }

    public sealed class AccountDetailData
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

    }
}
