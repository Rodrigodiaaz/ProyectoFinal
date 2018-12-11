using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorPublicacion
    {
        public String realizarActializacion(string idemisor, string idreceptor, string texto, string fecha)
        {
            if (texto.Equals("") || texto.Equals("¿Que estas pensando?") || texto.Length < 2)
            {
                return "Por favor escriba el comentario";
            }
            else
            {
                Publicacion pos = new Publicacion();
                if (pos.registraPost2(texto, idemisor, idreceptor, 0 , 0, fecha))
                {
                    return "Actualizacion realizada con exito";
                }
                else
                {

                    return "Error al realizar actualizacion";
                }
            }
        }

        public String realizarComentario(string emisor, string receptor, string texto, string fecha)
        {
            if (texto.Equals("") || texto.Equals("Saluda a tu amigo, escribele algo lindo.") || texto.Length < 2)
            {
                return "Por favor escriba el comentario";
            }
            else
            {
                Publicacion pos = new Publicacion();
                if (pos.registraPost2(texto, emisor, receptor, 1, 0, fecha))
                {
                    pos.IdReceptor = receptor;
                    Publicacion pu = pos.buscaReceptor(pos);
                    ControladorNotificacion cn = new ControladorNotificacion();
                    if (cn.creaNotificacion(pu.Idpublicacion, Int32.Parse(pu.IdReceptor)))
                    {
                        return "Comentario realizado con exito";
                    }
                    else
                    {
                        return "Error al realizar comentario";
                    }
                }
                else
                {

                    return "Error al realizar comentario";
                }
            }
        }

        public List<Publicacion> obtenerPost(string receptor)
        {
            Publicacion p = new Publicacion();
            List<Publicacion> lista = p.buscaMuro(receptor);
            return lista;
        }

        public List<Publicacion> ObtenerTodasPublicaciones()
        {
            Publicacion p = new Publicacion();
            List<Publicacion> lista = p.BuscaTodas();
            return lista;
        }

        public List<Publicacion> obtenerPost()
        {
            return null;
        }
    }
}