using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_REPORTE:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leeFilas;
        DataTable tabla = new DataTable();

        public DataTable Rpt_Vent_Dia(string fecha1, string fecha2)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Rpt_Vent_PorDia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaini", fecha1);
            comando.Parameters.AddWithValue("@fechafin", fecha2);
            leeFilas = comando.ExecuteReader();
            tabla.Load(leeFilas);
            CerrarConexion();
            leeFilas.Close();
            return tabla;
        }
    }
}
