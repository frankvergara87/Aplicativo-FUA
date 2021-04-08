namespace FissalWinForm
{
    partial class FrmEstadisticasAtendidosSis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticasAtendidosSis));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFechaProduccionHasta = new System.Windows.Forms.Button();
            this.btnLimpiarFechaProduccionDesde = new System.Windows.Forms.Button();
            this.chkOmitir = new System.Windows.Forms.CheckBox();
            this.dtpFechaProduccionHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaProduccionDesde = new System.Windows.Forms.Label();
            this.dtpFechaProduccionDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFechaProduccionDesde = new System.Windows.Forms.TextBox();
            this.lblFechaProduccionHasta = new System.Windows.Forms.Label();
            this.txtFechaProduccionHasta = new System.Windows.Forms.TextBox();
            this.cboMecanismoFinanciamiento = new System.Windows.Forms.ComboBox();
            this.lblMecanismoFinanciamiento = new System.Windows.Forms.Label();
            this.lblTipoEstadistica = new System.Windows.Forms.Label();
            this.cboTipoEstadistica = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.stsStpBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvEstadisticas);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.AllowUserToAddRows = false;
            this.dgvEstadisticas.AllowUserToDeleteRows = false;
            this.dgvEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadisticas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(16, 19);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.Size = new System.Drawing.Size(727, 369);
            this.dgvEstadisticas.TabIndex = 0;
            this.dgvEstadisticas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEstadisticas_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarFechaProduccionHasta);
            this.groupBox1.Controls.Add(this.btnLimpiarFechaProduccionDesde);
            this.groupBox1.Controls.Add(this.chkOmitir);
            this.groupBox1.Controls.Add(this.dtpFechaProduccionHasta);
            this.groupBox1.Controls.Add(this.lblFechaProduccionDesde);
            this.groupBox1.Controls.Add(this.dtpFechaProduccionDesde);
            this.groupBox1.Controls.Add(this.txtFechaProduccionDesde);
            this.groupBox1.Controls.Add(this.lblFechaProduccionHasta);
            this.groupBox1.Controls.Add(this.txtFechaProduccionHasta);
            this.groupBox1.Controls.Add(this.cboMecanismoFinanciamiento);
            this.groupBox1.Controls.Add(this.lblMecanismoFinanciamiento);
            this.groupBox1.Controls.Add(this.lblTipoEstadistica);
            this.groupBox1.Controls.Add(this.cboTipoEstadistica);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.cboRegion);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpiarFechaProduccionHasta
            // 
            this.btnLimpiarFechaProduccionHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFechaProduccionHasta.Image")));
            this.btnLimpiarFechaProduccionHasta.Location = new System.Drawing.Point(721, 46);
            this.btnLimpiarFechaProduccionHasta.Name = "btnLimpiarFechaProduccionHasta";
            this.btnLimpiarFechaProduccionHasta.Size = new System.Drawing.Size(22, 22);
            this.btnLimpiarFechaProduccionHasta.TabIndex = 177;
            this.btnLimpiarFechaProduccionHasta.UseVisualStyleBackColor = true;
            this.btnLimpiarFechaProduccionHasta.Click += new System.EventHandler(this.btnLimpiarFechaProduccionHasta_Click);
            // 
            // btnLimpiarFechaProduccionDesde
            // 
            this.btnLimpiarFechaProduccionDesde.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFechaProduccionDesde.Image")));
            this.btnLimpiarFechaProduccionDesde.Location = new System.Drawing.Point(562, 46);
            this.btnLimpiarFechaProduccionDesde.Name = "btnLimpiarFechaProduccionDesde";
            this.btnLimpiarFechaProduccionDesde.Size = new System.Drawing.Size(22, 22);
            this.btnLimpiarFechaProduccionDesde.TabIndex = 176;
            this.btnLimpiarFechaProduccionDesde.UseVisualStyleBackColor = true;
            this.btnLimpiarFechaProduccionDesde.Click += new System.EventHandler(this.btnLimpiarFechaProduccionDesde_Click);
            // 
            // chkOmitir
            // 
            this.chkOmitir.AutoSize = true;
            this.chkOmitir.Location = new System.Drawing.Point(374, 74);
            this.chkOmitir.Name = "chkOmitir";
            this.chkOmitir.Size = new System.Drawing.Size(52, 17);
            this.chkOmitir.TabIndex = 8;
            this.chkOmitir.Text = "Omitir";
            this.chkOmitir.UseVisualStyleBackColor = true;
            // 
            // dtpFechaProduccionHasta
            // 
            this.dtpFechaProduccionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaProduccionHasta.Location = new System.Drawing.Point(697, 47);
            this.dtpFechaProduccionHasta.Name = "dtpFechaProduccionHasta";
            this.dtpFechaProduccionHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaProduccionHasta.TabIndex = 6;
            this.dtpFechaProduccionHasta.ValueChanged += new System.EventHandler(this.dtpFechaProduccionHasta_ValueChanged);
            // 
            // lblFechaProduccionDesde
            // 
            this.lblFechaProduccionDesde.AutoSize = true;
            this.lblFechaProduccionDesde.Location = new System.Drawing.Point(371, 50);
            this.lblFechaProduccionDesde.Name = "lblFechaProduccionDesde";
            this.lblFechaProduccionDesde.Size = new System.Drawing.Size(95, 13);
            this.lblFechaProduccionDesde.TabIndex = 173;
            this.lblFechaProduccionDesde.Text = "Produccion Desde";
            // 
            // dtpFechaProduccionDesde
            // 
            this.dtpFechaProduccionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaProduccionDesde.Location = new System.Drawing.Point(538, 47);
            this.dtpFechaProduccionDesde.Name = "dtpFechaProduccionDesde";
            this.dtpFechaProduccionDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaProduccionDesde.TabIndex = 4;
            this.dtpFechaProduccionDesde.ValueChanged += new System.EventHandler(this.dtpFechaProduccionDesde_ValueChanged);
            // 
            // txtFechaProduccionDesde
            // 
            this.txtFechaProduccionDesde.Location = new System.Drawing.Point(469, 47);
            this.txtFechaProduccionDesde.Name = "txtFechaProduccionDesde";
            this.txtFechaProduccionDesde.Size = new System.Drawing.Size(65, 20);
            this.txtFechaProduccionDesde.TabIndex = 5;
            this.txtFechaProduccionDesde.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaProduccionDesde_Validating);
            this.txtFechaProduccionDesde.Validated += new System.EventHandler(this.txtFechaProduccionDesde_Validated);
            // 
            // lblFechaProduccionHasta
            // 
            this.lblFechaProduccionHasta.AutoSize = true;
            this.lblFechaProduccionHasta.Location = new System.Drawing.Point(588, 50);
            this.lblFechaProduccionHasta.Name = "lblFechaProduccionHasta";
            this.lblFechaProduccionHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaProduccionHasta.TabIndex = 174;
            this.lblFechaProduccionHasta.Text = "Hasta";
            // 
            // txtFechaProduccionHasta
            // 
            this.txtFechaProduccionHasta.Location = new System.Drawing.Point(628, 47);
            this.txtFechaProduccionHasta.Name = "txtFechaProduccionHasta";
            this.txtFechaProduccionHasta.Size = new System.Drawing.Size(65, 20);
            this.txtFechaProduccionHasta.TabIndex = 7;
            this.txtFechaProduccionHasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaProduccionHasta_Validating);
            this.txtFechaProduccionHasta.Validated += new System.EventHandler(this.txtFechaProduccionHasta_Validated);
            // 
            // cboMecanismoFinanciamiento
            // 
            this.cboMecanismoFinanciamiento.FormattingEnabled = true;
            this.cboMecanismoFinanciamiento.Location = new System.Drawing.Point(469, 22);
            this.cboMecanismoFinanciamiento.Name = "cboMecanismoFinanciamiento";
            this.cboMecanismoFinanciamiento.Size = new System.Drawing.Size(270, 21);
            this.cboMecanismoFinanciamiento.TabIndex = 3;
            // 
            // lblMecanismoFinanciamiento
            // 
            this.lblMecanismoFinanciamiento.AutoSize = true;
            this.lblMecanismoFinanciamiento.Location = new System.Drawing.Point(371, 25);
            this.lblMecanismoFinanciamiento.Name = "lblMecanismoFinanciamiento";
            this.lblMecanismoFinanciamiento.Size = new System.Drawing.Size(78, 13);
            this.lblMecanismoFinanciamiento.TabIndex = 167;
            this.lblMecanismoFinanciamiento.Text = "Financiamiento";
            // 
            // lblTipoEstadistica
            // 
            this.lblTipoEstadistica.AutoSize = true;
            this.lblTipoEstadistica.Location = new System.Drawing.Point(12, 25);
            this.lblTipoEstadistica.Name = "lblTipoEstadistica";
            this.lblTipoEstadistica.Size = new System.Drawing.Size(71, 13);
            this.lblTipoEstadistica.TabIndex = 166;
            this.lblTipoEstadistica.Text = "T. Estadistica";
            // 
            // cboTipoEstadistica
            // 
            this.cboTipoEstadistica.FormattingEnabled = true;
            this.cboTipoEstadistica.Location = new System.Drawing.Point(85, 22);
            this.cboTipoEstadistica.Name = "cboTipoEstadistica";
            this.cboTipoEstadistica.Size = new System.Drawing.Size(270, 21);
            this.cboTipoEstadistica.TabIndex = 0;
            this.cboTipoEstadistica.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoEstadistica_Validating);
            this.cboTipoEstadistica.Validated += new System.EventHandler(this.cboTipoEstadistica_Validated);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(85, 72);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(270, 21);
            this.cboCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(85, 47);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(270, 21);
            this.cboRegion.TabIndex = 1;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(12, 50);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 0;
            this.lblRegion.Text = "Region";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnExportarExcel,
            this.toolStripSeparator1,
            this.tsBtnLimpiar,
            this.toolStripSeparator2,
            this.tsBtnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnExportarExcel
            // 
            this.tsBtnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportarExcel.Image")));
            this.tsBtnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportarExcel.Name = "tsBtnExportarExcel";
            this.tsBtnExportarExcel.Size = new System.Drawing.Size(108, 22);
            this.tsBtnExportarExcel.Text = "Exportar a Excel";
            this.tsBtnExportarExcel.Click += new System.EventHandler(this.tsBtnExportarExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnLimpiar
            // 
            this.tsBtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLimpiar.Image")));
            this.tsBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLimpiar.Name = "tsBtnLimpiar";
            this.tsBtnLimpiar.Size = new System.Drawing.Size(67, 22);
            this.tsBtnLimpiar.Text = "Limpiar";
            this.tsBtnLimpiar.Click += new System.EventHandler(this.tsBtnLimpiar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnBuscar
            // 
            this.tsBtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscar.Image")));
            this.tsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscar.Name = "tsBtnBuscar";
            this.tsBtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsBtnBuscar.Text = "Buscar";
            this.tsBtnBuscar.Click += new System.EventHandler(this.tsBtnBuscar_Click);
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMensajePgsBarBuscador,
            this.tsPgsBarBuscador,
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 540);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(784, 22);
            this.stsStpBuscador.TabIndex = 76;
            this.stsStpBuscador.Text = "statusStrip1";
            // 
            // tsslMensajePgsBarBuscador
            // 
            this.tsslMensajePgsBarBuscador.Name = "tsslMensajePgsBarBuscador";
            this.tsslMensajePgsBarBuscador.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPgsBarBuscador
            // 
            this.tsPgsBarBuscador.Name = "tsPgsBarBuscador";
            this.tsPgsBarBuscador.Size = new System.Drawing.Size(100, 16);
            // 
            // tsslTotalRegistros
            // 
            this.tsslTotalRegistros.Name = "tsslTotalRegistros";
            this.tsslTotalRegistros.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEstadisticasAtendidosSis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEstadisticasAtendidosSis";
            this.Text = "Estadisticas de Atendidos SIS";
            this.Load += new System.EventHandler(this.FrmEstadisticasAtencionesSis_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.CheckBox chkOmitir;
        private System.Windows.Forms.DateTimePicker dtpFechaProduccionHasta;
        private System.Windows.Forms.Label lblFechaProduccionDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaProduccionDesde;
        private System.Windows.Forms.TextBox txtFechaProduccionDesde;
        private System.Windows.Forms.Label lblFechaProduccionHasta;
        private System.Windows.Forms.TextBox txtFechaProduccionHasta;
        private System.Windows.Forms.ComboBox cboMecanismoFinanciamiento;
        private System.Windows.Forms.Label lblMecanismoFinanciamiento;
        private System.Windows.Forms.Label lblTipoEstadistica;
        private System.Windows.Forms.ComboBox cboTipoEstadistica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiarFechaProduccionHasta;
        private System.Windows.Forms.Button btnLimpiarFechaProduccionDesde;
    }
}