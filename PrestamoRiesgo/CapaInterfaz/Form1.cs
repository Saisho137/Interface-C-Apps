using CapaNegocio;

namespace CapaInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Credito prestamo = new Credito();
            //
            bool confirm = prestamo.aceptarCredito( 
                int.Parse(tbCedula.Text), 
                prestamo.capacidadEndeudamiento( int.Parse( tbIngresos.Text ), int.Parse( tbEgresos.Text ) ),
                prestamo.edadUsuario( DateTime.Parse(tbFechaNacimiento.Text) ),
                int.Parse(tbPrestamo.Text)
                );
            if (confirm)
            {
                MessageBox.Show("El Credito ha sido aprobado");
            }
            else
            {
                MessageBox.Show("No es posible aceptar su credito");
            }
            //
            tbCedula.Text = "";
            tbNombre.Text = "";
            tbFechaNacimiento.Text = "";
            tbIngresos.Text = "";
            tbEgresos.Text = "";
            tbPrestamo.Text = "";
        }
    }
}