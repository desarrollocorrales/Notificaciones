using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToastNotifications.Entity;

namespace ToastNotifications.Modelos
{
    public class Recordatorio
    {
        public eventos evento { set; get; }
        public bool entregado { set; get; }
    }
}
