using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    class Docente:Persona
    {
       
        protected int legajo;

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }


        public Docente(string Nombre, string Apellido, int Legajo)
            :base(Nombre,Apellido)
        {
            this.legajo = Legajo;
        }

        protected override string Mostrar()
        {

            return string.Format("{0},DNI: {1}", base.Mostrar(), this.legajo);

        }

        public static explicit operator string(Docente unDocente)
        {
            return unDocente.Mostrar();

        }

        public void Calificar()
        {
            Thread.Sleep(2000);

            Random ran = new Random();
            ran.Next();
            
        }
    }
}
