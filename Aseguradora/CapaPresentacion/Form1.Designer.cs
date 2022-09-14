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
            this.btConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbKilo = new System.Windows.Forms.TextBox();
            this.cbPeri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(166, 241);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 0;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kilometraje: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peritraje: ";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(83, 43);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(279, 23);
            this.tbPlaca.TabIndex = 5;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(96, 77);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(266, 23);
            this.tbModelo.TabIndex = 6;
            // 
            // tbKilo
            // 
            this.tbKilo.Location = new System.Drawing.Point(115, 126);
            this.tbKilo.Name = "tbKilo";
            this.tbKilo.Size = new System.Drawing.Size(247, 23);
            this.tbKilo.TabIndex = 7;
            // 
            // cbPeri
            // 
            this.cbPeri.FormattingEnabled = true;
            this.cbPeri.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPeri.Location = new System.Drawing.Point(98, 174);
            this.cbPeri.Name = "cbPeri";
            this.cbPeri.Size = new System.Drawing.Size(264, 23);
            this.cbPeri.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 292);
            this.Controls.Add(this.cbPeri);
            this.Controls.Add(this.tbKilo);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbPlaca;
        private TextBox tbModelo;
        private TextBox tbKilo;
        private ComboBox cbPeri;
    }
}