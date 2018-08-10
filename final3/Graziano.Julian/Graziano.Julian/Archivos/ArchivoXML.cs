using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Archivos
{
    public class ArchivoXML<T>:IArchivo<T,string>
    {
        //bool Guardar(T elemento, string path);

        //V Leer(string path);

        #region GuardarXML
        public bool Guardar(T datos, string archivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }


        #endregion

        #region LeerXML
        public T Leer(string archivo)
        {

            T datos;


            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                FileStream fsin = new FileStream("archivoXML.XML", FileMode.Append, FileAccess.Write);
                datos = (T)serializer.Deserialize(fsin);
                fsin.Close();

                return datos;
            }
            catch (FileNotFoundException noencontrado)
            {
                return datos = default(T);
                throw new Exception("Archivo no encontrado.", noencontrado);

            }






            //XmlTextReader writer = new XmlTextReader(archivo);

            //datos = (T)serializer.Deserialize(writer);
            //writer.Close();

        }
        #endregion
    }
}
