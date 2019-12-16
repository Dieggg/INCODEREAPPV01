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
    public class NegocioProveedor
    {
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "PROVEEDORES",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public DataSet RetornaProveedorDataSet()
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT * FROM PROVEEDORES";
            this.Conn.EsSelect = true;
            this.Conn.Conectar();

            return this.Conn.DbDataSet;
        }




        public void IngresaProveedor(Proveedor proveedor)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO PROVEEDORES (rut,nombre) " +
                                     " VALUES ('" + proveedor.Rut + "','" +
                                      proveedor.Rut + "','" +
                                      proveedor.Telefono + "','" +
                                      proveedor.Email + "','" +
                                      proveedor.Direccion + "','" +
                                      proveedor.RazonSocial + "','" +
                                      proveedor.Giro + "','" +
                                      proveedor.NombreRepresentante + "','" +                               
                                      proveedor.ApellidosRepresentante + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();

        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "UPDATE PROVEEDORES set rut = '" + proveedor.Rut + 
                                   "', telefono = '" + proveedor.Telefono + 
                                   "', email = '" + proveedor.Email +
                                   "', direccion = '" + proveedor.Direccion +
                                   "', razon_social = '" + proveedor.RazonSocial +
                                   "', giro = '" + proveedor.Giro +
                                   "', nombre_representante = '" + proveedor.NombreRepresentante +
                                   "', apellido_representante = '" + proveedor.ApellidosRepresentante +
                                   "' WHERE id = '" + proveedor.Id + "';";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();

        }

        public void EliminarProveedor(String id)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "DELETE FROM PROVEEDORES " +
                                    " WHERE id = '" + id + "';";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();

        }


    }
}
