using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    // Agregar un enumerado con los colores: Natural, Blanco, Negro, Rojo. Utilizar este enumerado en el atributo color de Sofa.
    // Generar una relación de herencia entre Asiento y Sofa.
    // Modificar los atributos y constructores según crea necesario.
    // El método ProbarAsiento hará un Sleep de 3 segundos y retornará true o false de forma aleatoria (Random).

    // Utilizar la teoría de encapsulamiento en todas las clases.
    public class Sofa:Asiento
    {
        public enum miColor
        {
            Natural,
            Blanco,
            Negro,
            Rojo
            
        }

        
        public miColor color;

        public Sofa()
        { }
        private Sofa(short alto, short ancho, short profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        public Sofa(short alto, short ancho, short profundidad, miColor color)
            :this(alto,ancho,profundidad)
        {
            this.color = color;
        }

        public override void ProbarAsiento()
        {
            Thread.Sleep(5000);
            
            Random ram = new Random();
            int devuelve=0;
            bool rta = false;
            
            devuelve = ram.Next(0, 1);
            switch (devuelve)
            {
                case 0:
                    rta = false;
                    break;
                case 1:
                    rta = true;
                    break;
                default:
                    break;
            }

            base.InformarFinDePrueba(rta);

        }

    }
}
