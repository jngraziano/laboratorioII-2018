using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region EVENTOS
        public delegate void ProductoTerminado(object sender, EventArgs e);
        public event ProductoTerminado InformarProductoTerrminado;

        #endregion
        #region Atributos Propiedades y Constructores
        protected string descripcion;

        public string Descripcion { get { return this.descripcion; } }

        public Producto()
        { }
        public Producto(string descrip)
        { this.descripcion = descrip; }

        #endregion

        #region Metodos

        /// <summary>
        /// El método Elaborar deberá guardar en la base de datos el
        /// producto y disparar el evento InformarProductoTerminado informando el producto
        /// elaborado.
        /// </summary>
        public void Elaborar()
        {
            ProductoDAO.GuardarProducto(this);
            InformarProductoTerrminado(this,EventArgs.Empty);
        }

        /// <summary>
        /// Mostrar en producto tendrá implementación y podrá ser sobrescrito en las clases hijas.
        /// Deberá retornar un string con el formato:
        /// DESCRIPCIÓN: {descripcion}.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("DESCRIPCION: {0}",this.Descripcion));

            return sb.ToString();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool ValidarDimensiones();

        #endregion
    }
}
