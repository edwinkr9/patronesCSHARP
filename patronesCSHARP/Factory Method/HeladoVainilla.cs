using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Factory_Method
{
    public class HeladoVainilla : Helado
    {
        public HeladoVainilla(string origen)
        {
            _descripcion = "Vainilla";
            _origen = origen;
        }
    }
}
