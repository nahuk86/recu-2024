using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Model;
using BLL;
using DAL;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var bateria = new Bateria();
            var bateriaService = new BateriaService(bateria);
            var bitacoraService = new BitacoraService("bitacora.txt");

            bateria.EstadoCambiado += () =>
            {
                Console.WriteLine($"Conectado: {bateria.Conectado}");
                Console.WriteLine($"Carga: {bateria.Carga}%");
                Console.WriteLine($"Tiempo de Carga: {bateria.TiempoCarga} min");
                Console.WriteLine($"Tiempo de Uso: {bateria.TiempoUso} min");
                bitacoraService.EscribirBitacora(bateria);
            };

            while (true)
            {
                Console.WriteLine("Actualizar estado de la batería:");
                Console.Write("Conectado (true/false): ");
                bool conectado = bool.Parse(Console.ReadLine());
                Console.Write("Carga (%): ");
                int carga = int.Parse(Console.ReadLine());
                Console.Write("Tiempo de Carga (min): ");
                int tiempoCarga = int.Parse(Console.ReadLine());
                Console.Write("Tiempo de Uso (min): ");
                int tiempoUso = int.Parse(Console.ReadLine());

                bateriaService.ActualizarEstado(conectado, carga, tiempoCarga, tiempoUso);
            }

            // Evitar que la consola se cierre automáticamente
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}