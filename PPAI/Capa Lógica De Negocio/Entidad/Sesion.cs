using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Sesion
    {
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }

        public Sesion(Usuario user, string desc, DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            this.Usuario = user;
            this.Descripcion = desc;
            this.FechaHoraInicio = fechaHoraInicio;
            this.FechaHoraFin = fechaHoraFin;

        }

        public Sesion()
        {

        }

        public Usuario obtenerCientificoLogueado()
        {
            var usuario = new Usuario();
            return usuario;
        }
    }
}
