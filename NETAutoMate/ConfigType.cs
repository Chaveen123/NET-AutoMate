using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETAutoMate
{
    public partial class ConfigType : Form
    {
        public ConfigType()
        {
            InitializeComponent();          
        }

        private void preconfigured_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.WelcomePage.ShowDialog();
        }    

        private void preconfigured_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Use This Option To Perform Configurations To a Pre-Configured Device Using SSH & NETCONF", preconfigured);
        }

        private void newconfig_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Use This Option To Provision a New Device Using Serial", newconfig);
        }

        private void newconfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ProvisionPage.ShowDialog();
        }

        private void ConfigType_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Quit NET-AutoMate?";
            string title = "Quit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Hand);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
