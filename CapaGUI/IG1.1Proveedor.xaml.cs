using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;


namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para CrearGuia.xaml
    /// </summary>
    public partial class IGProveedor : MetroWindow
    {

       ServiceReferenceProveedor.WebServiceProveedoresSoapClient auxServicioProveedor = new ServiceReferenceProveedor.WebServiceProveedoresSoapClient();
      

        
        public IGProveedor()
        {
            InitializeComponent();

            ServiceReferenceProveedor.WebServiceProveedoresSoapClient auxServiceProveedor = new ServiceReferenceProveedor.WebServiceProveedoresSoapClient();
            DataSet ds = new DataSet();
            ds = auxServiceProveedor.EntregaProveedorDataSet();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            dgProveedorView.ItemsSource = dt.DefaultView;


        }

        private void CargaDG(object sender, RoutedEventArgs e)
        {

        }



       

        private async void dgProveedorView_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
          
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                CrearGuia Ventana = new CrearGuia();

                Ventana.lblId.Content = row_selected["id"].ToString();
                Ventana.lblRutProveedor.Content = row_selected["Rut"].ToString();
                Ventana.lblNombreProveedor.Content = row_selected["Razon_social"].ToString();
                Ventana.lblDireccionProveedor.Content = row_selected["direccion"].ToString();
                Ventana.lblGiroProveedor.Content = row_selected["giro"].ToString();
                Ventana.ShowDialog();
                
             


            }

        }

        private void btnCrearProveedor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}