using System;

namespace CAPA_PRESENTACION
{
    partial class G_venats
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.agregarP = new System.Windows.Forms.PictureBox();
            this.personaBuscar = new System.Windows.Forms.PictureBox();
            this.buscarP = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtbHora = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCOD = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.numeroUp = new System.Windows.Forms.NumericUpDown();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.dgv_grilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.erProd = new System.Windows.Forms.ErrorProvider(this.components);
            this.erCant = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agregarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(236, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 24);
            this.label16.TabIndex = 66;
            this.label16.Text = "DETALLES DE LA VENTA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(236, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 24);
            this.label15.TabIndex = 65;
            this.label15.Text = "DATOS DEL CLIENTE";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Coral;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(707, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(614, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(518, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // agregarP
            // 
            this.agregarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarP.Location = new System.Drawing.Point(725, 180);
            this.agregarP.Name = "agregarP";
            this.agregarP.Size = new System.Drawing.Size(20, 21);
            this.agregarP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agregarP.TabIndex = 61;
            this.agregarP.TabStop = false;
            this.agregarP.Click += new System.EventHandler(this.agregarP_Click);
            // 
            // personaBuscar
            // 
            this.personaBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personaBuscar.Location = new System.Drawing.Point(614, 88);
            this.personaBuscar.Name = "personaBuscar";
            this.personaBuscar.Size = new System.Drawing.Size(23, 26);
            this.personaBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personaBuscar.TabIndex = 60;
            this.personaBuscar.TabStop = false;
            this.personaBuscar.Click += new System.EventHandler(this.personaBuscar_Click);
            // 
            // buscarP
            // 
            this.buscarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarP.Location = new System.Drawing.Point(684, 180);
            this.buscarP.Name = "buscarP";
            this.buscarP.Size = new System.Drawing.Size(20, 21);
            this.buscarP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscarP.TabIndex = 59;
            this.buscarP.TabStop = false;
            this.buscarP.Click += new System.EventHandler(this.buscarP_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(536, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "CI/NIT";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCliente.Location = new System.Drawing.Point(351, 94);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 20);
            this.txtCliente.TabIndex = 56;
            // 
            // txtCodCli
            // 
            this.txtCodCli.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodCli.Location = new System.Drawing.Point(240, 94);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(86, 20);
            this.txtCodCli.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PeachPuff;
            this.label12.Location = new System.Drawing.Point(21, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "NIT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PeachPuff;
            this.label11.Location = new System.Drawing.Point(21, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(21, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fecha";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblNit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(69, 364);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(51, 15);
            this.lblNit.TabIndex = 51;
            this.lblNit.Text = "000000";
            // 
            // txtbHora
            // 
            this.txtbHora.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbHora.Location = new System.Drawing.Point(69, 322);
            this.txtbHora.Name = "txtbHora";
            this.txtbHora.Size = new System.Drawing.Size(84, 20);
            this.txtbHora.TabIndex = 50;
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Fecha.Location = new System.Drawing.Point(69, 285);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(84, 20);
            this.Fecha.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(21, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "COD";
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblCOD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOD.Location = new System.Drawing.Point(69, 227);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(23, 15);
            this.lblCOD.TabIndex = 47;
            this.lblCOD.Text = "02";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 194);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(177, 15);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Gustavo Andres Velasco Cruz";
            // 
            // numeroUp
            // 
            this.numeroUp.Location = new System.Drawing.Point(518, 181);
            this.numeroUp.Name = "numeroUp";
            this.numeroUp.Size = new System.Drawing.Size(57, 20);
            this.numeroUp.TabIndex = 45;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblPuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(24, 163);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(51, 17);
            this.lblPuesto.TabIndex = 44;
            this.lblPuesto.Text = "Cajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPrecio.Location = new System.Drawing.Point(592, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(56, 20);
            this.txtPrecio.TabIndex = 40;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDetalle.Location = new System.Drawing.Point(305, 181);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(181, 20);
            this.txtDetalle.TabIndex = 39;
            // 
            // dgv_grilla
            // 
            this.dgv_grilla.AllowUserToAddRows = false;
            this.dgv_grilla.AllowUserToDeleteRows = false;
            this.dgv_grilla.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgv_grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dgv_grilla.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_grilla.Location = new System.Drawing.Point(240, 227);
            this.dgv_grilla.Name = "dgv_grilla";
            this.dgv_grilla.ReadOnly = true;
            this.dgv_grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grilla.Size = new System.Drawing.Size(541, 121);
            this.dgv_grilla.TabIndex = 38;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio ud.";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cod.";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodProd.Location = new System.Drawing.Point(240, 181);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(50, 20);
            this.txtCodProd.TabIndex = 36;
            // 
            // logoImg
            // 
            this.logoImg.BackColor = System.Drawing.Color.PeachPuff;
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoImg.Location = new System.Drawing.Point(24, 41);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(163, 82);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 35;
            this.logoImg.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Location = new System.Drawing.Point(1, -26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 454);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Total.Location = new System.Drawing.Point(684, 359);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(97, 20);
            this.Total.TabIndex = 68;
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(641, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "Total";
            // 
            // erProd
            // 
            this.erProd.ContainerControl = this;
            // 
            // erCant
            // 
            this.erCant.ContainerControl = this;
            // 
            // erPrecio
            // 
            this.erPrecio.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 372);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 70;
            this.button1.Text = "VER REGISTROS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // G_venats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(805, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.agregarP);
            this.Controls.Add(this.personaBuscar);
            this.Controls.Add(this.buscarP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.txtbHora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCOD);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.numeroUp);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.dgv_grilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.pictureBox2);
            this.Name = "G_venats";
            this.Text = "venats";
            this.Load += new System.EventHandler(this.venats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agregarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox agregarP;
        private System.Windows.Forms.PictureBox personaBuscar;
        private System.Windows.Forms.PictureBox buscarP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtbHora;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCOD;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_grilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.NumericUpDown numeroUp;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtDetalle;
        public System.Windows.Forms.TextBox txtCodProd;
        public System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider erProd;
        private System.Windows.Forms.ErrorProvider erCant;
        private System.Windows.Forms.ErrorProvider erPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button button1;
    }
}