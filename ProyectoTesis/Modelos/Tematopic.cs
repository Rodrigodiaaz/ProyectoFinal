using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Tematopic
    {
        private int idtematopic;
        private string tema;


        public string Tema { get => tema; set => tema = value; }
        public int Idtematopic { get => idtematopic; set => idtematopic = value; }

        public Tematopic()
        {

        }

        public bool InsertaTemaTopic(Tematopic t)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO tema_topic(tema) VALUES('"+t.Tema+"')";
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

        public Tematopic BuscaTemaTopicporid(Tematopic c)
        {
            Conexion con = Conexion.Instance();
            Tematopic c2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tema_topic WHERE id_tematopic='" + c.Tema + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    c2 = new Tematopic();
                    c2.Idtematopic = Convert.ToInt32(reader[0].ToString());
                    c2.Tema = reader[1].ToString();

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

        public List<Tematopic> BuscaTodasTrabajoSocial()
        {
            Conexion con = Conexion.Instance();
            List<Tematopic> lista = new List<Tematopic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con.usaConexion();
                comando.CommandText = "SELECT * FROM tema_topic where tema='Trabajo Social'";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tematopic c2 = new Tematopic();
                    c2.Idtematopic = Convert.ToInt32(reader[0].ToString());
                    c2.Tema = reader[1].ToString();
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

        public List<Tematopic> BuscaTodasPsicopedagogia()
        {
            Conexion con = Conexion.Instance();
            List<Tematopic> lista = new List<Tematopic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con.usaConexion();
                comando.CommandText = "SELECT * FROM tema_topic where tema='Psicopedagogía'";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tematopic c2 = new Tematopic();
                    c2.Idtematopic = Convert.ToInt32(reader[0].ToString());
                    c2.Tema = reader[1].ToString();
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

        public List<Tematopic> BuscaTodasTraduccion()
        {
            Conexion con = Conexion.Instance();
            List<Tematopic> lista = new List<Tematopic>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con.usaConexion();
                comando.CommandText = "SELECT * FROM tema_topic where tema='Traduccion'";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tematopic c2 = new Tematopic();
                    c2.Idtematopic = Convert.ToInt32(reader[0].ToString());
                    c2.Tema = reader[1].ToString();
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