using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo//:IEntradaSalida<bool>
    {


        private List<Grupo> grupos;
        private string nombre;
        public const int MAX_EQUIPOS_GRUPO = 4;

        public List<Grupo> Grupos { get { return this.grupos; } }
      
        
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }
    }
}
