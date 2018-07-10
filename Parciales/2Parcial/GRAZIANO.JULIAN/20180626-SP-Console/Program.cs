using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Threading;

namespace _20180626_SP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo t = new Torneo("Rusia 2018");
            Console.Title = "Copa Mundial Rusia 2018";

            Grupo grupoA = new Grupo(Letras.A,Torneo.MAX_EQUIPOS_GRUPO);
            Grupo grupoB = new Grupo(Letras.B,Torneo.MAX_EQUIPOS_GRUPO);
            Grupo grupoC = new Grupo(Letras.C,Torneo.MAX_EQUIPOS_GRUPO);

            Grupo grupoD = new Grupo(Letras.D, Torneo.MAX_EQUIPOS_GRUPO);
            grupoD.Leer();

           

            
            t.Grupos.Add(grupoD);

            //public void ImprimirResultados(Grupo unGrupo)
            //{
            //    unGrupo.MostrarTabla();

            //}
            // Agregar Thread

            // **************

            Console.ReadKey();
        }
    }
}
