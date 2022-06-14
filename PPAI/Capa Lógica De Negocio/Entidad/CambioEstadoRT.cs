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
        
        public Estado Estado { get; set; }
        public DateTime? FechaHoraHasta { get; set; }

        public CambioEstadoRT(DateTime fechaHoraDesde, Estado estado, DateTime fechaHoraHasta)
        {
            this.FechaHoraDesde = fechaHoraDesde;
            this.FechaHoraHasta= fechaHoraHasta;
            this.Estado = estado;
        }
        public CambioEstadoRT(DateTime fechaHoraDesde, Estado estado)
        {
            this.FechaHoraDesde = fechaHoraDesde;
            this.Estado = estado;
        }

        public static List<CambioEstadoRT> listaCambioEstado = new List<CambioEstadoRT>()
        {
            new CambioEstadoRT(DateTime.Parse("10/06/2022"),Estado.listaEstados[0],DateTime.Parse("11/06/2022")),
            new CambioEstadoRT(DateTime.Parse("11/06/2022"),Estado.listaEstados[1],DateTime.Parse("12/06/2022")),
            new CambioEstadoRT(DateTime.Parse("13/06/2022"),Estado.listaEstados[2],DateTime.Parse("14/06/2022")),
            new CambioEstadoRT(DateTime.Parse("14/06/2022"),Estado.listaEstados[3],DateTime.Parse("15/06/2022")),
            new CambioEstadoRT(DateTime.Parse("15/06/2022"),Estado.listaEstados[4]),
            
        };
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
