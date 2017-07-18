using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Owl_Parking.BLL
{

    [DataObject]
    public class NotificacionBLL
    {

        ti2Entities Bd = new ti2Entities();

        [DataObjectMethod(DataObjectMethodType.Select)]
        public IEnumerable<dynamic> getNotificacionesPorEstacionamiento(int Estacionamiento_Id)
        {
            return (from n in Bd.Notificacion
                    where n.Estacionamiento_Id == Estacionamiento_Id
                    select new
                    {
                        Fecha = n.Fecha,
                        Comentario = n.Comentario
                    });
        }


        public void AgregarComentario(string Comentario)
        {
            int Notificacion_Id = (from n in Bd.Notificacion
                                   orderby n.Notificacion_Id descending
                                   select n.Notificacion_Id).FirstOrDefault();

            Notificacion noti = (from n in Bd.Notificacion
                                 where n.Notificacion_Id == Notificacion_Id
                                 select n).FirstOrDefault();

            noti.Comentario = Comentario;
            Bd.SaveChanges();
        }


        public bool CompararComentario()
        {
            string Comentario = (from n in Bd.Notificacion
                                   orderby n.Notificacion_Id descending
                                   select n.Comentario).FirstOrDefault();
            if (Comentario != "El comentario ya sera actualizado")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string ComentarioNotificacion()
        {

            Notificacion noti = (from n in Bd.Notificacion
                                 orderby n.Notificacion_Id descending
                                 select n).FirstOrDefault();
            return string.Format("El estacionamiento {0} está siendo mal útilizado, por favor acercarse lo antes posible", noti.Estacionamiento.Codigo);
        }
    }
}