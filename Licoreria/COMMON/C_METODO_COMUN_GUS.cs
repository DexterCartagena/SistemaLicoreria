using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMMON
{
    public class C_METODO_COMUN_GUS
    {
        public static bool ErrorCasillaVacia(TextBox texto, ErrorProvider error,string mensaje)
        {
            if(texto.Text == "")
            {
                error.SetError(texto, " La casilla " + mensaje + " No debe estar vacia");
                return false;
            }
            else
            {
                error.Clear();
                return true;
            }
        }


    }
}
