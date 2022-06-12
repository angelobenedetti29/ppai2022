using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Estado
    {
        public string Ambito { get; set; }
        public string Descripcion { get; set; }
        public bool EsCancelable { get; set; }
        public bool EsReservable { get; set; }
        public string nombre { get; set; }

        public bool esAmbitoRecursoTecnologico()
        {
            return true;
        }
        public bool esAmbitoTurno()
        {
            return true;
        }
        public bool esCancelablePorMantenimientoCorrectivo()
        {
            return true;
        }
        public bool esDisponible()
        {
            return true;
        }
        public bool esEnIngresoAMantenimientoCorrectivo()
        {
            return true;
        }





    }
}
