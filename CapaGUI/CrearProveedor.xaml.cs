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
    /// Lógica de interacción para CrearProveedor.xaml
    /// </summary>
    public partial class CrearProveedor : MetroWindow
    {
        public CrearProveedor()
        {
            InitializeComponent();
            ServiceReferenceProveedor.WebServiceProveedoresSoapClient auxServiceProveedor = new ServiceReferenceProveedor.WebServiceProveedoresSoapClient();
            DataSet ds = new DataSet();
            ds = auxServiceProveedor.EntregaProveedorDataSet();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            dgProveedorView.ItemsSource = dt.DefaultView;
        }

        private void btnCrearProveedor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
