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
    public class ArchivoXML : IGuardar<string, Sofa>
    {

        #region GuardarXML
        public string Guardar(string archivo, Sofa datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Sofa));
               
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
                writer.Close();

                return "ok";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "no ok";
            }
        }


        #endregion

        #region LeerXML
        public Sofa Leer(string archivo)
        {
            Sofa datos = new Sofa();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Sofa));
               
                XmlTextReader writer = new XmlTextReader(archivo);
                
                datos = (Sofa)serializer.Deserialize(writer);
                writer.Close();

                return datos;
            }
            catch (Exception)
            {
                datos = default(Sofa);
                return datos;
            }
        }
        #endregion

    }
}
