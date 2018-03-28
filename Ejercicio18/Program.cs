using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma1 = new Sumador();

            string result =suma1.Sumar("perro","gato");

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
