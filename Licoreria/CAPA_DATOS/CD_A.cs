using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CAPA_DATOS
{
    public class CD_A:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();
        public bool Revisar(string yearB, string monthB, string dayB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select a.cod as Codigo, c.detalle as Detalle, 'venta' as Tipo, d.total as Total from venta as a, usuario as b, rol as c, detalle_venta as d where d.fk_venta = a.cod and a.fecha = '" + yearB + "/" + monthB + "/" + dayB + "'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable llenarTabla(string yearB, string monthB, string dayB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "select a.cod as Codigo, c.detalle as Detalle, 'venta' as Tipo, d.total as Total from venta as a, usuario as b, rol as c, detalle_venta as d where d.fk_venta = a.cod and a.fecha = '" + yearB + "/" + monthB + "/" + dayB + "'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }

        public bool Guardar(int fk_usuario, string yearB, string monthB, string dayB, int restaA, string tipoArq, string detalle)
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "insert into Arq_Caja values (" + fk_usuario + " ,'" + yearB + "/" + monthB + "/" + dayB + "'," + restaA + ",'" + tipoArq + "','" + detalle + "')";
            comando.CommandType = CommandType.Text;
            if (comando.ExecuteNonQuery() == 1)
            {
                CerrarConexion();
                return true;
            }
            else
            {
                CerrarConexion();
                return false;
            }
        }
        public bool Revisar2(int monthB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select * from Arq_Caja where MONTH(fecha) =" + monthB;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable llenarTabla2(int monthB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select cod, detalle, fecha, valor, tipo,fk_usuario from Arq_Caja where MONTH(fecha) =" + monthB;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public bool Revisar3(int yearB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select * from Arq_Caja where year(fecha) =" + yearB;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable llenarTabla3(int yearB)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select cod, detalle, fecha, valor, tipo,fk_usuario from Arq_Caja where year(fecha) =" + yearB;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
        public bool Actualizar1(int codARQ)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "update Arq_Caja set valor = Valor where cod =" + codARQ;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
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
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "update Arq_Caja set detalle = '" + detalle + "' where cod =" + codARQ;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable llenarTabla4(int codARQ)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Select cod, detalle ,fecha from Arq_Caja where cod =" + codARQ;
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
    }
}
