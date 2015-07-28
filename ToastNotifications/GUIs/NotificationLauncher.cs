using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToastNotifications.Modelos;
using ToastNotifications.Entity;

namespace ToastNotifications.GUIs
{
    public partial class NotificationLauncher : Form
    {
        private int MinutosCiclo;
        private int MinutosTranscurridos;

        public NotificationLauncher()
        {
            InitializeComponent();
        }

        private void ShowNotification()
        {
            try
            {
                if (MinutosTranscurridos == MinutosCiclo)
                {
                    MinutosTranscurridos = 0;
                    var animationMethod = FormAnimator.AnimationMethod.Roll;
                    var animationDirection = FormAnimator.AnimationDirection.Up;
                    var toastNotification = new Notification(animationMethod, animationDirection);

                    toastNotification.Show();
                }
                else
                {
                    MinutosTranscurridos++;
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        
        private void NotificationLauncher_Load(object sender, EventArgs e)
        {
            MinutosCiclo = ValoresGlobales.MinutosCiclo;
            MinutosTranscurridos = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar()
        {
            IconoBarra.Visible = true;
            this.Hide();
            Temporizador.Enabled = true;
        }

        private void IconoBarra_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            Temporizador.Enabled = false;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Configurar();
        }
        public void Configurar()
        {
            try
            {
                new Frm_Configuracion().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarExcepcion(Exception ex)
        {
            var Mensaje = ex.Message;
            var ExType = ex.GetType().ToString();
            var Botones = MessageBoxButtons.OK;
            var Icono = MessageBoxIcon.Error;

            MessageBox.Show(Mensaje, ExType, Botones, Icono);
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            ShowNotification();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new Frm_Eventos(null).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_Eventos(new eventos()).ShowDialog();
        }

    }
}
