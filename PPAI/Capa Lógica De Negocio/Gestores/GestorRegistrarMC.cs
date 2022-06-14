using PPAI.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.LogicaNegocio
{
    class GestorRegistrarMC
    {
        public DateTime IngresoFechaFin { get; set; }
        public string RazonMc { get; set; }
        public RecursoTecnologico RecursoTecnologio { get; set; }
        public Sesion Sesion { get; set; }
        public AsignacionResponsableTecnicoRT AsignacionResponsableTecnicoRT { get; set; }

        private RecursoTecnologico oRecursoTecnologico;
        private Sesion oSesion;
        private AsignacionResponsableTecnicoRT oAsignacionResponsableTecnicoRT;

        public GestorRegistrarMC()
        {
            oRecursoTecnologico = new RecursoTecnologico();
            oSesion = new Sesion();
            oAsignacionResponsableTecnicoRT = new AsignacionResponsableTecnicoRT();
        }
            public void agregarRTPorTipoRecurso()
        {

        }
        public void agregarTurnosPorPersonalCientifico()
        {

        }
        public void buscarDatos()
        {
            

        }
        public void buscarDatosTurnosCancelables()
        {

        }
        public void buscarReservaTurnos()
        {

        }
        public IList<AsignacionResponsableTecnicoRT> buscarRT(int legajo )
        {

            return oAsignacionResponsableTecnicoRT.esAsignacionDelUsario(legajo);
        }
        public void crearMantenimiento()
        {

        }
        public void enviarMail()
        {

        }
        public void finCu()
        {

        }
        public void nuevoIngresoMantenimientoCorrectivo()
        {

        }
        public PersonalCientifico obtenerUsuarioLogueado(string nombre)
        {
            var usario = oSesion.obtenerCientificoLogueado(nombre);
            return usario;

        }
        public void tomarConfirmacion()
        {

        }
        public void tomarIngresoFechaFin()
        {

        }
        public void tomarRazon()
        {

        }
        public void tomarSeleccionRT()
        {

        }
        public /*IList<RecursoTecnologico>*/void  obternerRT(List<RecursoTecnologico> rt )
        {
            

           
        }





    }
}
