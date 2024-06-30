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
    public class CN_VENTAS_GUS
    {
        CD_VENTAS_GUS cdVentasGus = new CD_VENTAS_GUS();

        public int Get_Nit()
        {
            int nit = 0;
            try 
            {
                DataTable dt = new DataTable();
                dt = cdVentasGus.Get_Nit();
                nit = Convert.ToInt32(dt.Rows[0][0].ToString());
                return nit;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return nit;
            }          
        }
        
        public DataTable ListProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdVentasGus.ListProductos();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }

        public DataTable ListClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                dt=cdVentasGus.ListClientes();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }

        public DataTable BusCliente(int Cod_Client, string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdVentasGus.BusCliente(Cod_Client, Nombre);
                return dt;                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }

        public DataTable BusProducto ( int Cod, String Detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdVentasGus.BusProducto(Cod, Detalle);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }

        public DataTable VistVentas ()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdVentasGus.vistVentas();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }

        public bool RegVenta(int codcliente, int coduser, int nit, int nroautorizacion, string fecha, decimal total)
        {
            try
            {
                if (cdVentasGus.RegVenta(codcliente, coduser, nit, nroautorizacion, fecha, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public bool RegDetalleVenta(int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            try
            {
                if (cdVentasGus.RegDetalleVenta(codproducto, producto, cant, precio, total))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public DataTable ListDetalleVenta(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdVentasGus.ListDetalleVenta(cod);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
    }
}
