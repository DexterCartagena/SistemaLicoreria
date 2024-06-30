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
    public partial class G_ConsuProducVenta : Form
    {
        public G_ConsuProducVenta()
        {
            InitializeComponent();
        }
        CN_VENTAS_GUS cnVentasGus = new CN_VENTAS_GUS();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt=cnVentasGus.ListProductos();
            dgv_Productos.DataSource = dt;

            dgv_Productos.Columns[0].Width = 35;
            dgv_Productos.Columns[1].Width = 120;
            dgv_Productos.Columns[2].Width = 50;
            dgv_Productos.Columns[3].Width = 50;
        }

       
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.SelectedRows.Count == 0)
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
            if(COMMON.C_METODO_COMUN_GUS.ErrorCasillaVacia(txtBuscar,erBuscar,"de Busqueda"))
            {
                int cod;
                try
                {
                    cod = Convert.ToInt32(txtBuscar.Text);
                }
                catch(Exception ex)
                {
                    cod = 0;
                }
                dt.Rows.Clear();
                dt = cnVentasGus.BusProducto(cod, txtBuscar.Text);
                dgv_Productos.DataSource = dt;
            }
        }
    }
}
