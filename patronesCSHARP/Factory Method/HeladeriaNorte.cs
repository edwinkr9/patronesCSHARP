using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Factory_Method
{
    public class HeladeriaNorte : Heladeria
    {
        public override Helado CrearHelado(string tipo)
        {
            if (tipo == "Vainilla")
            {
                return new HeladoVainilla("Norte");
            }
            else if (tipo == "Chocolate")
            {
                return new HeladoChocolate("Norte");
            }
            else
            {
                return null;
            }
        }
    }
}
