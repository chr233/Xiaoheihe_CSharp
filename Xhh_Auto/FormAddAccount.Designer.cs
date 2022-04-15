namespace Xhh_Auto
{
    partial class FormAddAccount
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRandomImei = new System.Windows.Forms.Button();
            this.txtChannal = new System.Windows.Forms.TextBox();
            this.txtDeviceInfo = new System.Windows.Forms.TextBox();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.txtOSType = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeyboxID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Controls.Add(this.btnRandomImei);
            this.groupBox2.Controls.Add(this.txtChannal);
            this.groupBox2.Controls.Add(this.txtDeviceInfo);
            this.groupBox2.Controls.Add(this.txtOSVersion);
            this.groupBox2.Controls.Add(this.txtOSType);
            this.groupBox2.Controls.Add(this.txtImei);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPkey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHeyboxID);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入账号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 99;
            this.label7.Text = "渠道";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "手机型号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "系统版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "系统类型";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(216, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&C. 取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(81, 234);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&A. 添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRandomImei
            // 
            this.btnRandomImei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomImei.Location = new System.Drawing.Point(231, 80);
            this.btnRandomImei.Name = "btnRandomImei";
            this.btnRandomImei.Size = new System.Drawing.Size(107, 23);
            this.btnRandomImei.TabIndex = 9;
            this.btnRandomImei.Text = "&R. 随机生成";
            this.btnRandomImei.UseVisualStyleBackColor = true;
            this.btnRandomImei.Click += new System.EventHandler(this.btnRandomImei_Click);
            // 
            // txtChannal
            // 
            this.txtChannal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannal.Location = new System.Drawing.Point(81, 196);
            this.txtChannal.Name = "txtChannal";
            this.txtChannal.PlaceholderText = "heybox_xiaomi";
            this.txtChannal.Size = new System.Drawing.Size(257, 23);
            this.txtChannal.TabIndex = 6;
            // 
            // txtDeviceInfo
            // 
            this.txtDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceInfo.Location = new System.Drawing.Point(81, 167);
            this.txtDeviceInfo.Name = "txtDeviceInfo";
            this.txtDeviceInfo.PlaceholderText = "K40";
            this.txtDeviceInfo.Size = new System.Drawing.Size(257, 23);
            this.txtDeviceInfo.TabIndex = 5;
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOSVersion.Location = new System.Drawing.Point(81, 138);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.PlaceholderText = "11";
            this.txtOSVersion.Size = new System.Drawing.Size(257, 23);
            this.txtOSVersion.TabIndex = 4;
            // 
            // txtOSType
            // 
            this.txtOSType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOSType.Location = new System.Drawing.Point(81, 109);
            this.txtOSType.Name = "txtOSType";
            this.txtOSType.PlaceholderText = "Android";
            this.txtOSType.Size = new System.Drawing.Size(257, 23);
            this.txtOSType.TabIndex = 3;
            // 
            // txtImei
            // 
            this.txtImei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImei.Location = new System.Drawing.Point(81, 80);
            this.txtImei.Name = "txtImei";
            this.txtImei.PlaceholderText = "Imei";
            this.txtImei.Size = new System.Drawing.Size(144, 23);
            this.txtImei.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Imei";
            // 
            // txtPkey
            // 
            this.txtPkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPkey.Location = new System.Drawing.Point(81, 51);
            this.txtPkey.Name = "txtPkey";
            this.txtPkey.PlaceholderText = "PKey";
            this.txtPkey.Size = new System.Drawing.Size(257, 23);
            this.txtPkey.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Pkey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Heybox ID";
            // 
            // txtHeyboxID
            // 
            this.txtHeyboxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeyboxID.Location = new System.Drawing.Point(81, 22);
            this.txtHeyboxID.Name = "txtHeyboxID";
            this.txtHeyboxID.PlaceholderText = "Heybox ID";
            this.txtHeyboxID.Size = new System.Drawing.Size(257, 23);
            this.txtHeyboxID.TabIndex = 0;
            // 
            // FormAddAccount
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 295);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "导入账号";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private Button btnOK;
        private Button btnRandomImei;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        internal TextBox txtImei;
        internal TextBox txtPkey;
        internal TextBox txtHeyboxID;
        private Label label6;
        private Label label2;
        private Label label1;
        internal TextBox txtDeviceInfo;
        internal TextBox txtOSVersion;
        internal TextBox txtOSType;
        private Label label7;
        internal TextBox txtChannal;
    }
}