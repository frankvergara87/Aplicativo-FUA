namespace FissalWinForm
{
    partial class FrmPreAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreAutorizacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnConsultarSis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnConsultaReniec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnObtenerModalidad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPreAutorizacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacionAutorizacionDefinitiva = new System.Windows.Forms.TextBox();
            this.cboModalidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPacienteRegimenSis = new System.Windows.Forms.ComboBox();
            this.cboPacienteActivoSis = new System.Windows.Forms.ComboBox();
            this.cboPacienteVivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAutorizacionesPrevias = new System.Windows.Forms.DataGridView();
            this.AutorizacionId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumentoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientenombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasedescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreAutorizacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacionesPrevias)).BeginInit();
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
            this.toolStripSeparator6,
            this.tsBtnSalir,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnConsultarSis
            // 
            this.tsBtnConsultarSis.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsultarSis.Image")));
            this.tsBtnConsultarSis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsultarSis.Name = "tsBtnConsultarSis";
            this.tsBtnConsultarSis.Size = new System.Drawing.Size(92, 22);
            this.tsBtnConsultarSis.Text = "Consulta SIS";
            this.tsBtnConsultarSis.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsBtnConsultaReniec
            // 
            this.tsBtnConsultaReniec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnConsultaReniec.Image")));
            this.tsBtnConsultaReniec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConsultaReniec.Name = "tsBtnConsultaReniec";
            this.tsBtnConsultaReniec.Size = new System.Drawing.Size(112, 22);
            this.tsBtnConsultaReniec.Text = "Verificar RENIEC";
            this.tsBtnConsultaReniec.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Visible = false;
            // 
            // tsBtnObtenerModalidad
            // 
            this.tsBtnObtenerModalidad.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnObtenerModalidad.Image")));
            this.tsBtnObtenerModalidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnObtenerModalidad.Name = "tsBtnObtenerModalidad";
            this.tsBtnObtenerModalidad.Size = new System.Drawing.Size(75, 22);
            this.tsBtnObtenerModalidad.Text = "Autorizar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSalir.Image")));
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(73, 22);
            this.tsBtnSalir.Text = "Cancelar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPreAutorizacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre Autorizacion";
            // 
            // dgvPreAutorizacion
            // 
            this.dgvPreAutorizacion.AllowUserToAddRows = false;
            this.dgvPreAutorizacion.AllowUserToDeleteRows = false;
            this.dgvPreAutorizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreAutorizacion.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPreAutorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreAutorizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorizacionId2,
            this.EstablecimientoId,
            this.Descripcion,
            this.PacienteId2,
            this.TipoDocumentoId,
            this.DescripcionTipoDocumento,
            this.NumeroDocumento,
            this.pacientenombre,
            this.CategoriaId2,
            this.DescripcionDiagnostico,
            this.fasedescripcion,
            this.EstadioId,
            this.DescripcionAutorizacion,
            this.FechaInicio,
            this.Vigencia,
            this.Monto,
            this.Modalidad,
            this.FechaSolicitud,
            this.Nro_Solicitud});
            this.dgvPreAutorizacion.Location = new System.Drawing.Point(22, 19);
            this.dgvPreAutorizacion.Name = "dgvPreAutorizacion";
            this.dgvPreAutorizacion.ReadOnly = true;
            this.dgvPreAutorizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreAutorizacion.Size = new System.Drawing.Size(943, 80);
            this.dgvPreAutorizacion.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtObservacionAutorizacionDefinitiva);
            this.groupBox2.Controls.Add(this.cboModalidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboPacienteRegimenSis);
            this.groupBox2.Controls.Add(this.cboPacienteActivoSis);
            this.groupBox2.Controls.Add(this.cboPacienteVivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observacion";
            // 
            // txtObservacionAutorizacionDefinitiva
            // 
            this.txtObservacionAutorizacionDefinitiva.Location = new System.Drawing.Point(407, 63);
            this.txtObservacionAutorizacionDefinitiva.Multiline = true;
            this.txtObservacionAutorizacionDefinitiva.Name = "txtObservacionAutorizacionDefinitiva";
            this.txtObservacionAutorizacionDefinitiva.Size = new System.Drawing.Size(334, 44);
            this.txtObservacionAutorizacionDefinitiva.TabIndex = 8;
            // 
            // cboModalidad
            // 
            this.cboModalidad.FormattingEnabled = true;
            this.cboModalidad.Location = new System.Drawing.Point(407, 27);
            this.cboModalidad.Name = "cboModalidad";
            this.cboModalidad.Size = new System.Drawing.Size(121, 21);
            this.cboModalidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Definir Modalidad";
            // 
            // cboPacienteRegimenSis
            // 
            this.cboPacienteRegimenSis.FormattingEnabled = true;
            this.cboPacienteRegimenSis.Location = new System.Drawing.Point(154, 55);
            this.cboPacienteRegimenSis.Name = "cboPacienteRegimenSis";
            this.cboPacienteRegimenSis.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteRegimenSis.TabIndex = 5;
            // 
            // cboPacienteActivoSis
            // 
            this.cboPacienteActivoSis.FormattingEnabled = true;
            this.cboPacienteActivoSis.Location = new System.Drawing.Point(154, 27);
            this.cboPacienteActivoSis.Name = "cboPacienteActivoSis";
            this.cboPacienteActivoSis.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteActivoSis.TabIndex = 4;
            // 
            // cboPacienteVivo
            // 
            this.cboPacienteVivo.FormattingEnabled = true;
            this.cboPacienteVivo.Location = new System.Drawing.Point(154, 86);
            this.cboPacienteVivo.Name = "cboPacienteVivo";
            this.cboPacienteVivo.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteVivo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paciente Regimen SIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente esta Activo SIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente esta Vivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAutorizacionesPrevias);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 273);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autorizacion Previas";
            // 
            // dgvAutorizacionesPrevias
            // 
            this.dgvAutorizacionesPrevias.AllowUserToAddRows = false;
            this.dgvAutorizacionesPrevias.AllowUserToDeleteRows = false;
            this.dgvAutorizacionesPrevias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutorizacionesPrevias.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAutorizacionesPrevias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizacionesPrevias.Location = new System.Drawing.Point(22, 19);
            this.dgvAutorizacionesPrevias.Name = "dgvAutorizacionesPrevias";
            this.dgvAutorizacionesPrevias.ReadOnly = true;
            this.dgvAutorizacionesPrevias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutorizacionesPrevias.Size = new System.Drawing.Size(943, 240);
            this.dgvAutorizacionesPrevias.TabIndex = 1;
            // 
            // AutorizacionId2
            // 
            this.AutorizacionId2.DataPropertyName = "AutorizacionId";
            this.AutorizacionId2.HeaderText = "AutorizacionId";
            this.AutorizacionId2.Name = "AutorizacionId2";
            this.AutorizacionId2.ReadOnly = true;
            this.AutorizacionId2.Visible = false;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "Renaes";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            this.EstablecimientoId.Width = 40;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "IPRESS";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 240;
            // 
            // PacienteId2
            // 
            this.PacienteId2.DataPropertyName = "PacienteId";
            this.PacienteId2.HeaderText = "PacienteId";
            this.PacienteId2.Name = "PacienteId2";
            this.PacienteId2.ReadOnly = true;
            this.PacienteId2.Visible = false;
            // 
            // TipoDocumentoId
            // 
            this.TipoDocumentoId.DataPropertyName = "TipoDocumentoId";
            this.TipoDocumentoId.HeaderText = "TipoDocumentoId";
            this.TipoDocumentoId.Name = "TipoDocumentoId";
            this.TipoDocumentoId.ReadOnly = true;
            this.TipoDocumentoId.Visible = false;
            // 
            // DescripcionTipoDocumento
            // 
            this.DescripcionTipoDocumento.DataPropertyName = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.HeaderText = "TipoDoc";
            this.DescripcionTipoDocumento.Name = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.ReadOnly = true;
            this.DescripcionTipoDocumento.Width = 50;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Doc";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 50;
            // 
            // pacientenombre
            // 
            this.pacientenombre.DataPropertyName = "pacientenombre";
            this.pacientenombre.HeaderText = "Paciente";
            this.pacientenombre.Name = "pacientenombre";
            this.pacientenombre.ReadOnly = true;
            this.pacientenombre.Width = 210;
            // 
            // CategoriaId2
            // 
            this.CategoriaId2.DataPropertyName = "CategoriaId";
            this.CategoriaId2.HeaderText = "Categoria";
            this.CategoriaId2.Name = "CategoriaId2";
            this.CategoriaId2.ReadOnly = true;
            this.CategoriaId2.Width = 40;
            // 
            // DescripcionDiagnostico
            // 
            this.DescripcionDiagnostico.DataPropertyName = "DescripcionDiagnostico";
            this.DescripcionDiagnostico.HeaderText = "Diagnostico";
            this.DescripcionDiagnostico.Name = "DescripcionDiagnostico";
            this.DescripcionDiagnostico.ReadOnly = true;
            // 
            // fasedescripcion
            // 
            this.fasedescripcion.DataPropertyName = "fasedescripcion";
            this.fasedescripcion.HeaderText = "Fase";
            this.fasedescripcion.Name = "fasedescripcion";
            this.fasedescripcion.ReadOnly = true;
            // 
            // EstadioId
            // 
            this.EstadioId.DataPropertyName = "EstadioId";
            this.EstadioId.HeaderText = "Estadio";
            this.EstadioId.Name = "EstadioId";
            this.EstadioId.ReadOnly = true;
            this.EstadioId.Width = 50;
            // 
            // DescripcionAutorizacion
            // 
            this.DescripcionAutorizacion.DataPropertyName = "DescripcionAutorizacion";
            this.DescripcionAutorizacion.HeaderText = "TipoAut";
            this.DescripcionAutorizacion.Name = "DescripcionAutorizacion";
            this.DescripcionAutorizacion.ReadOnly = true;
            this.DescripcionAutorizacion.Width = 50;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 70;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "Vigencia";
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            this.Vigencia.Width = 70;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 50;
            // 
            // Modalidad
            // 
            this.Modalidad.DataPropertyName = "Modalidad";
            this.Modalidad.HeaderText = "Modalidad";
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.ReadOnly = true;
            this.Modalidad.Width = 50;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.DataPropertyName = "FechaSolicitud";
            this.FechaSolicitud.HeaderText = "FechaSolicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.ReadOnly = true;
            this.FechaSolicitud.Width = 70;
            // 
            // Nro_Solicitud
            // 
            this.Nro_Solicitud.DataPropertyName = "Nro_Solicitud";
            this.Nro_Solicitud.HeaderText = "Solicitud";
            this.Nro_Solicitud.Name = "Nro_Solicitud";
            this.Nro_Solicitud.ReadOnly = true;
            this.Nro_Solicitud.Width = 50;
            // 
            // FrmPreAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPreAutorizacion";
            this.Text = "FrmPreAutorizacion";
            this.Load += new System.EventHandler(this.FrmPreAutorizacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreAutorizacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacionesPrevias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnConsultarSis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnConsultaReniec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnObtenerModalidad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPreAutorizacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAutorizacionesPrevias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPacienteRegimenSis;
        private System.Windows.Forms.ComboBox cboPacienteActivoSis;
        private System.Windows.Forms.ComboBox cboPacienteVivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacionAutorizacionDefinitiva;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorizacionId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumentoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientenombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasedescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Solicitud;

    }
}