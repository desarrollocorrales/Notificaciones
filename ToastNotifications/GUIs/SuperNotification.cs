using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using ToastNotifications.Entity;
using ToastNotifications.Modelos;

namespace ToastNotifications.GUIs
{
    public partial class SuperNotification : Form
    {
        public List<eventos> lstEventosTest;
        public EventosEntities Contexto;
        private static List<SuperNotification> openNotifications = new List<SuperNotification>();
        private bool _allowFocus;
        private readonly FormAnimator _animator;
        private IntPtr _currentForegroundWindow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="duration"></param>
        /// <param name="animation"></param>
        /// <param name="direction"></param>
        public SuperNotification(FormAnimator.AnimationMethod animation, FormAnimator.AnimationDirection direction)
        {
            InitializeComponent();

            _animator = new FormAnimator(this, animation, direction, 500);

            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 20, 20));
        }

        #region Methods

        /// <summary>
        /// Displays the form
        /// </summary>
        /// <remarks>
        /// Required to allow the form to determine the current foreground window before being displayed
        /// </remarks>
        public new void Show()
        {
            // Determine the current foreground window so it can be reactivated each time this form tries to get the focus
            _currentForegroundWindow = NativeMethods.GetForegroundWindow();

            base.Show();
        }

        #endregion // Methods

        #region Event Handlers

        private void Notification_Load(object sender, EventArgs e)
        {
            // Display the form just above the system tray.
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                                 Screen.PrimaryScreen.WorkingArea.Height - Height);

            // Move each open form upwards to make room for this one
            foreach (SuperNotification openForm in openNotifications)
            {
                openForm.Top -= Height;
            }

            openNotifications.Add(this);
        }

        private void Notification_Activated(object sender, EventArgs e)
        {
            // Prevent the form taking focus when it is initially shown
            if (!_allowFocus)
            {
                // Activate the window that previously had focus
                NativeMethods.SetForegroundWindow(_currentForegroundWindow);
            }
        }

        private void Notification_Shown(object sender, EventArgs e)
        {
            CargarEventos();

            // Once the animation has completed the form can receive focus
            _allowFocus = true;

            // Close the form by sliding down.
            _animator.Duration = 0;
            _animator.Direction = FormAnimator.AnimationDirection.Down;
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Move down any open forms above this one
            foreach (SuperNotification openForm in openNotifications)
            {
                if (openForm == this)
                {
                    // Remaining forms are below this one
                    break;
                }
                openForm.Top += Height;
            }

            openNotifications.Remove(this);
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelRO_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion // Event Handlers

        #region * * *  Cargar Recordatorios  * * *

        private void CargarEventos()
        {
            gridEventos.DataSource = lstEventosTest;
            gvEventos.BestFitColumns();
        }

        #endregion

        private void gvEventos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int indice = gvEventos.GetSelectedRows()[0];
            eventos EventoSeleccionado = (eventos)gvEventos.GetRow(indice);

            lblDescripción.Text = EventoSeleccionado.descripcion;
            lblBanco.Text = EventoSeleccionado.banco;
            lblCuentaBancaria.Text = EventoSeleccionado.cuenta_bancaria;
            lblNotas.Text = EventoSeleccionado.notas;  
        }

        private void btnTerminarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTerminar() == true)
                    TerminarEvento();
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
            }
        }
        private void TerminarEvento()
        {
            Logger.AgregarLog("  --- Terminar el Evento ---  ");
            Logger.AgregarLog("         Obtener el evento seleccionado...");

            //Obtener el  evento
            int index = gvEventos.GetSelectedRows()[0];
            eventos evento = (eventos)gvEventos.GetRow(index);
            Logger.AgregarLog(string.Format("         Id del evento = {0}...", evento.id_evento));

            //Crear nuevo evento terminado
            eventos_realizados evento_terminado = new eventos_realizados();
            evento_terminado.id_evento = evento.id_evento;
            evento_terminado.fecha = DateTime.Today.Date;
            evento_terminado.hora = DateTime.Now.TimeOfDay;
            evento_terminado.id_usuario = Properties.Settings.Default.id_usuario;
            Contexto.eventos_realizados.AddObject(evento_terminado);
            Contexto.SaveChanges();

            Logger.AgregarLog("  --------------------------  ");
            Logger.AgregarLog();

            usuarios usuario = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == Properties.Settings.Default.id_usuario);
            EnviaCorreos.Enviar(evento, usuario);

            ActualizarListaEventos(evento_terminado.id_evento);
        }
        private bool ValidarTerminar()
        {
            int indice = gvEventos.GetSelectedRows()[0];
            eventos EventoSeleccionado = (eventos)gvEventos.GetRow(indice);

            string Mensaje = string.Format("¿Esta seguro que desea marcar el recordatorio '{0}' como terminado?", EventoSeleccionado.nombre);
            DialogResult dr = MessageBox.Show(Mensaje, "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                return true;

            return false;
        }
        private void ActualizarListaEventos(long id_evento)
        {
            eventos evento_a_quitar = lstEventosTest.Find(o => o.id_evento == id_evento);
            lstEventosTest.Remove(evento_a_quitar);
            if (lstEventosTest.Count != 0)
                CargarEventos();
            else
                this.Close();
        }
    }
}