using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Secret_App
{
    public partial class main : Form
    {
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
                processKillTimer.Enabled = false;
                killStatus.Text = "프라이버시 보호 꺼짐";
                processKillButton.Text = "켜고 트레이로 최소화";
            }
            else
            {
                processKillTimer.Enabled = true;
                killStatus.Text = "프라이버시 보호 켜짐";
                processKillButton.Text = "끄기";
                this.Hide();
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closeCancel;
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            closeCancel = false;
            this.Close();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
