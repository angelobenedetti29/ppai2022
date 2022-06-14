using PPAI.clases;
using PPAI.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Formularios
{
    public partial class FrmRegistrarMC : Form
    {
        public FrmRegistrarMC()
        {
            InitializeComponent();
        }

        private void FrmRegistrarMC_Load(object sender, EventArgs e)
        {
            var oGestorRegistrarMC = new GestorRegistrarMC();
            var prueba = oGestorRegistrarMC.obtenerUsuarioLogueado("abenedetti");
            var asignacionesVigentes = oGestorRegistrarMC.buscarRT(prueba.Legajo);
            //oGestorRegistrarMC.obternerRT(asigancionesVigentes);
        }
    }
}
