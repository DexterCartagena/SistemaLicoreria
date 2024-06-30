using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CN_Cliente_De
    {
        CD_Cliente_De oCliente = new CD_Cliente_De();
	    public string NOMBRES { get; set; }
	    public string CELULAR { get; set; }
        public string CORREO { get; set; }

        public Boolean Guardar()
        {
            if (NOMBRES.Trim() == "")
            {
                return false;
            }
            if (CELULAR.Trim() == "")
            {
                return false;
            }
            if (CORREO.Trim() == "")
            {
                return false;
            }
            try
            {
                oCliente.Guardar(NOMBRES, CELULAR, CORREO);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool Modificar(string IdCliente)
        {
            if (NOMBRES.Trim() == "")
            {
                return false;
            }
            if (CELULAR.Trim() == "")
            {
                return false;
            }
            if (CORREO.Trim() == "")
            {
                return false;
            }
            try
            {
                oCliente.Modificar(IdCliente, NOMBRES, CELULAR, CORREO);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Eliminar(string IdCliente)
        {
            if (string.IsNullOrWhiteSpace(IdCliente))
            {
                return false;
            }
            try
            {
                oCliente.Eliminar(IdCliente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean VerificarCliente(string codigo, ref DataTable TablaCliente)
        {
            int IdCliente;
            if (!int.TryParse(codigo,out IdCliente))
            {
                
                return false;
            }
            
            
            try
            {
                
                TablaCliente = oCliente.BuscarCliente(IdCliente.ToString());
                if (TablaCliente.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ListCliente()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oCliente.listCliente();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
        public bool RegistrarCliente(String nombre, string celular, string correo)
        {
            try
            {
                if (oCliente.AgregarCliente(nombre, celular, correo))
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
        public bool ModificarCliente(int cod, String nombre, string celular, string correo)
        {
            try
            {
                if (oCliente.ModificarCliente(cod, nombre, celular, correo))
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
        public bool EliminarCliente(int cod)
        {
            try
            {
                if (oCliente.EliminarCliente(cod))
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
        public DataTable BuscarCliente(int cod, string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oCliente.BuscarCliente(cod, nombre);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }
    }
}
