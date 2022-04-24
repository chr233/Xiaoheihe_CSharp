using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Data
{
    public sealed class FavourTopicResponse : BasicResponse<FavourTopicResultData>
    {
    }

    public sealed class FavourTopicResultData : BasicResultData
    {
        [JsonPropertyName("auto_rank")]
        public byte AutoRank { get; set; }

        [JsonPropertyName("options")]
        public HashSet<FavourOptionData> Options { get; set; } = new();
    }

    public sealed class FavourOptionData
    {
        [JsonPropertyName("children")]
        public HashSet<FavourOptionChildrenData> Children { get; set; } = new();

        public override string? ToString()
        {
            return Children.ToString();
        }
    }

    public sealed class FavourOptionChildrenData
    {
        [JsonPropertyName("tag")]
        public FavourTagData Tag { get; set; } = new();

        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; } = "";

        [JsonPropertyName("topic_id")]
        public int TopicID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
        public override string? ToString()
        {
            return $"{TopicID} {Name} {Tag}";
        }
    }

    public sealed class FavourTagData
    {
        [JsonPropertyName("mask")]
        public byte Mask { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; } = "";
        public override string? ToString()
        {
            return $"{Mask} {Key}";
        }
    }

}
