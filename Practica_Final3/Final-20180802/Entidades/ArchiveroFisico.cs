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
        public string pathArchivos;

        public ArchiveroFisico(){}
        public ArchiveroFisico(string path)
        {
            this.pathArchivos = path;
        }


        /// <summary>
        /// Guarda en un txt
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
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


        public override void MostrarArchivos()
        {
            throw new NotImplementedException();
        }

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
