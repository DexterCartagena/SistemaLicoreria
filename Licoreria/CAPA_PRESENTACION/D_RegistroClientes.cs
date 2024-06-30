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
    public partial class D_RegistroClientes : Form
    {
        CN_Cliente_De oCliente = new CN_Cliente_De();
        string accion = "";
        public D_RegistroClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Boton Eliminar = btnEliminar(por alguna razon no se asigno el nombre)
        {
            if (accion == "N")
            {
                accion = "E";
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                if (accion == "E")
                {
                    accion = "N";

                    if (oCliente.Eliminar(txtCodigo.Text))
                    {
                        MessageBox.Show("Datos Eliminados correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error, Verifique los datos");
                    }
                    LimpiarEntradas();
                    btnCancelar_Click(sender, e);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accion = "N";
            LimpiarEntradas();
            txtCodigo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void LimpiarEntradas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            accion = "N";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion=="N" || accion == "G")
            {
                accion = "G";
                oCliente.NOMBRES = txtNombre.Text;
                oCliente.CELULAR = txtCelular.Text;
                oCliente.CORREO = txtCorreo.Text;
                if (oCliente.Guardar())
                {
                    MessageBox.Show("Datos introducidos correctamente");
                }
                else
                {
                    MessageBox.Show("Error, Verifique los datos");
                }
            }
            if (accion=="M")
            {
                oCliente.NOMBRES = txtNombre.Text;
                oCliente.CELULAR = txtCelular.Text;
                oCliente.CORREO = txtCorreo.Text;
                if (oCliente.Modificar(txtCodigo.Text))
                {
                    MessageBox.Show("Datos Modificados correctamente");
                }
                else
                {
                    MessageBox.Show("Error, Verifique los datos");
                }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "M";
            LimpiarEntradas();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable TablaCliente= new DataTable();
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("VACIO");
                }
                else
                {
                    if (oCliente.VerificarCliente(txtCodigo.Text,ref TablaCliente))
                    {
                        txtNombre.Text = TablaCliente.Rows[0][0].ToString();
                        txtCelular.Text = TablaCliente.Rows[0][1].ToString();
                        txtCorreo.Text = TablaCliente.Rows[0][2].ToString();
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
    }
}
