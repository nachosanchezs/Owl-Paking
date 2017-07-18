using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{

    [DataObject]
    public class AdministradorBLL
    {

        ti2Entities Bd = new ti2Entities();

        //INSERT
        public void AgregarAdministrador(string Nombre, string Correo, string Contraseña, string Cargo, int Condominio_Id)
        {
            Administrador nAdministrador = new Administrador()
            {
                Nombre = Nombre,
                Correo = Correo,
                Password = Contraseña,
                Cargo = Cargo,
                Condominio_Id = Condominio_Id
            };
            Bd.Administrador.AddObject(nAdministrador);
            Bd.SaveChanges();
        }

        //DELETE
        public void EliminarAdministrador(int Administrador_Id)
        {
            Administrador dAdministrador = (from a in Bd.Administrador
                                            where a.Administrador_Id == Administrador_Id
                                            select a).FirstOrDefault();

            Bd.Administrador.DeleteObject(dAdministrador);
            Bd.SaveChanges();
        }

        public bool ValidarCredenciales(string Correo, string Contraseña)
        {
            List<Administrador> lista = (from a in Bd.Administrador
                                         where a.Correo == Correo && a.Password == Contraseña
                                         select a).ToList();
            return lista.Count() > 0;
        }
    }
}