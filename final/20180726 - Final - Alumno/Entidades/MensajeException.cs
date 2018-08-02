using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class MensajeException : Exception
    {
        public MensajeException() { }
        public MensajeException(string message) : base(message) { }
        public MensajeException(string message, Exception inner) : base(message, inner) { }
       
    }
}
