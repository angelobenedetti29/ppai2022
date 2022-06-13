using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.clases;

namespace PPAI.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                msgError("Por favor ingrese el nombre de usuario.");
                txtUsuario.Focus();
            }
            else if (txtPassword.Text.Equals(""))
            {
                msgError("Por favor ingrese la contraseña.");
                txtPassword.Focus();
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text.Trim();
                string password = txtPassword.Text.Trim();
                bool resultado = false;

                //resultado = ValidarUsuario(nombreDeUsuario, password);
                //if (resultado)
                //{
                //    Usuarios usu = new Usuarios(nombreDeUsuario, password);
                //    FrmMenuPrincipal ventana = new FrmMenuPrincipal(usu);
                //    ventana.Show();
                //    ventana.FormClosed += LogOut;
                //    Hide();
                //}
                //else
                //{
                //    msgError("Nombre de usuario o contraseña incorrectos, intente nuevamente.");
                //    txtUsuario.Clear();
                //    txtPassword.Clear();
                //    txtUsuario.Focus();
                //}
            }
        }

        private void ValidarUsuario(string nombreDeUsuario, string password)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "      " +msg;
            lblErrorMessage.Visible = true;
        }
        private void LogOut (object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtUsuario.Clear();
            lblErrorMessage.Visible=false;
            this.Show();
            txtUsuario.Focus();
        }
    }
}
