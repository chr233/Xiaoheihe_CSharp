using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class GameDetailResponse : BasicResponse<GameDetailResultData>
    {
    }

    public sealed class GameDetailResultData : BasicResultData
    {
        [JsonPropertyName("appid")]
        public ulong Appid { get; set; }

        [JsonPropertyName("user_num")]
        public GameDetailUserNumData UserNum { get; set; } = new();

        [JsonPropertyName("share_desc")]
        public string ShareDesc { get; set; } = "";

        [JsonPropertyName("platforms_url")]
        public HashSet<string> PlatformsUrl { get; set; } = new();

        [JsonPropertyName("deadline_desc")]
        public string DeadlineDesc { get; set; } = "";

        [JsonPropertyName("image")]
        public string Image { get; set; } = "";

        [JsonPropertyName("menu_v2")]
        public HashSet<GameDetailMenuData> Menu { get; set; } = new();

        [JsonPropertyName("comment_change")]
        public byte CommentChange { get; set; }

        [JsonPropertyName("platforms")]
        public HashSet<string> Platforms { get; set; } = new();

        [JsonPropertyName("share_url")]
        public string ShareUrl { get; set; } = "";

        [JsonPropertyName("heybox_download")]
        public string HeyboxDownload { get; set; } = "";

        [JsonPropertyName("is_official")]
        public byte IsOfficial { get; set; }

        [JsonPropertyName("screenshots")]
        public HashSet<GameDetailScreenshotsData> Screenshots { get; set; } = new();

        [JsonPropertyName("genres")]
        public HashSet<string> Genres { get; set; } = new();

        [JsonPropertyName("heybox_price")]
        public HeyboxPeiceData HeyboxPrice { get; set; } = new();

        [JsonPropertyName("comment_stats")]
        public HeyboxCommentStatsData CommentStats { get; set; } = new();

        [JsonPropertyName("deadline_timestamp")]
        public DateTime DeadlineTimestamp { get; set; }

        [JsonPropertyName("has_game_detail")]
        public byte HasGameDetail { get; set; }

        [JsonPropertyName("has_unfinished_order")]
        public byte HasUnfinishedOrder { get; set; }

        [JsonPropertyName("about_the_game")]
        public string AboutTheGame { get; set; } = "";

        [JsonPropertyName("score")]
        public string Score { get; set; } = "";

        [JsonPropertyName("share_title")]
        public string ShareTitle { get; set; } = "";

        [JsonPropertyName("appicon")]
        public string AppIcon { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("positive_desc")]
        public string PositiveDesc { get; set; } = "";

        [JsonPropertyName("publishers")]
        public HashSet<KeyValueData> Publishers { get; set; } = new();

        [JsonPropertyName("platf")]
        public string Platform { get; set; } = "";

        [JsonPropertyName("price")]
        public GamePriceData Price { get; set; } = new();

        [JsonPropertyName("purchase_url")]
        public string PurchaseUrl { get; set; } = "";

        [JsonPropertyName("genres_list")]
        public HashSet<GenresData> GenresList { get; set; } = new();

        [JsonPropertyName("is_free")]
        public bool IsFree { get; set; }

        [JsonPropertyName("name_en")]
        public string NameEn { get; set; } = "";

        [JsonPropertyName("dlcs")]
        public HashSet<GameDlcData> Dlcs { get; set; } = new();

        [JsonPropertyName("desc")]
        public string Desc { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("share_img")]
        public string ShareImg { get; set; } = "";

        [JsonPropertyName("comment_state")]
        public byte CommentState { get; set; }

        [JsonPropertyName("game_type")]
        public string GameType { get; set; } = "";

        [JsonPropertyName("display_add_wishlist")]
        public byte DisplayAddWishlist { get; set; }

        [JsonPropertyName("hot_tags")]
        public HashSet<GameHotTagData> HotTags { get; set; } = new();

        [JsonPropertyName("platforms_list")]
        public HashSet<GamePlatformData> platforms_list { get; set; } = new();

        [JsonPropertyName("support_chinese")]
        public byte SupportChinese { get; set; }

        [JsonPropertyName("game_review_summary")]
        public string GameReviewSummary { get; set; } = "";

        [JsonPropertyName("follow_state")]
        public string FollowState { get; set; } = "";

    }


    public sealed class GameDetailUserNumData
    {
        [JsonPropertyName("current_online_url")]
        public string CurrentOnlineUrl { get; set; } = "";

        public override string? ToString()
        {
            return CurrentOnlineUrl;
        }
    }

    public sealed class GameDetailMenuData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("value")]
        public string Value { get; set; } = "";

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        public override string? ToString()
        {
            return $"{Title} {Value} {Type}";
        }
    }


    public sealed class GameDetailScreenshotsData
    {
        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; } = "";

        public override string? ToString()
        {
            return $"{Type} {Url}";
        }
    }

    public sealed class HeyboxPeiceData
    {
        [JsonPropertyName("has_sl")]
        public bool HasSl { get; set; }

        [JsonPropertyName("is_lowest")]
        public byte IsLowest { get; set; }

        [JsonPropertyName("discount")]
        public int Discount { get; set; }

        [JsonPropertyName("original_coin")]
        public int OriginalCoin { get; set; }

        [JsonPropertyName("cost_coin")]
        public int CostCoin { get; set; }

        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = "";

        [JsonPropertyName("new_lowest")]
        public byte NewLowest { get; set; }

        [JsonPropertyName("super_lowest")]
        public bool SuperLowest { get; set; }

        public override string? ToString()
        {
            return $"{Discount}% {CostCoin} {OriginalCoin}";
        }
    }

    public sealed class HeyboxCommentStatsData
    {
        [JsonPropertyName("expect_num")]
        public uint ExpectNum { get; set; }

        [JsonPropertyName("star_1")]
        public string Star1 { get; set; } = "";

        [JsonPropertyName("star_2")]
        public string Star2 { get; set; } = "";

        [JsonPropertyName("star_3")]
        public string Star3 { get; set; } = "";

        [JsonPropertyName("star_4")]
        public string Star4 { get; set; } = "";

        [JsonPropertyName("star_5")]
        public string Star5 { get; set; } = "";

        [JsonPropertyName("extra_desc")]
        public string ExtraDesc { get; set; } = "";

        [JsonPropertyName("score_comment")]
        public uint ScoreComment { get; set; }

        public override string? ToString()
        {
            return $"5:{Star5} 4:{Star4} 3:{Star3} 2:{Star2} 1:{Star1} {ExtraDesc}";
        }
    }

    public sealed class GamePriceData
    {
        [JsonPropertyName("current")]
        public string Current { get; set; } = "";

        [JsonPropertyName("deadline_timestamp")]
        public DateTime DeadlineTimestamp { get; set; }

        [JsonPropertyName("initial")]
        public string Initial { get; set; } = "";

        [JsonPropertyName("is_lowest")]
        public byte IsLowest { get; set; }

        [JsonPropertyName("discount")]
        public uint Discount { get; set; }

        [JsonPropertyName("deadline_date")]
        public string deadline_date { get; set; } = "";

        [JsonPropertyName("lowest_price_raw")]
        public string LowestPriceRaw { get; set; } = "";

        [JsonPropertyName("lowest_price")]
        public uint LowestPrice { get; set; }

        [JsonPropertyName("new_lowest")]
        public byte NewLowest { get; set; }

        [JsonPropertyName("super_lowest")]
        public bool SuperLowest { get; set; }

        [JsonPropertyName("lowest_discount")]
        public uint LowestDiscount { get; set; }
    }

    public sealed class GenresData
    {
        [JsonPropertyName("key")]
        public uint Key { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; } = "";

        [JsonPropertyName("desc")]
        public string Desc { get; set; } = "";
    }


    public sealed class GameDlcData
    {
        [JsonPropertyName("game_count")]
        public uint GameCount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("platforms_url")]
        public HashSet<string> PlatformsUrl { get; set; } = new();

        [JsonPropertyName("image")]
        public string Image { get; set; } = "";

        [JsonPropertyName("platforms")]
        public HashSet<string> PlatForms { get; set; } = new();

        [JsonPropertyName("bundle_id")]
        public uint BundleID { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("price")]
        public GamePriceData Price { get; set; } = new();
    }

    public sealed class GameHotTagData
    {
        [JsonPropertyName("filter_head")]
        public string FilterHead { get; set; } = "";

        [JsonPropertyName("key")]
        public int Key { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; } = "";
    }

    public sealed class GamePlatformData
    {
        [JsonPropertyName("platf")]
        public string Platf { get; set; } = "";

        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("appid")]
        public ulong Appid { get; set; }
    }
}



