using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Proveedor
    {
        public int Id { get; set; }
        public String Rut { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }

        public String RazonSocial { get; set; }
        public String Giro { get; set; }
        public String NombreRepresentante { get; set; }
        public String ApellidosRepresentante { get; set; }
    }
}
