using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Factory_Method
{
    public abstract class Helado
    {
        protected string _descripcion;
        protected string _origen;

        public void Render()
        {
            Console.WriteLine(string.Format("Helado de {0} hecha en {1}", _descripcion, _origen));
        }
    }
}
