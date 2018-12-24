using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public partial class cForo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string idtopic = Request.QueryString["idtopic"];
                string tema = Request.QueryString["tema"];
                if (idtopic.Equals("") || idtopic == null || tema.Equals("") || tema == null)
                {
                    Session["mensajetopic"] = "Error al recibir parametros 1";
                    Response.Redirect("../Vistas/menuTesis.aspx?tema=" + tema);
                }
                else
                {
                    Topic t = new Topic();
                    if (t.EliminarTopic(idtopic))
                    {
                        Session["mensajetopic"] = "Topic Eliminada con exito";
                        Response.Redirect("../Vistas/menuForo.aspx?tema=" + tema);
                    }
                    else
                    {
                        Session["mensajetopic"] = "Error al eliminar";
                        Response.Redirect("../Vistas/menuForo.aspx?tema=" + tema);
                    }
                }
            }
            catch (NullReferenceException)
            {
                Session["mensajetopic"] = "Error al recibir parametros 2";
                Response.Redirect("../Vistas/menuForo.aspx");
            }
        }
    }
}