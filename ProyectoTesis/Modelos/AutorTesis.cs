using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class AutorTesis
    {
        private int id_autor;
        private string nombre;
        private int id_tesis;

        public int Id_autor { get => id_autor; set => id_autor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }

        public AutorTesis()
        {

        }


        public bool InsertaAutorTesis(AutorTesis t)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO autor_tesis(nombre, id_tesis) VALUES('"+t.Nombre+"', "+Id_tesis+")";
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

        public List<AutorTesis> BuscaAutorTesis(string id)
        {
            Conexion con = Conexion.Instance();
            AutorTesis t2 = null;
            List<AutorTesis> lista = new List<AutorTesis>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM autor_tesis where id_tesis = '"+id+"'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    t2 = new AutorTesis();
                    t2.Id_autor = Int32.Parse(reader[0].ToString());
                    t2.Nombre = reader[1].ToString();
                    t2.Id_tesis = Int32.Parse(reader[2].ToString());
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


    }
}