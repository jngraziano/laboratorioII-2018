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
    public class ArchivoTexto//:IGuardar<string,Sofa>
    {
        //V Guardar(string path, T elemento);

        //T Leer(string path);

        #region GuardarArchivoTxt
        public  string Guardar(string path, Sofa unSofa)
        {
            string flag = "nook";
            try
            {
                //guardo la ruta y le doy al archivo el nombre que recibo
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path;

                StreamWriter txt = new StreamWriter(ruta, true);
                txt.WriteLine(unSofa);
                txt.Close();

                flag = "ok";
            }
            catch (FileNotFoundException)
            {
                string error = "Archivo no encontrado";
                throw new FileNotFoundException(error);

            }

            return flag;

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
