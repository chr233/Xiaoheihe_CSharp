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
            this.colChecks = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colLevel = new System.Windows.Forms.ColumnHeader();
            this.colOS = new System.Windows.Forms.ColumnHeader();
            this.colDeviceName = new System.Windows.Forms.ColumnHeader();
            this.colChannal = new System.Windows.Forms.ColumnHeader();
            this.cMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.更新账号数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.编辑当前账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDailyTask = new System.Windows.Forms.Button();
            this.txtHBVersion = new System.Windows.Forms.TextBox();
            this.txtHKeyServer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTopupThread = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cMenuAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVAccounts
            // 
            this.lVAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lVAccounts.CheckBoxes = true;
            this.lVAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChecks,
            this.colHeyboxID,
            this.colNickName,
            this.colLevel,
            this.colOS,
            this.colDeviceName,
            this.colChannal});
            this.lVAccounts.ContextMenuStrip = this.cMenuAccount;
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(0, 0);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(522, 393);
            this.lVAccounts.TabIndex = 0;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
            this.lVAccounts.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LVAccounts_ItemChecked);
            // 
            // colChecks
            // 
            this.colChecks.Text = "";
            this.colChecks.Width = 30;
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
            // colLevel
            // 
            this.colLevel.Text = "等级";
            this.colLevel.Width = 40;
            // 
            // colOS
            // 
            this.colOS.Text = "系统";
            this.colOS.Width = 80;
            // 
            // colDeviceName
            // 
            this.colDeviceName.Text = "手机型号";
            // 
            // colChannal
            // 
            this.colChannal.Text = "渠道";
            this.colChannal.Width = 100;
            // 
            // cMenuAccount
            // 
            this.cMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新账号数据ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.编辑当前账号ToolStripMenuItem});
            this.cMenuAccount.Name = "contextMenuStrip1";
            this.cMenuAccount.Size = new System.Drawing.Size(149, 54);
            // 
            // 更新账号数据ToolStripMenuItem
            // 
            this.更新账号数据ToolStripMenuItem.Name = "更新账号数据ToolStripMenuItem";
            this.更新账号数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.更新账号数据ToolStripMenuItem.Text = "更新账号数据";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // 编辑当前账号ToolStripMenuItem
            // 
            this.编辑当前账号ToolStripMenuItem.Name = "编辑当前账号ToolStripMenuItem";
            this.编辑当前账号ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑当前账号ToolStripMenuItem.Text = "编辑当前账号";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Location = new System.Drawing.Point(528, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号编辑";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "&I. 查看个人资料";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 90);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "&D. 删除勾选";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(7, 56);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(117, 28);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "&E. 编辑账号";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.BtnEditAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 22);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(117, 28);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "&A. 添加账号";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // btnDailyTask
            // 
            this.btnDailyTask.Location = new System.Drawing.Point(7, 22);
            this.btnDailyTask.Name = "btnDailyTask";
            this.btnDailyTask.Size = new System.Drawing.Size(117, 28);
            this.btnDailyTask.TabIndex = 7;
            this.btnDailyTask.Text = "&T. 每日任务";
            this.btnDailyTask.UseVisualStyleBackColor = true;
            this.btnDailyTask.Click += new System.EventHandler(this.BtnDailyTask_Click);
            // 
            // txtHBVersion
            // 
            this.txtHBVersion.Location = new System.Drawing.Point(7, 22);
            this.txtHBVersion.Name = "txtHBVersion";
            this.txtHBVersion.Size = new System.Drawing.Size(244, 23);
            this.txtHBVersion.TabIndex = 6;
            this.txtHBVersion.Text = "1.3.218";
            // 
            // txtHKeyServer
            // 
            this.txtHKeyServer.Location = new System.Drawing.Point(7, 22);
            this.txtHKeyServer.Name = "txtHKeyServer";
            this.txtHKeyServer.Size = new System.Drawing.Size(244, 23);
            this.txtHKeyServer.TabIndex = 5;
            this.txtHKeyServer.Text = "http://localhost:9000/encode";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHBVersion);
            this.groupBox1.Location = new System.Drawing.Point(528, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模拟小黑盒版本";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btnDailyTask);
            this.groupBox3.Location = new System.Drawing.Point(528, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基础功能";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(134, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "&C. 模拟客户端";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnTopupThread
            // 
            this.btnTopupThread.Location = new System.Drawing.Point(7, 22);
            this.btnTopupThread.Name = "btnTopupThread";
            this.btnTopupThread.Size = new System.Drawing.Size(117, 28);
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
            this.groupBox4.Location = new System.Drawing.Point(528, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 56);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "特殊功能";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(134, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "&P. 发帖工具";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtHKeyServer);
            this.groupBox5.Location = new System.Drawing.Point(528, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 56);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HkeyServer";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lVAccounts);
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小黑盒 CShape";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.cMenuAccount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ListView lVAccounts;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colLevel;
        private GroupBox groupBox2;
        private Button btnAddAccount;
        private TextBox txtHBVersion;
        private TextBox txtHKeyServer;
        private ColumnHeader colChecks;
        private ColumnHeader colOS;
        private ColumnHeader colDeviceName;
        private ColumnHeader colChannal;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnDailyTask;
        private ContextMenuStrip cMenuAccount;
        private ToolStripMenuItem 更新账号数据ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 编辑当前账号ToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button2;
        private Button btnTopupThread;
        private GroupBox groupBox4;
        private Button button3;
        private Button button4;
        private GroupBox groupBox5;
    }
}
