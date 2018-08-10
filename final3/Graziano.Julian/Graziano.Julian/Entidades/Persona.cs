using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        protected string nombre;
        protected string apellido;

        public string Nombre { get { return this.nombre; } set{ this.nombre=value;} }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public Persona()
        { }
        public Persona(string Nombre, string Apellido)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
        }

        protected virtual string Mostrar()
        {
            return string.Format("Nombre: {0}, Apellido:{1}", this.nombre, this.apellido);
        }
       
    }
}
