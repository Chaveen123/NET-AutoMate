using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETAutoMate
{
    public partial class VLANTranslationWizard : Form
    {
        public VLANTranslationWizard()
        {
            InitializeComponent();

            dvendor.Items.Add("Cisco");
            dvendor.Items.Add("Arista");
            dvendor.Items.Add("Juniper");
        }

        RunScript runScript = new RunScript();

        private void start_Click(object sender, EventArgs e)
        {
            startpage.Visible = false;
            step1.Visible = true;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            startpage.Visible = true;
            step1.Visible = false;
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (dvendor.SelectedItem == null)
            {
                MessageBox.Show("Select the Device Vendor Before Proceeding!");
            }
            else
            {                          
                step1.Visible = false;
                step2.Visible = true;
            }
        }

        private void previous1_Click(object sender, EventArgs e)
        {
            step1.Visible = true;
            step2.Visible = false;
        }

        private void next3_Click(object sender, EventArgs e)
        {
            if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else
            {
                step2.Visible = false;
                step3.Visible = true;
            }
        }

        private void previous2_Click(object sender, EventArgs e)
        {
            step2.Visible = true;
            step3.Visible = false;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                MessageBox.Show("Enter a Username for the Device Before Proceeding!");
            }
            else if (password.Text.Length == 0)
            {
                MessageBox.Show("Enter a Password for the Device Before Proceeding!");
            }
            else if (username.Text.Any(Char.IsUpper))
            {
                MessageBox.Show("Username can only be in Lowercase!");
            }
            else
            {
                string message = $"Verify the Entered Details Before Proceeding!\n\nDevice Vendor: {dvendor.Text}\nIP Address: {ipaddress.Text}\nUsername: {username.Text}\nPassword: {password.Text}";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(@"C:\NETAutoMate\VLAN_Temp.txt");

                    string[] lines = streamReader.ReadToEnd().Split("\n");
                    string vlanid = lines[0];
                    string vlanname = lines[1];
                    string vlanip = lines[2];
                    string vlanmask = lines[3];

                    streamReader.Close();

                    runScript.runpy("vlantranslation.py", dvendor.Text + " " + ipaddress.Text + " " + username.Text + " " + password.Text + " " + vlanid + " " + vlanname + " " + vlanip + " " + vlanmask);
                    MessageBox.Show(runScript.name);

                    this.Close();
                }
                else
                {
                    //
                }
            }
        }

        private void VLANTranslationWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Exit Configuration Wizard?";
            string title = "Exit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Forms.VLANInterfacesPage.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
