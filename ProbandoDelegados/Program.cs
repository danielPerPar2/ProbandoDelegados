using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoDelegados
{
    class Program
    {
        public void Handler(string message)
        {
            Console.WriteLine("handler: {0}", message);
        }

        public static void StaticHandler(string message)
        {
            Console.WriteLine("static handler: {0}", message);
        }

        static void Main(string[] args)
        {
            PrintHelper helper = new PrintHelper();

             //subscripción al evento
             helper.beforePrintEvent += new Program().Handler;
             helper.beforePrintEvent += StaticHandler;  

            //acceso al delegado
            var del =  new PrintHelper.BeforePrint(new Program().Handler);
            del("delegado");

           helper.Print();

            Console.ReadKey();
        }
    }
}
