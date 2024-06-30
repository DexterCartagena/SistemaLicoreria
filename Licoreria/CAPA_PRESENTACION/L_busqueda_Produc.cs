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
    public partial class L_busqueda_Produc : Form
    {
        public L_busqueda_Produc()
        {
            InitializeComponent();
        }
        CN_Productos_LF cnproductos = new CN_Productos_LF();
        DataTable dt = new DataTable();
        private void L_busqueda_Produc_Load(object sender, EventArgs e)
        {
            dt = cnproductos.ListProductos();
            dgv_grilla.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cod;
            string detalle;
            try
            {
                cod = Convert.ToInt32(txtBuscar.Text);
            }catch(Exception ex)
            {
                cod = 0;
            }
            finally
            {
                detalle = txtBuscar.Text;
            }
            dt.Rows.Clear();
            dt = cnproductos.BuscarProducto(cod, detalle);
            dgv_grilla.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_grilla.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
