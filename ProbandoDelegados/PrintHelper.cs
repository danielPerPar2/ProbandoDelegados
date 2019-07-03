using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoDelegados
{
    public class PrintHelper
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;

        public void Print()
        {
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke("Mensaje del delegado");
        }
    }
}
