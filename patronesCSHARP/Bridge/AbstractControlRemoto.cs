using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Bridge
{
    public abstract class AbstractControlRemoto
    {
        protected LEDTV ledTv;
        protected AbstractControlRemoto(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void EscogerCanal(int NumeroCanal);

    }
}
