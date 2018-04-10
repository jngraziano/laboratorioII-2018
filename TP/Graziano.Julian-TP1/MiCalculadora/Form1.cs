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
    public partial class Form1 : Form
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
        public Form1()
        {
          InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


            
    }
}
