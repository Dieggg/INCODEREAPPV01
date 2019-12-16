using CapaDTO;
using CapaConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class NegocioTrabajador
    {
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "TRABAJADORES",
                CadenaConexion = Globals.CadenaConexion
            };
        }
        public Trabajador ValidarLogin(String email, String password)
        {
            Trabajador auxTrabajador = new Trabajador();
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT * FROM TRABAJADORES WHERE email = '" + email + "' AND password = '" + password +"';";
            this.Conn.EsSelect = true;
            this.Conn.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conn.DbDataSet.Tables[this.Conn.NombreTabla];

            try
            {
                auxTrabajador.Id = (int)dt.Rows[0]["id"];
                auxTrabajador.Rut = (String)dt.Rows[0]["rut"];
                auxTrabajador.Nombre = (String)dt.Rows[0]["nombre"];
                auxTrabajador.Apellidos = (String)dt.Rows[0]["apellidos"];
                auxTrabajador.Email = (String)dt.Rows[0]["email"];
                auxTrabajador.NombreUsuario = (String)dt.Rows[0]["nombre_usuario"];
                auxTrabajador.Password = (String)dt.Rows[0]["password"];
                auxTrabajador.UltimoLogin = (DateTime)dt.Rows[0]["ultimo_login"];
                auxTrabajador.Perfil = (String)dt.Rows[0]["perfil"];

            }
            catch (Exception ex)
            {
                auxTrabajador = null;
                
            }

            return auxTrabajador;
        }
    }
}
