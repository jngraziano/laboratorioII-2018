using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivo<T,V>
    {
        bool Guardar(T elemento, string path);

        V Leer(string path);
    }
}
