using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new A_inicio());
            //Uy con que viniste hasta aqui, para que tu form arranque de primera pantalla cambio el Form1 de arriba por el de tu formulario
            //Suerte c:
        }
    }
}
