using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using Owl_Parking.BLL;

namespace Owl_Parking.BLL
{
    [DataObject]
    public class EstacionamientoBLL
    {

        ti2Entities Bd = new ti2Entities();


        //SELECT
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Estacionamiento> GetEstacionamientoParticular()
        {
            return (from e in Bd.Estacionamiento
                    orderby e.Codigo ascending
                    where e.Tipo == "Particular"
                    select e).ToList();
        }


        public int getUltimoEstacionamientoParticular()
        {
            Estacionamiento estacionamientoId = (from e in Bd.Estacionamiento
                                                 where e.Tipo == "Particular"
                                                 orderby e.Codigo descending
                                                 select e).FirstOrDefault();
            return Convert.ToInt32(estacionamientoId.Estacionamiento_Id);
        }

        public int GetUltimoEstacionamientoVisita()
        {
            Estacionamiento estacionamientoId = (from e in Bd.Estacionamiento
                                                 where e.Tipo == "Visita"
                                                 orderby e.Codigo descending
                                                 select e).FirstOrDefault();
            return Convert.ToInt32(estacionamientoId.Estacionamiento_Id);
        }


        //GENERAR CODIGO ESTACIONAMIENTO
        public string GetCodigoEstacionamiento(string Tipo)
        {
            Estacionamiento cEstacionamiento = (from e in Bd.Estacionamiento
                                                where e.Tipo == Tipo
                                                orderby e.Codigo descending
                                                select e).FirstOrDefault();

            string codigo = "";


            int cSum = Convert.ToInt32(cEstacionamiento.Codigo.Substring(2));
            cSum = cSum + 1;

            if (cSum < 10)
            {
                codigo = cEstacionamiento.Codigo.Substring(0, 1) + "-0" + cSum.ToString();
            }
            else
            {
                codigo = cEstacionamiento.Codigo.Substring(0, 1) + "-" + cSum.ToString();
            }



            return Convert.ToString(codigo);
            //return (cEstacionamiento.Codigo).ToString();
        }


        //Agregar
        public void AgregarEstacionamiento(string Tipo, string Codigo)
        {
            Estacionamiento nEstacionamiento = new Estacionamiento()
            {
                Tipo = Tipo,
                Codigo = Codigo,
                Condominio_Id = 1
            };
            Bd.Estacionamiento.AddObject(nEstacionamiento);
            Bd.SaveChanges();
        }
    }
}