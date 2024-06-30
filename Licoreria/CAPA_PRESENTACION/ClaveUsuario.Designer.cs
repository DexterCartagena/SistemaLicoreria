
namespace CAPA_PRESENTACION
{
    partial class ClaveUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmacion1 = new System.Windows.Forms.TextBox();
            this.txtconfirmacion2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.epPas1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPas2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPas2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtConfirmacion1
            // 
            this.txtConfirmacion1.Location = new System.Drawing.Point(103, 27);
            this.txtConfirmacion1.Name = "txtConfirmacion1";
            this.txtConfirmacion1.PasswordChar = '*';
            this.txtConfirmacion1.Size = new System.Drawing.Size(161, 20);
            this.txtConfirmacion1.TabIndex = 2;
            // 
            // txtconfirmacion2
            // 
            this.txtconfirmacion2.Location = new System.Drawing.Point(103, 53);
            this.txtconfirmacion2.Name = "txtconfirmacion2";
            this.txtconfirmacion2.PasswordChar = '*';
            this.txtconfirmacion2.Size = new System.Drawing.Size(161, 20);
            this.txtconfirmacion2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epPas1
            // 
            this.epPas1.ContainerControl = this;
            // 
            // epPas2
            // 
            this.epPas2.ContainerControl = this;
            // 
            // ClaveUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(354, 115);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtconfirmacion2);
            this.Controls.Add(this.txtConfirmacion1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(370, 154);
            this.MinimumSize = new System.Drawing.Size(370, 154);
            this.Name = "ClaveUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Password";
            ((System.ComponentModel.ISupportInitialize)(this.epPas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtConfirmacion1;
        public System.Windows.Forms.TextBox txtconfirmacion2;
        private System.Windows.Forms.ErrorProvider epPas1;
        private System.Windows.Forms.ErrorProvider epPas2;
    }
}