using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioCompra
    {
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "COMPRAS",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public void GrabarCompra(Compra compra)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO COMPRAS (numero_unidades, id_producto, id_guia)" +
                                     " VALUES ('" +
                                     compra.NumeroUnidades + "','" +
                                     compra.IdProducto + "','" +
                                     compra.IdGuia + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();
        }

    }
}
