using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            //
            bool confirm = prestamo.aceptarPrestamo( int.Parse(tbDocumento.Text), int.Parse(tbIngresos.Text),
                int.Parse(tbMonto.Text) );
            if (confirm)
            {
                MessageBox.Show("El prestamo ha sido aprobado");
                //
                bool resultdo = prestamo.registrarPrestamo(int.Parse(tbDocumento.Text), tbNombre.Text,
                tbApellidos.Text, int.Parse(tbMonto.Text));
                if (resultdo)
                {
                    MessageBox.Show("Se ha guardado el prestamo");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                //
                tbDocumento.Text = "";
                tbNombre.Text = "";
                tbApellidos.Text = "";
                tbIngresos.Text = "";
                tbMonto.Text = "";
            } else
            {
                MessageBox.Show("No es posible aceptar sus creditos");
            }
            //
        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}