using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "PRODUCTOS",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public DataSet RetornaProducoDataSet()
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT * FROM PRODUCTOS";
            this.Conn.EsSelect = true;
            this.Conn.Conectar();

            return this.Conn.DbDataSet;
        }

        public void IngresaProducto(Producto producto)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO PRODUCTOS (descripcion, stock, unidad)" +
                                     " VALUES ('" +
                                     producto.Descripcion + "','" +
                                     producto.Stock + "','" +
                                     producto.Unidad + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();
        }

        public void ActualizarStock(int idProducto, int cantidad)
        {
            int CantidadActual = this.ObtenerStock(idProducto);
            int NuevoStock = CantidadActual + cantidad;

            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "UPDATE PRODUCTOS SET stock = " + NuevoStock +" WHERE codigo_interno = " + idProducto + ";";                             
            this.Conn.EsSelect = false;
            this.Conn.Conectar();

        }

        public int ObtenerStock(int idProducto)
        {
            Producto auxProducto = new Producto();
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT * FROM PRODUCTOS " +
                                    " WHERE codigo_interno = '" + idProducto + "';";
            this.Conn.EsSelect = true;
            this.Conn.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conn.DbDataSet.Tables[this.Conn.NombreTabla];

            try
            {
                auxProducto.CodigoInterno = (int)dt.Rows[0]["codigo_interno"];
                auxProducto.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxProducto.Stock = (int)dt.Rows[0]["stock"];
                auxProducto.Unidad = (String)dt.Rows[0]["unidad"];
            }
            catch (Exception ex)
            {
                auxProducto.CodigoInterno = -1;
                auxProducto.Descripcion = String.Empty;
                auxProducto.Stock = -1;
                auxProducto.Unidad = String.Empty;
            }

            return auxProducto.Stock;
        }
    }
}
