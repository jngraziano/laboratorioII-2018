using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcu = new Calculadora();
            Numero num1 = new Numero("2");
            Numero num2 = new Numero(3);
            Numero num3 = new Numero(8);
            string op="*";
            double result = calcu.Operar(num1, num2, op);

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("El resultado {0} {1} {2} es: {3}.",num1.GetNumero,op,num2.GetNumero,result);
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("CALCULADORA");
            string result2 = num3.DecimalBinario(8);
            Console.WriteLine(result2); 
            Console.ReadKey();

        }
    }
}
