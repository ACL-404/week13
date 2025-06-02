namespace week13
{
    partial class from
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(from));
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timercook = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.txtDown = new System.Windows.Forms.TextBox();
            this.cmbCountHour = new System.Windows.Forms.ComboBox();
            this.cmbCountMin = new System.Windows.Forms.ComboBox();
            this.cmbCountSecond = new System.Windows.Forms.ComboBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStop = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCountStop);
            this.tabPage3.Controls.Add(this.btnCountPause);
            this.tabPage3.Controls.Add(this.btnCountStart);
            this.tabPage3.Controls.Add(this.cmbCountSecond);
            this.tabPage3.Controls.Add(this.cmbCountMin);
            this.tabPage3.Controls.Add(this.cmbCountHour);
            this.tabPage3.Controls.Add(this.txtDown);
            this.tabPage3.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtStopWatch);
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.listStopWatchLog);
            this.tabPage2.Controls.Add(this.btnLog);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(429, 307);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(322, 68);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "停止並歸零";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 20;
            this.listStopWatchLog.Location = new System.Drawing.Point(23, 171);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(395, 204);
            this.listStopWatchLog.TabIndex = 10;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(593, 240);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(158, 61);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(429, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 61);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.Location = new System.Drawing.Point(593, 171);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(158, 63);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(429, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 63);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.cmbMin);
            this.tabPage1.Controls.Add(this.cmbHour);
            this.tabPage1.Controls.Add(this.txtWeekDay);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Controls.Add(this.btnCancelAlert);
            this.tabPage1.Controls.Add(this.btnSetAlert);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(210, 162);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(186, 28);
            this.cmbMin.TabIndex = 10;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(23, 162);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(186, 28);
            this.cmbHour.TabIndex = 9;
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Font = new System.Drawing.Font("新細明體", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeekDay.Location = new System.Drawing.Point(402, 89);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(349, 67);
            this.txtWeekDay.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("新細明體", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(23, 89);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(373, 67);
            this.txtDate.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("新細明體", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(23, 19);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(728, 67);
            this.txtTime.TabIndex = 6;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelAlert.Location = new System.Drawing.Point(585, 162);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(166, 63);
            this.btnCancelAlert.TabIndex = 1;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = false;
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(402, 162);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(177, 63);
            this.btnSetAlert.TabIndex = 0;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // timercook
            // 
            this.timercook.Tick += new System.EventHandler(this.timercook_Tick);
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Font = new System.Drawing.Font("新細明體", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.Location = new System.Drawing.Point(23, 62);
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(728, 103);
            this.txtStopWatch.TabIndex = 12;
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // txtDown
            // 
            this.txtDown.Font = new System.Drawing.Font("新細明體", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDown.Location = new System.Drawing.Point(14, 3);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(728, 103);
            this.txtDown.TabIndex = 13;
            // 
            // cmbCountHour
            // 
            this.cmbCountHour.FormattingEnabled = true;
            this.cmbCountHour.Location = new System.Drawing.Point(14, 112);
            this.cmbCountHour.Name = "cmbCountHour";
            this.cmbCountHour.Size = new System.Drawing.Size(186, 28);
            this.cmbCountHour.TabIndex = 14;
            // 
            // cmbCountMin
            // 
            this.cmbCountMin.FormattingEnabled = true;
            this.cmbCountMin.Location = new System.Drawing.Point(206, 112);
            this.cmbCountMin.Name = "cmbCountMin";
            this.cmbCountMin.Size = new System.Drawing.Size(186, 28);
            this.cmbCountMin.TabIndex = 15;
            // 
            // cmbCountSecond
            // 
            this.cmbCountSecond.FormattingEnabled = true;
            this.cmbCountSecond.Location = new System.Drawing.Point(398, 112);
            this.cmbCountSecond.Name = "cmbCountSecond";
            this.cmbCountSecond.Size = new System.Drawing.Size(186, 28);
            this.cmbCountSecond.TabIndex = 16;
            // 
            // btnCountStart
            // 
            this.btnCountStart.Location = new System.Drawing.Point(14, 146);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(158, 63);
            this.btnCountStart.TabIndex = 17;
            this.btnCountStart.Text = "開始";
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // btnCountPause
            // 
            this.btnCountPause.Location = new System.Drawing.Point(206, 146);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(158, 63);
            this.btnCountPause.TabIndex = 18;
            this.btnCountPause.Text = "暫停";
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStop
            // 
            this.btnCountStop.Location = new System.Drawing.Point(398, 146);
            this.btnCountStop.Name = "btnCountStop";
            this.btnCountStop.Size = new System.Drawing.Size(158, 63);
            this.btnCountStop.TabIndex = 19;
            this.btnCountStop.Text = "停止";
            this.btnCountStop.UseVisualStyleBackColor = true;
            this.btnCountStop.Click += new System.EventHandler(this.btnCountStop_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "from";
            this.RightToLeftLayout = true;
            this.Text = "簡單時鐘";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timercook;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button btnCountStop;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.ComboBox cmbCountSecond;
        private System.Windows.Forms.ComboBox cmbCountMin;
        private System.Windows.Forms.ComboBox cmbCountHour;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

