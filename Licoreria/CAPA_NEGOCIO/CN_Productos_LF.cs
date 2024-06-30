using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_DATOS;
using System.Data;


namespace CAPA_NEGOCIO
{
    public class CN_Productos_LF
    {
        CD_Productos_LF cdProductos = new CD_Productos_LF();

        public bool RegistrarProductos(string detalle, float cantidad, decimal precio_c, decimal precio_v, decimal precio_h, string img)
        {
            try
            {
                if (cdProductos.RegistrarProductos(detalle, cantidad, precio_c, precio_v, precio_h, img))
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
        public DataTable BuscarProducto(int cod, string detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdProductos.BuscarProducto(cod, detalle);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdProductos.ListProductos();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public int CodProxProducto()
        {
            int cont = 0;
            try
            {
                cont = cdProductos.CodProxProducto();
                return cont;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return cont;
            }
        }
        public bool EliminarProducto(int cod)
        {
            try
            {
                if (cdProductos.EliminarProducto(cod))
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
        public bool ActualizarProducto(int cod, string detalle, float cantidad, decimal precioc, decimal precioh, decimal preciov, string img)
        {
            try
            {
                if (cdProductos.ActualizarProducto(cod, detalle, cantidad, precioc, precioh, preciov, img))
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
