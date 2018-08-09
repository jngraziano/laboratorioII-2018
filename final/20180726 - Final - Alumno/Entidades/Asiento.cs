using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Redefinir ToString para que retorne la información del Asiento de forma ordenada. Utilizar string.Format o StringBuilder.
    // Utilizar la teoría de encapsulamiento en todas las clases.
    // La clase debe ser abstracta
    // Crear un método abstracto llamado ProbarAsiento que retorne un bool.
    public abstract class Asiento
    {
        public delegate void miDelegado(string informe, bool estado);
        public event miDelegado FinPruebaCalidad;
              
        public short alto;
        public short ancho;
        public short profundidad;
        
        public Asiento()
        { }
        public Asiento(short alto, short ancho, short profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
         
            sb.Append("Alto: ");
            sb.AppendLine(this.alto.ToString());
            sb.Append("Ancho: ");
            sb.AppendLine(this.ancho.ToString());
            sb.Append("Profundidad: ");
            sb.AppendLine(this.profundidad.ToString());

            return sb.ToString();
        }

        public abstract void ProbarAsiento();

        public void  InformarFinDePrueba(bool rta)
        {
            //miDelegado d = new miDelegado(base.InformarFinDePrueba(rta));
            //FinPruebaCalidad.Invoke(d, new object[] { avance, carril });
            //this.FinPruebaCalidad += Asiento_FinPruebaCalidad ();

            //this.FinPruebaCalidad.Invoke(this.ToString(), rta);
            //miDelegado d = new miDelegado(this.ToString(), rta);

            //this.FinPruebaCalidad.Invoke(InformarFinDePrueba());


             //return this.FinPruebaCalidad(this.ToString(), rta);
            
          
        }

      

        
    }
}
