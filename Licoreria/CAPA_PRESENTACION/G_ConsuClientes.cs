using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_DATOS;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class G_ConsuClientes : Form
    {
        public G_ConsuClientes()
        {
            InitializeComponent();
        }
        CN_VENTAS_GUS cnVentasGus = new CN_VENTAS_GUS();
        DataTable dt = new DataTable();

        private void ConsuClientes_Load(object sender, EventArgs e)
        {
            dt = cnVentasGus.ListClientes();
            dgv_Clientes.DataSource = dt;
            dgv_Clientes.Columns[0].Width = 40;
            dgv_Clientes.Columns[1].Width = 120;
            dgv_Clientes.Columns[2].Width = 80;
        }

        
        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (dgv_Clientes.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_GUS.ErrorCasillaVacia(txtClient, erBusqueda, "Buscar"))
            {

                int cod;
                try
                {
                    cod = Convert.ToInt32(txtClient.Text);
                }
                catch (Exception ex)
                {
                    cod = 0;

                }
                dt.Rows.Clear();
                dt = cnVentasGus.BusCliente(cod, txtClient.Text);
                dgv_Clientes.DataSource = dt;

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
