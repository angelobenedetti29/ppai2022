using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Descripcion { get; set; }

        public PersonalCientifico obtenerCientifico()
        {
            var personalCientifico = new PersonalCientifico();
            return personalCientifico;
        }
    }
}
