using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        #region Atributos propiedades y constructores
        public List<Producto> productos;

        public List<Producto> Productos { get { return this.productos; } set { this.productos = value; } }

        public Pedido()
        {
            List<Producto> aux = new List<Producto>();

            this.Productos = aux;
        }

    
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega un producto al pedido (5 MAX)
        /// </summary>
        /// <param name="unPedido"></param>
        /// <param name="unProducto"></param>
        /// <returns></returns>
        public static Pedido operator +(Pedido unPedido, Producto unProducto)
        {
            foreach (var item in unPedido.Productos)
            {
                while (unPedido.Productos.Count <= 5)
                {
                    unPedido.Productos.Add(unProducto);
                }
            }

            return unPedido;
        }

        public void FabricarPedido()
        {
            foreach (var item in this.Productos)
            {
                Thread.Sleep(1000);
                item.Elaborar();
                
            }

            
        }



        #endregion

    }
}
