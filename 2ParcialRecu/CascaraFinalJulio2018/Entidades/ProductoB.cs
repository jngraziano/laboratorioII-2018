using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB:Producto
    {
        #region Atributos propiedades y constructores
        protected short alto;
        protected short ancho;
        protected short largo;

        public short Alto { get { return this.alto; } }
        public short Ancho { get { return this.ancho; } }
        public short Largo { get { return this.largo; } }

        public ProductoB() { }
        public ProductoB(string descripcion, short largo, short alto, short ancho)
            : base(descripcion)
        {
            this.largo = largo;
            this.alto = alto;
            this.ancho = ancho;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Multiplico alto largo y ancho
        /// </summary>
        /// <returns></returns>
        public int CaluclarVolumen() 
        {
            return this.Alto * this.Largo * this.Ancho;
        }
        /// <summary>
        /// Devuelvo un string mostrando los datos mas la descripcion de la base
        /// </summary>
        /// <returns></returns>
        public override string Mostrar() 
        {
            return string.Format("DESCRIPCION: {0}, TIPO: {B}, ANCHO: {1}, ALTO: {2}, LARGO: {3}, VOLUMEN: {4}", base.Descripcion, this.Ancho, this.Alto,this.Largo,this.CaluclarVolumen()); 

        }
       

        #endregion
    }
}
