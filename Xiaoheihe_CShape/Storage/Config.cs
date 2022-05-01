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
    }
}
