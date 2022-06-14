using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Estado
    {
        public string Nombre { get; set; } 
        public string Ambito { get; set; }
        public string Descripcion { get; set; }
        public bool EsCancelable { get; set; }
        public bool EsReservable { get; set; }


        public Estado()
        {

        }

        public Estado(string nombre, string ambito, string descripcion, bool esCancelable, bool esReservable)
        {
            this.Nombre = nombre;
            this.Ambito = ambito;
            this.Descripcion = descripcion;
            this.EsCancelable = esCancelable;
            this.EsReservable = esReservable;
        }

        public static List<Estado> listaEstados = new List<Estado>()
        {
            new Estado("Disponible","Recurso Tecnológico", "RT Disponible", true, true),
            new Estado("En Ingreso a Mantenimiento Correctivo","Recurso Tecnológico", "RT Ingresado para MC", false, false),
            new Estado("Confirmado","Turno", "Turno Confirmado", true, false),
            new Estado("Pendiente de Confirmación","Turno", "Turno Pendiende de Confirmación", true, true),
            new Estado("Cancelado por Mantenimiento Correctivo","Turno", "Turno Cancelado por Mantenimiento Correctivo", false, false),
        };


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
