using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class Popupo : System.Web.UI.Page
    {
        NotificacionBLL nBLL = new NotificacionBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LblComentario.Text = nBLL.ComentarioNotificacion();
        }

        protected void BtnAgregarComentario_Click(object sender, EventArgs e)
        {
            nBLL.AgregarComentario(TxtComentario.Text.Trim());
            
            Response.Write("<script> window.close(); </script>");
        }
    }
}