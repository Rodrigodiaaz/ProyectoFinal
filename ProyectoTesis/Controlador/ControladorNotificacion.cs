using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorNotificacion
    {
        public bool creaNotificacion(int idPost, int receptor)
        {
            Notificacion nt = new Notificacion();
            nt.Estado = 0;
            nt.IdPost = idPost;
            nt.IdUsuario = receptor;
            if (nt.insertaNotitifacion(nt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int cantidadNotificaciones(Usuario us)
        {
            Notificacion nt = new Notificacion();
            List<Notificacion> lista = nt.buscaTodosDe(us);
            int contador = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Estado == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public List<Notificacion> notificacionesNoVistas(Usuario us)
        {
            List<Notificacion> noVistas = new List<Notificacion>();
            Notificacion nt = new Notificacion();
            List<Notificacion> lista = nt.buscaTodosDe(us);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Estado == 0)
                {
                    noVistas.Add(lista[i]);
                }
            }
            return noVistas;
        }

        public void cambiaEstado(Usuario u)
        {
            Notificacion n = new Notificacion();
            n.cambiaEstado(u);
        }
    }
}