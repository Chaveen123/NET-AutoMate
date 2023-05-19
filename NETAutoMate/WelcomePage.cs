using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace NETAutoMate
{
    public partial class WelcomePage : Form
    {
      
        public WelcomePage()
        {
            InitializeComponent();

            dvendor.Items.Add("Arista");
            dvendor.Items.Add("Cisco");
            dvendor.Items.Add("Juniper");
            
            //dtype.Items.Add("Router");
            //dtype.Items.Add("Switch");        
        }
        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();

        void GetConfig()
        {
            runScript.runpy("getconfiglocal.py", "");
        }
        void Prerequisites()
        {
            runScript.runpy("prerequisites.py", "");
        }
        void VerifyNETCONFKeys()
        {
            var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"cmd.exe";
            processStartInfo.Arguments = $"/C ssh -o StrictHostKeyChecking=no -s {deviceusername}@{deviceip} -p830 netconf";

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            Thread.Sleep(1000);
            process.CloseMainWindow();
            process.WaitForExit();
        }
        void VerifySSHKeys()
        {
            var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"cmd.exe";
            processStartInfo.Arguments = $"/C ssh -o StrictHostKeyChecking=no {deviceusername}@{deviceip}";

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            Thread.Sleep(1000);
            process.CloseMainWindow();
            process.WaitForExit();
        }

        void CheckModel()
        {
            dmodel.Items.Clear();
            
            XElement xElement = XElement.Load(@"assets\devices\devicemodels.xml");

            IEnumerable<XElement> device = xElement.Descendants(dvendor.Text);

            foreach (var vendor in device)
            {
                string model = vendor.Element("Model").Value;
  
                dmodel.Items.Add(model);
            }
        }

        string type;

        void CheckType()
        {
            XElement xElement = XElement.Load(@"assets\devices\devicemodels.xml");

            var device = xElement.Descendants(dvendor.Text);

            foreach (var vendor in device)
            {       
                string model = vendor.Element("Model").Value;

                if (model == dmodel.Text)
                {
                    type = vendor.Element("Type").Value;
                }              
            }
        }

        void CheckAuth()
        {          
            if (File.Exists(@"C:\NETAutoMate\DeviceAuth.csv"))
            {
                var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                string message = $"Device Authentication File Found for {devicevendor} {devicetype} {deviceip}";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Ping ping = new Ping();                
                    IPAddress address = IPAddress.Parse(deviceip);
                    PingReply pingReply = ping.Send(address);

                    if (pingReply.Status == IPStatus.Success)
                    {
                        try
                        {
                            waitMessage.Wait(GetConfig);

                            string porterror = "socket";
                            string hosterror = "host";
                            string autherror = "Authentication";

                            if (runScript.name.Length == 0)
                            {
                                MessageBox.Show("System has Not Detected the Additional Python Libraries!");

                                string message1 = "It is required to have a Stable Internet Connection. Download and Install?";
                                string title1 = "Proceed?";
                                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Warning);
                                if (result1 == DialogResult.OK)
                                {
                                    Process.Start("cmd.exe", "/C pip install ncclient & pip install napalm & pip install get-mac & pip install mac-vendor-lookup").WaitForExit();
                                    MessageBox.Show("Additional Libraries Installed Successfully. Retry!");
                                }
                                else
                                {
                                    //
                                }
                            }
                            else if (runScript.name.Contains(porterror))
                            {
                                MessageBox.Show(runScript.name + "\nMake sure NETCONF is enabled on the Device. If not, Click 'Get Started' to configure the necessary Prerequesites.");

                                string message1 = "Device is NOT Compatible with NETCONF! Certain Configurations will Take Few Seconds to Load. Continue in Legacy Mode?";
                                string title1 = "Proceed?";
                                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Warning);
                                if (result1 == DialogResult.OK)
                                {
                                    string message2 = "Before Proceeding, make sure SSH HOST Keys are Verified. Verify HOST Keys?";
                                    string title2 = "Proceed?";
                                    MessageBoxButtons buttons2 = MessageBoxButtons.OKCancel;
                                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2, MessageBoxIcon.Warning);
                                    if (result2 == DialogResult.OK)
                                    {
                                        StreamReader streamReader = new StreamReader($@"C:\Users\{Environment.UserName}\.ssh\known_hosts");
                                        string readfile;

                                        readfile = streamReader.ReadToEnd();

                                        streamReader.Close();

                                        if (readfile.Contains(deviceip))
                                        {
                                            MessageBox.Show($"HOST Keys for {deviceip} has Already been Verified!");
                                        }
                                        else
                                        {
                                            VerifySSHKeys();

                                            MessageBox.Show("HOST Keys Verified Successfully!");
                                        }

                                        File.WriteAllText(@"C:\NETAutoMate\NETCONF_Compatible.txt", "NO");

                                        this.Hide();
                                        Forms.SelectionPage.ShowDialog();
                                    }
                                    else
                                    {
                                        //
                                    }
                                }
                                else
                                {
                                    //
                                }
                            }
                            else if (runScript.name.Contains(hosterror))
                            {
                                string message1 = runScript.name + "\nMake sure HOST Keys are Verified. Verify HOST Keys?";
                                string title1 = "Proceed?";
                                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Warning);
                                if (result1 == DialogResult.OK)
                                {
                                    VerifyNETCONFKeys();
                                    Thread.Sleep(1000);
                                    VerifySSHKeys();
                                    this.Focus();

                                    MessageBox.Show("HOST Keys Verified Successfully. Retry!");
                                }
                                else
                                {
                                    //
                                }
                            }
                            else if (runScript.name.Contains(autherror))
                            {
                                MessageBox.Show("Authentication Error. Re-Check Username & Password!");
                            }
                            else
                            {
                                File.WriteAllText(@"C:\NETAutoMate\NETCONF_Compatible.txt", "YES");
                                MessageBox.Show(runScript.name);

                                this.Hide();
                                Forms.SelectionPage.ShowDialog();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Please Install Python v3 Before Using The Software!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection Cannot be Established with the Device. Make sure the Device is Connected to the Network or Re-Check Authentication Details!");
                    }                   
                }
                else
                {
                    MessageBox.Show("Enter New Device Authentication!");
                }
            }
            else
            {
                MessageBox.Show("Device Authentication File Not Found. Please Retry!");
            }
        }

        void SaveAuth()
        {
            string location = @"C:\";
            string path = Path.Combine(location, "NETAutoMate");
            Directory.CreateDirectory(path);

            string file = Path.Combine(path, "DeviceAuth.csv");

            string netmiko;

            CheckType();

            if (dvendor.Text == "Cisco")
            {
                netmiko = dvendor.Text.Replace("Cisco", "cisco_ios");             
                File.WriteAllText(file, dvendor.Text + "," + dmodel.Text + "," + type + "," + netmiko + "," + ipaddress.Text + "," + username.Text + "," + password.Text);
            }
            if (dvendor.Text == "Juniper")
            {
                netmiko = dvendor.Text.Replace("Juniper", "juniper");
                File.WriteAllText(file, dvendor.Text + "," + dmodel.Text + "," + type + "," + netmiko + "," + ipaddress.Text + "," + username.Text + "," + password.Text);
            }
            if (dvendor.Text == "Arista")
            {
                netmiko = dvendor.Text.Replace("Arista", "arista_eos");
                File.WriteAllText(file, dvendor.Text + "," + dmodel.Text + "," + type + "," + netmiko + "," + ipaddress.Text + "," + username.Text + "," + password.Text);
            }
            MessageBox.Show("Device Authentication Details Saved Successfully!");
        }

        private void save_Click(object sender, EventArgs e)
        {         
            if (dvendor.SelectedItem == null && dmodel.SelectedItem == null && username.Text == "" && ipaddress.Text == "" && password.Text == "")
            {
                MessageBox.Show("Enter Authentication Details!");
            }
            else
            {
                if (dvendor.SelectedItem == null || dmodel.SelectedItem == null || username.Text == "" || ipaddress.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Incomplete Authentication!");
                }
                else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
                {
                    MessageBox.Show("Invalid IP Address!");
                }
                else
                {
                    if (File.Exists(@"C:\NETAutoMate\DeviceAuth.csv"))
                    {
                        var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                        if (dvendor.Text == devicevendor && dmodel.Text == devicemodel && ipaddress.Text == deviceip && username.Text == deviceusername && password.Text == devicepassword)
                        {
                            MessageBox.Show("Current Authentication Details are Already Saved!");
                        }
                        else
                        {
                            string message = "Device Authentication Details Already Exist! Overwrite Authentication File?";
                            string title = "Proceed?";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                SaveAuth();
                            }
                            else
                            {
                                //
                            }
                        }
                    }
                    else
                    {
                        SaveAuth();
                    }
                }
            }               
        }
        
        private void next_Click(object sender, EventArgs e)
        {     
            if (dvendor.SelectedItem == null && dmodel.SelectedItem == null && username.Text == "" && ipaddress.Text == "" && password.Text == "")
            {
                CheckAuth();
            }
            else
            {
                if (File.Exists(@"C:\NETAutoMate\DeviceAuth.csv"))
                {
                    var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                    if (dvendor.Text == devicevendor && dmodel.Text == devicemodel && ipaddress.Text == deviceip && username.Text == deviceusername && password.Text == devicepassword)
                    {
                        CheckAuth();
                    }
                    else
                    {
                        MessageBox.Show("Save New Device Authentication Before Proceeding!");
                    }
                }
                else
                {
                    MessageBox.Show("Save New Device Authentication Before Proceeding!");
                }
            }                   
        }

        private void delete_Click(object sender, EventArgs e)
        {        
            if (File.Exists(@"C:\NETAutoMate\DeviceAuth.csv"))
            {
                var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                string message = $"Delete the Device Authentication File of {devicevendor} {devicetype} {deviceip} ?";
                string title = "Delete?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    File.Delete(@"C:\NETAutoMate\DeviceAuth.csv");
                    MessageBox.Show("Device Authentication File Deleted Successfully");
                }
                else
                {
                    //
                }               
            }
            else
            {
                MessageBox.Show("Device Authentication File Doesn't Exist!");
            }
        }

        private void vendorlookup_Click(object sender, EventArgs e)
        {
            if(ipaddress.Text == "")
            {
                MessageBox.Show("Please Enter Device IP Address");
            }
            else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else
            {
                try
                {
                    runScript.runpy("vendorlookup.py", ipaddress.Text);

                    if (runScript.name.Length == 0)
                    {
                        MessageBox.Show("System has Not Detected the Additional Python Libraries of this Feature!");

                        string message1 = "It is required to have a Stable Internet Connection. Download and Install?";
                        string title1 = "Proceed?";
                        MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                        DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Warning);
                        if (result1 == DialogResult.OK)
                        {
                            Process.Start("cmd.exe", "/C pip install get-mac & pip install mac-vendor-lookup").WaitForExit();
                            MessageBox.Show("Libraries for Vendor Lookup Installed Successfully. Retry!");
                        }
                        else
                        {
                            //
                        }
                    }
                    else if (runScript.name.Contains("Cisco"))
                    {
                        dvendor.SelectedItem = "Cisco";

                        CheckModel();                                                          
                    }
                    else if (runScript.name.Contains("Arista"))
                    {
                        dvendor.SelectedItem = "Arista";

                        CheckModel();
                    }
                    else if (runScript.name.Contains("Juniper"))
                    {
                        dvendor.SelectedItem = "Juniper";

                        CheckModel();
                    }
                    else
                    {
                        MessageBox.Show(runScript.name);
                        dvendor.SelectedIndex = -1;
                    }
                }
                catch
                {
                    MessageBox.Show("Please Install Python v3 Before Using The Software!");
                }
            }         
        }

        private void WelcomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.ConfigType.Show();
        }

        private void prerequisites_Click(object sender, EventArgs e)
        {         
            if (File.Exists(@"C:\NETAutoMate\DeviceAuth.csv"))
            {
                var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                string message = $"System will configure the necessary prerequisites for the {devicevendor} {devicetype} {deviceip}";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        waitMessage.Wait(Prerequisites);
                        MessageBox.Show(runScript.name);
                    }
                    catch
                    {
                        MessageBox.Show("Please Install Python v3 Before Using The Software!");
                    }                   
                }
                else
                {
                    //
                }
            }
            else
            {
                MessageBox.Show("Device Authentication File Doesn't Exist!");
            }          
        }

        private void help_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @"assets\docs\readme.html");
        }

        private void cleardata_Click(object sender, EventArgs e)
        {
            dvendor.SelectedIndex = -1;
            dmodel.SelectedIndex = -1;
            ipaddress.Text = null;      
            username.Text = null;
            password.Text = null;
        }

        private void dvendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }      

        private void dmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dvendor_SelectedIndexChanged(object sender, EventArgs e)
        {        
            if (dvendor.SelectedIndex < 0)
            {
                dvendor.Text = "Select Device Vendor";
            }
            else
            {
                CheckModel();
                dmodel.Text = "Select Device Model";
            }
        }

        private void dmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dmodel.SelectedIndex < 0)
            {
                dmodel.Text = "Select Device Model";
            }
        }

        private void ipaddress_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                dvendor.Enabled = true;
                dmodel.Enabled = true;
                username.Enabled = true;
                password.Enabled = true;
            }
            else
            {
                dvendor.Enabled = false;
                dmodel.Enabled = false;
                username.Enabled = false;
                password.Enabled = false;
            }
        }
    }
}