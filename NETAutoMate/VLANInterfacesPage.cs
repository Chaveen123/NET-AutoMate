using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NETAutoMate
{
    public partial class VLANInterfacesPage : Form 
    {
        public VLANInterfacesPage()
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

        void GetVLANs()
        {
            runScript.runpy("getvlans.py", "");
        }

        void GetInterfaces()
        {
            runScript.runpy("getinterfaces.py", "");
        }

        void clear()
        {
            vnamelabel.Text = "";
            vstatuslabel.Text = "";
            viplabel.Text = "";
            vsubnetabel.Text = "";     
            assignedports.Items.Clear();
        }

        void assignedaccessports()
        {
            runScript.runpy("getvlanaccessports.py", selvlanid.Text);

            string x = runScript.name;

            string[] strings = x.Split();
            foreach (string s in strings)
            {
                assignedports.Items.Add(s);
                for (int i = assignedports.Items.Count - 1; i >= 0; i += -1)
                {
                    if (String.IsNullOrWhiteSpace(selvlanid.GetItemText(assignedports.Items[i]).Trim()))
                    {
                        assignedports.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void getvlandetails_Click(object sender, EventArgs e)
        {   
            if(selvlanid.Items.Count != 0)
            {
                if (selvlanid.SelectedIndex > -1)
                {
                    if (vnamelabel.Text.Trim() == "")
                    {
                        runScript.runpy("getvlans.py", selvlanid.Text);

                        string r = runScript.name;
                        string[] str = r.Split('\n');
                        vnamelabel.Text = str[0];
                        vstatuslabel.Text = str[1];
                        viplabel.Text = str[2];
                        vsubnetabel.Text = str[3];

                        assignedaccessports();

                        translatevlan.Visible = true;
                    }
                    else
                    {
                        //
                    }                     
                }
                else
                {
                    MessageBox.Show("Select a VLAN!");
                }
            }
            else
            {
                MessageBox.Show("No VLANs Created!");
            }        
        }    

        private void selvlanid_SelectedIndexChanged(object sender, EventArgs e)
        {
            translatevlan.Visible = false;

            clear();          
        }

        void checkvlans()
        {
            clear();

            selvlanid.Items.Clear();

            waitMessage.Wait(GetVLANs);

            string x = runScript.name;

            string[] strings = x.Split();
            foreach (string s in strings)
            {
                selvlanid.Items.Add(s);
                for (int i = selvlanid.Items.Count - 1; i >= 0; i += -1)
                {
                    if (String.IsNullOrWhiteSpace(selvlanid.GetItemText(selvlanid.Items[i]).Trim()))
                    {
                        selvlanid.Items.RemoveAt(i);
                    }
                }
            }
        }

        void checkaccessports()
        {
            newaccessports.Items.Clear();

            waitMessage.Wait(GetInterfaces);

            string x = runScript.name;

            string[] strings = x.Split();
            foreach (string s in strings)
            {
                newaccessports.Items.Add(s);
                for (int i = newaccessports.Items.Count - 1; i >= 0; i += -1)
                {
                    if (String.IsNullOrWhiteSpace(newaccessports.GetItemText(newaccessports.Items[i]).Trim()))
                    {
                        newaccessports.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void retrievevlan_CheckedChanged(object sender, EventArgs e)
        {
            //checkvlans();

            retrievevlandetails.Visible = true;
            createnewvlan.Visible = false;
            translatevlan.Visible = false;
            getvlandetails.Visible = true;
            removevlan.Visible = true;
        }
   
        private void newvlan_CheckedChanged(object sender, EventArgs e)
        {
            //checkaccessports();

            retrievevlandetails.Visible = false;
            createnewvlan.Visible = true;
            translatevlan.Visible = false;
            getvlandetails.Visible = false;
            removevlan.Visible = false;
        }

        private void createvlanint_Click(object sender, EventArgs e)
        {
            if (newvlanid.Text == "" || newvlanname.Text == "" || newvlanip.Text == "" || newvlansubnet.Text == "" || newaccessports.Text == "")
            {
                MessageBox.Show("Incomplete. Please fill all fields!");
            }
            else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(newvlanip.Text))
            {
                MessageBox.Show("Enter a Valid IP Address!");
            }
            else if (!(new Regex(@"^(((255\.){3}(255|254|252|248|240|224|192|128|0+))|((255\.){2}(255|254|252|248|240|224|192|128|0+)\.0)|((255\.)(255|254|252|248|240|224|192|128|0+)(\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\.0+){3}))$")).IsMatch(newvlansubnet.Text))
            {
                MessageBox.Show("Enter a Valid Subnet Mask!");
            }
            else
            {
                string message = "Create This VLAN Interface?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    runScript.runpy("createvlans.py", newvlanid.Text + " " + newvlanname.Text + " " + newvlanip.Text + " " + newvlansubnet.Text + " " + newaccessports.Text);
                    MessageBox.Show(runScript.name);

                    if (!runScript.name.Contains("Error"))
                    {
                        waitMessage.Wait(GetConfig);

                        checkvlans();
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

        private void removevlan_Click(object sender, EventArgs e)
        {
            if (selvlanid.SelectedIndex > -1)
            {
                if(vnamelabel.Text != "")
                {
                    var (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword) = ReadAuthFile.readfile();

                    if (deviceip == viplabel.Text.Trim())
                    {
                        MessageBox.Show("You are connected to the System through this VLAN Interface. Any changes to this would cause a disconnection!");
                    }
                    if (vnamelabel.Text.Contains("default"))
                    {
                        MessageBox.Show("Default VLANs Shouldn't be Removed!");
                    }
                    else
                    {
                        string message = "This Operation Cannot be Undone! Remove This VLAN?";
                        string title = "Proceed?";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.OK)
                        {
                            runScript.runpy("removevlans.py", selvlanid.Text + " " + vnamelabel.Text);
                            MessageBox.Show(runScript.name);
                            if (!runScript.name.Contains("Error"))
                            {
                                waitMessage.Wait(GetConfig);
                            
                                checkvlans();

                                translatevlan.Visible = false;

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
                    MessageBox.Show("You are about to Remove a VLAN! Click Get Details to View VLAN Details before Proceeding");
                }                            
            }
            else
            {
                MessageBox.Show("Select a VLAN!");
            }
        }

        private void VLANInterfacesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();

            selvlanid.SelectedIndex = -1;
            clear();
        }

        private void translatevlan_Click(object sender, EventArgs e)
        {
            if(viplabel.Text.Contains("Not Configured!"))
            {
                MessageBox.Show("VLAN Not Configured!");
            }
            else
            {
                string message = "Translate This VLAN to another Switch?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    File.WriteAllText(@"C:\NETAutoMate\VLAN_Temp.txt", selvlanid.Text + "\n" + vnamelabel.Text.Trim() + "\n" + viplabel.Text.Trim() + "\n" + vsubnetabel.Text.Trim());

                    this.Hide();
                    VLANTranslationWizard vLANTranslationWizard = new VLANTranslationWizard();
                    vLANTranslationWizard.ShowDialog();
                    //this.Close();
                }
                else
                {
                    //
                }
            }                                  
        }

        private void translatevlan_MouseHover(object sender, EventArgs e)
        {
            hints.Show("Click Here to Translate the Selected VLAN to another Switch in the Network", translatevlan);
        }

        private void VLANInterfacesPage_Load(object sender, EventArgs e)
        {
            checkvlans();
            checkaccessports();
        }
    }
}
