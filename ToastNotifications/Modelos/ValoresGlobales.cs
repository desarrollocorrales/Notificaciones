using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ToastNotifications.Modelos
{
    public static class ValoresGlobales
    {
        public static int MinutosCiclo = Convert.ToInt32(ConfigurationManager.AppSettings["MinutosCiclo"]);
    }
}
