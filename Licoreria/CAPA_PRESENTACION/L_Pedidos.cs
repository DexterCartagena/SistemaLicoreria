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
    public partial class L_Pedidos : Form
    {
        public L_Pedidos()
        {
            InitializeComponent();
        }
        CN_PEDIDOS_LF cnPedidos = new CN_PEDIDOS_LF();
        private void Pedidos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cnPedidos.ListPlataforma();

            cb_Plataforma.DataSource = dt;
            cb_Plataforma.DisplayMember = "detalle";
            cb_Plataforma.ValueMember = "cod";

            pbLogo.ImageLocation = COMMON.C_APPCOMUN.ruta + @"\imgL\LogoPedido.png";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gdv_grilla_productos.SelectedRows.Count > 0)
            {
                gdv_grilla_productos.Rows.RemoveAt(gdv_grilla_productos.CurrentRow.Index);
            }
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Cod,epCod,"Codigo")
                )
            {
                if(MessageBox.Show("Seguroq ue desea Eliminar este Registro?","Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                if (cnPedidos.EliminarPedido(Convert.ToInt32(txt_Cod.Text)))
                {
                    MessageBox.Show("Registro Eliminado");
                        limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Registro");
                }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n;
          cuadro busqueda = new cuadro();
            busqueda.ShowDialog();
            if (busqueda.DialogResult == DialogResult.OK)
            {
                if (!repeticionProducto(Convert.ToInt32(busqueda.dgv_grilla.Rows[busqueda.dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString())))
                {
                    epRepeticionGrilla.Clear();
                    n = gdv_grilla_productos.Rows.Add();
                    gdv_grilla_productos.Rows[n].Cells[0].Value = busqueda.dgv_grilla.Rows[busqueda.dgv_grilla.CurrentRow.Index].Cells[0].Value.ToString();
                    gdv_grilla_productos.Rows[n].Cells[1].Value = busqueda.dgv_grilla.Rows[busqueda.dgv_grilla.CurrentRow.Index].Cells[1].Value.ToString();
                    gdv_grilla_productos.Rows[n].Cells[3].Value = busqueda.dgv_grilla.Rows[busqueda.dgv_grilla.CurrentRow.Index].Cells[3].Value.ToString();
                }
                else
                {
                    epRepeticionGrilla.SetError(btnBuscarProductos, "El producto ya se encuentra en la lista");
                }

            }
        }

        public bool repeticionProducto(int cod)
        {
            for(int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
            {
                if (Convert.ToInt32(gdv_grilla_productos.Rows[i].Cells[0].Value.ToString()) == cod)
                {
                    return true;
                }
            }
            return false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
         L_Busqueda_Clientes m = new L_Busqueda_Clientes();
            m.ShowDialog();
            if (m.DialogResult == DialogResult.OK)
            { 
             txt_Cliente.Text= m.dgv_Clientes.Rows[m.dgv_Clientes.CurrentRow.Index].Cells[0].Value.ToString();

            }
        }
        DataTable dtgrilla = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> codigo = new List<int>();
            List<string> producto = new List<string>();
            List<int> cant = new List<int>();
            List<decimal> precio = new List<decimal>();
            List<decimal> subtotal = new List<decimal>();

            L_Busqueda_Pedidos L= new L_Busqueda_Pedidos();
            L.ShowDialog();
            if (L.DialogResult == DialogResult.OK)
            {
                txt_Cod.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[0].Value.ToString();
                txt_Cliente.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[1].Value.ToString();
                cb_Plataforma.SelectedValue = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[3].Value.ToString();
                txt_Observacion.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[5].Value.ToString();
                txt_Pedido.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[6].Value.ToString().Substring(0,10);
                txt_Entrega.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[7].Value.ToString().Substring(0,10);
                txt_Total.Text = L.dgv_Pedidos.Rows[L.dgv_Pedidos.CurrentRow.Index].Cells[8].Value.ToString();

                if (dtgrilla == null)
                {
                    dtgrilla = cnPedidos.VistDetallePedido(Convert.ToInt32(txt_Cod.Text));
                    gdv_grilla_productos.Rows.Clear();
                    int n;
                    for(int i=0; i< dtgrilla.Rows.Count; i++)
                    {
                        n = gdv_grilla_productos.Rows.Add();

                        gdv_grilla_productos.Rows[n].Cells[0].Value = dtgrilla.Rows[i][0].ToString();
                        gdv_grilla_productos.Rows[n].Cells[1].Value = dtgrilla.Rows[i][1].ToString();
                        gdv_grilla_productos.Rows[n].Cells[2].Value = dtgrilla.Rows[i][2].ToString();
                        gdv_grilla_productos.Rows[n].Cells[3].Value = dtgrilla.Rows[i][3].ToString();
                        gdv_grilla_productos.Rows[n].Cells[4].Value = dtgrilla.Rows[i][4].ToString();
                    }
                }
                else
                {
                    dtgrilla.Rows.Clear();
                    dtgrilla.Columns.Clear();
                    gdv_grilla_productos.Rows.Clear();
                    dtgrilla = cnPedidos.VistDetallePedido(Convert.ToInt32(txt_Cod.Text));
                    int n;
                    for (int i = 0; i < dtgrilla.Rows.Count; i++)
                    {
                        n = gdv_grilla_productos.Rows.Add();

                        gdv_grilla_productos.Rows[n].Cells[0].Value = dtgrilla.Rows[i][0].ToString();
                        gdv_grilla_productos.Rows[n].Cells[1].Value = dtgrilla.Rows[i][1].ToString();
                        gdv_grilla_productos.Rows[n].Cells[2].Value = dtgrilla.Rows[i][2].ToString();
                        gdv_grilla_productos.Rows[n].Cells[3].Value = dtgrilla.Rows[i][3].ToString();
                        gdv_grilla_productos.Rows[n].Cells[4].Value = dtgrilla.Rows[i][4].ToString();
                    }
                }
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        public void CargarDatosDetalleTexto(List<string>lista,int columna,DataTable dt)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Entrega,EpFechaEntrega,"Fecha Entrega") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Pedido,epFechaPedido,"Fecha`Pedido") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Cliente,epCodCliente,"Cliente") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Total,epTotal,"Total")
                )
            {
                if(
                    COMMON.C_METODO_COMUN_OR.ValidacionFormatoFehca(txt_Pedido,epFechaPedido) &
                    COMMON.C_METODO_COMUN_OR.ValidacionFormatoFehca(txt_Entrega,EpFechaEntrega)
                    )
                {
                    if (cnPedidos.RegistrarPedidos
                        (Convert.ToInt32(txt_Cliente.Text), Convert.ToInt32(cb_Plataforma.SelectedValue.ToString()),txt_Observacion.Text,CambioFormato(txt_Pedido.Text),CambioFormato(txt_Entrega.Text),Convert.ToDecimal(txt_Total.Text)
                ))
                    {
                        for(int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
                        {
                            cnPedidos.RegiDetallePedido(
                                Convert.ToInt32(gdv_grilla_productos.Rows[i].Cells[0].Value.ToString()),
                                gdv_grilla_productos.Rows[i].Cells[1].Value.ToString(),
                                Convert.ToInt32(gdv_grilla_productos.Rows[i].Cells[2].Value.ToString()),
                                Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[3].Value.ToString()),
                                Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[4].Value.ToString())
                                );
                        }
                        MessageBox.Show("Registro Existoso");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Registro Fallido");
                    }
                }
            }
        }
        string CambioFormato(string ddmmyyyy)
        {
            string an;
            string mes;
            string dia;
            string yyyymmdd;
            dia = ddmmyyyy.Substring(0, 2);
            mes = ddmmyyyy.Substring(3, 2);
            an = ddmmyyyy.Substring(6, 4);
            yyyymmdd = an + mes + dia;
            return yyyymmdd;
        }
        public void limpiar()
        {
            txt_Cod.Text = "";
            txt_Pedido.Text = "";
            txt_Entrega.Text = "";
            txt_Cliente.Text = "";
            txt_Observacion.Text = "";
            txt_Total.Text = "";
            gdv_grilla_productos.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gdv_grilla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdv_grilla_productos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdv_grilla_productos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            if (CasillasNumericas() & CasillaVaciaSubTotal())
            {
                for(int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[4].Value.ToString());
                }
                txt_Total.Text = total.ToString();
            }
        }
        public bool CasillasNumericas()
        {
            int temp;
            decimal total = 0;
            for(int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
            {
                if (gdv_grilla_productos.Rows[i].Cells[2].Value == null) { gdv_grilla_productos.Rows[i].Cells[2].Value = 0; }
                if(int.TryParse(gdv_grilla_productos.Rows[i].Cells[2].Value.ToString(),out temp))
                {
                    gdv_grilla_productos.Rows[i].Cells[4].Value = temp * Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[3].Value.ToString());
                }
                else
                {
                    MessageBox.Show("La columna 'CANT' solo admite valores numericos enteros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gdv_grilla_productos.Rows[i].Cells[2].Value = "";
                    return false;
                }
            }
            return true;
        }
        public bool CasillaVaciaSubTotal()
        {
            decimal temp;
            for(int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
            {
                if (gdv_grilla_productos.Rows[i].Cells[4].Value == null) { return false; }
                if (! decimal.TryParse(gdv_grilla_productos.Rows[i].Cells[4].Value.ToString(), out temp))
                {
                    return false;
                }
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Cod,epCod,"Codifgo") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Entrega, EpFechaEntrega, "Fecha Entrega") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Pedido, epFechaPedido, "Fecha`Pedido") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Cliente, epCodCliente, "Cliente") &
                COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txt_Total, epTotal, "Total")
                )
            {
                if(cnPedidos.ModificarPedidos(Convert.ToInt32(txt_Cod.Text), Convert.ToInt32(txt_Cliente.Text), Convert.ToInt32(cb_Plataforma.SelectedValue.ToString()),txt_Observacion.Text,CambioFormato(txt_Pedido.Text),CambioFormato(txt_Entrega.Text),Convert.ToDecimal(txt_Total.Text)))
                {
                    for (int i = 0; i < gdv_grilla_productos.Rows.Count; i++)
                    {
                        try
                        {
                            cnPedidos.ModificariDetallePedido(
                                Convert.ToInt32(txt_Cod.Text),
                                Convert.ToInt32(gdv_grilla_productos.Rows[i].Cells[0].Value.ToString()),
                                gdv_grilla_productos.Rows[i].Cells[1].Value.ToString(),
                                Convert.ToInt32(gdv_grilla_productos.Rows[i].Cells[2].Value.ToString()),
                                Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[3].Value.ToString()),
                                Convert.ToDecimal(gdv_grilla_productos.Rows[i].Cells[4].Value.ToString())
                                );
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Uno de los datos en la lista esta incompleto");
                        }
                    }
                    MessageBox.Show("Registro Modificado");
                    limpiar();
                }
            }
        }
      
    }
}
