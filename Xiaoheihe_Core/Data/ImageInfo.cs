using System.Text.Json;

namespace Xiaoheihe_Core.Data
{
    public sealed class ImageInfo
    {
        public string ImageType { get; set; } = "jpeg";
        public int Width { get; set; }
        public int Height { get; set; }
        public long Size { get; set; }

        public string Package()
        {
            Dictionary<string, string> data = new(4)
            {
                { "mimetype", "image/" + ImageType },
                { "width", Width.ToString() },
                { "height", Height.ToString() },
                { "fsize", Size.ToString() },
            };

            string strJson = JsonSerializer.Serialize(data);

            return $"[{strJson}]";
        }

        public override string? ToString()
        {
            return $"{ImageType} 高{Height} 宽{Width} 大小{Size}";
        }
    }
}
