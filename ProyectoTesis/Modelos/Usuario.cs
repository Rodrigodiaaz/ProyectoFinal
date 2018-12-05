using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Usuario
    {
        private int id;
        private string rut;
        private string nombre;
        private string correo;
        private string pass;
        private string fecha_nacimiento;
        private string cargo;
        private int estado;
        private string tipoperfil;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Tipoperfil { get => tipoperfil; set => tipoperfil = value; }

        public Usuario(int id, string rut, string nombre, string correo, string pass, string fechaNacimiento, string cargo, int estado, string tipoperfil )
        {
            this.id = id;
            this.rut = rut;
            this.nombre = nombre;
            this.correo = correo;
            this.pass = pass;
            this.fecha_nacimiento = fechaNacimiento;
            this.cargo = Cargo;
            this.estado = estado;
            this.Tipoperfil = tipoperfil;
        }

        public Usuario()
        {
        }

        public bool insertaUsuarioAlumno(Usuario ua)
        {
            Conexion con = Conexion.Instance();
            try
            {
                string[] nombre = ua.Nombre.Split(' ');
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO usuario (rut_usuario, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, correo, fecha_nacimiento, contrasenia, cargo, tipo_perfil, estado) VALUES('" + ua.Rut + "', '" + nombre[0] + "', '" + nombre[1] + "', '" + nombre[2] + "', '" + nombre[3] + "', '" + ua.Correo + "', '" + ua.Fecha_nacimiento + "', '" + ua.Pass + "', '" + ua.Cargo + "', '" + ua.Tipoperfil + "', " + ua.Estado + ")";
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

        public Usuario buscaUnoID(string idusuario)
        {
            Conexion con = Conexion.Instance();
            Usuario u2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM usuario WHERE id_usuario='" + idusuario + "'";
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

        public List<Usuario> buscaTodos()
        {
            Conexion con = Conexion.Instance();
            Usuario u2 = null;
            List<Usuario> lista = new List<Usuario>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM usuario";
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

    }
}