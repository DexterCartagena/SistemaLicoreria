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
    public partial class ConsuProveComp : Form
    {
        public ConsuProveComp()
        {
            InitializeComponent();
        }
        //Variables
        CN_COMPRAS_OR cncomrpasor = new CN_COMPRAS_OR();
        DataTable dt = new DataTable();
        private void ConsuProveComp_Load(object sender, EventArgs e)
        {
            dt = cncomrpasor.ListProveedor();
            dgvGrilla.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtBusqueda, epBusqueda, "Busqueda"))
            {
                int cod;
                string detalle;
                try
                {
                    cod = Convert.ToInt32(txtBusqueda.Text);
                }catch(Exception ex)
                {
                    cod = 1;
                }
                finally
                {
                    detalle = txtBusqueda.Text;
                }

                dt.Rows.Clear();
                dt = cncomrpasor.BuscarProveedor(cod, detalle);
                dgvGrilla.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
