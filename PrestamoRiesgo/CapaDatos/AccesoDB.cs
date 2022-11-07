using System.Data.SqlClient;

namespace CapaDatos
{
    public class AccesoDB
    {

        private SqlConnection conexion;

        public AccesoDB()
        {
            this.conexion = new SqlConnection(@"Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=CentralesDeRiesgo;Data Source=SANTIAGOPC\SQLEXPRESS");
        }

        public int consultarRegistro(int cedula)
        {
            conexion.Open();

            string select = string.Format(
                "SELECT * FROM PuntajeRiesgo WHERE cedula = '{0}'",
                cedula);

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            int puntaje = 0;

            while (dataReader.Read())
            {
                puntaje = int.Parse(dataReader.GetValue(1).ToString());
            }

            conexion.Close();

            return puntaje;
        }
    }
}