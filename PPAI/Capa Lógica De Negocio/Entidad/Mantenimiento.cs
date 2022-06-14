using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.clases
{
    class Mantenimiento
    {
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaInicioPrevista { get; set; }
        public string MotivoMantenimiento { get; set; }

        public Mantenimiento()
        {

        }

        public Mantenimiento(DateTime fechaFin, DateTime fechaInicio, DateTime fechaInicioPrevista, string motivo)
        {
            this.FechaFin = fechaFin;
            this.FechaInicio = fechaInicio;
            this.FechaInicioPrevista = fechaInicioPrevista;
            this.MotivoMantenimiento = motivo;

        }
    }

}
