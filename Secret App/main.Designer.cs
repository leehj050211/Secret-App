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
            this.processKillButton = new System.Windows.Forms.Button();
            this.processNameBox = new System.Windows.Forms.TextBox();
            this.processKillTimer = new System.Windows.Forms.Timer(this.components);
            this.killStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processKillButton
            // 
            this.processKillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.processKillButton.Location = new System.Drawing.Point(143, 307);
            this.processKillButton.Name = "processKillButton";
            this.processKillButton.Size = new System.Drawing.Size(75, 23);
            this.processKillButton.TabIndex = 0;
            this.processKillButton.Text = "프로세스 종료";
            this.processKillButton.UseVisualStyleBackColor = true;
            this.processKillButton.Click += new System.EventHandler(this.processKillButton_Click);
            // 
            // processNameBox
            // 
            this.processNameBox.Location = new System.Drawing.Point(134, 231);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(100, 21);
            this.processNameBox.TabIndex = 1;
            // 
            // processKillTimer
            // 
            this.processKillTimer.Interval = 200;
            this.processKillTimer.Tick += new System.EventHandler(this.processKillTimer_Tick);
            // 
            // killStatus
            // 
            this.killStatus.AutoSize = true;
            this.killStatus.Location = new System.Drawing.Point(166, 268);
            this.killStatus.Name = "killStatus";
            this.killStatus.Size = new System.Drawing.Size(29, 12);
            this.killStatus.TabIndex = 2;
            this.killStatus.Text = "상태";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.killStatus);
            this.Controls.Add(this.processNameBox);
            this.Controls.Add(this.processKillButton);
            this.Name = "main";
            this.Text = "Secret App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processKillButton;
        private System.Windows.Forms.TextBox processNameBox;
        private System.Windows.Forms.Timer processKillTimer;
        private System.Windows.Forms.Label killStatus;
    }
}

