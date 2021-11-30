using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Command
{
    public class BajaStock : OrdenCommand
    {
        public BajaStock(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {

        }
        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
