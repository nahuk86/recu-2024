using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Model;


namespace BLL
{
    public class BateriaService
    {
        private readonly Bateria bateria;

        public BateriaService(Bateria bateria)
        {
            this.bateria = bateria;
            this.bateria.EstadoCambiado += OnEstadoCambiado;
        }

        private void OnEstadoCambiado()
        {
            // Lógica adicional si es necesaria cuando cambia el estado de la batería
        }

        public void ActualizarEstado(bool conectado, int carga, int tiempoCarga, int tiempoUso)
        {
            bateria.Conectado = conectado;
            bateria.Carga = carga;
            bateria.TiempoCarga = tiempoCarga;
            bateria.TiempoUso = tiempoUso;
        }
    }
}