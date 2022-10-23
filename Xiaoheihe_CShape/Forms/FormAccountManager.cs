using System.Linq;
using Xiaoheihe_Core.Data;
using Xiaoheihe_CShape.Storage;
using static Xiaoheihe_Core.StaticValue;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormAccountManager : Form
    {
        private static Dictionary<string, Account> AccountsDict => Utils.AccountsDict;

        public FormAccountManager()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;

            UpdateAccountList();
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

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new()
            {
                OSType = DefaultOSType,
                OSVersion = DefaultOSVersion,
                DeviceInfo = DefaultDevice,
                Channal = DefaultChannal
            };

            using FormAddAccount frmAdd = new(account, true);

            if (frmAdd.ShowDialog(this) == DialogResult.OK)
            {
                string heyboxID = frmAdd.txtHeyboxID.Text;
                account.HeyboxID = heyboxID;
                account.Pkey = frmAdd.txtPkey.Text;
                account.XhhTokenID = frmAdd.txtXToken.Text;
                account.Imei = frmAdd.txtImei.Text;
                account.NickName = "待更新";
                account.Level = "0";
                account.OSType = frmAdd.txtOSType.Text;
                account.OSVersion = frmAdd.txtOSVersion.Text;
                account.DeviceInfo = frmAdd.txtDeviceInfo.Text;
                account.Channal = frmAdd.txtChannal.Text;
                account.Description = frmAdd.txtDescription.Text;

                if (AccountsDict.ContainsKey(heyboxID))
                {
                    DialogResult result = MessageBox.Show("该 Heybox ID 已存在, 是否替换原先的项目?",
                        "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }                 
                }
                AccountsDict[account.HeyboxID] = account;

                Utils.SaveConfig();
                UpdateAccountList();
            }
        }

        private void BtnEditAccount_Click(object sender, EventArgs e)
        {
            var selectedItems = lVAccounts.SelectedItems;
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
                        account.XhhTokenID = frmAdd.txtXToken.Text;
                        account.Imei = frmAdd.txtImei.Text;
                        account.NickName ??= "待更新";
                        account.Level ??= "0";
                        account.OSType = frmAdd.txtOSType.Text;
                        account.OSVersion = frmAdd.txtOSVersion.Text;
                        account.DeviceInfo = frmAdd.txtDeviceInfo.Text;
                        account.Channal = frmAdd.txtChannal.Text;
                        account.Description = frmAdd.txtDescription.Text;

                        AccountsDict[account.HeyboxID] = account;
                    }
                    frmAdd.Dispose();
                }
                else
                {
                    MessageBox.Show("找不到对应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Utils.SaveConfig();
            UpdateAccountList();
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
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
                        AccountsDict.Remove(heyboxID);
                    }
                }
                Utils.SaveConfig();
                UpdateAccountList();
            }
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

        private void LVAccounts_DoubleClick(object sender, EventArgs e)
        {
            var selectedItems = lVAccounts.SelectedItems;
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
                        account.XhhTokenID = frmAdd.txtXToken.Text;
                        account.Imei = frmAdd.txtImei.Text;
                        account.NickName ??= "待更新";
                        account.Level ??= "0";
                        account.OSType = frmAdd.txtOSType.Text;
                        account.OSVersion = frmAdd.txtOSVersion.Text;
                        account.DeviceInfo = frmAdd.txtDeviceInfo.Text;
                        account.Channal = frmAdd.txtChannal.Text;
                        account.Description = frmAdd.txtDescription.Text;

                        AccountsDict[account.HeyboxID] = account;
                    }
                    frmAdd.Dispose();
                }
                else
                {
                    MessageBox.Show("找不到对应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //SaveAndReload();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            using FormSetting formSetting = new();
            formSetting.ShowDialog(this);
        }

        private void tSMAll_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = true;
            }
            lVAccounts.EndUpdate();
        }

        private void tSMNone_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = false;
            }
            lVAccounts.EndUpdate();
        }

        private void tSMNot_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Selected = !item.Selected;
            }
            lVAccounts.EndUpdate();
        }
    }
}
