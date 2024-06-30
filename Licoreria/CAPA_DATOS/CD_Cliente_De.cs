using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Cliente_De : Conexionsql
    {
        Conexionsql oConexionsql;

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand comandoQuery = new SqlCommand();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerFilas;
        DataTable tabla = new DataTable();


        public void Guardar(string NOMBRES, string CELULAR, string CORREO)
        {
            

            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "insert into CLIENTE" +
                " values('" + NOMBRES + "','" +
                CELULAR + "','" + CORREO + "')";
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();

            
        }
        public void Modificar(string IdCliente, string NOMBRES, string CELULAR, string CORREO)
        {


            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "update CLIENTE" +
                "set NOMBRES='" + NOMBRES + "'," +
                "CELULAR='"+ CELULAR + "',CORREO='" + CORREO + "where CODIGO =" + IdCliente;
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();


        }
        public void Eliminar(string IdCliente)
        {


            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "delete from CLIENTE" +
            "where CODIGO =" + IdCliente;
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();
            comandoQuery.Connection = oConexionsql.CerrarConexion();


        }

        public DataTable BuscarCliente(/*int*/string IdCliente)
        {
            comandoQuery.Connection = oConexionsql.AbrirConexion();
            comandoQuery.CommandText = "select NOMBRES, CELULAR, CORREO " +
            "from CLIENTE" +
            " where CODIGO = " + IdCliente ;

            comandoQuery.CommandType = CommandType.Text;
            Leer = comandoQuery.ExecuteReader();
            Tabla.Clear();
            Tabla.Load(Leer);
            oConexionsql.CerrarConexion();
            return Tabla;
        }

        public DataTable listCliente()
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT * FROM VistCliente";
            comando.CommandType = CommandType.Text;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            CerrarConexion();
            return tabla;
        }
        public bool AgregarCliente(string nombre, string celula, string correo)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_AgregarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@celular", celula);
            comando.Parameters.AddWithValue("@correo", correo);
            cont = comando.ExecuteNonQuery();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarCliente(int cod, string nombre, string celula, string correo)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_ModificarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@celular", celula);
            comando.Parameters.AddWithValue("@correo", correo);
            cont = comando.ExecuteNonQuery();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarCliente(int cod)
        {
            int cont = 0;
            comando.Parameters.Clear();
            comando.Connection = AbrirConexion();
            comando.CommandText = "Pr_EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            cont = comando.ExecuteNonQuery();
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable BuscarCliente(int cod, string nombre)
        {
            comando.Parameters.Clear();
            tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "BuscarCliente_OR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@nombre", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            CerrarConexion();
            return tabla;
        }
    }
}
