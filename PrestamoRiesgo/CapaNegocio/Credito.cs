using CapaDatos;

namespace CapaNegocio
{
    public class Credito
    {
        AccesoDB acceso = new AccesoDB();

        public int capacidadEndeudamiento(int ingresos, int egresos)
        {
            return ingresos-egresos;
        }
        public int edadUsuario(DateTime fechaNacimiento)
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }
        public bool aceptarCredito(int cedula, int endeudamiento, int edad, int prestamoSolicitado)
        {
            int puntaje = acceso.consultarRegistro(cedula);

            if (prestamoSolicitado > endeudamiento * 50 || puntaje < 750 || edad >= 25 && puntaje < 850)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}