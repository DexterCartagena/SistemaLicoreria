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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        CN_STOCK cnstock = new CN_STOCK();
        DataTable dt = new DataTable();
        private void Stock_Load(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgOr\LogoStock.png";

            dt = cnstock.ListStock();
            dgvGrilla.DataSource = dt;

            dgvGrilla.Columns[0].Width = 20;
            dgvGrilla.Columns[1].Width = 20;
            dgvGrilla.Columns[2].Width = 100;
            dgvGrilla.Columns[3].Width = 40;
            dgvGrilla.Columns[4].Width = 50;
        }

        private void iconButton1_Click(object sender, EventArgs e)
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
            dt = cnstock.BuscarStock(cod,detalle);
            dgvGrilla.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count > 0)
            {
                txtCod.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtCodProducto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtProdcuto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[2].Value.ToString();

                try { txtCantidad.Value = int.Parse(dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[3].Value.ToString()); }
                catch(Exception ex) { dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[3].Value = 0; txtCantidad.Value = 0; }

                try { txtCantidadMinima.Value = int.Parse(dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[4].Value.ToString()); }
                catch (Exception ex) { dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[4].Value = 0; txtCantidadMinima.Value = 0; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        protected void limpiar()
        {
            txtBuscar.Text = "";
            txtCantidad.Value = 0;
            txtCantidadMinima.Value = 0;
            txtCodProducto.Text = "";
            txtProdcuto.Text = "";
            txtCod.Text = "";

            dt.Rows.Clear();
            dt = cnstock.ListStock();
            dgvGrilla.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCod,epCod,"Codigo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVaciaNumerica(txtCantidad,epCant,"Cantidad") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVaciaNumerica(txtCantidadMinima,epCantMin,"Cantidad minima")
                )
            if(MessageBox.Show("Seguroq ue desea actualizar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cnstock.ActualizarStock(
                    Convert.ToInt32(txtCod.Text),
                    Convert.ToInt32(txtCantidad.Value),
                    Convert.ToInt32(txtCantidadMinima.Value)
                    ))
                    {
                        MessageBox.Show("Registro Actualizado");
                        limpiar();
                    }
            }
        }
    }
}
