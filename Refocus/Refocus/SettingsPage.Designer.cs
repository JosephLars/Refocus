namespace Refocus
{
    partial class SettingsPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAlertTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlertType = new System.Windows.Forms.ComboBox();
            this.updAlertInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updInactivityDetection = new System.Windows.Forms.NumericUpDown();
            this.chkInactivityDetection = new System.Windows.Forms.CheckBox();
            this.chkLaunchStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAlertInterval)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updInactivityDetection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLaunchStartup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAlertTest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboAlertType);
            this.groupBox2.Controls.Add(this.updAlertInterval);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alerts";
            // 
            // btnAlertTest
            // 
            this.btnAlertTest.Location = new System.Drawing.Point(58, 99);
            this.btnAlertTest.Name = "btnAlertTest";
            this.btnAlertTest.Size = new System.Drawing.Size(75, 23);
            this.btnAlertTest.TabIndex = 2;
            this.btnAlertTest.Text = "Test";
            this.btnAlertTest.UseVisualStyleBackColor = true;
            this.btnAlertTest.Click += new System.EventHandler(this.btnAlertTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "mins";
            // 
            // cboAlertType
            // 
            this.cboAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlertType.FormattingEnabled = true;
            this.cboAlertType.Items.AddRange(new object[] {
            "Balloon Tooltip",
            "Message Box"});
            this.cboAlertType.Location = new System.Drawing.Point(68, 58);
            this.cboAlertType.Name = "cboAlertType";
            this.cboAlertType.Size = new System.Drawing.Size(100, 21);
            this.cboAlertType.TabIndex = 1;
            this.cboAlertType.SelectedIndexChanged += new System.EventHandler(this.cboAlertType_SelectedIndexChanged);
            // 
            // updAlertInterval
            // 
            this.updAlertInterval.Location = new System.Drawing.Point(83, 19);
            this.updAlertInterval.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.updAlertInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAlertInterval.Name = "updAlertInterval";
            this.updAlertInterval.Size = new System.Drawing.Size(50, 20);
            this.updAlertInterval.TabIndex = 1;
            this.updAlertInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAlertInterval.ValueChanged += new System.EventHandler(this.updAlertInterval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updInactivityDetection);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chkInactivityDetection);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inactivity Detection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "mins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "After";
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.AutoSize = true;
            this.btnResetSettings.Location = new System.Drawing.Point(60, 324);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(97, 23);
            this.btnResetSettings.TabIndex = 2;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // updInactivityDetection
            // 
            this.updInactivityDetection.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Refocus.Properties.Settings.Default, "InactivityDetection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.updInactivityDetection.Enabled = global::Refocus.Properties.Settings.Default.InactivityDetection;
            this.updInactivityDetection.Location = new System.Drawing.Point(74, 61);
            this.updInactivityDetection.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updInactivityDetection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updInactivityDetection.Name = "updInactivityDetection";
            this.updInactivityDetection.Size = new System.Drawing.Size(50, 20);
            this.updInactivityDetection.TabIndex = 3;
            this.updInactivityDetection.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updInactivityDetection.ValueChanged += new System.EventHandler(this.updInactivityDetection_ValueChanged);
            // 
            // chkInactivityDetection
            // 
            this.chkInactivityDetection.AutoSize = true;
            this.chkInactivityDetection.Checked = global::Refocus.Properties.Settings.Default.InactivityDetection;
            this.chkInactivityDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInactivityDetection.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Refocus.Properties.Settings.Default, "InactivityDetection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkInactivityDetection.Location = new System.Drawing.Point(68, 29);
            this.chkInactivityDetection.Name = "chkInactivityDetection";
            this.chkInactivityDetection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInactivityDetection.Size = new System.Drawing.Size(65, 17);
            this.chkInactivityDetection.TabIndex = 0;
            this.chkInactivityDetection.Text = "Enabled";
            this.chkInactivityDetection.UseVisualStyleBackColor = true;
            // 
            // chkLaunchStartup
            // 
            this.chkLaunchStartup.AutoSize = true;
            this.chkLaunchStartup.Checked = global::Refocus.Properties.Settings.Default.LaunchOnStartUp;
            this.chkLaunchStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Refocus.Properties.Settings.Default, "LaunchOnStartUp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLaunchStartup.Location = new System.Drawing.Point(42, 19);
            this.chkLaunchStartup.Name = "chkLaunchStartup";
            this.chkLaunchStartup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLaunchStartup.Size = new System.Drawing.Size(117, 17);
            this.chkLaunchStartup.TabIndex = 4;
            this.chkLaunchStartup.Text = "Launch on Start-up";
            this.chkLaunchStartup.UseVisualStyleBackColor = true;
            this.chkLaunchStartup.CheckedChanged += new System.EventHandler(this.chkLaunchStartup_CheckedChanged);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 363);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refocus Settings";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAlertInterval)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updInactivityDetection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkLaunchStartup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updAlertInterval;
        private System.Windows.Forms.ComboBox cboAlertType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlertTest;
        private System.Windows.Forms.NumericUpDown updInactivityDetection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkInactivityDetection;
        private System.Windows.Forms.Button btnResetSettings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}