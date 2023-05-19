namespace NETAutoMate
{
    partial class NewConfigWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConfigWizard));
            this.label3 = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.step5 = new System.Windows.Forms.Panel();
            this.subnetmask = new System.Windows.Forms.TextBox();
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.previous4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.step4 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.previous3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.next5 = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Panel();
            this.hostname = new System.Windows.Forms.TextBox();
            this.previous2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.next4 = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.Panel();
            this.dtype = new System.Windows.Forms.ComboBox();
            this.previous1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.next3 = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Panel();
            this.dvendor = new System.Windows.Forms.ComboBox();
            this.previous = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.startpage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.step5.SuspendLayout();
            this.step4.SuspendLayout();
            this.step3.SuspendLayout();
            this.step2.SuspendLayout();
            this.step1.SuspendLayout();
            this.startpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "New Configuration Wizard";
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
            // step5
            // 
            this.step5.BackColor = System.Drawing.Color.Transparent;
            this.step5.Controls.Add(this.subnetmask);
            this.step5.Controls.Add(this.ipaddress);
            this.step5.Controls.Add(this.previous4);
            this.step5.Controls.Add(this.label15);
            this.step5.Controls.Add(this.label16);
            this.step5.Controls.Add(this.finish);
            this.step5.Location = new System.Drawing.Point(15, 48);
            this.step5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.step5.Name = "step5";
            this.step5.Size = new System.Drawing.Size(500, 188);
            this.step5.TabIndex = 80;
            this.step5.Visible = false;
            // 
            // subnetmask
            // 
            this.subnetmask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subnetmask.Location = new System.Drawing.Point(159, 94);
            this.subnetmask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.subnetmask.Name = "subnetmask";
            this.subnetmask.PlaceholderText = "Enter Subnet Mask";
            this.subnetmask.Size = new System.Drawing.Size(182, 29);
            this.subnetmask.TabIndex = 80;
            // 
            // ipaddress
            // 
            this.ipaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipaddress.Location = new System.Drawing.Point(159, 50);
            this.ipaddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.PlaceholderText = "Enter IP Address";
            this.ipaddress.Size = new System.Drawing.Size(182, 29);
            this.ipaddress.TabIndex = 79;
            this.ipaddress.MouseHover += new System.EventHandler(this.ipaddress_MouseHover);
            // 
            // previous4
            // 
            this.previous4.FlatAppearance.BorderSize = 0;
            this.previous4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous4.Image = ((System.Drawing.Image)(resources.GetObject("previous4.Image")));
            this.previous4.Location = new System.Drawing.Point(161, 144);
            this.previous4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.previous4.Name = "previous4";
            this.previous4.Size = new System.Drawing.Size(88, 31);
            this.previous4.TabIndex = 78;
            this.previous4.UseVisualStyleBackColor = true;
            this.previous4.Click += new System.EventHandler(this.previous4_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(4, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 31);
            this.label15.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(40, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(456, 25);
            this.label16.TabIndex = 76;
            this.label16.Text = "Enter an IP Address and a Subnet Mask for the Device";
            // 
            // finish
            // 
            this.finish.FlatAppearance.BorderSize = 0;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish.Image = ((System.Drawing.Image)(resources.GetObject("finish.Image")));
            this.finish.Location = new System.Drawing.Point(256, 142);
            this.finish.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(32, 32);
            this.finish.TabIndex = 75;
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // step4
            // 
            this.step4.BackColor = System.Drawing.Color.Transparent;
            this.step4.Controls.Add(this.password);
            this.step4.Controls.Add(this.username);
            this.step4.Controls.Add(this.previous3);
            this.step4.Controls.Add(this.label10);
            this.step4.Controls.Add(this.label12);
            this.step4.Controls.Add(this.next5);
            this.step4.Location = new System.Drawing.Point(15, 48);
            this.step4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(500, 188);
            this.step4.TabIndex = 81;
            this.step4.Visible = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(159, 94);
            this.password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.password.Name = "password";
            this.password.PlaceholderText = "Enter Password";
            this.password.Size = new System.Drawing.Size(182, 29);
            this.password.TabIndex = 80;
            this.password.MouseHover += new System.EventHandler(this.password_MouseHover);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(159, 50);
            this.username.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.username.Name = "username";
            this.username.PlaceholderText = "Enter Username";
            this.username.Size = new System.Drawing.Size(182, 29);
            this.username.TabIndex = 79;
            this.username.MouseHover += new System.EventHandler(this.username_MouseHover);
            // 
            // previous3
            // 
            this.previous3.FlatAppearance.BorderSize = 0;
            this.previous3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous3.Image = ((System.Drawing.Image)(resources.GetObject("previous3.Image")));
            this.previous3.Location = new System.Drawing.Point(161, 144);
            this.previous3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.previous3.Name = "previous3";
            this.previous3.Size = new System.Drawing.Size(88, 31);
            this.previous3.TabIndex = 78;
            this.previous3.UseVisualStyleBackColor = true;
            this.previous3.Click += new System.EventHandler(this.previous3_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(4, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 31);
            this.label10.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(40, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(456, 25);
            this.label12.TabIndex = 76;
            this.label12.Text = "Enter a Username and a Password for the Device";
            // 
            // next5
            // 
            this.next5.FlatAppearance.BorderSize = 0;
            this.next5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next5.Image = ((System.Drawing.Image)(resources.GetObject("next5.Image")));
            this.next5.Location = new System.Drawing.Point(256, 144);
            this.next5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.next5.Name = "next5";
            this.next5.Size = new System.Drawing.Size(88, 31);
            this.next5.TabIndex = 75;
            this.next5.UseVisualStyleBackColor = true;
            this.next5.Click += new System.EventHandler(this.next5_Click);
            // 
            // step3
            // 
            this.step3.BackColor = System.Drawing.Color.Transparent;
            this.step3.Controls.Add(this.hostname);
            this.step3.Controls.Add(this.previous2);
            this.step3.Controls.Add(this.label8);
            this.step3.Controls.Add(this.label9);
            this.step3.Controls.Add(this.next4);
            this.step3.Location = new System.Drawing.Point(15, 48);
            this.step3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(500, 188);
            this.step3.TabIndex = 82;
            this.step3.Visible = false;
            // 
            // hostname
            // 
            this.hostname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hostname.Location = new System.Drawing.Point(159, 75);
            this.hostname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.hostname.Name = "hostname";
            this.hostname.PlaceholderText = "Enter Hostname";
            this.hostname.Size = new System.Drawing.Size(182, 29);
            this.hostname.TabIndex = 78;
            this.hostname.MouseHover += new System.EventHandler(this.hostname_MouseHover);
            // 
            // previous2
            // 
            this.previous2.FlatAppearance.BorderSize = 0;
            this.previous2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous2.Image = ((System.Drawing.Image)(resources.GetObject("previous2.Image")));
            this.previous2.Location = new System.Drawing.Point(161, 144);
            this.previous2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.previous2.Name = "previous2";
            this.previous2.Size = new System.Drawing.Size(88, 31);
            this.previous2.TabIndex = 77;
            this.previous2.UseVisualStyleBackColor = true;
            this.previous2.Click += new System.EventHandler(this.previous2_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 31);
            this.label8.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(40, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(456, 25);
            this.label9.TabIndex = 75;
            this.label9.Text = "Enter a Hostname for the Device";
            // 
            // next4
            // 
            this.next4.FlatAppearance.BorderSize = 0;
            this.next4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next4.Image = ((System.Drawing.Image)(resources.GetObject("next4.Image")));
            this.next4.Location = new System.Drawing.Point(256, 144);
            this.next4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.next4.Name = "next4";
            this.next4.Size = new System.Drawing.Size(88, 31);
            this.next4.TabIndex = 74;
            this.next4.UseVisualStyleBackColor = true;
            this.next4.Click += new System.EventHandler(this.next4_Click);
            // 
            // step2
            // 
            this.step2.BackColor = System.Drawing.Color.Transparent;
            this.step2.Controls.Add(this.dtype);
            this.step2.Controls.Add(this.previous1);
            this.step2.Controls.Add(this.label4);
            this.step2.Controls.Add(this.label7);
            this.step2.Controls.Add(this.next3);
            this.step2.Location = new System.Drawing.Point(15, 48);
            this.step2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(500, 188);
            this.step2.TabIndex = 83;
            this.step2.Visible = false;
            // 
            // dtype
            // 
            this.dtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtype.FormattingEnabled = true;
            this.dtype.Location = new System.Drawing.Point(159, 75);
            this.dtype.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtype.Name = "dtype";
            this.dtype.Size = new System.Drawing.Size(182, 29);
            this.dtype.TabIndex = 78;
            // 
            // previous1
            // 
            this.previous1.FlatAppearance.BorderSize = 0;
            this.previous1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous1.Image = ((System.Drawing.Image)(resources.GetObject("previous1.Image")));
            this.previous1.Location = new System.Drawing.Point(161, 144);
            this.previous1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.previous1.Name = "previous1";
            this.previous1.Size = new System.Drawing.Size(88, 31);
            this.previous1.TabIndex = 77;
            this.previous1.UseVisualStyleBackColor = true;
            this.previous1.Click += new System.EventHandler(this.previous1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 31);
            this.label4.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(456, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "Select the Device Type";
            // 
            // next3
            // 
            this.next3.FlatAppearance.BorderSize = 0;
            this.next3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next3.Image = ((System.Drawing.Image)(resources.GetObject("next3.Image")));
            this.next3.Location = new System.Drawing.Point(256, 144);
            this.next3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.next3.Name = "next3";
            this.next3.Size = new System.Drawing.Size(88, 31);
            this.next3.TabIndex = 74;
            this.next3.UseVisualStyleBackColor = true;
            this.next3.Click += new System.EventHandler(this.next3_Click);
            // 
            // step1
            // 
            this.step1.BackColor = System.Drawing.Color.Transparent;
            this.step1.Controls.Add(this.dvendor);
            this.step1.Controls.Add(this.previous);
            this.step1.Controls.Add(this.label5);
            this.step1.Controls.Add(this.label6);
            this.step1.Controls.Add(this.next2);
            this.step1.Location = new System.Drawing.Point(15, 48);
            this.step1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(500, 188);
            this.step1.TabIndex = 84;
            this.step1.Visible = false;
            // 
            // dvendor
            // 
            this.dvendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dvendor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dvendor.FormattingEnabled = true;
            this.dvendor.Location = new System.Drawing.Point(159, 75);
            this.dvendor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dvendor.Name = "dvendor";
            this.dvendor.Size = new System.Drawing.Size(182, 29);
            this.dvendor.TabIndex = 78;
            // 
            // previous
            // 
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Image = ((System.Drawing.Image)(resources.GetObject("previous.Image")));
            this.previous.Location = new System.Drawing.Point(161, 144);
            this.previous.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(88, 31);
            this.previous.TabIndex = 77;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 31);
            this.label5.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Select a Device Vendor";
            // 
            // next2
            // 
            this.next2.FlatAppearance.BorderSize = 0;
            this.next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next2.Image = ((System.Drawing.Image)(resources.GetObject("next2.Image")));
            this.next2.Location = new System.Drawing.Point(256, 144);
            this.next2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(88, 31);
            this.next2.TabIndex = 74;
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // startpage
            // 
            this.startpage.BackColor = System.Drawing.Color.Transparent;
            this.startpage.Controls.Add(this.label2);
            this.startpage.Controls.Add(this.label1);
            this.startpage.Controls.Add(this.start);
            this.startpage.Controls.Add(this.label11);
            this.startpage.Location = new System.Drawing.Point(15, 48);
            this.startpage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startpage.Name = "startpage";
            this.startpage.Size = new System.Drawing.Size(500, 188);
            this.startpage.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 75;
            // 
            // start
            // 
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(369, 144);
            this.start.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(125, 38);
            this.start.TabIndex = 73;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(456, 138);
            this.label11.TabIndex = 74;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(66, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 38);
            this.label13.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(121, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 2);
            this.label14.TabIndex = 86;
            // 
            // NewConfigWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 251);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.step5);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startpage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "NewConfigWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewConfigWizard_FormClosing);
            this.step5.ResumeLayout(false);
            this.step5.PerformLayout();
            this.step4.ResumeLayout(false);
            this.step4.PerformLayout();
            this.step3.ResumeLayout(false);
            this.step3.PerformLayout();
            this.step2.ResumeLayout(false);
            this.step1.ResumeLayout(false);
            this.startpage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private ToolTip hints;
        private Panel step5;
        private TextBox subnetmask;
        private TextBox ipaddress;
        private Button previous4;
        private Label label15;
        private Label label16;
        private Button finish;
        private Panel step4;
        private TextBox password;
        private TextBox username;
        private Button previous3;
        private Label label10;
        private Label label12;
        private Button next5;
        private Panel step3;
        private TextBox hostname;
        private Button previous2;
        private Label label8;
        private Label label9;
        private Button next4;
        private Panel step2;
        private ComboBox dtype;
        private Button previous1;
        private Label label4;
        private Label label7;
        private Button next3;
        private Panel step1;
        private ComboBox dvendor;
        private Button previous;
        private Label label5;
        private Label label6;
        private Button next2;
        private Panel startpage;
        private Label label2;
        private Label label1;
        private Button start;
        private Label label11;
        private Label label13;
        private Label label14;
    }
}