using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Data;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CN_PEDIDOS_LF
    {
        CD_PEDIDOS_LF cdpedidos = new CD_PEDIDOS_LF();

        public DataTable ListProductos()
        {
            DataTable dt = new DataTable();
            try
            {
              dt = cdpedidos.LisProdcutos();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        
        public DataTable ListClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.ListClientes();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListPedidos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.ListPedidos();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListDetallePedido()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.ListDetallePedidos();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListPlataforma()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.ListPlataforma();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public bool RegistrarPedidos(int cod_Cliente, int cod_Plataforma, string observacion, string fecha_pedido, string fecha_entrega, decimal total)
        {
            try
            {
                if (cdpedidos.RegistrarPedido(cod_Cliente, cod_Plataforma, observacion, fecha_pedido, fecha_entrega, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public bool ModificarPedidos(int cod, int cod_Cliente, int cod_Plataforma, string observacion, string fecha_pedido, string fecha_entrega, decimal total)
        {
            try
            {
                if (cdpedidos.ModficartrarPedido(cod, cod_Cliente, cod_Plataforma, observacion, fecha_pedido, fecha_entrega, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public bool RegiDetallePedido(int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            try
            {
                if (cdpedidos.RegDetallePedido(codproducto, producto, cant, precio, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public bool ModificariDetallePedido(int cod, int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            try
            {
                if (cdpedidos.ModificarDetallePedido(cod, codproducto, producto, cant, precio, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public DataTable BuscarPedido(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.BuscarPedido(cod);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable BuscarProducto(int cod, string detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.BuscarProducto(cod, detalle);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable VistDetallePedido(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdpedidos.VistDetallePedido(cod);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public bool EliminarPedido(int cod)
        {
            try
            {
                if (cdpedidos.EliminarPedido(cod))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
    }
}
