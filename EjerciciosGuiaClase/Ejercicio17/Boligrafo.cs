using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        #region Variables y constructor
        int cantidadTintaMaxima;
        ConsoleColor color;
        int tinta;

        public Boligrafo(ConsoleColor Color, int tint)
        {
            this.cantidadTintaMaxima = 100;
            this.color = Color;

        }
        #endregion

        #region Metodos

        #region Getters
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public int GetTinta()
        {
            return this.tinta;
        }
        #endregion

        private void SetTinta(int tinta)
        {
            if (tinta < 0 || tinta > 100)
            {
                Console.WriteLine("\nError. Reingrese: ");
                this.cantidadTintaMaxima = int.Parse(Console.ReadLine());
            }
            else
            {
                this.cantidadTintaMaxima = tinta;
            }

        }

        public void Recargar()
        {
            this.cantidadTintaMaxima=100;
        }


        public bool Pintar(int gasto, out string dibujo)
        {
            /*ACLARACION IMPORTANTE OUT
             * Cuando el metodo tiene el out, el return del metodo (si es que devuelve algo)
             * devuelve lo que la misma funcion indique.
             * Lo que podes hacer o no es modificar la variable dibujo en este caso
             * y queda guardada para el main tambièn y listo.
             * 
             * */
            int result = this.Restar(this.tinta, gasto);
            bool rta;
            
            if (result > 0 || result == 0)
	        {
                rta= true;
		        
	        }
            else
            {
               rta = false;   

 
            }
            for (int i = 0; i < gasto; i++)
            {
               
                
            }
             dibujo = "*";
            
            return rta;
            
        }

        public int Restar(int num1, int num2)
        {

            int result = num1 - num2;
            return result;
        }
       
        
        #endregion
    }
}
