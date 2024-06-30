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
    public partial class A_FrmArqCaj2 : Form
    {
        //public A_FrmArqCaj2()
        //{
        //    InitializeComponent();
        //}

        private void A_FrmArqCaj2_Load(object sender, EventArgs e)
        {

        }
        CN_A oCN_A = new CN_A();
        public string fechaB;
        DataTable DtsCons = new DataTable();
        public string fechaAux;
        public int yearB;
        public int monthB;
        public string detalle;
        public int codARQ;
        public int codAux;
        public string estado;
        public A_FrmArqCaj2()
        {
            InitializeComponent();
            txt1A2Mes.Visible = false;
            txt2Arq2Year.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            txt4Ar2Deta.Enabled = false;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (txt1A2Mes.Text.Length != 0)
            {
                verificarNum1();
                if (oCN_A.Revisar2(monthB))
                {
                    DtsCons = oCN_A.llenarTabla2(monthB);
                    DtGrdDetalAr2.DataSource = DtsCons;
                }
                else
                {
                    MessageBox.Show("No hay datos para la fecha");
                }
            }
            if (txt2Arq2Year.Text.Length != 0)
            {
                verificarNum2();
                if (oCN_A.Revisar3(yearB))
                {
                    DtsCons = oCN_A.llenarTabla3(yearB);
                    DtGrdDetalAr2.DataSource = DtsCons;
                }
                else
                {
                    MessageBox.Show("No hay datos para la fecha");
                }
            }
            txt3Ar2Cod.Focus();
        }

        public void chkMes_CheckedChanged(object sender, EventArgs e)
        {
            chkAño.Checked = false;
            if (chkMes.Checked == true)
            {
                txt2Arq2Year.Visible = false;
                label3.Visible = false;
                txt2Arq2Year.Enabled = false;
                txt1A2Mes.Visible = true;
                txt1A2Mes.Enabled = true;
                label1.Visible = true;
                txt1A2Mes.Focus();
            }
        }

        public void chkAño_CheckedChanged(object sender, EventArgs e)
        {
            chkMes.Checked = false;
            if (chkAño.Checked == true)
            {
                txt1A2Mes.Visible = false;
                label1.Visible = false;
                txt1A2Mes.Enabled = false;
                txt2Arq2Year.Visible = true;
                txt2Arq2Year.Enabled = true;
                label3.Visible = true;
                txt2Arq2Year.Focus();
            }
        }


        private void btnSi_Click(object sender, EventArgs e)
        {
            txt4Ar2Deta.Enabled = true;
            detalle = txt4Ar2Deta.Text;
            DtGrdDetalAr2.DataSource = null;
            DtGrdDetalAr2.Rows.Clear();
            txt4Ar2Deta.Focus();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnActualizar.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            verificarNum3();
            if (codARQ >= 0)
            {
                oCN_A.Actualizar1(codARQ);
            }
            else
            {
                MessageBox.Show("No hay existe registro para actualizar");
            }
            btnSi.Focus();
        }




        public bool verificarNum1()
        {
            if (!(Int32.TryParse(txt1A2Mes.ToString(), out codAux)))
            {
                monthB = Convert.ToInt32(txt1A2Mes.Text);
                btnRecuperar.Focus();
                return false;
            }
            else
            {
                MessageBox.Show("Solo se permite numeros");
                return true;
            }

        }
        public bool verificarNum2()
        {
            if (!(Int32.TryParse(txt2Arq2Year.ToString(), out codAux)))
            {
                yearB = Convert.ToInt32(txt2Arq2Year.Text);
                btnRecuperar.Focus();
                return false;
            }
            else
            {
                MessageBox.Show("Solo se permite numeros");
                return true;
            }

        }
        public bool verificarNum3()
        {
            if (!(Int32.TryParse(txt3Ar2Cod.ToString(), out codAux)))
            {
                codARQ = Convert.ToInt32(txt3Ar2Cod.Text);
                return false;
            }
            else
            {
                MessageBox.Show("Solo se permite numeros");
                return true;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            detalle = txt4Ar2Deta.Text;
            if (codARQ >= 0)
            {
                oCN_A.Actualizar2(detalle, codARQ);
                DtGrdDetalAr2.Refresh();
                DtsCons = oCN_A.llenarTabla4(codARQ);
                DtGrdDetalAr2.DataSource = DtsCons;
            }
            else
            {
                MessageBox.Show("No existe registro para actualizar");
            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {

            txt1A2Mes.Clear();
            txt2Arq2Year.Clear();
            txt3Ar2Cod.Clear();
            txt4Ar2Deta.Clear();
            txt4Ar2Deta.Enabled = false;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form fVista2 = new A_FrmArqCaj();
            fVista2.Show();
            fVista2.Location = new Point(347, 174);
        }

        private void FrmArqCaj2_Load(object sender, EventArgs e)
        {

        }
    }
}
