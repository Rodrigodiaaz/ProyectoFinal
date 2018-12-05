using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.modelos
{
    public class Usuario
    {
        private int id;
        private string rut;
        private string nombre;
        private string correo;
        private string pass;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pass { get => pass; set => pass = value; }

        public Usuario(int id, string rut, string nombre, string correo, string pass)
        {
            this.id = id;
            this.rut = rut;
            this.nombre = nombre;
            this.correo = correo;
            this.pass = pass;
        }

        public Usuario()
        {
        }

        public bool insertaUsuario(Usuario u)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO usuario (rut_usuario, nombre_usuario, correo, contrasenia) VALUES('" + u.rut +"', '"+ u.nombre +"', '" + u.correo +"', '" + u.pass + "')";
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

        public Usuario buscaUno(String correo, String rut)
        {
            Conexion con = Conexion.Instance();
            Usuario u2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM usuario WHERE correo='" + correo + "' OR rut_usuario = '" + rut +"'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    u2 = new Usuario();
                    u2.Id = Int32.Parse(reader[0].ToString());
                    u2.Rut = reader[1].ToString();
                    u2.Nombre = reader[2].ToString();
                    u2.Correo = reader[3].ToString();
                    u2.Pass = reader[4].ToString();
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
    }
}