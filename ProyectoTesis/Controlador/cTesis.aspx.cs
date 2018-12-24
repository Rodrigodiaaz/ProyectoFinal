using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Modelos;

namespace ProyectoTesis.Controlador
{
    public partial class cTesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string idtesis = Request.QueryString["idtesis"];
                string tema = Request.QueryString["tema"];
                if (idtesis.Equals("") || idtesis == null || tema.Equals("") || tema == null)
                {
                    Session["mensajetesis"] = "Error al recibir parametros 1";
                    Response.Redirect("../Vistas/MenuTesis.aspx?tema=" + tema);
                }
                else
                {
                    Tesis t = new Tesis();
                    if (t.EliminarTesis(idtesis))
                    {
                        Session["mensajetesis"] = "Tesis Eliminada con exito";
                        Response.Redirect("../Vistas/MenuTesis.aspx?tema=" + tema);
                    }
                    else
                    {
                        Session["mensajetesis"] = "Error al eliminar";
                        Response.Redirect("../Vistas/MenuTesis.aspx?tema=" + tema);
                    }
                }
            }
            catch (NullReferenceException)
            {
                Session["mensajetesis"] = "Error al recibir parametros 2";
                Response.Redirect("../Vistas/MenuTesis.aspx");
            }
            
        }
    }
}