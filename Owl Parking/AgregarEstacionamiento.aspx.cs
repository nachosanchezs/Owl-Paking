using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class AgregarEstacionamiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnAgregarEstacionamiento_Click(object sender, EventArgs e)
        {
            EstacionamientoBLL eBLL = new EstacionamientoBLL();
            PropietarioBLL pBLL = new PropietarioBLL();
            Estac_PersonaBLL epBLL = new Estac_PersonaBLL();
            VisitasBLL vBLL = new VisitasBLL();
            if (DdlTipo.SelectedItem.ToString() == "Particular")
            {
                if (TxtEmail.Text.Length >= 1)
                {
                    try
                    {
                        eBLL.AgregarEstacionamiento(DdlTipo.SelectedValue.ToString(), eBLL.GetCodigoEstacionamiento(DdlTipo.SelectedValue.ToString()));
                        int Propietario_Id = pBLL.GetPropietarioIdporCorreo(TxtEmail.Text.Trim());
                        int cEstacionamiento = eBLL.getUltimoEstacionamientoParticular();
                        epBLL.AgregarEstac_Persona(Propietario_Id, cEstacionamiento);
                        Response.Redirect("Estacionamiento.aspx");
                    }
                    catch (Exception ex)
                    {

                        Response.Write("<script>alert('" + Server.HtmlEncode(ex.Message) + "')</script>");
                    }

                }
                else
                {
                    eBLL.AgregarEstacionamiento(DdlTipo.SelectedValue.ToString(), eBLL.GetCodigoEstacionamiento(DdlTipo.SelectedValue.ToString()));
                    int cEstacionamiento = eBLL.getUltimoEstacionamientoParticular();
                    epBLL.AgregarEstac_Persona(4, cEstacionamiento);
                    Response.Redirect("Estacionamiento.aspx");
                }


            }
            else
            {
                eBLL.AgregarEstacionamiento(DdlTipo.SelectedValue.ToString(), eBLL.GetCodigoEstacionamiento(DdlTipo.SelectedValue.ToString()));
                int cEstacionamiento = eBLL.GetUltimoEstacionamientoVisita();
                vBLL.AgregarVisita(null, null, null, null, null, null, cEstacionamiento);
                Response.Redirect("Visitas.aspx");

            }

        }



    }
}