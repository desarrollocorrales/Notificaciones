using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using ToastNotifications.Entity;

namespace ToastNotifications.GUIs
{
    public partial class SuperNotification : Form
    {
        private EventosEntities Contexto;
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
        List<eventos> lstEventosAMostrar;

        private void CargarEventos()
        {
            Contexto = crearContexto();

            lstEventosAMostrar = new List<eventos>();
            CountEventosPorDiaMes(Contexto.eventos.ToList());
            CountEventosSemanal(Contexto.eventos.ToList());

            gridEventos.DataSource = lstEventosAMostrar;
            gvEventos.BestFitColumns();
        }
        private EventosEntities crearContexto()
        {
            string StringConnection = 
                string.Format(Modelos.Configuraciones.SC_ServUserPassPortDatabase,
                                                            Properties.Settings.Default.Servidor,
                                                            Properties.Settings.Default.Usuario,
                                                            Properties.Settings.Default.Password,
                                                            Properties.Settings.Default.Puerto,
                                                            Properties.Settings.Default.BaseDeDatos);
            EventosEntities Context = new EventosEntities(StringConnection);

            return Context;
        }

        private int CountEventosSemanal(List<eventos> lstEventos)
        {
            //Eventos que son del dia de la semana de hoy
            List<eventos> lstEventosSemana = new List<eventos>();

            DayOfWeek DiaDelaSemanaHoy = DateTime.Today.DayOfWeek;
            switch (DiaDelaSemanaHoy)
            {
                case DayOfWeek.Monday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "L" && o.activo == true);
                    break;

                case DayOfWeek.Tuesday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "M" && o.activo == true);
                    break;
                case DayOfWeek.Wednesday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "X" && o.activo == true);
                    break;
                case DayOfWeek.Thursday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "J" && o.activo == true);
                    break;
                case DayOfWeek.Friday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "V" && o.activo == true);
                    break;
                case DayOfWeek.Saturday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "S" && o.activo == true);
                    break;
            }

            //Agregar los eventos a la lista
            lstEventosAMostrar.AddRange(lstEventosSemana);

            return lstEventosSemana.Count;
        }
        private int CountEventosPorDiaMes(List<eventos> lstEventos)
        {
            int DiaDeHoy = DateTime.Today.Day;
            List<eventos> lstEventosDeHoy =
                lstEventos.FindAll(o => o.dia_limite == DiaDeHoy && o.activo == true);

            //Agregar los eventos a la lista
            lstEventosAMostrar.AddRange(lstEventosDeHoy);

            return lstEventosDeHoy.Count;
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
    }
}