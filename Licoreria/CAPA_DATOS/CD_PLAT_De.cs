using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_PLAT_De: Conexionsql
    {

        Conexionsql oConexionsql;

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand comandoQuery = new SqlCommand();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();


        public void Guardar(string USUARIO, string DETALLE, string CLAVE)
        {
            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "insert into PLATAFORMA" +
                " values('" + USUARIO + "','" +
                DETALLE + "','" + CLAVE + "')";
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();
        }

        public void Modificar(string IdUsuario, string USUARIO, string DETALLE, string CLAVE)
        {

            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "update PLATAFORMA" +
                "set USUARIO='" + USUARIO + "'," +
                "DETALLE='" + DETALLE + "',CLAVE='" + CLAVE + "where CODIGO =" + IdUsuario;
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();

        }

        public void Eliminar(string IdUsuario)
        {


            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "delete from PLATAFORMA" +
            "where CODIGO =" + IdUsuario;
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();


        }

        public DataTable listUsuario()
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection= AbrirConexion();
            comando.CommandText = "SELECT * FROM PLATAFORMA";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            CerrarConexion();
            return tabla;
        }


        public DataTable BuscarUsuario(string IdUsuario)
        {
            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "select USUARIO, DETALLE, CLAVE " +
            "from PLATAFORMA" +
            " where CODIGO = " + IdUsuario;

            comandoQuery.CommandType = CommandType.Text;
            Leer = comandoQuery.ExecuteReader();
            Tabla.Clear();
            Tabla.Load(Leer);
            oConexionsql.CerrarConexion();
            return Tabla;
        }

        public bool RegisPlataforma(string detalle, string usuario, string clave)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_RegistrarPlataforma_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarPlataforma(int cod, string detalle, string usuario, string clave)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_ModificarPlataforma_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarPlataforma(int cod)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "EliminarPlataforma_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
