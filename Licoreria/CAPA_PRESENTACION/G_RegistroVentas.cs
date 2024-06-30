
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class G_RegistroVentas : Form
    {
        public G_RegistroVentas()
        {
            InitializeComponent();
        }

        CN_VENTAS_GUS cnVentasGus = new CN_VENTAS_GUS();
        DataTable dt = new DataTable();

        DataTable dtdetalle = new DataTable();

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            dt = cnVentasGus.VistVentas();
            dgvVenta.DataSource = dt;

            dgvVenta.Columns[0].Width = 50;
            dgvVenta.Columns[1].Width = 70;
            dgvVenta.Columns[2].Width = 50;
            dgvVenta.Columns[3].Width = 110;
            dgvVenta.Columns[4].Width = 50;
            dgvVenta.Columns[5].Width = 110;
            dgvVenta.Columns[6].Width = 50;
            dgvVenta.Columns[7].Width = 50;
            dgvVenta.Columns[8].Width = 80;
        }

        private void dgvVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                dtdetalle = cnVentasGus.ListDetalleVenta(Convert.ToInt32(dgvVenta.Rows[dgvVenta.CurrentRow.Index].Cells[0].Value.ToString()));
                dgvDetalle.DataSource = dtdetalle;

                dgvDetalle.Columns[0].Width = 50;
                dgvDetalle.Columns[1].Width = 50;
                dgvDetalle.Columns[2].Width = 50;
                dgvDetalle.Columns[3].Width = 110;
                dgvDetalle.Columns[4].Width = 50;
                dgvDetalle.Columns[5].Width = 80;
                dgvDetalle.Columns[6].Width = 90;
            }
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelec_Click(object sender, EventArgs e)
        {

        }
    }
}
