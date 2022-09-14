using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class RegistroDTO
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Ingresos { get; set; }
        public int Monto { get; set; }
    }
}
