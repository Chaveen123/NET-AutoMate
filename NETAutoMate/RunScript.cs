using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutoMate
{
    internal class RunScript
    {
        string output;
        public void runpy(string file,string args)
        {
            string location = @"assets\python\";           
            
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"python.exe";
            processStartInfo.Arguments = (location+file+" "+args);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

        }
        public string name
        {
            get { return output;}
        }
    }
}
