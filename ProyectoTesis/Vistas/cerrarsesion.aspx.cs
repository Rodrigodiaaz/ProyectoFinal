using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTesis.Vistas
{
    public partial class cerrarsesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logeado"] != null)
            {
                Session["logeado"] = null;
                Response.Redirect("index.aspx");
            }
            else
            {
                Session["logeado"] = null;
                Response.Redirect("index.aspx");
            }
        }
    }
}