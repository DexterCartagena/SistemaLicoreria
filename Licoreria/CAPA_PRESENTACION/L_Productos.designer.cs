namespace CAPA_PRESENTACION
{
    partial class L_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btneliminarReg = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Detalle = new System.Windows.Forms.RichTextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_PrecioCosto = new System.Windows.Forms.TextBox();
            this.txt_PrecioVenta = new System.Windows.Forms.TextBox();
            this.txt_PrecioHistorico = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.epCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecioc = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecioh = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPreciov = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDetalle = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPreciov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtImg);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.pbImagen);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnSeleccion);
            this.panel3.Location = new System.Drawing.Point(426, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 304);
            this.panel3.TabIndex = 27;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(14, 11);
            this.txtImg.Margin = new System.Windows.Forms.Padding(2);
            this.txtImg.Name = "txtImg";
            this.txtImg.ReadOnly = true;
            this.txtImg.Size = new System.Drawing.Size(134, 20);
            this.txtImg.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(130, 271);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 27);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button5_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(14, 30);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(340, 237);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(230, 271);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 27);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccion.Location = new System.Drawing.Point(35, 271);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(69, 27);
            this.btnSeleccion.TabIndex = 7;
            this.btnSeleccion.Text = "Seleccionar ";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btneliminarReg);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(20, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 79);
            this.panel2.TabIndex = 26;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(107, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btneliminarReg
            // 
            this.btneliminarReg.BackColor = System.Drawing.Color.FloralWhite;
            this.btneliminarReg.Enabled = false;
            this.btneliminarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarReg.Location = new System.Drawing.Point(202, 23);
            this.btneliminarReg.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminarReg.Name = "btneliminarReg";
            this.btneliminarReg.Size = new System.Drawing.Size(74, 35);
            this.btneliminarReg.TabIndex = 18;
            this.btneliminarReg.Text = "Eliminar ";
            this.btneliminarReg.UseVisualStyleBackColor = false;
            this.btneliminarReg.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(298, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 35);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FloralWhite;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(11, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Buscar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_Detalle);
            this.panel1.Controls.Add(this.txt_Cantidad);
            this.panel1.Controls.Add(this.txt_PrecioCosto);
            this.panel1.Controls.Add(this.txt_PrecioVenta);
            this.panel1.Controls.Add(this.txt_PrecioHistorico);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 321);
            this.panel1.TabIndex = 25;
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Location = new System.Drawing.Point(151, 223);
            this.txt_Detalle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(221, 78);
            this.txt_Detalle.TabIndex = 20;
            this.txt_Detalle.Text = "";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(151, 50);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(78, 20);
            this.txt_Cantidad.TabIndex = 13;
            // 
            // txt_PrecioCosto
            // 
            this.txt_PrecioCosto.Location = new System.Drawing.Point(151, 98);
            this.txt_PrecioCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioCosto.Name = "txt_PrecioCosto";
            this.txt_PrecioCosto.Size = new System.Drawing.Size(111, 20);
            this.txt_PrecioCosto.TabIndex = 12;
            // 
            // txt_PrecioVenta
            // 
            this.txt_PrecioVenta.Location = new System.Drawing.Point(151, 143);
            this.txt_PrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioVenta.Name = "txt_PrecioVenta";
            this.txt_PrecioVenta.Size = new System.Drawing.Size(111, 20);
            this.txt_PrecioVenta.TabIndex = 11;
            // 
            // txt_PrecioHistorico
            // 
            this.txt_PrecioHistorico.Location = new System.Drawing.Point(151, 181);
            this.txt_PrecioHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioHistorico.Name = "txt_PrecioHistorico";
            this.txt_PrecioHistorico.Size = new System.Drawing.Size(111, 20);
            this.txt_PrecioHistorico.TabIndex = 10;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(151, 10);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(78, 20);
            this.txtCod.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio historico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(426, 334);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(372, 94);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 28;
            this.pbLogo.TabStop = false;
            // 
            // epCodigo
            // 
            this.epCodigo.ContainerControl = this;
            // 
            // epCantidad
            // 
            this.epCantidad.ContainerControl = this;
            // 
            // epPrecioc
            // 
            this.epPrecioc.ContainerControl = this;
            // 
            // epPrecioh
            // 
            this.epPrecioh.ContainerControl = this;
            // 
            // epPreciov
            // 
            this.epPreciov.ContainerControl = this;
            // 
            // epDetalle
            // 
            this.epDetalle.ContainerControl = this;
            // 
            // L_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "L_Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPreciov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btneliminarReg;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txt_Detalle;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_PrecioCosto;
        private System.Windows.Forms.TextBox txt_PrecioVenta;
        private System.Windows.Forms.TextBox txt_PrecioHistorico;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.ErrorProvider epCodigo;
        private System.Windows.Forms.ErrorProvider epCantidad;
        private System.Windows.Forms.ErrorProvider epPrecioc;
        private System.Windows.Forms.ErrorProvider epPrecioh;
        private System.Windows.Forms.ErrorProvider epPreciov;
        private System.Windows.Forms.ErrorProvider epDetalle;
    }
}