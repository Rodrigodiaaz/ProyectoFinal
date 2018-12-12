using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Post
    {
        private int idrespuesta;
        private int idusuario;
        private int idtopic;
        private string fecha;
        private string texto;

        public int Idrespuesta { get => idrespuesta; set => idrespuesta = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Idtopic { get => idtopic; set => idtopic = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Texto { get => texto; set => texto = value; }

        public Post()
        {

        }


        public bool InsertaReplica(Post p)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO respuesta_topic(id_usuario, id_topic, fecha, texto) VALUES(" + p.Idusuario + ", '" + p.Idtopic + "', '" + p.Fecha + "', '" + p.Texto + "')";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                con.cierraConexion();
            }
        }





        public bool ModificaUsuario(Usuario ua)
        {
            Conexion con = Conexion.Instance();
            try
            {
                string[] nombre = ua.Nombre.Split(' ');
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "UPDATE usuario SET primerNombre = '" + nombre[0] + "', segundoNombre = '" + nombre[1] + "', apellidoPaterno = '" + nombre[2] + "', apellidoMaterno = '" + nombre[3] + "', correo = '" + ua.Correo + "', fecha_nacimiento = '" + ua.Fecha_nacimiento + "', contrasenia = '" + ua.Pass + "', cargo = '" + ua.Cargo + "', tipo_perfil = '" + ua.Tipoperfil + "' where id_Usuario = '" + ua.Id + "'  ";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public Usuario buscaUnoCorreoRut(string correo, string rut)
        {
            Conexion con = Conexion.Instance();
            Usuario u2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM usuario WHERE correo='" + correo + "' OR rut_usuario = '" + rut + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    u2 = new Usuario();
                    u2.Id = Int32.Parse(reader[0].ToString());
                    u2.Rut = reader[1].ToString();
                    u2.Nombre = reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString();
                    u2.Correo = reader[6].ToString();
                    u2.Fecha_nacimiento = reader[7].ToString();
                    u2.Pass = reader[8].ToString();
                    u2.Cargo = reader[9].ToString();
                    u2.Tipoperfil = reader[10].ToString();
                    u2.Estado = Int32.Parse(reader[11].ToString());
                }
                return u2;
            }
            catch
            {
                return u2;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public Topic BuscaTopicId(string id)
        {
            Conexion con = Conexion.Instance();
            Topic t = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM topic WHERE id_topic=" + id + "";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t = new Topic();
                    t.Id_topic = Int32.Parse(reader[0].ToString());
                    t.Id_usuario = Int32.Parse(reader[1].ToString());
                    t.Titulo = reader[2].ToString();
                    t.Fecha = reader[3].ToString();
                    t.Texto = reader[4].ToString();
                }
                return t;
            }
            catch
            {
                return t;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public List<Post> buscaRespuestaporTopic(string idtopic)
        {
            Conexion con = Conexion.Instance();
            Post t = null;
            List<Post> lista = new List<Post>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM respuesta_topic WHERE id_topic = '"+idtopic+"' ORDER BY id_respuesta DESC";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t = new Post();
                    t.Idrespuesta = Int32.Parse(reader[0].ToString());
                    t.Idusuario = Int32.Parse(reader[1].ToString());
                    t.Idtopic = Int32.Parse(reader[2].ToString());
                    t.Fecha = reader[3].ToString();
                    t.Texto = reader[4].ToString();
                    lista.Add(t);
                }
                return lista;
            }
            catch
            {
                return lista;
            }
            finally
            {
                con.cierraConexion();
            }
        }

    }
}