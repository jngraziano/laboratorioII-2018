using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Xml.Serialization;
using System.Xml;

using System.Runtime.Serialization.Formatters.Binary;


namespace Entidades
{
    public static class GuardaString
    {
        #region GuardarArchivoTxt
        public static bool Guardar(this String texto, string archivo)
        {
            bool flag = false;
            try
            {
                //guardo la ruta y le doy al archivo el nombre que recibo
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;

                StreamWriter txt = new StreamWriter(ruta, true);
                txt.WriteLine(texto);
                txt.Close();               
                               
                flag = true;
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
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }

                return true;
            }
            catch (Exception)
            {
                datos = "";
                return false;
            }
        }
        #endregion

        #region GuardarXML
        //public bool Guardar(string archivo, V datos)
        //{
        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(V));
        //        //TextWriter writer = new StreamWriter(archivo);
        //        XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
        //        serializer.Serialize(writer, datos);
        //        writer.Close();

        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }
        //}
       

        #endregion

        #region LeerXML
        //public bool Leer(string archivo, out V datos)
        //{
        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(V));
        //        //TextReader writer = new StreamReader(archivo);
        //        XmlTextReader writer = new XmlTextReader(archivo);
        //        datos = (V)serializer.Deserialize(writer);
        //        writer.Close();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        datos = default(V);
        //        return false;
        //    }
        //}
        #endregion

        #region GuardarBinario
        //public bool Guardar(string archivo, T datos)
        //{ //datos es el tipo de dato que recibe, puede ser generica (T)
        //    Stream stream = null;
        //    try
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        stream = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None);
        //        formatter.Serialize(stream, datos);

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (!ReferenceEquals(stream, null))
        //            stream.Close();
        //    }
        //}
       
        #endregion

        #region LeerBinario
        //public bool Leer(string archivo, out T datos)
        //{
        //    Stream stream = null;
        //    try
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        stream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read);
        //        datos = (T)formatter.Deserialize(stream);
        //        stream.Close();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        datos = default(T);
        //        return false;
        //    }
        //    finally
        //    {
        //        if (!ReferenceEquals(stream, null))
        //            stream.Close();
        //    }
        //}

        #endregion

    }
}
