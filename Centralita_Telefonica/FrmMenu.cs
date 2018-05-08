using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralita_Telefonica
{
    public partial class FrmMenu : Form
    {
        //Centralita centralita1 = new Centralita();

        protected Centralita centralita1;

        public FrmMenu()
        {
            //centralita1.
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnGenerar_Llamada(object sender, EventArgs e)
        {
            //FrmLlamador l = new FrmLlamador();
            //if (l.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
                
            //}
           

          
          
        }

        private void btnFactu_Total(object sender, EventArgs e)
        {

        }

        private void btnFactu_Local(object sender, EventArgs e)
        {

        }

        private void btnFactu_Prov(object sender, EventArgs e)
        {

        }

        private void btnSalir(object sender, EventArgs e)
        {
            const string mensaje = "Desea Salir?";
            const string titulo = "CERRAR";
            var result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
