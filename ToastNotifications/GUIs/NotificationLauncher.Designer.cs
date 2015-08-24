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
            this.IconoBarra = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbDataBase = new System.Windows.Forms.ComboBox();
            this.cbUsuarioSistema = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 60000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(155, 48);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(303, 23);
            this.txbServidor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(155, 77);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(303, 23);
            this.txbUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(155, 106);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(303, 23);
            this.txbContraseña.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puerto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Base de Datos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Recordar cada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "minutos.";
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(155, 135);
            this.nudPuerto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(71, 23);
            this.nudPuerto.TabIndex = 8;
            this.nudPuerto.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(155, 224);
            this.nudMinutos.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(51, 23);
            this.nudMinutos.TabIndex = 15;
            this.nudMinutos.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(201, 266);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbDataBase
            // 
            this.cbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBase.FormattingEnabled = true;
            this.cbDataBase.Location = new System.Drawing.Point(155, 164);
            this.cbDataBase.Name = "cbDataBase";
            this.cbDataBase.Size = new System.Drawing.Size(304, 24);
            this.cbDataBase.TabIndex = 10;
            this.cbDataBase.Click += new System.EventHandler(this.cbDataBase_Click);
            // 
            // cbUsuarioSistema
            // 
            this.cbUsuarioSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioSistema.FormattingEnabled = true;
            this.cbUsuarioSistema.Location = new System.Drawing.Point(154, 194);
            this.cbUsuarioSistema.Name = "cbUsuarioSistema";
            this.cbUsuarioSistema.Size = new System.Drawing.Size(228, 24);
            this.cbUsuarioSistema.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Usuario sistema:";
            // 
            // btnCargarUsuarios
            // 
            this.btnCargarUsuarios.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarUsuarios.Location = new System.Drawing.Point(388, 194);
            this.btnCargarUsuarios.Name = "btnCargarUsuarios";
            this.btnCargarUsuarios.Size = new System.Drawing.Size(70, 24);
            this.btnCargarUsuarios.TabIndex = 13;
            this.btnCargarUsuarios.Text = "Cargar";
            this.btnCargarUsuarios.UseVisualStyleBackColor = true;
            this.btnCargarUsuarios.Click += new System.EventHandler(this.btnCargarUsuarios_Click);
            // 
            // NotificationLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 308);
            this.Controls.Add(this.btnCargarUsuarios);
            this.Controls.Add(this.cbUsuarioSistema);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDataBase);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.nudPuerto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NotificationLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recordatorio de Eventos";
            this.Load += new System.EventHandler(this.NotificationLauncher_Load);
            this.Shown += new System.EventHandler(this.NotificationLauncher_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.NotifyIcon IconoBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbDataBase;
        private System.Windows.Forms.ComboBox cbUsuarioSistema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargarUsuarios;
    }
}