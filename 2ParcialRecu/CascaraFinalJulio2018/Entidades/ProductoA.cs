using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entidades
{

    public class ProductoA:Producto
    {
        #region Atributos propiedades y constructores
        protected short diametro;
        protected Material material;

        public short Diametro { get { return this.diametro; } }

        public Material Material
        {
            get { return this.material; }
            set
            {
                if (this.validarMaterial(value)) { this.material = value; }
            }
        }

        public ProductoA() { }

        public ProductoA(string descripcion, short diametro, Material material)
            : base(descripcion)
        {
            this.diametro = diametro;
            this.Material = material;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Valido el material segun su tipo y su diametro. 
        /// </summary>
        /// <param name="unMaterial"></param>
        /// <returns></returns>
        public bool validarMaterial(Material unMaterial)
        {
            bool rta = false;
            MaterialException miExcepcion = new MaterialException(string.Format("No se puede fabricar una pieza de {0} y diametro de {1} centimetros", this.Material, this.Diametro));

            switch (unMaterial)
            {
                case Material.Plastico:
                    rta= true;
                    break;
                case Material.Aluminio:
                    if (this.Diametro <= 10)
                    {
                        rta = true; 
                    }
                    else
                    {
                        throw miExcepcion;  
                    }
                    break;
                case Material.Caucho:
                    if (this.Diametro <= 15)
                    {
                        rta = true;
                    }
                    else
                    {
                        throw miExcepcion;
                    }
                    break;
                default:
                    break;
            }
            return rta;
        }

        /// <summary>
        /// Devuelvo un string mostrando los datos mas la descripcion de la base
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            return string.Format("DESCRIPCION: {0}, TIPO: {A}, DIAMETRO: {1}, MATERIAL: {2}",base.Descripcion,this.Diametro,this.Material); 
        }

        #endregion

    }
}
