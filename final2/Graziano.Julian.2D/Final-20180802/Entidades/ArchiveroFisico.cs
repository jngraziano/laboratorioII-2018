using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Deberá heredar de Almacenador e implementar IAlmacenable.
    //Crear un constructor que reciba y asigne el/los atributos de la misma.
    //El método MostrarArchivos lanzará una excepción del tipo NotImplementedException.
    //El método Guardar deberá guardar un objeto de tipo archivo en un archivo de texto en la ubicación definida en el atributo pathArchivos.
    //El método Leer recibirá el nombre de un archivo y deberá retornar su contenido.
    //Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    public class ArchiveroFisico:Almacenador,IAlmacenable<Archivo,string>
    {
        private string pathArchivos;

        public ArchiveroFisico(string path)
        {
            this.pathArchivos = path;
        }

        #region Guardo Archivo
        public bool Guardar(Archivo elemento)
        {
         
            try
            {
                using (StreamWriter file = new StreamWriter(this.pathArchivos, true))
                {
                    file.WriteLine(elemento);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        #endregion

        #region Leo archivo
        public string Leer(string nombreArchivo)
        {
            string datos;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(nombreArchivo))
                {
                    datos = file.ReadToEnd();
                }

                return datos;
            }
            catch (Exception)
            {
                datos = "";
                return datos;
            }

        }
        #endregion

        public override void MostrarArchivos()
        {
            throw new NotImplementedException("No Implementado");
        }


    }
}
