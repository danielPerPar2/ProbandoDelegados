using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturasGridView
{
    public partial class LineaFactura : Form
    {
        private delegate void AddLineDelegate(Factura factura);
        private AddLineDelegate addLineEvent;
        private GlobalFacturas globalFacturas;
        

        public LineaFactura()
        {
            InitializeComponent();           
        }

        private void BtnAddLinea_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura()
            {
                Id = Convert.ToInt32(txtId.Text),
                Importe = Convert.ToInt32(txtImporte.Text),
                Descripcion = txtDetalle.Text
            };

            addLineEvent(factura);
        } 
        
        private void AddLineHandler(Factura factura)
        {
            var repo = globalFacturas.FacturaRepository;
            repo.AddFactura(factura);
            globalFacturas.RefreshGrid();
        }

        private void LineaFactura_Load(object sender, EventArgs e)
        {
            globalFacturas = new GlobalFacturas();
            globalFacturas.Show();
            addLineEvent += AddLineHandler;
        }
    }
}
