using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class CommentListResponse : BasicResponse<CommentListResultData>
    {
        [JsonPropertyName("current_user")]
        public HeyboxUserData User { get; set; } = new();

        [JsonPropertyName("has_more_floors")]
        public byte HasMoreFloors { get; set; }

        [JsonPropertyName("total_floor_num")]
        public uint TotalFloorCount { get; set; }

        [JsonPropertyName("total_page")]
        public uint TotalPage { get; set; }
    }

    public sealed class CommentListResultData : BasicResultData
    {
        [JsonPropertyName("comments")]
        public HashSet<CommentGrouptData> Comments { get; set; } = new();

        [JsonPropertyName("cy_control")]
        public byte CyControl { get; set; }

        [JsonPropertyName("link")]
        public CommentLinkData Link { get; set; } = new();

        [JsonPropertyName("sort_filter")]
        public HashSet<SortFilterData> SortFilter { get; set; } = new();
    }

    public sealed class CommentGrouptData
    {
        [JsonPropertyName("comment")]
        public HashSet<CommentObjectData> Comment { get; set; } = new();

        public override string? ToString()
        {
            if (Comment.Count > 0)
            {
                return $"[{Comment.Count}] {Comment.First()}";
            }
            else
            {
                return $"[{Comment.Count}]";
            }
        }
    }

    public sealed class CommentObjectData
    {
        [JsonPropertyName("child_num")]
        public uint ChildCount { get; set; }

        [JsonPropertyName("commentid")]
        public ulong CommentID { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("floor_num")]
        public uint FloorNum { get; set; }

        [JsonPropertyName("has_more")]
        public byte HasMore { get; set; }

        [JsonPropertyName("is_cy")]
        public byte IsCy { get; set; }

        [JsonPropertyName("is_link_owner")]
        public uint IsLinkOwner { get; set; }

        [JsonPropertyName("is_support")]
        public int IsSupport { get; set; }

        [JsonPropertyName("replyid")]
        public ulong ReplyID { get; set; }

        [JsonPropertyName("replyuser")]
        public HeyboxUserData ReplyUser { get; set; } = new();

        [JsonPropertyName("text")]
        public string Text { get; set; } = "";

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("user")]
        public HeyboxUserData User { get; set; } = new();

        public override string? ToString()
        {
            if (ReplyID == 0)
            {
                return $"[{CommentID}] {User} {Text}";
            }
            else
            {
                return $"[{CommentID}=>{ReplyID}] {User} {Text}";
            }
        }
    }

    public sealed class CommentLinkData : BaseCommentLinkData
    {
        [JsonPropertyName("battery")]
        public BatteryExData Battery { get; set; } = new();

        [JsonPropertyName("click")]
        public uint Click { get; set; }

        [JsonPropertyName("comment_num")]
        public uint CommentCount { get; set; }

        [JsonPropertyName("create_at")]
        public DateTime CreateAt { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("disable_comment")]
        public byte DisableComment { get; set; }

        [JsonPropertyName("follow_status")]
        public byte FollowStatus { get; set; }

        [JsonPropertyName("forward_num")]
        public uint ForwardCount { get; set; }

        [JsonPropertyName("imgs")]
        public HashSet<string> Imgs { get; set; } = new();

        [JsonPropertyName("is_article")]
        public byte IsArticle { get; set; }

        [JsonPropertyName("is_award_link")]
        public byte IsAwardLink { get; set; }

        [JsonPropertyName("is_favour")]
        public byte IsFavour { get; set; }

        [JsonPropertyName("is_hot_post")]
        public byte IsHotPost { get; set; }

        [JsonPropertyName("is_support")]
        public byte IsSupport { get; set; }

        [JsonPropertyName("is_web")]
        public byte IsWeb { get; set; }

        [JsonPropertyName("labels")]
        public string Labels { get; set; } = "";

        [JsonPropertyName("link_award_num")]
        public uint LinkAwardCount { get; set; }

        [JsonPropertyName("link_type")]
        public uint LinkType { get; set; }

        [JsonPropertyName("linkid")]
        public uint LinkID { get; set; }

        [JsonPropertyName("modify_at")]
        public DateTime ModifyAt { get; set; }

        [JsonPropertyName("news_show")]
        public byte NewsShow { get; set; }

        [JsonPropertyName("recommendable")]
        public byte Recommendable { get; set; }

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("topics")]
        public HashSet<TopicData> Topics { get; set; } = new();

        [JsonPropertyName("up")]
        public uint Up { get; set; }

        [JsonPropertyName("use_concept_type")]
        public byte UseConceptType { get; set; }
    }
}
