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
    public class CN_REPORTE
    {
        CD_REPORTE cdreporte = new CD_REPORTE();
        public DataTable Rpt_Vent_Dia(string fecha1, string fecha2)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdreporte.Rpt_Vent_Dia(fecha1,fecha2);
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
