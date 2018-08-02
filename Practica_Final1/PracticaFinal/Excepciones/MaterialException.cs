using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    
    public class MaterialException : Exception
    {
        public MaterialException() { }
        public MaterialException(string message) : base(message) { }
        public MaterialException(string message, Exception inner) : base(message, inner) { }
       
    }
    
}
