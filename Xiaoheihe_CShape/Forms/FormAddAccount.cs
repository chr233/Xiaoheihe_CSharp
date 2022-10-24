using System.Text.RegularExpressions;

using Xiaoheihe_Core.Data;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormAddAccount : Form
    {
        private Account Account { get; }

        private bool IsAdd { get; }

        public FormAddAccount(Account account, bool add)
        {
            InitializeComponent();

            Account = account;
            IsAdd = add;


        }

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;

            string title = IsAdd ? "添加账号" : "编辑账号";

            string okBtn = IsAdd ? "&A. 添加" : "&A. 修改";

            Text = title;
            groupBox2.Text = title;
            txtHeyboxID.Text = Account.HeyboxID;
            btnOK.Text = okBtn;
            txtPkey.Text = Account.Pkey;
            txtXToken.Text = Account.XhhTokenID;
            txtImei.Text = Account.Imei;
            txtOSType.Text = Account.OSType;
            txtOSVersion.Text = Account.OSVersion;
            txtDeviceInfo.Text = Account.DeviceInfo;
            txtChannal.Text = Account.Channal;
            txtDescription.Text = Account.Description;
            txtHeyboxID.ReadOnly = !IsAdd;
        }

        private void BtnRandomImei_Click(object sender, EventArgs e)
        {
            txtImei.Text = Xiaoheihe_Core.Utils.RandomImei();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeyboxID.Text))
            {
                MessageBox.Show("Heybox ID 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeyboxID.Focus();
            }
            else if (string.IsNullOrEmpty(txtPkey.Text))
            {
                MessageBox.Show("Pkey 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPkey.Focus();
            }
            else if (string.IsNullOrEmpty(txtImei.Text))
            {
                MessageBox.Show("Imei 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImei.Focus();
            }
            else if (string.IsNullOrEmpty(txtOSType.Text))
            {
                MessageBox.Show("系统类型 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOSType.Focus();
            }
            else if (string.IsNullOrEmpty(txtOSVersion.Text))
            {
                MessageBox.Show("系统版本 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOSVersion.Focus();
            }
            else if (string.IsNullOrEmpty(txtDeviceInfo.Text))
            {
                MessageBox.Show("手机型号 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeviceInfo.Focus();
            }
            else if (string.IsNullOrEmpty(txtChannal.Text))
            {
                MessageBox.Show("渠道 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChannal.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            string rawText = txtClipboard.Text;

            if (string.IsNullOrEmpty(rawText))
            {
                MessageBox.Show("识别区域为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MatchCollection matches = Regex.Matches(rawText, @"([^&?]*)=([^&]*)");

            foreach (Match match in matches.Cast<Match>())
            {
                if (match.Groups.Count == 3)
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    switch (key)
                    {
                        case "heybox_id":
                            txtHeyboxID.Text = value;
                            break;
                        case "imei":
                            txtImei.Text = value;
                            break;
                        case "device_info":
                            txtDeviceInfo.Text = value;
                            break;
                        case "os_type":
                            txtOSType.Text = value;
                            break;
                        case "os_version":
                            txtOSVersion.Text = value;
                            break;
                        case "channel":
                            txtChannal.Text = value;
                            break;
                        default:
                            break;
                    }
                }
            }

            Match pkey = Regex.Match(rawText, @"pkey=([^\n;]+)");

            if (pkey.Success)
            {
                txtPkey.Text = pkey.Groups[1].Value;
            }

            Match xhh_tokenID = Regex.Match(rawText, @"x_xhh_tokenid=([^\n;]+)");

            if (xhh_tokenID.Success)
            {
                txtXToken.Text = xhh_tokenID.Groups[1].Value;
            }
        }
    }
}
