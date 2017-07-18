using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class EditarCuenta : System.Web.UI.Page
    {
        PropietarioBLL pBLL = new PropietarioBLL();
        Estac_PersonaBLL epBLL = new Estac_PersonaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVerCorreo_Click(object sender, EventArgs e)
        {

            Propietario propietario = pBLL.GetPropietarioPorCorreo(TxtCorreo.Text.Trim());
            if (propietario != null)
            {
                TxtNombre.Text = propietario.Nombre;
                TxtPatente.Text = propietario.Patente;
                TxtTelefono.Text = propietario.Telefono;
                TxtDepartamento.Text = propietario.Departamento;
                TxtContraseña.Text = propietario.Password;
                TxtConfirmarContraseña.Text = propietario.Password;
                DdlTorre.SelectedValue = propietario.Torre;
                DdlEstacionamiento.SelectedValue = epBLL.GetEstacionamientoId(TxtCorreo.Text.Trim()).ToString();
            }
            else
            {
                Response.Write("<script>alert('Ingrese los datos correctamente')</script>");
            }


        }

        protected void BtnEditarCuenta_Click(object sender, EventArgs e)
        {
            pBLL.EditarPropi(pBLL.GetPropietarioIdporCorreo(TxtCorreo.Text.Trim()), TxtNombre.Text.Trim(), TxtPatente.Text.Trim(), TxtTelefono.Text.Trim(), DdlTorre.SelectedValue.ToString(), TxtDepartamento.Text.Trim(), TxtContraseña.Text.Trim(), Convert.ToInt32(DdlEstacionamiento.SelectedValue));
            TxtCorreo.Text = "";
            TxtNombre.Text = "";
            TxtPatente.Text = "";
            TxtDepartamento.Text = "";
            TxtTelefono.Text = "";
            TxtContraseña.Text = "";
            TxtConfirmarContraseña.Text = "";
            Response.Redirect("Estacionamiento.aspx");
        }


    }
}