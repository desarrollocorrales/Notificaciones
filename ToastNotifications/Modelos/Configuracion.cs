using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToastNotifications.Modelos
{
    public class Configuracion
    {
        public int Articulo_ID { set; get; }
        public string Clave_Articulo { set; get; }
        public string Nombre_Articulo { set; get; }
        public decimal Existencia_Minima { set; get; }
        public decimal Existencia { set; get; }
    }
}
