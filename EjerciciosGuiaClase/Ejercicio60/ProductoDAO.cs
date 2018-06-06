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
        private string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True";


        public ProductoDAO()
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




        #endregion



    }
}
