using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Impuesto impuesto = new Impuesto();
            double result = impuesto.valorFinal(cbTipo.Text, int.Parse(tbValor.Text));
            MessageBox.Show("El valor total es de: " + result);
            //
            tbNombre.Text = "";
            cbTipo.Text = " ";
            tbValor.Text = "";
        }
    }
}