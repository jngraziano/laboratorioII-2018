using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public enum Letras { A, B, C, D, E, F, G, H }

    public class Grupo:IEntradaSalida<Grupo>
    {
        private List<Equipo> equipos;
        private Letras grupo;
        private short maxCantidad;

        public Letras Group { get { return this.grupo;} set{ this.grupo=value;} }
        public short MaxCantidad { get { return this.maxCantidad; } set { this.maxCantidad = value; } }
        public List<Equipo> Equipos { get{ return this.equipos; }  }

        private Grupo()
        {
            this.equipos = new List<Equipo>();
        }

        public Grupo(Letras grupo, short maxCantidad)
            : this()
        {
            this.grupo = grupo;
            this.maxCantidad = maxCantidad;
        }

        public static Grupo operator +(Grupo g, Equipo e)
        {
            if (g.equipos.Count < g.maxCantidad)
            { g.equipos.Add(e); }
            else
            {
                throw new GrupoLlenoException(string.Format("El Grupo {0} ya cuenta con {1} equipos", g.Group, g.MaxCantidad));
            }
            

            return g;
        }

        /// <summary>
        /// Ordenará la lista de equipos teniendo en cuenta Puntos, Diferencia de Gol y Goles Hechos
        /// </summary>
        /// <param name="eq1"></param>
        /// <param name="eq2"></param>
        /// <returns></returns>
        public static int Ordenar(Equipo eq1, Equipo eq2)
        {
            // Analizo por puntos obtenidos
            if (eq1.Puntos > eq2.Puntos)
                return -1;
            else if (eq1.Puntos < eq2.Puntos)
                return 1;
            else
            {
                // Analizo por diferencia de goles
                short eq1Dif = (short)(eq1.GolesHechos - eq1.GolesRecibidos);
                short eq2Dif = (short)(eq2.GolesHechos - eq2.GolesRecibidos);
                if (eq1Dif > eq2Dif)
                    return -1;
                else if (eq1Dif < eq2Dif)
                    return 1;
                else
                {
                    // Analizo por goles a favor
                    if (eq1.GolesHechos > eq2.GolesHechos)
                        return -1;
                    if (eq1.GolesHechos < eq2.GolesHechos)
                        return 1;
                    else
                        return 0;
                }
            }
        }

        /// <summary>
        /// Retorna la tabla de posiciones ordenada
        /// </summary>
        /// <returns></returns>
        public string MostrarTabla()
        {
            //Ordenar(this);

            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("{0,-20} {1,2} {2,2} {3,2} {4,2}", "Equipo", "Pt", "GH", "GR", "Df"));
            sb.AppendLine("Equipo".FormatoTabla(-20) + " Pt".FormatoTabla(2) + " GH".FormatoTabla(2) + " GR".FormatoTabla(2) + " Df".FormatoTabla(2));
            sb.AppendLine("----------------------------------------");
            foreach(Equipo e in this.equipos)
                sb.AppendLine(string.Format("{0,-20} {1,2} {2,2} {3,2} {4,2}", e.Nombre, e.Puntos, e.GolesHechos, e.GolesRecibidos, (e.GolesHechos - e.GolesRecibidos)));

            return sb.ToString();
        }

        /// <summary>
        /// Crear y simula todos los partidos del Grupo
        /// </summary>
        public void Simular()
        {
            for (int i = 0; i < this.equipos.Count-1; i++)
            {
                for (int j = i+1; j < this.equipos.Count; j++)
                {
                    System.Threading.Thread.Sleep(100);
                    Random r = new Random(this.equipos[i].Nombre.Length + DateTime.Now.Millisecond + DateTime.Now.Second);
                    // Serán los goles convertidos por el primer equipo, y recibidos por el segundo
                    short goles1 = (short)r.Next(0, 5);
                    this.equipos[i].GolesHechos += goles1;
                    this.equipos[j].GolesRecibidos += goles1;
                    r = new Random(this.equipos[j].Nombre.Length + DateTime.Now.Millisecond + DateTime.Now.Second);
                    // Serán los goles recibidos por el primer equipo, y convertidos por el segundo
                    short goles2 = (short)r.Next(0, 5);
                    this.equipos[i].GolesRecibidos += goles2;
                    this.equipos[j].GolesHechos += goles2;

                    if (goles1 > goles2) // Si metió más goles el primer equipo, ganó y le sumo 3 puntos
                        this.equipos[i].Puntos += 3;
                    else if (goles1 < goles2) // Si metió más goles el segundo equipo, ganó y le sumo 3 puntos
                        this.equipos[j].Puntos += 3;
                    else // En caso de empate, ambos suman 1 punto
                    {
                        this.equipos[i].Puntos += 1;
                        this.equipos[j].Puntos += 1;
                    }
                }
            }
        }

        public Grupo Leer()
        {
            Grupo grupoaux = new Grupo();
            
            grupoaux=GrupoDAO.ObtieneGrupo(this);


            return grupoaux;
        }
        public bool Guardar()
        {
            try
            {
                return true;
            }
            catch (NotImplementedException)
            {
                string comment = "El Grupo no podrá ser serializado";
                throw new Excepciones.ExcepcionesPropias(comment);
            }
        }
    }
}
