using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telCom_2._1
{
   public partial class Worker1

    {
        public void add()
        {
            using (var ct = global.CreateContext())
            {
                ct.Worker1.Add(this);
                ct.SaveChanges();
            } 
        }
    }
}
