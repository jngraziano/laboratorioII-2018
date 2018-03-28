using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region Variables y Constructor
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        string nb;
        string ap;
        int leg;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nb = nombre;
            this.ap = apellido;
            this.leg = legajo;
        }


        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            //El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
            //iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
            //el método de instancia Next de la clase Random.
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random random = new Random();
                this._notaFinal = random.Next(1, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            //d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
            //mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
            //desaprobado".
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos alumnos \n");
            sb.Append("Nombre: ");
            sb.AppendLine(this.nb);
            sb.Append("Apellido: ");
            sb.AppendLine(this.ap);
            sb.Append("Legajo: ");
            sb.AppendLine(this.leg.ToString());

            if (this._notaFinal != -1)
            {
                sb.Append("Nota Final: ");
                sb.AppendLine(this._notaFinal.ToString());
            }
            else
            {
                sb.AppendLine("El alumno no calificó para nota final.");
            }

            Console.WriteLine(sb.ToString());

        }

        #endregion
    }
}
