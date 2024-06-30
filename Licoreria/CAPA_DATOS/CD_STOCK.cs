using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_STOCK:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leeFilas;
        DataTable tabla = new DataTable();

        public DataTable ListStock()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistStock_OR";
            comando.CommandType = CommandType.Text;
            leeFilas = comando.ExecuteReader();
            tabla.Load(leeFilas);
            CerrarConexion();
            leeFilas.Close();
            return tabla;
        }
        public DataTable BuscarStock(int cod, string detalle)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BuscarSotck_Or";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            leeFilas = comando.ExecuteReader();
            tabla.Load(leeFilas);
            CerrarConexion();
            leeFilas.Close();
            return tabla;
        }
        public bool ActualizarStock(int cod, int cant, int cantmin)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ActuStock_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@cantmin", cantmin);
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
