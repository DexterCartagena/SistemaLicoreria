using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_PEDIDOS_LF : Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();

        public DataTable LisProdcutos()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM vistProductos_LF";
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
            comando.Connection= AbrirConexion();
            comando.CommandText = "select * from VistClientes";
            comando.CommandType= CommandType.Text;
            leerFilas= comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListDetallePedidos()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistDetallePedido";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListPedidos()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select * from VistPedidos";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public DataTable ListPlataforma()
        {
            comando.Parameters.Clear();
            comando.Connection= AbrirConexion();
            comando.CommandText = "Select * from LisPlataforma";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public bool RegistrarPedido(int cod_Cliente, int cod_Plataforma, string obeservacion, string fecha_pedido, string fecha_entrega, decimal total)
        {
            int cont = 0;

            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_adPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_Cliente",cod_Cliente);
            comando.Parameters.AddWithValue("@cod_Plataforma", cod_Plataforma);
            comando.Parameters.AddWithValue("@observacion", obeservacion);
            comando.Parameters.AddWithValue("@fecha_pedido", fecha_pedido);
            comando.Parameters.AddWithValue("@fecha_entrega", fecha_entrega);
            comando.Parameters.AddWithValue("@total", total);
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
        public bool ModficartrarPedido(int cod,int cod_Cliente, int cod_Plataforma, string obeservacion, string fecha_pedido, string fecha_entrega, decimal total)
        {
            int cont = 0;

            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ModfPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@codcliente", cod_Cliente);
            comando.Parameters.AddWithValue("@codplataforma", cod_Plataforma);
            comando.Parameters.AddWithValue("@observacion", obeservacion);
            comando.Parameters.AddWithValue("@fechaped", fecha_pedido);
            comando.Parameters.AddWithValue("@fechaent", fecha_entrega);
            comando.Parameters.AddWithValue("@total", total);
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
        public bool RegDetallePedido(int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_RegDetallePedido";
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
        public bool ModificarDetallePedido(int cod, int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "ModfDetallePedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codpedido", cod);
            comando.Parameters.AddWithValue("@codproducto", codproducto);
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cantidad", cant);
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
        public DataTable BuscarPedido(int cod)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BusquedaPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
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
            comando.CommandText = "BuscarProducto_LF";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@detalle", detalle);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            return tabla;
        }
        public DataTable VistDetallePedido(int cod)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "VistDetallePedido_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            return tabla;
        }
        public bool EliminarPedido(int cod)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "EliminarPediddo";
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
