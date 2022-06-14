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
        public Estado Estado { get; set; }

        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.FechaHoraHasta = fechaHoraHasta;
            this.Estado = estado;
            this.FechaHoraDesde = fechaHoraHasta;
        }

        public CambioEstadoTurno(DateTime fechaHoraDesde, Estado estado)
        {
            this.FechaHoraDesde = fechaHoraDesde;
            this.Estado = estado;
        }

        public CambioEstadoTurno()
        {

        }
        
        public static List<CambioEstadoTurno> listaCambiosEstadoTurno = new List<CambioEstadoTurno>()
        {
            new CambioEstadoTurno(DateTime.Now,Estado.listaEstados[2]),
            new CambioEstadoTurno(DateTime.Now,Estado.listaEstados[2]),
            new CambioEstadoTurno(DateTime.Now,Estado.listaEstados[2]),
        };


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
