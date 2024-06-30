using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace CAPA_PRESENTACION
{
    public partial class A_Principal : Form
    {
        //public A_Principal()
        //{
        //    InitializeComponent();
        //}

        private void A_Principal_Load(object sender, EventArgs e)
        {
           
        }
        ///////////////////////////////////////////////
        public string estado = "nor";
        public bool movible = false;
        private IconButton btns;
        private Panel panelBtn;
        private Form FormSec;

        public A_Principal()
        {
            InitializeComponent();
            panelBtn = new Panel();
            panelBtn.Size = new Size(7, 35);
            Navegacion.Controls.Add(panelBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_Tam_Click(object sender, EventArgs e)
        {

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
            Cerrar.Location = new Point(640, 26);
            Min_Tam.Location = new Point(604, 26);
            Minimizar.Location = new Point(579, 26);
            Navegacion.Size = MaximumSize;
            Navegacion.Location = new Point(15, 15);
            estado = "mod";
        }
        private void MinTam()
        {
            WindowState = FormWindowState.Normal;
            Cerrar.Location = new Point(596, 23);
            Min_Tam.Location = new Point(560, 23);
            Minimizar.Location = new Point(525, 23);
            estado = "nor";
        }

        public void MENU_MouseDown(object sender, MouseEventArgs e)
        {
            movible = true;
        }

        public void MENU_MouseMove(object sender, MouseEventArgs e)
        {
            if (movible == true)
            {
                this.Location = Cursor.Position;
            }
        }

        public void MENU_MouseUp(object sender, MouseEventArgs e)
        {
            movible = false;
        }
        private void BotonAct(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BotonDesact();

                btns = (IconButton)senderBtn;
                btns.BackColor = Color.Maroon;
                btns.ForeColor = color;
                btns.TextAlign = ContentAlignment.MiddleCenter;
                btns.IconColor = color;
                btns.TextImageRelation = TextImageRelation.TextBeforeImage;
                btns.ImageAlign = ContentAlignment.MiddleRight;
                btns.BackColor = Color.AntiqueWhite;
                panelBtn.BackColor = color;
                panelBtn.Location = new Point(0, btns.Location.Y);
                panelBtn.Visible = true;
                panelBtn.BringToFront();
            }
        }
        private void BotonDesact()
        {
            if (btns != null)
            {
                btns.BackColor = Color.FromArgb(31, 30, 68);
                btns.ForeColor = Color.SaddleBrown;
                btns.TextAlign = ContentAlignment.MiddleLeft;
                btns.IconColor = Color.SaddleBrown;
                btns.TextImageRelation = TextImageRelation.ImageBeforeText;
                btns.ImageAlign = ContentAlignment.MiddleLeft;
                btns.BackColor = Color.AntiqueWhite;
            }
        }
        private void Fun1_Click(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new G_venats());
        }

        private void Fun2_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new Compras());
        }

        private void Fun3_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new L_Productos());
        }

        private void Fun4_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new Stock());
        }

        private void Fun5_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new D_Cliente());
        }

        private void Fun6_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new Usuario());
        }

        private void Fun7_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new Reportes());
        }

        private void Fun8_Click_1(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new A_FrmArqCaj());
        }
        private void AbrirFormSec(Form childForm)
        {

            if (FormSec != null)
            {
                FormSec.Close();
            }
            FormSec = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DispFormSec.Visible = true;
            DispFormSec.Controls.Add(childForm);
            DispFormSec.Tag = childForm;
            picBox.SendToBack();
            panel3.SendToBack();
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {

            if (FormSec != null)
            {
                FormSec.Close();
            }
            Inicio();
        }
        private void Inicio()
        {
            BotonDesact();
            panelBtn.Visible = false;
            picBox.BringToFront();
            panel3.BringToFront();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DispFormSec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void Min_Tam_Click_1(object sender, EventArgs e)
        {

        }

        private void DispFormSec_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new D_Plataforma());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            BotonAct(sender, Color.Maroon);
            AbrirFormSec(new L_Pedidos());
        }

        private void pnCabeza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// /////////////////
        /// </summary>
        ///

    }
}
