namespace CapaInterfaz
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
            this.label6 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbFechaNacimiento = new System.Windows.Forms.TextBox();
            this.tbIngresos = new System.Windows.Forms.TextBox();
            this.tbEgresos = new System.Windows.Forms.TextBox();
            this.tbPrestamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresos Mensuales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Egresos Mensuales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prestamo Solicitado:";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(160, 286);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(100, 32);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(65, 43);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(315, 23);
            this.tbCedula.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(128, 76);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(252, 23);
            this.tbNombre.TabIndex = 8;
            // 
            // tbFechaNacimiento
            // 
            this.tbFechaNacimiento.Location = new System.Drawing.Point(140, 110);
            this.tbFechaNacimiento.Name = "tbFechaNacimiento";
            this.tbFechaNacimiento.Size = new System.Drawing.Size(240, 23);
            this.tbFechaNacimiento.TabIndex = 9;
            // 
            // tbIngresos
            // 
            this.tbIngresos.Location = new System.Drawing.Point(131, 146);
            this.tbIngresos.Name = "tbIngresos";
            this.tbIngresos.Size = new System.Drawing.Size(249, 23);
            this.tbIngresos.TabIndex = 10;
            // 
            // tbEgresos
            // 
            this.tbEgresos.Location = new System.Drawing.Point(127, 185);
            this.tbEgresos.Name = "tbEgresos";
            this.tbEgresos.Size = new System.Drawing.Size(253, 23);
            this.tbEgresos.TabIndex = 11;
            // 
            // tbPrestamo
            // 
            this.tbPrestamo.Location = new System.Drawing.Point(133, 223);
            this.tbPrestamo.Name = "tbPrestamo";
            this.tbPrestamo.Size = new System.Drawing.Size(247, 23);
            this.tbPrestamo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 356);
            this.Controls.Add(this.tbPrestamo);
            this.Controls.Add(this.tbEgresos);
            this.Controls.Add(this.tbIngresos);
            this.Controls.Add(this.tbFechaNacimiento);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btConfirm;
        private TextBox tbCedula;
        private TextBox tbNombre;
        private TextBox tbFechaNacimiento;
        private TextBox tbIngresos;
        private TextBox tbEgresos;
        private TextBox tbPrestamo;
    }
}