using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaWebService
{
    /// <summary>
    /// Descripción breve de WebServiceGuias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceGuias : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos desde las guias!!";
        }

        [WebMethod]
        public void AgregarCompra(Compra compra)
        {
            NegocioCompra auxNegocioCompra = new NegocioCompra();
            auxNegocioCompra.GrabarCompra(compra);
        }

        [WebMethod]
        public void AgregarGuia(GuiaRecepcion guia)
        {
            NegocioGuia auxNegocioGuia = new NegocioGuia();
            auxNegocioGuia.GrabarGuia(guia);
        }

        [WebMethod]
        public void CargarGuiaCompleta(GuiaRecepcion guia, List<Compra> compras)
        {
            NegocioGuia auxNegocioGuia = new NegocioGuia();
            auxNegocioGuia.CargarGuiaCompleta(guia, compras);
        }


    }
}
