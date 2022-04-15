using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class TaskListResponse : BasicResponse<TaskListResultData>
    {
    }

    public sealed class TaskListResultData
    {
        [JsonPropertyName("task_list")]
        public HashSet<TaskWithTitleData> TaskList { get; set; } = new();
    }

    public sealed class TaskWithTitleData
    {
        [JsonPropertyName("tasks")]
        public HashSet<TaskDetailData> Tasks { get; set; } = new();

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";
    }


    public sealed class TaskDetailData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("award_coin")]
        public int AwardCoin { get; set; } = 0;

        [JsonPropertyName("state_desc")]
        public string StateDesc { get; set; } = "";

        [JsonPropertyName("state")]
        public string State { get; set; } = "";

        [JsonPropertyName("award_exp")]
        public int AwardExp { get; set; } = 0;

        [JsonPropertyName("icon")]
        public string Icon { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("desc")]
        public string Desc { get; set; } = "";
    }


    public sealed class LevelInfoData
    {
        [JsonPropertyName("max_exp")]
        public int Max_exp { get; set; } = 0;

        [JsonPropertyName("coin")]
        public int Coin { get; set; } = 0;

        [JsonPropertyName("exp")]
        public int Exp { get; set; } = 0;

        [JsonPropertyName("level")]
        public int Level { get; set; } = 0;
    }
}
