using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Comentario
    {
        private int idcomentario;
        private int idpublicacion;
        private int idemisor;
        private string texto;
        private string fecha;
       
        private int estado;
        // 1 si el comentario es borrado


        public int Idcomentario { get => idcomentario; set => idcomentario = value; }
        public int Idpublicacion { get => idpublicacion; set => idpublicacion = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Idemisor { get => idemisor; set => idemisor = value; }

        public Comentario(int idcomentario, int idpublicacion, int idemisor, string texto, string fecha, int estado)
        {
            this.idcomentario = idcomentario;
            this.idpublicacion = idpublicacion;
            this.idemisor = idemisor;
            this.texto = texto;
            this.fecha = fecha;
            this.estado = estado;
        }

        public Comentario()
        {

        }

        public bool insertarComentario(Comentario com)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO comentario(idpublicacion, idemisor, texto, fecha, estado) VALUES("+com.idpublicacion+", "+com.Idemisor+", '"+com.Texto+"', '"+com.Fecha+"', "+com.Estado+")";
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

        public Comentario BuscaComentario(Comentario c)
        {
            Conexion con = Conexion.Instance();
            Comentario c2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM comentario WHERE idpublicacion='" + c.idpublicacion + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    c2 = new Comentario();
                    c2.idpublicacion = Convert.ToInt32(reader[0].ToString());
                    c2.Idemisor = Convert.ToInt32(reader[1].ToString());
                    c2.Texto = reader[2].ToString();
                    c2.Fecha = reader[3].ToString();
                    c2.Estado = Convert.ToInt32(reader[4].ToString());

                }
                return c2;
            }
            catch
            {
                return c2;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public List<Comentario> Buscarcomentarios(int idpublicacion)
        {
            Conexion con = Conexion.Instance();
            List<Comentario> lista = new List<Comentario>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con.usaConexion();
                comando.CommandText = "SELECT * FROM comentario WHERE idpublicacion=" + idpublicacion + " ORDER BY idcomentario asc";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Comentario c2 = new Comentario();
                    c2.Idcomentario = Convert.ToInt32(reader[0].ToString());
                    c2.idpublicacion = Convert.ToInt32(reader[1].ToString());
                    c2.Idemisor = Convert.ToInt32(reader[2].ToString());
                    c2.Texto = reader[3].ToString();
                    c2.Fecha = reader[4].ToString();
                    c2.Estado = Convert.ToInt32(reader[5].ToString());
                    lista.Add(c2);
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