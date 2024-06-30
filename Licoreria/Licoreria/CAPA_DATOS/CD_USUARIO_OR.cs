using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_USUARIO_OR:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();

        public DataTable ListUsuarios()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistUsuario";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable BuscarUsuario(int cod, string nombre)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BuscarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@nombre", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListRol()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from ListRol";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public bool RegisModUsuario(int cod,int rol, string nombre, string clave, string ci, string fecha, string celular)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "addModfrUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@celular", celular);
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
        public bool EliminarUsuario(int cod)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "pr_EliminarUsuario";
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
