using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Excepciones : Exception
    {
        public Excepciones() { }
        public Excepciones(string message) : base(message) { }
        public Excepciones(string message, Exception inner) : base(message, inner) { }
       
    }
}
