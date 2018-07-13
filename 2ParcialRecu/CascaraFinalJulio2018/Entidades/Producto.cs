using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

    public class Producto
    {
        public delegate void ProductoTerminado(object sender, EventArgs e);
        public event ProductoTerminado InformaProductoTerminado;

        #region Atributos, propiedades y constructor
        protected string descripcion;

        public string Descripcion { get { return this.descripcion; } }

        public Producto()
        {
 
        }
        public Producto(string descrip)
        { this.descripcion = descrip; }

        #endregion

        #region Metodos

        public void Elaborar()
        {
            try
            {
                //Guardo el producto
                ProductoDAO.GuardarProducto(this);
                //Disparo el evento
                InformaProductoTerminado.Invoke(this, EventArgs.Empty);


            }
            catch (Exception excep)
            {
                throw excep;
            }

                       
 
        }


        public virtual string Mostrar()
        {
            return string.Format("DESCRIPCION: {0}",this.Descripcion); 

        }
    

        #endregion
    }
}
