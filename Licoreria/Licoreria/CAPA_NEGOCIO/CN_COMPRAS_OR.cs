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
    public class CN_COMPRAS_OR
    {
        CD_COMPRAS_OR cdComprasOr = new CD_COMPRAS_OR();


        public int Get_Nit()
        {
            int nit=0;
            try
            {
                DataTable dt = new DataTable();
                dt = cdComprasOr.Get_Nit();
                nit = Convert.ToInt32(dt.Rows[0][0].ToString());
                return nit;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return nit;
            }
        }

        public DataTable ListProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.ListProductos();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }

        public DataTable ListProveedor()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.ListProvedores();
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public bool registrarComrpa(int codUser, int codProv, int nitProv, decimal total,string fecha)
        {
            try
            {
                if (cdComprasOr.RegistrarComrpa(codUser, codProv, nitProv, total, fecha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return false;
            }
        }
        public bool RegistroDetalleCompra(int codProducto, string detalle, int cant, decimal preciocost, decimal total)
          {
            try
            {
                if (cdComprasOr.RegistroDetalleCompra(codProducto, detalle, cant, preciocost, total)) {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return false;
            }
        
        }
        public DataTable ListCompra()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.ListCompras();
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListDetalleComrpaFiltrado(int codCompra)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.ListDetalleComrpaFiltrado(codCompra);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable BuscarProducto(int cod,string detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.BuscarProducto(cod,detalle);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable BuscarProveedor(int cod, string detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdComprasOr.BuscarProveedor(cod, detalle);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public bool ModificarCompra(int codcompra, int codproveedor, int coduser, int nit, decimal total)
        {
            try
            {
                if (cdComprasOr.ModificarCompra(codcompra, codproveedor, coduser, nit, total))
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
        public bool ModificarDetalleCompra(int codcompra, int codproducto, string producto, int cant, decimal precio, decimal total)
        {
            try
            {
                if (cdComprasOr.ModficarDetalleCompra(codcompra, codproducto, producto, cant, precio, total))
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
    }
}
