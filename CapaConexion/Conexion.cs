using System;
using System.Data.SqlClient;
using System.Windows;
namespace CapaConexion
{
    public class Conexion
    {
        public String NombreBaseDeDatos { get; set; }
        public String NombreTabla { get; set; }
        public String CadenaConexion { get; set; }
        public String CadenaSQL { get; set; }
        public Boolean EsSelect { get; set; }
        public SqlConnection DbConnection { get; set; }
        public System.Data.DataSet DbDataSet { get; set; }
        public SqlDataAdapter DbDataAdapter { get; set; }

        // Abrir la conexión
        public void Abrir()
        {
            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion " + ex.Message, "mensaje Sistema");
            }
        }

        public void Cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexion " + ex.Message, "mensaje Sistema");
            }
        }

        public void Conectar()
        {
            if (this.NombreBaseDeDatos.Length == 0)
            {
                MessageBox.Show("Falta nombre base de datos ", "mensaje Sistema");
                return;
            }


            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Falta nombre tabla ", "mensaje Sistema");
                return;
            }

            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Falta cadena C ", "mensajeonexion Sistema");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Falta cadena SQL ", "mensaje Sistema");
                return;
            }

            try
            {
                this.DbConnection = new SqlConnection(this.CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion " + ex.Message, "mensaje Sistema");
                return;
            }

            this.Abrir();

            if (this.EsSelect)
            {
                this.DbDataSet = new System.Data.DataSet();

                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.DbConnection);
                    this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message, "mensaje Sistema");
                    return;

                }
            }
            else
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.DbConnection);
                    variableSQL.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en SQL " + ex.Message, "mensaje Sistema");
                    return;

                }
            } //Fin if

            this.Cerrar();
        }
    }
}
