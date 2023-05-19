using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NETAutoMate
{
    public partial class PortScanner: Form
    {
        public PortScanner()
        {
            InitializeComponent();
        }

        ShowWaitMessage waitMessage = new ShowWaitMessage();
        RunScript runScript = new RunScript();

        void PortScan()
        {
            runScript.runpy("portscan.py", ipaddress.Text + " " + startport.Text + " " + endport.Text);
        }

        private void scan_Click(object sender, EventArgs e)
        {
            int Number;
            bool isNumber;
            isNumber = Int32.TryParse(startport.Text, out Number) && Int32.TryParse(endport.Text, out Number);
            if (ipaddress.Text == "" || startport.Text == "")
            {
                MessageBox.Show("Incomplete. Please fill all fields!");
            }
            else if (!isNumber)
            {
                MessageBox.Show("Enter a Valid Port Number Range");
            }
            else if (!(new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")).IsMatch(ipaddress.Text))
            {
                MessageBox.Show("Enter a Valid IP Address");
            }
            else
            {
                Ping ping = new Ping();
                IPAddress address = IPAddress.Parse(ipaddress.Text);
                PingReply pingReply = ping.Send(address);

                if (pingReply.Status == IPStatus.Success)
                {
                    results.Clear();

                    waitMessage.Wait(PortScan);
                    results.Text = runScript.name;
                }
                else
                {
                    MessageBox.Show("Entered IP Address is NOT Available in the Network. Re-Check IP Address!");
                }             
            }           
        }

        private void PortScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.SelectionPage.Show();
        }
    }
}
