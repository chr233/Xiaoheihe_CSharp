using Xiaoheihe_Core.APIs;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormMain : Form
    {
        private static Dictionary<string, Account> AccountsDict => Utils.AccountsDict;
        private static HashSet<string> ChecledItems => Utils.GlobalConfig.CheckedItems.ToHashSet();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Version version = typeof(Program).Assembly.GetName().Version ?? throw new ArgumentNullException(nameof(Version));

            Text = $"小黑盒 CShape - {version.Major}.{version.Minor}.{version.Build}.{version.Revision} - by Chr_ - 2022";

            Icon = Properties.Resources.icon;

            Utils.LoadConfig();
            UpdateAccountList();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.SaveConfig();
        }

        private void UpdateAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            uint count = 1;
            foreach (Account account in AccountsDict.Values)
            {
                ListViewItem item = new()
                {
                    Text = count++.ToString(),
                    SubItems =
                    {
                        account.HeyboxID,
                        account.NickName,
                        $"{account.OSType} {account.OSVersion}",
                        account.DeviceInfo,
                        account.Channal
                    },
                };

                lVAccounts.Items.Add(item);
            }

            lVAccounts.EndUpdate();
        }

        private void BtnEditAccount_Click(object sender, EventArgs e)
        {
            using FormAccountManager formAccountManager = new();
            formAccountManager.ShowDialog(this);
            UpdateAccountList();
        }

        private void BtnDailyTask_Click(object sender, EventArgs e)
        {
            using FormDailyTask formDailyTask = new();
            formDailyTask.ShowDialog(this);
            UpdateAccountList();
        }

        private void BtnTopupThread_Click(object sender, EventArgs e)
        {
            //Form formTopupThread = new FormTopupThread();
            //formTopupThread.Show();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            var selectedItems = lVAccounts.SelectedItems;

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("未选中任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (ListViewItem item in selectedItems)
                {
                    string heyboxID = item.SubItems[1].Text;
                    if (uint.TryParse(heyboxID, out uint userID))
                    {
                        FormAccountInfo formAccountInfo = new(userID);
                        formAccountInfo.Show();
                    }
                }
            }
        }

        private void TSMAll_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = true;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNone_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = false;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNot_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = !item.Selected;
            }
            lVAccounts.EndUpdate();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            UpdateAccountList();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new();
            formSetting.ShowDialog(this);
            formSetting.Close();
        }

#if DEBUG

        private void Test()
        {
            var selectedItems = lVAccounts.SelectedItems;

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("未选中任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in selectedItems)
                {
                    string heyboxID = item.SubItems[1].Text;

                    if (AccountsDict.ContainsKey(heyboxID))
                    {
                        Account account = AccountsDict[heyboxID];

                        Xiaoheihe_Core.XiaoheiheClient xhh = new(account, Utils.GlobalConfig.XhhVersion, Utils.GlobalConfig.HkeyServer);

                        //var result = xhh.GetLinkTree(80631064, 6, 0, SortFilter.Hot, false, false);
                        var result = xhh.GetNewsContent(80631064, 6).Result;
                    }
                }
            }
        }

#endif

    }
}
