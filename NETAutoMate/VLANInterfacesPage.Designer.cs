namespace NETAutoMate
{
    partial class VLANInterfacesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLANInterfacesPage));
            this.label2 = new System.Windows.Forms.Label();
            this.getvlandetails = new System.Windows.Forms.Button();
            this.retrievevlan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.newvlan = new System.Windows.Forms.RadioButton();
            this.createvlan = new System.Windows.Forms.Button();
            this.removevlan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.translatevlan = new System.Windows.Forms.Button();
            this.createnewvlan = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.newaccessports = new System.Windows.Forms.ComboBox();
            this.newvlansubnet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newvlanip = new System.Windows.Forms.TextBox();
            this.newvlanname = new System.Windows.Forms.TextBox();
            this.newvlanid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.retrievevlandetails = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.assignedports = new System.Windows.Forms.ComboBox();
            this.vstatuslabel = new System.Windows.Forms.Label();
            this.vsubnetabel = new System.Windows.Forms.Label();
            this.viplabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vnamelabel = new System.Windows.Forms.Label();
            this.selvlanid = new System.Windows.Forms.ComboBox();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.createnewvlan.SuspendLayout();
            this.retrievevlandetails.SuspendLayout();
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
            // getvlandetails
            // 
            this.getvlandetails.Location = new System.Drawing.Point(361, 123);
            this.getvlandetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getvlandetails.Name = "getvlandetails";
            this.getvlandetails.Size = new System.Drawing.Size(80, 25);
            this.getvlandetails.TabIndex = 43;
            this.getvlandetails.Text = "Get Details";
            this.getvlandetails.UseVisualStyleBackColor = true;
            this.getvlandetails.Visible = false;
            this.getvlandetails.Click += new System.EventHandler(this.getvlandetails_Click);
            // 
            // retrievevlan
            // 
            this.retrievevlan.AutoSize = true;
            this.retrievevlan.BackColor = System.Drawing.Color.Transparent;
            this.retrievevlan.ForeColor = System.Drawing.Color.White;
            this.retrievevlan.Location = new System.Drawing.Point(175, 55);
            this.retrievevlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retrievevlan.Name = "retrievevlan";
            this.retrievevlan.Size = new System.Drawing.Size(166, 19);
            this.retrievevlan.TabIndex = 47;
            this.retrievevlan.Text = "Retrieve VLAN Information";
            this.retrievevlan.UseVisualStyleBackColor = false;
            this.retrievevlan.CheckedChanged += new System.EventHandler(this.retrievevlan_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "VLAN Interfaces";
            // 
            // newvlan
            // 
            this.newvlan.AutoSize = true;
            this.newvlan.BackColor = System.Drawing.Color.Transparent;
            this.newvlan.ForeColor = System.Drawing.Color.White;
            this.newvlan.Location = new System.Drawing.Point(175, 78);
            this.newvlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newvlan.Name = "newvlan";
            this.newvlan.Size = new System.Drawing.Size(119, 19);
            this.newvlan.TabIndex = 52;
            this.newvlan.Text = "Create New VLAN";
            this.newvlan.UseVisualStyleBackColor = false;
            this.newvlan.CheckedChanged += new System.EventHandler(this.newvlan_CheckedChanged);
            // 
            // createvlan
            // 
            this.createvlan.Location = new System.Drawing.Point(206, 175);
            this.createvlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createvlan.Name = "createvlan";
            this.createvlan.Size = new System.Drawing.Size(90, 25);
            this.createvlan.TabIndex = 55;
            this.createvlan.Text = "Create VLAN";
            this.createvlan.UseVisualStyleBackColor = true;
            this.createvlan.Click += new System.EventHandler(this.createvlanint_Click);
            // 
            // removevlan
            // 
            this.removevlan.Location = new System.Drawing.Point(447, 123);
            this.removevlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removevlan.Name = "removevlan";
            this.removevlan.Size = new System.Drawing.Size(80, 25);
            this.removevlan.TabIndex = 56;
            this.removevlan.Text = "Remove";
            this.removevlan.UseVisualStyleBackColor = true;
            this.removevlan.Visible = false;
            this.removevlan.Click += new System.EventHandler(this.removevlan_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(525, 1);
            this.label8.TabIndex = 64;
            // 
            // translatevlan
            // 
            this.translatevlan.BackColor = System.Drawing.Color.Transparent;
            this.translatevlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translatevlan.FlatAppearance.BorderSize = 0;
            this.translatevlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translatevlan.Image = ((System.Drawing.Image)(resources.GetObject("translatevlan.Image")));
            this.translatevlan.Location = new System.Drawing.Point(381, 158);
            this.translatevlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translatevlan.Name = "translatevlan";
            this.translatevlan.Size = new System.Drawing.Size(40, 40);
            this.translatevlan.TabIndex = 75;
            this.translatevlan.UseVisualStyleBackColor = false;
            this.translatevlan.Visible = false;
            this.translatevlan.Click += new System.EventHandler(this.translatevlan_Click);
            this.translatevlan.MouseHover += new System.EventHandler(this.translatevlan_MouseHover);
            // 
            // createnewvlan
            // 
            this.createnewvlan.BackColor = System.Drawing.Color.Transparent;
            this.createnewvlan.Controls.Add(this.label9);
            this.createnewvlan.Controls.Add(this.newaccessports);
            this.createnewvlan.Controls.Add(this.newvlansubnet);
            this.createnewvlan.Controls.Add(this.createvlan);
            this.createnewvlan.Controls.Add(this.label7);
            this.createnewvlan.Controls.Add(this.label1);
            this.createnewvlan.Controls.Add(this.newvlanip);
            this.createnewvlan.Controls.Add(this.newvlanname);
            this.createnewvlan.Controls.Add(this.newvlanid);
            this.createnewvlan.Controls.Add(this.label3);
            this.createnewvlan.Controls.Add(this.label5);
            this.createnewvlan.Location = new System.Drawing.Point(12, 123);
            this.createnewvlan.Name = "createnewvlan";
            this.createnewvlan.Size = new System.Drawing.Size(343, 200);
            this.createnewvlan.TabIndex = 78;
            this.createnewvlan.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "Access Ports";
            // 
            // newaccessports
            // 
            this.newaccessports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newaccessports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newaccessports.FormattingEnabled = true;
            this.newaccessports.Location = new System.Drawing.Point(163, 141);
            this.newaccessports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newaccessports.Name = "newaccessports";
            this.newaccessports.Size = new System.Drawing.Size(176, 25);
            this.newaccessports.Sorted = true;
            this.newaccessports.TabIndex = 79;
            // 
            // newvlansubnet
            // 
            this.newvlansubnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newvlansubnet.Location = new System.Drawing.Point(163, 106);
            this.newvlansubnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newvlansubnet.Name = "newvlansubnet";
            this.newvlansubnet.PlaceholderText = "Enter New VLAN Subnet";
            this.newvlansubnet.Size = new System.Drawing.Size(176, 25);
            this.newvlansubnet.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "VLAN Subnet Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 76;
            this.label1.Text = "VLAN IP Address";
            // 
            // newvlanip
            // 
            this.newvlanip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newvlanip.Location = new System.Drawing.Point(163, 71);
            this.newvlanip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newvlanip.Name = "newvlanip";
            this.newvlanip.PlaceholderText = "Enter New VLAN IP";
            this.newvlanip.Size = new System.Drawing.Size(176, 25);
            this.newvlanip.TabIndex = 75;
            // 
            // newvlanname
            // 
            this.newvlanname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newvlanname.Location = new System.Drawing.Point(163, 36);
            this.newvlanname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newvlanname.Name = "newvlanname";
            this.newvlanname.PlaceholderText = "Enter New VLAN Name";
            this.newvlanname.Size = new System.Drawing.Size(176, 25);
            this.newvlanname.TabIndex = 74;
            // 
            // newvlanid
            // 
            this.newvlanid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newvlanid.Location = new System.Drawing.Point(163, 1);
            this.newvlanid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newvlanid.Name = "newvlanid";
            this.newvlanid.PlaceholderText = "Enter New VLAN ID";
            this.newvlanid.Size = new System.Drawing.Size(176, 25);
            this.newvlanid.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "VLAN ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "VLAN Name";
            // 
            // retrievevlandetails
            // 
            this.retrievevlandetails.BackColor = System.Drawing.Color.Transparent;
            this.retrievevlandetails.Controls.Add(this.label11);
            this.retrievevlandetails.Controls.Add(this.label12);
            this.retrievevlandetails.Controls.Add(this.label13);
            this.retrievevlandetails.Controls.Add(this.label14);
            this.retrievevlandetails.Controls.Add(this.label10);
            this.retrievevlandetails.Controls.Add(this.assignedports);
            this.retrievevlandetails.Controls.Add(this.vstatuslabel);
            this.retrievevlandetails.Controls.Add(this.vsubnetabel);
            this.retrievevlandetails.Controls.Add(this.viplabel);
            this.retrievevlandetails.Controls.Add(this.label4);
            this.retrievevlandetails.Controls.Add(this.vnamelabel);
            this.retrievevlandetails.Controls.Add(this.selvlanid);
            this.retrievevlandetails.Location = new System.Drawing.Point(12, 123);
            this.retrievevlandetails.Name = "retrievevlandetails";
            this.retrievevlandetails.Size = new System.Drawing.Size(343, 200);
            this.retrievevlandetails.TabIndex = 83;
            this.retrievevlandetails.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "VLAN Subnet Mask";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 93;
            this.label12.Text = "VLAN IP Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 92;
            this.label13.Text = "VLAN ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 19);
            this.label14.TabIndex = 91;
            this.label14.Text = "VLAN Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 19);
            this.label10.TabIndex = 90;
            this.label10.Text = "Assigned Access Ports";
            // 
            // assignedports
            // 
            this.assignedports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignedports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignedports.FormattingEnabled = true;
            this.assignedports.Location = new System.Drawing.Point(163, 175);
            this.assignedports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assignedports.Name = "assignedports";
            this.assignedports.Size = new System.Drawing.Size(176, 25);
            this.assignedports.Sorted = true;
            this.assignedports.TabIndex = 89;
            // 
            // vstatuslabel
            // 
            this.vstatuslabel.BackColor = System.Drawing.SystemColors.Window;
            this.vstatuslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vstatuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vstatuslabel.ForeColor = System.Drawing.Color.Black;
            this.vstatuslabel.Location = new System.Drawing.Point(163, 140);
            this.vstatuslabel.Name = "vstatuslabel";
            this.vstatuslabel.Size = new System.Drawing.Size(176, 25);
            this.vstatuslabel.TabIndex = 85;
            this.vstatuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vsubnetabel
            // 
            this.vsubnetabel.BackColor = System.Drawing.SystemColors.Window;
            this.vsubnetabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsubnetabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsubnetabel.ForeColor = System.Drawing.Color.Black;
            this.vsubnetabel.Location = new System.Drawing.Point(163, 105);
            this.vsubnetabel.Name = "vsubnetabel";
            this.vsubnetabel.Size = new System.Drawing.Size(176, 25);
            this.vsubnetabel.TabIndex = 88;
            this.vsubnetabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viplabel
            // 
            this.viplabel.BackColor = System.Drawing.SystemColors.Window;
            this.viplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viplabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viplabel.ForeColor = System.Drawing.Color.Black;
            this.viplabel.Location = new System.Drawing.Point(163, 70);
            this.viplabel.Name = "viplabel";
            this.viplabel.Size = new System.Drawing.Size(176, 25);
            this.viplabel.TabIndex = 87;
            this.viplabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "VLAN Status";
            // 
            // vnamelabel
            // 
            this.vnamelabel.BackColor = System.Drawing.SystemColors.Window;
            this.vnamelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vnamelabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vnamelabel.ForeColor = System.Drawing.Color.Black;
            this.vnamelabel.Location = new System.Drawing.Point(163, 35);
            this.vnamelabel.Name = "vnamelabel";
            this.vnamelabel.Size = new System.Drawing.Size(176, 25);
            this.vnamelabel.TabIndex = 84;
            this.vnamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selvlanid
            // 
            this.selvlanid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selvlanid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selvlanid.FormattingEnabled = true;
            this.selvlanid.Location = new System.Drawing.Point(163, 0);
            this.selvlanid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selvlanid.Name = "selvlanid";
            this.selvlanid.Size = new System.Drawing.Size(176, 25);
            this.selvlanid.Sorted = true;
            this.selvlanid.TabIndex = 83;
            this.selvlanid.SelectedIndexChanged += new System.EventHandler(this.selvlanid_SelectedIndexChanged);
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
            // VLANInterfacesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.retrievevlandetails);
            this.Controls.Add(this.createnewvlan);
            this.Controls.Add(this.translatevlan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removevlan);
            this.Controls.Add(this.newvlan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.retrievevlan);
            this.Controls.Add(this.getvlandetails);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "VLANInterfacesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VLAN Interfaces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VLANInterfacesPage_FormClosing);
            this.Load += new System.EventHandler(this.VLANInterfacesPage_Load);
            this.createnewvlan.ResumeLayout(false);
            this.createnewvlan.PerformLayout();
            this.retrievevlandetails.ResumeLayout(false);
            this.retrievevlandetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button getvlandetails;
        private RadioButton retrievevlan;
        private Label label6;
        private RadioButton newvlan;
        private Button createvlan;
        private Button removevlan;
        private Label label8;
        private Button translatevlan;
        private Panel createnewvlan;
        private Label label9;
        private ComboBox newaccessports;
        private TextBox newvlansubnet;
        private Label label7;
        private Label label1;
        private TextBox newvlanip;
        private TextBox newvlanname;
        private TextBox newvlanid;
        private Label label3;
        private Label label5;
        private Panel retrievevlandetails;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label10;
        private ComboBox assignedports;
        private Label vstatuslabel;
        private Label vsubnetabel;
        private Label viplabel;
        private Label label4;
        private Label vnamelabel;
        private ComboBox selvlanid;
        private ToolTip hints;
    }
}