using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturasGridView
{
    public class FacturaRepository : IRepository
    {
        private List<Factura> facturas;

        public  FacturaRepository()
        {
            InitializeList();
        }

        public  void AddFactura(Factura factura)
        {
            facturas.Add(factura);
        }

        public  List<Factura> GetFacturas()
        {
            return facturas;
        }

        private void InitializeList()
        {
            facturas = new List<Factura>()
            {
                new Factura()
                {
                    Id = 0,
                    Importe = 10,
                    Descripcion = "golosina"
                },
                new Factura()
                {
                    Id = 1,
                    Importe = 5,
                    Descripcion = "patata"
                },
                new Factura()
                {
                    Id = 2,
                    Importe = 2,
                    Descripcion = "pipa"
                }
            };
        }
    }
}
