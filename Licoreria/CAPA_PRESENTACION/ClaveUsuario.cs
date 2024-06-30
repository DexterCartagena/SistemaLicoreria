using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class ClaveUsuario : Form
    {
        public ClaveUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtConfirmacion1,epPas1,"Password") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtconfirmacion2,epPas2,"Confirmacion")
                )
            {
                if (txtConfirmacion1.Text == txtconfirmacion2.Text)
                {
                    epPas2.Clear();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    epPas2.SetError(txtconfirmacion2, "Las claves no coinciden");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
