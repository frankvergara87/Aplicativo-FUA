namespace FissalWinForm
{
    partial class FrmGestionEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEstadoCuenta));
            this.dgvEstadoCuenta = new System.Windows.Forms.DataGridView();
            this.EstadoCuentaConciliacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conciliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoFallecido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoFissal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnImportarPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnConsultarSis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnConsultaFissal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnObtenerEstados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCuenta)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.stsStpBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstadoCuenta
            // 
            this.dgvEstadoCuenta.AllowUserToAddRows = false;
            this.dgvEstadoCuenta.AllowUserToDeleteRows = false;
            this.dgvEstadoCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadoCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoCuentaConciliacionId,
            this.Conciliacion,
            this.EstablecimientoId,
            this.PacienteId,
            this.CadenaId,
            this.NoFallecido,
            this.ActivoSis,
            this.ActivoFissal,
            this.Estado,
            this.Seleccionar});
            this.dgvEstadoCuenta.Location = new System.Drawing.Point(20, 19);
            this.dgvEstadoCuenta.Name = "dgvEstadoCuenta";
            this.dgvEstadoCuenta.ReadOnly = true;
            this.dgvEstadoCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoCuenta.Size = new System.Drawing.Size(725, 470);
            this.dgvEstadoCuenta.TabIndex = 0;
            this.dgvEstadoCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadoCuenta_CellDoubleClick);
            this.dgvEstadoCuenta.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstadoCuenta_CurrentCellDirtyStateChanged);
            this.dgvEstadoCuenta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEstadoCuenta_DataBindingComplete);
            // 
            // EstadoCuentaConciliacionId
            // 
            this.EstadoCuentaConciliacionId.DataPropertyName = "EstadoCuentaConciliacionId";
            this.EstadoCuentaConciliacionId.HeaderText = "EstadoCuentaConciliacionId";
            this.EstadoCuentaConciliacionId.Name = "EstadoCuentaConciliacionId";
            this.EstadoCuentaConciliacionId.ReadOnly = true;
            this.EstadoCuentaConciliacionId.Visible = false;
            // 
            // Conciliacion
            // 
            this.Conciliacion.DataPropertyName = "Conciliacion";
            this.Conciliacion.HeaderText = "Conciliacion";
            this.Conciliacion.Name = "Conciliacion";
            this.Conciliacion.ReadOnly = true;
            this.Conciliacion.Width = 70;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "EstablecimientoId";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            // 
            // PacienteId
            // 
            this.PacienteId.DataPropertyName = "PacienteId";
            this.PacienteId.HeaderText = "PacienteId";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.ReadOnly = true;
            this.PacienteId.Width = 65;
            // 
            // CadenaId
            // 
            this.CadenaId.DataPropertyName = "CadenaId";
            this.CadenaId.HeaderText = "CadenaId";
            this.CadenaId.Name = "CadenaId";
            this.CadenaId.ReadOnly = true;
            this.CadenaId.Width = 60;
            // 
            // NoFallecido
            // 
            this.NoFallecido.DataPropertyName = "NoFallecido";
            this.NoFallecido.HeaderText = "Vivo";
            this.NoFallecido.Name = "NoFallecido";
            this.NoFallecido.ReadOnly = true;
            this.NoFallecido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoFallecido.Width = 70;
            // 
            // ActivoSis
            // 
            this.ActivoSis.DataPropertyName = "ActivoSis";
            this.ActivoSis.HeaderText = "ActivoSIS";
            this.ActivoSis.Name = "ActivoSis";
            this.ActivoSis.ReadOnly = true;
            this.ActivoSis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivoSis.Width = 60;
            // 
            // ActivoFissal
            // 
            this.ActivoFissal.DataPropertyName = "ActivoFissal";
            this.ActivoFissal.HeaderText = "ActivoFISSAL";
            this.ActivoFissal.Name = "ActivoFissal";
            this.ActivoFissal.ReadOnly = true;
            this.ActivoFissal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivoFissal.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.Width = 70;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnExportarPacientes,
            this.toolStripSeparator2,
            this.tsBtnImportarPacientes,
            this.toolStripSeparator3,
            this.tsBtnConsultarSis,
            this.toolStripSeparator4,
            this.tsBtnConsultaFissal,
            this.toolStripSeparator5,
            this.tsBtnObtenerEstados,
            this.toolStripSeparator6,
            this.tsBtnAnular,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnExportarPacientes
            // 
            this.tsBtnExportarPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnExportarPacientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnExportarPacientes.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportarPacientes.Image")));
            this.tsBtnExportarPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportarPacientes.Name = "tsBtnExportarPacientes";
            this.tsBtnExportarPacientes.Size = new System.Drawing.Size(107, 22);
            this.tsBtnExportarPacientes.Text = "Exportar Pacientes";
            this.tsBtnExportarPacientes.Visible = false;
            this.tsBtnExportarPacientes.Click += new System.EventHandler(this.tsBtnExportarPacientes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsBtnImportarPacientes
            // 
            this.tsBtnImportarPacientes.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnImportarPacientes.Image")));
            this.tsBtnImportarPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImportarPacientes.Name = "tsBtnImportarPacientes";
            this.tsBtnImportarPacientes.Size = new System.Drawing.Size(112, 22);
            this.tsBtnImportarPacientes.Text = "Verificar RENIEC";
            this.tsBtnImportarPacientes.Click += new System.EventHandler(this.tsBtnImportarPacientes_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnConsultarSis
            // 
            this.tsBtnConsultarSis.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsultarSis.Image")));
            this.tsBtnConsultarSis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsultarSis.Name = "tsBtnConsultarSis";
            this.tsBtnConsultarSis.Size = new System.Drawing.Size(92, 22);
            this.tsBtnConsultarSis.Text = "Consulta SIS";
            this.tsBtnConsultarSis.Click += new System.EventHandler(this.tsBtnConsultarSis_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnConsultaFissal
            // 
            this.tsBtnConsultaFissal.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsultaFissal.Image")));
            this.tsBtnConsultaFissal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsultaFissal.Name = "tsBtnConsultaFissal";
            this.tsBtnConsultaFissal.Size = new System.Drawing.Size(112, 22);
            this.tsBtnConsultaFissal.Text = "Consulta FISSAL";
            this.tsBtnConsultaFissal.Click += new System.EventHandler(this.tsBtnConsultaFissal_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnObtenerEstados
            // 
            this.tsBtnObtenerEstados.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnObtenerEstados.Image")));
            this.tsBtnObtenerEstados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnObtenerEstados.Name = "tsBtnObtenerEstados";
            this.tsBtnObtenerEstados.Size = new System.Drawing.Size(113, 22);
            this.tsBtnObtenerEstados.Text = "Obtener Estados";
            this.tsBtnObtenerEstados.Click += new System.EventHandler(this.tsBtnObtenerEstados_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnAnular
            // 
            this.tsBtnAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAnular.Image")));
            this.tsBtnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAnular.Name = "tsBtnAnular";
            this.tsBtnAnular.Size = new System.Drawing.Size(103, 22);
            this.tsBtnAnular.Text = "Anular Cuenta";
            this.tsBtnAnular.Click += new System.EventHandler(this.tsBtnAnular_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvEstadoCuenta);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 509);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas";
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
            this.stsStpBuscador.TabIndex = 71;
            this.stsStpBuscador.Text = "statusStrip1";
            // 
            // FrmGestionEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionEstadoCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Estados de Cuentas";
            this.Load += new System.EventHandler(this.FrmGestionEstadoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCuenta)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadoCuenta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarPacientes;
        private System.Windows.Forms.ToolStripButton tsBtnImportarPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnAnular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton tsBtnConsultarSis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnConsultaFissal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsBtnObtenerEstados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCuentaConciliacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conciliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CadenaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFallecido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoFissal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}