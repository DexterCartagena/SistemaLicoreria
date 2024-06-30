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
    public class CN_USUARIO_OR
    {
        CD_USUARIO_OR cdusuarioor = new CD_USUARIO_OR();

        public DataTable ListUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdusuarioor.ListUsuarios();
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable BuscarUsuario(int cod, string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdusuarioor.BuscarUsuario(cod, nombre);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public DataTable ListRol()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdusuarioor.ListRol();
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public bool RegModUsuario(int cod, int rol, string nombre, string clave, string ci, string fecha, string celular)
        {
            try
            {
                if (cdusuarioor.RegisModUsuario(cod, rol, nombre, clave, ci, fecha, celular))
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
        public bool EliminarUsuario(int cod)
        {
            try
            {
                if (cdusuarioor.EliminarUsuario(cod))
                {
                    return true;
                }else
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
