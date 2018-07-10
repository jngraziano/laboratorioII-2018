using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DateTimeTest
    {
       
        DateTime fecha1 = new DateTime(2003,09,11); //AAAA,MM,DD
        DateTime fecha2 = new DateTime(2018, 04, 19, 20, 10, 30);//AAAA,MM,DD,hh,mm,ss
        DateTime fechaActual = DateTime.Now;

            //Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha actual ", fechaActual));
            //Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha 1 ", fecha1));
            //Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha 2 ", fecha2));
            //Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Diferencia entre fechas ", (fecha2 - fecha1)));
            //Console.WriteLine("Compara fecha1 y Now con Compare(): {0}", DateTimeTest.Compare(fecha1, DateTimeTest.Now));

       
    }
}
