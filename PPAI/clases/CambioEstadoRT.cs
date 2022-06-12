using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class CambioEstadoRT
    {
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }
        public Estado Estado { get; set; }

        public bool esActual()
        {
            return true;
        }
        public bool esDispobible()
        {
            return true;
        }
        
    }
}
