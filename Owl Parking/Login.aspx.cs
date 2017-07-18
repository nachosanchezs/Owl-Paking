using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            AdministradorBLL aBLL = new AdministradorBLL();
            if (aBLL.ValidarCredenciales(TxtCorreo.Text.Trim(), TxtContraseña.Text.Trim()) == true)
            {
                Response.Redirect("Estacionamiento.aspx");
            }
            else
            {
                Response.Write("<script>alert('Ingresar datos correctamente')</script>");
            }
        }
    }
}