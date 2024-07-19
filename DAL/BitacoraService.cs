using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Model;
using System.IO;    

namespace DAL
{
    public class BitacoraService
    {
        private readonly string filePath;

        public BitacoraService(string filePath)
        {
            this.filePath = filePath;
        }

        public void EscribirBitacora(Bateria bateria)
        {
            var log = $"Conectado: {bateria.Conectado}, Carga: {bateria.Carga}%, Tiempo de Carga: {bateria.TiempoCarga} min, Tiempo de Uso: {bateria.TiempoUso} min";
            File.AppendAllText(filePath, $"{DateTime.Now}: {log}{Environment.NewLine}");
        }
    }
}