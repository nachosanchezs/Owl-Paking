using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{

    [DataObject]
    public class VisitasBLL
    {

        ti2Entities Bd = new ti2Entities();

        //SELECT
        [DataObjectMethod(DataObjectMethodType.Select)]
        public IEnumerable<dynamic> GetVisitas()
        {
            return (from v in Bd.Visita
                    select new
                    {
                        Visita_Id = v.Visita_Id,
                        Codigo = v.Estacionamiento.Codigo,
                        Patente = v.Patente,
                        Nombre = v.Nombre,
                        Torre = v.Torre,
                        Departamento = v.Departamento,
                        Telefono = v.Telefono,
                        Hora = v.Hora
                    });
        }


        //INSERT
        public void AgregarVisita(string Nombre, string Patente, string Telefono, string Torre, string Departamento, DateTime? Hora, int Estacionamiento_Id)
        {
            Visita nVisita = new Visita()
            {
                Nombre = Nombre,
                Patente = Patente,
                Telefono = Telefono,
                Torre = Torre,
                Departamento = Departamento,
                Hora = Hora,
                Estacionamiento_Id = Estacionamiento_Id
            };
            Bd.Visita.AddObject(nVisita);
            Bd.SaveChanges();
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void EditarVisita(int Visita_Id, string Codigo, string Patente, string Nombre, string Torre, string Departamento, string Telefono, DateTime? Hora)
        {
            Visita eVisita = (from v in Bd.Visita
                              where v.Visita_Id == Visita_Id
                              select v).FirstOrDefault();

            Hora = System.DateTime.Now;
            eVisita.Nombre = Nombre;
            eVisita.Patente = Patente;
            eVisita.Telefono = Telefono;
            eVisita.Torre = Torre;
            eVisita.Departamento = Departamento;
            eVisita.Hora = Hora;
            Bd.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarVisita(int Visita_Id, string Codigo, string Patente, string Nombre, string Torre, string Departamento, string Telefono, DateTime? Hora)
        {
            Visita eVisita = (from v in Bd.Visita
                              where v.Visita_Id == Visita_Id
                              select v).FirstOrDefault();
            eVisita.Nombre = "";
            eVisita.Patente = "";
            eVisita.Telefono = "";
            eVisita.Torre = "";
            eVisita.Departamento = "";
            eVisita.Hora = null;
            Bd.SaveChanges();
        }

    }
}