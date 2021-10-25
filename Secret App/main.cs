using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Secret_App
{
    public partial class main : Form
    {
        [DllImport("user32")] private static extern bool LockWorkStation();

        String processName = "";
        bool closeCancel = true;
        public main()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void processKillTimer_Tick(object sender, EventArgs e)
        {
            foreach(Process process in Process.GetProcesses()){
                if (process.MainWindowTitle.Contains(processName)){
                    process.Kill();
                }
            }
        }
        private void processKillButton_Click(object sender, EventArgs e)
        {
            processName = processNameBox.Text;
            if (processKillTimer.Enabled)
            {
                LockWorkStation();
                processKillTimer.Enabled = false;
                killStatus.Text = "사생활 보호 꺼짐";
                processKillButton.Text = "켜고 트레이로 최소화";
            }
            else
            {
                processKillTimer.Enabled = true;
                killStatus.Text = "사생활 보호 켜짐";
                processKillButton.Text = "끄고 화면 잠금";
                this.Hide();
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closeCancel;
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            LockWorkStation();
            closeCancel = false;
            this.Close();
        }
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void processNameBox_Enter(object sender, EventArgs e)
        {
            if (processNameBox.ForeColor == Color.Gray)
            {
                processNameBox.Text = "";
                processNameBox.ForeColor = Color.FromArgb(232, 234, 237);
            }
        }

        private void processNameBox_Leave(object sender, EventArgs e)
        {
            if (processNameBox.Text == "잠그려는 창의 제목을 입력")
            {
                processNameBox.Text = processNameBox.Tag.ToString();
                processNameBox.ForeColor = Color.Gray;
            }
        }
    }
}
