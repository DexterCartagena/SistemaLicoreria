using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_Productos_LF:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();
        public bool RegistrarProductos(string detalle, float cantidad, decimal precio_c, decimal precio_v, decimal precio_h, string img)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_adProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@cantidad ", cantidad);
            comando.Parameters.AddWithValue("@precio_c", precio_c);
            comando.Parameters.AddWithValue("@precio_v", precio_v);
            comando.Parameters.AddWithValue("@precio_h", precio_h);
            comando.Parameters.AddWithValue("@img", img);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public DataTable BuscarProducto(int cod, string detalle)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BuscarProductoPro_LF";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListProductos()
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select * from vistProductosPro_LF";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public int CodProxProducto()
        {
            int cont=0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select count(*) from PRODUCTO";
            comando.CommandType = CommandType.Text;
            cont = int.Parse(comando.ExecuteScalar().ToString());
            CerrarConexion();
            return cont;
        }
        public bool EliminarProducto(int cod)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_eliminarProducto";
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
        public bool ActualizarProducto(int cod, string detalle, float cantidad, decimal precioc, decimal precioh, decimal preciov, string img)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ActualizarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precioc", precioc);
            comando.Parameters.AddWithValue("@precioh", precioh);
            comando.Parameters.AddWithValue("@preciov", preciov);
            comando.Parameters.AddWithValue("@img", img);
            cont = comando.ExecuteNonQuery();
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
