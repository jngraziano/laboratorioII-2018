using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Alumno:Persona
    {
        #region Variables Prop y Constructor
        protected short anio;
        protected Divisiones division;

        public string AnioDivision { get { return anio + "º" + division; } }

        public Alumno()
        { }

        public Alumno(string nomb, string apel, string docu, short an, Divisiones divi)
        {
            base.nombre = nomb;
            base.apellido = apel;
            base.Documento = docu;
            this.anio = an;
            this.division = divi;
        }
        #endregion

        #region Metodos
        public override string ExponerDatos()
        {
            return base.ExponerDatos();
        }
        public override bool ValidarDocumentacion(string doc)
        {
            //ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato XX-XXXX-
            //X siendo las X números. Caso contrario retornará false y no se asignará el documento, siguiendo
            //luego con el curso normal de la aplicación.
            throw new NotImplementedException();
        }

        #endregion
    }
}
