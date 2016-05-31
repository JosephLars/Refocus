namespace TrayTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.secsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minsOfActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minsOfActivityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minsOfActivityToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minsOfActivityToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 104);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourToolStripMenuItem,
            this.hoursToolStripMenuItem,
            this.hoursToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem2.Text = "Do not disturb";
            // 
            // hourToolStripMenuItem
            // 
            this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            this.hourToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.hourToolStripMenuItem.Text = "1 hour";
            // 
            // hoursToolStripMenuItem
            // 
            this.hoursToolStripMenuItem.Name = "hoursToolStripMenuItem";
            this.hoursToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.hoursToolStripMenuItem.Text = "3 hours";
            // 
            // hoursToolStripMenuItem1
            // 
            this.hoursToolStripMenuItem1.Name = "hoursToolStripMenuItem1";
            this.hoursToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.hoursToolStripMenuItem1.Text = "8 hours";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem3.Text = "About";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem4.Text = "Exit Refocus (v1.0)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // secsToolStripMenuItem
            // 
            this.secsToolStripMenuItem.Name = "secsToolStripMenuItem";
            this.secsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.secsToolStripMenuItem.Text = "15 secs inactivity";
            // 
            // secsToolStripMenuItem1
            // 
            this.secsToolStripMenuItem1.Name = "secsToolStripMenuItem1";
            this.secsToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.secsToolStripMenuItem1.Text = "30 secs inactivity";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.minToolStripMenuItem.Text = "1 min inactivity";
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.minToolStripMenuItem1.Text = "2 min inactivity";
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.minToolStripMenuItem2.Text = "5 min inactivity";
            // 
            // minsOfActivityToolStripMenuItem
            // 
            this.minsOfActivityToolStripMenuItem.Name = "minsOfActivityToolStripMenuItem";
            this.minsOfActivityToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.minsOfActivityToolStripMenuItem.Text = "15 mins of activity";
            // 
            // minsOfActivityToolStripMenuItem1
            // 
            this.minsOfActivityToolStripMenuItem1.Name = "minsOfActivityToolStripMenuItem1";
            this.minsOfActivityToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.minsOfActivityToolStripMenuItem1.Text = "30 mins of activity";
            // 
            // minsOfActivityToolStripMenuItem2
            // 
            this.minsOfActivityToolStripMenuItem2.Name = "minsOfActivityToolStripMenuItem2";
            this.minsOfActivityToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.minsOfActivityToolStripMenuItem2.Text = "45 mins of activity";
            // 
            // minsOfActivityToolStripMenuItem3
            // 
            this.minsOfActivityToolStripMenuItem3.Name = "minsOfActivityToolStripMenuItem3";
            this.minsOfActivityToolStripMenuItem3.Size = new System.Drawing.Size(177, 22);
            this.minsOfActivityToolStripMenuItem3.Text = "60 mins of activity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minsOfActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minsOfActivityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minsOfActivityToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minsOfActivityToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem1;
    }
}

