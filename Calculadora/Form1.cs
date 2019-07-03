using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {  
        public delegate int Operation(int a, int b);
        Operation add = null;
        Operation sub = null;
        Operation mul = null;
        Operation div = null;
        Operation addLambda = null;
        Operation sumaDelegados = null;

      
        public Calculadora calculadora = null;

        public Form1()
        {
            InitializeComponent();
            calculadora = new Calculadora();
            add += calculadora.Add;
            sub += calculadora.Subs;
            mul += calculadora.Mult;
            div += calculadora.Div;
            addLambda += (x, y) => (x + y);

            sumaDelegados = add + sub + mul + div + addLambda;
        }   
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int addResult = add(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));
            int subResult = sub(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));
            int mulResult = mul(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));
            int divResult = div(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));
            int addLambdaResult = addLambda(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));

            string message = "suma=" + addResult + "\n" +
                                "resta=" + subResult + "\n" +
                                "multip=" + mulResult + "\n" +
                                "div=" + divResult + "\n" +
                                "addLambda=" + addLambdaResult + "\n";

            
                                
            MessageBox.Show(message);
        }

        private void BtnMultiCalcular_Click(object sender, EventArgs e)
        {
            sumaDelegados(Convert.ToInt32(txtInput1.Text), Convert.ToInt32(txtInput2.Text));
        }
    }
}
