using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Notificacion
    {
        private int idNotificacion;
        //referencia a si la notificacion es vista o no
        private int estado;
        private int idPost;
        private int idUsuario;

        public int IdNotificacion { get => idNotificacion; set => idNotificacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public int IdPost { get => idPost; set => idPost = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public Notificacion()
        {

        }
        public Notificacion(string idnotificacion, string estado, string idpost, string idusuario)
        {
            this.idNotificacion = Int32.Parse(idnotificacion);
            this.estado = Int32.Parse(estado);
            this.idPost = Int32.Parse(idpost);
            this.idUsuario = Int32.Parse(idusuario);
        }

        public Boolean insertaNotitifacion(Notificacion n)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO notificaciones(estado, idpost, idusuario) VALUES('" + n.Estado + "','" + n.IdPost + "','" + n.IdUsuario + "')";
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
        public bool modificaNotificacion(Notificacion n)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "UPDATE notificaciones SET estado='" + n.Estado + "', idpost='" + n.IdPost + "' idusuario='" + n.IdUsuario + "'";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
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
        public bool eliminaNotificacion(Notificacion n)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "DELETE FROM notificaciones WHERE idnotificacion='" + n.IdNotificacion + "';";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
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
        public List<Notificacion> buscaTodosDe(Usuario u)
        {
            Conexion con = Conexion.Instance();
            Notificacion u2 = null;
            List<Notificacion> lista = new List<Notificacion>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM notificaciones WHERE idusuario='" + u.Id + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    u2 = new Notificacion();
                    u2.IdNotificacion = Int32.Parse(reader[0].ToString());
                    u2.Estado = reader.GetByte("visto");
                    u2.IdPost = Convert.ToInt32(reader[2].ToString());
                    u2.idUsuario = Int32.Parse(reader[3].ToString());
                    lista.Add(u2);
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
        public List<Notificacion> buscaTodos(Notificacion n)
        {
            Conexion con = Conexion.Instance();
            List<Notificacion> lista = new List<Notificacion>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM notificaciones";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    n = new Notificacion();
                    n.IdNotificacion = Int32.Parse(reader["idnotificacion"].ToString());
                    n.estado = Int32.Parse(reader["estado"].ToString());
                    n.IdPost = Int32.Parse(reader["idpost"].ToString());
                    n.IdUsuario = Int32.Parse(reader["idusuario"].ToString());
                    lista.Add(n);
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
        public bool cambiaEstado(Usuario us)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "UPDATE notificaciones SET visto=1 WHERE usuario = '" + us.Id + "'";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
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
    }
}