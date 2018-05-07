using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefonica
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
        public abstract float CostoLlamada { get; }

        public Llamada() { }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        #endregion

        #region Metodos

        protected virtual string Mostrar()
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


        #region Sobrecarga operadores
        public static bool operator ==(Llamada llam1, Llamada llam2)
        {
            //El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
            //(utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
            //origen son iguales en ambas llamadas.

            bool rta = false;

            //((Local)item).CostoLlamada;

            //bool test = CentralTelefonica.Provincial.Equals(llam1);

            if ((llam1.Equals(llam1)) == llam2.Equals(llam2) && llam1.NroDestino == llam2.NroDestino && llam1.NroOrigen == llam2.NroOrigen)
            {
                rta = true;
            }
            //else if (local.equals(llam1) == local.equals(llam2) && llam1.nrodestino == llam2.nrodestino && llam1.nroorigen == llam2.nroorigen)
            //{
            //    rta = true;
            //}

            return rta;

        }
        public static bool operator !=(Llamada llam1, Llamada llam2)
        {
            return !(llam1 == llam2);
        }

        #endregion


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
