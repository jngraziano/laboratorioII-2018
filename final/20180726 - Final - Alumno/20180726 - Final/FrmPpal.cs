using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace _20180726___Final
{
    // Reutilizar tanto código como sea posible.
    // Primer Parcial: Agregar un atributo del tipo Muebleria e instanciarlo en el constructor.
    // Segundo Parcial y Final
    //   - Agregar un atributo del tipo Lista de Asiento e instanciarlo en el constructor.
    //   - Controlar excepciones en archivos.
    //   - Para el manejo de archivos agregar una interfaz genérica con los métodos V Guardar(string path, T elemento) y T Leer(string path)
    //   - Generar dos clases: ArchivoTexto y ArchivoXML que implementen dicha interfaz. Completar los métodos según corresponda.
    //   - Probar todos los asientos mediante un Thread. Crear un evento FinPruebaCalidad() en Asiento para que informe si la prueba pasó (true) o no (false) y mostrar el resultado por pantalla.
    public partial class FrmPpal : Form
    {
         List<Asiento> listaAsientos;
         Thread miHilo;

        public FrmPpal()
        {
            InitializeComponent();

            this.listaAsientos = new List<Asiento>();
        }

        /// <summary>
        /// Primer Parcial: Agregar el elemento a la mueblería.
        /// Segundo Parcial y Final: Al presionar el botón agregar se deberá guardar la información a un archivo, anexando el nuevo Asiento al final. Agregar el elemento a la lista.
        /// Luego, leer el archivo y mostrarlo en el RichTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region Creo un sofa
            Sofa unSofa = new Sofa();
            unSofa.alto = (short)nudAlto.Value;
            unSofa.ancho = (short)nudAncho.Value;

            Random ram = new Random();
            int devuelveRam;
            devuelveRam=ram.Next(0, 4);
            switch (devuelveRam)
            {
                case 0:
                    unSofa.color = Sofa.Color.Blanco;
                    break;
                case 1:
                    unSofa.color = Sofa.Color.Natural;
                    break;
                case 2:
                    unSofa.color = Sofa.Color.Negro;
                    break;
                case 3:
                    unSofa.color = Sofa.Color.Rojo;
                    break;
                default:
                    break;
            }
            #endregion

            //LO GUARDO
            try 
	        {

               
                //TextWriter WriteFileStream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "GuardoTXT.txt";
                IArchivos<string, string> archivoTXT = new ArchivoTexto();
                
                    archivoTXT.Guardar(ruta, unSofa.ToString());
          

                this.listaAsientos.Add(unSofa);
                
	        }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message);

            }

            //LO LEO
            try
            {

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "GuardoTXT";
                //rtbMensaje.Text=ArchivoTexto.Leer(path);
            }
            catch (Exception excep)
            {
                
                 MessageBox.Show(excep.Message);
         
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Al abrir el programa se deberá leer el archivo y mostrarlo en el RichTextBox
            try
            {

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "GuardoTXT";
                //rtbMensaje.Text = ArchivoTexto.Leer(path);
            }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        /// <summary>
        /// Antes de cerrar, serializar la lista en XML. Hacer las modificaciones necesarias para guardar todos los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (miHilo.IsAlive)
            {
                miHilo.Abort();
            }
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +"GuardoXML";

            foreach (var item in this.listaAsientos)
	        {
                try 
	                {
                        //ArchivoXML.Guardar(archivo, item);
	                }
	                catch (Exception)
	                {
		
		                throw;
	                }
		 
	        }
            

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            miHilo = new Thread(BancoDePrueba);
            miHilo.Start();
            
            //falta el 4
           

        }

        public void BancoDePrueba()
        {
            foreach (var item in this.listaAsientos)
            {
                item.ProbarAsiento();
                MessageBox.Show(item.ToString());
                
            }
           
        }
    }
}
