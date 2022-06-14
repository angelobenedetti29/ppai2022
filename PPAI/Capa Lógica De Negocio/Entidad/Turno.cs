using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Turno
    {
        public int DiaSemana { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        private CambioEstadoTurno CambioEstadoTurno { get; set; }

        public Turno(int diaSemana, DateTime fechaGeneracion, DateTime fechaHoraFin, DateTime fechaHoraInicio, CambioEstadoTurno cambioEstadoTurno)
        {
            this.DiaSemana = diaSemana;
            this.FechaGeneracion = fechaGeneracion;
            this.FechaHoraFin = fechaHoraFin;
            this.FechaHoraInicio = fechaHoraInicio;
            this.CambioEstadoTurno = cambioEstadoTurno;
        }
        public Turno()
        {

        }

        public static List<Turno> listaTurnos1 = new List<Turno>()
        {
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("15/06/2022"),DateTime.Parse("14/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[0]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("23/06/2022"),DateTime.Parse("22/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[1]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("30/06/2022"),DateTime.Parse("29/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[2]),
        };

        public static List<Turno> listaTurnos2 = new List<Turno>()
        {
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("15/06/2022"),DateTime.Parse("14/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[0]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("23/06/2022"),DateTime.Parse("22/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[1]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("30/06/2022"),DateTime.Parse("29/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[2]),
        };

        public static List<Turno> listaTurnos3 = new List<Turno>()
        {
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("15/06/2022"),DateTime.Parse("14/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[0]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("23/06/2022"),DateTime.Parse("22/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[1]),
            new Turno(4,DateTime.Parse("13/06/2022"),DateTime.Parse("30/06/2022"),DateTime.Parse("29/06/2022"),CambioEstadoTurno.listaCambiosEstadoTurno[2]),
        };



        public void cancelar()
        {

        }
        public bool esCancelable()
        {
            return true;

        }
        public void ObtenerCientificoResponsable()
        {

        }
        public void setEstado()
        {

        }

    }
}
