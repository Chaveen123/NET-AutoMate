namespace NETAutoMate
{
    partial class RoutedInterfacesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutedInterfacesPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selint = new System.Windows.Forms.ComboBox();
            this.getintdetails = new System.Windows.Forms.Button();
            this.retrieveint = new System.Windows.Forms.RadioButton();
            this.configint = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.removeint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.retrieveintdetails = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.subnetlabel = new System.Windows.Forms.Label();
            this.iplabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confignewint = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.configroutedint = new System.Windows.Forms.Button();
            this.netmask = new System.Windows.Forms.TextBox();
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.retrieveintdetails.SuspendLayout();
            this.confignewint.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select Option";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Interface";
            this.label3.Visible = false;
            // 
            // selint
            // 
            this.selint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selint.FormattingEnabled = true;
            this.selint.Location = new System.Drawing.Point(179, 123);
            this.selint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selint.Name = "selint";
            this.selint.Size = new System.Drawing.Size(176, 25);
            this.selint.Sorted = true;
            this.selint.TabIndex = 41;
            this.selint.Visible = false;
            this.selint.SelectedIndexChanged += new System.EventHandler(this.selint_SelectedIndexChanged);
            // 
            // getintdetails
            // 
            this.getintdetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getintdetails.Location = new System.Drawing.Point(361, 123);
            this.getintdetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getintdetails.Name = "getintdetails";
            this.getintdetails.Size = new System.Drawing.Size(80, 25);
            this.getintdetails.TabIndex = 43;
            this.getintdetails.Text = "Get Details";
            this.getintdetails.UseVisualStyleBackColor = true;
            this.getintdetails.Visible = false;
            this.getintdetails.Click += new System.EventHandler(this.getintdetails_Click);
            // 
            // retrieveint
            // 
            this.retrieveint.AutoSize = true;
            this.retrieveint.BackColor = System.Drawing.Color.Transparent;
            this.retrieveint.ForeColor = System.Drawing.Color.White;
            this.retrieveint.Location = new System.Drawing.Point(179, 55);
            this.retrieveint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retrieveint.Name = "retrieveint";
            this.retrieveint.Size = new System.Drawing.Size(182, 19);
            this.retrieveint.TabIndex = 47;
            this.retrieveint.Text = "Retrieve Interface Information";
            this.retrieveint.UseVisualStyleBackColor = false;
            this.retrieveint.CheckedChanged += new System.EventHandler(this.retrieveint_CheckedChanged);
            // 
            // configint
            // 
            this.configint.AutoSize = true;
            this.configint.BackColor = System.Drawing.Color.Transparent;
            this.configint.ForeColor = System.Drawing.Color.White;
            this.configint.Location = new System.Drawing.Point(179, 78);
            this.configint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configint.Name = "configint";
            this.configint.Size = new System.Drawing.Size(168, 19);
            this.configint.TabIndex = 48;
            this.configint.Text = "Configure Routed Interface";
            this.configint.UseVisualStyleBackColor = false;
            this.configint.CheckedChanged += new System.EventHandler(this.configint_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(187, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Routed Interfaces";
            // 
            // removeint
            // 
            this.removeint.Location = new System.Drawing.Point(447, 123);
            this.removeint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeint.Name = "removeint";
            this.removeint.Size = new System.Drawing.Size(80, 25);
            this.removeint.TabIndex = 52;
            this.removeint.Text = "Remove";
            this.removeint.UseVisualStyleBackColor = true;
            this.removeint.Visible = false;
            this.removeint.Click += new System.EventHandler(this.removeint_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(525, 1);
            this.label8.TabIndex = 63;
            // 
            // retrieveintdetails
            // 
            this.retrieveintdetails.BackColor = System.Drawing.Color.Transparent;
            this.retrieveintdetails.Controls.Add(this.label4);
            this.retrieveintdetails.Controls.Add(this.statuslabel);
            this.retrieveintdetails.Controls.Add(this.subnetlabel);
            this.retrieveintdetails.Controls.Add(this.iplabel);
            this.retrieveintdetails.Controls.Add(this.label1);
            this.retrieveintdetails.Controls.Add(this.label5);
            this.retrieveintdetails.Location = new System.Drawing.Point(37, 158);
            this.retrieveintdetails.Name = "retrieveintdetails";
            this.retrieveintdetails.Size = new System.Drawing.Size(350, 103);
            this.retrieveintdetails.TabIndex = 64;
            this.retrieveintdetails.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Interface Status";
            // 
            // statuslabel
            // 
            this.statuslabel.BackColor = System.Drawing.SystemColors.Window;
            this.statuslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statuslabel.ForeColor = System.Drawing.Color.Black;
            this.statuslabel.Location = new System.Drawing.Point(142, 74);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(176, 25);
            this.statuslabel.TabIndex = 55;
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subnetlabel
            // 
            this.subnetlabel.BackColor = System.Drawing.SystemColors.Window;
            this.subnetlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subnetlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subnetlabel.ForeColor = System.Drawing.Color.Black;
            this.subnetlabel.Location = new System.Drawing.Point(142, 39);
            this.subnetlabel.Name = "subnetlabel";
            this.subnetlabel.Size = new System.Drawing.Size(176, 25);
            this.subnetlabel.TabIndex = 54;
            this.subnetlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iplabel
            // 
            this.iplabel.BackColor = System.Drawing.SystemColors.Window;
            this.iplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iplabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iplabel.ForeColor = System.Drawing.Color.Black;
            this.iplabel.Location = new System.Drawing.Point(142, 4);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(176, 25);
            this.iplabel.TabIndex = 53;
            this.iplabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Subnet Mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "IP Address";
            // 
            // confignewint
            // 
            this.confignewint.BackColor = System.Drawing.Color.Transparent;
            this.confignewint.Controls.Add(this.label7);
            this.confignewint.Controls.Add(this.label9);
            this.confignewint.Controls.Add(this.configroutedint);
            this.confignewint.Controls.Add(this.netmask);
            this.confignewint.Controls.Add(this.ipaddress);
            this.confignewint.Location = new System.Drawing.Point(37, 158);
            this.confignewint.Name = "confignewint";
            this.confignewint.Size = new System.Drawing.Size(350, 103);
            this.confignewint.TabIndex = 65;
            this.confignewint.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 72;
            this.label7.Text = "Subnet Mask";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 71;
            this.label9.Text = "IP Address";
            // 
            // configroutedint
            // 
            this.configroutedint.Location = new System.Drawing.Point(175, 74);
            this.configroutedint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configroutedint.Name = "configroutedint";
            this.configroutedint.Size = new System.Drawing.Size(110, 25);
            this.configroutedint.TabIndex = 70;
            this.configroutedint.Text = "Confirm Changes";
            this.configroutedint.UseVisualStyleBackColor = true;
            this.configroutedint.Click += new System.EventHandler(this.configroutedint_Click);
            // 
            // netmask
            // 
            this.netmask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netmask.Location = new System.Drawing.Point(142, 39);
            this.netmask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.netmask.Name = "netmask";
            this.netmask.PlaceholderText = "Enter Subnet Mask";
            this.netmask.Size = new System.Drawing.Size(176, 25);
            this.netmask.TabIndex = 69;
            // 
            // ipaddress
            // 
            this.ipaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipaddress.Location = new System.Drawing.Point(142, 4);
            this.ipaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.PlaceholderText = "Enter IP Address";
            this.ipaddress.Size = new System.Drawing.Size(176, 25);
            this.ipaddress.TabIndex = 68;
            // 
            // RoutedInterfacesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.confignewint);
            this.Controls.Add(this.retrieveintdetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removeint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.configint);
            this.Controls.Add(this.retrieveint);
            this.Controls.Add(this.getintdetails);
            this.Controls.Add(this.selint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RoutedInterfacesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Routed Interfaces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoutedInterfacesPage_FormClosing);
            this.Load += new System.EventHandler(this.RoutedInterfacesPage_Load);
            this.retrieveintdetails.ResumeLayout(false);
            this.retrieveintdetails.PerformLayout();
            this.confignewint.ResumeLayout(false);
            this.confignewint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox selint;
        private Button getintdetails;
        private RadioButton retrieveint;
        private RadioButton configint;
        private Label label6;
        private Button removeint;
        private Label label8;
        private Panel retrieveintdetails;
        private Label label4;
        private Label statuslabel;
        private Label subnetlabel;
        private Label iplabel;
        private Label label1;
        private Label label5;
        private Panel confignewint;
        private Label label7;
        private Label label9;
        private Button configroutedint;
        private TextBox netmask;
        private TextBox ipaddress;
    }
}