using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefonica
{
    public class Centralita
    {
        #region Variables, prop y Constructores

        private List<Llamada> listaDeLlamadas;
        public string razonSocial;

        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }

        protected List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public Centralita()
        {
            List<Llamada> aux = new List<Llamada>();
            this.listaDeLlamadas = aux;
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private void AgregarLlamada(Llamada nuevaLLamada)
        {
            this.listaDeLlamadas.Add(nuevaLLamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float result = 0;
            foreach (var item in this.listaDeLlamadas)
            {

                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                        {
                            result += ((Local)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            result += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:

                        if (item is Local)
                        {
                            result += ((Local)item).CostoLlamada;

                        }
                        if (item is Provincial)
                        {
                            result += ((Provincial)item).CostoLlamada;
                        }

                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this.razonSocial.ToString());
            sb.Append("\nGanancia Local: ");
            sb.AppendLine(this.GananciasPorLocal.ToString());
            sb.Append("\nGanancia Provincial: ");
            sb.AppendLine(this.GananciasPorProvincial.ToString());
            sb.Append("\nGanancia Total: ");
            sb.AppendLine(this.GananciasPorTotal.ToString());
            foreach (Llamada recorre in this.listaDeLlamadas)
            {
                recorre.ToString();

            }

            return sb.ToString();

        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion
    }
}
