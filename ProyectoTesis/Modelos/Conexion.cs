using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTesis.Modelos
{
    public class Conexion
    {
        private MySqlConnection con;
        private static Conexion instance;
        private Conexion()
        {
            con = new MySqlConnection("server=localhost;port=3306;Uid=root;Pwd=;database=proyecto;");
        }
        public static Conexion Instance()
        {
            if (instance == null)
                instance = new Conexion();
            return instance;
        }
        public void abreConexion()
        {
            con.Open();
        }
        public void cierraConexion()
        {
            con.Close();
        }
        public MySqlConnection usaConexion()
        {
            return con;
        }

    }
}