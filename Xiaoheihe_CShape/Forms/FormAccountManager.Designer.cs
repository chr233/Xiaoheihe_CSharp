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
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colChecks = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colLevel = new System.Windows.Forms.ColumnHeader();
            this.colOS = new System.Windows.Forms.ColumnHeader();
            this.colDeviceName = new System.Windows.Forms.ColumnHeader();
            this.colChannal = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
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
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(2, 2);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(614, 383);
            this.lVAccounts.TabIndex = 13;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnProfile);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnEditAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Location = new System.Drawing.Point(622, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 195);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号编辑";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(6, 158);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(142, 28);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "&R. 刷新列表";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(7, 124);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(141, 28);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "&I. 查看个人资料";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 90);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(142, 28);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "&D. 删除勾选";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(7, 56);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(141, 28);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "&E. 编辑账号";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 22);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(142, 28);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "&A. 添加账号";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // FormAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lVAccounts);
            this.Name = "FormAccountManager";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListView lVAccounts;
        private ColumnHeader colChecks;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colLevel;
        private ColumnHeader colOS;
        private ColumnHeader colDeviceName;
        private ColumnHeader colChannal;
        private GroupBox groupBox2;
        private Button btnReload;
        private Button btnProfile;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnAddAccount;
    }
}
