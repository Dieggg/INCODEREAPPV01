using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Compra
    {
        public int Id { get; set; }
        public int IdGuia { get; set; }
        public int IdProducto { get; set; }
        public int NumeroUnidades { get; set; }
    }
}
