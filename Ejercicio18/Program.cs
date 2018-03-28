using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();

            long result1 =suma1.Sumar(25,25);

            Console.WriteLine("Suma: \n"+result1);
            Console.ReadKey();

            Console.Clear();

            string result2 = suma1.Sumar("perro", "gato");
            Console.WriteLine("Concatenar strings: \n"+result2);
            Console.ReadKey();

            Console.Clear();




        }
    }
}
