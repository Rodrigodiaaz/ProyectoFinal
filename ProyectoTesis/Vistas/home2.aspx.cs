using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTesis.Controlador;
using ProyectoTesis.Modelos;
using System.Text.RegularExpressions;

namespace ProyectoTesis.Vistas
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mostrarUsuarios(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            List<Usuario> listaUsuarios = cu.cargarUsuarios();
            List<Usuario> perfiles = new List<Usuario>();
            listaBusqueda.Items.Clear();
            listaBusqueda.Items.Add("");
            string busqueda = txtBuscar.Text.ToUpper();
            foreach (Usuario u in listaUsuarios)
            {
                if (Regex.IsMatch(u.Nombre.ToUpper(), busqueda))
                {
                    listaBusqueda.Items.Add(u.Nombre);
                    perfiles.Add(u);
                }
                
            }
            listaBusqueda.Visible = true;
            Session["perfiles"] = perfiles;

        }

        protected void listaBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaBusqueda.SelectedIndex > 0 )
            {
                int pos = listaBusqueda.SelectedIndex - 1;
                List<Usuario> perfiles = (List<Usuario>)Session["perfiles"];
                Response.Redirect("perfil.aspx?id=" + perfiles[pos].Id);
            }
        }

        protected void listaBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}