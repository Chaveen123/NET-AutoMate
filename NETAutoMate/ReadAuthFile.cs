using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutoMate
{
    internal class ReadAuthFile
    {
        public static (string, string, string, string ,string, string) readfile()
        {
            StreamReader streamReader = new StreamReader(@"C:\NETAutoMate\DeviceAuth.csv");
            string readfile;

            readfile = streamReader.ReadLine();
            string[] strings = readfile.Split(',');
            string devicevendor = strings[0];
            string devicemodel = strings[1];
            string devicetype = strings[2];
            string deviceip = strings[4];
            string deviceusername = strings[5];
            string devicepassword = strings[6];
            streamReader.Close();

            return (devicevendor, devicemodel, devicetype, deviceip, deviceusername, devicepassword);
        }
    }
}
