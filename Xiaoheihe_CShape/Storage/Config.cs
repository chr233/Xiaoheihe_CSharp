using Xiaoheihe_Core.Data;

namespace Xiaoheihe_CShape.Storage
{
    public class Config
    {
        public string XhhVersion { get; set; } = "";
        public string HkeyServer { get; set; } = "";
        public HashSet<Account> Accounts { get; set; } = new();
        public HashSet<string> CheckedItems { get; set; } = new();
    }
}
