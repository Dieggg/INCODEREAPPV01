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
    public class NegocioValeConsumo
    {
        public NegocioCompra auxNegocioCompra = new NegocioCompra();
        public Conexion Conn { get; set; }

        public void ConfigurarConexion()
        {
            this.Conn = new Conexion
            {
                NombreBaseDeDatos = Globals.NombreBaseDeDatos,
                NombreTabla = "VALES",
                CadenaConexion = Globals.CadenaConexion
            };
        }

        public void GrabarValeConsumo(ValeConsumo valeConsumo)
        {
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "INSERT INTO VALES (id_trabajador, fecha, tipo)" +
                                     " VALUES ('" +
                                     valeConsumo.IdTrabajador + "','" +
                                     valeConsumo.Fecha + "','" +
                                     valeConsumo.Tipo + "');";
            this.Conn.EsSelect = false;
            this.Conn.Conectar();
        }

        public void GenerarConsumo(ValeConsumo valeConsumo, List<Salida> salidas)
        {
            this.GrabarValeConsumo(valeConsumo);

            int IdUltimoVale = this.ObtenerUltimoId();
            foreach (Salida salida in salidas)
            {
                Salida auxSalida = new Salida
                {
                    NumeroUnidades = salida.NumeroUnidades,
                    IdProducto = salida.IdProducto,
                    IdValeConsumo = IdUltimoVale
                };

                //MessageBox.Show("id prod:" + salida.IdProducto + "id guia: " + salida.IdValeConsumo);
                NegocioSalida auxNegocioSalida = new NegocioSalida();
                auxNegocioSalida.GrabarSalida(auxSalida);

                //Acutalizar stock
                // FALTA VALIDAR CANTIDAD!!
                NegocioProducto auxNegocioProducto = new NegocioProducto();
                int cantidadVigente = auxNegocioProducto.ObtenerStock(auxSalida.IdProducto);
                int cantidadSolicitada = auxSalida.NumeroUnidades;

                if (cantidadSolicitada <= cantidadVigente)
                {
                    auxNegocioProducto.ActualizarStock(auxSalida.IdProducto, auxSalida.NumeroUnidades);
                }
            } // Fin de foreach

        }

        public int ObtenerUltimoId()
        {
            ValeConsumo auxValeConsumo = new ValeConsumo();
            this.ConfigurarConexion();
            this.Conn.CadenaSQL = "SELECT TOP 1 * FROM VALES ORDER BY id DESC";

            this.Conn.EsSelect = true;
            this.Conn.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conn.DbDataSet.Tables[this.Conn.NombreTabla];

            try
            {
                auxValeConsumo.Id = (int)dt.Rows[0]["id"];
                auxValeConsumo.IdTrabajador = (int)dt.Rows[0]["id_trabajador"];
                auxValeConsumo.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxValeConsumo.Tipo = (String)dt.Rows[0]["tipo"];
            }
            catch (Exception ex)
            {
                auxValeConsumo.Id = -1;
                auxValeConsumo.IdTrabajador = -1;
                auxValeConsumo.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxValeConsumo.Tipo = "error";
            }

            return auxValeConsumo.Id;
        }
    }
}
