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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDailyTask = new System.Windows.Forms.Button();
            this.txtHBVersion = new System.Windows.Forms.TextBox();
            this.txtHKeyServer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cMenuAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.lVAccounts.Size = new System.Drawing.Size(540, 422);
            this.lVAccounts.TabIndex = 0;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
            this.lVAccounts.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LVAccounts_ItemChecked);
            this.lVAccounts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lVAccounts_MouseClick);
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
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Location = new System.Drawing.Point(546, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号编辑";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "查看个人资料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "测试勾选账号";
            this.button1.UseVisualStyleBackColor = true;
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
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(129, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(117, 28);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnDailyTask
            // 
            this.btnDailyTask.Location = new System.Drawing.Point(7, 22);
            this.btnDailyTask.Name = "btnDailyTask";
            this.btnDailyTask.Size = new System.Drawing.Size(117, 28);
            this.btnDailyTask.TabIndex = 7;
            this.btnDailyTask.Text = "&T. 每日任务";
            this.btnDailyTask.UseVisualStyleBackColor = true;
            this.btnDailyTask.Click += new System.EventHandler(this.btnDailyTask_Click);
            // 
            // txtHBVersion
            // 
            this.txtHBVersion.Location = new System.Drawing.Point(111, 50);
            this.txtHBVersion.Name = "txtHBVersion";
            this.txtHBVersion.Size = new System.Drawing.Size(196, 23);
            this.txtHBVersion.TabIndex = 6;
            this.txtHBVersion.Text = "1.3.218";
            // 
            // txtHKeyServer
            // 
            this.txtHKeyServer.Location = new System.Drawing.Point(111, 22);
            this.txtHKeyServer.Name = "txtHKeyServer";
            this.txtHKeyServer.Size = new System.Drawing.Size(196, 23);
            this.txtHKeyServer.TabIndex = 5;
            this.txtHKeyServer.Text = "http://localhost:9000/encode";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHKeyServer);
            this.groupBox1.Controls.Add(this.txtHBVersion);
            this.groupBox1.Location = new System.Drawing.Point(546, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全局设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "模拟小黑盒版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "HkeyServer地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnTest);
            this.groupBox3.Controls.Add(this.btnDailyTask);
            this.groupBox3.Location = new System.Drawing.Point(546, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "集成工具";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(867, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lVAccounts);
            this.MinimumSize = new System.Drawing.Size(800, 320);
            this.Name = "FormMain";
            this.Text = "小黑盒 CShape";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.cMenuAccount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private Button btnTest;
        private ContextMenuStrip cMenuAccount;
        private ToolStripMenuItem 更新账号数据ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 编辑当前账号ToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button2;
        private Button button1;
    }
}
