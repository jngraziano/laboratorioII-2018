using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    //a.Deberá heredar de Almacenador e implementar IAlmacenable.
    //b.El método Guardar deberá insertar un archivo en la base de datos.
    //c.El método Leer recibirá el nombre de la tabla a consultar. Deberá leer y retornar todos los archivos de la base de datos.
    //d.Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    //e.El método MostrarArchivos por el momento sólo deberá recorrer la lista de archivos y por cada uno simular un retardo de 5 segundos.
    //f.Agregar un constructor en el cual se deberá cargar la lista a partir de los datos guardados en la base.
    //g.Sobrecargar el operador + para agregar un archivo a la lista siempre y cuando no supere la capacidad, caso contrario lanzará una excepción con el mensaje "El disco está lleno!".
    public class DiscoElectronico<V,T>: Almacenador, IAlmacenable<V,T>
    {
        public List<Archivo> archivosGuardados;

        public SqlConnection Conexion;
        public SqlCommand Comando;

        public DiscoElectronico()
        {
            this.archivosGuardados = new List<Archivo>();

            this.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            this.Comando = new SqlCommand();

            this.Comando.CommandType = System.Data.CommandType.Text;

            this.Comando.Connection = this.Conexion;
        }

        public bool Guardar(T elemento)
        {
        
            string query = "INSERT INTO bla bla";

            return this.EjecutarNonQuery(query);
            
        }

        public T Leer(string nombreTabla)
        {
            string query = "SELECT * FROM" + nombreTabla;

            this.Comando.CommandText = query;

            //// EJECUTO EL COMMAND                 
              SqlDataReader oDr = this.Comando.ExecuteReader();

              if (oDr.Read())
              {
                  string myString = oDr.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                  // Do somthing with this rows string, for example to put them in to a list
                  //this.archivosGuardados.Add(myString);
                  //string col1Value = rdr["ColumnOneName"].ToString(); 
 
              }

            //    T nuevot = new T();

            
            //   // MIENTRAS TENGA REGISTROS...
            //   if (oDr.Read())
            //   {
            //       // ACCEDO POR NOMBRE O POR INDICE
            //       obj = new Object(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString());
            //   }

            //   //CIERRO EL DATAREADER
            //   oDr.Close();
               

           

            return oDr;
 
        }
        public bool EjecutarNonQuery(string sql)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                this.Comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this.Conexion.Open();

                // EJECUTO EL COMMAND
                this.Comando.ExecuteNonQuery();

                flag = true;
            }
            catch (SqlException)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                { this.Conexion.Close(); }

            }
            return flag;
        }


    }
}
