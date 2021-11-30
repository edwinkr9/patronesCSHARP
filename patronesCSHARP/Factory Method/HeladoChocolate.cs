using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Factory_Method
{
    public class HeladoChocolate : Helado
    {
        public HeladoChocolate(string origen)
        {
            _descripcion = "Chocolate";
            _origen = origen;
        }
    }
}
