using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
         public function int Devuelve()
        {
            Random ram = new Random();
            int devuelve=0;
           
            
            devuelve = (int)ram.Next(0, 1);
            
           return devuelve;
            
        }
    }
}
