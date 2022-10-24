namespace Xiaoheihe_CShape.Forms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colNo = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colOS = new System.Windows.Forms.ColumnHeader();
            this.colDeviceName = new System.Windows.Forms.ColumnHeader();
            this.colChannal = new System.Windows.Forms.ColumnHeader();
            this.cMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNot = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnDailyTask = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTopupThread = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cMenuAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.lVAccounts.ContextMenuStrip = this.cMenuAccount;
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(12, 12);
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(532, 372);
            this.lVAccounts.TabIndex = 0;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
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
            // cMenuAccount
            // 
            this.cMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMAll,
            this.tSMNone,
            this.tSMNot});
            this.cMenuAccount.Name = "contextMenuStrip1";
            this.cMenuAccount.Size = new System.Drawing.Size(181, 92);
            // 
            // tSMAll
            // 
            this.tSMAll.Name = "tSMAll";
            this.tSMAll.Size = new System.Drawing.Size(180, 22);
            this.tSMAll.Text = "全选";
            this.tSMAll.Click += new System.EventHandler(this.TSMAll_Click);
            // 
            // tSMNone
            // 
            this.tSMNone.Name = "tSMNone";
            this.tSMNone.Size = new System.Drawing.Size(180, 22);
            this.tSMNone.Text = "全不选";
            this.tSMNone.Click += new System.EventHandler(this.TSMNone_Click);
            // 
            // tSMNot
            // 
            this.tSMNot.Name = "tSMNot";
            this.tSMNot.Size = new System.Drawing.Size(180, 22);
            this.tSMNot.Text = "反选";
            this.tSMNot.Click += new System.EventHandler(this.TSMNot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnProfile);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Location = new System.Drawing.Point(550, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号功能";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(7, 91);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 28);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "&R. 刷新列表";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(7, 57);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(121, 28);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "&I. 查看个人资料";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAccount.Location = new System.Drawing.Point(6, 22);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(121, 28);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "&A. 账号管理器";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.BtnEditAccount_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Location = new System.Drawing.Point(550, 356);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(134, 28);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "&S. 系统设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // btnDailyTask
            // 
            this.btnDailyTask.Location = new System.Drawing.Point(6, 22);
            this.btnDailyTask.Name = "btnDailyTask";
            this.btnDailyTask.Size = new System.Drawing.Size(122, 28);
            this.btnDailyTask.TabIndex = 7;
            this.btnDailyTask.Text = "&T. 每日任务";
            this.btnDailyTask.UseVisualStyleBackColor = true;
            this.btnDailyTask.Click += new System.EventHandler(this.BtnDailyTask_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btnDailyTask);
            this.groupBox3.Location = new System.Drawing.Point(550, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 93);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基础功能";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(6, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "&C. 模拟客户端";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnTopupThread
            // 
            this.btnTopupThread.Enabled = false;
            this.btnTopupThread.Location = new System.Drawing.Point(6, 22);
            this.btnTopupThread.Name = "btnTopupThread";
            this.btnTopupThread.Size = new System.Drawing.Size(122, 26);
            this.btnTopupThread.TabIndex = 7;
            this.btnTopupThread.Text = "&U. 顶贴工具";
            this.btnTopupThread.UseVisualStyleBackColor = true;
            this.btnTopupThread.Click += new System.EventHandler(this.BtnTopupThread_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.btnTopupThread);
            this.groupBox4.Location = new System.Drawing.Point(550, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 93);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "特殊功能";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(7, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "&P. 发帖工具";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 396);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lVAccounts);
            this.MinimumSize = new System.Drawing.Size(500, 412);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小黑盒 CShape";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.cMenuAccount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListView lVAccounts;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private GroupBox groupBox2;
        private ColumnHeader colNo;
        private ColumnHeader colOS;
        private ColumnHeader colDeviceName;
        private ColumnHeader colChannal;
        private Button btnEditAccount;
        private Button btnDailyTask;
        private ContextMenuStrip cMenuAccount;
        private GroupBox groupBox3;
        private Button btnProfile;
        private Button btnTopupThread;
        private GroupBox groupBox4;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem tSMAll;
        private ToolStripMenuItem tSMNone;
        private ToolStripMenuItem tSMNot;
        private Button btnReload;
        private Button btnSetting;
    }
}
