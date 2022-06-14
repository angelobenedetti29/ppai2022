using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class PersonalCientifico
    {
        public int Legajo { get; set; }
        public int NumeroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronicoInst { get; set; }
        public string CorreoElectronicoPer { get; set; }
        public string TelCelular { get; set; }
        public Usuario Usuario { get; set; }

        public PersonalCientifico(int legajo, int numeroDoc, string nombre, string apellido,
            string emailInstitucional, string emailPersonal, string telefono, Usuario usuario)
        {
            this.Legajo = legajo;
            this.NumeroDoc = numeroDoc;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CorreoElectronicoInst = emailInstitucional;
            this.CorreoElectronicoPer = emailPersonal;
            this.TelCelular = telefono;
            this.Usuario = usuario;
        }
        public PersonalCientifico()
        {

        }

        public static readonly IList<PersonalCientifico> listaPersonal = new List<PersonalCientifico>()
        {
            new PersonalCientifico(85526, 43811433, "María Sol", "Vega", "msvega@utn.com","sol.vega.01@gmail.com","3516970971", Usuario.listaUsuarios[0]),
            new PersonalCientifico(81699, 42987345, "Angelo", "Benedetti", "abenedetti@utn.com","angelo.benedetti2910@gmail.com","3513183592", Usuario.listaUsuarios[1]),
            new PersonalCientifico(65784, 40983234, "María Mickaela", "Crespo", "mcrespo@utn.com","mickaelacrespo@gmail.com","123456789", Usuario.listaUsuarios[2]),

        };
        public PersonalCientifico getPersonalCientificoLogeado (string nombre)
        {
            var pcEncontrado = new PersonalCientifico();
            foreach (var pc in listaPersonal)
            {
               if( pc.Usuario.Nombre == nombre)
                {
                    pcEncontrado = pc;
                    break;
                }
            }
            return pcEncontrado;
        }
        
    }
}
