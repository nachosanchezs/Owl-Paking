using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{
    [DataObject]
    public class PropietarioBLL
    {
        ti2Entities Bd = new ti2Entities();

        //SELECT
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Propietario> GetPropietarios()
        {
            return Bd.Propietario.ToList();
        }

        public Propietario GetPropietarioPorCorreo(string Correo)
        {
            Propietario propietario = (from p in Bd.Propietario
                                       where p.Correo == Correo
                                       select p).FirstOrDefault();
            return propietario;
        }

        public int GetPropietarioIdporCorreo(string Correo)
        {
            return (from p in Bd.Propietario
                    where p.Correo == Correo
                    select p.Propietario_Id).FirstOrDefault();
        }

        public int GetIdUltimoPropietario()
        {
            return (from p in Bd.Propietario
                    orderby p.Propietario_Id descending
                    select p.Propietario_Id).FirstOrDefault();
        }

        //INSERT
        public void AgregarPropietario(string Nombre, string Patente, string Telefono, string Torre, string Departamento, string Correo, string Contraseña)
        {
            Propietario nPropietario = new Propietario()
            {
                Nombre = Nombre,
                Patente = Patente,
                Telefono = Telefono,
                Torre = Torre,
                Departamento = Departamento,
                Correo = Correo,
                Password = Contraseña
            };
            Bd.Propietario.AddObject(nPropietario);
            Bd.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void EditarPropietario2(int Propietario_Id, string Nombre, string Patente, string Telefono, string Torre, string Departamento, string Contraseña, int Estacionamiento_Id)
        {
            Propietario ePropietario = (from p in Bd.Propietario
                                        where p.Propietario_Id == Propietario_Id
                                        select p).FirstOrDefault();

            Estac_PersonaBLL epBLL = new Estac_PersonaBLL();
            epBLL.EditarEstac_Persona(ePropietario.Propietario_Id, Estacionamiento_Id);
            ePropietario.Nombre = Nombre;
            ePropietario.Patente = Patente;
            ePropietario.Telefono = Telefono;
            ePropietario.Torre = Torre;
            ePropietario.Departamento = Departamento;
            ePropietario.Password = Contraseña;
            Bd.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void EditarPropi(int Propietario_Id, string Nombre, string Patente, string Telefono, string Torre, string Departamento, string Contraseña, int Estacionamiento_Id)
        {
            Propietario ePropietario = (from p in Bd.Propietario
                                        where p.Propietario_Id == Propietario_Id
                                        select p).FirstOrDefault();
            ePropietario.Nombre = Nombre;
            ePropietario.Patente = Patente;
            ePropietario.Telefono = Telefono;
            ePropietario.Torre = Torre;
            ePropietario.Departamento = Departamento;
            ePropietario.Password = Contraseña;
            Bd.SaveChanges();
        }
    }
}