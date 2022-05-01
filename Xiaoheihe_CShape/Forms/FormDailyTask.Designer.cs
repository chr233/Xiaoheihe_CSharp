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
            this.colTask = new System.Windows.Forms.ColumnHeader();
            this.colLog = new System.Windows.Forms.ColumnHeader();
            this.tSControl = new System.Windows.Forms.ToolStrip();
            this.tSBtnStartTask = new System.Windows.Forms.ToolStripButton();
            this.tSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBtnMulitSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSLbl1 = new System.Windows.Forms.ToolStripLabel();
            this.tSTxtThread = new System.Windows.Forms.ToolStripTextBox();
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
            this.colTask,
            this.colLog});
            this.lVAccounts.FullRowSelect = true;
            this.lVAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVAccounts.Location = new System.Drawing.Point(0, 28);
            this.lVAccounts.MultiSelect = false;
            this.lVAccounts.Name = "lVAccounts";
            this.lVAccounts.Size = new System.Drawing.Size(574, 331);
            this.lVAccounts.TabIndex = 1;
            this.lVAccounts.UseCompatibleStateImageBehavior = false;
            this.lVAccounts.View = System.Windows.Forms.View.Details;
            this.lVAccounts.SelectedIndexChanged += new System.EventHandler(this.lVAccounts_SelectedIndexChanged);
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
            // colTask
            // 
            this.colTask.Text = "任务";
            this.colTask.Width = 120;
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
            this.tSBtnStartTask,
            this.tSS1,
            this.tSBtnMulitSelect,
            this.tSS2,
            this.tSLbl1,
            this.tSTxtThread,
            this.tSLblStatus});
            this.tSControl.Location = new System.Drawing.Point(0, 0);
            this.tSControl.Name = "tSControl";
            this.tSControl.Size = new System.Drawing.Size(574, 25);
            this.tSControl.TabIndex = 3;
            this.tSControl.Text = "toolStrip1";
            // 
            // tSBtnStartTask
            // 
            this.tSBtnStartTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnStartTask.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnStartTask.Image")));
            this.tSBtnStartTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnStartTask.Name = "tSBtnStartTask";
            this.tSBtnStartTask.Size = new System.Drawing.Size(60, 22);
            this.tSBtnStartTask.Text = "开始任务";
            this.tSBtnStartTask.Click += new System.EventHandler(this.TSBtnStartTask_Click);
            // 
            // tSS1
            // 
            this.tSS1.Name = "tSS1";
            this.tSS1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBtnMulitSelect
            // 
            this.tSBtnMulitSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnMulitSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.tSBtnMulitSelect.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnMulitSelect.Image")));
            this.tSBtnMulitSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnMulitSelect.Name = "tSBtnMulitSelect";
            this.tSBtnMulitSelect.Size = new System.Drawing.Size(45, 22);
            this.tSBtnMulitSelect.Text = "多选";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem1.Text = "全选";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "全不选";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem3.Text = "反选";
            // 
            // tSS2
            // 
            this.tSS2.Name = "tSS2";
            this.tSS2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSLbl1
            // 
            this.tSLbl1.Name = "tSLbl1";
            this.tSLbl1.Size = new System.Drawing.Size(44, 22);
            this.tSLbl1.Text = "线程数";
            // 
            // tSTxtThread
            // 
            this.tSTxtThread.Name = "tSTxtThread";
            this.tSTxtThread.Size = new System.Drawing.Size(50, 25);
            this.tSTxtThread.Text = "1";
            this.tSTxtThread.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSLblStatus
            // 
            this.tSLblStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSLblStatus.Name = "tSLblStatus";
            this.tSLblStatus.Size = new System.Drawing.Size(63, 22);
            this.tSLblStatus.Text = "状态: 停止";
            // 
            // FormDailyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 359);
            this.Controls.Add(this.tSControl);
            this.Controls.Add(this.lVAccounts);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "FormDailyTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "每日任务";
            this.Load += new System.EventHandler(this.FormDailyTask_Load);
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
        private ToolStripDropDownButton tSBtnMulitSelect;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripButton tSBtnStopTask;
        private ToolStripLabel tSLbl1;
        private ToolStripTextBox tSTxtThread;
    }
}
