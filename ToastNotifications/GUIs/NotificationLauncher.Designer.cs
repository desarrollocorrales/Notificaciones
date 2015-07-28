using ToastNotifications;

namespace ToastNotifications.GUIs
{
    partial class NotificationLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationLauncher));
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IconoBarra = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 60000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 66);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Notificaciones del calendario de pagos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconoBarra
            // 
            this.IconoBarra.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IconoBarra.BalloonTipText = "El sistema de norificaciones esta activo...";
            this.IconoBarra.BalloonTipTitle = "Notificaciones";
            this.IconoBarra.Icon = ((System.Drawing.Icon)(resources.GetObject("IconoBarra.Icon")));
            this.IconoBarra.Text = "Notificaciones de existencia";
            this.IconoBarra.Visible = true;
            this.IconoBarra.DoubleClick += new System.EventHandler(this.IconoBarra_DoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.Image = global::ToastNotifications.Properties.Resources.Excel;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(95, 96);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 80);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo Evento";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciar.Image = global::ToastNotifications.Properties.Resources.play_icon;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.Location = new System.Drawing.Point(207, 200);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(90, 80);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfigurar.Image = global::ToastNotifications.Properties.Resources.gear_icon;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigurar.Location = new System.Drawing.Point(95, 200);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(90, 80);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.Text = "Configurar Servidor";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = global::ToastNotifications.Properties.Resources.Excel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(207, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modificar Evento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotificationLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnConfigurar);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NotificationLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toast Notification Launcher";
            this.Load += new System.EventHandler(this.NotificationLauncher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NotifyIcon IconoBarra;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
    }
}