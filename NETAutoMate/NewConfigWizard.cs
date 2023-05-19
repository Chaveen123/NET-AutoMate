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
using System.Xml;

namespace NETAutoMate
{
    public partial class NewConfigWizard : Form
    {
        public NewConfigWizard()
        {
            InitializeComponent();

            dvendor.Items.Add("Cisco");
            //dvendor.Items.Add("Juniper");
            //dvendor.Items.Add("Arista");

            dtype.Items.Add("Switch");
            dtype.Items.Add("Router");
        }

        private void start_Click(object sender, EventArgs e)
        {
            startpage.Visible = false;
            step1.Visible = true;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            startpage.Visible = true;
            step1.Visible=false;
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if(dvendor.SelectedItem == null)
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
            step1.Visible=true;
            step2.Visible=false;
        }

        private void next3_Click(object sender, EventArgs e)
        {
            if(dtype.SelectedItem == null)
            {
                MessageBox.Show("Select the Device Type Before Proceeding!");
            }
            else
            {
                step2.Visible = false;
                step3.Visible = true;
            }        
        }

        private void previous2_Click(object sender, EventArgs e)
        {
            step2.Visible= true;
            step3.Visible = false;
        }

        private void next4_Click(object sender, EventArgs e)
        {
            if(hostname.Text.Length == 0)
            {
                MessageBox.Show("Enter a Hostname for the Device Before Proceeding!");
            }
            else
            {
                step3.Visible = false;
                step4.Visible = true;
            }                 
        }

        private void previous3_Click(object sender, EventArgs e)
        {
            step3.Visible = true;
            step4.Visible=false;
        }

        private void next5_Click(object sender, EventArgs e)
        {
            if(username.Text.Length == 0)
            {
                MessageBox.Show("Enter a Username for the Device Before Proceeding!");
            }
            else if(password.Text.Length == 0)
            {
                MessageBox.Show("Enter a Password for the Device Before Proceeding!");
            }
            else if(username.Text.Any(Char.IsUpper))
            {
                MessageBox.Show("Username can only be in Lowercase!");
            }
            else
            {             
                step4.Visible = false;
                step5.Visible = true;
            }                     
        }

        private void previous4_Click(object sender, EventArgs e)
        {
            step4.Visible = true;
            step5.Visible=false;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else if (!(new Regex(@"^(((255\.){3}(255|254|252|248|240|224|192|128|0+))|((255\.){2}(255|254|252|248|240|224|192|128|0+)\.0)|((255\.)(255|254|252|248|240|224|192|128|0+)(\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\.0+){3}))$")).IsMatch(subnetmask.Text))
            {
                MessageBox.Show("Enter a Valid Subnet Mask!");
            }
            else
            {
                if (dtype.Text == "Router")
                {
                    MessageBox.Show("IP Address will be Configured on GigabitEthernet 0/0 Port.\nConnect the Ethernet Cable to this Port for SSH Connectivity!");
                }

                string message = $"Verify the Entered Details Before Saving!\n\nDevice Vendor: {dvendor.Text}\nDevice Type: {dtype.Text}\nHostname: {hostname.Text}\nUsername: {username.Text}\nPassword: {password.Text}\nIP Address: {ipaddress.Text}\nSubnet Mask: {subnetmask.Text}";
                string title = "Save?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    string location = @"C:\";
                    string path = Path.Combine(location, @"NETAutoMate\Device_ConfigParams");
                    Directory.CreateDirectory(path);
                    string file = Path.Combine(path, $"DeviceConfigParams_{dvendor.Text}_{dtype.Text}_{hostname.Text}_{ipaddress.Text}.xml");

                    XmlTextWriter xmlTextWriter = new XmlTextWriter(file, Encoding.UTF8);

                    xmlTextWriter.Formatting = Formatting.Indented;

                    xmlTextWriter.WriteStartDocument();

                    xmlTextWriter.WriteStartElement("Parameters");

                    xmlTextWriter.WriteElementString("DeviceVendor", dvendor.Text);
                    xmlTextWriter.WriteElementString("DeviceType", dtype.Text);
                    xmlTextWriter.WriteElementString("Hostname", hostname.Text);
                    xmlTextWriter.WriteElementString("Username", username.Text);
                    xmlTextWriter.WriteElementString("Password", password.Text);
                    xmlTextWriter.WriteElementString("IPAddress", ipaddress.Text);
                    xmlTextWriter.WriteElementString("SubnetMask", subnetmask.Text);

                    xmlTextWriter.WriteEndElement();

                    xmlTextWriter.Close();

                    MessageBox.Show("Device Configuration Details Saved Successfully!\nFiles are Available at 'C:\\NETAutoMate\\Device_ConfigParams'");

                    this.Close();
                }
                else
                {
                    //
                }
            }
        }

        private void hostname_MouseHover(object sender, EventArgs e)
        {
            hints.Show("A Hostname will be used to Uniquely Identify the Device in the Network", hostname);
        }

        private void username_MouseHover(object sender, EventArgs e)
        {
            hints.Show("A Username will be used as a Parameter to Connect to the Device using SSH",username);
        }

        private void password_MouseHover(object sender, EventArgs e)
        {
            hints.Show("A Password will be used as a Parameter to Connect to the Device using SSH", password);
        }

        private void ipaddress_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Make sure the IP Address is Unique and belongs to the same Network Subnet as the Host PC", ipaddress);
        }

        private void NewConfigWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Exit Configuration Wizard?";
            string title = "Exit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Forms.ProvisionPage.Show();              
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
