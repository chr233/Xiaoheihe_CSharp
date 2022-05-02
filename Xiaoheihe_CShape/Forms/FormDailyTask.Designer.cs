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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDailyTask));
            this.lVAccounts = new System.Windows.Forms.ListView();
            this.colChecks = new System.Windows.Forms.ColumnHeader();
            this.colHeyboxID = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colLevel = new System.Windows.Forms.ColumnHeader();
            this.colExp = new System.Windows.Forms.ColumnHeader();
            this.colTask = new System.Windows.Forms.ColumnHeader();
            this.colLog = new System.Windows.Forms.ColumnHeader();
            this.tSControl = new System.Windows.Forms.ToolStrip();
            this.tSBtnAll = new System.Windows.Forms.ToolStripButton();
            this.tSBtnNone = new System.Windows.Forms.ToolStripButton();
            this.tSBtnNot = new System.Windows.Forms.ToolStripButton();
            this.tSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLbl1 = new System.Windows.Forms.ToolStripLabel();
            this.tSTxtThread = new System.Windows.Forms.ToolStripTextBox();
            this.tSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLbl2 = new System.Windows.Forms.ToolStripLabel();
            this.tSTxtDelay = new System.Windows.Forms.ToolStripTextBox();
            this.tSBtnStartTask = new System.Windows.Forms.ToolStripButton();
            this.tSS3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLblStatus = new System.Windows.Forms.ToolStripLabel();
            this.tSControl.SuspendLayout();
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
            this.colExp,
            this.colTask,
            this.colLog});
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(0, 25);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(671, 336);
            this.lVAccounts.TabIndex = 1;
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
            // colLog
            // 
            this.colLog.Text = "日志";
            this.colLog.Width = 150;
            // 
            // tSControl
            // 
            this.tSControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAll,
            this.tSBtnNone,
            this.tSBtnNot,
            this.tSS1,
            this.tSLbl1,
            this.tSTxtThread,
            this.tSS2,
            this.tSLbl2,
            this.tSTxtDelay,
            this.tSBtnStartTask,
            this.tSS3,
            this.tSLblStatus});
            this.tSControl.Location = new System.Drawing.Point(0, 0);
            this.tSControl.Name = "tSControl";
            this.tSControl.Size = new System.Drawing.Size(671, 25);
            this.tSControl.TabIndex = 3;
            this.tSControl.Text = "toolStrip1";
            // 
            // tSBtnAll
            // 
            this.tSBtnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnAll.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAll.Image")));
            this.tSBtnAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAll.Name = "tSBtnAll";
            this.tSBtnAll.Size = new System.Drawing.Size(36, 22);
            this.tSBtnAll.Text = "全选";
            this.tSBtnAll.Click += new System.EventHandler(this.TSBtnAll_Click);
            // 
            // tSBtnNone
            // 
            this.tSBtnNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnNone.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnNone.Image")));
            this.tSBtnNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnNone.Name = "tSBtnNone";
            this.tSBtnNone.Size = new System.Drawing.Size(48, 22);
            this.tSBtnNone.Text = "全不选";
            this.tSBtnNone.Click += new System.EventHandler(this.TSBtnNone_Click);
            // 
            // tSBtnNot
            // 
            this.tSBtnNot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnNot.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnNot.Image")));
            this.tSBtnNot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnNot.Name = "tSBtnNot";
            this.tSBtnNot.Size = new System.Drawing.Size(36, 22);
            this.tSBtnNot.Text = "反选";
            this.tSBtnNot.Click += new System.EventHandler(this.TSBtnNot_Click);
            // 
            // tSS1
            // 
            this.tSS1.Name = "tSS1";
            this.tSS1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSLbl1
            // 
            this.tSLbl1.Name = "tSLbl1";
            this.tSLbl1.Size = new System.Drawing.Size(44, 22);
            this.tSLbl1.Text = "线程数";
            this.tSLbl1.ToolTipText = "工作线程数量";
            // 
            // tSTxtThread
            // 
            this.tSTxtThread.Name = "tSTxtThread";
            this.tSTxtThread.Size = new System.Drawing.Size(50, 25);
            this.tSTxtThread.Text = "1";
            this.tSTxtThread.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tSTxtThread.ToolTipText = "工作线程数量";
            // 
            // tSS2
            // 
            this.tSS2.Name = "tSS2";
            this.tSS2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSLbl2
            // 
            this.tSLbl2.Name = "tSLbl2";
            this.tSLbl2.Size = new System.Drawing.Size(64, 22);
            this.tSLbl2.Text = "延时(毫秒)";
            this.tSLbl2.ToolTipText = "延时时间设定(毫秒)";
            // 
            // tSTxtDelay
            // 
            this.tSTxtDelay.Name = "tSTxtDelay";
            this.tSTxtDelay.Size = new System.Drawing.Size(50, 25);
            this.tSTxtDelay.Text = "500";
            this.tSTxtDelay.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tSTxtDelay.ToolTipText = "延时时间设定(毫秒)";
            // 
            // tSBtnStartTask
            // 
            this.tSBtnStartTask.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBtnStartTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnStartTask.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnStartTask.Image")));
            this.tSBtnStartTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnStartTask.Name = "tSBtnStartTask";
            this.tSBtnStartTask.Size = new System.Drawing.Size(60, 22);
            this.tSBtnStartTask.Text = "开始任务";
            this.tSBtnStartTask.Click += new System.EventHandler(this.TSBtnStartTask_Click);
            // 
            // tSS3
            // 
            this.tSS3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSS3.Name = "tSS3";
            this.tSS3.Size = new System.Drawing.Size(6, 25);
            // 
            // tSLblStatus
            // 
            this.tSLblStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSLblStatus.Name = "tSLblStatus";
            this.tSLblStatus.Size = new System.Drawing.Size(63, 22);
            this.tSLblStatus.Text = "状态: 停止";
            this.tSLblStatus.ToolTipText = "任务执行状态";
            // 
            // FormDailyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.tSControl);
            this.Controls.Add(this.lVAccounts);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "FormDailyTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每日任务 - 仅执行勾选的账号";
            this.tSControl.ResumeLayout(false);
            this.tSControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lVAccounts;
        private ColumnHeader colChecks;
        private ColumnHeader colHeyboxID;
        private ColumnHeader colNickName;
        private ColumnHeader colLevel;
        private ToolStrip tSControl;
        private ColumnHeader colTask;
        private ColumnHeader colLog;
        private ToolStripButton tSBtnStartTask;
        private ToolStripSeparator tSS1;
        private ToolStripLabel tSLblStatus;
        private ToolStripSeparator tSS2;
        private ToolStripLabel tSLbl1;
        private ToolStripTextBox tSTxtThread;
        private ToolStripSeparator tSS3;
        private ToolStripLabel tSLbl2;
        private ToolStripTextBox tSTxtDelay;
        private ToolStripButton tSBtnAll;
        private ToolStripButton tSBtnNone;
        private ToolStripButton tSBtnNot;
        private ColumnHeader colExp;
    }
}
