using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{
    [DataObject]
    public class Estac_PersonaBLL
    {
        ti2Entities Bd = new ti2Entities();

        [DataObjectMethod(DataObjectMethodType.Select)]
        public IEnumerable<dynamic> GetEstacionamientoPersona()
        {
            return (from ep in Bd.Estac_Persona
                    orderby ep.Estacionamiento.Codigo ascending
                    select new
                    {
                        Codigo = ep.Estacionamiento.Codigo,
                        Dueño = ep.Propietario.Nombre,
                        Torre = ep.Propietario.Torre,
                        Departamento = ep.Propietario.Departamento,
                        Telefono = ep.Propietario.Telefono,
                        Estado = ep.Estacionamiento.Estado
                    }).ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public int GetEstacionamientoId(string Correo)
        {
            PropietarioBLL pBLL = new PropietarioBLL();
            int Propietario_Id = pBLL.GetPropietarioIdporCorreo(Correo);
            int Estacionamiento_Id = (from e in Bd.Estac_Persona
                                      where e.Propietario_Id == Propietario_Id
                                      select e.Estacionamiento.Estacionamiento_Id).FirstOrDefault();
            return Estacionamiento_Id;
        }

        public void AgregarEstac_Persona(int Propietario_Id, int Estacionamiento_Id)
        {
            Estac_Persona nEstac_Persona = new Estac_Persona() 
            {
                
                Propietario_Id = Propietario_Id,
                Estacionamiento_Id = Estacionamiento_Id
            };
            Bd.Estac_Persona.AddObject(nEstac_Persona);
            Bd.SaveChanges();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void EditarEstac_Persona(int Propietario_Id, int Estacionamiento_Id)
        {
            Estac_Persona eEstac_Persona = (from ep in Bd.Estac_Persona
                                            where ep.Propietario_Id == Propietario_Id
                                            select ep).FirstOrDefault();
            if (eEstac_Persona.Estacionamiento_Id != Estacionamiento_Id)
            {
                eEstac_Persona.Estacionamiento_Id = Estacionamiento_Id;
            }
            else
            {
                eEstac_Persona.Propietario_Id = 4;
            }
            Bd.SaveChanges();
        }

        
    }
}