using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class AsignacionResponsableTecnicoRT
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public IList<RecursoTecnologico> RecursoTecnologicos { get; set; }
        public PersonalCientifico PersonalCientifico { get; set; }


        public AsignacionResponsableTecnicoRT()
        {

        }

        public AsignacionResponsableTecnicoRT(DateTime fechaDesde, DateTime fechaHasta, IList<RecursoTecnologico> rt, PersonalCientifico pc)
        {
            this.FechaDesde = fechaDesde;
            this.FechaHasta = fechaHasta;
            this.RecursoTecnologicos = rt;
            this.PersonalCientifico = pc;
        }


        public static readonly List<AsignacionResponsableTecnicoRT> listaAsignaciones = new List<AsignacionResponsableTecnicoRT>()
        {
            
            new AsignacionResponsableTecnicoRT(DateTime.Parse("13/06/2022"),DateTime.Parse("30/06/2022"),RecursoTecnologico.listaRecursos,PersonalCientifico.listaPersonal[0]),
            new AsignacionResponsableTecnicoRT(DateTime.Parse("13/06/2022"),DateTime.Parse("16/06/2022"),RecursoTecnologico.listaRecursos,PersonalCientifico.listaPersonal[1]),
            new AsignacionResponsableTecnicoRT(DateTime.Parse("11/06/2022"),DateTime.Parse("13/06/2022"),RecursoTecnologico.listaRecursos,PersonalCientifico.listaPersonal[2])
        };


        public IList<AsignacionResponsableTecnicoRT> esAsignacionDelUsario(int legajo)
        {
            
            var asignacionesVigentes = new List<AsignacionResponsableTecnicoRT>();
            foreach (var asignacion in listaAsignaciones)
            {
                if (asignacion.PersonalCientifico.Legajo == legajo)
                {
                    if (asignacion.esVigente(asignacion.FechaDesde,asignacion.FechaHasta))
                    {
                        asignacionesVigentes.Add(asignacion);
                    }
                }    
            }
            
            return asignacionesVigentes;
        }
        public bool esVigente(DateTime fechaDesde , DateTime fechaHasta )
        {
            var fechaActual = DateTime.Today;
            var resultado = false;
            if (fechaDesde < fechaActual && fechaActual < fechaHasta)
            {
                resultado = true;
            }
            return resultado;
        }

        public /*IList<RecursoTecnologico>*/void  obtenerRT(AsignacionResponsableTecnicoRT asignacionesVigentes )
        {
                foreach (var recurso in asignacionesVigentes.RecursoTecnologicos)
                {
                    if (recurso.esRecursoDisponible())
                    {
                    
                    }
                }

            
            
        }
    }
}
