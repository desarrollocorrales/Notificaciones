using System;
using System.Configuration;

namespace ToastNotifications.Modelos
{
    public static class ValoresGlobales
    {
        public static int MinutosCiclo = Convert.ToInt32(ConfigurationManager.AppSettings["MinutosCiclo"]);
    }
}
