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
        public static bool ErrorCasillaVaciaNumerica(NumericUpDown texto, ErrorProvider error, string mensaje)
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
        public static bool ValidacionFormatoFehca(TextBox ddmmyyyy,ErrorProvider error)
        {
            if (ddmmyyyy.Text.Length == 10)
            {
                int cont=0;
                int contNum = 0;
                foreach(char caracter in ddmmyyyy.Text)
                {
                    if (caracter == '/')
                    {
                        cont = cont + 1;
                    }
                    if (char.IsDigit(caracter))
                    {
                        contNum = contNum + 1;
                    }
                }
                if(cont==2 && contNum == 8)
                {
                    if (Convert.ToInt32(ddmmyyyy.Text.Substring(0, 2)) <= 31)
                    {
                        if (Convert.ToInt32(ddmmyyyy.Text.Substring(3, 2)) <= 12)
                        {
                            if (Convert.ToInt32(ddmmyyyy.Text.Substring(6,4)) > 2020)
                            {
                                error.Clear();
                                return true;
                            }
                            else
                            {
                                error.SetError(ddmmyyyy, "Error de año incoherente");
                                return false;
                            }
                        }
                        else
                        {
                            error.SetError(ddmmyyyy, "Error de mes incoherente");
                            return false;
                        }
                    }
                    else
                    {
                        error.SetError(ddmmyyyy, "Error de de dia incoherente");
                        return false;
                    }
                }
                else
                {
                    error.SetError(ddmmyyyy, "Error de formato de fecha (dd/mm/yyyy)");
                    return false;
                }
            }
            else
            {
                error.SetError(ddmmyyyy, "Error de longitud de fecha");
                return false;
            }
        }
    }
}
