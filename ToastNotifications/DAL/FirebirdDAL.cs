using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using ToastNotifications.Modelos;

namespace ToastNotifications.DAL
{
    public class FirebirdDAL
    {
        private FbConnection fbconn;
        private FbCommand fbcomm;
        private FbDataAdapter fbadapter;

        public FirebirdDAL()
        {
            fbconn = new FbConnection();
            fbcomm = new FbCommand();
            fbadapter = new FbDataAdapter();

            fbconn.ConnectionString = getConectionString();
        }

        private string getConectionString()
        {
            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();

            fbcsb.DataSource = Properties.Settings.Default.Servidor;
            fbcsb.Database = Properties.Settings.Default.BaseDeDatos;
            fbcsb.UserID = Properties.Settings.Default.Usuario;
            fbcsb.Password = Properties.Settings.Default.Password;
            fbcsb.Port = Properties.Settings.Default.Puerto;

            return fbcsb.ToString();
        }

        public decimal ObtenerExistencia(Configuracion Articulo)
        {
            int AlmacenID = Properties.Settings.Default.IdentificadorAlmacen;
            string Fecha = DateTime.Today.AddDays(1).Date.ToString("yyyy-MM-dd");
            string Consulta =
                string.Format(@"SELECT 
                                   EXIVAL_ART.EXISTENCIA 
                                FROM 
                                   EXIVAL_ART({0}, {1}, '{2}', 'S')", 
                                Articulo.Articulo_ID, AlmacenID, Fecha);
            fbconn.Open();
            fbcomm.Connection = fbconn;
            fbcomm.CommandText = Consulta;
            object oExistencia = fbcomm.ExecuteScalar();
            decimal dExistencia = Convert.ToInt32(oExistencia);
            fbconn.Close();
            return dExistencia;
        }
    }
}
