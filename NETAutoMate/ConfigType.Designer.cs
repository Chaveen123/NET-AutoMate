namespace NETAutoMate
{
    partial class ConfigType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigType));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preconfigured = new System.Windows.Forms.Button();
            this.newconfig = new System.Windows.Forms.Button();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(104, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Configuration Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configure New Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(229, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pre-Configured Device";
            // 
            // preconfigured
            // 
            this.preconfigured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preconfigured.Image = ((System.Drawing.Image)(resources.GetObject("preconfigured.Image")));
            this.preconfigured.Location = new System.Drawing.Point(265, 66);
            this.preconfigured.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.preconfigured.Name = "preconfigured";
            this.preconfigured.Size = new System.Drawing.Size(100, 100);
            this.preconfigured.TabIndex = 7;
            this.preconfigured.TabStop = false;
            this.preconfigured.UseVisualStyleBackColor = true;
            this.preconfigured.Click += new System.EventHandler(this.preconfigured_Click);
            this.preconfigured.MouseHover += new System.EventHandler(this.preconfigured_MouseHover);
            // 
            // newconfig
            // 
            this.newconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newconfig.Image = ((System.Drawing.Image)(resources.GetObject("newconfig.Image")));
            this.newconfig.Location = new System.Drawing.Point(50, 66);
            this.newconfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newconfig.Name = "newconfig";
            this.newconfig.Size = new System.Drawing.Size(100, 100);
            this.newconfig.TabIndex = 8;
            this.newconfig.TabStop = false;
            this.newconfig.UseVisualStyleBackColor = true;
            this.newconfig.Click += new System.EventHandler(this.newconfig_Click);
            this.newconfig.MouseHover += new System.EventHandler(this.newconfig_MouseHover);
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
            // ConfigType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 201);
            this.Controls.Add(this.newconfig);
            this.Controls.Add(this.preconfigured);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "ConfigType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to NET-AutoMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigType_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Button preconfigured;
        private Button newconfig;
        private ToolTip hints;
    }
}