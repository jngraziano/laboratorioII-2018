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
        
        #region Atributos y Constructor 
        private static SqlConnection Conexion;
        private static SqlCommand Comando;
        private static string TablaNombre = "dbo.Productos";

        static ProductoDAO()
        {
            ProductoDAO.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            ProductoDAO.Comando = new SqlCommand();

            ProductoDAO.Comando.CommandType = System.Data.CommandType.Text;

            ProductoDAO.Comando.Connection = ProductoDAO.Conexion;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Guardo un producto dependiendo si es A o B
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool GuardarProducto(Producto p)
        {

            //Creo la query
            string query = "Abajo estan las querys";

            //FEDE HAGO LO QUE ME DIJISTE, LO COMENTO PARA QUE COMPILE

            //if (p is ProductoA)
            //{
            //    query = "INSERT INTO " + TablaNombre + " (descripcion,tipo,diametro,material,largo,alto,ancho) VALUES(";
            //    query += p.Descripcion + ",'" + "A" + "','" + p.Diametro + "','" + p.Material + "'," + "NULL" + "," + "NULL" + "," + "NULL" + ")";

            //}
            //else if(p is ProductoB)
            //{
            //    query = "INSERT INTO " + TablaNombre + " (descripcion,tipo,diametro,material,largo,alto,ancho) VALUES('";
            //    query += p.Descripcion + "','" + "B" + "'," + "NULL" + "," + "NULL" + ",'" + p.Largo + "','" + p.Alto + "','" + p.Ancho + "')";


            //}
            
            
            return EjecutarNonQuery(query);

        }
             
       



        private static bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO.Comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO.Conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO.Comando.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                { ProductoDAO.Conexion.Close(); }
                   
            }
            return flag;
        }
      

        #endregion

    }
}
