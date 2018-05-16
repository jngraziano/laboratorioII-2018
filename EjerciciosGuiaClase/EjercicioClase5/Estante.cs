using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
    class Estante
    {
        #region Variables constructores y getters

        private Producto[] productos;
        private int ubicacionEstante;
        

        private Estante(int capacidad)
        {
            
            this.productos = new Producto[capacidad];
            
            //if (object.ReferenceEquals(aux, null))
            //{
                //for (int i = 0; i < capacidad; i++)
                //{
                //    this.productos[i] = aux[i];
                //}
            //}                      
        }
        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProducto { get { return this.productos; } }
                
        #endregion

        #region Metodos y Sobrecargas

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ubicacion del estante: ");
            sb.AppendLine(e.ubicacionEstante.ToString());
            //si hay ganas, usar el metodo MostrarProducto() en vez de esto
            foreach (var item in e.GetProducto)
            {
                sb.AppendLine("Producto: ");
                sb.AppendLine(Producto.MostrarProducto(item));

                //Otra forma usando
                //conversion explicita del producto (PROBAR DSP)
                //sb.Append("Marca: ");
                //sb.AppendLine(item.GetMarca);
                //sb.Append("Codigo de Barras: ");
                
                //sb.AppendLine((string)item);
                //sb.Append("Precio: ");
                //sb.AppendLine(item.GetPrecio.ToString());
                                                
            }

            return sb.ToString();

        }

        #region Sobrecargas
        public static bool operator ==(Estante e, Producto p)
        {
            //Igualdad, retornará true, si es que el producto ya se encuentra 
            //en el estante, false, caso contrario.
            bool devuelve=false;

            for (int i = 0; i < e.GetProducto.Length; i++)
            {
                if (object.ReferenceEquals(e.GetProducto[i], null) || e.GetProducto[i] != p)
                {
                    devuelve = true;
                    break;

                }
                
                
            }
            
            return devuelve;
        }
        public static bool operator !=(Estante e, Producto p)
        { return !(e == p); }

        public static bool operator +(Estante e, Producto p)
        {
            /*Adición, retornará true y agregará el producto si 
            el estante posee capacidad de almacenar al menos un producto 
            más y dicho producto no se encuentra en él; false, 
            caso contrario. Reutilizar código*/
            bool devuelve=false;
           
            for (int i = 0; i < e.GetProducto.Length; i++)
			{

                if (e != p)
                {
                    

                    if (Object.ReferenceEquals(e.GetProducto[i], null))
                    {
                    //Significa que primero me fijo Si el producto no esta ya en
                    //los productos ya guardados, asigna true y si encuentra
                    //un objeto en null agrega.

                    e.GetProducto[i] = p;
                    devuelve = true;
                    break;

                    }
                }
                
			 
			}
            
            
           
            return devuelve;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            //Sustracción (Estante, Producto), retornará un estante 
            //sin el producto, siempre y cuando el producto se encuentre 
            //en el listado. Reutilizar código.
            for (int i = 0; i < e.GetProducto.Length; i++)
			{
                if (e == p)
                {
                    e.GetProducto[i] = null;
                }
                
			}

            return e;


        }

        #endregion


        #endregion

    }
}
