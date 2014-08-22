using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToastNotifications
{
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            try
            {
                Properties.Settings.Default.Servidor = txbServidor.Text;
                Properties.Settings.Default.BaseDeDatos = txbBaseDeDatos.Text;
                Properties.Settings.Default.Usuario = txbUsuario.Text;
                Properties.Settings.Default.Password = txbContraseña.Text;
                Properties.Settings.Default.Puerto = Convert.ToInt32(txbPuerto.Text);
                Properties.Settings.Default.IdentificadorAlmacen = Convert.ToInt32(txbIdentificadorAlmacen.Text);
                Properties.Settings.Default.Save();

                var Mensaje = "La configuracion se a guardado correctamente.";
                var Titulo = "OK";
                var Botones = MessageBoxButtons.OK;
                var Icono = MessageBoxIcon.Information;
                MessageBox.Show(Mensaje, Titulo, Botones, Icono);
                this.Close();
            }
            catch (Exception ex)
            {
                var exMessage = ex.Message;
                var exType = ex.GetType().ToString();
                var Botones = MessageBoxButtons.OK;
                var Icono = MessageBoxIcon.Error;
                MessageBox.Show(exMessage, exType, Botones, Icono);
            }
        }

        private void Frm_Configuracion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar()
        {
            try
            {
                txbServidor.Text = Properties.Settings.Default.Servidor;
                txbBaseDeDatos.Text = Properties.Settings.Default.BaseDeDatos;
                txbUsuario.Text = Properties.Settings.Default.Usuario;
                txbContraseña.Text = Properties.Settings.Default.Password;
                txbPuerto.Text = Properties.Settings.Default.Puerto.ToString();
                txbIdentificadorAlmacen.Text = Properties.Settings.Default.IdentificadorAlmacen.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
