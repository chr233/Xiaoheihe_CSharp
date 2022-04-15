using Xiaoheihe_CShape.Data;

namespace Xhh_Auto.Storage
{
    public class Config
    {
        public string XhhVersion { get; set; } = "";
        public string HkeyServer { get; set; } = "";
        public HashSet<Account> Accounts { get; set; } = new();
    }
}
