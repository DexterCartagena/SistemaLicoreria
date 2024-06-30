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
using COMMON;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace CAPA_PRESENTACION
{
    public partial class G_venats : Form
    {
        public G_venats()
        {
            InitializeComponent();
        }
        CN_VENTAS_GUS cnVentasGus = new CN_VENTAS_GUS();
        string fechaActual;

        private void venats_Load(object sender, EventArgs e)
        {
            numeroUp.Minimum = 1;
            txtCodProd.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            logoImg.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\VentasImg\Ventaspng.png";
            personaBuscar.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\VentasImg\persona.png";
            buscarP.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\VentasImg\buscar.png";
            agregarP.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\VentasImg\agregar.png";

            fechaActual = DateTime.Now.ToString();
            
            Fecha.Text = fechaActual.Substring(0,10);
            txtbHora.Text = fechaActual.Substring(11,5);
            lblNit.Text = cnVentasGus.Get_Nit().ToString();

            
            lblCOD.Text = COMMON.C_USUARIO.cod.ToString();
            lblPuesto.Text = COMMON.C_USUARIO.rol;
            lblUsuario.Text = COMMON.C_USUARIO.nombre;

        }

        private void buscarP_Click(object sender, EventArgs e)
        {
            G_ConsuProducVenta producto = new G_ConsuProducVenta();
            producto.ShowDialog();
            if(producto.DialogResult == DialogResult.OK)
            {
                txtCodProd.Text = producto.dgv_Productos.Rows[producto.dgv_Productos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDetalle.Text = producto.dgv_Productos.Rows[producto.dgv_Productos.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = producto.dgv_Productos.Rows[producto.dgv_Productos.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void personaBuscar_Click(object sender, EventArgs e)
        {
            G_ConsuClientes clientes = new G_ConsuClientes();
            clientes.ShowDialog();
            if(clientes.DialogResult == DialogResult.OK)
            {
                txtCodCli.Text = clientes.dgv_Clientes.Rows[clientes.dgv_Clientes.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = clientes.dgv_Clientes.Rows[clientes.dgv_Clientes.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }

        private void agregarP_Click(object sender, EventArgs e)
        {
            int n;
            if (
                COMMON.C_METODO_COMUN_GUS.ErrorCasillaVacia(txtDetalle, erProd, "Detalle") &
                COMMON.C_METODO_COMUN_GUS.ErrorCasillaVacia(txtPrecio, erPrecio, "Precio")
                )
            {
                if(VerificarDatosGrilla()==false)
                {
                    n = dgv_grilla.Rows.Add();
                    int cant;
                    decimal precio, subtotal;
                    dgv_grilla.Rows[n].Cells[0].Value = txtCodProd.Text;
                    dgv_grilla.Rows[n].Cells[1].Value = txtDetalle.Text;
                    dgv_grilla.Rows[n].Cells[2].Value = txtPrecio.Text;
                    dgv_grilla.Rows[n].Cells[3].Value = numeroUp.Text;
                    

                    cant = Convert.ToInt32(dgv_grilla.Rows[n].Cells[3].Value.ToString());
                    precio = Convert.ToDecimal(dgv_grilla.Rows[n].Cells[2].Value.ToString());
                    subtotal = (precio * cant);
                    dgv_grilla.Rows[n].Cells[4].Value = subtotal;

                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;


                    txtCodProd.ResetText();
                    txtDetalle.ResetText();
                    txtPrecio.ResetText();
                    numeroUp.Text = "1";

                }
                TotalDeCompra();



                


            }
        }

        public bool VerificarDatosGrilla()
        {
            bool estado = false;
            for (int i = 0; i < dgv_grilla.Rows.Count; i++)
            {
                if (dgv_grilla.Rows[i].Cells[0].Value.ToString() == txtCodProd.Text)
                {
                    int cant;
                    decimal precio;
                    decimal subtotal;
                    
                    dgv_grilla.Rows[i].Cells[1].Value = txtDetalle.Text;
                    dgv_grilla.Rows[i].Cells[2].Value = txtPrecio.Text;
                    dgv_grilla.Rows[i].Cells[3].Value = numeroUp.Text;
                    cant = Convert.ToInt32(dgv_grilla.Rows[i].Cells[2].Value.ToString());
                    precio = Convert.ToDecimal(dgv_grilla.Rows[i].Cells[3].Value.ToString());
                    subtotal = (precio * cant);
                    dgv_grilla.Rows[i].Cells[4].Value = subtotal;
                    estado = true;
                }
            }
            return estado;
        }

        public void TotalDeCompra()
        {
            decimal total = 0;
            for (int i = 0; i < dgv_grilla.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgv_grilla.Rows[i].Cells[4].Value.ToString());
            }
            Total.Text = total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgv_grilla.SelectedRows.Count > 0)
            {
                dgv_grilla.Rows.RemoveAt(dgv_grilla.CurrentRow.Index);
            }
            TotalDeCompra();

            if(dgv_grilla.RowCount == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgv_grilla.SelectedRows.Count > 0)
            {
                txtCodProd.Text = dgv_grilla.Rows[dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString();
                txtDetalle.Text = dgv_grilla.Rows[dgv_grilla.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = dgv_grilla.Rows[dgv_grilla.CurrentRow.Index].Cells[2].Value.ToString();
                numeroUp.Text = dgv_grilla.Rows[dgv_grilla.CurrentRow.Index].Cells[3].Value.ToString();
                

                dgv_grilla.Rows.RemoveAt(dgv_grilla.CurrentRow.Index);

                TotalDeCompra();

                if (dgv_grilla.RowCount == 0)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            G_RegistroVentas registroVentas = new G_RegistroVentas();
            registroVentas.ShowDialog();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea registrar la venta?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cnVentasGus.RegVenta(Convert.ToInt32(txtCodCli.Text),Convert.ToInt32(lblCOD.Text), 0 , 1, COMMON.C_METODO_COMUN_OR.CambioFormato(Fecha.Text), Convert.ToDecimal(Total.Text)))
                {
                    for(int i = 0; i < dgv_grilla.Rows.Count; i++)
                    {
                        cnVentasGus.RegDetalleVenta(
                            Convert.ToInt32(dgv_grilla.Rows[i].Cells[0].Value.ToString()),
                            dgv_grilla.Rows[i].Cells[1].Value.ToString(),
                            Convert.ToInt32(dgv_grilla.Rows[i].Cells[3].Value.ToString()),
                            Convert.ToDecimal(dgv_grilla.Rows[i].Cells[2].Value.ToString()),
                            Convert.ToDecimal(dgv_grilla.Rows[i].Cells[4].Value.ToString())
                            );
                    }
                    MessageBox.Show("Venta Registrada");
                    if(MessageBox.Show("Desea generar una nota de venta?","Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FolderBrowserDialog seleccionUbicacion = new FolderBrowserDialog();
                        if(seleccionUbicacion.ShowDialog() == DialogResult.OK)
                        {
                            ImprecioonNota(seleccionUbicacion.SelectedPath);
                            MessageBox.Show("Nota Impresa");
                            limpiar();
                        }

                    }
                    else
                    {
                        limpiar();
                    }
                }
            }
        }
        public void limpiar()
        {
            txtCliente.Text = "";
            txtCodCli.Text = "";
            txtCodProd.Text = "";
            txtDetalle.Text = "";
            txtPrecio.Text = "";
            dgv_grilla.Rows.Clear();
        }
        public void ImprecioonNota(string ubicacion)
        {
            //Ventas vent04 = new Ventas();
            string filas = string.Empty;
            decimal total2 = 0;
            decimal temp = 0;

            int nroVentaT = 0;

            foreach (DataGridViewRow row in dgv_grilla.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            total2 = decimal.Parse(Total.Text);
            string paginaHtml = Properties.Resources.notasVenta.ToString();
            //string paginaHtml = @"C:\Users\Orlando\Desktop\SistemasDesarrollo\SistemaMarket\Presentacion\bin\Debug\Plantillas\notasVenta.html";
            CN_IMPRESION impr = new CN_IMPRESION();
            impr.imprimirVenta(paginaHtml, txtCliente.Text, txtCodCli.Text, nroVentaT, filas, total2.ToString(),Fecha.Text, ubicacion);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
