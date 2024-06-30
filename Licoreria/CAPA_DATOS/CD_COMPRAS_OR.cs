using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_COMPRAS_OR:Conexionsql
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
        public DataTable ListProvedores()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VistProveedores";
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
            comando.CommandText = "SELECT * FROM VistProductos";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public bool RegistrarComrpa(int codUser,int codProv, int nitProv, decimal total, string fecha)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "PR_COMRPA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codUser", codUser);
            comando.Parameters.AddWithValue("@codProv", codProv);
            comando.Parameters.AddWithValue("@nitProv", nitProv);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@fecha", fecha);
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
        public bool RegistroDetalleCompra(int codProducto,string detalle,int cant,decimal preciocost,decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "PR_DETALLECOMRPRA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codproducto", codProducto);
            comando.Parameters.AddWithValue("@detallePr", detalle);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@precioUni", preciocost);
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
        public DataTable ListCompras()
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistCompra";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListDetalleComrpaFiltrado(int codCommpra)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistDetalleCompraFiltrado where COD_COMPRA =" + codCommpra.ToString();
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public DataTable BuscarProducto(int cod, string detalle)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BusProducto_Or";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable BuscarProveedor(int cod,string detalle)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BusProveedor_Or";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public bool ModificarCompra(int codcompra, int codproveedor,int coduser,int nit,decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ModifCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", codcompra);
            comando.Parameters.AddWithValue("@codProveedor", codproveedor);
            comando.Parameters.AddWithValue("@codUser", coduser);
            comando.Parameters.AddWithValue("@nit", nit);
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
        public bool ModficarDetalleCompra(int codcompra, int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ModifDetalleCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codcompra", codcompra);
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
    }
}
