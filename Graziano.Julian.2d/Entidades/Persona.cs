using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Variables Prop y Constructor
        protected string apellido;
        protected string documento;
        protected string nombre;

        public string Apellido { get { return this.apellido; } }
        public string Documento
        {
            get { return this.documento; }
            set
            {
                if (this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                } 
            }
        } 
        public string Nombre { get { return this.nombre; } }

        public Persona() { }
        public Persona(string nomb, string apel, string docu)
        {
            this.nombre = nomb;
            this.apellido = apel;
            this.Documento = docu;
        }
        #endregion

        #region Metodos
        public abstract bool ValidarDocumentacion(string doc);

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(this.Nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this.Apellido);
            sb.Append("Documento: ");
            sb.AppendLine(this.Documento.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
