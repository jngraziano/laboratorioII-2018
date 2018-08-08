using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Sobreescribir el método ToString para mostrar los valores de sus atributos.Utilizar String.Format.
    //Agregar el operador explicit para retornar el contenido del archivo.
    public class Archivo
    {
        public string nombre;
        public string contenido;

        public Archivo(string nombre, string contenido)
        {
            this.nombre = nombre;
            this.contenido = contenido;
        }
        public explicit operator string(Archivo unArchivo)
        {
            return unArchivo.contenido;

        }


        public override string ToString()
        {
            return string.Format("Nombre: {0}\nContenido: {1}", this.nombre, this.contenido);
        }
    }
}
