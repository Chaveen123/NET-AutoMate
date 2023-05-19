namespace NETAutoMate
{
    partial class LoopbackInterfacesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoopbackInterfacesPage));
            this.label2 = new System.Windows.Forms.Label();
            this.getlbintdetails = new System.Windows.Forms.Button();
            this.retrievelbint = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.removelbint = new System.Windows.Forms.Button();
            this.newlbint = new System.Windows.Forms.RadioButton();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.createnewlbint = new System.Windows.Forms.Panel();
            this.createlbint = new System.Windows.Forms.Button();
            this.newlbsubnet = new System.Windows.Forms.TextBox();
            this.newlbip = new System.Windows.Forms.TextBox();
            this.newlbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.retrievelbintdetails = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.subnetlabel = new System.Windows.Forms.Label();
            this.iplabel = new System.Windows.Forms.Label();
            this.selint = new System.Windows.Forms.ComboBox();
            this.createnewlbint.SuspendLayout();
            this.retrievelbintdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select Option";
            // 
            // getlbintdetails
            // 
            this.getlbintdetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getlbintdetails.Location = new System.Drawing.Point(451, 154);
            this.getlbintdetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.getlbintdetails.Name = "getlbintdetails";
            this.getlbintdetails.Size = new System.Drawing.Size(100, 31);
            this.getlbintdetails.TabIndex = 43;
            this.getlbintdetails.Text = "Get Details";
            this.getlbintdetails.UseVisualStyleBackColor = true;
            this.getlbintdetails.Visible = false;
            this.getlbintdetails.Click += new System.EventHandler(this.getlbintdetails_Click);
            // 
            // retrievelbint
            // 
            this.retrievelbint.AutoSize = true;
            this.retrievelbint.BackColor = System.Drawing.Color.Transparent;
            this.retrievelbint.ForeColor = System.Drawing.Color.White;
            this.retrievelbint.Location = new System.Drawing.Point(222, 69);
            this.retrievelbint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.retrievelbint.Name = "retrievelbint";
            this.retrievelbint.Size = new System.Drawing.Size(297, 24);
            this.retrievelbint.TabIndex = 47;
            this.retrievelbint.Text = "Retrieve Loopback Interface Information";
            this.retrievelbint.UseVisualStyleBackColor = false;
            this.retrievelbint.CheckedChanged += new System.EventHandler(this.retrievelbint_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Loopback Interfaces";
            // 
            // removelbint
            // 
            this.removelbint.Location = new System.Drawing.Point(559, 154);
            this.removelbint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.removelbint.Name = "removelbint";
            this.removelbint.Size = new System.Drawing.Size(100, 31);
            this.removelbint.TabIndex = 52;
            this.removelbint.Text = "Remove";
            this.removelbint.UseVisualStyleBackColor = true;
            this.removelbint.Visible = false;
            this.removelbint.Click += new System.EventHandler(this.removelbint_Click);
            // 
            // newlbint
            // 
            this.newlbint.AutoSize = true;
            this.newlbint.BackColor = System.Drawing.Color.Transparent;
            this.newlbint.ForeColor = System.Drawing.Color.White;
            this.newlbint.Location = new System.Drawing.Point(222, 98);
            this.newlbint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newlbint.Name = "newlbint";
            this.newlbint.Size = new System.Drawing.Size(238, 24);
            this.newlbint.TabIndex = 53;
            this.newlbint.Text = "Create New Loopback Interface";
            this.newlbint.UseVisualStyleBackColor = false;
            this.newlbint.CheckedChanged += new System.EventHandler(this.newlbint_CheckedChanged);
            // 
            // hints
            // 
            this.hints.AutomaticDelay = 100;
            this.hints.AutoPopDelay = 10000;
            this.hints.InitialDelay = 100;
            this.hints.ReshowDelay = 20;
            this.hints.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.hints.ToolTipTitle = "Example:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(656, 1);
            this.label8.TabIndex = 64;
            // 
            // createnewlbint
            // 
            this.createnewlbint.BackColor = System.Drawing.Color.Transparent;
            this.createnewlbint.Controls.Add(this.createlbint);
            this.createnewlbint.Controls.Add(this.newlbsubnet);
            this.createnewlbint.Controls.Add(this.newlbip);
            this.createnewlbint.Controls.Add(this.newlbname);
            this.createnewlbint.Controls.Add(this.label3);
            this.createnewlbint.Controls.Add(this.label1);
            this.createnewlbint.Controls.Add(this.label5);
            this.createnewlbint.Location = new System.Drawing.Point(44, 154);
            this.createnewlbint.Margin = new System.Windows.Forms.Padding(4);
            this.createnewlbint.Name = "createnewlbint";
            this.createnewlbint.Size = new System.Drawing.Size(400, 162);
            this.createnewlbint.TabIndex = 65;
            this.createnewlbint.Visible = false;
            // 
            // createlbint
            // 
            this.createlbint.Location = new System.Drawing.Point(220, 131);
            this.createlbint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createlbint.Name = "createlbint";
            this.createlbint.Size = new System.Drawing.Size(138, 31);
            this.createlbint.TabIndex = 64;
            this.createlbint.Text = "Create Loopback";
            this.createlbint.UseVisualStyleBackColor = true;
            this.createlbint.Click += new System.EventHandler(this.createlbint_Click);
            // 
            // newlbsubnet
            // 
            this.newlbsubnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newlbsubnet.Location = new System.Drawing.Point(179, 88);
            this.newlbsubnet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newlbsubnet.Name = "newlbsubnet";
            this.newlbsubnet.PlaceholderText = "Loopback Subnet Mask";
            this.newlbsubnet.Size = new System.Drawing.Size(219, 29);
            this.newlbsubnet.TabIndex = 63;
            this.newlbsubnet.MouseHover += new System.EventHandler(this.newlbsubnet_MouseHover);
            // 
            // newlbip
            // 
            this.newlbip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newlbip.Location = new System.Drawing.Point(179, 44);
            this.newlbip.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newlbip.Name = "newlbip";
            this.newlbip.PlaceholderText = "Loopback IP Address";
            this.newlbip.Size = new System.Drawing.Size(219, 29);
            this.newlbip.TabIndex = 62;
            this.newlbip.MouseHover += new System.EventHandler(this.newlbip_MouseHover);
            // 
            // newlbname
            // 
            this.newlbname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newlbname.Location = new System.Drawing.Point(179, 0);
            this.newlbname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newlbname.Name = "newlbname";
            this.newlbname.PlaceholderText = "Loopback Int. Name";
            this.newlbname.Size = new System.Drawing.Size(219, 29);
            this.newlbname.TabIndex = 61;
            this.newlbname.MouseHover += new System.EventHandler(this.newlbname_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Interface";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Subnet Mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "IP Address";
            // 
            // retrievelbintdetails
            // 
            this.retrievelbintdetails.BackColor = System.Drawing.Color.Transparent;
            this.retrievelbintdetails.Controls.Add(this.label7);
            this.retrievelbintdetails.Controls.Add(this.label9);
            this.retrievelbintdetails.Controls.Add(this.label10);
            this.retrievelbintdetails.Controls.Add(this.label4);
            this.retrievelbintdetails.Controls.Add(this.statuslabel);
            this.retrievelbintdetails.Controls.Add(this.subnetlabel);
            this.retrievelbintdetails.Controls.Add(this.iplabel);
            this.retrievelbintdetails.Controls.Add(this.selint);
            this.retrievelbintdetails.Location = new System.Drawing.Point(44, 154);
            this.retrievelbintdetails.Margin = new System.Windows.Forms.Padding(4);
            this.retrievelbintdetails.Name = "retrievelbintdetails";
            this.retrievelbintdetails.Size = new System.Drawing.Size(400, 162);
            this.retrievelbintdetails.TabIndex = 66;
            this.retrievelbintdetails.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Interface";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 76;
            this.label9.Text = "Subnet Mask";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 75;
            this.label10.Text = "IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "Interface Status";
            // 
            // statuslabel
            // 
            this.statuslabel.BackColor = System.Drawing.SystemColors.Window;
            this.statuslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statuslabel.ForeColor = System.Drawing.Color.Black;
            this.statuslabel.Location = new System.Drawing.Point(179, 131);
            this.statuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(220, 31);
            this.statuslabel.TabIndex = 73;
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subnetlabel
            // 
            this.subnetlabel.BackColor = System.Drawing.SystemColors.Window;
            this.subnetlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subnetlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subnetlabel.ForeColor = System.Drawing.Color.Black;
            this.subnetlabel.Location = new System.Drawing.Point(179, 88);
            this.subnetlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subnetlabel.Name = "subnetlabel";
            this.subnetlabel.Size = new System.Drawing.Size(220, 31);
            this.subnetlabel.TabIndex = 72;
            this.subnetlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iplabel
            // 
            this.iplabel.BackColor = System.Drawing.SystemColors.Window;
            this.iplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iplabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iplabel.ForeColor = System.Drawing.Color.Black;
            this.iplabel.Location = new System.Drawing.Point(179, 44);
            this.iplabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(220, 31);
            this.iplabel.TabIndex = 71;
            this.iplabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selint
            // 
            this.selint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selint.FormattingEnabled = true;
            this.selint.Location = new System.Drawing.Point(179, 0);
            this.selint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selint.Name = "selint";
            this.selint.Size = new System.Drawing.Size(219, 29);
            this.selint.Sorted = true;
            this.selint.TabIndex = 70;
            this.selint.SelectedIndexChanged += new System.EventHandler(this.selint_SelectedIndexChanged);
            // 
            // LoopbackInterfacesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 420);
            this.Controls.Add(this.retrievelbintdetails);
            this.Controls.Add(this.createnewlbint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newlbint);
            this.Controls.Add(this.removelbint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.retrievelbint);
            this.Controls.Add(this.getlbintdetails);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "LoopbackInterfacesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loopback Interfaces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoopbackInterfacesPage_FormClosing);
            this.Load += new System.EventHandler(this.LoopbackInterfacesPage_Load);
            this.createnewlbint.ResumeLayout(false);
            this.createnewlbint.PerformLayout();
            this.retrievelbintdetails.ResumeLayout(false);
            this.retrievelbintdetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button getlbintdetails;
        private RadioButton retrievelbint;
        private Label label6;
        private Button removelbint;
        private RadioButton newlbint;
        private ToolTip hints;
        private Label label8;
        private Panel createnewlbint;
        private Button createlbint;
        private TextBox newlbsubnet;
        private TextBox newlbip;
        private TextBox newlbname;
        private Label label3;
        private Label label1;
        private Label label5;
        private Panel retrievelbintdetails;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label statuslabel;
        private Label subnetlabel;
        private Label iplabel;
        private ComboBox selint;
    }
}