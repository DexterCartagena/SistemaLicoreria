using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_VENTAS_GUS:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();

        public DataTable Get_Nit()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT nit from Empresa";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        

        public DataTable ListProductos()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VistProductos_GUS";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public DataTable ListClientes()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VistClientes_GUS";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public DataTable BusCliente(int Cod_Client, string Nombre)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prBuscCliente @cod='"+Cod_Client+"' ,@nombre='"+Nombre+"'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public DataTable BusProducto (int Cod, string Detalle)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prBuscProducto @cod='" + Cod + "', @detalle='" + Detalle + "'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        
        public DataTable vistVentas ()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VistVentas_GUS";
            comando.CommandType = CommandType.Text;
            leerFilas=comando.ExecuteReader ();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public bool RegVenta(int codcliente,int coduser, int nit, int nroautorizacion, string fecha, decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "RegVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codcliente", codcliente);
            comando.Parameters.AddWithValue("@coduser", coduser);
            comando.Parameters.AddWithValue("@nitcliente", nit);
            comando.Parameters.AddWithValue("@nroautorizacion", nroautorizacion);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@total", total);
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
        public bool RegDetalleVenta(int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "RegDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codproducto", codproducto);
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@total", total);
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
        public DataTable ListDetalleVenta(int cod)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "FiltrarDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            return tabla;
        }
    }
}
