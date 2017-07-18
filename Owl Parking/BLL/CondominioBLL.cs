using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{
    [DataObject]
    public class CondominioBLL
    {

        ti2Entities Bd = new ti2Entities();

        //INSERT
        public void AgregarCondominio(string Nombre)
        {
            Condominio nCondominio = new Condominio()
            {
                Nombre = Nombre
            };
            Bd.Condominio.AddObject(nCondominio);
            Bd.SaveChanges();
        }

        //DELETE
        public void BorrarCondominio(int Condominio_Id)
        {
            Condominio dCondominio = (from c in Bd.Condominio
                                      where c.Condominio_Id == Condominio_Id
                                      select c).FirstOrDefault();
            Bd.Condominio.DeleteObject(dCondominio);
            Bd.SaveChanges();
        }

    }
}