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
        Centralita centralita1 = new Centralita();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnGenerar_Llamada(object sender, EventArgs e)
        {
            FrmLlamador l = new FrmLlamador();
            l.ShowDialog();
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

        }
    }
}
