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
    public partial class FrmLlamador : Form
    {
        //Centralita centralLlamador = new Centralita();

        public FrmLlamador() { }

        public FrmLlamador(Centralita centralMenu)
        {
            //this.centralLlamador.GananciasPorLocal = centralMenu.GananciasPorLocal;

            InitializeComponent();
        }
        //FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita, a
        //fin de volver a ser leída por el formulario de menú una vez terminada la acción.

        //public Centralita CentralLlamador { get { return this. } }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }
    }
}
