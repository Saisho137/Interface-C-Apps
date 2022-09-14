using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class AccesoBD
    {
        private SqlConnection conexion;
        public AccesoBD()
        {
            this.conexion = new SqlConnection(@"Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=EstudioCredito;Data Source=SANTIAGOPC\SQLEXPRESS"); 
        }

        public bool crearRegistro(int Documento, string Nombre, string Apellidos, int Monto)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO clientes VALUES ('{0}','{1}','{2}','{3}')",
                Documento, Nombre, Apellidos, Monto);
            
            SqlCommand comando = new SqlCommand(insert,conexion);

            int rows = comando.ExecuteNonQuery();

            conexion.Close();

            return rows > 0;
        }
        
        public RegistroDTO consultarRegistro(int documento)
        {
            conexion.Open();

            string select = string.Format(
                "SELECT * FROM clientes WHERE documento = '{0}'",
                documento);

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            RegistroDTO historial = new RegistroDTO();

            while (dataReader.Read())
            {
                historial.Documento = documento;
                historial.Nombre = dataReader.GetValue(2).ToString();
                historial.Apellidos = dataReader.GetValue(3).ToString();
                historial.Monto += int.Parse(dataReader.GetValue(4).ToString());
            }

            conexion.Close();

            return historial;
        }
    }

}