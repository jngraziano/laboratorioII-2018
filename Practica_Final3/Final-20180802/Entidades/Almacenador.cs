using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   //Crear un constructor que reciba y asigne el/los atributos de la misma.
   //La clase debe ser abstracta.
   //Crear un método abstracto llamado MostrarArchivos que retorne void.


    public abstract class Almacenador
    {
        /// <summary>
        /// delegado que recibirá un string y retornará void.
        /// </summary>
        /// <param name="unString"></param>
        public delegate void miDelegado(string unString); 

        /// <summary>
        /// evento con las caracteristicas de miDelegado para ser llamado
        /// </summary>
        public event miDelegado MostrarInfo;

        public int capacidad;

        public Almacenador() { }
        public Almacenador(int capa)
        {
            this.capacidad = capa;
        }





        public abstract void MostrarArchivos();




        /// <summary>
        /// Si el evento no es nulo, 
        /// invocará al evento MostrarInfo con los datos del archivo.
        /// </summary>
        /// <param name="unArchivo"></param>
        public void DispararEvento(Archivo unArchivo)
        {
            if (MostrarInfo != null)
            {
                MostrarInfo(unArchivo.ToString());
            }
                

           
        }
    }
}
