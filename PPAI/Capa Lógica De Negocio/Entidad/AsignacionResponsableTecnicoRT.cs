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
        public RecursoTecnologico RecursoTecnologico { get; set; }
        public PersonalCientifico PersonalCientifico { get; set; }

        public AsignacionResponsableTecnicoRT()
        {

        }

        public AsignacionResponsableTecnicoRT(DateTime fechaDesde, DateTime fechaHasta, RecursoTecnologico rt, PersonalCientifico pc)
        {
            this.FechaDesde = fechaDesde;
            this.FechaHasta = fechaHasta;
            this.RecursoTecnologico = rt;
            this.PersonalCientifico = pc;
        }


        public static readonly List<AsignacionResponsableTecnicoRT> listaAsignaciones = new List<AsignacionResponsableTecnicoRT>()
        {
            new AsignacionResponsableTecnicoRT(DateTime.Parse("13/06/2022"),DateTime.Parse("16/06/2022"),RecursoTecnologico.listaRecursos[0],PersonalCientifico.listaPersonal[0]),
            new AsignacionResponsableTecnicoRT(DateTime.Parse("13/06/2022"),DateTime.Parse("16/06/2022"),RecursoTecnologico.listaRecursos[1],PersonalCientifico.listaPersonal[0]),
            new AsignacionResponsableTecnicoRT(DateTime.Parse("13/06/2022"),DateTime.Parse("16/06/2022"),RecursoTecnologico.listaRecursos[2],PersonalCientifico.listaPersonal[0])
        };


        public bool esAsignacionDelUsario()
        {
            return true;
        }
        public bool esVigente()
        {
            return true;
        }
        public RecursoTecnologico obtenerRecursoRT()
        {
            var rt = new RecursoTecnologico();
            return rt;
        }
    }
}
