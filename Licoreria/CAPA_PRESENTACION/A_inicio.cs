using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class A_inicio : Form
    {
        public A_inicio()
        {
            InitializeComponent();
        }

        private void A_inicio_Load(object sender, EventArgs e)
        {
        
        }

        public string estado = "nor";
        public bool movible = false;
        //public Present()
        //{
        //    InitializeComponent();
        //}

        private void Cerrar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Min_Tam_Click(object sender, EventArgs e)
        {
            //La neta me olvide del principio de "si funciona no lo toques
            //tonces ya no centra la ventana max y ya no se lo puede mover
            //tras maximizar si tu puedes pues yei
            //si no eliminalo o io que se por eso lo deshabilite al boton xd
            if (estado == "nor")
            {
                MaxTam();
                this.CenterToScreen();
            }
            else if (estado == "mod")
            {
                MinTam();
                this.CenterToScreen();
            }

        }


        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MaxTam()
        {
            WindowState = FormWindowState.Maximized;
            Margen.Location = new Point(15, 15);
            Margen.Size = MaximumSize;
            Cerrar.Location = new Point(640, 26);
            Min_Tam.Location = new Point(604, 26);
            Minimizar.Location = new Point(579, 26);
            estado = "mod";
        }
        private void MinTam()
        {
            WindowState = FormWindowState.Normal;
            Margen.Location = new Point(12, 12);
            Margen.Size = MinimumSize;
            Cerrar.Location = new Point(596, 23);
            Min_Tam.Location = new Point(560, 23);
            Minimizar.Location = new Point(525, 23);
            estado = "nor";
        }

        private void Acceso_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
            }
            //Form fAcceso = new Form2();
            //fAcceso.Show();
            //fAcceso.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Present_MouseDown(object sender, MouseEventArgs e)
        {
            movible = true;
        }

        private void Present_MouseMove(object sender, MouseEventArgs e)
        {
            if (movible == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void Present_MouseUp(object sender, MouseEventArgs e)
        {
            movible = false;
        }

        private void Present_Load(object sender, EventArgs e)
        {

        }
    }
}
