using patronesCSHARP.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP
{
    public class SamsungLedTv : LEDTV
    {
        public void Encender()
        {
            Console.WriteLine("Encendiendo : Samsung TV");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando : Samsung TV");
        }

        public void EscogerCanal(int NumeroCanal)
        {
            Console.WriteLine("Cambiando canal " + NumeroCanal + " en Samsung TV");
        }

    }
}
