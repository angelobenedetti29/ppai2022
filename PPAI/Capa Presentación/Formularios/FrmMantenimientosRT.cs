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
    public partial class FrmMantenimientosRT : Form
    {
        public FrmMantenimientosRT()
        {
            InitializeComponent();
        }

        private void btnRegistrarIngresoRTMP_Click(object sender, EventArgs e)
        {
            FrmRegistrarMC interfazRegistrarMC = new FrmRegistrarMC();
            interfazRegistrarMC.ShowDialog();
        }

        private void FrmMantenimientosRT_Load(object sender, EventArgs e)
        {

        }
    }
}
