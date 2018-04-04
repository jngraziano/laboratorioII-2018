using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
    class Producto
    {
        #region Variables, getters y constructor
        protected string _codigoDeBarra;
        protected string _marca;
        protected float _precio;

        public Producto(string marca, string codigo, float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigo;
            this._precio = precio;
        }

        public string GetMarca { get { return this._marca; } }
        public float GetPrecio { get { return this._precio; } }

        #endregion

        #region Metodos
        
        
        
        public static string MostrarProducto(Producto p)
        {
           
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ");
            sb.AppendLine(p._marca);
            sb.Append("Codigo de barras: ");
            sb.AppendLine(p._codigoDeBarra);
            sb.Append("Precio: ");
            sb.AppendLine(p._precio.ToString());

            return sb.ToString();
                
        }

        #region Sobrecargas
        public static explicit operator string(Producto p)
        {
            //Explícito. Retornará el código de barras del producto que recibe como parámetro.
            return p._codigoDeBarra;

        }
       
        
        public static bool operator ==(Producto p, string marca)
        {
            /*Igualdad (Producto, string). 
            Retornará true, si la marca del producto coincide con
            la cadena pasada por parámetro, false, caso contrario.*/

            if (p._marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            /*Igualdad (Producto, Producto). 
            Retornará true, si las marcas y códigos de barras son iguales,
            false, caso contrario.*/
            if (p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion


        #endregion
    }
}
