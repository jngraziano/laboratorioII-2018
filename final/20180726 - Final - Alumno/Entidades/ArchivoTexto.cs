using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Xml.Serialization;
using System.Xml;



namespace Entidades
{
    public class ArchivoTexto:IArchivos<string,string>
    {
        //V Guardar(string path, T elemento);

        //T Leer(string path);

        #region GuardarArchivoTxt
        public string Guardar(string archivo, string elemento)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo, true))
                {
                    file.WriteLine(elemento);
                }

                return elemento;
            }
            catch (Exception)
            {
                return elemento;
            }
            
            //string flag = "nook";
            //try
            //{

            //    StreamWriter txt = new StreamWriter(archivo, true);
            //    txt.WriteLine(elemento);
            //    txt.Close();

            //    flag = "ok";
            //}
            //catch (FileNotFoundException)
            //{
            //    string error = "Archivo no encontrado";
            //    throw new FileNotFoundException(error);

            //}

            //return flag;

        }
        #endregion

        #region LeerArchivoTxt
        public string Leer(string archivo)
        {
            string datos;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
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

      
      
    }
}
