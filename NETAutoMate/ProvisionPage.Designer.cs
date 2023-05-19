namespace NETAutoMate
{
    partial class ProvisionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvisionPage));
            this.label3 = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.newconfig = new System.Windows.Forms.RadioButton();
            this.openconfig = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comport = new System.Windows.Forms.ComboBox();
            this.path = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.check.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(165, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Device Provisioning";
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.BackColor = System.Drawing.Color.Transparent;
            this.ver.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ver.ForeColor = System.Drawing.SystemColors.Control;
            this.ver.Location = new System.Drawing.Point(460, 331);
            this.ver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(69, 16);
            this.ver.TabIndex = 19;
            this.ver.Text = "Version 1.0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(531, 1);
            this.label10.TabIndex = 68;
            // 
            // newconfig
            // 
            this.newconfig.AutoSize = true;
            this.newconfig.BackColor = System.Drawing.Color.Transparent;
            this.newconfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newconfig.ForeColor = System.Drawing.Color.White;
            this.newconfig.Location = new System.Drawing.Point(165, 98);
            this.newconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newconfig.Name = "newconfig";
            this.newconfig.Size = new System.Drawing.Size(279, 24);
            this.newconfig.TabIndex = 67;
            this.newconfig.Text = "Create New Configuration Parameters";
            this.newconfig.UseVisualStyleBackColor = false;
            this.newconfig.CheckedChanged += new System.EventHandler(this.newconfig_CheckedChanged);
            // 
            // openconfig
            // 
            this.openconfig.AutoSize = true;
            this.openconfig.BackColor = System.Drawing.Color.Transparent;
            this.openconfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openconfig.ForeColor = System.Drawing.Color.White;
            this.openconfig.Location = new System.Drawing.Point(165, 69);
            this.openconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openconfig.Name = "openconfig";
            this.openconfig.Size = new System.Drawing.Size(238, 24);
            this.openconfig.TabIndex = 66;
            this.openconfig.Text = "Open Configuration Parameters";
            this.openconfig.UseVisualStyleBackColor = false;
            this.openconfig.CheckedChanged += new System.EventHandler(this.openconfig_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 65;
            this.label11.Text = "Select Option";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(154, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "All Rights Reserved. NET-AutoMate 2023";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 312);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(531, 1);
            this.label13.TabIndex = 72;
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Location = new System.Drawing.Point(414, 65);
            this.open.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(38, 31);
            this.open.TabIndex = 74;
            this.open.TabStop = false;
            this.open.UseVisualStyleBackColor = false;
            this.open.Visible = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.Controls.Add(this.refresh);
            this.check.Controls.Add(this.label1);
            this.check.Controls.Add(this.next);
            this.check.Controls.Add(this.label5);
            this.check.Controls.Add(this.comport);
            this.check.Controls.Add(this.path);
            this.check.Location = new System.Drawing.Point(15, 166);
            this.check.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(470, 131);
            this.check.TabIndex = 85;
            this.check.Visible = false;
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(348, 46);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 34);
            this.refresh.TabIndex = 90;
            this.refresh.TabStop = false;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "File Path";
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.next.Location = new System.Drawing.Point(208, 98);
            this.next.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 31);
            this.next.TabIndex = 88;
            this.next.TabStop = false;
            this.next.Text = "Proceed";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "COM Port";
            // 
            // comport
            // 
            this.comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comport.FormattingEnabled = true;
            this.comport.Location = new System.Drawing.Point(150, 48);
            this.comport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(189, 29);
            this.comport.Sorted = true;
            this.comport.TabIndex = 87;
            this.comport.TabStop = false;
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.path.Location = new System.Drawing.Point(150, 2);
            this.path.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(312, 29);
            this.path.TabIndex = 85;
            this.path.TabStop = false;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(500, 6);
            this.help.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(38, 38);
            this.help.TabIndex = 86;
            this.help.TabStop = false;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // ProvisionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 358);
            this.Controls.Add(this.help);
            this.Controls.Add(this.check);
            this.Controls.Add(this.open);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.newconfig);
            this.Controls.Add(this.openconfig);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "ProvisionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET-AutoMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProvisionPage_FormClosing);
            this.check.ResumeLayout(false);
            this.check.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label ver;
        private Label label10;
        private RadioButton newconfig;
        private RadioButton openconfig;
        private Label label11;
        private Label label4;
        private Label label13;
        private Button open;
        private Panel check;
        private Label label1;
        private Button next;
        private Label label5;
        private ComboBox comport;
        private TextBox path;
        private Button help;
        private Button refresh;
    }
}