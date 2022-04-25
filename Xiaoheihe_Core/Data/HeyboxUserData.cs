using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    /// <summary>
    /// 一般响应中返回的用户信息
    /// </summary>
    public class HeyboxUserData
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; } = "";

        [JsonPropertyName("userid")]
        public string UserID { get; set; } = "";

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";

        [JsonPropertyName("signature")]
        public string Signature { get; set; } = "";

        [JsonPropertyName("battery")]
        public uint Battery { get; set; }

        [JsonPropertyName("level_info")]
        public LevelInfoData LevelInfo { get; set; } = new();

        public override string? ToString()
        {
            return $"[{UserID}] {LevelInfo} {UserName}";
        }
    }

    /// <summary>
    /// 用户详情页响应返回的用户信息
    /// </summary>
    public sealed class HeyboxUserDetailData : HeyboxUserData
    {
        /// <summary>获赞数量</summary>
        [JsonPropertyName("awarded_num")]
        public uint AwardedCount { get; set; }

        /// <summary>关注的人数量</summary>
        [JsonPropertyName("follow_num")]
        public uint FollowingCount { get; set; }

        /// <summary>粉丝数量</summary>
        [JsonPropertyName("fan_num")]
        public uint FollowerCount { get; set; }

        [JsonPropertyName("follow_status")]
        public FollowStatus FollowStatus { get; set; } = FollowStatus.Unknown;

        /// <summary>评论数量</summary>
        [JsonPropertyName("post_comment_num")]
        public uint PostCommentCount { get; set; }

        /// <summary>文章投稿</summary>
        [JsonPropertyName("post_article_num")]
        public uint PostArticleCount { get; set; }

        /// <summary>新闻评论?数量</summary>
        [JsonPropertyName("news_comment_num")]
        public uint NewsCommentCount { get; set; }

        /// <summary>发帖数量</summary>
        [JsonPropertyName("post_link_num")]
        public uint PostLinkCount { get; set; }

        /// <summary>游戏评价数量</summary>
        [JsonPropertyName("game_comment_num")]
        public uint GameCommentCount { get; set; }

        [JsonPropertyName("moments_num")]
        public uint MomentsCount { get; set; }
    }

    public sealed class HeyboxUserFriendListData : HeyboxUserData
    {
        [JsonPropertyName("is_follow")]
        public FollowStatus FollowStatus { get; set; } = FollowStatus.Unknown;
    }
}
