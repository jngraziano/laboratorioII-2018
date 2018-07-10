using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace Entidades
{
    public static class GrupoDAO
    {
         #region Atributos y Constructor 
        private static SqlConnection Conexion;
        private static SqlCommand Comando;
        private static string TablaNombre = "dbo.Equipos";

        static GrupoDAO()
        {
            GrupoDAO.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            GrupoDAO.Comando = new SqlCommand();

            GrupoDAO.Comando.CommandType = System.Data.CommandType.Text;

            GrupoDAO.Comando.Connection = Conexion;

            GrupoDAO.Conexion.Open();
        }

        #endregion

        #region Metodos

        public static Grupo ObtieneGrupo(Grupo grupo)
        {
           string query = "select * from " + TablaNombre + "WHERE grupo = " + grupo.Group;
            
            try
            {
                
                
                EjecutarNonQuery(query);
                SqlDataReader oDr = GrupoDAO.Comando.ExecuteReader();

                if (oDr.Read())
                {
                    
                    Equipo equipoaux = new Equipo((int)oDr["id"], oDr["nombre"].ToString());
                    grupo += equipoaux;

           

                }
                oDr.Close();
                


            }
            catch (SqlException excep)
            {
                
                throw excep;
            }
            finally
            {
                    Conexion.Close();
 
            }

            return grupo;

        }

        private static bool EjecutarNonQuery(string sql)
        {
            try
            {
                // LE PASO LA INSTRUCCION SQL
                GrupoDAO.Comando.CommandText = sql;

                // EJECUTO EL COMMAND
                GrupoDAO.Comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

      

        #endregion

    }
}
