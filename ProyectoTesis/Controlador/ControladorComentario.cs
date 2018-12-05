using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorComentario
    {
        public bool InsertarComentario(int idpublicacion, int idemisor, string texto, string fecha)
        {
            int estado = 0; // comentario visible
            if (texto.Equals("") || texto.Length > 1000)
            {
                return false;
            }
            else
            {
                Comentario cm = new Comentario();
                cm.Idpublicacion = idpublicacion;
                cm.Idemisor = idemisor;
                cm.Texto = texto;
                cm.Fecha = DateTime.Now.ToString();
                cm.Estado = 0;
                if (cm.insertarComentario(cm))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Comentario> listaComentarios(int idpost)
        {
            List<Comentario> lista = null;
            Comentario c = new Comentario();
            lista = c.Buscarcomentarios(idpost);
            return lista;
        }
    }
}