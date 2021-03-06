﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Controlador;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public partial class cComentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string idpost = Request.QueryString["idpost"];
                string texto = Request.QueryString["texto"];
                string idusuario = Request.QueryString["idusuario"];
                int identificador = Convert.ToInt32(Request.QueryString["identificador"]);
                int upropietario = Convert.ToInt32(Request.QueryString["upropietario"]);
                if (identificador == 0)
                {
                    ControladorComentario cc = new ControladorComentario();
                    if (cc.InsertarComentario(Convert.ToInt32(idpost), Convert.ToInt32(idusuario), texto, DateTime.Now.ToString()))
                    {
                        Response.Redirect("../Vistas/home.aspx");
                    }
                }
                else
                {
                    if (identificador == 1)
                    {
                        ControladorComentario cc = new ControladorComentario();
                        if (cc.InsertarComentario(Convert.ToInt32(idpost), Convert.ToInt32(idusuario), texto, DateTime.Now.ToString()))
                        {
                            Response.Redirect("../Vistas/perfil.aspx?id=" + upropietario);
                        }
                    }
                    else
                    {
                        ControladorComentario cc = new ControladorComentario();
                        if (cc.InsertarComentario(Convert.ToInt32(idpost), Convert.ToInt32(idusuario), texto, DateTime.Now.ToString()))
                        {
                            Response.Redirect("../Vistas/MenuPrincipal.aspx");
                        }
                    }

                }
            }
            catch (NullReferenceException)
            {
                Response.Redirect("../Vistas/MenuPrincipal.aspx");
            }
            
            
        }
    }
}