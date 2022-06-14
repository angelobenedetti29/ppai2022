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
        public List<Turno> Turnos { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
        public TipoRecursoTecnologico TipoRecursoTecnologico { get; set; }
        public Modelo Modelo { get; set; }
        public CambioEstadoRT CambioEstadoRT { get; set; }

        public RecursoTecnologico()
        {

        }

        public RecursoTecnologico(int duracion, DateTime fechaAlta, int fraccion, int numeroRT, int periodicidad, List<Turno> turno, Mantenimiento mant,
            TipoRecursoTecnologico tipo, Modelo modelo, CambioEstadoRT cambioEstadoRT)
        {
            this.DuracionMantenimientoPrev = duracion;
            this.FechaAlta = fechaAlta;
            this.FraccionHorarioTurnos = fraccion;
            this.NumeroRT = numeroRT;
            this.PeriodicidadMantenimientoPrev = periodicidad;
            this.Turnos = turno;
            this.Mantenimiento = mant;
            this.TipoRecursoTecnologico = tipo;
            this.Modelo = modelo;
            this.CambioEstadoRT = cambioEstadoRT;
        }
        public RecursoTecnologico(int duracion, DateTime fechaAlta, int fraccion, int numeroRT, int periodicidad, List<Turno> turno,
    TipoRecursoTecnologico tipo, Modelo modelo, CambioEstadoRT cambioEstadoRT)
        {
            this.DuracionMantenimientoPrev = duracion;
            this.FechaAlta = fechaAlta;
            this.FraccionHorarioTurnos = fraccion;
            this.NumeroRT = numeroRT;
            this.PeriodicidadMantenimientoPrev = periodicidad;
            this.Turnos = turno;
            this.TipoRecursoTecnologico = tipo;
            this.Modelo = modelo;
            this.CambioEstadoRT = cambioEstadoRT;
        }


        public static List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>()
        {
            new RecursoTecnologico(20,DateTime.Now,3,1,10,Turno.listaTurnos1,TipoRecursoTecnologico.listaTiposRecursos[2],new Modelo(), CambioEstadoRT.listaCambioEstado[0]),
            new RecursoTecnologico(10,DateTime.Now,5,2,10,Turno.listaTurnos2,TipoRecursoTecnologico.listaTiposRecursos[1],new Modelo(), CambioEstadoRT.listaCambioEstado[1]),
            new RecursoTecnologico(15,DateTime.Now,2,3,10,Turno.listaTurnos3,TipoRecursoTecnologico.listaTiposRecursos[0],new Modelo(), CambioEstadoRT.listaCambioEstado[4]),
        };

        public void cancelarTurnos()
        {

        }

        public void crearMantenimiento()
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
