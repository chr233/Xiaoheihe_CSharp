using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xiaoheihe_Core.Converters
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64());
                return offset.LocalDateTime;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? str = reader.GetString();

                if (long.TryParse(str, out long value1))
                {
                    DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds(value1);
                    return offset.LocalDateTime;
                }

                if (double.TryParse(str, out double value2))
                {
                    DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds((long)(value2));
                    return offset.LocalDateTime;
                }

                throw new JsonException($"{reader.GetString()} 无法转换为 {typeof(long)}");
            }
            throw new JsonException($"{reader.GetString()} 无法转换为 {typeof(DateTime)}");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            long timeStamp = new DateTimeOffset(value).ToUnixTimeSeconds();
            writer.WriteStringValue(timeStamp.ToString());
        }
    }
}
