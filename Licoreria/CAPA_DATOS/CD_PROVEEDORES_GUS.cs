using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_PROVEEDORES_GUS:Conexionsql
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();


        public DataTable ListaProveedores()
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM vistProveedores_GUS";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }



        public bool Ag_ModProveedor(int cod_Proveedor, string nombre, int nit, string telefono )
        {
            int cont = 0;

            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prAgregarModificar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod_Proveedor);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nit", nit );
            comando.Parameters.AddWithValue("@telefono", telefono);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool ElimProveedor(int cod_Proveedor)
        {
            int cont = 0;

            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prEliminarProv_GUS";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod_Proveedor);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        /*public bool BuscProveedor(int cod_Proveedor, string nombre)
        {
            int cont = 0;

            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prBuscProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod_Proveedor);
            comando.Parameters.AddWithValue("@nombre", nombre);
            cont = comando.ExecuteNonQuery();
            CerrarConexion();
            if (cont > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }*/

        //no tiene funcionalida prevista
        public DataTable BuscProveedor(int cod_Proveedor, string nombre)
        {
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "prBuscProveedor @cod='"+cod_Proveedor+"' ,@nombre='"+nombre+"'";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            CerrarConexion();
            leerFilas.Close();
            return tabla;
        }
    }
}
