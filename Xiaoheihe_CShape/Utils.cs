using System.Text;
using System.Text.Json;
using Xiaoheihe_Core.Data;
using Xiaoheihe_CShape.Storage;

namespace Xiaoheihe_CShape
{
    public static class Utils
    {
        /// <summary>
        /// 全局配置
        /// </summary>
        public static Config GlobalConfig { get; private set; } = new();

        /// <summary>
        /// 账号字典
        /// </summary>
        public static Dictionary<string, Account> AccountsDict { get; private set; } = new();

        /// <summary>
        /// 读取配置路径
        /// </summary>
        /// <returns></returns>
        public static string GetConfigFilePath()
        {
            string appFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configFolder = Path.Combine(appFolder, nameof(Xiaoheihe_CShape));

            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            string filePath = Path.Combine(configFolder, "config.json");
            return filePath;
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        public static void SaveConfig()
        {
            string filePath = GetConfigFilePath();
            SaveConfig(filePath);
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="filePath"></param>
        public static void SaveConfig(string filePath)
        {
            GlobalConfig.Accounts = AccountsDict.Values.ToList();

            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
            };

            string strConfig = JsonSerializer.Serialize(GlobalConfig, options);

            File.WriteAllText(filePath, strConfig, Encoding.UTF8);
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        public static void LoadConfig()
        {
            string filePath = GetConfigFilePath();

            LoadConfig(filePath);
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        /// <param name="filePath"></param>
        public static void LoadConfig(string filePath)
        {
            AccountsDict.Clear();
            if (File.Exists(filePath))
            {
                string strConfig = File.ReadAllText(filePath, Encoding.UTF8);
                GlobalConfig = JsonSerializer.Deserialize<Config>(strConfig ?? "") ?? new();

                foreach (Account account in GlobalConfig.Accounts)
                {
                    if (!AccountsDict.ContainsKey(account.HeyboxID))
                    {
                        AccountsDict[account.HeyboxID] = account;
                    }
                }

                GlobalConfig.Accounts = AccountsDict.Values.ToList();
            }
            else
            {
                GlobalConfig = new();
                SaveConfig(filePath);
            }
        }

        /// <summary>
        /// 布尔转字符串
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string B2S(bool value)
        {
            return value ? "√" : "×";
        }
    }
}
