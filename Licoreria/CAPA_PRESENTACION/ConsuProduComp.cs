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
    public partial class ConsuProduComp : Form
    {
        public ConsuProduComp()
        {
            InitializeComponent();
        }
        //Variables
        CN_COMPRAS_OR cnComprasOr = new CN_COMPRAS_OR();
        DataTable dt = new DataTable();
        private void ConsuProduComp_Load(object sender, EventArgs e)
        {
            //Cargar datos en la grilla
            dt = cnComprasOr.ListProductos();
            dgv_grilla.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_grilla.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (COMMON.C_METODO_COMUN_OR.ErrorCasillaVacia(txtBusqueda, epBusqueda, "Buscar"))
            {
                int cod;
                string detalle="";
                try
                {
                    cod = Convert.ToInt32(txtBusqueda.Text);
                }catch(Exception ex)
                { cod = 1; }
                dt.Rows.Clear();
                dt = cnComprasOr.BuscarProducto(cod, txtBusqueda.Text);
                dgv_grilla.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
