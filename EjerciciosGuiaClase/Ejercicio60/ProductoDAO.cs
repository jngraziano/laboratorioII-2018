using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Ejercicio60
{
    public static class ProductoDAO
    {
        /*
         * SQL SERVER 2012 managment studio
         * Link de descarga de base de datos de ejemmplo
         * https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks
         * 
         */
        #region Variables y Constructor
        private static SqlConnection _conexion;
        private static SqlCommand _comando;

        /* Original del ppt:
         * private string connectionStr = "Data Source=[Instancia Del Servidor];Initial Catalog=[Nombre de la Base de Datos];Integrated Security=True";
                
         Data Source = es el nombre del servidor en el SQL Server2012
        
        */
        private static string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True";


        static ProductoDAO()
        {
            //creo la conexion pasandole el string
            ProductoDAO._conexion = new SqlConnection(connectionStr);
             // CREO UN OBJETO SQLCOMMAND
            ProductoDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            ProductoDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            ProductoDAO._comando.Connection = ProductoDAO._conexion;


        }

        #endregion

        #region Metodos
        public static Producto ObtieneProducto()
        {
            bool flag = false;
            Producto producto = null;


            try
            {
                ProductoDAO._comando.CommandText = "SELECT  Production.Product.ProductID,Name,ProductNumber FROM Production.Product WHERE (ProductID = 1 );";
                ProductoDAO._conexion.Open();

                SqlDataReader oDr = ProductoDAO._comando.ExecuteReader();

                if (oDr.Read())
                {
                    producto = new Producto(int.Parse(oDr["ProductID"].ToString()), oDr["Name"].ToString(), oDr["ProductNumber"].ToString());

                }
                oDr.Close();
                flag = true;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }           
            
            ProductoDAO._conexion.Close();
            return producto;
        }

        public static bool AgregarProducto(Producto p)
        {
            string sql = "INSERT INTO Personas (nombre,apellido,dni) VALUES(";
            //sql = sql + "'" + p.Nombre + "','" + p.Apellido + "'," + p.DNI.ToString() + ")";

            return ProductoDAO.EjecutarNonQuery(sql);
        }



        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO._conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductoDAO._conexion.Close();
            }
            return todoOk;
        }


        #endregion



    }
}
