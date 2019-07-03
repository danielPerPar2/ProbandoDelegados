using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    class AddBillLine
    {
        public delegate void AddBillLineEvent(string line);
        public event AddBillLineEvent addBillEvent;
      
        public void LaunchAddBillLineEvent(string line)
        {
            addBillEvent(line);
        }

    }
}
