using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    

    public static class PaqueteDAO
    {
        #region Atributos y Constructor 
        private static SqlConnection Conexion;
        private static SqlCommand Comando;
        private static string TablaNombre = "Paquetes";

        static PaqueteDAO()
        {
            PaqueteDAO.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            PaqueteDAO.Comando = new SqlCommand();

            PaqueteDAO.Comando.CommandType = System.Data.CommandType.Text;

            PaqueteDAO.Comando.Connection = PaqueteDAO.Conexion;
        }

        #endregion

        #region Metodos


        #region Obtengo paquete (de la BD)
        /// <summary>
        /// Leer elementos de la base de datos.
        /// </summary>
        /// <param name="comandoTexto"></param>
        /// <returns></returns>
        public static SqlDataReader ObtieneObjeto(string comandoTexto)
        {
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO.Comando.CommandText = comandoTexto;

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PaqueteDAO.Comando.ExecuteReader();

                /*
                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    obj = new Object(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString(), int.Parse(oDr["dni"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();
                */

                return oDr;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Insertar Paquete
        public static bool Insertar(Paquete p)
        {
            //Creo la query
            string query = "INSERT INTO " + TablaNombre + " (direccionEntrega,trackingID,alumno) VALUES(";
            query += "'" + p.DireccionEntrega + "','" + p.TrackingID + "', 'JulianGraziano')";

            return EjecutarNonQuery(query);

        }
        #endregion

        #region Modificar Paquete
        public static bool ModificaPaquete(Paquete p)
        {
            string sql = "UPDATE Personas SET nombre = '" + "p.Nombre" + "', apellido = '";
            sql = sql + "p.Apellido" + "', dni = " + "p.DNI.ToString()" + " WHERE id = " + "p.ID.ToString()";

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar Paquete
        public static bool EliminaPaquete(Paquete p)
        {

            string sql = "DELETE FROM Personas WHERE id = " + "p.ID.ToString()";

            return EjecutarNonQuery(sql);
        }
        #endregion



        private static bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO.Comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO.Conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO.Comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                { PaqueteDAO.Conexion.Close(); }
                   
            }
            return flag;
        }
      

        #endregion


    }
}
