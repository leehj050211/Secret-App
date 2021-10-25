namespace Secret_App
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.processKillButton = new System.Windows.Forms.Button();
            this.processNameBox = new System.Windows.Forms.TextBox();
            this.processKillTimer = new System.Windows.Forms.Timer(this.components);
            this.killStatus = new System.Windows.Forms.Label();
            this.programExit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // processKillButton
            // 
            this.processKillButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processKillButton.AutoSize = true;
            this.processKillButton.Location = new System.Drawing.Point(68, 202);
            this.processKillButton.Name = "processKillButton";
            this.processKillButton.Size = new System.Drawing.Size(131, 23);
            this.processKillButton.TabIndex = 0;
            this.processKillButton.Text = "켜고 트레이로 최소화";
            this.processKillButton.UseVisualStyleBackColor = true;
            this.processKillButton.Click += new System.EventHandler(this.processKillButton_Click);
            // 
            // processNameBox
            // 
            this.processNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processNameBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.processNameBox.ForeColor = System.Drawing.Color.Gray;
            this.processNameBox.Location = new System.Drawing.Point(59, 149);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(151, 21);
            this.processNameBox.TabIndex = 1;
            this.processNameBox.Text = "잠그려는 창의 제목을 입력";
            this.processNameBox.Enter += new System.EventHandler(this.processNameBox_Enter);
            this.processNameBox.Leave += new System.EventHandler(this.processNameBox_Leave);
            // 
            // processKillTimer
            // 
            this.processKillTimer.Interval = 200;
            this.processKillTimer.Tick += new System.EventHandler(this.processKillTimer_Tick);
            // 
            // killStatus
            // 
            this.killStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.killStatus.AutoSize = true;
            this.killStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.killStatus.Location = new System.Drawing.Point(83, 115);
            this.killStatus.Name = "killStatus";
            this.killStatus.Size = new System.Drawing.Size(97, 12);
            this.killStatus.TabIndex = 2;
            this.killStatus.Text = "사생활 보호 꺼짐";
            this.killStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programExit
            // 
            this.programExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.programExit.AutoSize = true;
            this.programExit.Location = new System.Drawing.Point(94, 242);
            this.programExit.Name = "programExit";
            this.programExit.Size = new System.Drawing.Size(75, 23);
            this.programExit.TabIndex = 3;
            this.programExit.Text = "종료";
            this.programExit.UseVisualStyleBackColor = true;
            this.programExit.Click += new System.EventHandler(this.programExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Secret App";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(264, 341);
            this.Controls.Add(this.programExit);
            this.Controls.Add(this.killStatus);
            this.Controls.Add(this.processNameBox);
            this.Controls.Add(this.processKillButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Secret App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processKillButton;
        private System.Windows.Forms.TextBox processNameBox;
        private System.Windows.Forms.Timer processKillTimer;
        private System.Windows.Forms.Label killStatus;
        private System.Windows.Forms.Button programExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

