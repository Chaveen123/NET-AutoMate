using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NETAutoMate
{
    public partial class ProvisionPage : Form
    {
        public ProvisionPage()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            comport.Items.AddRange(ports);
        }

        private void ProvisionPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.ConfigType.Show();
        }

        private void openconfig_CheckedChanged(object sender, EventArgs e)
        {
            if (openconfig.Checked == true)
            {
                open.Visible = true;
            }
            else
            {
                //
            }                 
        }

        private void newconfig_CheckedChanged(object sender, EventArgs e)
        {
            if(newconfig.Checked == true)
            {
                open.Visible = false;
                check.Visible = false;

                this.Hide();
                NewConfigWizard newConfigWizard = new NewConfigWizard();
                newConfigWizard.ShowDialog();
                //this.Close();

                newconfig.Checked = false;
            }
            else
            {
                //
            }               
        }

        RunScript runScript = new RunScript();

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Parameter Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                check.Visible = true;
                path.Text = openFileDialog.FileName;
            }
            else
            {
                //
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (comport.SelectedItem == null)
            {
                MessageBox.Show("Select a COM Port!");
            }
            else
            {
                string templatepath = "\""+ Path.GetDirectoryName(Application.ExecutablePath) + @"\assets\jinja"+"\"";

                XmlDocument xmlDocument = new XmlDocument();

                xmlDocument.Load(path.Text);

                string dvendor = xmlDocument["Parameters"]["DeviceVendor"].InnerText;
                string dtype = xmlDocument["Parameters"]["DeviceType"].InnerText;
                string hostname = xmlDocument["Parameters"]["Hostname"].InnerText;
                string username = xmlDocument["Parameters"]["Username"].InnerText;
                string password = xmlDocument["Parameters"]["Password"].InnerText;
                string ipaddress = xmlDocument["Parameters"]["IPAddress"].InnerText;
                string subnetmask = xmlDocument["Parameters"]["SubnetMask"].InnerText;

                string message = $"Configure This New {dvendor} {dtype}?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    runScript.runpy("confignewdevice.py", templatepath + " " + dvendor + " " + dtype + " " + hostname + " " + username + " " + password + " " + ipaddress + " " + subnetmask + " " + comport.Text);
                    MessageBox.Show(runScript.name);
                }
                else
                {
                    //
                }                  
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @"assets\docs\readme.html");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            comport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comport.Items.AddRange(ports);
        }
    }
}
