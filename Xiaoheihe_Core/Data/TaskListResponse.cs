using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class TaskListResponse : BasicResponse<TaskListResultData>
    {
    }

    public sealed class TaskListResultData : BasicResultData
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

        public override string? ToString()
        {
            return $"{Title} 任务数量: {Tasks.Count}";
        }
    }


    public sealed class TaskDetailData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("award_coin")]
        public int AwardCoin { get; set; }

        [JsonPropertyName("state_desc")]
        public string StateDesc { get; set; } = "";

        [JsonPropertyName("state")]
        public string State { get; set; } = "";

        [JsonPropertyName("award_exp")]
        public int AwardExp { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("desc")]
        public string Desc { get; set; } = "";

        public override string? ToString()
        {
            return $"{Title} {StateDesc} {Desc}";
        }
    }


    public sealed class LevelInfoData
    {
        [JsonPropertyName("max_exp")]
        public int MaxExp { get; set; }

        [JsonPropertyName("coin")]
        public int Coin { get; set; }

        [JsonPropertyName("exp")]
        public int Exp { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        public override string? ToString()
        {
            return $"Lv{Level}";
        }
    }
}
