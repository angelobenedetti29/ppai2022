using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class CambioEstadoTurno
    {
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }

        public bool esActual()
        {
            return true;
        }
        public bool esCancelable()
        {
            return true;
        }
    }
}
