using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ProductoDAO
    {

        #region Atributos y constructor
        private static SqlConnection conexion;
        private static SqlCommand comando;

        private static string TablaNombre = "dbo.Productos";
        

        static ProductoDAO()
        {
            ProductoDAO.conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            ProductoDAO.comando = new SqlCommand();

            ProductoDAO.comando.CommandType = CommandType.Text;
            ProductoDAO.comando.Connection = ProductoDAO.conexion;
            
        }


        #endregion

        #region Metodos

        public static bool GuardarProducto(Producto p)
        {
            string query = "SELECT * FROM "+ TablaNombre;



            return EjecutarNonQuery(query);
 
        
        }

        //public List<Producto> ObtenerProductos()
        //{ }

        private static bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO.conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO.comando.ExecuteNonQuery();

                flag = true;
            }
            catch (SqlException e)
            {
                flag = false;
                throw e;
                
            }
            finally
            {
                if (flag)
                { ProductoDAO.conexion.Close(); }

            }
            return flag;
        }

        #endregion
    }
}
