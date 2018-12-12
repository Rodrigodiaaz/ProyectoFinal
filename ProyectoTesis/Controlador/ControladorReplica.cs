using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorReplica
    {

        public bool insertarReplica(string idusuario,string idtopic, string texto)
        {
            try
            {
                Post p = new Post();
                p.Idusuario = Convert.ToInt32(idusuario);
                p.Idtopic = Convert.ToInt32(idtopic);
                p.Fecha = DateTime.Now.ToString();
                p.Texto = texto;
                if (p.InsertaReplica(p))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (FormatException r)
            {
                return false;
            }
            
        }

        public List<Post> ObtenerPostxTopic(string idtopic)
        {
            Post t = new Post();
            return t.buscaRespuestaporTopic(idtopic);
        }
    }
}