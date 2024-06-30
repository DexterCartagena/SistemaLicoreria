using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CN_STOCK
    {
        CD_STOCK cdstock = new CD_STOCK();

        public DataTable ListStock()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdstock.ListStock();
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable BuscarStock(int cod, string detalle)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdstock.BuscarStock(cod, detalle);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
           
        }
        public bool ActualizarStock(int cod, int cant, int cantmin)
        {
            try
            {
                if (cdstock.ActualizarStock(cod, cant, cantmin))
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
