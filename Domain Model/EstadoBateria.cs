using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Model
{
    public abstract class EstadoBateria
    {
        public abstract void EjecutarVideojuego(Bateria bateria);
    }

    public class BateriaConectada : EstadoBateria
    {
        public override void EjecutarVideojuego(Bateria bateria)
        {
            Console.WriteLine("Ejecutando videojuego...");
        }
    }

    public class BateriaDesconectada : EstadoBateria
    {
        public override void EjecutarVideojuego(Bateria bateria)
        {
            Console.WriteLine("No se puede ejecutar el videojuego. La batería está desconectada.");
        }
    }
}