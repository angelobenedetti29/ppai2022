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
        public int TelCelular { get; set; }
        public Usuario Usuario { get; set; }

        public PersonalCientifico(int legajo, int numeroDoc, string nombre, string apellido,
            string emailInstitucional, string emailPersonal, int telefono, Usuario usuario)
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

        public static readonly List<PersonalCientifico> listaPersonal = new List<PersonalCientifico>()
        {
            new PersonalCientifico(85526, 43811433, "María Sol", "Vega", "msvega@utn.com","sol.vega.01@gmail.com",int.Parse("3516970971"), Usuario.listaUsuarios[0]),
            new PersonalCientifico(81699, 42987345, "Angelo", "Benedetti", "abenedetti@utn.com","angelo.benedetti2910@gmail.com",int.Parse("3513183592"), Usuario.listaUsuarios[1]),
            new PersonalCientifico(65784, 40983234, "María Mickaela", "Crespo", "mcrespo@utn.com","mickaelacrespo@gmail.com",int.Parse("123456789"), Usuario.listaUsuarios[2]),

        };
    }
}
