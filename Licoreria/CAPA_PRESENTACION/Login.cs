using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        CN_USUARIO_OR cnusuarioor = new CN_USUARIO_OR();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtUsuario, errorP_Validacion, "Usuario") & COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtClave, errorP_Validacion, "Contraseña"))
            {//Validacion casillas vacias
                if (cnusuarioor.LoginUsuario(txtUsuario.Text, txtClave.Text))
                {
                    DialogResult = DialogResult.OK;
                    errorP_Validacion.Clear();
                    A_Principal PP = new A_Principal();
                    PP.Show();
                    this.Hide();
                }
                else
                {
                    errorP_Validacion.SetError(txtUsuario, "El usuario o contraseña son incorrectos");
                    errorP_Validacion.SetError(txtClave, "El usuario o contraseña son incorrectos");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
