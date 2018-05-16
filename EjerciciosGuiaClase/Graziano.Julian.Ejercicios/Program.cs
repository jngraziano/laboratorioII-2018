using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
        //    11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
        //    Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
        //    posea la siguiente firma: bool Validar(int valor, int min, int max):
        //    a. valor: dato a validar
            //    b. min y max: rango en el cual deberá estar la variable valor.
            //Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            #endregion

            #region variables
            int numero =0;
            int numeroval=0;
            int nummax=0;
            int nummin=0;
            bool rta = true;

            #endregion

            #region Desarrollo
            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine("Ingrese numero {0}:",i+1);
                numero = int.Parse(Console.ReadLine());
                rta = Validacion.Validar(numero,-100,100);
                
             if(rta != false)
             {
                 numeroval = numero;                 
             }
             if (nummax < numeroval)
             {
                 nummax = numeroval;
             }
             if (nummin == 0)
             {
                 nummin = numeroval;
             }
             if (nummin > numeroval)
             {
                 nummin = numeroval;
             }
            
            }

            Console.Clear();
            Console.WriteLine("Resultados");
            Console.WriteLine("\n\nNumero Maximo: {0}", nummax);
            Console.WriteLine("\n\nNumero Minimo: {0}", nummin);

            #endregion

            Console.ReadKey();
        }
    
    }

}
