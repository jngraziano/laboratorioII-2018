using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    class ProductoA:Producto
    {
        #region Atributos Propiedades y Constructores
        protected short diametro;
        protected Material material;

        public short Diametro { get { return this.diametro; } }
        public Material Material { get { return this.material; }
            set {
                if (ValidarMaterial(value))
                {
                    this.material = value; 
                }
                }
        }

        public ProductoA()
        { }
        public ProductoA(string descripcion, short diametro, Material material) :
            base(descripcion)
        {
            this.diametro = diametro;
            this.Material = material;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(string.Format(" Tipo: A, DIÁMETRO: {1}, MATERIAL: {2}",this.Diametro,this.Material));

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool ValidiarDimensiones()
        {
            bool rta = false;
            if ((this.Diametro % 2)==0)
            {
                if (this.Diametro>=30 || this.Diametro<=50)
                {
                    rta = true;
                }
                
            }

            return rta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unMaterial"></param>
        /// <returns></returns>
        public bool ValidarMaterial(Material unMaterial)
        {
            bool rta = false;
            MaterialException miexepcion = new MaterialException(string.Format("No se puede fabricar unapieza de {0} y diámetro de {1} centímetros.",unMaterial,this.Diametro));


            switch (unMaterial)
            {
                case Material.Plastico:
                    rta = true;
                   
                    break;
                case Material.Aluminio:
                    if (this.Diametro <= 10)
                    {
                        rta = true;
                    }
                   
                    break;
                case Material.Caucho:
                    if (this.Diametro <= 15)
                    {
                        rta = true;
                    }
                    break;
                default:
                    break;
            }

            if (rta == false)
            {
                throw miexepcion;
                
            }


            return rta;
        }


        #endregion
    }
}
