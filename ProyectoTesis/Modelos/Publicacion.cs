using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProyectoTesis.Modelos
{
    public class Publicacion
    {
        private int idpublicacion;
        private string fecha;
        private string texto;
        private string idEmisor;
        private string idReceptor;
        //estado especifica si una publicacion es borrada, se especifica por valores 0 y 1, 1 es desactivada.
        private int estado;

        public int Idpublicacion { get => idpublicacion; set => idpublicacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Texto { get => texto; set => texto = value; }
        public string IdEmisor { get => idEmisor; set => idEmisor = value; }
        public string IdReceptor { get => idReceptor; set => idReceptor = value; }
        public int Estado { get => estado; set => estado = value; }

        public Publicacion()
        {

        }

        public Publicacion(string id, string fecha, string texto, string idemisor, string idReceptor, string estado)
        {
            this.idpublicacion = Int32.Parse(id);
            this.fecha = fecha;
            this.texto = texto;
            this.idEmisor = idemisor;
            this.idReceptor = idReceptor;
            this.estado = Int32.Parse(estado);
        }

        public bool insertarPost(Publicacion po)
        {
            Conexion con = Conexion.Instance();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                con.abreConexion();
                comando.CommandText = "INSERT INTO publicacion(idpublicacion, texto, idemisor, idreceptor, estado, fecha) VALUES(" + po.idpublicacion + ",'" + po.Texto + "','" + po.IdEmisor + "', '" + po.IdReceptor + "' , '"+ po.Estado +"', '"+po.Fecha+"' )";
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

        public Publicacion buscaCreador(Publicacion po)
        {
            Conexion con = Conexion.Instance();
            Publicacion po2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM publicacion WHERE idemisor='" + po.IdEmisor + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    po2 = new Publicacion();
                    po2.idpublicacion = Convert.ToInt32(reader[0].ToString());
                    po2.Texto = reader[1].ToString();
                    po2.idEmisor = reader[2].ToString();
                    po2.idReceptor = reader[3].ToString();
                    po2.Estado = Convert.ToInt32(reader[4].ToString());
                    po2.fecha = reader[5].ToString();
                }
                return po2;
            }
            catch
            {
                return po2;
            }
            finally
            {
                con.cierraConexion();
            }
        }
        public Publicacion buscaReceptor(Publicacion po)
        {
            Conexion con = Conexion.Instance();
            Publicacion po2 = null;
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM publicacion WHERE idreceptor='" + po.IdReceptor + "'";
                comando.Connection = con.usaConexion();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    po2 = new Publicacion();
                    po2.idpublicacion = Convert.ToInt32(reader[0].ToString());
                    po2.Texto = reader[1].ToString();
                    po2.idEmisor = reader[2].ToString();
                    po2.idReceptor = reader[3].ToString();
                    po2.Estado = Convert.ToInt32(reader[4].ToString());
                    po2.fecha = reader[5].ToString();
                }
                return po2;
            }
            catch
            {
                return po2;
            }
            finally
            {
                con.cierraConexion();
            }
        }
        public bool registraPost2(string texto, string idemisor, string idreceptor, int tipopost, int estado, string fecha)
        {
            Conexion con = Conexion.Instance();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "INSERT INTO publicacion (texto,idemisor,idreceptor,estado,fecha) VALUES('" + texto + "','" + idemisor + "','" + idreceptor + "', '"+ estado +"', '"+fecha+"')";
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
        public List<Publicacion> buscaMuro(string idreceptor)
        {
            Conexion con = Conexion.Instance();
            List<Publicacion> lista = new List<Publicacion>();
            try
            {
                con.abreConexion();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con.usaConexion();
                comando.CommandText = "SELECT * FROM publicacion WHERE idreceptor='" + idreceptor + "' ORDER BY idpublicacion DESC";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Publicacion po2 = new Publicacion();
                    po2.idpublicacion = Convert.ToInt32(reader[0].ToString());
                    po2.Texto = reader[1].ToString();
                    po2.idEmisor = reader[2].ToString();
                    po2.idReceptor = reader[3].ToString();
                    po2.Estado = Convert.ToInt32(reader[4].ToString());
                    po2.fecha = reader[5].ToString();
                    lista.Add(po2);
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