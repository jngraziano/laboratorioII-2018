using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuardar<V,T>
    {
      
        V Guardar(string path, T elemento);
        T Leer(string path);
       
    }
}
