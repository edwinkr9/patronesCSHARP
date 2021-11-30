using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Factory_Method
{
    public abstract class Heladeria
    {
        public abstract Helado CrearHelado(string tipo);
    }
}
