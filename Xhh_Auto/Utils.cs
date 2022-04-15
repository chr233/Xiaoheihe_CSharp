using System.Text;
using System.Text.Json;

using Xhh_Auto.Storage;

namespace Xhh_Auto
{
    public static class Utils
    {

        public static string GetConfigFilePath()
        {
            string appFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configFolder = Path.Combine(appFolder, nameof(Xhh_Auto));

            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            string filePath = Path.Combine(configFolder, "config.json");
            return filePath;
        }

        public static void SaveConfig(Config config)
        {
            string filePath = GetConfigFilePath();
            SaveConfig(config, filePath);
        }


        public static void SaveConfig(Config config, string filePath)
        {

            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
            };

            string strConfig = JsonSerializer.Serialize(config, options);

            File.WriteAllText(filePath, strConfig, Encoding.UTF8);
        }

        public static Config LoadConfig()
        {
            string filePath = GetConfigFilePath();

            return LoadConfig(filePath);
        }


        public static Config LoadConfig(string filePath)
        {
            Config? config = null;
            if (File.Exists(filePath))
            {
                string strConfig = File.ReadAllText(filePath, Encoding.UTF8);
                config = JsonSerializer.Deserialize<Config>(strConfig ?? "");
            }
            else
            {
                config = new();
                SaveConfig(config, filePath);
            }
            return config ?? new();
        }
    }
}
