namespace Xiaoheihe_CShape.Forms
{
    partial class FormAccountManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colNo = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colOS = new System.Windows.Forms.ColumnHeader();
            this.colDeviceName = new System.Windows.Forms.ColumnHeader();
            this.colChannal = new System.Windows.Forms.ColumnHeader();
            this.btnSetting = new System.Windows.Forms.Button();
            this.cMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNot = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.cMenuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Controls.Add(this.btnProfile);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Location = new System.Drawing.Point(551, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号编辑";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 90);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(122, 28);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "&D. 删除选中账号";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(7, 56);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(121, 28);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "&E. 编辑账号";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.BtnEditAccount_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProfile.Location = new System.Drawing.Point(6, 145);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(122, 28);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "&I. 查看个人资料";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 22);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(122, 28);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "&A. 添加账号";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // lVAccounts
            // 
            this.lVAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lVAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colHeyboxID,
            this.colNickName,
            this.colOS,
            this.colDeviceName,
            this.colChannal});
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(12, 12);
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(533, 380);
            this.lVAccounts.TabIndex = 15;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
            this.lVAccounts.DoubleClick += new System.EventHandler(this.LVAccounts_DoubleClick);
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 40;
            // 
            // colHeyboxID
            // 
            this.colHeyboxID.Text = "HeyboxID";
            this.colHeyboxID.Width = 90;
            // 
            // colNickName
            // 
            this.colNickName.Text = "昵称";
            this.colNickName.Width = 100;
            // 
            // colOS
            // 
            this.colOS.Text = "系统";
            this.colOS.Width = 80;
            // 
            // colDeviceName
            // 
            this.colDeviceName.Text = "手机型号";
            this.colDeviceName.Width = 100;
            // 
            // colChannal
            // 
            this.colChannal.Text = "渠道";
            this.colChannal.Width = 100;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Location = new System.Drawing.Point(551, 364);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(134, 28);
            this.btnSetting.TabIndex = 16;
            this.btnSetting.Text = "&S. 系统设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // cMenuAccount
            // 
            this.cMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMAll,
            this.tSMNone,
            this.tSMNot});
            this.cMenuAccount.Name = "contextMenuStrip1";
            this.cMenuAccount.Size = new System.Drawing.Size(113, 70);
            // 
            // tSMAll
            // 
            this.tSMAll.Name = "tSMAll";
            this.tSMAll.Size = new System.Drawing.Size(112, 22);
            this.tSMAll.Text = "全选";
            this.tSMAll.Click += new System.EventHandler(this.tSMAll_Click);
            // 
            // tSMNone
            // 
            this.tSMNone.Name = "tSMNone";
            this.tSMNone.Size = new System.Drawing.Size(112, 22);
            this.tSMNone.Text = "全不选";
            this.tSMNone.Click += new System.EventHandler(this.tSMNone_Click);
            // 
            // tSMNot
            // 
            this.tSMNot.Name = "tSMNot";
            this.tSMNot.Size = new System.Drawing.Size(112, 22);
            this.tSMNot.Text = "反选";
            this.tSMNot.Click += new System.EventHandler(this.tSMNot_Click);
            // 
            // FormAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 404);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lVAccounts);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(500, 412);
            this.Name = "FormAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账号管理";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.groupBox2.ResumeLayout(false);
            this.cMenuAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private Button btnProfile;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnAddAccount;
        private ListView lVAccounts;
        private ColumnHeader colNo;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colOS;
        private ColumnHeader colDeviceName;
        private ColumnHeader colChannal;
        private Button btnSetting;
        private ContextMenuStrip cMenuAccount;
        private ToolStripMenuItem tSMAll;
        private ToolStripMenuItem tSMNone;
        private ToolStripMenuItem tSMNot;
    }
}
