using Xiaoheihe_CShape.Storage;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormSetting : Form
    {
        private bool CloseAlert;
        private static Config MyConfig => Utils.GlobalConfig;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;

            txtHBVersion.Text = MyConfig.XhhVersion;
            txtHKeyServer.Text = MyConfig.HkeyServer;
            txtProxies.Text = string.Join(Environment.NewLine, MyConfig.Proxies);
            CloseAlert = false;
        }

        private void FormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseAlert)
            {
                DialogResult result = MessageBox.Show("不保存设置就退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void OnConfigChange(object sender, EventArgs e)
        {
            CloseAlert = true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            MyConfig.XhhVersion = txtHBVersion.Text;
            MyConfig.HkeyServer = txtHKeyServer.Text;

            List<string> proxies = new();
            foreach (string line in txtProxies.Lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    proxies.Add(line);
                }
            }

            MyConfig.Proxies = proxies;

            txtProxies.Text = string.Join('\n', MyConfig.Proxies);

            Utils.SaveConfig();
            CloseAlert = false;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string configPath = Utils.GetConfigFilePath();
            System.Diagnostics.Process.Start("Explorer.exe", "/select," + configPath);
        }
    }
}
