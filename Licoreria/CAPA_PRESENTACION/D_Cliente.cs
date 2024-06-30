using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class D_Cliente : Form
    {
        CN_Cliente_De oCliente = new CN_Cliente_De();
        public D_Cliente()        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            RellenoGenral();

            pbLogo.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgOr\LogoCliente.png";
        }
        public void RellenoGenral()
        {
            dt.Rows.Clear();
            dt = oCliente.ListCliente();
            dgvgrilla.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cod;
            string nombre;
            try
            {
                cod = Convert.ToInt32(txtBuscar.Text);
            }catch(Exception ex)
            {
                cod = 0;
            }
            finally
            {
                nombre = txtBuscar.Text;
            }
            dt.Rows.Clear();
            dt = oCliente.BuscarCliente(cod, nombre);
            dgvgrilla.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtNombre,epNombre,"Nombre") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCelular,epCelular,"Telefono") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCorreo,epCorreo,"Correo")
                )
            {
                if(MessageBox.Show("Esta seguro de agregar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oCliente.RegistrarCliente(txtNombre.Text, txtCelular.Text, txtCorreo.Text))
                        {
                        MessageBox.Show("Registro Realizado");
                        RellenoGenral();
                        }
                }
            }
        }

        private void btnMModificar_Click(object sender, EventArgs e)
        {
            if (
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodigo,epCodigo,"Codigo") &
               COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtNombre, epNombre, "Nombre") &
               COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCelular, epCelular, "Telefono") &
               COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCorreo, epCorreo, "Correo")
               )
            {
                if (MessageBox.Show("Esta seguro de actualizar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oCliente.ModificarCliente(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtCelular.Text, txtCorreo.Text))
                    {
                        MessageBox.Show("Registro Actualizado");
                        RellenoGenral();
                    }
                }
            }
        }

        private void dgvgrilla_Click(object sender, EventArgs e)
        {

        }

        private void dgvgrilla_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvgrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvgrilla.Rows[dgvgrilla.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvgrilla.Rows[dgvgrilla.CurrentRow.Index].Cells[1].Value.ToString();
            txtCorreo.Text = dgvgrilla.Rows[dgvgrilla.CurrentRow.Index].Cells[2].Value.ToString();
            txtCelular.Text = dgvgrilla.Rows[dgvgrilla.CurrentRow.Index].Cells[3].Value.ToString();
        }
        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtNombre.Text="";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarico_Click(object sender, EventArgs e)
        {
            if (
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodigo, epCodigo, "Codigo")
               )
            {
                if (MessageBox.Show("Esta seguro de Eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oCliente.EliminarCliente(Convert.ToInt32(txtCodigo.Text)))
                    {
                        MessageBox.Show("Registro Eliminado");
                        RellenoGenral();
                    }
                }
            }
        }
    }
}
