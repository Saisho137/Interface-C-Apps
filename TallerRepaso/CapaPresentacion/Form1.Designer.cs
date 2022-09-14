namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbIngresos = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre (s): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresos Mensuales: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Solicitado: ";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(97, 37);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(258, 23);
            this.tbDocumento.TabIndex = 5;
            this.tbDocumento.TextChanged += new System.EventHandler(this.tbDocumento_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(97, 76);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(258, 23);
            this.tbNombre.TabIndex = 6;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(97, 114);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(258, 23);
            this.tbApellidos.TabIndex = 7;
            // 
            // tbIngresos
            // 
            this.tbIngresos.Location = new System.Drawing.Point(142, 151);
            this.tbIngresos.Name = "tbIngresos";
            this.tbIngresos.Size = new System.Drawing.Size(213, 23);
            this.tbIngresos.TabIndex = 8;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(142, 192);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(213, 23);
            this.tbMonto.TabIndex = 9;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(155, 249);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(94, 37);
            this.btConfirmar.TabIndex = 10;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 317);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.tbIngresos);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prestamo Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbDocumento;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbIngresos;
        private TextBox tbMonto;
        private Button btConfirmar;
    }
}