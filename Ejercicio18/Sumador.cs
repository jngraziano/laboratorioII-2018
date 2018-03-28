using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
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
        
        
        
        //Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
        #region Operadores
        public explicit operator int(Sumador s)        
        {
            //c. Generar una conversión explícita que retorne cantidadSumas.
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            //d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
            //con dicho valor.
            return s1.cantidadSumas + s2.cantidadSumas;
            
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            //e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
            //cantidadSumas.
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }



        #endregion
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
