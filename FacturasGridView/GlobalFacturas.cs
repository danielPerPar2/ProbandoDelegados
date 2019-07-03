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
    public partial class GlobalFacturas : Form
    {
        private FacturaRepository repo = new FacturaRepository();

        public FacturaRepository FacturaRepository { get { return repo; } }

        public GlobalFacturas()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("desc", "Descripción");
            foreach (var factura in FacturaRepository.GetFacturas())
            {              
                dataGridView1.Rows.Add(factura.Id, factura.Importe, factura.Descripcion);
            }
        }

        public void RefreshGrid()
        {
            Factura last = repo.GetFacturas().Last<Factura>();
            dataGridView1.Rows.Add(last.Id, last.Importe, last.Descripcion);
            dataGridView1.Update();            
        }
    }
}
