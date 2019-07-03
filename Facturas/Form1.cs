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

        public delegate void AddBillLineEvent(string line);
        public event AddBillLineEvent addBillEvent;

        public Form1()
        {
            InitializeComponent();
            addBillEvent += AddLineHandler;
        }
      
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            addBillEvent(txtLineaFactura.Text);
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
