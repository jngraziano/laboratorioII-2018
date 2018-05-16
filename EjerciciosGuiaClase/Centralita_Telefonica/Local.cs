using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefonica
{
    class Local : Llamada
    {
        #region Variables, Prop y Constructor
        protected float _costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }


        public Local(string origen, float duracion, string destino, float costo)
        {
            base._duracion = duracion;
            base._nroOrigen = origen;
            base._nroDestino = destino;

            this._costo = costo;

        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        { }

        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("Costo: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            return sb.ToString();

        }

        public override bool Equals(object obj)
        {


            if (obj is Local)
            {
                return true;
            }

            // TODO: write your implementation of Equals() here
            //throw new NotImplementedException();


            return false;
        }
        public float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

    }
}
