using System.Text.Json;

namespace Xiaoheihe_Core.Data
{
    internal class ImageInfo
    {
        internal string ImageType { get; set; } = "jpeg";
        internal int Width { get; set; }
        internal int Height { get; set; }
        internal long Size { get; set; }

        internal string Package()
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
