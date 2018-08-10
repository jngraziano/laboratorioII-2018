using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    
    
    //public class DiscoElectronico<V, Archivo> : Almacenador, IAlmacenable<V, Archivo>
    public class DiscoElectronico: Almacenador, IAlmacenable<Archivo,List<Archivo>>
    {
        public List<Archivo> archivosGuardados;


        #region Conexion Comando y constructor
        public SqlConnection Conexion;
        public SqlCommand Comando;

        public DiscoElectronico()
        {
            this.archivosGuardados = new List<Archivo>();

           // string server = ".\\SQLEXPRESS";
         
            this.Conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

            //Data Source=.\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=SSPI;uid=MEDEL\cadmin-jgrazian;pwd=Granatepasion18;

            this.Comando = new SqlCommand();

            this.Comando.CommandType = System.Data.CommandType.Text;

            this.Comando.Connection = this.Conexion;

            base.capacidad = 5;
            
        }
        #endregion

        #region Guardar en BD
        public bool Guardar(Archivo elemento)
        {
            bool flag = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                this.Comando.CommandText = "INSERT INTO dbo.Archivo (nombre,contenido) VALUES('" + elemento.nombre + "','" + elemento.contenido + "');";;

                // ABRO LA CONEXION A LA BD
                this.Conexion.Open();

                // EJECUTO EL COMMAND
                this.Comando.ExecuteNonQuery();

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
                { this.Conexion.Close(); }

            }
            return flag;
               
            
        }
        #endregion

        #region Leer de BD
        public List<Archivo> Leer(string nombreTabla)
        {
           
            string query = "SELECT * FROM " + nombreTabla;
            List<Archivo> aux = new List<Archivo>();
            Archivo unArchivo = new Archivo();

            try
            {
                this.Conexion.Open();
                this.Comando.CommandText = query;

                //// EJECUTO EL COMMAND                 
                SqlDataReader oDr = this.Comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE

                    //unArchivo = new Archivo(oDr["nombre"].ToString(), oDr["contenido"].ToString());

                    unArchivo.nombre = oDr["nombre"].ToString();
                    unArchivo.contenido = oDr["contenido"].ToString();
                    aux.Add(unArchivo);
                }

                //CIERRO EL DATAREADER
                oDr.Close();
                this.Conexion.Close();

            }
            catch (SqlException excep)
            {

                throw excep;
            }
          
            return aux;
              
 
        }
        #endregion

        /// <summary>
        /// Ejecuta el metodo DispararEvento por cada archivo de la lista.
        /// </summary>
        public override void MostrarArchivos()
        {
            
            foreach (Archivo item in this.archivosGuardados)
            {
                Thread.Sleep(5000);
                base.DispararEvento(item);
     
            }

        }


        /// <summary>
        /// Sobrecarga + para que lanze una excepcion si se sobrepasa la capacidad 
        /// </summary>
        /// <param name="unDisco"></param>
        /// <param name="unArchivo"></param>
        /// <returns></returns>
        public static List<Archivo> operator +(DiscoElectronico unDisco, Archivo unArchivo)
        {
            try
            {
               
                int aux = unDisco.archivosGuardados.Count;
                
                if (aux < unDisco.capacidad)
                {
                    unDisco.archivosGuardados.Add(unArchivo);

                }
                else
                {
                    throw new Exception("El disco esta lleno");
                }

            }
            catch (Exception excep)
            {
                throw excep;
            }
            return unDisco.archivosGuardados;

        }


    }
}
