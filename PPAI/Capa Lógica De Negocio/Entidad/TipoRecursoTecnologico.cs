using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class TipoRecursoTecnologico
    {
        public string Descripcion { get; set; }
        public string Nombre { get; set; }

        public TipoRecursoTecnologico()
        {

        }
        public TipoRecursoTecnologico(string nombre, string desc)
        {
            this.Nombre = nombre;
            this.Descripcion = desc;
        }

        public static List<TipoRecursoTecnologico> listaTiposRecursos = new List<TipoRecursoTecnologico>()
        {
            new TipoRecursoTecnologico("Balanza de Precisión","Tipo de balanza"),
            new TipoRecursoTecnologico("Microscopio de medición","Tipo de microscopio"),
            new TipoRecursoTecnologico("Equipo de cómputo","Tipo de equipamiento"),
        };

    }
}
