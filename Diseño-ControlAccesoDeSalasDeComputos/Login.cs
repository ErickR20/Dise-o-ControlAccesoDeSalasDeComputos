using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Diseño_ControlAccesoDeSalasDeComputos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iniciar_sesion_Click(object sender, EventArgs e)
        {
            string UsuarioAdmin = "Administrador";
            string ContrasenaAdmin = "1234";
            bool usuario_autenticado = Usuario.Text == UsuarioAdmin;
            bool contrasena_correcta = ContrasenaAdmin == Contrasena.Text;
            if (usuario_autenticado && contrasena_correcta)
            {
                this.Close();

            }
        }
    }
}
