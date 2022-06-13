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

        public Usuario(string nombre, string password, string desc)
        {
            this.Nombre = nombre;
            this.Contraseña = password;
            this.Descripcion = desc;
        }
        public Usuario()
        {

        }

        public static readonly List<Usuario> listaUsuarios = new List<Usuario>()
        {
            new Usuario("msvega", "123456", "Científica"),
            new Usuario("abenedetti", "123456", "Científico"),
            new Usuario("mcrespo", "123456", "Científica")
        };

        public PersonalCientifico obtenerCientifico()
        {
            var personalCientifico = new PersonalCientifico();
            return personalCientifico;
        }
    }
}
