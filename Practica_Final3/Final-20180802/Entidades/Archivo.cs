using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    
    public class Archivo
    {

        #region Variables constructores y propiedades de Nombre y Contenido
        public string nombre;
        public string contenido;

        public Archivo(){}
        public Archivo(string nombre, string contenido)
        {
            this.nombre = nombre;
            this.contenido = contenido;
        }

        public string Nombre { get { return this.nombre; } }
        public string Contenido { get { return this.contenido; } }
        #endregion

        

        /// <summary>
        /// operador explicit: retornar el contenido del archivo.
        /// </summary>
        /// <param name="unArchivo"></param>
        /// <returns></returns>
        public static explicit operator string(Archivo unArchivo)
        {
            return unArchivo.contenido;

        }

        /// <summary>
        /// sobreescribir ToString para mostrar los valores
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Nombre: {0}\nContenido: {1}", this.nombre, this.contenido);
        }
    }
}
