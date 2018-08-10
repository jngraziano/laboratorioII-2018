using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
//using Archivos;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Alumno unAlumno = new Alumno("Pepe", "Apel", "22A");
                Alumno otroAlumno = new Alumno("Carlos", "Rodrigo", "111");

                Console.WriteLine("Correcto");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


                  



        }
    }
}
