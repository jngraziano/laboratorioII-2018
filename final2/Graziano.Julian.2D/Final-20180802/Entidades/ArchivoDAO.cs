using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    static class ArchivoDAO
    {
        private static SqlConnection Conexion;
        private static SqlCommand Comando;
       

        static ArchivoDAO()
        {
            ArchivoDAO.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            ArchivoDAO.Comando = new SqlCommand();

            ArchivoDAO.Comando.CommandType = System.Data.CommandType.Text;

            ArchivoDAO.Comando.Connection = ArchivoDAO.Conexion;
        }

        public static bool Insertar(string query)
        {
          
            return EjecutarNonQuery(query);

        }

        public static SqlDataReader ObtengoArchivos(string comandoTexto)
        {
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ArchivoDAO.Comando.CommandText = comandoTexto;

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = ArchivoDAO.Comando.ExecuteReader();

            

                return oDr;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        private static bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ArchivoDAO.Comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ArchivoDAO.Conexion.Open();

                // EJECUTO EL COMMAND
                ArchivoDAO.Comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                { ArchivoDAO.Conexion.Close(); }
                
            }
            return flag;
        }
    }
}
