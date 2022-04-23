using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class TaskSignListResponse : BasicResponse<TaskSignListResultData>
    {
    }

    public sealed class TaskSignListResultData : BasicResultData
    {
        [JsonPropertyName("replenish_desc")]
        public string ReplenishDesc { get; set; } = "";

        [JsonPropertyName("sign_list")]
        public HashSet<SignListData> SighList { get; set; } = new();
    }

    public sealed class SignListData
    {
        private const string Signed = "已签到";
        private const string Unsigned = "未签到";

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("is_sign")]
        public bool IsSign { get; set; }

        public override string? ToString()
        {
            return $"{Date} {(IsSign ? Signed : Unsigned)}";
        }
    }
}
