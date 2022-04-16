using Xhh_Auto.Storage;
using Xiaoheihe_Core;
using Xiaoheihe_Core.Data;
using Xiaoheihe_Core.APIs;
using static System.Windows.Forms.ListView;

using static Xiaoheihe_Core.StaticValue;

namespace Xhh_Auto
{
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, Account> Accounts = new();

        private HashSet<string> ChecledItems = new();

        public FormMain()
        {
            InitializeComponent();

            Version version = typeof(Program).Assembly.GetName().Version ?? throw new ArgumentNullException(nameof(Version));

            Text = $"小黑盒 助手 - {version.Major}.{version.Minor}.{version.Build}.{version.Revision} - by Chr_ - 2022";

            LoadCfg();
        }

        private void SaveAndReload()
        {
            SaveCfg();
            UpdateAccountList();
        }

        private void SaveCfg()
        {
            Config config = new()
            {
                HkeyServer = txtHKeyServer.Text,
                XhhVersion = txtHBVersion.Text,
                Accounts = Accounts.Values.ToHashSet(),
                CheckedItems = ChecledItems,
            };

            Utils.SaveConfig(config);
        }

        private void LoadCfg()
        {

            Config config = Utils.LoadConfig();

            txtHKeyServer.Text = config.HkeyServer;
            txtHBVersion.Text = config.XhhVersion;

            Accounts.Clear();
            foreach (Account account in config.Accounts)
            {
                Accounts[account.HeyboxID] = account;
            }
            ChecledItems = config.CheckedItems;

            UpdateAccountList();
        }

        private void UpdateAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            foreach (Account account in Accounts.Values)
            {
                ListViewItem item = new("");

                item.SubItems.Add(account.HeyboxID);
                item.SubItems.Add(account.NickName);
                item.SubItems.Add(account.Level);
                item.SubItems.Add("");
                item.SubItems.Add(account.OSType);
                item.SubItems.Add(account.OSVersion);
                item.SubItems.Add(account.DeviceInfo);
                item.SubItems.Add(account.Channal);

                item.Checked = ChecledItems.Contains(account.HeyboxID);

                lVAccounts.Items.Add(item);
            }

            lVAccounts.EndUpdate();
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new()
            {
                OSType = DefaultOSType,
                OSVersion = DefaultOSVersion,
                DeviceInfo = DefaultDevice,
                Channal = DefaultChannal
            };

            FormAddAccount frmAdd = new(account, true);

            if (frmAdd.ShowDialog(this) == DialogResult.OK)
            {
                string heyboxID = frmAdd.txtHeyboxID.Text;
                account.HeyboxID = heyboxID;
                account.Pkey = frmAdd.txtPkey.Text;
                account.Imei = frmAdd.txtImei.Text;
                account.NickName = "待更新";
                account.Level = "0";
                account.OSType = frmAdd.txtOSType.Text;
                account.OSVersion = frmAdd.txtOSVersion.Text;
                account.DeviceInfo = frmAdd.txtDeviceInfo.Text;
                account.Channal = frmAdd.txtChannal.Text;

                frmAdd.Dispose();

                if (Accounts.ContainsKey(heyboxID))
                {
                    DialogResult result = MessageBox.Show("该 Heybox ID 已存在, 是否替换原先的项目?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) { return; }
                }
                Accounts[account.HeyboxID] = account;
                SaveAndReload();
            }

        }

        private void BtnEditAccount_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection selectedItems = lVAccounts.SelectedItems;
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("未选择任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string heyboxID = selectedItems[0].SubItems[1].Text;

                if (Accounts.ContainsKey(heyboxID))
                {
                    Account account = Accounts[heyboxID];

                    FormAddAccount frmAdd = new(account, false);

                    if (frmAdd.ShowDialog(this) == DialogResult.OK)
                    {
                        account.HeyboxID = frmAdd.txtHeyboxID.Text;
                        account.Pkey = frmAdd.txtPkey.Text;
                        account.Imei = frmAdd.txtImei.Text;
                        account.NickName = "待更新";
                        account.Level = "0";
                        account.OSType = frmAdd.txtOSType.Text;
                        account.OSVersion = frmAdd.txtOSVersion.Text;
                        account.DeviceInfo = frmAdd.txtDeviceInfo.Text;
                        account.Channal = frmAdd.txtChannal.Text;

                        Accounts[account.HeyboxID] = account;
                    }
                    frmAdd.Dispose();
                }
                else
                {
                    MessageBox.Show("找不到对应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SaveAndReload();
        }
        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            CheckedListViewItemCollection checkedItems = lVAccounts.CheckedItems;

            if (checkedItems.Count == 0)
            {
                MessageBox.Show("未勾选任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in checkedItems)
                {
                    string heyboxID = item.SubItems[1].Text;
                    if (Accounts.ContainsKey(heyboxID))
                    {
                        Accounts.Remove(heyboxID);
                    }
                }
                SaveAndReload();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckedListViewItemCollection checkedItems = lVAccounts.CheckedItems;

            if (checkedItems.Count == 0)
            {
                MessageBox.Show("未勾选任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in checkedItems)
                {
                    string heyboxID = item.SubItems[1].Text;
                    if (Accounts.ContainsKey(heyboxID))
                    {
                        Account account = Accounts[heyboxID];

                        XiaoheiheClient xhh = new(account, txtHBVersion.Text, txtHKeyServer.Text);

                        var result = xhh.GetFeedNews(0);

                        var result1 = xhh.TaskSign();
                        var result2 = xhh.GetTaskList();
                        var result3 = xhh.GetTaskSignList();
                        var result4 = xhh.GetAccountInfo();

                        var a = "";
                    }
                }
            }
        }

        private void LVAccounts_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ChecledItems.Clear();

            foreach (ListViewItem item in lVAccounts.CheckedItems)
            {
                ChecledItems.Add(item.SubItems[1].Text);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCfg();
        }
    }
}