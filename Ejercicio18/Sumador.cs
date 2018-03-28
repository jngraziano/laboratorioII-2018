using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Sumador
    {
        #region Variables y Constructor
        public int cantidadSumas;

        public Sumador()
        {
            Sumador sum = new Sumador(0);
            this.cantidadSumas= sum.cantidadSumas;

        }
        public Sumador(int cants)
        {
            this.cantidadSumas=cants;
        }
        #endregion

        #region Metodos
        //public explicit int operator int(Sumador s)
        //{}
        //public implicit

        public long Sumar(long a, long b)
        {
            this.cantidadSumas = this.cantidadSumas + 1;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas = this.cantidadSumas + 1;
            return a + b;
        }

        #endregion
    }
}
