using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   
    public class ExcepcionesPropias : Exception
    {
        public ExcepcionesPropias() 
        { }
        public ExcepcionesPropias(string message) 
            : base(message)
        { }

        public ExcepcionesPropias(string message, Exception inner) 
            : base(message, inner) 
        { }

        protected ExcepcionesPropias(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) 
        { }
    }
}
