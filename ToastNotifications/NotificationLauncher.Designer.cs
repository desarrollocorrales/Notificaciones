namespace ToastNotifications
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
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 60000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(549, 40);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Notificaciones de existencia minima";
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
            // btnArticulos
            // 
            this.btnArticulos.Image = global::ToastNotifications.Properties.Resources.Excel;
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(192, 107);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(165, 38);
            this.btnArticulos.TabIndex = 4;
            this.btnArticulos.Text = "Configurar Artículos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = global::ToastNotifications.Properties.Resources.play_icon;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(232, 153);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(85, 38);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = global::ToastNotifications.Properties.Resources.gear_icon;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.Location = new System.Drawing.Point(164, 61);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(220, 38);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.Text = "Configurar Servidor Microsip";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // NotificationLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 252);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnConfigurar);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(565, 290);
            this.MinimumSize = new System.Drawing.Size(565, 290);
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
        private System.Windows.Forms.Button btnArticulos;
    }
}