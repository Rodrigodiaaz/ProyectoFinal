using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProyectoTesis.Modelos
{
    public class Tesis
    {
        private int idtesis;
        private string autor;
        private string descripcion;
        private string profesor_guia;
        private string nombre_archivo;
        private string titulo;
        private int tematesis;



        public string Autor { get => autor; set => autor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Profesor_guia { get => profesor_guia; set => profesor_guia = value; }
        public string Nombre_archivo { get => nombre_archivo; set => nombre_archivo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Idtesis { get => idtesis; set => idtesis = value; }
        public int Tematesis { get => tematesis; set => tematesis = value; }

        public Tesis()
        {

        }

        public Tesis(string id, string autor, string descripcion, string profesorguia, string nombre, string titulo, int tematesis)
        {
            this.Idtesis = Int32.Parse(id);
            this.autor = autor;
            this.descripcion = descripcion;
            this.profesor_guia = profesorguia;
            this.nombre_archivo = nombre;
            this.titulo = titulo;
            this.Tematesis = tematesis;
        }

        public bool InsertaTesis(Tesis t)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO tesis(autor,descripcion,profesor_guia,nombre_archivo,titulo,idtematesis) VALUES('" + t.Autor + "', '" + t.Descripcion + "', '" + t.Profesor_guia + "', '" + t.Nombre_archivo + "', '" + t.Titulo + "' , " + t.tematesis + ")";
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


        public bool EliminarTesis(string id)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "DELETE from tesis WHERE id_tesis='" + id + "'";
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


        public bool ModificaTesis(Tesis t)
        {
            Conexion con = Conexion.Instance();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "UPDATE tesis SET autor='" + t.Autor + "', descripcion='" + t.Descripcion + "', profesor_guia='" + t.Profesor_guia + "', nombre_archivo='" + t.Nombre_archivo + "', titulo'" + t.Titulo + "', where id_tesis = " + t.Idtesis + "  ";
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



        public Tesis buscaUnatesis(string id, string titulo)
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis WHERE id_tesis='" + id + "' OR titulo = '" + titulo + "' ";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());

                }
                return t2;
            }
            catch
            {
                return t2;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public Tesis buscaUnoID(string idtesis)
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis WHERE id_tesis='" + idtesis + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());

                }
                return t2;
            }
            catch
            {
                return t2;
            }
            finally
            {
                con.cierraConexion();
            }
        }

        public List<Tesis> buscaTodos()
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            List<Tesis> lista = new List<Tesis>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis ORDER BY id_tesis DESC";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());
                    lista.Add(t2);
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

        public List<Tesis> BuscaPorTema(int tema)
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            List<Tesis> lista = new List<Tesis>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis where idtematesis = " +tema+ " ORDER BY id_tesis DESC";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());
                    lista.Add(t2);
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

        public List<Tesis> buscaTodosLosTesis2()
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            List<Tesis> lista = new List<Tesis>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis ORDER BY id_tesis DESC";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());
                    lista.Add(t2);
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

        public Tesis BuscaPorTitulo(string titulo)
        {
            Conexion con = Conexion.Instance();
            Tesis t2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM tesis WHERE titulo='" + titulo + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new Tesis();
                    t2.Idtesis = Int32.Parse(reader[0].ToString());
                    t2.Autor = reader[1].ToString();
                    t2.Descripcion = reader[2].ToString();
                    t2.Profesor_guia = reader[3].ToString();
                    t2.Nombre_archivo = reader[4].ToString();
                    t2.Titulo = reader[5].ToString();
                    t2.tematesis = Int32.Parse(reader[6].ToString());

                }
                return t2;
            }
            catch
            {
                return t2;
            }
            finally
            {
                con.cierraConexion();
            }
        }
    }
}