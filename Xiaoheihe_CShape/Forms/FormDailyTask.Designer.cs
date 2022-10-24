namespace Xiaoheihe_CShape.Forms
{
    partial class FormDailyTask
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
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colNo = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colLevel = new System.Windows.Forms.ColumnHeader();
            this.colExp = new System.Windows.Forms.ColumnHeader();
            this.colTask = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.cMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMNot = new System.Windows.Forms.ToolStripMenuItem();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updTaskDelay = new System.Windows.Forms.NumericUpDown();
            this.updThreadCount = new System.Windows.Forms.NumericUpDown();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.gbProxy = new System.Windows.Forms.GroupBox();
            this.cMenuAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTaskDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updThreadCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVAccounts
            // 
            this.lVAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lVAccounts.CheckBoxes = true;
            this.lVAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colHeyboxID,
            this.colNickName,
            this.colLevel,
            this.colExp,
            this.colTask,
            this.colStatus});
            this.lVAccounts.ContextMenuStrip = this.cMenuAccount;
            this.lVAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(0, 0);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(525, 231);
            this.lVAccounts.TabIndex = 0;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
            // 
            // colNo
            // 
            this.colNo.Text = "No";
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
            // colExp
            // 
            this.colExp.Text = "经验";
            this.colExp.Width = 100;
            // 
            // colTask
            // 
            this.colTask.Text = "任务";
            this.colTask.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.Text = "日志";
            this.colStatus.Width = 130;
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
            this.tSMAll.Click += new System.EventHandler(this.TSMAll_Click);
            // 
            // tSMNone
            // 
            this.tSMNone.Name = "tSMNone";
            this.tSMNone.Size = new System.Drawing.Size(112, 22);
            this.tSMNone.Text = "全不选";
            this.tSMNone.Click += new System.EventHandler(this.TSMNone_Click);
            // 
            // tSMNot
            // 
            this.tSMNot.Name = "tSMNot";
            this.tSMNot.Size = new System.Drawing.Size(112, 22);
            this.tSMNot.Text = "反选";
            this.tSMNot.Click += new System.EventHandler(this.TSMNot_Click);
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 17;
            this.lstLog.Location = new System.Drawing.Point(0, 0);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(525, 166);
            this.lstLog.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lVAccounts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstLog);
            this.splitContainer1.Size = new System.Drawing.Size(525, 401);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updTaskDelay);
            this.groupBox1.Controls.Add(this.updThreadCount);
            this.groupBox1.Location = new System.Drawing.Point(543, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "延时(毫秒)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "线程数";
            // 
            // updTaskDelay
            // 
            this.updTaskDelay.Location = new System.Drawing.Point(93, 51);
            this.updTaskDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.updTaskDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updTaskDelay.Name = "updTaskDelay";
            this.updTaskDelay.Size = new System.Drawing.Size(53, 23);
            this.updTaskDelay.TabIndex = 3;
            this.updTaskDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updTaskDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // updThreadCount
            // 
            this.updThreadCount.Location = new System.Drawing.Point(93, 22);
            this.updThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updThreadCount.Name = "updThreadCount";
            this.updThreadCount.Size = new System.Drawing.Size(53, 23);
            this.updThreadCount.TabIndex = 2;
            this.updThreadCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updThreadCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStartTask
            // 
            this.btnStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTask.Location = new System.Drawing.Point(6, 22);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(140, 28);
            this.btnStartTask.TabIndex = 4;
            this.btnStartTask.Text = "&S. 开始任务";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.BtnStartTask_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(543, 385);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(152, 28);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "&C. 清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(102, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "未运行";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnStartTask);
            this.groupBox2.Location = new System.Drawing.Point(543, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 58);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(39, 22);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(75, 21);
            this.chkUseProxy.TabIndex = 0;
            this.chkUseProxy.Text = "使用代理";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            // 
            // gbProxy
            // 
            this.gbProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProxy.Controls.Add(this.chkUseProxy);
            this.gbProxy.Location = new System.Drawing.Point(543, 101);
            this.gbProxy.Name = "gbProxy";
            this.gbProxy.Size = new System.Drawing.Size(152, 50);
            this.gbProxy.TabIndex = 9;
            this.gbProxy.TabStop = false;
            this.gbProxy.Text = "代理设置";
            // 
            // FormDailyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 425);
            this.Controls.Add(this.gbProxy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "FormDailyTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每日任务 - 仅执行勾选的账号";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDailyTask_FormClosing);
            this.Load += new System.EventHandler(this.FormDailyTask_Load);
            this.cMenuAccount.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTaskDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updThreadCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbProxy.ResumeLayout(false);
            this.gbProxy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lVAccounts;
        private ColumnHeader colNo;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colLevel;
        private ColumnHeader colTask;
        private ColumnHeader colExp;
        private ListBox lstLog;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private NumericUpDown updTaskDelay;
        private NumericUpDown updThreadCount;
        private Button btnStartTask;
        private Button btnClearLog;
        private Label label2;
        private Label label1;
        private ContextMenuStrip cMenuAccount;
        private ToolStripMenuItem tSMAll;
        private ToolStripMenuItem tSMNone;
        private ToolStripMenuItem tSMNot;
        private Label lblStatus;
        private GroupBox groupBox2;
        private ColumnHeader colStatus;
        private CheckBox chkUseProxy;
        private GroupBox gbProxy;
    }
}
