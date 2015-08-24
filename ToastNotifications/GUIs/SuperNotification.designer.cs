namespace ToastNotifications.GUIs
{
    partial class SuperNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperNotification));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridEventos = new DevExpress.XtraGrid.GridControl();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEventos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCuentaBancaria = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(750, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "  Recordatorio de eventos";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitulo.Controls.Add(this.labelTitle);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(750, 38);
            this.pnlTitulo.TabIndex = 1;
            // 
            // gridEventos
            // 
            this.gridEventos.DataSource = this.eventosBindingSource;
            this.gridEventos.Location = new System.Drawing.Point(12, 45);
            this.gridEventos.MainView = this.gvEventos;
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.Size = new System.Drawing.Size(365, 363);
            this.gridEventos.TabIndex = 2;
            this.gridEventos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEventos});
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataSource = typeof(ToastNotifications.Entity.eventos);
            // 
            // gvEventos
            // 
            this.gvEventos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEventos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEventos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEventos.Appearance.Row.Options.UseFont = true;
            this.gvEventos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colcantidad});
            this.gvEventos.GridControl = this.gridEventos;
            this.gvEventos.Name = "gvEventos";
            this.gvEventos.OptionsBehavior.Editable = false;
            this.gvEventos.OptionsView.ShowGroupPanel = false;
            this.gvEventos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvEventos_FocusedRowChanged);
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colcantidad
            // 
            this.colcantidad.DisplayFormat.FormatString = "C";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            // 
            // lblDescripción
            // 
            this.lblDescripción.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripción.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.ForeColor = System.Drawing.Color.White;
            this.lblDescripción.Location = new System.Drawing.Point(6, 19);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(343, 91);
            this.lblDescripción.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescripción);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(383, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBanco);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(383, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 45);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banco:";
            // 
            // lblBanco
            // 
            this.lblBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanco.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.White;
            this.lblBanco.Location = new System.Drawing.Point(6, 19);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(343, 23);
            this.lblBanco.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCuentaBancaria);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(383, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 45);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta Bancaria:";
            // 
            // lblCuentaBancaria
            // 
            this.lblCuentaBancaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuentaBancaria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaBancaria.ForeColor = System.Drawing.Color.White;
            this.lblCuentaBancaria.Location = new System.Drawing.Point(6, 19);
            this.lblCuentaBancaria.Name = "lblCuentaBancaria";
            this.lblCuentaBancaria.Size = new System.Drawing.Size(343, 23);
            this.lblCuentaBancaria.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNotas);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(383, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 106);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notas:";
            // 
            // lblNotas
            // 
            this.lblNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.ForeColor = System.Drawing.Color.White;
            this.lblNotas.Location = new System.Drawing.Point(6, 19);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(343, 81);
            this.lblNotas.TabIndex = 3;
            // 
            // SuperNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridEventos);
            this.Controls.Add(this.pnlTitulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SuperNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EDGE Shop Flag Notification";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private DevExpress.XtraGrid.GridControl gridEventos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEventos;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCuentaBancaria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
    }
}