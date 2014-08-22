using System;
using System.IO;
using System.Windows.Forms;
using ToastNotifications.DAL;
using LinqToExcel;
using ToastNotifications.Modelos;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ToastNotifications
{
    public partial class NotificationLauncher : Form
    {
        private int MinutosCiclo;
        private int MinutosTranscurridos;
        private List<Configuracion> ListArticulos;
        public NotificationLauncher()
        {
            InitializeComponent();
        }

        private void ShowNotification(List<Configuracion> lstExistencias)
        {
            try
            {
                if (MinutosTranscurridos == MinutosCiclo)
                {
                    MinutosTranscurridos = 0;
                    var animationMethod = FormAnimator.AnimationMethod.Slide;
                    var animationDirection = FormAnimator.AnimationDirection.Up;
                    var toastNotification = new Notification(animationMethod, animationDirection);

                    List<Configuracion>ListArticulosAMostrar = 
                        ListArticulos.FindAll(o => o.Existencia_Minima > o.Existencia).ToList();

                    if (ListArticulosAMostrar.Count != 0)
                    {
                        toastNotification.lstExistencias = ListArticulos;
                        toastNotification.Show();
                    }
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
        private List<Configuracion> ObtenerExtistencias(List<Configuracion> lstSinExistencias)
        {
            try
            {
                FirebirdDAL fbDal = new FirebirdDAL();

                foreach (Configuracion config in lstSinExistencias)
                {
                    config.Existencia = fbDal.ObtenerExistencia(config);
                }

                return lstSinExistencias;
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
                return null;
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
            var Excel = new ExcelQueryFactory(".\\Configuracion\\Configuracion.xls");
            var ListArticulosExcel = from Articulos in Excel.Worksheet<Configuracion>("Articulos") select Articulos;
            this.ListArticulos = ListArticulosExcel.ToList();
            this.ListArticulos = ListArticulos.Distinct().ToList();
            Excel.Dispose();

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
            ListArticulos = ObtenerExtistencias(ListArticulos);
            ShowNotification(ListArticulos);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            AbrirExcel();
        }
        private void AbrirExcel()
        {
            try
            {
                System.Diagnostics.Process.Start(".\\Configuracion\\Configuracion.xls");
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
    }
}
