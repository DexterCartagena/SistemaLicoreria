using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class Class1: Conexionsql
    {
        //Si lees esto, suerte c:

        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();

        public DataTable listRegistrosOficial()
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VIS_REGPRODUCT";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            CerrarConexion();
            return tabla;
        }
    }
}
