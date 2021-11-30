using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Bridge
{
    public interface LEDTV
    {
        void Encender();
        void Apagar();
        void EscogerCanal(int NumeroCanal);
    }
}
