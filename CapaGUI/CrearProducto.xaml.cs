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
    /// Lógica de interacción para CrearProducto.xaml
    /// </summary>
    public partial class CrearProducto : MetroWindow
    {
        public CrearProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        public void CargarProductos()
        {
            ServiceReferenceProductos.WebServiceProductosSoapClient auxServiceProductos = new ServiceReferenceProductos.WebServiceProductosSoapClient();
            DataSet ds = new DataSet();
            ds = auxServiceProductos.EntregaProductoDataSet();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            dgProductos.ItemsSource = dt.DefaultView;
        }
    }
}
