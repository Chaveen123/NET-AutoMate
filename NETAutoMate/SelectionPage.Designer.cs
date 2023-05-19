namespace NETAutoMate
{
    partial class SelectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionPage));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vlanint = new System.Windows.Forms.RadioButton();
            this.loopbackint = new System.Windows.Forms.RadioButton();
            this.portscan = new System.Windows.Forms.RadioButton();
            this.dping = new System.Windows.Forms.RadioButton();
            this.getarptable = new System.Windows.Forms.RadioButton();
            this.getmactable = new System.Windows.Forms.RadioButton();
            this.backupconfig = new System.Windows.Forms.RadioButton();
            this.routedint = new System.Windows.Forms.RadioButton();
            this.getdeviceinfo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.getconfig = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.pingdevice = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.versioninfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(198, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Rights Reserved. NET-AutoMate 2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Device Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(212, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select Type of Automation";
            // 
            // vlanint
            // 
            this.vlanint.AutoSize = true;
            this.vlanint.BackColor = System.Drawing.Color.Transparent;
            this.vlanint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vlanint.ForeColor = System.Drawing.SystemColors.Control;
            this.vlanint.Location = new System.Drawing.Point(12, 163);
            this.vlanint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlanint.Name = "vlanint";
            this.vlanint.Size = new System.Drawing.Size(141, 19);
            this.vlanint.TabIndex = 19;
            this.vlanint.Text = "VLAN Interfaces (SVIs)";
            this.hints.SetToolTip(this.vlanint, "Switched Virtual Interfaces");
            this.vlanint.UseVisualStyleBackColor = false;
            // 
            // loopbackint
            // 
            this.loopbackint.AutoSize = true;
            this.loopbackint.BackColor = System.Drawing.Color.Transparent;
            this.loopbackint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loopbackint.ForeColor = System.Drawing.SystemColors.Control;
            this.loopbackint.Location = new System.Drawing.Point(12, 128);
            this.loopbackint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loopbackint.Name = "loopbackint";
            this.loopbackint.Size = new System.Drawing.Size(131, 19);
            this.loopbackint.TabIndex = 20;
            this.loopbackint.Text = "Loopback Interfaces";
            this.loopbackint.UseVisualStyleBackColor = false;
            // 
            // portscan
            // 
            this.portscan.AutoSize = true;
            this.portscan.BackColor = System.Drawing.Color.Transparent;
            this.portscan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.portscan.ForeColor = System.Drawing.SystemColors.Control;
            this.portscan.Location = new System.Drawing.Point(12, 198);
            this.portscan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portscan.Name = "portscan";
            this.portscan.Size = new System.Drawing.Size(99, 19);
            this.portscan.TabIndex = 24;
            this.portscan.Text = "Port Scanning";
            this.hints.SetToolTip(this.portscan, "Scan for Open Ports of Devices in the Network");
            this.portscan.UseVisualStyleBackColor = false;
            // 
            // dping
            // 
            this.dping.AutoSize = true;
            this.dping.BackColor = System.Drawing.Color.Transparent;
            this.dping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dping.ForeColor = System.Drawing.SystemColors.Control;
            this.dping.Location = new System.Drawing.Point(12, 233);
            this.dping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dping.Name = "dping";
            this.dping.Size = new System.Drawing.Size(92, 19);
            this.dping.TabIndex = 25;
            this.dping.Text = "Ping Devices";
            this.hints.SetToolTip(this.dping, "Ping Devices in the Network");
            this.dping.UseVisualStyleBackColor = false;
            this.dping.CheckedChanged += new System.EventHandler(this.dping_CheckedChanged);
            // 
            // getarptable
            // 
            this.getarptable.AutoSize = true;
            this.getarptable.BackColor = System.Drawing.Color.Transparent;
            this.getarptable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getarptable.ForeColor = System.Drawing.SystemColors.Control;
            this.getarptable.Location = new System.Drawing.Point(401, 128);
            this.getarptable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getarptable.Name = "getarptable";
            this.getarptable.Size = new System.Drawing.Size(122, 19);
            this.getarptable.TabIndex = 26;
            this.getarptable.Text = "Retrieve ARP Table";
            this.getarptable.UseVisualStyleBackColor = false;
            // 
            // getmactable
            // 
            this.getmactable.AutoSize = true;
            this.getmactable.BackColor = System.Drawing.Color.Transparent;
            this.getmactable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getmactable.ForeColor = System.Drawing.SystemColors.Control;
            this.getmactable.Location = new System.Drawing.Point(401, 163);
            this.getmactable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getmactable.Name = "getmactable";
            this.getmactable.Size = new System.Drawing.Size(127, 19);
            this.getmactable.TabIndex = 27;
            this.getmactable.Text = "Retrieve MAC Table";
            this.getmactable.UseVisualStyleBackColor = false;
            // 
            // backupconfig
            // 
            this.backupconfig.AutoSize = true;
            this.backupconfig.BackColor = System.Drawing.Color.Transparent;
            this.backupconfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupconfig.ForeColor = System.Drawing.SystemColors.Control;
            this.backupconfig.Location = new System.Drawing.Point(401, 233);
            this.backupconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupconfig.Name = "backupconfig";
            this.backupconfig.Size = new System.Drawing.Size(141, 19);
            this.backupconfig.TabIndex = 28;
            this.backupconfig.Text = "Backup Configuration";
            this.backupconfig.UseVisualStyleBackColor = false;
            // 
            // routedint
            // 
            this.routedint.AutoSize = true;
            this.routedint.BackColor = System.Drawing.Color.Transparent;
            this.routedint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routedint.ForeColor = System.Drawing.SystemColors.Control;
            this.routedint.Location = new System.Drawing.Point(12, 93);
            this.routedint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routedint.Name = "routedint";
            this.routedint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.routedint.Size = new System.Drawing.Size(117, 19);
            this.routedint.TabIndex = 30;
            this.routedint.Text = "Routed Interfaces";
            this.routedint.UseVisualStyleBackColor = false;
            // 
            // getdeviceinfo
            // 
            this.getdeviceinfo.AutoSize = true;
            this.getdeviceinfo.BackColor = System.Drawing.Color.Transparent;
            this.getdeviceinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getdeviceinfo.ForeColor = System.Drawing.SystemColors.Control;
            this.getdeviceinfo.Location = new System.Drawing.Point(401, 93);
            this.getdeviceinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getdeviceinfo.Name = "getdeviceinfo";
            this.getdeviceinfo.Size = new System.Drawing.Size(171, 19);
            this.getdeviceinfo.TabIndex = 31;
            this.getdeviceinfo.Text = "Retrieve Device Information";
            this.getdeviceinfo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 1);
            this.label1.TabIndex = 33;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm.Location = new System.Drawing.Point(252, 230);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 25);
            this.confirm.TabIndex = 34;
            this.confirm.Text = "Select";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.BackColor = System.Drawing.Color.Transparent;
            this.ver.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ver.ForeColor = System.Drawing.SystemColors.Control;
            this.ver.Location = new System.Drawing.Point(518, 315);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(54, 12);
            this.ver.TabIndex = 39;
            this.ver.Text = "Version 1.0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 1);
            this.label6.TabIndex = 66;
            // 
            // save
            // 
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(297, 266);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(35, 30);
            this.save.TabIndex = 67;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseHover += new System.EventHandler(this.save_MouseHover);
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(252, 266);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 30);
            this.refresh.TabIndex = 68;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseHover += new System.EventHandler(this.refresh_MouseHover);
            // 
            // getconfig
            // 
            this.getconfig.AutoSize = true;
            this.getconfig.BackColor = System.Drawing.Color.Transparent;
            this.getconfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getconfig.ForeColor = System.Drawing.SystemColors.Control;
            this.getconfig.Location = new System.Drawing.Point(401, 198);
            this.getconfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getconfig.Name = "getconfig";
            this.getconfig.Size = new System.Drawing.Size(144, 19);
            this.getconfig.TabIndex = 69;
            this.getconfig.Text = "Retrieve Configuration";
            this.getconfig.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(575, 1);
            this.label7.TabIndex = 70;
            // 
            // hints
            // 
            this.hints.AutomaticDelay = 100;
            this.hints.AutoPopDelay = 10000;
            this.hints.InitialDelay = 100;
            this.hints.ReshowDelay = 20;
            this.hints.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.hints.ToolTipTitle = "What\'s This?";
            // 
            // pingdevice
            // 
            this.pingdevice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pingdevice.Location = new System.Drawing.Point(110, 230);
            this.pingdevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pingdevice.Name = "pingdevice";
            this.pingdevice.PlaceholderText = "Device IP Address";
            this.pingdevice.Size = new System.Drawing.Size(120, 25);
            this.pingdevice.TabIndex = 39;
            this.pingdevice.Visible = false;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(550, 5);
            this.help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(30, 30);
            this.help.TabIndex = 88;
            this.help.TabStop = false;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // versioninfo
            // 
            this.versioninfo.BackColor = System.Drawing.Color.Transparent;
            this.versioninfo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.versioninfo.ForeColor = System.Drawing.SystemColors.Control;
            this.versioninfo.Location = new System.Drawing.Point(12, 34);
            this.versioninfo.Name = "versioninfo";
            this.versioninfo.Size = new System.Drawing.Size(171, 50);
            this.versioninfo.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(60, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 89;
            this.label10.Text = "What\'s New?";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mode.ForeColor = System.Drawing.SystemColors.Control;
            this.mode.Location = new System.Drawing.Point(10, 315);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(74, 12);
            this.mode.TabIndex = 91;
            this.mode.Text = "LEGACY MODE";
            this.mode.Visible = false;
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.versioninfo);
            this.Controls.Add(this.pingdevice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getconfig);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getdeviceinfo);
            this.Controls.Add(this.routedint);
            this.Controls.Add(this.backupconfig);
            this.Controls.Add(this.getmactable);
            this.Controls.Add(this.getarptable);
            this.Controls.Add(this.dping);
            this.Controls.Add(this.portscan);
            this.Controls.Add(this.loopbackint);
            this.Controls.Add(this.vlanint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NET-AutoMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionPage_FormClosing);
            this.Load += new System.EventHandler(this.SelectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label5;
        private RadioButton vlanint;
        private RadioButton loopbackint;
        private RadioButton portscan;
        private RadioButton dping;
        private RadioButton getarptable;
        private RadioButton getmactable;
        private RadioButton backupconfig;
        private RadioButton routedint;
        private RadioButton getdeviceinfo;
        private Label label1;
        private Button confirm;
        private Label ver;
        private Label label6;
        private Button save;
        private Button refresh;
        private RadioButton getconfig;
        private Label label7;
        private ToolTip hints;
        private TextBox pingdevice;
        private Button help;
        private Label versioninfo;
        private Label label10;
        private Label mode;
    }
}