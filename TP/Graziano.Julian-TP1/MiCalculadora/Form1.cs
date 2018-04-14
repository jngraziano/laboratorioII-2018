using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        /*
             *                  WINDOWS FORM 
             * IMPORTANTE: siempre trabajar sobre el Form1.cs o dandole doble click al Design. No Codear en Program                 
             * Ejemplo instanciar formulario: Form miForm = new Form();
             * 1 - Usar con GUI dentro del Design, la pestaña Toolbox, dentro de esta podes arrastrar al WF lo que quieras.
             * 2 - Al darle doble click a lo que sea, te lleva dentro del Form1 al metodo que hace (ejemplo boton).
             * 
             * Uso los metodos del objeto. Ejemplos:
             *  
             *  miForm.Text = "MiCalculadora - Julian Graziano"; //Le pone titulo al form.
             *  miForm.Opacity = 0.89; //capitan obvio.
             *  miForm.Font = new System.Drawing.Font("Arial", 10); //Seteo el tipò de letra.
             *  miForm.ShowInTaskbar = false; no se que hace.
             *  
             *  
             *  Show(): Visualiza el formulario. Puede especificarse su formulario Owner (dueño o propietario).
             *  Close(): Cierra el formulario.
             *  Hide(): Oculta el formulario del usuario.
             *
             * 
             */

        public LaCalculadora()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
      


        private void btnOperar_click(object sender, EventArgs e)
        {

        }





        private void Limpiar()
        {
           //   El método Limpiar será llamado por el evento click del botón btnLimpiar y borrará
           //    los datos de los TextBox, ComboBox y Label de la pantalla.
            this.text_Numero1.Text = "";
            this.text_Numero2.Text = "";
            this.lblResultado = new Label();
            this.cmbOperador = new ComboBox();


        }
        
        private static double Operar(string numero1, string numero2, string operador)
        {
            //El método Operar será estático recibirá los dos números y el operador para luego
            //llamar al método Operar de Calculadora y retornar el resultado al método de evento
            //del botón btnOperar que reflejará el resultado en el Label txtResultado.
            Entidades.Calculadora calcu = new Calculadora();
            //trabajar con esto
            
            Entidades.Numero num1 = new Entidades.Numero(numero1);
            Entidades.Numero num2 = new Entidades.Numero(numero2);




            return calcu.Operar(num1, num2, operador);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_click(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirADecimal_click(object sender, EventArgs e)
        {

        }


            
    }
}
