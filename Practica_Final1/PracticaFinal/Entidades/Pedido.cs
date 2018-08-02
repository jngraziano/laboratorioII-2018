using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    class Pedido
    {
        #region Atributos Propiedades y Constructores

        public List<Producto> productos;

        public List<Producto> Productos { get { return this.productos; }
            set { this.productos=value; }
        }

        public Pedido()
        {
            this.productos = new List<Producto>();
        }

        #endregion

        #region Metodos

        public void FabricarPedido()
        {
            foreach (var item in this.Productos)
            {
                Thread.Sleep(1000);
                item.Elaborar();
                
            }
        }

        public static implicit operator String(Pedido unPedido)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in unPedido.Productos)
            {
                sb.Append(item.Mostrar());
                
            }
            return sb.ToString(); 
        }

        public static Pedido operator +(Pedido unPedido,Producto unProducto)
        {
            foreach (var item in unPedido.Productos)
            {
                while (unPedido.Productos.Count <=5)
                {
                    if (unProducto.ValidarDimensiones())
	                {
		                unPedido.Productos.Add(unProducto);
	                }
                    
                }
                
            }

            return unPedido;
           
        }

        #endregion
    }
}
