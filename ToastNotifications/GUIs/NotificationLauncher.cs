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
                string StringConnection =
                    string.Format(Modelos.Configuraciones.SC_ServUserPassPortDatabase,
                                    Properties.Settings.Default.Servidor, Properties.Settings.Default.Usuario,
                                    Properties.Settings.Default.Password, Properties.Settings.Default.Puerto,
                                    Properties.Settings.Default.BaseDeDatos);

                Logger.AgregarLog("Crear el contexto de la base de datos...");
                EventosEntities Contexto = new EventosEntities(StringConnection);

                Logger.AgregarLog("Obtener el usuario configurado...");
                usuarios user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == Properties.Settings.Default.id_usuario);
            
                if (user.id_tipousuario == "S")
                {
                    //Super Usuario
                    MostrarRecordatorioSuperUsuario(Contexto);                    
                }
                else
                {
                    //Usuario Normal
                    MostrarRecordatoriosUsuario(Contexto, user);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
            }
        }

        private void MostrarRecordatorioSuperUsuario(EventosEntities Contexto)
        {
            Logger.AgregarLog("Es Super Usuario...");

            int iDia = DateTime.Today.Day;
            int iDiasDelMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            string sDia = string.Empty;

            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday: sDia = "L"; break;
                case DayOfWeek.Tuesday: sDia = "M"; break;
                case DayOfWeek.Wednesday: sDia = "X"; break;
                case DayOfWeek.Thursday: sDia = "J"; break;
                case DayOfWeek.Friday: sDia = "V"; break;
                case DayOfWeek.Saturday: sDia = "S"; break;
            }

            string sTipoMes = string.Empty;
            if (DateTime.Today.Month % 2 == 0)
            {
                sTipoMes = "P";
            }
            else
            {
                sTipoMes = "N";
            }

            Logger.AgregarLog("     Obtener todos los eventos activos de todos los usuarios...");
            List<eventos> lstEventos = Contexto.eventos.Where(o => o.activo == true).ToList();
            Logger.AgregarLog("     Obtener todos los eventos semanales...");
            List<eventos> lstEventosSemanales = 
                Contexto.eventos.Where(o =>  o.activo == true 
                                         &&  o.dia_semana == sDia
                                         && (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento == sTipoMes)).ToList();

            Logger.AgregarLog(string.Format("     Obtener todos los eventos por número de día [{0}]...", iDia));
            List<eventos> lstEventosDelDia = new List<eventos>();
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
                    
                    //******************** Agregado el 07/09/2015 ****************************************************************************
                    //Si el dia es sabado o domingo recorrerlo al dia habil anterior
                    Logger.AgregarLog("         Si el dia es sabado o domingo recorrerlo al dia habil anterior...");
                    DateTime fechDeEvento = new DateTime(DateTime.Today.Year, DateTime.Today.Month, Convert.ToInt32(evento.dia_limite));
                    if (fechDeEvento.DayOfWeek == DayOfWeek.Sunday)
                    {
                        //El evento cae en domingo
                        Logger.AgregarLog("         El evento cae en domingo, atrasar el dia limite 2 dias...");
                        dia_limite -= 2;
                    }
                    else if (fechDeEvento.DayOfWeek == DayOfWeek.Saturday)
                    {
                        //El evento cae en sabado
                        Logger.AgregarLog("         El evento cae en sabado, atrasar el dia limite 1 dia...");
                        dia_limite -= 1;
                    }
                    //******************** Fin del Agregado el 07/09/2015 ********************************************************************

                    if ((dia_limite == DateTime.Today.Day) && 
                        (evento.tipos_evento.id_tipo_evento == "T" || evento.tipos_evento.id_tipo_evento == sTipoMes))
                    {
                        Logger.AgregarLog(string.Format("         Se agrega el evento con id {0} nombre {1}...", evento.id_evento, evento.nombre));
                        lstEventosDelDia.Add(evento);
                    }
                }
            }

            Logger.AgregarLog("     Crear una lista con todos los eventos...");

            lstEventosAMostrar = new List<eventos>();
            lstEventosAMostrar.AddRange(lstEventosSemanales);
            lstEventosAMostrar.AddRange(lstEventosDelDia);

            Logger.AgregarLog("     Obtener la lista de todos los eventos terminados el dia de hoy...");
            List<eventos_realizados> lstEventosRealizados = Contexto.eventos_realizados.Where(o => o.fecha == DateTime.Today.Date).ToList();

            Logger.AgregarLog("     Quitar los eventos terminados de la lista...");
            foreach (eventos_realizados evento_realizado in lstEventosRealizados)
            {
                eventos evento_a_quitar = lstEventos.FirstOrDefault(o => o.id_evento == evento_realizado.id_evento);
                if (evento_a_quitar != null)
                {
                    lstEventosAMostrar.Remove(evento_a_quitar);
                }
            }

            if (lstEventosAMostrar.Count != 0)
            {
                Logger.AgregarLog(string.Format("     Se mostrarán {0} eventos...", lstEventos.Count));

                var animationMethod = FormAnimator.AnimationMethod.Fade;
                var animationDirection = FormAnimator.AnimationDirection.Up;
                var superToastNotification = new SuperNotification(animationMethod, animationDirection);
                
                superToastNotification.Contexto = Contexto;
                superToastNotification.lstEventosTest = lstEventosAMostrar;
                superToastNotification.Show();
            }
        }

        private void MostrarRecordatoriosUsuario(EventosEntities Contexto, usuarios usuario)
        {
            Logger.AgregarLog("Es Usuario Normal...");

            int iDia = DateTime.Today.Day;
            int iDiasDelMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            string sDia = string.Empty;

            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday: 
                    sDia = "L"; break;
                case DayOfWeek.Tuesday: 
                    sDia = "M"; break;
                case DayOfWeek.Wednesday: 
                    sDia = "X"; break;
                case DayOfWeek.Thursday: 
                    sDia = "J"; break;
                case DayOfWeek.Friday: 
                    sDia = "V"; break;
                case DayOfWeek.Saturday: 
                    sDia = "S"; break;
            }

            string sTipoMes = string.Empty;
            if (DateTime.Today.Month % 2 == 0)
            {
                sTipoMes = "P";
            }
            else
            {
                sTipoMes = "N";
            }

            Logger.AgregarLog("     Obtener todos los eventos activos del usuario...");
            List<eventos> lstEventos = 
                usuario
                .eventos
                .Where(o => o.activo == true && 
                           (o.tipos_evento.id_tipo_evento == "T" || o.tipos_evento.id_tipo_evento==sTipoMes)).ToList();

            Logger.AgregarLog(string.Format("     Obtener todos los eventos semanales del dia [{0}]...", sDia));
            List<eventos> lstEventosSemanales = lstEventos.Where(o => o.dia_semana == sDia).ToList();

            Logger.AgregarLog(string.Format("     Obtener todos los eventos por número de día [{0}]...", iDia));
            List<eventos> lstEventosDelDia = new List<eventos>();
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

                    //******************** Agregado el 07/09/2015 ****************************************************************************
                    //Si el dia es sabado o domingo recorrerlo al dia habil anterior
                    Logger.AgregarLog("         Si el dia es sabado o domingo recorrerlo al dia habil anterior...");
                    DateTime fechDeEvento = new DateTime(DateTime.Today.Year, DateTime.Today.Month, Convert.ToInt32(dia_limite));
                    if (fechDeEvento.DayOfWeek == DayOfWeek.Sunday)
                    {
                        //El evento cae en domingo
                        Logger.AgregarLog("         El evento cae en domingo, atrasar el dia limite 2 dias...");
                        dia_limite -= 2;
                    }
                    else if (fechDeEvento.DayOfWeek == DayOfWeek.Saturday)
                    {
                        //El evento cae en sabado
                        Logger.AgregarLog("         El evento cae en sabado, atrasar el dia limite 1 dia...");
                        dia_limite -= 1;
                    }
                    //******************** Fin del Agregado el 07/09/2015 ********************************************************************

                    if (dia_limite == DateTime.Today.Day)
                    {
                        Logger.AgregarLog(string.Format("         Se agrega el evento con id {0} nombre {1}...", evento.id_evento, evento.nombre));
                        lstEventosDelDia.Add(evento);
                    }
                }
            }

            Logger.AgregarLog("     Crear una lista con todos los eventos...");
            lstEventosAMostrar = new List<eventos>();
            lstEventosAMostrar.AddRange(lstEventosSemanales);
            lstEventosAMostrar.AddRange(lstEventosDelDia);

            Logger.AgregarLog("     Obtener la lista de todos los eventos terminados el dia de hoy...");
            List<eventos_realizados> lstEventosRealizados = Contexto.eventos_realizados.Where(o => o.fecha == DateTime.Today.Date).ToList();

            Logger.AgregarLog("     Quitar los eventos terminados de la lista...");
            foreach (eventos_realizados evento_realizado in lstEventosRealizados)
            {
                eventos evento_a_quitar = lstEventos.FirstOrDefault(o => o.id_evento == evento_realizado.id_evento);
                if (evento_a_quitar != null)
                {
                    lstEventosAMostrar.Remove(evento_a_quitar);
                }
            }

            if (lstEventosAMostrar.Count != 0)
            {
                Logger.AgregarLog(string.Format("     Se mostrarán {0} eventos...", lstEventos.Count));

                var animationMethod = FormAnimator.AnimationMethod.Fade;
                var animationDirection = FormAnimator.AnimationDirection.Up;
                var ToastNotification = new Notification(animationMethod, animationDirection);

                ToastNotification.lstEventosTest = lstEventosAMostrar;
                ToastNotification.Show();
            }
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
            Logger.AgregarLog("Iniciar Conteo...");
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

            if (MinutosTranscurridos >= Properties.Settings.Default.Minutos)
            {
                Logger.AgregarLog(" --- Mostrar Eventos del usuario --- ");
                    ShowNotification();
                Logger.AgregarLog(" ---       Terminar Proceso      --- ");
                Logger.AgregarLog();

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
