using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using ToastNotifications.Entity;

namespace ToastNotifications.Modelos
{
    public static class EnviaCorreos
    {
        private static MailMessage oCorreo;
        private struct CorreoConfig
        {
            public int iPort;
            public string sHost;
            public string sUser;
            public string sPass;
        }
        public static void Enviar(eventos evento, usuarios usuario)
        {
            try
            {
                oCorreo = new MailMessage();
                oCorreo.From = new MailAddress("automata@loscorrales.com.mx", "Automata los corrales");
                leerDestinatarios();
                oCorreo.Subject = string.Format("Notificación de termino de evento");

                System.Text.StringBuilder sbMensaje = new System.Text.StringBuilder();
                sbMensaje.AppendLine("Notificaciones de eventos.");
                sbMensaje.AppendLine();
                sbMensaje.AppendLine("El siguiente evento ha sido marcado como terminado:");
                sbMensaje.AppendLine();
                sbMensaje.AppendLine(string.Format("Nombre del evento: {0}", evento.nombre));
                sbMensaje.AppendLine(string.Format("Descripcion: {0}", evento.descripcion));
                sbMensaje.AppendLine(string.Format("Cantidad: {0}", evento.cantidad));
                sbMensaje.AppendLine(string.Format("Banco: {0}", evento.banco));
                sbMensaje.AppendLine(string.Format("Cuenta Bancaria: {0}", evento.cuenta_bancaria));
                sbMensaje.AppendLine(string.Format("Notas: {0}", evento.notas));
                sbMensaje.AppendLine(string.Format("Usuario: {0}", usuario.nombre));
                oCorreo.Body = string.Format(sbMensaje.ToString(), evento.nombre, usuario.nombre);
                oCorreo.IsBodyHtml = false;

                CorreoConfig cConfig = ObtenerConfiguracionDelCorreo();

                SmtpClient SmtpMail = new SmtpClient();
                SmtpMail.Host = cConfig.sHost;
                SmtpMail.Port = cConfig.iPort;
                SmtpMail.Credentials = new NetworkCredential(cConfig.sUser, cConfig.sPass);
                SmtpMail.EnableSsl = false;
                SmtpMail.Send(oCorreo);
            }
            catch (Exception ex)
            {
                Logger.AgregarLog("No se pudo enviar el correo");
                Logger.AgregarLog(ex.Message);
            }
        }

        private static void leerDestinatarios()
        {
            StreamReader objReader = new StreamReader("destinatarios.txt");
            string sLine = string.Empty;
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    oCorreo.To.Add(sLine);
            }
            objReader.Close();
        }

        private static CorreoConfig ObtenerConfiguracionDelCorreo()
        {
            CorreoConfig config = new CorreoConfig();

            StreamReader objReader = new StreamReader("correoconfig.txt");
            string sLine = string.Empty;
            
            //Leer Puerto
            sLine = objReader.ReadLine();
            sLine = sLine.Split('=')[1];
            config.iPort = Convert.ToInt32(sLine);

            //Leer Host Correo
            sLine = objReader.ReadLine();
            sLine = sLine.Split('=')[1];
            config.sHost = sLine;

            //Leer Direccion Correo
            sLine = objReader.ReadLine();
            sLine = sLine.Split('=')[1];
            config.sUser = sLine;

            //Leer Contraseña Correo
            sLine = objReader.ReadLine();
            sLine = sLine.Split('=')[1];
            config.sPass = sLine;

            objReader.Close();

            return config;
        }
    }
}
