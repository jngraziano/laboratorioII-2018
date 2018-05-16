using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        #region Variables
        public double cantidad;
        public float cotizRespectoDolar;

        public Dolar()
        { }
        public Dolar(double Cantidad):this()
        { this.cantidad = Cantidad; }
        public Dolar(double cantidad, float cotizacion):this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Metodos y Sobrecargas
        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro();
             euro.cotizRespectoDolar=float.Parse(d.cantidad)*1.3642F;
        }
        public static explicit operator Pesos(Dolar d)
        {}
        public static implicit operator Dolar(double d)
        {}
        public static bool operator !=(Dolar d, Euro e)
        { }
        public static bool operator !=(Dolar d, Pesos p)
        { }
        public static bool operator !=(Dolar d1, Dolar d2)
        { }
        public static Dolar operator -(Dolar d, Euro e)
        { }
        public static Dolar operator -(Dolar d, Pesos p)
        { }
        public static Dolar operator +(Dolar d, Euro e)
        { }
        public static Dolar operator +(Dolar d, Pesos p)
        { }
        public static bool operator ==(Dolar d, Euro e)
        { }
        public static bool operator ==(Dolar d, Pesos p)
        { }
        public static bool operator ==(Dolar d1, Dolar d2)
        { } 



        public float GetCotizacion()
        { }


        #endregion

    }
}
