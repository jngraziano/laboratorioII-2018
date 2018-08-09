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
   //f.	Agregar en la clase Almacenador un evento llamado MostrarInfo el cual recibirá un string y retornará void.
   //g.	Agregar también en la clase Almacenador un método llamado DispararEvento que recibirá un archivo por parámetro e invocará al evento MostrarInfo con los datos del archivo.
    public abstract class Almacenador
    {
        public delegate void miDelegado(string unString); 

        public event miDelegado MostrarInfo;

        public int capacidad;

        public Almacenador() { }
        public Almacenador(int capa)
        {
            this.capacidad = capa;
        }

        public abstract void MostrarArchivos();

        public void DispararEvento(Archivo unArchivo)
        {
            MostrarInfo.Invoke(unArchivo.ToString());
        }
    }
}
