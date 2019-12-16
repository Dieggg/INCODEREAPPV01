using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapaNegocio
{
    public class NegocioGuia
    {
        public NegocioCompra auxNegocioCompra = new NegocioCompra();
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "GUIAS",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public void GrabarGuia(GuiaRecepcion guia)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO GUIAS (id_proveedor, fecha)" +
                                     " VALUES ('" +
                                     guia.IDProveedor + "','" +
                                     guia.Fecha + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();
        }

        public void CargarGuiaCompleta(GuiaRecepcion guia, List<Compra> compras)
        {
            this.GrabarGuia(guia);

            int IdUltimaguia = this.ObtenerUltimoId();
            foreach(Compra compra in compras)
            {
                Compra auxCompra = new Compra {
                    NumeroUnidades = compra.NumeroUnidades, 
                    IdProducto = compra.IdProducto,
                    IdGuia = IdUltimaguia
                };

                MessageBox.Show("id prod:" + compra.IdProducto + "id guia: " + compra.IdGuia);
                NegocioCompra auxNegocioCompra = new NegocioCompra();
                auxNegocioCompra.GrabarCompra(auxCompra);

                //Acutalizar stock
                NegocioProducto auxNegocioProducto = new NegocioProducto();
                auxNegocioProducto.ActualizarStock(auxCompra.IdProducto, auxCompra.NumeroUnidades);

            }


        }

        public int ObtenerUltimoId()
        {
            GuiaRecepcion auxGuia = new GuiaRecepcion();
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT TOP 1 * FROM GUIAS ORDER BY id DESC";

            this.Conn.EsSelect = true;
            this.Conn.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conn.DbDataSet.Tables[this.Conn.NombreTabla];

            try
            {
                auxGuia.ID = (int)dt.Rows[0]["id"];
                auxGuia.IDProveedor = (int)dt.Rows[0]["id_proveedor"];
                auxGuia.Fecha = (DateTime)dt.Rows[0]["fecha"];
            }
            catch (Exception ex)
            {
                auxGuia.ID = -1;
                auxGuia.IDProveedor = -1;
                auxGuia.Fecha = (DateTime)dt.Rows[0]["fecha"]; ;
            }

            return auxGuia.ID;
        }




    }
}
