using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class RecursoTecnologico
    {
        public int DuracionMantenimientoPrev { get; set; }
        public DateTime FechaAlta { get; set; }
        public int FraccionHorarioTurnos { get; set; }
        public int NumeroRT { get; set; }
        public int PeriodicidadMantenimientoPrev {get;set;}
        public Turno Turno { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
        public TipoRecursoTecnologico TipoRecursoTecnologico { get; set; }
        public Modelo Modelo { get; set; }
        public CambioEstadoRT CambioEstadoRT { get; set; }

        public void cancelarTurnos()
        {

        }

        public void crarMantenimiento()
        {

        }
        public bool esRecursoDisponible()
        {
            return true;
        }
        public void obtenerDatosTurnosCancelables() { 
        }
        public void obtenerRecursosTurno()
        {

        }
    }
}
