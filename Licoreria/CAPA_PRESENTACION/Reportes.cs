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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        //Variables
        CN_REPORTE cnreporte = new CN_REPORTE();
        int estReporte = 0;
        int estSeleccionRpt = 0;
        DataTable dt = new DataTable();
        private void iconButton2_Click(object sender, EventArgs e)
        {
            BUscarSeleccionado();
            dt.Rows.Clear();
            if (estReporte == 1 && estSeleccionRpt == 1)
            {
                dt = cnreporte.Rpt_Vent_Dia(
                    COMMON.C_METODO_COMUN_OR.CambioFormato(dtpInicio.Text),
                    COMMON.C_METODO_COMUN_OR.CambioFormato(dtpFin.Text)
                    );
                dgvGrilla.DataSource = dt;
                txtTotal.Text = TotalizarReporte().ToString();
            }
      
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        public decimal TotalizarReporte()
        {
            decimal temp=0;
            int colum;
            for(int i = 0; i < dgvGrilla.Rows.Count; i++)
            {
                colum = dgvGrilla.Columns.Count-1;
                temp = temp + Convert.ToDecimal(dgvGrilla.Rows[i].Cells[colum].Value.ToString());
            }
            return temp;
        }
        public void BUscarSeleccionado()
        {
            if (radioButton1.Checked) { estSeleccionRpt = 1; }
            if (radioButton2.Checked) { estSeleccionRpt = 2; }
            if (radioButton3.Checked) { estSeleccionRpt = 3; }
            if (radioButton4.Checked) { estSeleccionRpt = 4; }
            if (radioButton5.Checked) { estSeleccionRpt = 5; }
            if (radioButton6.Checked) { estSeleccionRpt = 6; }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (rbVentas.Checked) { estReporte = 1; }
            if (rbCompras.Checked) { estReporte = 2; }
            if (rbProveedor.Checked) { estReporte = 3; }
            if (rbCliente.Checked) { estReporte = 4; }
            if (rbStock.Checked) { estReporte = 5; }

            GenerarReportes(estReporte);
        }
        public void GenerarReportes(int variable)
        {
            switch (variable)
            {
                case 1://Ventas
                    radioButton1.Text = "Ventas por Dia"; radioButton1.Visible = true; ; 
                    radioButton2.Text = "Ventas por Producto"; radioButton2.Visible = true; ;
                    radioButton3.Text = "Ventas por Usuario"; radioButton3.Visible = true; ;
                    radioButton4.Text = "Ventas Mensual"; radioButton4.Visible = true; ;
                    radioButton5.Text = "Resumen de Ingresos y Egresos"; radioButton5.Visible = true; ;
                    radioButton6.Text = "Top Ventas"; radioButton6.Visible = true; ;
                    break;
                case 2:
                    radioButton1.Text = "Reporte de Compra"; radioButton1.Visible = true; ;
                    radioButton2.Text = "Compras por Producto"; radioButton2.Visible = true; ;
                    radioButton3.Text = "Top Compras"; radioButton3.Visible = true; ;
                    break;
                case 3:
                    radioButton1.Text = "Reporte de Proveedores"; radioButton1.Visible = true; ;
                    break;
                case 4:
                    radioButton1.Text = "Reporte de Clientes"; radioButton1.Visible = true; ;
                    break;
                case 5:
                    radioButton1.Text = "Reporte de Stock"; radioButton1.Visible = true;
                    break;
            }
        }
        public void Limpiar()
        {
            radioButton1.Text = ""; radioButton1.Visible = false; ;
            radioButton2.Text = ""; radioButton2.Visible = false; ;
            radioButton3.Text = ""; radioButton3.Visible = false; ;
            radioButton4.Text = ""; radioButton4.Visible = false; ;
            radioButton5.Text = ""; radioButton5.Visible = false; ;
            radioButton6.Text = ""; radioButton6.Visible = false; ;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            if (estReporte == 1 && estSeleccionRpt == 1)
            {
                FolderBrowserDialog seleccionUbicacion = new FolderBrowserDialog();
                if (seleccionUbicacion.ShowDialog() == DialogResult.OK)
                {
                    ImpresionRptVentasDia(seleccionUbicacion.SelectedPath);
                    MessageBox.Show("Nota Impresa");
                }
            }
            
        }
        public void ImpresionRptVentasDia(string ubicacion)
        {
            //Ventas vent04 = new Ventas();
            string filas = string.Empty;
            decimal total2 = 0;
            decimal temp = 0;

            string fechaActual = DateTime.Now.ToString();

            int nroVentaT = estSeleccionRpt;

            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[5].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[6].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[7].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            total2 = decimal.Parse(txtTotal.Text);
            string paginaHtml = Properties.Resources.ReporteVentDia.ToString();
            //string paginaHtml = @"C:\Users\Orlando\Desktop\SistemasDesarrollo\SistemaMarket\Presentacion\bin\Debug\Plantillas\notasVenta.html";
            CN_IMPRESION impr = new CN_IMPRESION();
            impr.imprimirRptVentaDia(paginaHtml, COMMON.C_USUARIO.nombre, COMMON.C_USUARIO.cod.ToString(), nroVentaT, filas, total2.ToString(), dtpInicio.Text, dtpFin.Text, ubicacion);
        }
    }
}
