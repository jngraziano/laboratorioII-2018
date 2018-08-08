using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    static class AlmacenamientoDAO
    {
        private static SqlConnection Conexion;
        private static SqlCommand Comando;

        static AlmacenamientoDAO()
        {
            AlmacenamientoDAO.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            AlmacenamientoDAO.Comando = new SqlCommand();

            AlmacenamientoDAO.Comando.CommandType = System.Data.CommandType.Text;

            AlmacenamientoDAO.Comando.Connection = AlmacenamientoDAO.Conexion;
        }

        //public bool GuardarElemento(string query)
        //{
        //    return EjecutarNonQuery(query);
        //}


        public static bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                AlmacenamientoDAO.Comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                AlmacenamientoDAO.Conexion.Open();

                // EJECUTO EL COMMAND
                AlmacenamientoDAO.Comando.ExecuteNonQuery();

                flag = true;
            }
            catch (SqlException)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                { AlmacenamientoDAO.Conexion.Close(); }
                
            }
            return flag;
        }
    }
}
