using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Xiaoheihe_Core.Data;
using Xhh_Auto.Storage;

namespace Xhh_Auto
{
    public partial class FormAddAccount : Form
    {
        public FormAddAccount(Account account, bool Add = false)
        {
            InitializeComponent();

            string title = Add ? "添加账号" : "编辑账号";

            string okBtn = Add ? "&A. 添加" : "&A. 修改";

            Text = title;
            groupBox2.Text = title;
            txtHeyboxID.Text = account.HeyboxID;
            txtPkey.Text = account.Pkey;
            txtImei.Text = account.Imei;
            txtOSType.Text = account.OSType;
            txtOSVersion.Text = account.OSVersion;
            txtDeviceInfo.Text = account.DeviceInfo;
            txtChannal.Text = account.Channal;
            txtHeyboxID.ReadOnly = !Add;
        }

        private void btnRandomImei_Click(object sender, EventArgs e)
        {
            txtImei.Text = Xiaoheihe_Core.Utils.RandomImei();
        }

        private void btnOK_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
