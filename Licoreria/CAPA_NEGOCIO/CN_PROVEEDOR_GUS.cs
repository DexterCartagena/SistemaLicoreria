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
    public class CN_PROVEEDOR_GUS
    {
        CD_PROVEEDORES_GUS cdProveedorGus = new CD_PROVEEDORES_GUS();


        public DataTable ListaProveedores()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdProveedorGus.ListaProveedores();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;
            }
        }


        public bool Ag_ModProveedor(int cod_Proveedor, string nombre, int nit, string telefono)
        {
            try
            {
                if (cdProveedorGus.Ag_ModProveedor(cod_Proveedor, nombre, nit, telefono))
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

        public bool ElimProveedor(int cod_Proveedor)
        {
            try
            {
                if (cdProveedorGus.ElimProveedor(cod_Proveedor))
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

        public DataTable BuscProveedor(int cod_Proveedor, string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdProveedorGus.BuscProveedor(cod_Proveedor, nombre);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return dt;

            }
        }


        
    }

}