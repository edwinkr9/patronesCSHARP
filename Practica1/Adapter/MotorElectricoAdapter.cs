using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new MotorElectrico();

        public override void Acelerar()
        {
            motorElectrico.Mover();
        }
        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }
        public override void CargarCombustible()
        {
            motorElectrico.Enchufar();
        }
        public override void Detener()
        {
            motorElectrico.Desactivar();
            motorElectrico.Parar();
        }
    }
}
