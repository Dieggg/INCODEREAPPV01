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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
     

        public Menu()
        {
            InitializeComponent();
           
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

   
            lbltext.Text = "Transacción para el Ingreso de Guia de despacho Proveedor";

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            lbltext.Text = "";
        }

        private void MouseEnter_CrearProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "Transacción para crear materiales";
        }

        private void MouseLeave_CrearProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "";
        }

        private void MouseEnter_ModificarProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "Transaccion para modificar y eliminar materiales";
        }

        private void MouseLeave_ModificarProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "";
        }

        private void Button_Click_IngresarGuia(object sender, RoutedEventArgs e)
        {
            IGProveedor _ver = new IGProveedor();
            
            _ver.ShowDialog();

        }

        private void btnCrearProducto_Click(object sender, RoutedEventArgs e)
        {
            CrearProducto _ver = new CrearProducto();
            _ver.ShowDialog();
        }

        private void ModificarProducto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCrearProveedor_Click(object sender, RoutedEventArgs e)
        {
            CrearProveedor _ver = new CrearProveedor();
            _ver.ShowDialog();
        }

        private async void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            var settings = new MetroDialogSettings { AffirmativeButtonText = "yes", NegativeButtonText = "no" };
            string respuesta;
            await this.ShowMessageAsync("Cerrar Sesión","Desea Cerrar sesión",MessageDialogStyle.AffirmativeAndNegative, settings);
           
           
        }
    }
}
