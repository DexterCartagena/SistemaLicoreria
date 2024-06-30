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
    public partial class ConsuRegistros : Form
    {
        public ConsuRegistros()
        {
            InitializeComponent();
        }
        //Variables
        CN_COMPRAS_OR cncomprasor = new CN_COMPRAS_OR();
        DataTable dtCompras = new DataTable();
        DataTable dtDetalleCompra = new DataTable();
        private void ConsuRegistros_Load(object sender, EventArgs e)
        {
            dtCompras = cncomprasor.ListCompra();
            dgvCompra.DataSource = dtCompras;

            dgvCompra.Columns[0].Width = 50;
            dgvCompra.Columns[1].Width = 80;
            dgvCompra.Columns[2].Width = 120;
            dgvCompra.Columns[3].Width = 120;
            dgvCompra.Columns[4].Width = 50;
            dgvCompra.Columns[5].Width = 50;
        }

        private void dgvCompra_Click(object sender, EventArgs e)
        {
            dtDetalleCompra = cncomprasor.ListDetalleComrpaFiltrado(Convert.ToInt32(dgvCompra.Rows[dgvCompra.CurrentRow.Index].Cells[0].Value.ToString()));
            dgvDetalleCompra.DataSource = dtDetalleCompra;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
