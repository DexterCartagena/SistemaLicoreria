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
    public partial class G_Proveedor : Form
    {
        public G_Proveedor()
        {
            InitializeComponent();
        }
        CN_PROVEEDOR_GUS cnProveedorGus = new CN_PROVEEDOR_GUS();
        DataTable dt = new DataTable();

        private void Proveedor_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = false;
            dt = cnProveedorGus.ListaProveedores();
            dgv_Prov.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCod.Text == "" && txtNombre.Text != "")
            {
                txtCod.Text = "0";
            }
            if (txtNombre.Text != ""  && cnProveedorGus.Ag_ModProveedor(Convert.ToInt32(txtCod.Text),
            txtNombre.Text,Convert.ToInt32(txtNit.Text),txtNum.Text))
            {
                                
                dt.Rows.Clear();

                dt = cnProveedorGus.ListaProveedores();

                txtNombre.ResetText();
                txtNum.ResetText();
                txtNit.ResetText();
                txtCod.ResetText();

            }
            else
            {
                MessageBox.Show("Registro Fallido");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_Prov.SelectedRows.Count > 0)
            {
                
                txtCod.Text = dgv_Prov.Rows[dgv_Prov.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombre.Text = dgv_Prov.Rows[dgv_Prov.CurrentRow.Index].Cells[1].Value.ToString();
                txtNit.Text = dgv_Prov.Rows[dgv_Prov.CurrentRow.Index].Cells[2].Value.ToString();
                txtNum.Text = dgv_Prov.Rows[dgv_Prov.CurrentRow.Index].Cells[3].Value.ToString();

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dgv_Prov.SelectedRows.Count > 0)
            {
                string temp;
                temp = dgv_Prov.Rows[dgv_Prov.CurrentRow.Index].Cells[0].Value.ToString(); 

                if (cnProveedorGus.ElimProveedor(Convert.ToInt32(temp)))
                {

                    dt.Rows.Clear();

                    dt = cnProveedorGus.ListaProveedores();

                }
                else
                {
                    MessageBox.Show("Registro Fallido");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_GUS.ErrorCasillaVacia(txtBusqueda, errorBusqueda, "Buscar"))
            {

                int cod;
                try
                {
                    cod = Convert.ToInt32(txtBusqueda.Text);
                }
                catch (Exception ex)
                {
                    cod = 0;
                    
                }
                dt.Rows.Clear();
                dt = cnProveedorGus.BuscProveedor(cod, txtBusqueda.Text);
                dgv_Prov.DataSource = dt;

            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            dt = cnProveedorGus.ListaProveedores();
            dgv_Prov.DataSource = dt;
        }
    }
}
