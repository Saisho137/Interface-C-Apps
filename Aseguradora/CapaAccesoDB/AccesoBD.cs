using System.Data.SqlClient;

namespace CapaAccesoDB
{
    public class AccesoBD
    {
        private SqlConnection conexion;
        public AccesoBD()
        {
            this.conexion = new SqlConnection(@"Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=AseguradoraVehiculos;Data Source=SANTIAGOPC\SQLEXPRESS");
        }

        public bool crearRegistro(string Placa, int Modelo, int Kilometraje, int Peritraje, string Asegurable)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO Seguros_Vehiculos VALUES ('{0}','{1}','{2}','{3}','{4}')",
                Placa, Modelo, Kilometraje, Peritraje, Asegurable);

            SqlCommand comando = new SqlCommand(insert, conexion);

            int rows = comando.ExecuteNonQuery();

            conexion.Close();

            return rows > 0;
        }
    }
}