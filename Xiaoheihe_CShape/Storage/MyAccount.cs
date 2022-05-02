using System.Text.Json.Serialization;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_CShape.Storage
{
    public sealed class MyAccount : Account
    {
        [JsonIgnore]
        public string DailyTasks { get; set; } = "";

        [JsonIgnore]
        public string DailyStatus { get; set; } = "";
    }
}
