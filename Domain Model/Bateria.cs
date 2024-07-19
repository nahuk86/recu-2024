using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Model
{
    public class Bateria
    {
        private bool conectado;
        public bool Conectado
        {
            get => conectado;
            set
            {
                if (conectado != value)
                {
                    conectado = value;
                    Notificar();
                    CambiarEstado();
                }
            }
        }

        public int Carga { get; set; }
        public int TiempoCarga { get; set; }
        public int TiempoUso { get; set; }

        public event Action EstadoCambiado;

        private EstadoBateria estado;

        public Bateria()
        {
            estado = new BateriaDesconectada();
        }

        protected void Notificar()
        {
            EstadoCambiado?.Invoke();
        }

        public void CambiarEstado()
        {
            if (Conectado)
            {
                estado = new BateriaConectada();
            }
            else
            {
                estado = new BateriaDesconectada();
            }
        }

        public void EjecutarVideojuego()
        {
            estado.EjecutarVideojuego(this);
        }
    }
}
