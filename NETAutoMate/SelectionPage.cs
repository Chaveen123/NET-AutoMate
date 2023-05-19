using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETAutoMate
{
    public partial class SelectionPage : Form
    {
        public SelectionPage()
        {
            InitializeComponent();

            string version = File.ReadAllText(@"assets\docs\versioninfo.txt");
            versioninfo.Text = version;       
        }

        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();

        void GetDeviceInfo()
        {
            runScript.runpy("getdeviceinfo.py", "");
        }

        void GetARPInfo()
        {
            runScript.runpy("getarptable.py", "");
        }

        void GetMACInfo()
        {
            runScript.runpy("getmactable.py", "");
        }
        
        void BackupDevice()
        {
            runScript.runpy("backupconfig.py", "");
        }

        void GetConfig()
        {
            runScript.runpy("getconfiglocal.py", "");
        }

        void PingDevice()
        {
            runScript.runpy("pingdevice.py", pingdevice.Text);
        }      

        void CheckCompatibility()
        {
            StreamReader streamReader = new StreamReader(@"C:\NETAutoMate\NETCONF_Compatible.txt");
            string readfile;

            readfile = streamReader.ReadLine();
            streamReader.Close();

            if(readfile == "YES")
            {
                mode.Visible = false;
            }
            else
            {
                mode.Visible = true;
            }
        }

        private void dping_CheckedChanged(object sender, EventArgs e)
        {
            pingdevice.Visible = dping.Checked;
            pingdevice.Clear();
        }
       
        private void confirm_Click(object sender, EventArgs e)
        {                
            if (routedint.Checked)
            {
                var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                if (devicetype == "L2 Switch")
                {
                    MessageBox.Show($"Permission Denied! You are currently configuring a {devicevendor} {devicetype}\nRouted Interface Configurations are only allowed on Routers and L3 Switches");
                }
                else
                {
                    this.Hide();
                    Forms.InterfacesPage.ShowDialog();
                }               
            }
            if (loopbackint.Checked)
            {
                this.Hide();
                Forms.LoopbacktnterfacesPage.ShowDialog();
            }
            if (vlanint.Checked)
            {
                var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                if (devicetype == "Router")
                {
                    MessageBox.Show($"Permission Denied! You are currently configuring a {devicevendor} {devicetype}\nVLAN Configurations are only allowed on L2 and L3 Switches");
                }
                else
                {
                    this.Hide();
                    Forms.VLANInterfacesPage.ShowDialog();
                }
            }
            if (portscan.Checked)
            {
                this.Hide();
                Forms.PortScanner.ShowDialog();
            }
            if(getdeviceinfo.Checked)
            {
                waitMessage.Wait(GetDeviceInfo);
                MessageBox.Show(runScript.name);
            }
            if (getarptable.Checked)
            {
                waitMessage.Wait(GetARPInfo);
                MessageBox.Show(runScript.name);
            }
            if (getmactable.Checked)
            {
                waitMessage.Wait(GetMACInfo);
                MessageBox.Show(runScript.name);
            }
            if (backupconfig.Checked)
            {
                string message = "Backup Device Running Configuration?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    waitMessage.Wait(BackupDevice);
                    MessageBox.Show(runScript.name);
                }
                else
                {
                    //
                }           
            }
            if (getconfig.Checked)
            {
                this.Hide();               
                Forms.GetConfig.ShowDialog();
            }
            if (dping.Checked)
            {
                if (pingdevice.Text == "")
                {
                    MessageBox.Show("Please Enter IP Address to PING!");
                }
                else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(pingdevice.Text))
                {
                    MessageBox.Show("Please Enter a Valid IP Address!");
                }
                else
                {
                    string message = "Ping Target Device?";
                    string title = "Proceed?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Ping ping = new Ping();
                        IPAddress address = IPAddress.Parse(pingdevice.Text);
                        PingReply pingReply = ping.Send(address);

                        if (pingReply.Status == IPStatus.Success)
                        {
                            waitMessage.Wait(PingDevice);
                            MessageBox.Show(runScript.name);
                        }
                        else
                        {
                            MessageBox.Show("Entered IP Address is NOT Available in the Network. Re-Check IP Address!");
                        }
                    }
                    else
                    {
                        //
                    }               
                }
            }
            if ((dping.Checked || vlanint.Checked || routedint.Checked || loopbackint.Checked || portscan.Checked || getdeviceinfo.Checked || getarptable.Checked || getmactable.Checked || backupconfig.Checked || getconfig.Checked)==false)
            {
                MessageBox.Show("Please Select an Option!");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (mode.Visible == false)
            {
                string message = "Refresh Device Configuration File?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    waitMessage.Wait(GetConfig);
                    string error = "System was UNABLE to Retrieve Device Configuration. Please Retry!";
                    if (runScript.name.Contains(error))
                    {
                        MessageBox.Show(runScript.name);
                    }
                    else
                    {
                        MessageBox.Show(runScript.name);
                    }
                }
                else
                {
                    //
                }
            }
            else
            {
                MessageBox.Show("Permission Denied! Device is NOT Compatible with NETCONF");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string message = "Save Current Configurations?";
            string title = "Proceed?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                SaveConfig saveConfig = new SaveConfig();
                saveConfig.ShowDialog();
            }
            else
            {
                //
            }          
        }

        private void SelectionPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Quit to Welcome Page?";
            string title = "Quit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (File.Exists(@"C:\NETAutoMate\VLAN_Temp.txt"))
                {
                    File.Delete(@"C:\NETAutoMate\VLAN_Temp.txt");
                }
                else
                {
                    //
                }
                this.Hide();
                Forms.WelcomePage.Show();

                Forms.InterfacesPage.Close();
                Forms.LoopbacktnterfacesPage.Close();
                Forms.VLANInterfacesPage.Close();
                Forms.GetConfig.Close();
                Forms.PortScanner.Close();

                mode.Visible = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void refresh_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Refresh Device Configuration", refresh);
        }

        private void save_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Save Device Configuration", save);
        }

        private void help_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"assets\docs\readme.txt");
        }

        private void SelectionPage_Load(object sender, EventArgs e)
        {
            CheckCompatibility();
        }
    }
}
