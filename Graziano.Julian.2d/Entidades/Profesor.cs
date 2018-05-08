using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Profesor:Persona
    {
        //validar que tenga 8 caracteres el validardocumentacion

        #region Variables Prop y Constructores

        protected DateTime fechaIngreso;

        public int Antiguedad { get { return fechaIngreso.CompareTo(DateTime.Today); } }
        //corregir

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

    }
}
