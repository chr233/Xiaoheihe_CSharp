using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class FollowCountData
    {
        /// <summary>
        /// 粉丝
        /// </summary>
        [JsonPropertyName("fan_num")]
        public uint FollowerCount { get; set; }

        /// <summary>
        /// 关注的人
        /// </summary>
        [JsonPropertyName("follow_num")]
        public uint FollowingCount { get; set; }

        public override string? ToString()
        {
            return $"粉丝:{FollowerCount} 关注:{FollowingCount}";
        }
    }
}
