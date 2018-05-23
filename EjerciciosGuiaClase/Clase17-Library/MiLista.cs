using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17_Library
{
    //        Dado el siguiente Main [DESCARGAR]:
    //Utilizar Generics y Arrays construir la clase MiLista que imitará el comportamiento de List. Se deberán crear los métodos:

    //Add: agregá un ítem al array.
    //Remove: eliminará el primer elemento igual que encuentre.
    //Count: propiedad que retornará la cantidad ítems del array.
    //Implementar IEnumerable para poder recorrerla con, por ejemplo, foreach.

    //NOTA: se deberá redimensionar el array con Array.Resize tanto en el método Add como en el Remove.
    public class MiLista<T> : IEnumerable<T>
    {
      public T[] lista;

      public MiLista()
      {
        this.lista = new T[0];
      }

      public void Add(T obj)
      {
          /*Resize: cambia claramente el tamaño del array al numero que desee.
           */
          Array.Resize(ref lista, lista.Length + 1);
          this.lista[lista.Length] = obj;
          //porq -1? wat
          //Array.Resize(ref lista, lista.Length + 1);
          //this.lista[lista.Length - 1] = item;
      }
      public void Remove(T obj)
      {
          for (int i = 0; i < this.lista.Count(); i++)
          {
              if (true)
              {
                  
              }
          }
          Array.Resize(ref lista, lista.Length - 1);
      }


    }
}
