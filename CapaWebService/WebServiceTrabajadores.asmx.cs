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
    /// Descripción breve de WebServiceTrabajadores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTrabajadores : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public Trabajador ValidarLogin(String email, String password)
        {
            NegocioTrabajador auxNegocioTrabajador = new NegocioTrabajador();
            Trabajador auxTrabajador = auxNegocioTrabajador.ValidarLogin(email, password);
            return auxTrabajador;
        }
    }
}
