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
    public class DiscoElectronico:Almacenador,IAlmacenable<Archivo,string>
    {
        public List<Archivo> archivosGuardados;

        public delegate void miDelegado(object sender, EventArgs e);
        public event miDelegado MostrarInfo;


        private DiscoElectronico()
        {
            this.archivosGuardados = new List<Archivo>();
            base.capacidad = 5;

        }

        public DiscoElectronico(int capa)
        {
            this.capacidad = capa;

            for (int i = 0; i < capa; i++)
            {
                //this.archivosGuardados.Add(this.Leer("dbo.Archivo"));
              
                
            }
 
        }

        #region Guardo Archivo
        public bool Guardar(Archivo elemento)
        {
           // string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "GuardoTXT.txt";
                 

            string query = "INSERT INTO dbo.Archivo" + " (nombre,contenido) VALUES(";
            query += "'" + elemento.Nombre + "','" + (string)elemento+ "')";

            try
            {
                ArchivoDAO.Insertar(query);

                return true;
            }
            catch (Exception e)
            {
               
                return false;
              
            }

 
        }
        #endregion

        #region Leo archivo
        public string Leer(string nombretabla)
        {
            string query = "SELECT * FROM"+ nombretabla + ";";

            try
            {
              

                return ArchivoDAO.ObtengoArchivos(query).ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        #endregion

        public override void MostrarArchivos()
        {
            foreach (var item in this.archivosGuardados)
            {
                Thread.Sleep(5000);
                
            }
        }

        public static List<Archivo> operator +(Archivo unArchivo, DiscoElectronico unDisco)
        {
            try
            {
                int aux = 0;
                while (aux <= unDisco.capacidad)
                {
                    unDisco.archivosGuardados.Add(unArchivo);
                    aux++;
                }
               
            }
            catch (Excepciones)
            {
                throw new Excepciones("El disco esta lleno");   
            }
            return unDisco.archivosGuardados;
            
        }


    }
}
