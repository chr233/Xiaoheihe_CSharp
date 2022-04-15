using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class TaskSignListResponse : BasicResponse<TaskSignListResultData>
    {
    }

    public sealed class TaskSignListResultData
    {
        [JsonPropertyName("replenish_desc")]
        public string ReplenishDesc { get; set; } = "";

        [JsonPropertyName("sign_list")]
        public HashSet<SignListData> SighList { get; set; } = new();
    }

    public sealed class SignListData
    {
        [JsonPropertyName("date")]
        public long Date { get; set; } = 0;

        [JsonPropertyName("is_sign")]
        public bool IsSign { get; set; } = false;
    }
}
