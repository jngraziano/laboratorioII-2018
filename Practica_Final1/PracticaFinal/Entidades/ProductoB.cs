using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ProductoB:Producto
    {
        #region Atributos Propiedades y Constructores

        protected short alto;
        protected short ancho;
        protected short largo;

        public short Alto { get { return this.alto; } }
        public short Ancho { get { return this.ancho; } }
        public short Largo { get { return this.largo; } }

        public ProductoB()
        { }
        public ProductoB(string descripcion, short largo, short alto, short ancho)
            : base(descripcion)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CalcularVolumen()
        {
            return this.Alto * this.Ancho * this.Largo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(string.Format(" Tipo: B, ANCHO: {0}, ALTO: {1}, LARGO: {2}, VOLUMEN: {3}", this.Ancho, this.Alto,this.Largo,this.CalcularVolumen()));

            return sb.ToString();
        }
      
        public override bool ValidarDimensiones()
        {
            bool rta = false;

            if ((this.Alto + this.Ancho + this.Largo) <= 100)
            {
                rta = true;
                
            }

            return rta;

        }

        #endregion
    }
}
