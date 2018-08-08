﻿using System;
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

namespace VistaForm
{
    public partial class FormArchivos : Form
    {
        DiscoElectronico electronico;
        ArchiveroFisico fisico;

        public FormArchivos()
        {
            InitializeComponent();
        }

        //a.En el evento Load del formulario instanciar el DiscoElectrónico y el ArchiveroFísico del Form con capacidad para 3 archivos c/uno.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //instanciar un archivo a partir de los datos obtenidos de los controles del formulario.
        //Agregar el archivo a la lista del DiscoElectrónico siempre y cuando haya capacidad.
        //Si se pudo agregar a la lista, guardarlo también en la base de datos.
        //Finalmente limpiar el contenido de los controles del formulario.
        private void btnAlmacenarElectronico_Click(object sender, EventArgs e)
        {
            //Código Alumno

            this.txtNombreArchivo.Text = "";
            this.rtbContenido.Text = "";
        }

        //Instanciar un archivo a partir de los datos obtenidos de los controles del formulario.
        //Guardarlo en un archivo de texto
        //Finalmente limpiar el contenido de los controles del formulario.
        private void btnAlmacenarFisico_Click(object sender, EventArgs e)
        {
            //Código Alumno

            this.txtNombreArchivo.Text = "";
            this.rtbContenido.Text = "";
        }

        //Asociar el manejador del formulario MostrarArchivo al evento MostrarInfo de la clase DiscoElectronico.
        //Ejecutar en un hilo el método MostrarArchivos de la clase DiscoElectronico.
        private void btnLeerElectronico_Click(object sender, EventArgs e)
        {

        }

        public void MostrarArchivo(string info)
        {
            MessageBox.Show(info);
        }

        //En el manejador del botón LeerFisico se deberá, a partir del nombre ingresado en 
        //txtNombreArchivo, recuperar el contenido del archivo y mostrarlo en el rtbContenido.
        private void btnLeerFisico_Click(object sender, EventArgs e)
        {

        }

        //Antes de cerrar, en el evento FormClosing, abortar el hilo del formulario en caso de que siga vivo.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
