using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToastNotifications.Modelos
{
    public static class Configuraciones
    {
        public static string SC_ServUserPassPortDatabase = 
        "metadata=res://*/Entity.EventosModel.csdl|"+
                 "res://*/Entity.EventosModel.ssdl|"+
                 "res://*/Entity.EventosModel.msl;"+
        "provider=MySql.Data.MySqlClient;" +
        "provider connection string='server={0};user id={1};password={2};port={3};database={4}'";
    }
}
