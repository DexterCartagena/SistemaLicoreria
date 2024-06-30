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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        //Variables
        CN_COMPRAS_OR cnComprasOr = new CN_COMPRAS_OR();
        string fechaActual;

        private void Compras_Load(object sender, EventArgs e)
        {
            txtCodProducto.Enabled = false;

            pb_LogoCompra.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgOr\LogoCompra.png";

            //Cargar inofrmacion del  ususario
            txtCodUsuario.Text = COMMON.C_USUARIO.cod.ToString();
            TxtRolUsuario.Text = COMMON.C_USUARIO.rol;
            txtNombreUsuario.Text = COMMON.C_USUARIO.nombre;

            //Cargar infomracion de la fecha y nit
            fechaActual = DateTime.Now.ToString();

            txtFecha.Text = fechaActual.Substring(0,10);//9
            txtHora.Text = fechaActual.Substring(11, 5);//11-15
            txtNit.Text = cnComprasOr.Get_Nit().ToString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ConsuProduComp cpc = new ConsuProduComp();
            cpc.ShowDialog();
            if(cpc.DialogResult == DialogResult.OK)
            { 
                txtCodProducto.Text = cpc.dgv_grilla.Rows[cpc.dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtDetalleProducto.Text = cpc.dgv_grilla.Rows[cpc.dgv_grilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecioProducto.Text = cpc.dgv_grilla.Rows[cpc.dgv_grilla.CurrentRow.Index].Cells[4].Value.ToString();

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int n;
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCantProducto,epCant,"Cantidad") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtDetalleProducto,epDetalle,"Detalle") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtPrecioProducto,epPrecio,"Precio")
                )
            {
                if (VerificarDatosGrilla()==false)
                {
                    n = dgvGrilla.Rows.Add();
                    int cant;
                    decimal precio, subtotal;
                    dgvGrilla.Rows[n].Cells[0].Value = txtCodProducto.Text;
                    dgvGrilla.Rows[n].Cells[1].Value = txtDetalleProducto.Text;
                    dgvGrilla.Rows[n].Cells[2].Value = txtCantProducto.Text;
                    dgvGrilla.Rows[n].Cells[3].Value = txtPrecioProducto.Text;
                    //Calculo precio costo
                    cant = Convert.ToInt32(dgvGrilla.Rows[n].Cells[2].Value.ToString());
                    precio = Convert.ToDecimal(dgvGrilla.Rows[n].Cells[3].Value.ToString());
                    subtotal = (precio / cant);
                    dgvGrilla.Rows[n].Cells[4].Value = subtotal;
                }
                TotalDeCompra();
                limpiartextbox();
            }
        }

        public bool VerificarDatosGrilla()
        {
            bool estado = false;
            for (int i = 0; i < dgvGrilla.Rows.Count; i++)
            {
                if (dgvGrilla.Rows[i].Cells[0].Value.ToString()==txtCodProducto.Text)
                {
                    int cant;
                    decimal precio, subtotal;
                    dgvGrilla.Rows[i].Cells[1].Value = txtDetalleProducto.Text;
                    dgvGrilla.Rows[i].Cells[2].Value = txtCantProducto.Text;
                    dgvGrilla.Rows[i].Cells[3].Value = txtPrecioProducto.Text;
                    cant = Convert.ToInt32(dgvGrilla.Rows[i].Cells[2].Value.ToString());
                    precio = Convert.ToDecimal(dgvGrilla.Rows[i].Cells[3].Value.ToString());
                    subtotal = (precio / cant);
                    dgvGrilla.Rows[i].Cells[4].Value = subtotal;
                    estado = true;
                }
            }
            return estado;
        }
        public void TotalDeCompra()
        {
            decimal total = 0;
            for(int i = 0; i < dgvGrilla.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgvGrilla.Rows[i].Cells[3].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count > 0)
            {
                dgvGrilla.Rows.RemoveAt(dgvGrilla.CurrentRow.Index);
            }
            TotalDeCompra();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count > 0)
            {
                txtCodProducto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtDetalleProducto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtCantProducto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[2].Value.ToString();
                txtPrecioProducto.Text = dgvGrilla.Rows[dgvGrilla.CurrentRow.Index].Cells[3].Value.ToString();

                dgvGrilla.Rows.RemoveAt(dgvGrilla.CurrentRow.Index);

                TotalDeCompra();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ConsuProveComp cpc = new ConsuProveComp();
            cpc.ShowDialog();
            if(cpc.DialogResult == DialogResult.OK)
            {
                txtCodProveedor.Text = cpc.dgvGrilla.Rows[cpc.dgvGrilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtDetalleProveedor.Text = cpc.dgvGrilla.Rows[cpc.dgvGrilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtNitProveedor.Text = cpc.dgvGrilla.Rows[cpc.dgvGrilla.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodProveedor, epCodProveedor, "Proveedor"))
            {
                if (MessageBox.Show("Seguro que desea registrar una compra?", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cnComprasOr.registrarComrpa(int.Parse(txtCodUsuario.Text), int.Parse(txtCodProveedor.Text), int.Parse(txtNitProveedor.Text), Convert.ToDecimal(txtTotal.Text),COMMON.C_METODO_COMUN_OR.CambioFormato(txtFecha.Text)))
                    {
                        for (int i = 0; i < dgvGrilla.Rows.Count; i++)
                        {
                            if (dgvGrilla.Rows[i].Cells[0].Value.ToString() == "") { dgvGrilla.Rows[i].Cells[0].Value = 0; }

                            cnComprasOr.RegistroDetalleCompra(
                                int.Parse(dgvGrilla.Rows[i].Cells[0].Value.ToString()),
                                dgvGrilla.Rows[i].Cells[1].Value.ToString(),
                                int.Parse(dgvGrilla.Rows[i].Cells[2].Value.ToString()),
                                decimal.Parse(dgvGrilla.Rows[i].Cells[4].Value.ToString()),
                                decimal.Parse(dgvGrilla.Rows[i].Cells[3].Value.ToString())
                                );
                        }
                        MessageBox.Show("Registro Exitoso");
                    }
                }
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            limpiartextbox();
        }
        public void limpiartextbox()
        {
            txtCantProducto.Text = "";
            txtCodProducto.Text = "";
            txtDetalleProducto.Text = "";
            txtPrecioProducto.Text = "";
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ConsuRegistros cr = new ConsuRegistros();
            cr.ShowDialog();
            if(cr.DialogResult == DialogResult.OK)
            {
                txtCodCompraEditar.Visible = true;
                lblCodCompraEditar.Visible = true;

                txtCodCompraEditar.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[0].Value.ToString();
                txtFecha.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodProveedor.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[2].Value.ToString();
                txtDetalleProveedor.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[3].Value.ToString();
                txtNitProveedor.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[6].Value.ToString();
                txtCodUsuario.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[4].Value.ToString();
                txtNombreUsuario.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[5].Value.ToString();
                txtTotal.Text = cr.dgvCompra.Rows[cr.dgvCompra.CurrentRow.Index].Cells[7].Value.ToString();

                dgvGrilla.Rows.Clear();
                int n = 0;
                for(int i = 0; i < cr.dgvDetalleCompra.Rows.Count; i++)
                {// cod producto cant precio preciounit
                    n = dgvGrilla.Rows.Add();
                    dgvGrilla.Rows[n].Cells[0].Value = cr.dgvDetalleCompra.Rows[i].Cells[2].Value.ToString();
                    dgvGrilla.Rows[n].Cells[1].Value = cr.dgvDetalleCompra.Rows[i].Cells[3].Value.ToString();
                    dgvGrilla.Rows[n].Cells[2].Value = cr.dgvDetalleCompra.Rows[i].Cells[4].Value.ToString();
                    dgvGrilla.Rows[n].Cells[3].Value = cr.dgvDetalleCompra.Rows[i].Cells[6].Value.ToString();
                    dgvGrilla.Rows[n].Cells[4].Value = cr.dgvDetalleCompra.Rows[i].Cells[5].Value.ToString();
                }
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCodProveedor, epCodProveedor, "Proveedor"))
            {
                if(MessageBox.Show("Esta seguro de querer modificar la compra : "+txtCodCompraEditar.Text,"Modficicar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cnComprasOr.ModificarCompra(Convert.ToInt32(txtCodCompraEditar.Text), Convert.ToInt32(txtCodProveedor.Text), Convert.ToInt32(txtCodUsuario.Text), Convert.ToInt32(txtNitProveedor.Text), Convert.ToDecimal(txtTotal.Text)))
                    {
                        for(int i = 0; i < dgvGrilla.Rows.Count; i++)
                        {
                            if (dgvGrilla.Rows[i].Cells[0].Value.ToString() == "") { dgvGrilla.Rows[i].Cells[0].Value = "0"; }
                            cnComprasOr.ModificarDetalleCompra(
                                Convert.ToInt32(txtCodCompraEditar.Text),
                                Convert.ToInt32(dgvGrilla.Rows[i].Cells[0].Value.ToString()),
                                dgvGrilla.Rows[i].Cells[1].Value.ToString(),
                                Convert.ToInt32(dgvGrilla.Rows[i].Cells[2].Value.ToString()),
                                Convert.ToDecimal(dgvGrilla.Rows[i].Cells[4].Value.ToString()),
                                Convert.ToDecimal(dgvGrilla.Rows[i].Cells[3].Value.ToString())
                                ); ;
                        }
                        MessageBox.Show("Modificacion Exitosa");
                    }
                }
            }
        }
    }
}
