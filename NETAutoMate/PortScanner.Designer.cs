namespace NETAutoMate
{
    partial class PortScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortScanner));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.startport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.Button();
            this.endport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Port Scanner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Port Range";
            // 
            // ipaddress
            // 
            this.ipaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipaddress.Location = new System.Drawing.Point(129, 69);
            this.ipaddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.PlaceholderText = "Enter IP Address";
            this.ipaddress.Size = new System.Drawing.Size(189, 29);
            this.ipaddress.TabIndex = 55;
            this.ipaddress.TabStop = false;
            // 
            // startport
            // 
            this.startport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startport.Location = new System.Drawing.Point(129, 118);
            this.startport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startport.Name = "startport";
            this.startport.PlaceholderText = "Start";
            this.startport.Size = new System.Drawing.Size(83, 29);
            this.startport.TabIndex = 56;
            this.startport.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Results";
            // 
            // scan
            // 
            this.scan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scan.Location = new System.Drawing.Point(174, 169);
            this.scan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(100, 31);
            this.scan.TabIndex = 59;
            this.scan.TabStop = false;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // endport
            // 
            this.endport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endport.Location = new System.Drawing.Point(235, 118);
            this.endport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.endport.Name = "endport";
            this.endport.PlaceholderText = "End";
            this.endport.Size = new System.Drawing.Size(83, 29);
            this.endport.TabIndex = 61;
            this.endport.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "-";
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.results.Location = new System.Drawing.Point(15, 219);
            this.results.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(418, 218);
            this.results.TabIndex = 64;
            this.results.TabStop = false;
            this.results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 451);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endport);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startport);
            this.Controls.Add(this.ipaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "PortScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortScanner_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label3;
        private Label label1;
        private TextBox ipaddress;
        private TextBox startport;
        private Label label2;
        private Button scan;
        private TextBox endport;
        private Label label4;
        private TextBox results;
    }
}