using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class ValeConsumo
    {
        public int Id { get; set; }
        public int IdTrabajador { get; set; }
        public DateTime Fecha { get; set; }
        public String Tipo { get; set; }
    }
}