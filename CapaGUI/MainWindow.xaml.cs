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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class mainWindow : MetroWindow
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ServiceReferenceTrabajadores.WebServiceTrabajadoresSoapClient auxServicioTrabajador = new ServiceReferenceTrabajadores.WebServiceTrabajadoresSoapClient();
            ServiceReferenceTrabajadores.Trabajador auxTrabajador = new ServiceReferenceTrabajadores.Trabajador();

            String email = txtUsuario.Text;
            String password = txtContrasena.Password;
            auxTrabajador = auxServicioTrabajador.ValidarLogin(email, password);

            if (auxTrabajador == null){
                await this.ShowMessageAsync("Error", "Usuario o Contraseña incorrecta, intente nuevamente");
           
            }else
            {
                await this.ShowMessageAsync("Exito", "Tus datos son correctos");
                Menu _ver = new Menu();
                this.Close();
                _ver.txtcargo.Text = auxTrabajador.Perfil;
                _ver.txtcorreo.Text = auxTrabajador.Email;
                _ver.txtusuario.Text = auxTrabajador.NombreUsuario;
                _ver.ShowDialog();
            }

            
        }

     





    }
}
