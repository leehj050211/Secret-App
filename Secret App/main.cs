using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Secret_App
{
    public partial class main : Form
    {
        String processName = "";
        public main()
        {
            InitializeComponent();
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
                killStatus.Text = "프로세스 종료 꺼짐";
            }
            else
            {
                processKillTimer.Enabled = true;
                killStatus.Text = "프로세스 종료 켜짐";
            }
        }
    }
}
