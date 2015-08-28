using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToastNotifications.Entity;
using ToastNotifications.Modelos;

namespace ToastNotifications.GUIs
{
    public partial class NotificationLauncher : Form
    {
        private Frm_Autorizar frmAutorizar;
        private List<eventos> lstEventosAMostrar;
        private int MinutosTranscurridos;

        public NotificationLauncher()
        {
            InitializeComponent();
        }

        private void ShowNotification()
        {
            try
            {
                lstEventosAMostrar = new List<eventos>();

                string StringConnection =
                string.Format(Modelos.Configuraciones.SC_ServUserPassPortDatabase,
                                                            Properties.Settings.Default.Servidor,
                                                            Properties.Settings.Default.Usuario,
                                                            Properties.Settings.Default.Password,
                                                            Properties.Settings.Default.Puerto,
                                                            Properties.Settings.Default.BaseDeDatos);

                EventosEntities Contexto = new EventosEntities(StringConnection);

                var animationMethod = FormAnimator.AnimationMethod.Fade;
                var animationDirection = FormAnimator.AnimationDirection.Up;
                var toastNotification = new Notification(animationMethod, animationDirection);

                usuarios user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == Properties.Settings.Default.id_usuario);
                List<eventos> lstEventos = user.eventos.ToList();

                if (user.id_tipousuario == "S")
                {
                    Logger.AgregarLog("Es Super Usuario");
                    //Super Usuario
                    int iDia = DateTime.Today.Day;

                    string sDia = string.Empty;
                    switch (DateTime.Today.DayOfWeek)
                    {
                        case DayOfWeek.Monday:      sDia = "L"; break;
                        case DayOfWeek.Tuesday:     sDia = "M"; break;
                        case DayOfWeek.Wednesday:   sDia = "X"; break;
                        case DayOfWeek.Thursday:    sDia = "J"; break;
                        case DayOfWeek.Friday:      sDia = "V"; break;
                        case DayOfWeek.Saturday:    sDia = "S"; break;
                    }

                    lstEventos = Contexto
                                    .eventos
                                    .ToList()
                                    .FindAll(o=>o.activo == true && (o.dia_limite == iDia || o.dia_semana == sDia))
                                    .ToList();

                    if (lstEventos.Count != 0)
                    {
                        animationMethod = FormAnimator.AnimationMethod.Fade;
                        animationDirection = FormAnimator.AnimationDirection.Up;
                        var superToastNotification = new SuperNotification(animationMethod, animationDirection);
                        superToastNotification.Show();
                    }
                }
                else
                {
                    Logger.AgregarLog("Es usuario normal");
                    //Usuario Normal

                    //Tipo de Mes Par o Non
                    string tipoMes = string.Empty;
                    if ((DateTime.Today.Month % 2) == 0)
                        tipoMes = "P";
                    else
                        tipoMes = "N";

                    //Eventos que son por dia de la semana 
                    int iEventosDiaSemana = CountEventosSemanal(lstEventos, tipoMes);

                    //Eventos que son del dia de hoy
                    int iEventosDelDiaMes = CountEventosPorDiaMes(lstEventos, tipoMes);

                    Logger.AgregarLog(string.Format("Eventos Semanales: {0}. Eventos del dia: {1}", iEventosDiaSemana, iEventosDelDiaMes));

                    if (iEventosDelDiaMes != 0 || iEventosDiaSemana != 0)
                    {
                        toastNotification.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
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
            List<eventos> lstEventosDeHoy =
                lstEventos.FindAll(o => o.dia_limite == DiaDeHoy && o.activo == true &&
                                       (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == tipoMes));

            //Agregar los eventos a la lista
            lstEventosAMostrar.AddRange(lstEventosDeHoy);

            return lstEventosDeHoy.Count;
        }

        private void NotificationLauncher_Load(object sender, EventArgs e)
        {
            frmAutorizar = new Frm_Autorizar(this);
            MinutosTranscurridos = 0;
            CargarDatos();
        }
        private void CargarDatos()
        {
            txbServidor.Text = Properties.Settings.Default.Servidor;
            txbUsuario.Text = Properties.Settings.Default.Usuario;
            txbContraseña.Text = Properties.Settings.Default.Password;
            nudPuerto.Value = Properties.Settings.Default.Puerto;
            nudMinutos.Value = Properties.Settings.Default.Minutos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar()
        {
            Logger.AgregarLog("Iniciar conteo");
            IconoBarra.Visible = true;            
            Temporizador.Enabled = true;
            this.Hide();
        }

        private void IconoBarra_DoubleClick(object sender, EventArgs e)
        {
            Temporizador.Enabled = false;
            frmAutorizar.ShowDialog();
            Temporizador.Enabled = true;         
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            MinutosTranscurridos++;
            Logger.AgregarLog("Minutos transcurridos: " + MinutosTranscurridos);

            if (MinutosTranscurridos == Properties.Settings.Default.Minutos)
            {
                Logger.AgregarLog("Mostrar Eventos del usuario");

                ShowNotification();

                MinutosTranscurridos = 0;
            }
        }

        private void NotificationLauncher_Shown(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Servidor = txbServidor.Text;
                Properties.Settings.Default.Usuario = txbUsuario.Text;
                Properties.Settings.Default.Password = txbContraseña.Text;
                Properties.Settings.Default.Puerto = (int)nudPuerto.Value;
                Properties.Settings.Default.Minutos = (int)nudMinutos.Value;
                Properties.Settings.Default.BaseDeDatos = (string)cbDataBase.SelectedItem;

                usuarios user = (usuarios)cbUsuarioSistema.SelectedItem;
                Properties.Settings.Default.id_usuario = Convert.ToInt32(user.id_usuario);

                Properties.Settings.Default.Save();
                Iniciar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Existe un error en los datos....", ex.GetType().ToString());
            }
        }

        private void cbDataBase_Click(object sender, EventArgs e)
        {
            cargarBasesDeDatos();
        }
        private void cargarBasesDeDatos()
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder MyCSB = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            MyCSB.UserID = txbUsuario.Text;
            MyCSB.Password = txbContraseña.Text;
            MyCSB.Port = Convert.ToUInt32(nudPuerto.Value);
            MyCSB.Server = txbServidor.Text;

            MySql.Data.MySqlClient.MySqlConnection MyConn = new MySql.Data.MySqlClient.MySqlConnection(MyCSB.ConnectionString);
            try
            {
                MyConn.Open();

                MySql.Data.MySqlClient.MySqlCommand MyComm = new MySql.Data.MySqlClient.MySqlCommand();
                MyComm.Connection = MyConn;
                MyComm.CommandText = "SHOW DATABASES";

                MySql.Data.MySqlClient.MySqlDataAdapter MyAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                MyAdapter.SelectCommand = MyComm;

                System.Data.DataTable dtResultado = new System.Data.DataTable();
                MyAdapter.Fill(dtResultado);

                List<string> lstDatabases = new List<string>();
                foreach(System.Data.DataRow row in dtResultado.Rows)
                {
                    lstDatabases.Add(row[0].ToString());
                }

                cbDataBase.DataSource = lstDatabases;
            }
            catch (Exception)
            {
                cbDataBase.DataSource = null;
            }
        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                string strServidor = txbServidor.Text;
                string strUsuario = txbUsuario.Text;
                string strPuerto = nudPuerto.Value.ToString();
                string strContraseña = txbContraseña.Text;
                string strBaseDeDatos = cbDataBase.SelectedItem.ToString();

                string sSC = string.Format(Configuraciones.SC_ServUserPassPortDatabase,
                                                           strServidor, strUsuario, strContraseña, strPuerto, strBaseDeDatos);

                EventosEntities Contexto = new EventosEntities(sSC);

                List<usuarios> lstUsuarios = 
                    Contexto.usuarios.Where(o => o.activo == "S").ToList();
                cbUsuarioSistema.DataSource = lstUsuarios;
                cbUsuarioSistema.ValueMember = "id_usuario";
                cbUsuarioSistema.DisplayMember = "nombre";
            }
            catch
            {
                cbUsuarioSistema.DataSource = null;
            }
        }
    }
}
