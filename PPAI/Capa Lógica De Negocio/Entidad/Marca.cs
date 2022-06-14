using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Marca
    {
        public string nombre { get; set; }

        public Marca()
        {

        }
        public Marca(string nombre)
        {
            this.nombre = nombre;
        }
        public static List<Marca> listaMarcas = new List<Marca>()
        {
            new Marca("Shidmazu"),
            new Marca("Nikon"),
            new Marca("NH")
        };

    }
}
