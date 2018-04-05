using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        #region Variables, Getter y Constructor
        private double numero;

        public string SetNumero { set { this.numero = ValidarNumero(value); } }
        
        //Getter agregado solo para mostrar en main.
        public double GetNumero { get { return this.numero; } }

        public Numero()
        { }
        
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }

        #endregion

        #region Metodos
        public double ValidarNumero(string strNumero)
        {
            double devuelve=0;
            int num;
            if (int.TryParse(strNumero, out num))
            {
                //ValidarNumero comprobará que el valor recibido sea numérico,
                //y lo retornará en formato double. Caso contrario, 
                //retornará 0.
               
               
                
                devuelve = Convert.ToDouble(strNumero);
            }
            
            return devuelve;
        }

        public string BinarioDecimal(string binario)
        {
            string devuelve = "Valor invalido.";
            try
            {
                devuelve = Convert.ToInt32(binario, 2).ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
           
            return devuelve;

        }

        public string DecimalBinario(double numero)
        {
            int bin;
            int variable = Convert.ToInt32(numero);
            string binario = "";
            while (variable >0)
            {
                bin = variable % 2;
                variable = variable / 2;
                Convert.ToString(bin);
                binario = bin + binario;
            }
            return binario;
        }
        public string DecimalBinario(string numero)
        {
            return Convert.ToInt32(numero, 2).ToString();
        }

        #region Sobrecargas

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        #endregion

        #endregion
    }
}
