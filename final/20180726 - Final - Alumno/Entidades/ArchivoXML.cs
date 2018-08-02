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
    public class ArchivoXML<T> : IArchivos<string, T>
    {

        #region GuardarXML
        public string Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
               
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                writer.Close();

                return "Serializado con exito";
            }
            catch (MensajeException e)
            {
                return e.Message;
                
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
                    catch(FileNotFoundException noencontrado)  
                    {
                        return datos = default(T);
                        throw new MensajeException("Archivo no encontrado.", noencontrado);
                        
                    }

                   

               
                   

                //XmlTextReader writer = new XmlTextReader(archivo);

                //datos = (T)serializer.Deserialize(writer);
                //writer.Close();
 
        }
        #endregion

    }
}
