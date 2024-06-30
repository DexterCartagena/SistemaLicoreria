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
        public bool LoginUsuario(string usuario, string clave)
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select *, (select detalle from ROL where cod=pk_rol) as RolDetalle from usuario where nombre = '" + usuario + "' and clave = '" + clave + "'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
            {
                COMMON.C_USUARIO.cod = int.Parse(tabla.Rows[0]["cod"].ToString());
                COMMON.C_USUARIO.Codrol = int.Parse(tabla.Rows[0]["pk_rol"].ToString());
                COMMON.C_USUARIO.rol = tabla.Rows[0]["RolDetalle"].ToString();
                COMMON.C_USUARIO.nombre = tabla.Rows[0]["nombre"].ToString();
                COMMON.C_USUARIO.clave = tabla.Rows[0]["clave"].ToString();
                COMMON.C_USUARIO.ci = tabla.Rows[0]["ci"].ToString();
                COMMON.C_USUARIO.fechaIng = tabla.Rows[0]["fecha_ing"].ToString();
                COMMON.C_USUARIO.celular = tabla.Rows[0]["celular"].ToString();


                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
