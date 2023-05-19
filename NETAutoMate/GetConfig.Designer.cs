namespace NETAutoMate
{
    partial class GetConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetConfig));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runconfig = new System.Windows.Forms.Button();
            this.runningconfig = new System.Windows.Forms.TextBox();
            this.startupconfig = new System.Windows.Forms.TextBox();
            this.startconfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Configuration Comparison";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Results";
            // 
            // runconfig
            // 
            this.runconfig.Location = new System.Drawing.Point(109, 69);
            this.runconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.runconfig.Name = "runconfig";
            this.runconfig.Size = new System.Drawing.Size(156, 31);
            this.runconfig.TabIndex = 61;
            this.runconfig.TabStop = false;
            this.runconfig.Text = "Get Running Config";
            this.runconfig.UseVisualStyleBackColor = true;
            this.runconfig.Click += new System.EventHandler(this.runconfig_Click);
            // 
            // runningconfig
            // 
            this.runningconfig.Location = new System.Drawing.Point(15, 105);
            this.runningconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.runningconfig.Multiline = true;
            this.runningconfig.Name = "runningconfig";
            this.runningconfig.ReadOnly = true;
            this.runningconfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.runningconfig.Size = new System.Drawing.Size(343, 269);
            this.runningconfig.TabIndex = 62;
            this.runningconfig.TabStop = false;
            // 
            // startupconfig
            // 
            this.startupconfig.Location = new System.Drawing.Point(371, 105);
            this.startupconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startupconfig.Multiline = true;
            this.startupconfig.Name = "startupconfig";
            this.startupconfig.ReadOnly = true;
            this.startupconfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.startupconfig.Size = new System.Drawing.Size(343, 269);
            this.startupconfig.TabIndex = 63;
            this.startupconfig.TabStop = false;
            // 
            // startconfig
            // 
            this.startconfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startconfig.Location = new System.Drawing.Point(465, 69);
            this.startconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startconfig.Name = "startconfig";
            this.startconfig.Size = new System.Drawing.Size(156, 31);
            this.startconfig.TabIndex = 64;
            this.startconfig.TabStop = false;
            this.startconfig.Text = "Get Startup Config";
            this.startconfig.UseVisualStyleBackColor = true;
            this.startconfig.Click += new System.EventHandler(this.startconfig_Click);
            // 
            // GetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 389);
            this.Controls.Add(this.startconfig);
            this.Controls.Add(this.startupconfig);
            this.Controls.Add(this.runningconfig);
            this.Controls.Add(this.runconfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "GetConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetConfig_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label2;
        private Button runconfig;
        private TextBox runningconfig;
        private TextBox startupconfig;
        private Button startconfig;
    }
}