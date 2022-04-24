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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPDailyTask = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colChecks = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colLevel = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colOS = new System.Windows.Forms.ColumnHeader();
            this.colOSVersion = new System.Windows.Forms.ColumnHeader();
            this.colDeviceName = new System.Windows.Forms.ColumnHeader();
            this.colChannal = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDailyTask = new System.Windows.Forms.Button();
            this.txtHBVersion = new System.Windows.Forms.TextBox();
            this.txtHKeyServer = new System.Windows.Forms.TextBox();
            this.btnImportAccount = new System.Windows.Forms.Button();
            this.btnExportAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tPDailyTask);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(626, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 321);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tPDailyTask
            // 
            this.tPDailyTask.Location = new System.Drawing.Point(4, 26);
            this.tPDailyTask.Name = "tPDailyTask";
            this.tPDailyTask.Padding = new System.Windows.Forms.Padding(3);
            this.tPDailyTask.Size = new System.Drawing.Size(332, 291);
            this.tPDailyTask.TabIndex = 0;
            this.tPDailyTask.Text = "每日任务";
            this.tPDailyTask.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lVAccounts
            // 
            this.lVAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lVAccounts.CheckBoxes = true;
            this.lVAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChecks,
            this.colHeyboxID,
            this.colNickName,
            this.colLevel,
            this.colStatus,
            this.colOS,
            this.colOSVersion,
            this.colDeviceName,
            this.colChannal});
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(1, 0);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(619, 474);
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
            // colStatus
            // 
            this.colStatus.Text = "状态";
            this.colStatus.Width = 80;
            // 
            // colOS
            // 
            this.colOS.Text = "系统";
            // 
            // colOSVersion
            // 
            this.colOSVersion.Text = "版本";
            // 
            // colDeviceName
            // 
            this.colDeviceName.Text = "手机型号";
            // 
            // colChannal
            // 
            this.colChannal.Text = "渠道";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.btnDailyTask);
            this.groupBox2.Controls.Add(this.txtHBVersion);
            this.groupBox2.Controls.Add(this.txtHKeyServer);
            this.groupBox2.Controls.Add(this.btnImportAccount);
            this.groupBox2.Controls.Add(this.btnExportAccount);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Location = new System.Drawing.Point(626, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(129, 89);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(99, 28);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnDailyTask
            // 
            this.btnDailyTask.Location = new System.Drawing.Point(129, 22);
            this.btnDailyTask.Name = "btnDailyTask";
            this.btnDailyTask.Size = new System.Drawing.Size(99, 28);
            this.btnDailyTask.TabIndex = 7;
            this.btnDailyTask.Text = "每日任务";
            this.btnDailyTask.UseVisualStyleBackColor = true;
            // 
            // txtHBVersion
            // 
            this.txtHBVersion.Location = new System.Drawing.Point(236, 124);
            this.txtHBVersion.Name = "txtHBVersion";
            this.txtHBVersion.Size = new System.Drawing.Size(99, 23);
            this.txtHBVersion.TabIndex = 6;
            this.txtHBVersion.Text = "1.3.217";
            // 
            // txtHKeyServer
            // 
            this.txtHKeyServer.Location = new System.Drawing.Point(6, 124);
            this.txtHKeyServer.Name = "txtHKeyServer";
            this.txtHKeyServer.Size = new System.Drawing.Size(224, 23);
            this.txtHKeyServer.TabIndex = 5;
            this.txtHKeyServer.Text = "http://localhost:9000/encode";
            // 
            // btnImportAccount
            // 
            this.btnImportAccount.Location = new System.Drawing.Point(236, 22);
            this.btnImportAccount.Name = "btnImportAccount";
            this.btnImportAccount.Size = new System.Drawing.Size(99, 28);
            this.btnImportAccount.TabIndex = 1;
            this.btnImportAccount.Text = "导入账号";
            this.btnImportAccount.UseVisualStyleBackColor = true;
            // 
            // btnExportAccount
            // 
            this.btnExportAccount.Location = new System.Drawing.Point(236, 56);
            this.btnExportAccount.Name = "btnExportAccount";
            this.btnExportAccount.Size = new System.Drawing.Size(99, 28);
            this.btnExportAccount.TabIndex = 1;
            this.btnExportAccount.Text = "导出账号";
            this.btnExportAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 89);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(117, 28);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "&D. 删除选中账号";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(6, 56);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lVAccounts);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "小黑盒 CShape";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tPDailyTask;
        private TabPage tabPage2;
        private ListView lVAccounts;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colLevel;
        private ColumnHeader colStatus;
        private GroupBox groupBox2;
        private Button btnExportAccount;
        private Button btnAddAccount;
        private Button btnImportAccount;
        private TextBox txtHBVersion;
        private TextBox txtHKeyServer;
        private ColumnHeader colChecks;
        private ColumnHeader colOS;
        private ColumnHeader colOSVersion;
        private ColumnHeader colDeviceName;
        private ColumnHeader colChannal;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnDailyTask;
        private Button btnTest;
    }
}
