using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Command
{
    public class AltaStock : OrdenCommand
    {
        public AltaStock(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {

        }
        public override void Ejecutar()
        {
            _producto.SumarStock(_cantidad);
        }
    }
}
