using CapaAccesoDB;

namespace CapaNegocio
{
    public class Asegurable
    {
        DateTime fechaActual = DateTime.Today;
        AccesoBD acceso = new AccesoBD();
        public bool registrarSeguro(string Placa, int Modelo, int Kilometraje, int Peritraje, string Asegurable)
        {
            Placa = Placa.ToUpper();

            return acceso.crearRegistro(Placa, Modelo, Kilometraje, Peritraje, Asegurable);
        }
        public bool aceptarSeguro(string Placa, int Modelo, int Kilometraje, int Peritraje)
        {
            if (Modelo >= 1950 && Modelo < 2010 && Peritraje >= 7)
            {
                return true;
            }
            else if (Modelo >= 1950 && Modelo < 2010 && Peritraje >= 4 && Kilometraje <= 50000)
            {
                return true;
            }
            else if (Modelo >= 2010 && Modelo <= 2015 && Peritraje >= 7)
            {
                return true;
            }
            else if (Modelo >= 2010 && Modelo <= 2015 && Peritraje >= 4 && Kilometraje <= 30000)
            {
                return true;
            }
            else if (Modelo > 2015 && Modelo <= fechaActual.Year + 1 && Peritraje >= 7)
            {
                return true;
            }
            else if (Modelo > 2015 && Modelo <= fechaActual.Year + 1 && Peritraje >= 4 && Kilometraje <= 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}