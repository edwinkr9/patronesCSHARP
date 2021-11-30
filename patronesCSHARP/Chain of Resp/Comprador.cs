using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Chain_of_Responsability
{
    public class Comprador : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe < 100)
            {
                Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                _siguiente.Procesar(c);
            }
        }
    }
}
