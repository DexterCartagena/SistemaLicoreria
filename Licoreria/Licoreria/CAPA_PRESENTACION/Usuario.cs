using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMMON;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        CN_USUARIO_OR cnusuarioor = new CN_USUARIO_OR();
        private void Usuario_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cnusuarioor.ListRol();
            cbRol.DataSource = dt;
            cbRol.DisplayMember = "detalle";
            cbRol.ValueMember = "cod";

            txtCod.Text = COMMON.C_USUARIO.cod.ToString();
            txtNombre.Text = COMMON.C_USUARIO.nombre;
            txtCi.Text = COMMON.C_USUARIO.ci;
            cbRol.Text = COMMON.C_USUARIO.rol;
            txtTelefono.Text = COMMON.C_USUARIO.celular;
            txtFecha.Text = COMMON.C_USUARIO.fechaIng;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsuUsuario cu = new ConsuUsuario();
            cu.ShowDialog();
            if (cu.DialogResult == DialogResult.OK)
            {
                txtCod.Text= cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString();
                cbRol.Text = cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtNombre.Text = cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[2].Value.ToString();
                txtCi.Text = cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[3].Value.ToString();
                txtFecha.Text = cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[4].Value.ToString();
                txtTelefono.Text = cu.dgv_grilla.Rows[cu.dgv_grilla.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCod,epCod,"Codigo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtNombre,epNombre,"Nombre") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCi,epCi,"CI") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtFecha,epFecha,"Fecha") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtTelefono,epTelefono,"Telefono")
                )
            {
                ClaveUsuario clu = new ClaveUsuario();
                clu.ShowDialog();
                if (clu.DialogResult == DialogResult.OK)
                {
                    if (MessageBox.Show("Esta seguro de agregar/actualizar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        password = clu.txtconfirmacion2.Text;
                        if (txtCod.Text == "") { txtCod.Text = "0"; }
                        if (cnusuarioor.RegModUsuario(Convert.ToInt32(txtCod.Text), Convert.ToInt32(cbRol.SelectedValue.ToString()), txtNombre.Text.Trim(), password, txtCi.Text, COMMON.C_METODO_COMUN_OR.CambioFormato(txtFecha.Text), txtTelefono.Text))
                        {
                            MessageBox.Show("Registro Actualizado");
                            limpiar();
                        }
                    }
                }
            }
        }
        public void limpiar()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtCi.Text = "";
            txtTelefono.Text = "";
            txtFecha.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCod,epCod,"Codigo"))
            {
                if (MessageBox.Show("Esta seguro de eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cnusuarioor.EliminarUsuario(Convert.ToInt32(txtCod.Text)))
                    {
                        MessageBox.Show("Registro elimiado con exito");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Registro No existente");
                    }
                }
            }
        }
    }
}
