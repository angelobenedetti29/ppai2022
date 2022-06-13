using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Turno
    {
        public int DiaSemana { get; set; }
        public DateTime FechaGeneraccion { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        private CambioEstadoTurno CambioEstadoTurno { get; set; }

        public void cancelar()
        {

        }
        public bool esCancelable()
        {
            return true;

        }
        public void ObtenerCientificoResponsable()
        {

        }
        public void setEstado()
        {

        }

    }
}
