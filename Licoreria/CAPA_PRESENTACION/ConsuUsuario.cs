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
    public partial class ConsuUsuario : Form
    {
        public ConsuUsuario()
        {
            InitializeComponent();
        }
        CN_USUARIO_OR cnusuarioor = new CN_USUARIO_OR();
        DataTable dt = new DataTable();
        private void ConsuUsuario_Load(object sender, EventArgs e)
        {
            dt = cnusuarioor.ListUsuario();
            dgv_grilla.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cod;
            string detalle;
            try
            {
                cod = int.Parse(txtBusqueda.Text);
            }catch(Exception ex)
            {
                cod = 0;
            }
            finally
            {
                detalle = txtBusqueda.Text;
            }
            dt.Rows.Clear();
            dt = cnusuarioor.BuscarUsuario(cod,detalle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_grilla.SelectedRows.Count == 0)
            {
                return ;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
