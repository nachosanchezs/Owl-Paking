using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{

    [DataObject]
    public class ArduinoBLL
    {
        ti2Entities Bd = new ti2Entities();

        public bool VerEstado1()
        {
            List<Arduino> lista = (from ar in Bd.Arduino
                                   where ar.Estado == 1 && (from e in Bd.Estacionamiento
                                                            where e.Estado == "Afuera"
                                                            select e.Arduino_Id).FirstOrDefault() == ar.Arduino_Id
                                   select ar).ToList();
            return lista.Count() > 0;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Arduino> getArduinon()
        {
            return Bd.Arduino.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Editar(int id, int mensaje)
        {
            Arduino arduinoEditar = Bd.Arduino.First(a => a.Arduino_Id == id);
            arduinoEditar.Estado = mensaje;
            Bd.SaveChanges();
        }
    }
}