using Microsoft.Win32;
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

        /// <summary>
        /// Save settings on every change
        /// </summary>
        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Prevents form from showing in task switcher
        /// </summary>
        protected override void SetVisibleCore(bool value)
        {
            value = false;
            if (!this.IsHandleCreated)
                CreateHandle();

            base.SetVisibleCore(value);
        }

        /// <summary>
        /// Runs every tick
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
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

        /// <summary>
        /// Updates the time left in the contextMenuStrip
        /// </summary>
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

        /// <summary>
        /// Sets up the custom contextMenuStrip
        /// </summary>
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

        /// <summary>
        /// Sets the application to run at startup
        /// </summary>
        public static void SetStartup(bool onOff)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);

            if (onOff)
                key.SetValue(StartupValue, Application.ExecutablePath.ToString());
            else
                key.DeleteValue(StartupValue, false);
        }

        #region Notifications
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
            //Stop timer while message box is showing. Prevents MessageBoxes popping up error. 
            //http://stackoverflow.com/questions/17384487/c-sharp-message-box-pops-up-repeatedly-in-a-timer
            timer1.Stop();
            MessageBox.Show("Take a break", "Refocus");
            timer1.Start();
        }
        #endregion

        #region toolStripMenuItems
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new SettingsPage(this);
            settings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutPage();
            about.ShowDialog();

            //For testing launch on startup property
            ////MessageBox.Show(Properties.Settings.Default.LaunchOnStartUp.ToString());
        }

        private void exitRefocusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }
        #endregion
    }
}
