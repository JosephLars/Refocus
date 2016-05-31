using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayTester
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

        private void intervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervalMins = (int)intervalUpDown.Value;
            main.interval = new TimeSpan(0, (int)intervalUpDown.Value, 0);
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            intervalUpDown.Value = Properties.Settings.Default.IntervalMins;
            inactivityIntervalUpDown.Value = Properties.Settings.Default.InactivitySecs;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Form1.SetStartup(true);
            else
                Form1.SetStartup(false);
        }

        private void inactivityIntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.InactivitySecs = (int)inactivityIntervalUpDown.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            intervalUpDown.Value = Properties.Settings.Default.IntervalMins;
            inactivityIntervalUpDown.Value = Properties.Settings.Default.InactivitySecs;

            Form1.SetStartup(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.SendNotification();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NotificationType = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.startTime = DateTime.Now;
        }


    }
}
