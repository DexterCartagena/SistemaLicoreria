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
using System.IO;

namespace CAPA_PRESENTACION
{
    public partial class L_Productos : Form
    {
        public L_Productos()
        {
            InitializeComponent();
        }
         CN_Productos_LF cnProductos = new CN_Productos_LF();
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar la iamgen de referencia?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtImg.Text != "" & txtImg.Text!="none")
                {
                    if (File.Exists(COMMON.C_APPCOMUN.ruta+txtImg.Text))
                    {
                        File.Delete(COMMON.C_APPCOMUN.ruta + txtImg.Text);
                        txtImg.Text = "";
                        MessageBox.Show("Imagen eliminada");
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen seleccionada");
                }
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            int cod;
            cod = cnProductos.CodProxProducto();
            txtCod.Text = cod.ToString();
            pbLogo.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgL\LogoProducto.png";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtImg.Text == "") { txtImg.Text = "none"; }
            if (cnProductos.RegistrarProductos(
              txt_Detalle.Text,
              float.Parse(txt_Cantidad.Text),
              decimal.Parse(txt_PrecioCosto.Text),
              decimal.Parse(txt_PrecioVenta.Text),
              decimal.Parse(txt_PrecioHistorico.Text),
              txtImg.Text
               ))
            {
                MessageBox.Show("Registro Existoso");
            }
            else
            {
                MessageBox.Show("Registro Fallido");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro desea eliminar la iamgen de referencia?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnProductos.EliminarProducto(int.Parse(txtCod.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L_busqueda_Produc bp = new L_busqueda_Produc();
            bp.ShowDialog();
            if (bp.DialogResult == DialogResult.OK)
            {
                txtCod.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString();
                txt_Detalle.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[1].Value.ToString();
                txt_Cantidad.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[2].Value.ToString();
                txt_PrecioHistorico.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[3].Value.ToString();
                txt_PrecioCosto.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[4].Value.ToString();
                txt_PrecioVenta.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[5].Value.ToString();
                txtImg.Text = bp.dgv_grilla.Rows[bp.dgv_grilla.CurrentRow.Index].Cells[6].Value.ToString();

                pbImagen.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgSis\" + txtImg.Text;

                btnAgregar.Enabled = false;
                btneliminarReg.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
        string direccion;
        string direccion2;
        string terminacion;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int desglo;
            try
            {
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "imagenes|*.jpg; * .png";
                dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                dialogo.Title = "Seleccionar Imagen";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    direccion = dialogo.FileName;
                    desglo = direccion.Count() - 4;
                    terminacion = direccion.Remove(0, desglo);
                    pbImagen.ImageLocation = dialogo.FileName;
                    direccion2 = COMMON.C_APPCOMUN.ruta + @"\imgSis\" + txtCod.Text + terminacion;
                    btnSeleccion.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(direccion, direccion2);
                MessageBox.Show("Se Guardo la imagen Correctamente");
                txtImg.Text = txtCod.Text + terminacion;
                btnSeleccion.Enabled = false;
                btnGuardar.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtCod,epCodigo,"Codigo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Cantidad,epCantidad,"Cantidad") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_PrecioCosto,epPrecioc,"Precio Costo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_PrecioHistorico,epPrecioh,"Precio Historico") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_PrecioVenta,epPreciov,"PrecioVenta")
                )
            if(MessageBox.Show("Seguro que desea actualizar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    if(cnProductos.ActualizarProducto(
                        Convert.ToInt32(txtCod.Text),
                        txt_Detalle.Text,
                        float.Parse(txt_Cantidad.Text),
                        Convert.ToDecimal(txt_PrecioCosto.Text),
                        Convert.ToDecimal(txt_PrecioHistorico.Text),
                        Convert.ToDecimal(txt_PrecioVenta.Text),
                        txtImg.Text
                        ))
                    {
                        MessageBox.Show("Registro Actualizado");
                    }
                    else
                    {
                        MessageBox.Show("Fallo al realizar el registro");
                    }
            }
        }
    }
}
