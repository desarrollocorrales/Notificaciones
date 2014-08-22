namespace ToastNotifications
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.gridExistencias = new DevExpress.XtraGrid.GridControl();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvExistencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArticulo_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia_Minima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExistencias)).BeginInit();
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
            this.labelTitle.Text = "Articulos con existencia debajo del minimo";
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
            // gridExistencias
            // 
            this.gridExistencias.DataSource = this.configuracionBindingSource;
            this.gridExistencias.Location = new System.Drawing.Point(12, 45);
            this.gridExistencias.MainView = this.gvExistencias;
            this.gridExistencias.Name = "gridExistencias";
            this.gridExistencias.Size = new System.Drawing.Size(726, 236);
            this.gridExistencias.TabIndex = 2;
            this.gridExistencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExistencias});
            // 
            // configuracionBindingSource
            // 
            this.configuracionBindingSource.DataSource = typeof(ToastNotifications.Modelos.Configuracion);
            // 
            // gvExistencias
            // 
            this.gvExistencias.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvExistencias.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvExistencias.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvExistencias.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvExistencias.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gvExistencias.Appearance.Empty.Options.UseBackColor = true;
            this.gvExistencias.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvExistencias.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExistencias.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvExistencias.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gvExistencias.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvExistencias.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gvExistencias.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gvExistencias.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvExistencias.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvExistencias.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvExistencias.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvExistencias.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvExistencias.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExistencias.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvExistencias.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvExistencias.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExistencias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvExistencias.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvExistencias.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvExistencias.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvExistencias.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvExistencias.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.OddRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvExistencias.Appearance.OddRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvExistencias.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvExistencias.Appearance.Preview.Options.UseFont = true;
            this.gvExistencias.Appearance.Preview.Options.UseForeColor = true;
            this.gvExistencias.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvExistencias.Appearance.Row.Options.UseBackColor = true;
            this.gvExistencias.Appearance.Row.Options.UseForeColor = true;
            this.gvExistencias.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExistencias.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvExistencias.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvExistencias.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvExistencias.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvExistencias.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvExistencias.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvExistencias.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExistencias.Appearance.VertLine.Options.UseBackColor = true;
            this.gvExistencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticulo_ID,
            this.colClave_Articulo,
            this.colNombre_Articulo,
            this.colExistencia_Minima,
            this.colExistencia});
            this.gvExistencias.GridControl = this.gridExistencias;
            this.gvExistencias.Name = "gvExistencias";
            this.gvExistencias.OptionsBehavior.Editable = false;
            this.gvExistencias.OptionsView.EnableAppearanceEvenRow = true;
            this.gvExistencias.OptionsView.EnableAppearanceOddRow = true;
            this.gvExistencias.OptionsView.ShowGroupPanel = false;
            // 
            // colArticulo_ID
            // 
            this.colArticulo_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArticulo_ID.AppearanceCell.Options.UseFont = true;
            this.colArticulo_ID.FieldName = "Articulo_ID";
            this.colArticulo_ID.Name = "colArticulo_ID";
            // 
            // colClave_Articulo
            // 
            this.colClave_Articulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colClave_Articulo.AppearanceCell.Options.UseFont = true;
            this.colClave_Articulo.AppearanceCell.Options.UseTextOptions = true;
            this.colClave_Articulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClave_Articulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClave_Articulo.AppearanceHeader.Options.UseFont = true;
            this.colClave_Articulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colClave_Articulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClave_Articulo.Caption = "Clave";
            this.colClave_Articulo.FieldName = "Clave_Articulo";
            this.colClave_Articulo.Name = "colClave_Articulo";
            this.colClave_Articulo.Visible = true;
            this.colClave_Articulo.VisibleIndex = 0;
            // 
            // colNombre_Articulo
            // 
            this.colNombre_Articulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colNombre_Articulo.AppearanceCell.Options.UseFont = true;
            this.colNombre_Articulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colNombre_Articulo.AppearanceHeader.Options.UseFont = true;
            this.colNombre_Articulo.Caption = "Artículo";
            this.colNombre_Articulo.FieldName = "Nombre_Articulo";
            this.colNombre_Articulo.Name = "colNombre_Articulo";
            this.colNombre_Articulo.Visible = true;
            this.colNombre_Articulo.VisibleIndex = 1;
            // 
            // colExistencia_Minima
            // 
            this.colExistencia_Minima.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colExistencia_Minima.AppearanceCell.Options.UseFont = true;
            this.colExistencia_Minima.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colExistencia_Minima.AppearanceHeader.Options.UseFont = true;
            this.colExistencia_Minima.AppearanceHeader.Options.UseTextOptions = true;
            this.colExistencia_Minima.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colExistencia_Minima.Caption = "Existencia minima";
            this.colExistencia_Minima.DisplayFormat.FormatString = "n";
            this.colExistencia_Minima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia_Minima.FieldName = "Existencia_Minima";
            this.colExistencia_Minima.Name = "colExistencia_Minima";
            this.colExistencia_Minima.Visible = true;
            this.colExistencia_Minima.VisibleIndex = 2;
            // 
            // colExistencia
            // 
            this.colExistencia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colExistencia.AppearanceCell.Options.UseFont = true;
            this.colExistencia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colExistencia.AppearanceHeader.Options.UseFont = true;
            this.colExistencia.AppearanceHeader.Options.UseTextOptions = true;
            this.colExistencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colExistencia.Caption = "Existencia en sistema";
            this.colExistencia.DisplayFormat.FormatString = "n";
            this.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 3;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 293);
            this.ControlBox = false;
            this.Controls.Add(this.gridExistencias);
            this.Controls.Add(this.pnlTitulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Notification";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnlTitulo;
        private DevExpress.XtraGrid.GridControl gridExistencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExistencias;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colClave_Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia_Minima;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
    }
}