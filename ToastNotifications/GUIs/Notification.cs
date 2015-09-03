using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using ToastNotifications.Entity;
using ToastNotifications.Modelos;

namespace ToastNotifications.GUIs
{
    public partial class Notification : Form
    {
        public List<eventos> lstEventosTest;
        private EventosEntities Contexto;
        private static List<Notification> openNotifications = new List<Notification>();
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
        public Notification(FormAnimator.AnimationMethod animation, FormAnimator.AnimationDirection direction)
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
            foreach (Notification openForm in openNotifications)
            {
                openForm.Top -= Height;
            }

            openNotifications.Add(this);
            
            //Crear el contexto
            Contexto = crearContexto();
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
            //CargarEventos();
            gridEventos.DataSource = lstEventosTest;
            gvEventos.BestFitColumns();

            // Once the animation has completed the form can receive focus
            _allowFocus = true;

            // Close the form by sliding down.
            _animator.Duration = 0;
            _animator.Direction = FormAnimator.AnimationDirection.Down;
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Move down any open forms above this one
            foreach (Notification openForm in openNotifications)
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
            usuarios user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == Properties.Settings.Default.id_usuario);

            //Tipo de Mes Par o Non
            string tipoMes = string.Empty;
            if ((DateTime.Today.Month % 2) == 0)
                tipoMes = "P";
            else
                tipoMes = "N";

            lstEventosAMostrar = new List<eventos>();
            CountEventosPorDiaMes(user.eventos.ToList(), tipoMes);
            CountEventosSemanal(user.eventos.ToList(), tipoMes);
            QuitarEventosTerminados();

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

        private int CountEventosSemanal(List<eventos> lstEventos, string tipoMes)
        {
            //Eventos que son del dia de la semana de hoy
            List<eventos> lstEventosSemana = new List<eventos>();

            DayOfWeek DiaDelaSemanaHoy = DateTime.Today.DayOfWeek;
            switch (DiaDelaSemanaHoy)
            {
                case DayOfWeek.Monday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "L" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;

                case DayOfWeek.Tuesday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "M" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;
                case DayOfWeek.Wednesday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "X" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;
                case DayOfWeek.Thursday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "J" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;
                case DayOfWeek.Friday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "V" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;
                case DayOfWeek.Saturday:
                    lstEventosSemana =
                        lstEventos.FindAll(o => o.dia_semana == "S" && o.activo == true &&
                                               (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));
                    break;
            }

            //Agregar los eventos a la lista
            lstEventosAMostrar.AddRange(lstEventosSemana);

            return lstEventosSemana.Count;
        }
        private int CountEventosPorDiaMes(List<eventos> lstEventos, string tipoMes)
        {
            int DiaDeHoy = DateTime.Today.Day;
            int iDiasDelMes = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            foreach (eventos evento in lstEventos)
            {
                byte? dia_limite = evento.dia_limite;
                if (dia_limite != null)
                {
                    Logger.AgregarLog("         El evento es por dia del mes...");
                    if (dia_limite > iDiasDelMes)
                    {
                        Logger.AgregarLog("         El dia configurado es mayor al ultimo dia en el mes...");
                        dia_limite = Convert.ToByte(iDiasDelMes);
                        Logger.AgregarLog(string.Format("         El dia cambia al ultimo dia del mes [{0}]...", dia_limite));
                    }

                    if ((dia_limite == DateTime.Today.Day) && 
                        (evento.tipos_evento.id_tipo_evento == "T" || evento.tipos_evento.id_tipo_evento == tipoMes))
                    {
                        Logger.AgregarLog(string.Format("         Se agrega el evento con id {0} nombre {1}...", evento.id_evento, evento.nombre));
                        lstEventosAMostrar.Add(evento);
                    }
                }
            }

            return lstEventosAMostrar.Count;
        }
        private void QuitarEventosTerminados()
        {
            Logger.AgregarLog("       Obtener la lista de todos los eventos terminados el dia de hoy...");
            List<eventos_realizados> lstEventosRealizados = Contexto.eventos_realizados.Where(o => o.fecha == DateTime.Today.Date).ToList();

            Logger.AgregarLog("       Quitar los eventos terminados de la lista...");
            foreach (eventos_realizados evento_realizado in lstEventosRealizados)
            {
                eventos evento_a_quitar = lstEventosAMostrar.FirstOrDefault(o => o.id_evento == evento_realizado.id_evento);
                if (evento_a_quitar != null)
                {
                    lstEventosAMostrar.Remove(evento_a_quitar);
                }
            }
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
        private bool ValidarTerminar()
        {
            int indice = gvEventos.GetSelectedRows()[0];
            eventos EventoSeleccionado = (eventos)gvEventos.GetRow(indice);

            string Mensaje = string.Format("¿Esta seguro que desea marcar el recordatorio '{0}' como terminado?", EventoSeleccionado.nombre);
            DialogResult dr = MessageBox.Show(Mensaje,"Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                return true;

            return false;
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