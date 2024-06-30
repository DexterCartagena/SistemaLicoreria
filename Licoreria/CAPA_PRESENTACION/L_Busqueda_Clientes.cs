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
    public partial class L_Busqueda_Clientes : Form
    {
        public L_Busqueda_Clientes()
        {
            InitializeComponent();
        }
        CN_PEDIDOS_LF cnclientes = new CN_PEDIDOS_LF();
        DataTable dt = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_Clientes.Rows.Count == 0) 
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Busqueda_Clientes_Load(object sender, EventArgs e)
        {
            //cargar dats en la grilla
            dt = cnclientes.ListClientes();
            dgv_Clientes.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
