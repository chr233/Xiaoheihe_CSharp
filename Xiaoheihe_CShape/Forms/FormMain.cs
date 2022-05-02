using Xiaoheihe_Core.Data;
using Xiaoheihe_CShape.Storage;
using static Xiaoheihe_Core.StaticValue;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, Account> AccountsDict = new();

        private static HashSet<string> ChecledItems => Utils.GlobalConfig.CheckedItems;


        public FormMain()
        {
            InitializeComponent();

            Version version = typeof(Program).Assembly.GetName().Version ?? throw new ArgumentNullException(nameof(Version));

            Text = $"小黑盒 助手 - {version.Major}.{version.Minor}.{version.Build}.{version.Revision} - by Chr_ - 2022";

            Icon = Properties.Resources.icon;

            LoadCfg();
        }

        private void SaveAndReload()
        {
            SaveCfg();
            UpdateAccountList();
        }

        private void SaveCfg()
        {
            Utils.GlobalConfig.HkeyServer = txtHKeyServer.Text;
            Utils.GlobalConfig.XhhVersion = txtHBVersion.Text;
            Utils.GlobalConfig.Accounts = AccountsDict.Values.ToHashSet();

            Utils.SaveConfig();
        }

        private void LoadCfg()
        {
            Utils.LoadConfig();

            Config config = Utils.GlobalConfig;

            txtHKeyServer.Text = config.HkeyServer;
            txtHBVersion.Text = config.XhhVersion;

            AccountsDict.Clear();
            foreach (Account account in config.Accounts)
            {
                AccountsDict[account.HeyboxID] = account;
            }

            UpdateAccountList();
        }

        private void UpdateAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            foreach (Account account in AccountsDict.Values)
            {
                ListViewItem item = new("");

                item.SubItems.Add(account.HeyboxID);
                item.SubItems.Add(account.NickName);
                item.SubItems.Add(account.Level);
                item.SubItems.Add($"{account.OSType} {account.OSVersion}");
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

                if (AccountsDict.ContainsKey(heyboxID))
                {
                    DialogResult result = MessageBox.Show("该 Heybox ID 已存在, 是否替换原先的项目?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) { return; }
                }
                AccountsDict[account.HeyboxID] = account;
                SaveAndReload();
            }

        }

        private void BtnEditAccount_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lVAccounts.SelectedItems;
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("未选择任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string heyboxID = selectedItems[0].SubItems[1].Text;

                if (AccountsDict.ContainsKey(heyboxID))
                {
                    Account account = AccountsDict[heyboxID];

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

                        AccountsDict[account.HeyboxID] = account;
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
            ListView.CheckedListViewItemCollection checkedItems = lVAccounts.CheckedItems;

            if (checkedItems.Count == 0)
            {
                MessageBox.Show("未勾选任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in checkedItems)
                {
                    string heyboxID = item.SubItems[1].Text;
                    if (AccountsDict.ContainsKey(heyboxID))
                    {
                        AccountsDict.Remove(heyboxID);
                    }
                }
                SaveAndReload();
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

        private void BtnDailyTask_Click(object sender, EventArgs e)
        {
            FormCollection collection = Application.OpenForms;

            Form? formDailyTask = null;

            foreach (Form form in collection)
            {
                if (form is FormDailyTask)
                {
                    formDailyTask = form;
                    break;
                }
            }

            if (formDailyTask == null)
            {
                formDailyTask = new FormDailyTask();
                formDailyTask.Show();
            }
            else
            {
                formDailyTask.Focus();
            }
        }

        private void BtnTopupThread_Click(object sender, EventArgs e)
        {
            //Form formTopupThread = new FormTopupThread();
            //formTopupThread.Show();

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lVAccounts.SelectedItems;

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("未选中任何条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = true;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNone_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = false;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNot_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = !item.Checked;
            }
            lVAccounts.EndUpdate();
        }
    }
}
