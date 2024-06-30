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
    public class CN_PLAT_De
    {
        CD_PLAT_De oPlataforma = new CD_PLAT_De();
        public string USUARIO { get; set; }
        public string DETALLE { get; set; }
        public string CLAVE { get; set; }

        public Boolean Guardar()
        {
            if (USUARIO.Trim() == "")
            {
                return false;
            }
            if (DETALLE.Trim() == "")
            {
                return false;
            }
            if (CLAVE.Trim() == "")
            {
                return false;
            }
            try
            {
                oPlataforma.Guardar(USUARIO, DETALLE, CLAVE);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modificar(string IdUsuario)
        {
            if (USUARIO.Trim() == "")
            {
                return false;
            }
            if (DETALLE.Trim() == "")
            {
                return false;
            }
            if (CLAVE.Trim() == "")
            {
                return false;
            }
            try
            {
                oPlataforma.Modificar(IdUsuario, USUARIO, DETALLE, CLAVE);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(string IdUsuario)
        {
            if (string.IsNullOrWhiteSpace(IdUsuario))
            {
                return false;
            }
            try
            {
                oPlataforma.Eliminar(IdUsuario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ListUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oPlataforma.listUsuario();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return dt;
            }
        }

        public Boolean VerificarUsuario(string codigo, ref DataTable TablaUsuario)
        {
            int IdUsuario;
            if (!int.TryParse(codigo, out IdUsuario))
            {

                return false;
            }


            try
            {

                TablaUsuario = oPlataforma.BuscarUsuario(IdUsuario.ToString());
                if (TablaUsuario.Rows.Count == 0)
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
        public bool RegPlataforma(string detalle, string usuario, string clave)
        {
            try
            {
                if (oPlataforma.RegisPlataforma(detalle,usuario,clave))
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
        public bool ModificarPlataforma(int cod, string detalle, string usuario, string clave)
        {
            try
            {
                if (oPlataforma.ModificarPlataforma(cod, detalle, usuario, clave))
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
        public bool EliminarPlataforma(int cod)
        {
            try
            {
                if (oPlataforma.EliminarPlataforma(cod))
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
