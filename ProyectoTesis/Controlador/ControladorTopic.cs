using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorTopic
    {
        public string publicarTopic(int idusuario, string titulo, string texto)
        {
            if (idusuario.Equals("") || titulo.Equals("") || texto.Equals(""))
            {
                return "Campos vacios.";
            }
            else
            {
                Topic t = new Topic();
                t.Id_usuario = idusuario;
                t.Titulo = titulo;
                t.Texto = texto;
                t.Fecha = DateTime.Now.ToString();
                if (t.InsertaTopic(t))
                {
                    return "Discusión creada con exito.";
                }
                else
                {
                    return "Error al crear discusión";
                }
            }
        }
        public List<Topic> ObetenerTodosTopics()
        {
            Topic t = new Topic();
            List<Topic> lista = t.buscaTodosLosTopics();
            return lista;
        }

        public Topic ObtenerTopic(string id)
        {
            Topic t = new Topic();
            Topic t2 = null;
            t2 = t.BuscaTopicId(id);
            return t2;
        }

    }
}