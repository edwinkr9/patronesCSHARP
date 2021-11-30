using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Bridge
{
    public class SamsungControlRemoto : AbstractControlRemoto
    {
        public SamsungControlRemoto(LEDTV ledTv) : base(ledTv)
        {
        }
        public override void Encender()
        {
            ledTv.Encender();
        }
        public override void Apagar()
        {
            ledTv.Apagar();
        }
        public override void EscogerCanal(int NumeroCanal)
        {
            ledTv.EscogerCanal(NumeroCanal);
        }

    }
}
