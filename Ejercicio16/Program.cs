using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instancia

            Alumno alumno1 = new Alumno("Pedro", "Gutierrez", 10);
            Alumno alumno2 = new Alumno("Carlos", "Gonzalez", 55);
            Alumno alumno3 = new Alumno("Juan", "Perez", 3);
            #endregion

            #region Metodos
            alumno1.Estudiar(1, 2);
            alumno2.Estudiar(10, 10);
            alumno3.Estudiar(5, 8);

            alumno1.CalcularFinal();
            alumno1.Mostrar();
            Console.WriteLine("\n");

            alumno2.CalcularFinal();
            alumno2.Mostrar();
            Console.WriteLine("\n");

            alumno3.CalcularFinal();            
            alumno3.Mostrar();


            #endregion

            Console.ReadKey();
        }
    }
}
