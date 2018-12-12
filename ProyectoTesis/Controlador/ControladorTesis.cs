using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public class ControladorTesis
    {
        public string insertaTesis(string autor, string descripcion, string profeGuia, string nombreArchivo, string titulo)
        {
            if (autor.Equals("") || descripcion.Equals("") || profeGuia.Equals("") || nombreArchivo.Equals("") || titulo.Equals(""))
            {
                return "Campos vacios.";
            }
            else
            {
                Tesis t = new Tesis();
                t.Autor = autor;
                t.Descripcion = descripcion;
                t.Profesor_guia = profeGuia;
                t.Nombre_archivo = nombreArchivo;
                t.Titulo = titulo;
                if (t.InsertaTesis(t))
                {
                    return "Tesis subida con exito.";
                }
                else
                {
                    return "Error al subir tesis";
                }
            }
        }


    }
}
