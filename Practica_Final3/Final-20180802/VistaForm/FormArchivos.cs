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
using System.Threading;

using System.Data.SqlClient;


namespace VistaForm
{
    public partial class FormArchivos : Form
    {
        DiscoElectronico electronico;
        ArchiveroFisico fisico;
        Thread miHilo;

        public FormArchivos()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "GuardoTXT.txt";
            this.electronico = new DiscoElectronico();
            this.fisico = new ArchiveroFisico(ruta); 
            
            InitializeComponent();
        }

        //a.En el evento Load del formulario instanciar el DiscoElectrónico y el ArchiveroFísico del Form con capacidad para 3 archivos c/uno.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.electronico.capacidad = 3;
            this.fisico.capacidad = 3;

        }

        //instanciar un archivo a partir de los datos obtenidos de los controles del formulario.
        //Agregar el archivo a la lista del DiscoElectrónico siempre y cuando haya capacidad.
        //Si se pudo agregar a la lista, guardarlo también en la base de datos.
        //Finalmente limpiar el contenido de los controles del formulario.
        private void btnAlmacenarElectronico_Click(object sender, EventArgs e)
        {
            //Código Alumno

            #region Creo un archivo, chequeo capacidad, agrego en Lista y BD
            try
            {
                Archivo unArchivo = new Archivo(this.txtNombreArchivo.Text, this.rtbContenido.Text);

               this.electronico.archivosGuardados = this.electronico + unArchivo;
              
               if (this.electronico.Guardar(unArchivo))
               {
                   MessageBox.Show("Archivo electrónico guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show("error", "ERROR", MessageBoxButtons.OK);
               }

             


                //if (this.electronico.archivosGuardados.Count == this.electronico.capacidad)
                //{
                //    MessageBox.Show(string.Format("Llego al maximo de capacidad de almacenamiento({0} archivos).", this.electronico.capacidad), "Error al agregar", MessageBoxButtons.OK);
                //}
                //while (this.electronico.archivosGuardados.Count < this.electronico.capacidad)
                //{
                //    break;
                //}

            }
            catch (SqlException excep)
            {

                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK);
            }
           
            #endregion

            //Limpio:
            this.txtNombreArchivo.Text = "";
            this.rtbContenido.Text = "";
        }

        //Instanciar un archivo a partir de los datos obtenidos de los controles del formulario.
        //Guardarlo en un archivo de texto
        //Finalmente limpiar el contenido de los controles del formulario.
        private void btnAlmacenarFisico_Click(object sender, EventArgs e)
        {
            //Código Alumno
            try
            {
                Archivo unArchivo = new Archivo(this.txtNombreArchivo.Text, this.rtbContenido.Text);

                this.fisico.Guardar(unArchivo);
                MessageBox.Show("El archivo fue guardado con exito", "Almacenar Fisico", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (FieldAccessException excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK);
            }
           

            this.txtNombreArchivo.Text = "";
            this.rtbContenido.Text = "";
        }

        //Asociar el manejador del formulario MostrarArchivo al evento MostrarInfo de la clase DiscoElectronico.
        //Ejecutar en un hilo el método MostrarArchivos de la clase DiscoElectronico.
        private void btnLeerElectronico_Click(object sender, EventArgs e)
        {

            this.electronico.MostrarInfo += this.MostrarArchivo;

            miHilo = new Thread(this.electronico.MostrarArchivos);
            miHilo.Start();

        }

        public void MostrarArchivo(string info)
        {
            MessageBox.Show(info,"Leer Electronico",MessageBoxButtons.OK);
        }

        //En el manejador del botón LeerFisico se deberá, a partir del nombre ingresado en 
        //txtNombreArchivo, recuperar el contenido del archivo y mostrarlo en el rtbContenido.
        private void btnLeerFisico_Click(object sender, EventArgs e)
        {
            rtbContenido.Text=this.fisico.Leer(this.fisico.pathArchivos);
        }

        //Antes de cerrar, en el evento FormClosing, abortar el hilo del formulario en caso de que siga vivo.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(object.ReferenceEquals(miHilo,null)))
            {
                if (miHilo.IsAlive)
                {

                    miHilo.Abort();
                
                }
                              
            }
          

        }

        private void btn_LeoBase(object sender, EventArgs e)
        {
            try
            {
                this.electronico.archivosGuardados = this.electronico.Leer("dbo.Archivo");

                //MessageBox.Show(unArchivo.ToString(), "El ultimo",MessageBoxButtons.OK);

                foreach (var item in this.electronico.archivosGuardados)
                {
                    MessageBox.Show(item.ToString(), "BASE:");

                }
            }
            catch (NullReferenceException excep)
            {

                MessageBox.Show(excep.Message);
            }
           

            
        }
    }
}
