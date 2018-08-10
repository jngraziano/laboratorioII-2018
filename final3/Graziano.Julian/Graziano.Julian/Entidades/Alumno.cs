using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        
        protected string DNI;

        public string elDNI { get{return this.DNI;} set { this.validaDNI(value); } }

        public Alumno(string dni) 
        {
            this.validaDNI(dni);
        }
        public Alumno(string nombre, string apellido, string dni)
            :base(nombre,apellido)
        {
            this.validaDNI(dni);

        }
        

        protected override string Mostrar()
        {
           
            return string.Format("{0} DNI: {1}", base.Mostrar(),this.DNI);
 
        }

        public override string ToString()
        {

            return this.Mostrar();
        }
        public static bool operator ==(Alumno unAlumno, Alumno otroAlumno)
        {
            if (unAlumno.DNI == otroAlumno.DNI)
            {
                return true; 
            }

            return false;
        }
        public static bool operator !=(Alumno unAlumno, Alumno otroAlumno)
        {
            return !(unAlumno == otroAlumno);
        }


        public void validaDNI(string dni)
        {
           
          
          string retorna = "";
            try
            {
                 this.DNI = ExtensionClase.MetodoExtension(dni);;

               
            }
               
         


            catch (Exception e)
            {
                
                throw e;
            }

           
        }
    }
}
