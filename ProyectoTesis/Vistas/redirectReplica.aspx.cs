using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Controlador;

namespace ProyectoTesis.Vistas
{
    public partial class redirectReplica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logeado"] != null)
            {
                string idtopic = Request.QueryString["idtopic"];
                string texto = Request.QueryString["texto"];
                string idusuario = Request.QueryString["idusuario"];
                ControladorReplica cr = new ControladorReplica();
                if (cr.insertarReplica(idusuario, idtopic, texto))
                {
                    Response.Redirect("foro.aspx?idtopic=" + idtopic);
                }
                else
                {
                    Session["mensaje"] = "Error al realizar replica.";
                    Response.Redirect("foro.aspx?idtopic=" + idtopic);
                }

            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}