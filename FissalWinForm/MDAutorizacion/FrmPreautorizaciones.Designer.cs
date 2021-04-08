namespace FissalWinForm
{
    partial class FrmPreautorizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreautorizaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnConsultarSis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnConsultaReniec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnObtenerModalidad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPreAutorizaciones = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.AutorizacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TratamiendoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientenombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionlarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_SolicitudDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvaluacionSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteActivoSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteActivoSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteTipoRegimenSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteTipoRegimenSis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvaluacionReniec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteVivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteVivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvaluacionFissal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteSinAutorizacionPrevia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteSinAutorizacionPrevia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteTodosRetrospectivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteTodosRetrospectivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteTodosDiferenteFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPacienteTodosDiferenteFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreAutorizaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.stsStpBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnConsultarSis,
            this.toolStripSeparator3,
            this.tsBtnConsultaReniec,
            this.toolStripSeparator4,
            this.tsBtnObtenerModalidad,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnConsultaReniec
            // 
            this.tsBtnConsultaReniec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsultaReniec.Image")));
            this.tsBtnConsultaReniec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsultaReniec.Name = "tsBtnConsultaReniec";
            this.tsBtnConsultaReniec.Size = new System.Drawing.Size(112, 22);
            this.tsBtnConsultaReniec.Text = "Verificar RENIEC";
            this.tsBtnConsultaReniec.Click += new System.EventHandler(this.tsBtnConsultaReniec_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnObtenerModalidad
            // 
            this.tsBtnObtenerModalidad.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnObtenerModalidad.Image")));
            this.tsBtnObtenerModalidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnObtenerModalidad.Name = "tsBtnObtenerModalidad";
            this.tsBtnObtenerModalidad.Size = new System.Drawing.Size(75, 22);
            this.tsBtnObtenerModalidad.Text = "Autorizar";
            this.tsBtnObtenerModalidad.Click += new System.EventHandler(this.tsBtnObtenerModalidad_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPreAutorizaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 619);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre Autorizaciones";
            // 
            // dgvPreAutorizaciones
            // 
            this.dgvPreAutorizaciones.AllowUserToAddRows = false;
            this.dgvPreAutorizaciones.AllowUserToDeleteRows = false;
            this.dgvPreAutorizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreAutorizaciones.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPreAutorizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreAutorizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorizacionId,
            this.PacienteId,
            this.TratamiendoId,
            this.Version,
            this.CategoriaId,
            this.FaseId,
            this.EstablecimientoId,
            this.Descripcion,
            this.DescripcionTipoDocumento,
            this.NumeroDocumento,
            this.pacientenombre,
            this.descripcionlarga,
            this.FechaInicio,
            this.Vigencia,
            this.FechaSolicitud,
            this.Nro_SolicitudDetalle,
            this.DetalleId,
            this.FechaEvaluacionSis,
            this.PacienteActivoSis,
            this.DescripcionPacienteActivoSis,
            this.PacienteTipoRegimenSis,
            this.DescripcionPacienteTipoRegimenSis,
            this.FechaEvaluacionReniec,
            this.PacienteVivo,
            this.DescripcionPacienteVivo,
            this.FechaEvaluacionFissal,
            this.PacienteSinAutorizacionPrevia,
            this.DescripcionPacienteSinAutorizacionPrevia,
            this.PacienteTodosRetrospectivos,
            this.DescripcionPacienteTodosRetrospectivos,
            this.PacienteTodosDiferenteFase,
            this.DescripcionPacienteTodosDiferenteFase,
            this.Modalidad});
            this.dgvPreAutorizaciones.Location = new System.Drawing.Point(22, 19);
            this.dgvPreAutorizaciones.Name = "dgvPreAutorizaciones";
            this.dgvPreAutorizaciones.ReadOnly = true;
            this.dgvPreAutorizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreAutorizaciones.Size = new System.Drawing.Size(940, 583);
            this.dgvPreAutorizaciones.TabIndex = 1;
            this.dgvPreAutorizaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreAutorizaciones_CellDoubleClick);
            this.dgvPreAutorizaciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPreAutorizaciones_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboEstablecimiento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(114, 23);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(440, 21);
            this.cboEstablecimiento.TabIndex = 0;
            this.cboEstablecimiento.SelectionChangeCommitted += new System.EventHandler(this.cboEstablecimiento_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Establecimiento";
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMensajePgsBarBuscador,
            this.tsPgsBarBuscador,
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 708);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(1008, 22);
            this.stsStpBuscador.TabIndex = 72;
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
            // AutorizacionId
            // 
            this.AutorizacionId.DataPropertyName = "AutorizacionId";
            this.AutorizacionId.HeaderText = "AutorizacionId";
            this.AutorizacionId.Name = "AutorizacionId";
            this.AutorizacionId.ReadOnly = true;
            this.AutorizacionId.Visible = false;
            // 
            // PacienteId
            // 
            this.PacienteId.DataPropertyName = "PacienteId";
            this.PacienteId.HeaderText = "PacienteId";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.ReadOnly = true;
            this.PacienteId.Visible = false;
            // 
            // TratamiendoId
            // 
            this.TratamiendoId.DataPropertyName = "TratamiendoId";
            this.TratamiendoId.HeaderText = "TratamientoId";
            this.TratamiendoId.Name = "TratamiendoId";
            this.TratamiendoId.ReadOnly = true;
            this.TratamiendoId.Visible = false;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Visible = false;
            // 
            // CategoriaId
            // 
            this.CategoriaId.DataPropertyName = "CategoriaId";
            this.CategoriaId.HeaderText = "CategoriaId";
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.ReadOnly = true;
            this.CategoriaId.Visible = false;
            // 
            // FaseId
            // 
            this.FaseId.DataPropertyName = "FaseId";
            this.FaseId.HeaderText = "FaseId";
            this.FaseId.Name = "FaseId";
            this.FaseId.ReadOnly = true;
            this.FaseId.Visible = false;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "Renaes";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            this.EstablecimientoId.Width = 45;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "IPRESS";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 240;
            // 
            // DescripcionTipoDocumento
            // 
            this.DescripcionTipoDocumento.DataPropertyName = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.HeaderText = "TDoc";
            this.DescripcionTipoDocumento.Name = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.ReadOnly = true;
            this.DescripcionTipoDocumento.Width = 35;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Doc";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 60;
            // 
            // pacientenombre
            // 
            this.pacientenombre.DataPropertyName = "pacientenombre";
            this.pacientenombre.HeaderText = "Paciente";
            this.pacientenombre.Name = "pacientenombre";
            this.pacientenombre.ReadOnly = true;
            this.pacientenombre.Width = 200;
            // 
            // descripcionlarga
            // 
            this.descripcionlarga.DataPropertyName = "descripcionlarga";
            this.descripcionlarga.HeaderText = "Descripcion";
            this.descripcionlarga.Name = "descripcionlarga";
            this.descripcionlarga.ReadOnly = true;
            this.descripcionlarga.Width = 360;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaInicio.HeaderText = "Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 70;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "Vigencia";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Vigencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            this.Vigencia.Width = 70;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.DataPropertyName = "FechaSolicitud";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaSolicitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaSolicitud.HeaderText = "FechaSolicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.ReadOnly = true;
            this.FechaSolicitud.Width = 80;
            // 
            // Nro_SolicitudDetalle
            // 
            this.Nro_SolicitudDetalle.DataPropertyName = "Nro_SolicitudDetalle";
            this.Nro_SolicitudDetalle.HeaderText = "Solicitud";
            this.Nro_SolicitudDetalle.Name = "Nro_SolicitudDetalle";
            this.Nro_SolicitudDetalle.ReadOnly = true;
            this.Nro_SolicitudDetalle.Width = 50;
            // 
            // DetalleId
            // 
            this.DetalleId.DataPropertyName = "DetalleId";
            this.DetalleId.HeaderText = "DetalleIdSolicitud";
            this.DetalleId.Name = "DetalleId";
            this.DetalleId.ReadOnly = true;
            this.DetalleId.Visible = false;
            // 
            // FechaEvaluacionSis
            // 
            this.FechaEvaluacionSis.DataPropertyName = "FechaEvaluacionSis";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaEvaluacionSis.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaEvaluacionSis.HeaderText = "FechaSis";
            this.FechaEvaluacionSis.Name = "FechaEvaluacionSis";
            this.FechaEvaluacionSis.ReadOnly = true;
            this.FechaEvaluacionSis.Width = 70;
            // 
            // PacienteActivoSis
            // 
            this.PacienteActivoSis.DataPropertyName = "PacienteActivoSis";
            this.PacienteActivoSis.HeaderText = "IdActivoSIS";
            this.PacienteActivoSis.Name = "PacienteActivoSis";
            this.PacienteActivoSis.ReadOnly = true;
            this.PacienteActivoSis.Visible = false;
            this.PacienteActivoSis.Width = 55;
            // 
            // DescripcionPacienteActivoSis
            // 
            this.DescripcionPacienteActivoSis.DataPropertyName = "DescripcionPacienteActivoSis";
            this.DescripcionPacienteActivoSis.HeaderText = "ActivoSis";
            this.DescripcionPacienteActivoSis.Name = "DescripcionPacienteActivoSis";
            this.DescripcionPacienteActivoSis.ReadOnly = true;
            this.DescripcionPacienteActivoSis.Width = 60;
            // 
            // PacienteTipoRegimenSis
            // 
            this.PacienteTipoRegimenSis.DataPropertyName = "PacienteTipoRegimenSis";
            this.PacienteTipoRegimenSis.HeaderText = "IdRegimenSIS";
            this.PacienteTipoRegimenSis.Name = "PacienteTipoRegimenSis";
            this.PacienteTipoRegimenSis.ReadOnly = true;
            this.PacienteTipoRegimenSis.Visible = false;
            this.PacienteTipoRegimenSis.Width = 70;
            // 
            // DescripcionPacienteTipoRegimenSis
            // 
            this.DescripcionPacienteTipoRegimenSis.DataPropertyName = "DescripcionPacienteTipoRegimenSis";
            this.DescripcionPacienteTipoRegimenSis.HeaderText = "RegimenSis";
            this.DescripcionPacienteTipoRegimenSis.Name = "DescripcionPacienteTipoRegimenSis";
            this.DescripcionPacienteTipoRegimenSis.ReadOnly = true;
            this.DescripcionPacienteTipoRegimenSis.Width = 70;
            // 
            // FechaEvaluacionReniec
            // 
            this.FechaEvaluacionReniec.DataPropertyName = "FechaEvaluacionReniec";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.FechaEvaluacionReniec.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaEvaluacionReniec.HeaderText = "FechaReniec";
            this.FechaEvaluacionReniec.Name = "FechaEvaluacionReniec";
            this.FechaEvaluacionReniec.ReadOnly = true;
            this.FechaEvaluacionReniec.Width = 75;
            // 
            // PacienteVivo
            // 
            this.PacienteVivo.DataPropertyName = "PacienteVivo";
            this.PacienteVivo.HeaderText = "IdVivo";
            this.PacienteVivo.Name = "PacienteVivo";
            this.PacienteVivo.ReadOnly = true;
            this.PacienteVivo.Visible = false;
            this.PacienteVivo.Width = 55;
            // 
            // DescripcionPacienteVivo
            // 
            this.DescripcionPacienteVivo.DataPropertyName = "DescripcionPacienteVivo";
            this.DescripcionPacienteVivo.HeaderText = "Vivo";
            this.DescripcionPacienteVivo.Name = "DescripcionPacienteVivo";
            this.DescripcionPacienteVivo.ReadOnly = true;
            this.DescripcionPacienteVivo.Width = 60;
            // 
            // FechaEvaluacionFissal
            // 
            this.FechaEvaluacionFissal.DataPropertyName = "FechaEvaluacionFissal";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.FechaEvaluacionFissal.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaEvaluacionFissal.HeaderText = "FechaFissal";
            this.FechaEvaluacionFissal.Name = "FechaEvaluacionFissal";
            this.FechaEvaluacionFissal.ReadOnly = true;
            this.FechaEvaluacionFissal.Width = 70;
            // 
            // PacienteSinAutorizacionPrevia
            // 
            this.PacienteSinAutorizacionPrevia.DataPropertyName = "PacienteSinAutorizacionPrevia";
            this.PacienteSinAutorizacionPrevia.HeaderText = "IdSinAutPrevia";
            this.PacienteSinAutorizacionPrevia.Name = "PacienteSinAutorizacionPrevia";
            this.PacienteSinAutorizacionPrevia.ReadOnly = true;
            this.PacienteSinAutorizacionPrevia.Visible = false;
            this.PacienteSinAutorizacionPrevia.Width = 70;
            // 
            // DescripcionPacienteSinAutorizacionPrevia
            // 
            this.DescripcionPacienteSinAutorizacionPrevia.DataPropertyName = "DescripcionPacienteSinAutorizacionPrevia";
            this.DescripcionPacienteSinAutorizacionPrevia.HeaderText = "SinAutPrevia";
            this.DescripcionPacienteSinAutorizacionPrevia.Name = "DescripcionPacienteSinAutorizacionPrevia";
            this.DescripcionPacienteSinAutorizacionPrevia.ReadOnly = true;
            this.DescripcionPacienteSinAutorizacionPrevia.Width = 70;
            // 
            // PacienteTodosRetrospectivos
            // 
            this.PacienteTodosRetrospectivos.DataPropertyName = "PacienteTodosRetrospectivos";
            this.PacienteTodosRetrospectivos.HeaderText = "IdPacienteTodosRetrospectivos";
            this.PacienteTodosRetrospectivos.Name = "PacienteTodosRetrospectivos";
            this.PacienteTodosRetrospectivos.ReadOnly = true;
            this.PacienteTodosRetrospectivos.Visible = false;
            // 
            // DescripcionPacienteTodosRetrospectivos
            // 
            this.DescripcionPacienteTodosRetrospectivos.DataPropertyName = "DescripcionPacienteTodosRetrospectivos";
            this.DescripcionPacienteTodosRetrospectivos.HeaderText = "TodosRetrosp";
            this.DescripcionPacienteTodosRetrospectivos.Name = "DescripcionPacienteTodosRetrospectivos";
            this.DescripcionPacienteTodosRetrospectivos.ReadOnly = true;
            this.DescripcionPacienteTodosRetrospectivos.Width = 70;
            // 
            // PacienteTodosDiferenteFase
            // 
            this.PacienteTodosDiferenteFase.DataPropertyName = "PacienteTodosDiferenteFase";
            this.PacienteTodosDiferenteFase.HeaderText = "IdPacienteTodosDiferenteFase";
            this.PacienteTodosDiferenteFase.Name = "PacienteTodosDiferenteFase";
            this.PacienteTodosDiferenteFase.ReadOnly = true;
            this.PacienteTodosDiferenteFase.Visible = false;
            // 
            // DescripcionPacienteTodosDiferenteFase
            // 
            this.DescripcionPacienteTodosDiferenteFase.DataPropertyName = "DescripcionPacienteTodosDiferenteFase";
            this.DescripcionPacienteTodosDiferenteFase.HeaderText = "TodosDiferenteFase";
            this.DescripcionPacienteTodosDiferenteFase.Name = "DescripcionPacienteTodosDiferenteFase";
            this.DescripcionPacienteTodosDiferenteFase.ReadOnly = true;
            this.DescripcionPacienteTodosDiferenteFase.Width = 80;
            // 
            // Modalidad
            // 
            this.Modalidad.DataPropertyName = "Modalidad";
            this.Modalidad.HeaderText = "M";
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.ReadOnly = true;
            this.Modalidad.Width = 30;
            // 
            // FrmPreautorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPreautorizaciones";
            this.Text = "FrmPreautorizaciones";
            this.Load += new System.EventHandler(this.FrmPreautorizaciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreAutorizaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnConsultaReniec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnConsultarSis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnObtenerModalidad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.DataGridView dgvPreAutorizaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorizacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamiendoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientenombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionlarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_SolicitudDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvaluacionSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteActivoSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteActivoSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteTipoRegimenSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteTipoRegimenSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvaluacionReniec;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteVivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteVivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvaluacionFissal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteSinAutorizacionPrevia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteSinAutorizacionPrevia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteTodosRetrospectivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteTodosRetrospectivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteTodosDiferenteFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPacienteTodosDiferenteFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidad;
    }
}