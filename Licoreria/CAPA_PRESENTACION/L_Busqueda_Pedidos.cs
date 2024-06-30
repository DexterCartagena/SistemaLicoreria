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
    public partial class L_Busqueda_Pedidos : Form
    {
        public L_Busqueda_Pedidos()
        {
            InitializeComponent();
        }
        CN_PEDIDOS_LF cnpedidos  = new CN_PEDIDOS_LF();
        DataTable dt = new DataTable();
        private void Busqueda_Pedidos_Load(object sender, EventArgs e)
        {
            //cargar dats en la grilla
            dt = cnpedidos.ListPedidos();
            dgv_Pedidos.DataSource = dt;

            dgv_Pedidos.Columns[0].Width = 30;
            dgv_Pedidos.Columns[1].Width = 30;
            dgv_Pedidos.Columns[2].Width = 80;
            dgv_Pedidos.Columns[3].Width = 30;
            dgv_Pedidos.Columns[4].Width = 80;
            dgv_Pedidos.Columns[5].Width = 180;
            dgv_Pedidos.Columns[6].Width = 80;
            dgv_Pedidos.Columns[7].Width = 80;
            dgv_Pedidos.Columns[8].Width = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_Pedidos.Rows.Count == 0)
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
            int cod;
            try
            {
                cod = Convert.ToInt32(txtBuscar.Text);

                dt.Rows.Clear();
                dt = cnpedidos.BuscarPedido(cod);
                dgv_Pedidos.DataSource = dt;
            }
            catch(Exception ex)
            {
                epBuscar.SetError(txtBuscar, "Cuadro de buscqueda de COD de pedido");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgv_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
