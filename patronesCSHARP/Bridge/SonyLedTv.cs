using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesCSHARP.Bridge
{
    public class SonyLedTv : LEDTV
    {
        public void Encender()
        {
            Console.WriteLine("Encendiendo : Sony TV");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando : Sony TV");
        }

        public void EscogerCanal(int NumeroCanal)
        {
            Console.WriteLine("Cambiando canal " + NumeroCanal + " en Sony TV");
        }
    }
}
