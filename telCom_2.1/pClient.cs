using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace telCom_2._1
{
   
    
    public partial class Client1 : IUser
    {
        public bool IsClient { get { return false; } }
        public bool IsWorker { get { return true; } }
    }
}
