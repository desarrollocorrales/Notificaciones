namespace ToastNotifications.GUIs
{
    partial class Frm_Eventos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDiaSemana = new System.Windows.Forms.ComboBox();
            this.rbPorDia = new System.Windows.Forms.RadioButton();
            this.rbPorSemana = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudDiaEvento = new System.Windows.Forms.NumericUpDown();
            this.nudDiasRecordatorio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNones = new System.Windows.Forms.RadioButton();
            this.rbPares = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCuantaBancaria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasRecordatorio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(792, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Evento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del evento:";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.Location = new System.Drawing.Point(12, 64);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(364, 26);
            this.txbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.Location = new System.Drawing.Point(12, 114);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(364, 76);
            this.txbDescripcion.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDiaSemana);
            this.groupBox1.Controls.Add(this.rbPorDia);
            this.groupBox1.Controls.Add(this.rbPorSemana);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repetir";
            // 
            // cbDiaSemana
            // 
            this.cbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaSemana.Enabled = false;
            this.cbDiaSemana.FormattingEnabled = true;
            this.cbDiaSemana.ItemHeight = 18;
            this.cbDiaSemana.Items.AddRange(new object[] {
            "- Seleccione un día -",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbDiaSemana.Location = new System.Drawing.Point(175, 143);
            this.cbDiaSemana.Name = "cbDiaSemana";
            this.cbDiaSemana.Size = new System.Drawing.Size(251, 26);
            this.cbDiaSemana.TabIndex = 21;
            // 
            // rbPorDia
            // 
            this.rbPorDia.AutoSize = true;
            this.rbPorDia.Checked = true;
            this.rbPorDia.Location = new System.Drawing.Point(6, 25);
            this.rbPorDia.Name = "rbPorDia";
            this.rbPorDia.Size = new System.Drawing.Size(126, 22);
            this.rbPorDia.TabIndex = 16;
            this.rbPorDia.TabStop = true;
            this.rbPorDia.Text = "Por dia del mes";
            this.rbPorDia.UseVisualStyleBackColor = true;
            this.rbPorDia.CheckedChanged += new System.EventHandler(this.rbPorDia_CheckedChanged);
            // 
            // rbPorSemana
            // 
            this.rbPorSemana.AutoSize = true;
            this.rbPorSemana.Location = new System.Drawing.Point(6, 144);
            this.rbPorSemana.Name = "rbPorSemana";
            this.rbPorSemana.Size = new System.Drawing.Size(163, 22);
            this.rbPorSemana.TabIndex = 20;
            this.rbPorSemana.Text = "Por dia de la semana";
            this.rbPorSemana.UseVisualStyleBackColor = true;
            this.rbPorSemana.CheckedChanged += new System.EventHandler(this.rbPorSemana_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.nudDiaEvento);
            this.panel1.Controls.Add(this.nudDiasRecordatorio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 79);
            this.panel1.TabIndex = 17;
            // 
            // nudDiaEvento
            // 
            this.nudDiaEvento.Location = new System.Drawing.Point(115, 13);
            this.nudDiaEvento.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDiaEvento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiaEvento.Name = "nudDiaEvento";
            this.nudDiaEvento.Size = new System.Drawing.Size(50, 26);
            this.nudDiaEvento.TabIndex = 18;
            this.nudDiaEvento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiasRecordatorio
            // 
            this.nudDiasRecordatorio.Location = new System.Drawing.Point(115, 45);
            this.nudDiasRecordatorio.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDiasRecordatorio.Name = "nudDiasRecordatorio";
            this.nudDiasRecordatorio.Size = new System.Drawing.Size(50, 26);
            this.nudDiasRecordatorio.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dia del evento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "dias antes del evento. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notificar con ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNones);
            this.groupBox2.Controls.Add(this.rbPares);
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de repetición";
            // 
            // rbNones
            // 
            this.rbNones.AutoSize = true;
            this.rbNones.Location = new System.Drawing.Point(463, 25);
            this.rbNones.Name = "rbNones";
            this.rbNones.Size = new System.Drawing.Size(144, 22);
            this.rbNones.TabIndex = 14;
            this.rbNones.Text = "Solo meses nones";
            this.rbNones.UseVisualStyleBackColor = true;
            // 
            // rbPares
            // 
            this.rbPares.AutoSize = true;
            this.rbPares.Location = new System.Drawing.Point(308, 25);
            this.rbPares.Name = "rbPares";
            this.rbPares.Size = new System.Drawing.Size(141, 22);
            this.rbPares.TabIndex = 13;
            this.rbPares.Text = "Solo meses pares";
            this.rbPares.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(157, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(137, 22);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los meses";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad a pagar:";
            // 
            // txbBanco
            // 
            this.txbBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBanco.Location = new System.Drawing.Point(420, 114);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(360, 26);
            this.txbBanco.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Banco (Opcional):";
            // 
            // txbCuantaBancaria
            // 
            this.txbCuantaBancaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuantaBancaria.Location = new System.Drawing.Point(420, 164);
            this.txbCuantaBancaria.Name = "txbCuantaBancaria";
            this.txbCuantaBancaria.Size = new System.Drawing.Size(360, 26);
            this.txbCuantaBancaria.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cuenta Bancaria (Opcional):";
            // 
            // txbNotas
            // 
            this.txbNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNotas.Location = new System.Drawing.Point(12, 481);
            this.txbNotas.Multiline = true;
            this.txbNotas.Name = "txbNotas";
            this.txbNotas.Size = new System.Drawing.Size(768, 76);
            this.txbNotas.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Notas (Opcional):";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(359, 563);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCantidad.Location = new System.Drawing.Point(420, 64);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(187, 26);
            this.txbCantidad.TabIndex = 31;
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbNotas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCuantaBancaria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbBanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 630);
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "Frm_Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agregar Evento";
            this.Load += new System.EventHandler(this.Frm_Eventos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasRecordatorio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDiaEvento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDiaSemana;
        private System.Windows.Forms.RadioButton rbPorDia;
        private System.Windows.Forms.RadioButton rbPorSemana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudDiasRecordatorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNones;
        private System.Windows.Forms.RadioButton rbPares;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCuantaBancaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbCantidad;
    }
}