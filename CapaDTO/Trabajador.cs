using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Trabajador
    {
        public int Id { get; set; }
        public String Rut { get;  set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Email { get; set; }
        public String NombreUsuario { get; set; }
        public String Password { get; set; }
        public DateTime UltimoLogin { get; set; }
        public String Perfil { get; set; } // adm: Administrador, bdg: Bodeguero, usr: Usuario (Trabajador) 
    }
}
