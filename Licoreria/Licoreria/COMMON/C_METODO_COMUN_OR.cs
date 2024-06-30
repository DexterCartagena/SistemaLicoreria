using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMMON
{
    public class C_METODO_COMUN_OR
    {
        public static bool ErrorCasillaVacia(TextBox texto, ErrorProvider error, string mensaje)
        {
            if (texto.Text == "")
            {
                error.SetError(texto, "La casilla " + mensaje + " No debe estar vacia");
                return false;
            }
            else
            {
                error.Clear();
                return true;
            }
        }
        public static string CambioFormato(string ddmmyyyy)
        {
            string an;
            string mes;
            string dia;
            string yyyymmdd;
            dia = ddmmyyyy.Substring(0, 2);
            mes = ddmmyyyy.Substring(3, 2);
            an = ddmmyyyy.Substring(6, 4);
            yyyymmdd = an + mes + dia;
            return yyyymmdd;
        }
    }
}
