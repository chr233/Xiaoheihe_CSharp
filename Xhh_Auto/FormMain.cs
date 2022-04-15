using Xhh_Auto.Storage;
using Xiaoheihe_CShape;
using Xiaoheihe_CShape.Data;
using Xiaoheihe_CShape.Request;
using static System.Windows.Forms.ListView;

namespace Xhh_Auto
{
    public partial class FormMain : Form
    {
        Dictionary<string, Account> Accounts = new();

        const string DefaultOSType = "Android";
        const string DefaultOSVersion = "11";
        const string DefaultDevice = "K40";
        const string DefaultChannal = "heybox_xiaomi";

        public FormMain()
        {
            InitializeComponent();
            LoadCfg();
        }

        private void SaveAndReload()
        {
            SaveCfg();
            UpdateAccountList();
        }

        private void SaveCfg()
        {
            Config config = new Config()
            {
                HkeyServer = txtHKeyServer.Text,
                XhhVersion = txtHBVersion.Text,
                Accounts = Accounts.Values.ToHashSet(),
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

                lVAccounts.Items.Add(item);
            }

            lVAccounts.EndUpdate();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new()
            {
                OSType = DefaultOSType,
                OSVersion = DefaultOSVersion,
                DeviceInfo = DefaultDevice,
                Channal = DefaultChannal
            };

            FormAddAccount frmAdd = new(account, "导入账号");

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

        private void btnEditAccount_Click(object sender, EventArgs e)
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

                    FormAddAccount frmAdd = new(account, "编辑账号");

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
        private void btnDeleteAccount_Click(object sender, EventArgs e)
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

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            LoadCfg();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveCfg();
        }

        private void button1_Click(object sender, EventArgs e)
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

                        xhh.GetAccountInfo();

                    }
                }
            }
        }
    }
}