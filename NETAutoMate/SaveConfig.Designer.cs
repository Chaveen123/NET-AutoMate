namespace NETAutoMate
{
    partial class SaveConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveConfig));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.configdiff = new System.Windows.Forms.TextBox();
            this.rollback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(135, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Save Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Configuration Difference";
            // 
            // commit
            // 
            this.commit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commit.Location = new System.Drawing.Point(328, 375);
            this.commit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(138, 31);
            this.commit.TabIndex = 61;
            this.commit.TabStop = false;
            this.commit.Text = "Commit Changes";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // configdiff
            // 
            this.configdiff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configdiff.Location = new System.Drawing.Point(15, 92);
            this.configdiff.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.configdiff.Multiline = true;
            this.configdiff.Name = "configdiff";
            this.configdiff.ReadOnly = true;
            this.configdiff.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.configdiff.Size = new System.Drawing.Size(449, 276);
            this.configdiff.TabIndex = 62;
            this.configdiff.TabStop = false;
            // 
            // rollback
            // 
            this.rollback.Location = new System.Drawing.Point(15, 375);
            this.rollback.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(138, 31);
            this.rollback.TabIndex = 64;
            this.rollback.TabStop = false;
            this.rollback.Text = "Rollback Changes";
            this.rollback.UseVisualStyleBackColor = true;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // SaveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.rollback);
            this.Controls.Add(this.configdiff);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "SaveConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveConfig_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label2;
        private Button commit;
        private TextBox configdiff;
        private Button rollback;
    }
}