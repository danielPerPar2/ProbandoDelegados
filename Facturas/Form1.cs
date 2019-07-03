using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class Form1 : Form
    {
        private List<string> lineasFactura = new List<string>();
        private AddBillLine addBillLine = new AddBillLine();
        public Form1()
        {
            InitializeComponent();
            addBillLine.addBillEvent += AddLineHandler;
        }
      
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            addBillLine.LaunchAddBillLineEvent(txtLineaFactura.Text);
        }

        private void AddLineHandler(string line)
        {
            lineasFactura.Clear();
            lineasFactura.Add(line);
            foreach (var item in lineasFactura)
            {
                listViewFacturas.Items.Add(item);
            }
        }
    }
}
