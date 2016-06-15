using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refocus
{
    public partial class SettingsPage : Form
    {
        Form1 main;

        public SettingsPage()
        {
            InitializeComponent();
        }

        public SettingsPage(Form1 hoho)
        {
            main = hoho;

            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            updAlertInterval.Value = Properties.Settings.Default.IntervalMins;
            updInactivityDetection.Value = Properties.Settings.Default.InactivityMins;
            cboAlertType.SelectedItem = Properties.Settings.Default.NotificationType;
        }

        private void chkLaunchStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaunchStartup.Checked)
                Form1.SetStartup(true);
            else
                Form1.SetStartup(false);
        }

        private void updAlertInterval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervalMins = (int)updAlertInterval.Value;
            main.interval = new TimeSpan(0, (int)updAlertInterval.Value, 0);
        }

        private void cboAlertType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NotificationType = cboAlertType.SelectedItem.ToString();
        }

        private void btnAlertTest_Click(object sender, EventArgs e)
        {
            main.SendNotification();
        }

        private void updInactivityDetection_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.InactivityMins = (int)updInactivityDetection.Value;
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            updAlertInterval.Value = Properties.Settings.Default.IntervalMins;
            updInactivityDetection.Value = Properties.Settings.Default.InactivityMins;
            cboAlertType.SelectedItem = Properties.Settings.Default.NotificationType;

            Form1.SetStartup(false);
        }

    }
}
