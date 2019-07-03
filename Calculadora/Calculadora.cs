using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public int Add(int input1, int input2)
        {
            Console.WriteLine(String.Format("Add({0},{1}) = {2}", input1, input2, input1 + input2));
            return input1 + input2;
        }
        public int Subs(int input1, int input2)
        {
            Console.WriteLine(String.Format("Subs({0},{1}) = {2}", input1, input2, input1 - input2));
            return input1 - input2;
        }
        public int Mult(int input1, int input2)
        {
            Console.WriteLine(String.Format("Mult({0},{1}) = {2}", input1, input2, input1 * input2));
            return input1 * input2;
        }
        public int Div(int input1, int input2)
        {
            Console.WriteLine(String.Format("Div({0},{1}) = {2}", input1, input2, input1 / input2));
            return input1 / input2;
        }
    }
}
