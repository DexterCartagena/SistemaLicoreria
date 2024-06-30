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
    public partial class cuadro : Form
    {
        public cuadro()
        {
            InitializeComponent();
        }
        CN_PEDIDOS_LF cnpedidos = new CN_PEDIDOS_LF();
        DataTable dt = new DataTable(); 
        private void Cuadro_de_busqueda_Load(object sender, EventArgs e)
        {
            //cargar dats en la grilla
            dt = cnpedidos.ListProductos();
            dgv_grilla.DataSource = dt;

            dgv_grilla.Columns[0].Width = 30;
            dgv_grilla.Columns[1].Width = 120;
            dgv_grilla.Columns[2].Width = 40;
            dgv_grilla.Columns[3].Width = 60;

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
            dt = cnpedidos.BuscarProducto(cod, detalle);
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
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
               Close();
            }
        }
    }
}
