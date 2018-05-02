using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Local:Llamada
    {
        #region Variables, Prop y Constructor
        protected float _costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        public Local(Llamada llamada, float costo)
        {
            base._duracion = llamada.Duracion;
            base._nroOrigen = llamada.NroOrigen;
            base._nroDestino = llamada.NroDestino;

            this._costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            :this((new Llamada(duracion,destino,origen)),costo)
        { }

        #endregion

        #region Metodos
        public override string Mostrar()
        {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine(base.Mostrar());
             sb.Append("Costo: ");
             sb.AppendLine(this.CostoLlamada.ToString());

             return sb.ToString();
 
        }
        public float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }

        #endregion

    }
}
