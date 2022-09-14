using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Asegurable asegurable = new Asegurable();
                bool confirm = asegurable.aceptarSeguro(tbPlaca.Text, int.Parse(tbModelo.Text), int.Parse(tbKilo.Text), int.Parse(cbPeri.Text));
                //
                if (confirm)
                {
                    MessageBox.Show("Su Vehiculo es Asegurable!");
                    asegurable.registrarSeguro(tbPlaca.Text, int.Parse(tbModelo.Text), int.Parse(tbKilo.Text), int.Parse(cbPeri.Text), "True");
                    MessageBox.Show("Se ha registrado la Consulta en el historial.");
                    //
                    tbPlaca.Text = "";
                    tbModelo.Text = "";
                    tbKilo.Text = "";
                    cbPeri.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No es posible Asegurar su Vehiculo :(");
                    asegurable.registrarSeguro(tbPlaca.Text, int.Parse(tbModelo.Text), int.Parse(tbKilo.Text), int.Parse(cbPeri.Text), "False");
                    MessageBox.Show("Se ha registrado la Consulta en el historial.");
                    //
                    tbPlaca.Text = "";
                    tbModelo.Text = "";
                    tbKilo.Text = "";
                    cbPeri.SelectedIndex = -1;
                }
            } catch (FormatException)
            {
                MessageBox.Show("Revise los datos e inténtelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Revise los datos e inténtelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}