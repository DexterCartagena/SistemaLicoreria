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
    public class CN_A
    {
        CD_A oCD_A = new CD_A();

        public bool Revisar(string yearB, string monthB, string dayB)
        {
            if (oCD_A.Revisar(yearB, monthB, dayB))
            {
                llenarTabla(yearB, monthB, dayB);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable llenarTabla(string yearB, string monthB, string dayB)
        {
            DataTable DtsCons = new DataTable();
            DtsCons = oCD_A.llenarTabla(yearB, monthB, dayB);
            try
            {
                DtsCons = oCD_A.llenarTabla(yearB, monthB, dayB);
                return DtsCons;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return DtsCons;
            }
        }
        public bool Guardar(int fk_usuario, string yearB, string monthB, string dayB, int restaA, string tipoArq, string detalle)
        {
            if (oCD_A.Guardar(fk_usuario, yearB, monthB, dayB, restaA, tipoArq, detalle))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Revisar2(int monthB)
        {
            if (oCD_A.Revisar2(monthB))
            {
                llenarTabla2(monthB);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable llenarTabla2(int monthB)
        {
            DataTable DtsCons = new DataTable();
            DtsCons = oCD_A.llenarTabla2(monthB);
            try
            {
                DtsCons = oCD_A.llenarTabla2(monthB);
                return DtsCons;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return DtsCons;
            }
        }
        public bool Revisar3(int yearB)
        {
            if (oCD_A.Revisar3(yearB))
            {
                llenarTabla3(yearB);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable llenarTabla3(int yearB)
        {
            DataTable DtsCons = new DataTable();
            DtsCons = oCD_A.llenarTabla3(yearB);
            try
            {
                DtsCons = oCD_A.llenarTabla3(yearB);
                return DtsCons;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return DtsCons;
            }
        }
        public bool Actualizar1(int codARQ)
        {
            if (oCD_A.Actualizar1(codARQ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Actualizar2(string detalle, int codARQ)
        {
            if (oCD_A.Actualizar2(detalle, codARQ))
            {
                llenarTabla4(codARQ);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable llenarTabla4(int codARQ)
        {
            DataTable DtsCons = new DataTable();
            DtsCons = oCD_A.llenarTabla4(codARQ);
            try
            {
                DtsCons = oCD_A.llenarTabla4(codARQ);
                return DtsCons;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return DtsCons;
            }
        }
    }
}
