using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class ArchivoTXT<T>: IArchivo<T,string>
    {
        
        //V Leer(string path);

        /// <summary>
        /// Guarda en un txt
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public bool Guardar(T elemento, string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(elemento);
                }

                return true;
            }
            catch (FileNotFoundException excep)
            {
                return false;
                throw excep;

            }

        }

        /// <summary>
        /// Lee desde el archivo 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string Leer(string path)
        {
            string datos;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    datos = file.ReadToEnd();
                }

                return datos;
            }
            catch (FileNotFoundException)
            {
                datos = "Error archivo no encontrado.";
                return datos;
                // throw excep;
            }
        }
    }
}
