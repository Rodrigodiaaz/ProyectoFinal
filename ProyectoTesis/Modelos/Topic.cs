using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Topic
    {
        private int id_topic;
        private int id_usuario;
        private string titulo;
        private string fecha;
        private string texto;
        private int tematopic;

        public int Id_topic { get => id_topic; set => id_topic = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Texto { get => texto; set => texto = value; }
        public int Tematopic { get => tematopic; set => tematopic = value; }



        public Topic(int idtopic, int idusuario, string titulo, string fecha, string texto, int tematopic)
        {
            this.id_topic = idtopic;
            this.id_usuario = idusuario;
            this.titulo = titulo;
            this.fecha = fecha;
            this.texto = texto;
            this.Tematopic = tematopic;
        }

        public Topic()
        {

        }

        public bool InsertaTopic(Topic t)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO topic(id_usuario, titulo, fecha, texto, idtematopic) VALUES(" + t.Id_usuario+", '"+t.Titulo+"', '"+t.Fecha+"', '"+t.Texto+"', "+t.Tematopic+")";
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
                    t.Tematopic = Int32.Parse(reader[5].ToString());
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

        public Topic BuscaTopicTitulo(string titulo)
        {
            Conexion con = Conexion.Instance();
            Topic t = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM topic WHERE titulo ='"+ titulo + "'";
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
                    t.Tematopic = Int32.Parse(reader[5].ToString());
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

        public List<Topic> buscaTodosLosTopics()
        {
            Conexion con = Conexion.Instance();
            Topic t = null;
            List<Topic> lista = new List<Topic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM topic ORDER BY id_topic DESC";
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
                    t.Tematopic = Int32.Parse(reader[5].ToString());
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

        public List<Topic> BuscaPorTema(int tema)
        {
            Conexion con = Conexion.Instance();
            Topic t = null;
            List<Topic> lista = new List<Topic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM topic where idtematopic = "+tema+" ORDER BY id_topic DESC";
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
                    t.Tematopic = Int32.Parse(reader[5].ToString());
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

        public List<Topic> buscaTodosLosTopics2()
        {
            Conexion con = Conexion.Instance();
            Topic t = null;
            List<Topic> lista = new List<Topic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM topic ORDER BY id_topic DESC";
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
                    t.Tematopic = Int32.Parse(reader[5].ToString());
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