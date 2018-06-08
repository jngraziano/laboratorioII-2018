using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar(object sender, EventArgs e)
        {

        }

        private void btn_modificar(object sender, EventArgs e)
        {

        }

        private void btn_eliminar(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

            
        }

        private void btn_Mostrar(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();
            producto1 = ProductoDAO.ObtieneProducto();

            lbl1.Text = producto1.Mostrar();
        }


      
    }
}
