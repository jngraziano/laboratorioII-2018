using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
       

        #region Variables Prop y Constructores

        protected DateTime fechaIngreso;

        public int Antiguedad { get { return fechaIngreso.CompareTo(DateTime.Today); } }
        //nunca lo vi, y justo no lo repase el DateTime

        public Profesor(string nomb, string apell, string docu)
        {
            base.nombre = nomb;
            base.apellido = apell;
            base.Documento = docu;
        }
        public Profesor(string nomb, string apell, string docu, DateTime fechaIngres)
            :this(nomb,apell,docu)
        {
            this.fechaIngreso = fechaIngres;
          
        }

        #endregion

        #region Metodos
        public override string ExponerDatos()
        {
            return base.ExponerDatos();
        }
        public override bool ValidarDocumentacion(string doc)
        {
            bool rta = false;
            if(doc.Length == 8)
            {
                rta = true;
            }
            return rta;
        }


        #endregion

    }
}
