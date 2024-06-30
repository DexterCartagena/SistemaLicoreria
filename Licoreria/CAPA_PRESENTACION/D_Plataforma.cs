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
    public partial class D_Plataforma : Form
    {
        CN_PLAT_De oPlataforma = new CN_PLAT_De();
        string accion = "";
        public D_Plataforma()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();
            dgvGrilla.Columns.Clear();
            DataTable tabla = new DataTable();
            tabla = oPlataforma.ListUsuario();
            dgvGrilla.DataSource = tabla;

            imgLogo.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgOr\LogoPlataforma.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e) //Boton Salir
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarEntradas()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtDetalle.Clear();
            txtClave.Clear();
            txtUsuario.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable TablaUsuario = new DataTable();
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("VACIO");
                }
                else
                {
                    if (oPlataforma.VerificarUsuario(txtCodigo.Text, ref TablaUsuario))
                    {
                        txtUsuario.Text = TablaUsuario.Rows[0][0].ToString();
                        txtDetalle.Text = TablaUsuario.Rows[0][1].ToString();
                        txtClave.Text = TablaUsuario.Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ERROR DE DATO");
                        txtCodigo.Clear();
                        LimpiarEntradas();
                        txtCodigo.Focus();
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodigo, epCodigo, "Codigo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtDetalle, epDetalle, "Detalle") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtUsuario, epUsuario, "Usuario") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtClave, epClave, "Clave")
                )
            {
                if (oPlataforma.ModificarPlataforma(Convert.ToInt32(txtCodigo.Text), txtDetalle.Text, txtUsuario.Text, txtClave.Text))
                {
                    MessageBox.Show("Plataforma Actualizada");
                }
                else
                {
                    MessageBox.Show("Error en la Actualizacion");
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtDetalle, epDetalle, "Detalle") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtUsuario, epUsuario, "Usuario") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtClave, epClave, "Clave")
                )
            {
                if (oPlataforma.RegPlataforma(txtDetalle.Text, txtUsuario.Text, txtClave.Text))
                {
                    MessageBox.Show("Plataforma Registrada");
                }
                else
                {
                    MessageBox.Show("Error en el Registro");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtUsuario.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[2].Value.ToString();
                txtDetalle.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtClave.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (
               COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodigo, epCodigo, "Codigo")
               )
            {
                if (oPlataforma.EliminarPlataforma(Convert.ToInt32(txtCodigo.Text)))
                {
                    MessageBox.Show("Plataforma Eliminada");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }
            }
        }
    }
}
