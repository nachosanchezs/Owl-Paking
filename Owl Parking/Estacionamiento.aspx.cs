using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;
using System.IO.Ports;

namespace Owl_Parking
{
    public partial class Estacionamiento1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static string VerNotificacion(string name)
        {
            ArduinoBLL arBLL = new ArduinoBLL();
            NotificacionBLL nBLL = new NotificacionBLL();
            if (arBLL.VerEstado1() == true && nBLL.CompararComentario() == false )
            {
                return "verdadero";
            }
            else
            {
                return "falso";
            }
        }

    }
}