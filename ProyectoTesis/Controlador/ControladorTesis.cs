using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorTesis
    {
        public string insertaTesis(string autor, string descripcion, string profeGuia, string nombreArchivo, string titulo, int tematesis)
        {
            if (autor.Equals("") || descripcion.Equals("") || profeGuia.Equals("") || nombreArchivo.Equals("") || titulo.Equals(""))
            {
                return "Campos vacios.";
            }
            else
            {
                AutorTesis at = null;
                String[] autores = autor.Split(',');
                Tesis t = new Tesis();
                t.Autor = autor;
                t.Descripcion = descripcion;
                t.Profesor_guia = profeGuia;
                t.Nombre_archivo = nombreArchivo;
                t.Titulo = titulo;
                t.Tematesis = tematesis;
                
                if (t.InsertaTesis(t))
                {
                    Tesis t2 = t.BuscaPorTitulo(t.Titulo);
                    for (int i = 0; i < autores.Length; i++)
                    {
                        at = new AutorTesis();
                        at.Nombre = autores[i];
                        at.Id_tesis = t2.Idtesis;
                        at.InsertaAutorTesis(at);
                    }
                    return "Tesis subida con exito.";  
                }
                else
                {
                    return "Error al subir tesis";
                }
            }
        }

        public List<Tesis> ObetenerTodasTesis()
        {
            Tesis t = new Tesis();
            List<Tesis> lista = t.buscaTodos();
            return lista;
        }

        public List<Tesis> ObtenerporTema(int tema)
        {
            Tesis t = new Tesis();
            List<Tesis> lista = t.BuscaPorTema(tema);
            return lista;
        }

        public Tesis ObtenerTesis(string id)
        {
            Tesis t = new Tesis();
            Tesis t2 = null;
            t2 = t.buscaUnatesis(id, id);
            return t2;
        }


    }
}
