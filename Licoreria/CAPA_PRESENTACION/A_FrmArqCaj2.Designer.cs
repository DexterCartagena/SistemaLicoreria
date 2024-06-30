
namespace CAPA_PRESENTACION
{
    partial class A_FrmArqCaj2
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txt4Ar2Deta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1A2Mes = new System.Windows.Forms.TextBox();
            this.txt3Ar2Cod = new System.Windows.Forms.TextBox();
            this.txt2Arq2Year = new System.Windows.Forms.TextBox();
            this.chkAño = new System.Windows.Forms.CheckBox();
            this.chkMes = new System.Windows.Forms.CheckBox();
            this.lbl6v2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.DtGrdDetalAr2 = new System.Windows.Forms.DataGridView();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdDetalAr2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.Location = new System.Drawing.Point(197, 404);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(87, 23);
            this.btnRetornar.TabIndex = 94;
            this.btnRetornar.Text = "RETORNAR";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(352, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 93;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 92;
            this.label5.Text = "Nuevo detalle";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(516, 404);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 91;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txt4Ar2Deta
            // 
            this.txt4Ar2Deta.Location = new System.Drawing.Point(320, 371);
            this.txt4Ar2Deta.Name = "txt4Ar2Deta";
            this.txt4Ar2Deta.Size = new System.Drawing.Size(290, 20);
            this.txt4Ar2Deta.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 27);
            this.label4.TabIndex = 89;
            this.label4.Text = "¿Desea cambiar el detalle?";
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(444, 342);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(45, 23);
            this.btnNo.TabIndex = 88;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(389, 342);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(50, 23);
            this.btnSi.TabIndex = 87;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Digita el año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Digita el mes";
            // 
            // txt1A2Mes
            // 
            this.txt1A2Mes.Location = new System.Drawing.Point(389, 92);
            this.txt1A2Mes.MaxLength = 2;
            this.txt1A2Mes.Name = "txt1A2Mes";
            this.txt1A2Mes.Size = new System.Drawing.Size(100, 20);
            this.txt1A2Mes.TabIndex = 84;
            // 
            // txt3Ar2Cod
            // 
            this.txt3Ar2Cod.Location = new System.Drawing.Point(389, 316);
            this.txt3Ar2Cod.MaxLength = 10;
            this.txt3Ar2Cod.Name = "txt3Ar2Cod";
            this.txt3Ar2Cod.Size = new System.Drawing.Size(100, 20);
            this.txt3Ar2Cod.TabIndex = 83;
            // 
            // txt2Arq2Year
            // 
            this.txt2Arq2Year.Location = new System.Drawing.Point(389, 92);
            this.txt2Arq2Year.MaxLength = 4;
            this.txt2Arq2Year.Name = "txt2Arq2Year";
            this.txt2Arq2Year.Size = new System.Drawing.Size(100, 20);
            this.txt2Arq2Year.TabIndex = 82;
            // 
            // chkAño
            // 
            this.chkAño.AutoSize = true;
            this.chkAño.Location = new System.Drawing.Point(258, 101);
            this.chkAño.Name = "chkAño";
            this.chkAño.Size = new System.Drawing.Size(49, 17);
            this.chkAño.TabIndex = 81;
            this.chkAño.Text = "AÑO";
            this.chkAño.UseVisualStyleBackColor = true;
            // 
            // chkMes
            // 
            this.chkMes.AutoSize = true;
            this.chkMes.Location = new System.Drawing.Point(258, 78);
            this.chkMes.Name = "chkMes";
            this.chkMes.Size = new System.Drawing.Size(49, 17);
            this.chkMes.TabIndex = 80;
            this.chkMes.Text = "MES";
            this.chkMes.UseVisualStyleBackColor = true;
            // 
            // lbl6v2
            // 
            this.lbl6v2.AutoSize = true;
            this.lbl6v2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6v2.Location = new System.Drawing.Point(204, 313);
            this.lbl6v2.Name = "lbl6v2";
            this.lbl6v2.Size = new System.Drawing.Size(183, 27);
            this.lbl6v2.TabIndex = 79;
            this.lbl6v2.Text = "Digite el codigo a actualizar";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(516, 315);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(97, 23);
            this.btnIngresar.TabIndex = 78;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // DtGrdDetalAr2
            // 
            this.DtGrdDetalAr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdDetalAr2.Location = new System.Drawing.Point(209, 127);
            this.DtGrdDetalAr2.Name = "DtGrdDetalAr2";
            this.DtGrdDetalAr2.Size = new System.Drawing.Size(404, 172);
            this.DtGrdDetalAr2.TabIndex = 77;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(516, 89);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(94, 21);
            this.btnRecuperar.TabIndex = 76;
            this.btnRecuperar.Text = "RECUPERAR";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 45);
            this.label2.TabIndex = 75;
            this.label2.Text = "Arqueo de Caja (Actualizar)";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(183, 25);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 59);
            this.iconButton1.TabIndex = 74;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // A_FrmArqCaj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txt4Ar2Deta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1A2Mes);
            this.Controls.Add(this.txt3Ar2Cod);
            this.Controls.Add(this.txt2Arq2Year);
            this.Controls.Add(this.chkAño);
            this.Controls.Add(this.chkMes);
            this.Controls.Add(this.lbl6v2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.DtGrdDetalAr2);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_FrmArqCaj2";
            this.Text = "A_FrmArqCaj2";
            this.Load += new System.EventHandler(this.A_FrmArqCaj2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdDetalAr2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txt4Ar2Deta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1A2Mes;
        private System.Windows.Forms.TextBox txt3Ar2Cod;
        private System.Windows.Forms.TextBox txt2Arq2Year;
        private System.Windows.Forms.CheckBox chkAño;
        private System.Windows.Forms.CheckBox chkMes;
        private System.Windows.Forms.Label lbl6v2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView DtGrdDetalAr2;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}