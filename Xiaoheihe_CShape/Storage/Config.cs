using Xiaoheihe_Core.Data;
using static Xiaoheihe_Core.StaticValue;

namespace Xiaoheihe_CShape.Storage
{
    public class Config
    {
        public string XhhVersion { get; set; } = DefaultHBVersion;
        public string HkeyServer { get; set; } = "";
        public HashSet<Account> Accounts { get; set; } = new();
        public HashSet<string> CheckedItems { get; set; } = new();
        public uint DailyTaskThread { get; set; } = 1;
        public uint DailyTaskDelay { get; set; } = 500;
        public uint TopupAuthorID { get; set; } = 0;
        public uint TopupThread { get; set; } = 2;
        public uint TopupDelay { get; set; } = 500;
    }
}
