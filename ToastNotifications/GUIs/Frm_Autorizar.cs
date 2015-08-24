using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToastNotifications.Entity;

namespace ToastNotifications.GUIs
{
    public partial class Frm_Autorizar : Form
    {
        usuarios admin;
        NotificationLauncher FrmPrincipal;
        public Frm_Autorizar(NotificationLauncher Principal)
        {
            InitializeComponent();
            this.FrmPrincipal = Principal;
        }

        private void Frm_Autorizar_Load(object sender, EventArgs e)
        {
            ProbarConexion();
        }
        private void ProbarConexion()
        {
            try
            {
                string StringConnection =
                string.Format(Modelos.Configuraciones.SC_ServUserPassPortDatabase,
                                                            Properties.Settings.Default.Servidor,
                                                            Properties.Settings.Default.Usuario,
                                                            Properties.Settings.Default.Password,
                                                            Properties.Settings.Default.Puerto,
                                                            Properties.Settings.Default.BaseDeDatos);

                EventosEntities Contexto = new EventosEntities(StringConnection);
                admin= Contexto.usuarios.FirstOrDefault(o => o.nombre.ToUpper() == "ADMIN");
            }
            catch(Exception)
            {
                FrmPrincipal.Show();
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text.ToUpper();
            string contraseña = txbContraseña.Text.ToUpper();

            if (admin.nombre.ToUpper() == usuario && admin.contraseña.ToUpper() == contraseña)
            {
                txbContraseña.Text = string.Empty;
                txbUsuario.Text = string.Empty;
                FrmPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error de nombre de usuario o contraseña...");
            }
        }

    }
}
