using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class TaskListResponse : BasicResponse<TaskListResultData>
    {
    }

    public sealed class TaskListResultData : BasicResultData
    {
        [JsonPropertyName("task_list")]
        public List<TaskWithTitleData> TaskList { get; set; } = new();

        [JsonPropertyName("user")]
        public HeyboxUserData User { get; set; } = new();

        [JsonPropertyName("level_info")]
        public LevelInfoData LevelInfo { get; set; } = new();
    }

    public sealed class TaskWithTitleData
    {
        [JsonPropertyName("tasks")]
        public List<TaskDetailData> Tasks { get; set; } = new();

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

        [JsonPropertyName("state_desc")]
        public string StateDesc { get; set; } = "";

        [JsonPropertyName("state")]
        public string State { get; set; } = "";

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
}
