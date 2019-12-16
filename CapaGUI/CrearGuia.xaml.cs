﻿using System;
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
using System.Data;

namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para CrearGuia.xaml
    /// </summary>
    public partial class CrearGuia : MetroWindow
    {
        ServiceReferenceGuias.WebServiceGuiasSoapClient auxServicioGuias = new ServiceReferenceGuias.WebServiceGuiasSoapClient();
        ServiceReferenceGuias.GuiaRecepcion auxGuia = new ServiceReferenceGuias.GuiaRecepcion();
        List<ServiceReferenceGuias.Compra> auxCompras = new List<ServiceReferenceGuias.Compra>();

        public CrearGuia()
        {
            InitializeComponent();
            CargarProductos();
            txtCantidad.Text = "0";
            btnIngresarGuia.IsEnabled = false;
        }

        private void BtnCargarMaterial_Click(object sender, RoutedEventArgs e)
        {

            
            //if ( txtCantidad.Text != "" && txtCodigo.Text != "" && txtUm.Text != "")
            //{
            //    var data = new ListaGuia { Codigo = txtCodigo.Text , Cantidad = txtCantidad.Text, UM = txtUm.Text };
            //    dgGuia.Items.Add(data); 
              
            //    txtCantidad.Text = "";
            //    txtCodigo.Text = "";
            //    txtUm.Text = "";
            //    BitmapImage bi3 = new BitmapImage();
            //    bi3.BeginInit();
            //    bi3.UriSource = new Uri("Imagenes/Iconos/iconoCheck.png", UriKind.Relative);
            //    bi3.EndInit();
            //    imgEstado.Stretch = Stretch.Fill;
            //    imgEstado.Source = bi3;
            //    lblMensaje.Content = "Material Cargado correctamente.";
               


            //}
            //else
            //{
            //    BitmapImage bi3 = new BitmapImage();
            //    bi3.BeginInit();
            //    bi3.UriSource = new Uri("Imagenes/Iconos/iconoError.png", UriKind.Relative);
            //    bi3.EndInit();
            //    imgEstado.Stretch = Stretch.Fill;
            //    imgEstado.Source = bi3;
            //    lblMensaje.Content = "Favor llenar los campos de material";

            //}


        }

        public class ListaGuia
        {
            public string Codigo { get; set; }
            public string Material { get; set; }
            public string Cantidad { get; set; }

            public string UM { get; set; }
        }

        private void BtnIngresarGuia_Click(object sender, RoutedEventArgs e)
        {
            auxGuia.IDProveedor = Int32.Parse(lblId.Content.ToString());
            var Fecha = DateTime.Now;
            auxGuia.Fecha = Fecha;

            ServiceReferenceGuias.Compra[] ArrayCompras = auxCompras.ToArray();
            auxServicioGuias.CargarGuiaCompleta(auxGuia, ArrayCompras);
            //LimpiarFormulario();
            CargarProductos();
        }

        private void btnGuardarGuia_Click(object sender, RoutedEventArgs e)
        {
            btnIngresarGuia.IsEnabled = true;

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("Imagenes/Iconos/iconoCheck.png", UriKind.Relative);
            bi3.EndInit();
            imgEstado.Stretch = Stretch.Fill;
            imgEstado.Source = bi3;
            lblMensaje.Content = "Registro Guardado Correctamente";

        }

        private void CargarProductos()
        {
            ServiceReferenceProductos.WebServiceProductosSoapClient auxServiceProductos = new ServiceReferenceProductos.WebServiceProductosSoapClient();
            DataSet ds = new DataSet();
            ds = auxServiceProductos.EntregaProductoDataSet();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DtgProductos.ItemsSource = dt.DefaultView;
        }

        private void BtnCargarProductos_Click(object sender, RoutedEventArgs e)
        {
            CargarProductos();
        }

        private void BtnSeleccionarProducto_Click(object sender, RoutedEventArgs e)
        {
            DataRowView rowProducto = (DataRowView)DtgProductos.SelectedItems[0];
            var auxIdProducto = (int)rowProducto[0];

            ServiceReferenceGuias.Compra auxCompra = new ServiceReferenceGuias.Compra
            {
                NumeroUnidades = Int32.Parse(txtCantidad.Text),
                IdProducto = auxIdProducto
            };

            auxCompras.Add(auxCompra);

            dgGuia.ItemsSource = null;
            dgGuia.ItemsSource = auxCompras;
        }
    }
}
