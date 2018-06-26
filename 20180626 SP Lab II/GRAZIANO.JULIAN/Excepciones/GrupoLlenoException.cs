using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
     
        public class GrupoLlenoException : Exception
        {
            public GrupoLlenoException() { }
            public GrupoLlenoException(string message) : base(message) { }
            public GrupoLlenoException(string message, Exception inner) : base(message, inner) { }
           
        }
    
}
