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
    public partial class GetConfig : Form
    {
        public GetConfig()
        {
            InitializeComponent();    
        }

        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();

        void GetRunConfig()
        {
            runScript.runpy("getconfig.py", "running");
        }

        void GetStartConfig()
        {
            runScript.runpy("getconfig.py", "startup");
        }

        private void runconfig_Click(object sender, EventArgs e)
        {
            runningconfig.Clear();

            waitMessage.Wait(GetRunConfig);
            runningconfig.Text = runScript.name;
        }

        private void startconfig_Click(object sender, EventArgs e)
        {
            startupconfig.Clear();

            waitMessage.Wait(GetStartConfig);

            if(string.IsNullOrEmpty(runScript.name.Trim()))
            {
                startupconfig.Text = "Configurations are Commited By Default on Juniper Devices! Running Configuration is the Startup Configuration.";
            }
            else
            {
                startupconfig.Text = runScript.name;
            }           
        }

        private void GetConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();

            runningconfig.Clear();
            startupconfig.Clear();
        }
    }
}
