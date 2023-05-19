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
    public partial class LoopbackInterfacesPage : Form 
    {
        public LoopbackInterfacesPage()
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

        void GetLoopbacks()
        {
            runScript.runpy("getloopbackinterfaces.py", "");
        }

        void clear()
        {
            iplabel.Text = "";
            subnetlabel.Text = "";
            statuslabel.Text = "";
        }

        private void getlbintdetails_Click(object sender, EventArgs e)
        {
            if(selint.Items.Count != 0)
            {
                if (selint.SelectedIndex > -1)
                {
                    if (iplabel.Text.Trim() == "")
                    {
                        runScript.runpy("getloopbackinterfaces.py", selint.Text);

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
                    MessageBox.Show("Select a Loopback Interface!");
                }
            }
            else
            {
                MessageBox.Show("No Loopback Interfaces Created!");
            }                                        
        }     

        private void selint_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
        }

        void checkloopbacks()
        {
            clear();

            selint.Items.Clear();

            waitMessage.Wait(GetLoopbacks);

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

        private void retrievelbint_CheckedChanged(object sender, EventArgs e)
        {
            //checkloopbacks();

            retrievelbintdetails.Visible = true;
            createnewlbint.Visible = false;

            getlbintdetails.Visible = true;
            removelbint.Visible = true;
        }

        private void removelbint_Click(object sender, EventArgs e)
        {
            if (selint.SelectedIndex > -1)
            {
                if (iplabel.Text != "")
                {
                    string message = "This Operation Cannot be Undone! Remove This Loopback Interface?";
                    string title = "Proceed?";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        runScript.runpy("removeloopbackinterfaces.py", selint.Text + " " + iplabel.Text);
                        MessageBox.Show(runScript.name);
                        if (!runScript.name.Contains("Error"))
                        {
                            waitMessage.Wait(GetConfig);

                            checkloopbacks();

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
                else
                {
                    MessageBox.Show("You are about to Remove a Loopback Interface! Click Get Details to View Interface Details before Proceeding");                   
                }                
            }
            else
            {
                MessageBox.Show("Select a Loopback Interface!");
            }
        }

        private void createlbint_Click(object sender, EventArgs e)
        {
            if (newlbname.Text == "" || newlbip.Text == "" || newlbsubnet.Text =="")
            {
                MessageBox.Show("Incomplete. Please fill all fields!");
            }
            else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(newlbip.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else if (!(new Regex(@"^(((255\.){3}(255|254|252|248|240|224|192|128|0+))|((255\.){2}(255|254|252|248|240|224|192|128|0+)\.0)|((255\.)(255|254|252|248|240|224|192|128|0+)(\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\.0+){3}))$")).IsMatch(newlbsubnet.Text))
            {
                MessageBox.Show("Enter a Valid Subnet Mask!");
            }
            else
            {
                string message = "Create This Loopback Interface?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    runScript.runpy("createloopbackinterfaces.py", newlbname.Text + " " + newlbip.Text + " " + newlbsubnet.Text);
                    MessageBox.Show(runScript.name);

                    if (!runScript.name.Contains("Error"))
                    {
                        waitMessage.Wait(GetConfig);

                        checkloopbacks();
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

        private void newlbint_CheckedChanged(object sender, EventArgs e)
        {
            retrievelbintdetails.Visible = false;
            createnewlbint.Visible = true;

            getlbintdetails.Visible = false;
            removelbint.Visible = false;
        }

        private void newlbname_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Loopback0",newlbname);
        }

        private void newlbip_MouseHover(object sender, EventArgs e)
        {
            hints.Show("1.1.1.1", newlbip);
        }

        private void newlbsubnet_MouseHover(object sender, EventArgs e)
        {
            hints.Show("255.255.255.255", newlbsubnet);
        }

        private void LoopbackInterfacesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();

            selint.SelectedIndex = -1;
            clear();
        }

        private void LoopbackInterfacesPage_Load(object sender, EventArgs e)
        {
            checkloopbacks();
        }
    }
}
