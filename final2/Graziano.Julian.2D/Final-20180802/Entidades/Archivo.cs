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

        public string Nombre { get { return this.nombre; } }
       // public string Contenido { get { return this.contenido; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} \n Contenido: {1}", this.Nombre, this.contenido);
        }

        public static explicit operator string(Archivo arch)
        {
            return arch.contenido;
            
           
        }
    }
}
