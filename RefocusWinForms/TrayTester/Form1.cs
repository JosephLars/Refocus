using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace TrayTester
{
    public partial class Form1 : Form
    {

        // ContextMenu's Exit command used
        private bool allowClose;

        //Startup registry key and value
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "TrayTester";

        InactiveTimeRetriever _inactiveTimeRetriever;

        public DateTime startTime;
        public TimeSpan interval;

        public Form1()
        {
            InitializeComponent();

            Properties.Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);

            _inactiveTimeRetriever = new InactiveTimeRetriever();

            startTime = DateTime.Now;
            interval = new TimeSpan(0, Properties.Settings.Default.IntervalMins, 0);

            SetUp();
        }

        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        protected override void SetVisibleCore(bool value)
        {
            value = false;
            if (!this.IsHandleCreated)
                CreateHandle();

            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Reset elapsedTime if inactive
            if (Properties.Settings.Default.InactivityDetection == true)
                if (_inactiveTimeRetriever.GetInactiveTime().Value.TotalSeconds > Properties.Settings.Default.InactivitySecs)
                    startTime = DateTime.Now;

            //Notify and reset elapsedTime if interval reached
            if (startTime + interval <= DateTime.Now)
            {
                SendNotification();
                startTime = DateTime.Now;
            }

            //Print timeLeft
            PrintTimeLeft();
        }

        public void SendNotification()
        {
            if (Properties.Settings.Default.NotificationType == "Balloon Tooltip")
                SendBubble();
            else if (Properties.Settings.Default.NotificationType == "Message Box")
                SendMessageBox();
        }

        private void SendBubble()
        {
            this.notifyIcon1.BalloonTipText = "Take a break";
            this.notifyIcon1.BalloonTipTitle = "Refocus";
            this.notifyIcon1.ShowBalloonTip(10000);
        }

        public void SendMessageBox()
        {
            MessageBox.Show("Take a break", "Refocus");
        }

        private void PrintTimeLeft()
        {
            DateTime endTime = startTime + interval;
            TimeSpan timeLeft = endTime.Subtract(DateTime.Now);

            if (timeLeft.TotalSeconds <= 3)
            {
                contextMenuStrip1.Items[0].ForeColor = Color.Coral;
                contextMenuStrip1.Items[1].ForeColor = Color.Coral;
            }
            else
            {
                contextMenuStrip1.Items[0].ForeColor = Color.Teal;
                contextMenuStrip1.Items[1].ForeColor = Color.Teal;
            }


            contextMenuStrip1.Items[0].Text = timeLeft.ToString(@"mm\:ss");
        }

        private void SetUp()
        {
            //Time Remaining Display
            Label time = new Label()
            {
                Font = new Font(contextMenuStrip1.Font.FontFamily, 30),
                //TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            contextMenuStrip1.Items.Insert(0, new ToolStripControlHost(time));
            //contextMenuStrip1.Items[0].AutoSize = false;
            //contextMenuStrip1.Items[0].Height = 50;


            //Time Remaining Description
            Label timeUnit = new Label()
            {
                Text = "Mins till break",
                Font = new Font(contextMenuStrip1.Font, FontStyle.Italic),
                //TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            contextMenuStrip1.Items.Insert(1, new ToolStripControlHost(timeUnit));
            //contextMenuStrip1.Items[2].AutoSize = false;


            PrintTimeLeft();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var about = new AboutPage();
            about.ShowDialog();

            //For testing launch on startup property
            ////MessageBox.Show(Properties.Settings.Default.LaunchOnStartUp.ToString());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var settings = new SettingsPage(this);
            settings.ShowDialog();
        }

        public static void SetStartup(bool onOff)
        {
            //Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);

            if (onOff)
                key.SetValue(StartupValue, Application.ExecutablePath.ToString());
            else
                key.DeleteValue(StartupValue, false);
        }
    }
}
