using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefonica
{
    class Provincial : Llamada
    {
        #region Enum
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3

        }

        #endregion

        #region Variables, Prop y Constructor

        protected Franja _franjaHoraria;
        public override float CostoLlamada { get { return this.CalcularCosto(); } }



        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {
            base._duracion = duracion;
            base._nroOrigen = origen;
            base._nroDestino = destino;
            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append("Costo: ");
            sb.AppendLine(this.CostoLlamada.ToString());
            sb.Append("Franja Horaria: ");
            sb.AppendLine(this._franjaHoraria.ToString());

            return sb.ToString();

        }



        // override object.Equals
        public override bool Equals(object obj)
        {


            if (obj is Provincial)
            {
                return true;
            }


            return false;
        }



        private float CalcularCosto()
        {
            //CalcularCosto será privado. Retornará el valor de la 
            //llamada a partir de la duración y el costo
            //de la misma. Los valores serán: Franja_1: 0.99, 
            //Franja_2: 1.25 y Franja_3: 0.66.
            float result = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    result = float.Parse((base.Duracion * 0.99).ToString());
                    break;
                case Franja.Franja_2:
                    result = float.Parse((base.Duracion * 1.25).ToString());
                    break;
                case Franja.Franja_3:
                    result = float.Parse((base.Duracion * 0.66).ToString());
                    break;
                default:
                    break;
            }
            return result;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        #endregion
    }
}
