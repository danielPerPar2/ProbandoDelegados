using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturasGridView
{
    public interface IRepository
    {
        void AddFactura(Factura factura);

        List<Factura> GetFacturas();
        
    }
}
