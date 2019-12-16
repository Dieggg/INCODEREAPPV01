using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioSalida
    {
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "CONSUMOS",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public void GrabarSalida(Salida salida)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO CONSUMOS (numero_unidades, id_producto, id_vale)" +
                                     " VALUES ('" +
                                     salida.NumeroUnidades + "','" +
                                     salida.IdProducto + "','" +
                                     salida.IdValeConsumo + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();
        }
    }
}
