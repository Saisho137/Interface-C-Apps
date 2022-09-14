using CapaAccesoDatos;

namespace CapaNegocio
{
    public class Prestamo
    {
        AccesoBD acceso = new AccesoBD();
        public bool registrarPrestamo(int documento,string nombre, string apellidos, int monto)
        {
            documento = documento;
            nombre = nombre.ToUpper();
            apellidos = apellidos.ToUpper();
            monto = monto;

            return acceso.crearRegistro(documento, nombre, apellidos, monto);
        }

        public bool aceptarPrestamo(int documento,int ingresos, int monto)
        {
            RegistroDTO historial = acceso.consultarRegistro(documento);

            int Creditos = historial.Monto + monto;

            if (Creditos <= (ingresos * 10))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}