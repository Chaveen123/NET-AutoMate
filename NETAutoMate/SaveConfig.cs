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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NETAutoMate
{
    public partial class SaveConfig : Form
    {           
        public SaveConfig()
        {
            InitializeComponent();
            waitMessage.Wait(LoadConfig);
            configdiff.Text = runScript.name;
        }
        void LoadConfig()
        {         
            runScript.runpy("saveconfig.py", "");       
        }
        void RollbackConfig()
        {
            runScript.runpy("saveconfig.py", "rollback");
        }
        void CommitConfig()
        {
            runScript.runpy("saveconfig.py", "commit");
        }
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

        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();
             
        private void commit_Click(object sender, EventArgs e)
        {
            string error = "Error:";
            string check = "No Configuration Changes!";

            if (!configdiff.Text.Contains(check))
            {
                string message = "Current Configuration will be saved to the Start-up Configuration. Commit?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    waitMessage.Wait(CommitConfig);

                    if (!runScript.name.Contains(error))
                    {
                        MessageBox.Show(runScript.name);

                        configdiff.Clear();

                        waitMessage.Wait(LoadConfig);
                        configdiff.Text = runScript.name;

                        waitMessage.Wait(GetConfig);
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
                MessageBox.Show("No new Configurations Performed!");
            }
        }

        private void rollback_Click(object sender, EventArgs e)
        {
            string error = "Error:";
            string check = "No Configuration Changes!";

            if (!configdiff.Text.Contains(check))
            {
                string message = "Current Configuration Changes will be reverted back to the Default Configuration. Rollback?";
                string title = "Proceed?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    waitMessage.Wait(RollbackConfig);
                    
                    if (!runScript.name.Contains(error))
                    {
                        MessageBox.Show(runScript.name);

                        configdiff.Clear();

                        waitMessage.Wait(LoadConfig);
                        configdiff.Text = runScript.name;

                        waitMessage.Wait(GetConfig);
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
                MessageBox.Show("No new Configurations Performed!");
            }                     
        }

        private void SaveConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();
        }
    }
}
