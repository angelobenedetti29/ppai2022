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
