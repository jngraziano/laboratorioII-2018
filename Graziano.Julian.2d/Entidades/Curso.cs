using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Variables prop y Constructores
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision { get { return anio + "º" + division; } }

        private Curso()
        {
            List<Alumno> aux = new List<Alumno>();
            this.alumnos = aux;
        }
        public Curso(short an, Divisiones div, Profesor profe) 
            :this()
        {
            this.anio = an;
            this.division = div;
            this.profesor = profe; //wa
        }
        #endregion

        #region Metodos (Sobrecarga de operadores)
        
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Año/Division: ");
            sb.AppendLine(c.AnioDivision);
            sb.Append("Datos Profesor: \n");
            sb.AppendLine(c.profesor.ExponerDatos());
            //sb.Append("\n");
            foreach (var item in c.alumnos)
            {
                sb.Append("Datos Alumno: \n");
                sb.AppendLine(item.ExponerDatos());
                
                
            }

            return sb.ToString();
        
 
        }
        public static bool operator ==(Curso c, Alumno a)
        {
            bool rta = false;
           
           
            foreach (var item in c.alumnos)
            {
                
                if (item.AnioDivision == a.AnioDivision)
                { rta = true; }
                else
                {
                    rta = false;
                }
                
            }

       
            return rta;

        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            { c.alumnos.Add(a); }

           // c.alumnos.Add(a);
            
            return c;
        }
        

        #endregion

    }

    
}
