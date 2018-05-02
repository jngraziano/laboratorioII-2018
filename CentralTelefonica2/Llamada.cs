using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public abstract class Llamada
    {
       

        #region Variables, Prop y Constructor
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion { get { return _duracion; } } 
        public string NroDestino { get { return _nroDestino; } }
        public string NroOrigen { get { return _nroOrigen; } }
        public abstract float CostoLlamada { get;}

        public Llamada() { }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        #endregion

        #region Metodos

        public virtual string Mostrar()
        { /*stringbuilder*/
            StringBuilder sb = new StringBuilder();
            sb.Append("Duracion: ");
            sb.AppendLine(this.Duracion.ToString());
            sb.Append("Num Origen: ");
            sb.AppendLine(this.NroOrigen);
            sb.Append("Num Destino: ");
            sb.AppendLine(this.NroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            /*sort fijarse*/
            if (uno.Duracion > dos.Duracion)
            {
                return -1;
            }
            else if (uno.Duracion < dos.Duracion)
            {
                return 1;

            }
            else
            {
                return 0;

            }
        }


        #endregion

        #region Enum
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas

        }
        #endregion
    }
}
