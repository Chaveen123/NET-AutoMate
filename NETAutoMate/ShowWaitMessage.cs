using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutoMate
{
    internal class ShowWaitMessage
    {
        public void Wait(Action action)
        {
            WaitMessage waitMessage = new WaitMessage(action);          
            waitMessage.ShowDialog();           
        }
    }
}
