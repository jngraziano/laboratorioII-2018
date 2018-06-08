using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio60
{
    public class Producto
    {
        #region Variables y Constructores
        private int ProductID;
        private string Name;
        private string ProductNumber;

        public Producto()
        { this.ProductID = 0; }

        public Producto(string nombre, string numeroproduct) 
            :this()
        {
            this.Name = nombre;
            this.ProductNumber = numeroproduct;
        }
        public Producto(int id, string nombre, string numeroproduct)
            :this(nombre,numeroproduct)
        {
            this.ProductID = id;
        }

        #endregion 


        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ProductID.ToString());
            sb.AppendLine(this.Name);
            sb.AppendLine(this.ProductNumber);

            return sb.ToString();
        }


        #endregion
    }
}
