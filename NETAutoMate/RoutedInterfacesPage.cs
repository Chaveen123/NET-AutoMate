using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace NETAutoMate
{
    public partial class RoutedInterfacesPage : Form 
    {
        public RoutedInterfacesPage()
        {
            InitializeComponent();      
        }

        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();

        void GetConfig()
        {
            StreamReader streamReader = new StreamReader(@"C:\NETAutoMate\NETCONF_Compatible.txt");
            string readfile;

            readfile = streamReader.ReadLine();
            streamReader.Close();

            if (readfile == "YES")
            {
                Thread.Sleep(1000);
                runScript.runpy("getconfiglocal.py", "");
            }
            else
            {
                //
            }
        }

        void GetInterfaces()
        {
            runScript.runpy("getinterfaces.py", "");
        }

        void clear()
        {
            iplabel.Text = "";
            subnetlabel.Text = "";
            statuslabel.Text = "";
        }

        private void configroutedint_Click(object sender, EventArgs e)
        {
            if (selint.SelectedItem == null || ipaddress.Text == "" || netmask.Text == "")
            {
                MessageBox.Show("Incomplete. Please fill all fields!");
            }
            else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else if (!(new Regex(@"^(((255\.){3}(255|254|252|248|240|224|192|128|0+))|((255\.){2}(255|254|252|248|240|224|192|128|0+)\.0)|((255\.)(255|254|252|248|240|224|192|128|0+)(\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\.0+){3}))$")).IsMatch(netmask.Text))
            {
                MessageBox.Show("Enter a Valid Subnet Mask!");
            }
            else
            {
                if (selint.SelectedIndex > -1)
                {
                    string message = "Configure This Routed Interface?";
                    string title = "Proceed?";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        runScript.runpy("configroutedinterfaces.py", selint.Text + " " + ipaddress.Text + " " + netmask.Text);
                        MessageBox.Show(runScript.name);

                        if (!runScript.name.Contains("Error"))
                        {
                            waitMessage.Wait(GetConfig);

                            clear();
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
                else
                {
                    MessageBox.Show("Select an Interface!");
                }
            }
        }
      
        private void getintdetails_Click(object sender, EventArgs e)
        {                  
            if(selint.SelectedIndex >-1)
            {
                if (iplabel.Text.Trim() == "")
                {
                    runScript.runpy("getinterfaces.py", selint.Text);

                    string x = runScript.name;

                    string[] strings = x.Split('\n');
                    iplabel.Text = strings[0];
                    subnetlabel.Text = strings[1];
                    statuslabel.Text = strings[2];
                }
                else
                {
                    //
                }
            }
            else
            {
                MessageBox.Show("Select an Interface!");
            }                                        
        }     

        private void selint_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
        }

        void checkinterfaces()
        {        
            selint.Items.Clear();

            waitMessage.Wait(GetInterfaces);

            string x = runScript.name;

            string[] strings = x.Split();
            foreach (string s in strings)
            {
                selint.Items.Add(s);
                for (int i = selint.Items.Count - 1; i >= 0; i += -1)
                {
                    if (String.IsNullOrWhiteSpace(selint.GetItemText(selint.Items[i]).Trim()))
                    {
                        selint.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void retrieveint_CheckedChanged(object sender, EventArgs e)
        {
            //checkinterfaces();

            label3.Visible = true;
            selint.Visible = true;

            retrieveintdetails.Visible = true;
            confignewint.Visible = false;

            configroutedint.Visible = false;
            getintdetails.Visible = true;
            removeint.Visible = true;
        }

        private void configint_CheckedChanged(object sender, EventArgs e)
        {
            //checkinterfaces();

            label3.Visible = true;
            selint.Visible = true;

            retrieveintdetails.Visible = false;
            confignewint.Visible = true;
            
            configroutedint.Visible = true;
            getintdetails.Visible = false;
            removeint.Visible = false;
        }

        private void removeint_Click(object sender, EventArgs e)
        {
            if (selint.SelectedIndex > -1)
            {
                if (iplabel.Text != "")
                {
                    var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                    if (deviceip == iplabel.Text.Trim())
                    {
                        MessageBox.Show("You are connected to the System through this Routed Interface. Any changes to this would cause a disconnection!");
                    }
                    else if (iplabel.Text.Contains("Not Configured!"))
                    {
                        MessageBox.Show("Interface Not Configured!");
                    }
                    else
                    {
                        string message = "This Operation Cannot be Undone! Remove This Interface?";
                        string title = "Proceed?";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.OK)
                        {
                            runScript.runpy("removeroutedinterfaces.py", selint.Text);
                            MessageBox.Show(runScript.name);

                            if (!runScript.name.Contains("Error"))
                            {
                                waitMessage.Wait(GetConfig);

                                clear();

                                MessageBox.Show("If This Action was Performed Mistakenly, you may Rollback the Current Changes using the 'Save Configuration' Option!");
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
                }
                else
                {
                    MessageBox.Show("You are about to Remove an IP Address of an Interface! Click Get Details to View Interface Details before Proceeding");                   
                }                
            }
            else
            {
                MessageBox.Show("Select an Interface!");
            }
        }

        private void RoutedInterfacesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();

            selint.SelectedIndex = -1;
            clear();      
        }

        private void RoutedInterfacesPage_Load(object sender, EventArgs e)
        {
            checkinterfaces();
        }
    }
}
