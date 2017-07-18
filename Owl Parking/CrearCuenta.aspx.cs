using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            


        }

        protected void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            PropietarioBLL pBLL = new PropietarioBLL();
            Estac_PersonaBLL epBLL = new Estac_PersonaBLL();
            pBLL.AgregarPropietario(TxtNombre.Text.Trim(),TxtPatente.Text.Trim(), TxtTelefono.Text.Trim(), DdlTorre.SelectedValue.ToString(), TxtDepartamento.Text.Trim(), TxtEmail.Text.Trim(), TxtContraseña.Text.Trim());
            int idPropietario = pBLL.GetIdUltimoPropietario();
            epBLL.AgregarEstac_Persona(idPropietario, Convert.ToInt32(DdlEstacionamiento.SelectedValue));
            TxtNombre.Text = "";
            TxtPatente.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtDepartamento.Text = "";
            TxtContraseña.Text = "";
            
        }

    }
}