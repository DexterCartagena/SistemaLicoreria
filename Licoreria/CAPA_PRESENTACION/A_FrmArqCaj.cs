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
    public partial class A_FrmArqCaj : Form
    {
        //public A_FrmArqCaj()
        //{
        //    InitializeComponent();
        //}

        private void A_FrmArqCaj_Load(object sender, EventArgs e)
        {

        }

        CN_A oCN_A = new CN_A();
        public string fechaB;
        DataTable DtsCons = new DataTable();
        public string fechaAux;
        public string yearB;
        public string monthB;
        public string dayB;
        public string tipoArq;
        public string detalle;
        public int total;
        public int Val1 = 0;
        public int Val2 = 0;
        public int Val3 = 0;
        public int Val4 = 0;
        public int sumaA = 0;
        public int restaA = 0;


        //La neta no se como tan manejando lo de usuario
        //por eso lo puse estatico sorry xd

        public int fk_usuario = 1;

        public A_FrmArqCaj()
        {
            InitializeComponent();
            DesaparecerV2();
        }


        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            fechaB = FechaVenta.Value.ToString("yyyy-MM-dd");
            yearB = fechaB.Substring(0, 4);
            monthB = fechaB.Substring(6, 1);
            dayB = fechaB.Substring(8, 2);

            if (oCN_A.Revisar(yearB, monthB, dayB))
            {
                DtsCons = oCN_A.llenarTabla(yearB, monthB, dayB);
                DtGrdDetalAr.DataSource = DtsCons;
                Sumar();
            }
            else
            {
                MessageBox.Show("No hay datos para la fecha");
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DesaparecerV1();
            AparecerV2();
            txt1v2.Text = txtTotArC1.Text;
            txt1v2.ReadOnly = true;
            txt2v2.Focus();
        }
        public void DesaparecerV1()
        {
            btnRecuperar.Visible = false;
            DtGrdDetalAr.Visible = false;
            lbl1v1.Visible = false;
            txtTotArC1.Visible = false;
            btnSiguiente.Visible = false;
        }
        public void DesaparecerV2()
        {
            lbl1v2.Visible = false;
            lbl2v2.Visible = false;
            lbl3v2.Visible = false;
            lbl4v2.Visible = false;
            lbl5v2.Visible = false;
            lbl6v2.Visible = false;
            txt1v2.Visible = false;
            txt1v2.Enabled = false;
            txt2v2.Visible = false;
            txt2v2.Enabled = false;
            txt3v2.Visible = false;
            txt3v2.Enabled = false;
            txt4v2.Visible = false;
            txt4v2.Enabled = false;
            txt5v2.Visible = false;
            txt5v2.Enabled = false;
            txt6v2.Visible = false;
            txt6v2.Enabled = false;
            btnAtras.Enabled = false;
            btnAtras.Visible = false;
            btnGuardar.Visible = false;
            btnGuardar.Enabled = false;
            btnVerEdit.Enabled = false;
            btnVerEdit.Visible = false;
        }
        public void AparecerV1()
        {
            btnRecuperar.Visible = true;
            DtGrdDetalAr.Visible = true;
            lbl1v1.Visible = true;
            txtTotArC1.Visible = true;
            btnSiguiente.Visible = true;
        }
        public void AparecerV2()
        {
            lbl1v2.Visible = true;
            lbl2v2.Visible = true;
            lbl3v2.Visible = true;
            lbl4v2.Visible = true;
            lbl5v2.Visible = true;
            lbl6v2.Visible = true;
            txt1v2.Visible = true;
            txt1v2.Enabled = true;
            txt2v2.Visible = true;
            txt2v2.Enabled = true;
            txt3v2.Visible = true;
            txt3v2.Enabled = true;
            txt4v2.Visible = true;
            txt4v2.Enabled = true;
            txt5v2.Visible = true;
            txt5v2.Enabled = true;
            txt6v2.Visible = true;
            txt6v2.Enabled = true;
            btnAtras.Enabled = true;
            btnAtras.Visible = true;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            btnVerEdit.Enabled = true;
            btnVerEdit.Visible = true;
        }

        public void LimpiarV2()
        {
            txt1v2.Clear();
            txt2v2.Clear();
            txt3v2.Clear();
            txt4v2.Clear();
            txt5v2.Clear();
            txt6v2.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DesaparecerV2();
            AparecerV1();
            LimpiarV2();
        }

        public void Sumar()
        {
            int sumatoria = 0;

            foreach (DataGridViewRow row in DtGrdDetalAr.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells[3].Value);
            }
            txtTotArC1.Text = Convert.ToString(sumatoria);

        }

        private void txt2v2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(txt2v2.Text))
                {
                    Val2 = Convert.ToInt32(txt2v2.Text);
                }
                txt3v2.Focus();

            }
        }

        private void txt3v2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(txt3v2.Text))
                {
                    Val3 = Convert.ToInt32(txt3v2.Text);
                    sumaA = Val2 + Val3;
                    Val1 = Convert.ToInt32(txt1v2.Text);
                    restaA = sumaA - Val1;
                    txt6v2.Focus();
                }

                txt4v2.Text = Convert.ToString(sumaA);
                txt5v2.Text = Convert.ToString(restaA);
                if (restaA == 0)
                {
                    tipoArq = "EXACTO";
                    detalle = "";
                    fechaB = FechaVenta.Value.ToString("yyyy-MM-dd");
                    yearB = fechaB.Substring(0, 4);
                    monthB = fechaB.Substring(6, 1);
                    dayB = fechaB.Substring(8, 2);
                    Guardar(fk_usuario, yearB, monthB, dayB, restaA, tipoArq, detalle);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            fechaB = FechaVenta.Value.ToString("yyyy-MM-dd");
            yearB = fechaB.Substring(0, 4);
            monthB = fechaB.Substring(6, 1);
            dayB = fechaB.Substring(8, 2);
            string negativo = "-";
            string cadena = txt5v2.ToString();
            string cadenaAux;
            string cadenaAux2;
            bool contiene = cadena.Contains(negativo);
            if (contiene == true)
            {
                tipoArq = "FALTANTE";
                cadenaAux = txt5v2.Text;
                cadenaAux2 = cadenaAux.Substring(1);
                restaA = Convert.ToInt32(cadenaAux2);
                detalle = txt6v2.Text;
                Guardar(fk_usuario, yearB, monthB, dayB, restaA, tipoArq, detalle);
                LimpiarV2();
            }
            else
            {
                tipoArq = "EXCEDENTE";
                detalle = txt6v2.Text;
                Guardar(fk_usuario, yearB, monthB, dayB, restaA, tipoArq, detalle);
                LimpiarV2();
            }
        }
        public void Guardar(int fk_usuario, string yearB, string monthB, string dayB, int restaA, string tipoArq, string detalle)
        {
            if (oCN_A.Guardar(fk_usuario, yearB, monthB, dayB, restaA, tipoArq, detalle))
            {
                MessageBox.Show("Registro de tipo " + tipoArq + " guardado con exito");
                return;
            }
            else
            {
                MessageBox.Show("No se pudo guardar el detalle de tipo " + tipoArq + " arqueo");
            }
        }

        private void btnVerEdit_Click(object sender, EventArgs e)
        {
            Form fVista = new A_FrmArqCaj2();
            fVista.Show();
            fVista.Location = new Point(347, 174);
        }

        private void FrmArqCaj_Load(object sender, EventArgs e)
        {

        }
    }
}
