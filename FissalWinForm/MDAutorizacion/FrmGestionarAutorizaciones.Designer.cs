namespace FissalWinForm
{
    partial class FrmGestionarAutorizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarAutorizaciones));
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorPaciente = new System.Windows.Forms.Button();
            this.lblPacienteId = new System.Windows.Forms.Label();
            this.txtPacienteId = new System.Windows.Forms.TextBox();
            this.txtPacienteNombres = new System.Windows.Forms.TextBox();
            this.lblPacienteNombres = new System.Windows.Forms.Label();
            this.grpTratamiento = new System.Windows.Forms.GroupBox();
            this.lblTratamientoMonto = new System.Windows.Forms.Label();
            this.txtTratamientoMonto = new System.Windows.Forms.TextBox();
            this.cboTratamientoEstadio = new System.Windows.Forms.ComboBox();
            this.cboTratamientoFase = new System.Windows.Forms.ComboBox();
            this.cboTratamientoCategoria = new System.Windows.Forms.ComboBox();
            this.txtTratamientoVigencia = new System.Windows.Forms.TextBox();
            this.lblTratamientoVigencia = new System.Windows.Forms.Label();
            this.txtTratamientoVersion = new System.Windows.Forms.TextBox();
            this.lblTratamientoVersion = new System.Windows.Forms.Label();
            this.btnAbrirSelectorTratamiento = new System.Windows.Forms.Button();
            this.lblTratamientoId = new System.Windows.Forms.Label();
            this.txtTratamientoId = new System.Windows.Forms.TextBox();
            this.lblTratamientoCategoria = new System.Windows.Forms.Label();
            this.lblTratamientoFase = new System.Windows.Forms.Label();
            this.lblTratamientoEstadio = new System.Windows.Forms.Label();
            this.lblAutorizacionTipo = new System.Windows.Forms.Label();
            this.cboTratamientoTipo = new System.Windows.Forms.ComboBox();
            this.txtAutorizacionFechaVigencia = new System.Windows.Forms.TextBox();
            this.lblAutorizacionModalidad = new System.Windows.Forms.Label();
            this.lblAutorizacionFechaVigencia = new System.Windows.Forms.Label();
            this.dtpAutorizacionFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAutorizacionFecha = new System.Windows.Forms.Label();
            this.cboAutorizacionModalidad = new System.Windows.Forms.ComboBox();
            this.lblAutorizacionEstablecimiento = new System.Windows.Forms.Label();
            this.cboAutorizacionEstablecimiento = new System.Windows.Forms.ComboBox();
            this.grpAutorizacion = new System.Windows.Forms.GroupBox();
            this.btnAutorizacionLimpiarFechaSolicitud = new System.Windows.Forms.Button();
            this.btnAutorizacionLimpiarFecha = new System.Windows.Forms.Button();
            this.lblAutorizacionNumeroSolicitud = new System.Windows.Forms.Label();
            this.txtAutorizacionNumeroSolicitud = new System.Windows.Forms.TextBox();
            this.lblAutorizacionCodigo = new System.Windows.Forms.Label();
            this.txtAutorizacionCodigo = new System.Windows.Forms.TextBox();
            this.dtpAutorizacionFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblAutorizacionFechaSolicitud = new System.Windows.Forms.Label();
            this.txtAutorizacionFechaSolicitud = new System.Windows.Forms.TextBox();
            this.chkAutorizacionAnulado = new System.Windows.Forms.CheckBox();
            this.lblAutorizacionUsuarioCreacion = new System.Windows.Forms.Label();
            this.txtAutorizacionUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.lblAutorizacionObservacion = new System.Windows.Forms.Label();
            this.txtAutorizacionObservacion = new System.Windows.Forms.TextBox();
            this.lblAutorizacionDescripcion = new System.Windows.Forms.Label();
            this.txtAutorizacionDescripcion = new System.Windows.Forms.TextBox();
            this.lblAutorizacionFechaCreacion = new System.Windows.Forms.Label();
            this.txtAutorizacionFechaCreacion = new System.Windows.Forms.TextBox();
            this.chkAutorizacionEstado = new System.Windows.Forms.CheckBox();
            this.chkAutorizacionDxAsociado = new System.Windows.Forms.CheckBox();
            this.chkAutorizacionAdicional = new System.Windows.Forms.CheckBox();
            this.chkAutorizacionControlaCantidad = new System.Windows.Forms.CheckBox();
            this.txtAutorizacionFecha = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnRechazar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAnular = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPaciente.SuspendLayout();
            this.grpTratamiento.SuspendLayout();
            this.grpAutorizacion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.btnAbrirSelectorPaciente);
            this.grpPaciente.Controls.Add(this.lblPacienteId);
            this.grpPaciente.Controls.Add(this.txtPacienteId);
            this.grpPaciente.Controls.Add(this.txtPacienteNombres);
            this.grpPaciente.Controls.Add(this.lblPacienteNombres);
            this.grpPaciente.Location = new System.Drawing.Point(12, 28);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(600, 45);
            this.grpPaciente.TabIndex = 0;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Paciente";
            // 
            // btnAbrirSelectorPaciente
            // 
            this.btnAbrirSelectorPaciente.Location = new System.Drawing.Point(137, 13);
            this.btnAbrirSelectorPaciente.Name = "btnAbrirSelectorPaciente";
            this.btnAbrirSelectorPaciente.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorPaciente.TabIndex = 1;
            this.btnAbrirSelectorPaciente.Text = "...";
            this.btnAbrirSelectorPaciente.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorPaciente.Click += new System.EventHandler(this.btnAbrirSelectorPaciente_Click);
            // 
            // lblPacienteId
            // 
            this.lblPacienteId.AutoSize = true;
            this.lblPacienteId.Location = new System.Drawing.Point(17, 16);
            this.lblPacienteId.Name = "lblPacienteId";
            this.lblPacienteId.Size = new System.Drawing.Size(23, 13);
            this.lblPacienteId.TabIndex = 82;
            this.lblPacienteId.Text = "* Id";
            // 
            // txtPacienteId
            // 
            this.txtPacienteId.Location = new System.Drawing.Point(72, 13);
            this.txtPacienteId.Name = "txtPacienteId";
            this.txtPacienteId.Size = new System.Drawing.Size(60, 20);
            this.txtPacienteId.TabIndex = 0;
            this.txtPacienteId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPacienteId_KeyDown);
            this.txtPacienteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteNumeroDocumento_KeyPress);
            this.txtPacienteId.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteNumeroDocumento_Validating);
            this.txtPacienteId.Validated += new System.EventHandler(this.txtPacienteNumeroDocumento_Validated);
            // 
            // txtPacienteNombres
            // 
            this.txtPacienteNombres.Location = new System.Drawing.Point(230, 13);
            this.txtPacienteNombres.Name = "txtPacienteNombres";
            this.txtPacienteNombres.Size = new System.Drawing.Size(354, 20);
            this.txtPacienteNombres.TabIndex = 2;
            // 
            // lblPacienteNombres
            // 
            this.lblPacienteNombres.AutoSize = true;
            this.lblPacienteNombres.Location = new System.Drawing.Point(179, 16);
            this.lblPacienteNombres.Name = "lblPacienteNombres";
            this.lblPacienteNombres.Size = new System.Drawing.Size(49, 13);
            this.lblPacienteNombres.TabIndex = 84;
            this.lblPacienteNombres.Text = "Nombres";
            // 
            // grpTratamiento
            // 
            this.grpTratamiento.Controls.Add(this.lblTratamientoMonto);
            this.grpTratamiento.Controls.Add(this.txtTratamientoMonto);
            this.grpTratamiento.Controls.Add(this.cboTratamientoEstadio);
            this.grpTratamiento.Controls.Add(this.cboTratamientoFase);
            this.grpTratamiento.Controls.Add(this.cboTratamientoCategoria);
            this.grpTratamiento.Controls.Add(this.txtTratamientoVigencia);
            this.grpTratamiento.Controls.Add(this.lblTratamientoVigencia);
            this.grpTratamiento.Controls.Add(this.txtTratamientoVersion);
            this.grpTratamiento.Controls.Add(this.lblTratamientoVersion);
            this.grpTratamiento.Controls.Add(this.btnAbrirSelectorTratamiento);
            this.grpTratamiento.Controls.Add(this.lblTratamientoId);
            this.grpTratamiento.Controls.Add(this.txtTratamientoId);
            this.grpTratamiento.Controls.Add(this.lblTratamientoCategoria);
            this.grpTratamiento.Controls.Add(this.lblTratamientoFase);
            this.grpTratamiento.Controls.Add(this.lblTratamientoEstadio);
            this.grpTratamiento.Controls.Add(this.lblAutorizacionTipo);
            this.grpTratamiento.Controls.Add(this.cboTratamientoTipo);
            this.grpTratamiento.Location = new System.Drawing.Point(12, 300);
            this.grpTratamiento.Name = "grpTratamiento";
            this.grpTratamiento.Size = new System.Drawing.Size(600, 94);
            this.grpTratamiento.TabIndex = 2;
            this.grpTratamiento.TabStop = false;
            this.grpTratamiento.Text = "Tratamiento";
            // 
            // lblTratamientoMonto
            // 
            this.lblTratamientoMonto.AutoSize = true;
            this.lblTratamientoMonto.Location = new System.Drawing.Point(484, 16);
            this.lblTratamientoMonto.Name = "lblTratamientoMonto";
            this.lblTratamientoMonto.Size = new System.Drawing.Size(37, 13);
            this.lblTratamientoMonto.TabIndex = 123;
            this.lblTratamientoMonto.Text = "Monto";
            // 
            // txtTratamientoMonto
            // 
            this.txtTratamientoMonto.Location = new System.Drawing.Point(524, 13);
            this.txtTratamientoMonto.Name = "txtTratamientoMonto";
            this.txtTratamientoMonto.Size = new System.Drawing.Size(60, 20);
            this.txtTratamientoMonto.TabIndex = 122;
            // 
            // cboTratamientoEstadio
            // 
            this.cboTratamientoEstadio.FormattingEnabled = true;
            this.cboTratamientoEstadio.Location = new System.Drawing.Point(474, 63);
            this.cboTratamientoEstadio.Name = "cboTratamientoEstadio";
            this.cboTratamientoEstadio.Size = new System.Drawing.Size(110, 21);
            this.cboTratamientoEstadio.TabIndex = 121;
            // 
            // cboTratamientoFase
            // 
            this.cboTratamientoFase.FormattingEnabled = true;
            this.cboTratamientoFase.Location = new System.Drawing.Point(72, 63);
            this.cboTratamientoFase.Name = "cboTratamientoFase";
            this.cboTratamientoFase.Size = new System.Drawing.Size(346, 21);
            this.cboTratamientoFase.TabIndex = 120;
            // 
            // cboTratamientoCategoria
            // 
            this.cboTratamientoCategoria.FormattingEnabled = true;
            this.cboTratamientoCategoria.Location = new System.Drawing.Point(72, 38);
            this.cboTratamientoCategoria.Name = "cboTratamientoCategoria";
            this.cboTratamientoCategoria.Size = new System.Drawing.Size(512, 21);
            this.cboTratamientoCategoria.TabIndex = 104;
            this.cboTratamientoCategoria.SelectedIndexChanged += new System.EventHandler(this.cboTratamientoCategoria_SelectedIndexChanged);
            // 
            // txtTratamientoVigencia
            // 
            this.txtTratamientoVigencia.Location = new System.Drawing.Point(299, 13);
            this.txtTratamientoVigencia.Name = "txtTratamientoVigencia";
            this.txtTratamientoVigencia.Size = new System.Drawing.Size(20, 20);
            this.txtTratamientoVigencia.TabIndex = 96;
            this.txtTratamientoVigencia.TextChanged += new System.EventHandler(this.txtTratamientoVigencia_TextChanged);
            // 
            // lblTratamientoVigencia
            // 
            this.lblTratamientoVigencia.AutoSize = true;
            this.lblTratamientoVigencia.Location = new System.Drawing.Point(248, 16);
            this.lblTratamientoVigencia.Name = "lblTratamientoVigencia";
            this.lblTratamientoVigencia.Size = new System.Drawing.Size(48, 13);
            this.lblTratamientoVigencia.TabIndex = 95;
            this.lblTratamientoVigencia.Text = "Vigencia";
            // 
            // txtTratamientoVersion
            // 
            this.txtTratamientoVersion.Location = new System.Drawing.Point(215, 13);
            this.txtTratamientoVersion.Name = "txtTratamientoVersion";
            this.txtTratamientoVersion.Size = new System.Drawing.Size(20, 20);
            this.txtTratamientoVersion.TabIndex = 94;
            // 
            // lblTratamientoVersion
            // 
            this.lblTratamientoVersion.AutoSize = true;
            this.lblTratamientoVersion.Location = new System.Drawing.Point(170, 16);
            this.lblTratamientoVersion.Name = "lblTratamientoVersion";
            this.lblTratamientoVersion.Size = new System.Drawing.Size(42, 13);
            this.lblTratamientoVersion.TabIndex = 93;
            this.lblTratamientoVersion.Text = "Version";
            // 
            // btnAbrirSelectorTratamiento
            // 
            this.btnAbrirSelectorTratamiento.Location = new System.Drawing.Point(127, 13);
            this.btnAbrirSelectorTratamiento.Name = "btnAbrirSelectorTratamiento";
            this.btnAbrirSelectorTratamiento.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorTratamiento.TabIndex = 1;
            this.btnAbrirSelectorTratamiento.Text = "...";
            this.btnAbrirSelectorTratamiento.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorTratamiento.Click += new System.EventHandler(this.btnAbrirSelectorTratamiento_Click);
            // 
            // lblTratamientoId
            // 
            this.lblTratamientoId.AutoSize = true;
            this.lblTratamientoId.Location = new System.Drawing.Point(17, 16);
            this.lblTratamientoId.Name = "lblTratamientoId";
            this.lblTratamientoId.Size = new System.Drawing.Size(23, 13);
            this.lblTratamientoId.TabIndex = 85;
            this.lblTratamientoId.Text = "* Id";
            // 
            // txtTratamientoId
            // 
            this.txtTratamientoId.Location = new System.Drawing.Point(72, 13);
            this.txtTratamientoId.Name = "txtTratamientoId";
            this.txtTratamientoId.Size = new System.Drawing.Size(50, 20);
            this.txtTratamientoId.TabIndex = 0;
            this.txtTratamientoId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTratamientoId_KeyDown);
            this.txtTratamientoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTratamientoId_KeyPress);
            this.txtTratamientoId.Validating += new System.ComponentModel.CancelEventHandler(this.txtTratamientoId_Validating);
            this.txtTratamientoId.Validated += new System.EventHandler(this.txtTratamientoId_Validated);
            // 
            // lblTratamientoCategoria
            // 
            this.lblTratamientoCategoria.AutoSize = true;
            this.lblTratamientoCategoria.Location = new System.Drawing.Point(17, 41);
            this.lblTratamientoCategoria.Name = "lblTratamientoCategoria";
            this.lblTratamientoCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblTratamientoCategoria.TabIndex = 69;
            this.lblTratamientoCategoria.Text = "Categoria";
            // 
            // lblTratamientoFase
            // 
            this.lblTratamientoFase.AutoSize = true;
            this.lblTratamientoFase.Location = new System.Drawing.Point(17, 66);
            this.lblTratamientoFase.Name = "lblTratamientoFase";
            this.lblTratamientoFase.Size = new System.Drawing.Size(30, 13);
            this.lblTratamientoFase.TabIndex = 76;
            this.lblTratamientoFase.Text = "Fase";
            // 
            // lblTratamientoEstadio
            // 
            this.lblTratamientoEstadio.AutoSize = true;
            this.lblTratamientoEstadio.Location = new System.Drawing.Point(429, 66);
            this.lblTratamientoEstadio.Name = "lblTratamientoEstadio";
            this.lblTratamientoEstadio.Size = new System.Drawing.Size(42, 13);
            this.lblTratamientoEstadio.TabIndex = 74;
            this.lblTratamientoEstadio.Text = "Estadio";
            // 
            // lblAutorizacionTipo
            // 
            this.lblAutorizacionTipo.AutoSize = true;
            this.lblAutorizacionTipo.Location = new System.Drawing.Point(333, 16);
            this.lblAutorizacionTipo.Name = "lblAutorizacionTipo";
            this.lblAutorizacionTipo.Size = new System.Drawing.Size(28, 13);
            this.lblAutorizacionTipo.TabIndex = 78;
            this.lblAutorizacionTipo.Text = "Tipo";
            // 
            // cboTratamientoTipo
            // 
            this.cboTratamientoTipo.FormattingEnabled = true;
            this.cboTratamientoTipo.Location = new System.Drawing.Point(364, 13);
            this.cboTratamientoTipo.Name = "cboTratamientoTipo";
            this.cboTratamientoTipo.Size = new System.Drawing.Size(100, 21);
            this.cboTratamientoTipo.TabIndex = 95;
            this.cboTratamientoTipo.SelectedIndexChanged += new System.EventHandler(this.cboTratamientoTipo_SelectedIndexChanged);
            // 
            // txtAutorizacionFechaVigencia
            // 
            this.txtAutorizacionFechaVigencia.Location = new System.Drawing.Point(72, 113);
            this.txtAutorizacionFechaVigencia.Name = "txtAutorizacionFechaVigencia";
            this.txtAutorizacionFechaVigencia.Size = new System.Drawing.Size(70, 20);
            this.txtAutorizacionFechaVigencia.TabIndex = 5;
            this.txtAutorizacionFechaVigencia.TabStop = false;
            this.txtAutorizacionFechaVigencia.Validating += new System.ComponentModel.CancelEventHandler(this.txtAutorizacionFechaVigencia_Validating);
            this.txtAutorizacionFechaVigencia.Validated += new System.EventHandler(this.txtAutorizacionFechaVigencia_Validated);
            // 
            // lblAutorizacionModalidad
            // 
            this.lblAutorizacionModalidad.AutoSize = true;
            this.lblAutorizacionModalidad.Location = new System.Drawing.Point(17, 91);
            this.lblAutorizacionModalidad.Name = "lblAutorizacionModalidad";
            this.lblAutorizacionModalidad.Size = new System.Drawing.Size(54, 13);
            this.lblAutorizacionModalidad.TabIndex = 94;
            this.lblAutorizacionModalidad.Text = "* Modalid.";
            // 
            // lblAutorizacionFechaVigencia
            // 
            this.lblAutorizacionFechaVigencia.AutoSize = true;
            this.lblAutorizacionFechaVigencia.Location = new System.Drawing.Point(17, 116);
            this.lblAutorizacionFechaVigencia.Name = "lblAutorizacionFechaVigencia";
            this.lblAutorizacionFechaVigencia.Size = new System.Drawing.Size(55, 13);
            this.lblAutorizacionFechaVigencia.TabIndex = 90;
            this.lblAutorizacionFechaVigencia.Text = "* Vigencia";
            // 
            // dtpAutorizacionFecha
            // 
            this.dtpAutorizacionFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAutorizacionFecha.Location = new System.Drawing.Point(145, 63);
            this.dtpAutorizacionFecha.Name = "dtpAutorizacionFecha";
            this.dtpAutorizacionFecha.Size = new System.Drawing.Size(20, 20);
            this.dtpAutorizacionFecha.TabIndex = 2;
            this.dtpAutorizacionFecha.ValueChanged += new System.EventHandler(this.dtpAutorizacionFecha_ValueChanged);
            // 
            // lblAutorizacionFecha
            // 
            this.lblAutorizacionFecha.AutoSize = true;
            this.lblAutorizacionFecha.Location = new System.Drawing.Point(17, 66);
            this.lblAutorizacionFecha.Name = "lblAutorizacionFecha";
            this.lblAutorizacionFecha.Size = new System.Drawing.Size(44, 13);
            this.lblAutorizacionFecha.TabIndex = 86;
            this.lblAutorizacionFecha.Text = "* Fecha";
            // 
            // cboAutorizacionModalidad
            // 
            this.cboAutorizacionModalidad.FormattingEnabled = true;
            this.cboAutorizacionModalidad.Location = new System.Drawing.Point(72, 88);
            this.cboAutorizacionModalidad.Name = "cboAutorizacionModalidad";
            this.cboAutorizacionModalidad.Size = new System.Drawing.Size(120, 21);
            this.cboAutorizacionModalidad.TabIndex = 4;
            this.cboAutorizacionModalidad.Validating += new System.ComponentModel.CancelEventHandler(this.cboAutorizacionModalidad_Validating);
            this.cboAutorizacionModalidad.Validated += new System.EventHandler(this.cboAutorizacionModalidad_Validated);
            // 
            // lblAutorizacionEstablecimiento
            // 
            this.lblAutorizacionEstablecimiento.AutoSize = true;
            this.lblAutorizacionEstablecimiento.Location = new System.Drawing.Point(17, 16);
            this.lblAutorizacionEstablecimiento.Name = "lblAutorizacionEstablecimiento";
            this.lblAutorizacionEstablecimiento.Size = new System.Drawing.Size(58, 13);
            this.lblAutorizacionEstablecimiento.TabIndex = 102;
            this.lblAutorizacionEstablecimiento.Text = "* Establec.";
            // 
            // cboAutorizacionEstablecimiento
            // 
            this.cboAutorizacionEstablecimiento.FormattingEnabled = true;
            this.cboAutorizacionEstablecimiento.Location = new System.Drawing.Point(72, 13);
            this.cboAutorizacionEstablecimiento.Name = "cboAutorizacionEstablecimiento";
            this.cboAutorizacionEstablecimiento.Size = new System.Drawing.Size(512, 21);
            this.cboAutorizacionEstablecimiento.TabIndex = 0;
            this.cboAutorizacionEstablecimiento.SelectionChangeCommitted += new System.EventHandler(this.cboAutorizacionEstablecimiento_SelectionChangeCommitted);
            this.cboAutorizacionEstablecimiento.Validating += new System.ComponentModel.CancelEventHandler(this.cboAutorizacionEstablecimiento_Validating);
            this.cboAutorizacionEstablecimiento.Validated += new System.EventHandler(this.cboAutorizacionEstablecimiento_Validated);
            // 
            // grpAutorizacion
            // 
            this.grpAutorizacion.Controls.Add(this.btnAutorizacionLimpiarFechaSolicitud);
            this.grpAutorizacion.Controls.Add(this.btnAutorizacionLimpiarFecha);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionNumeroSolicitud);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionNumeroSolicitud);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionCodigo);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionCodigo);
            this.grpAutorizacion.Controls.Add(this.dtpAutorizacionFechaSolicitud);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionFechaSolicitud);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionFechaSolicitud);
            this.grpAutorizacion.Controls.Add(this.chkAutorizacionAnulado);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionUsuarioCreacion);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionUsuarioCreacion);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionObservacion);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionObservacion);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionDescripcion);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionDescripcion);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionFechaCreacion);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionFechaCreacion);
            this.grpAutorizacion.Controls.Add(this.cboAutorizacionEstablecimiento);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionEstablecimiento);
            this.grpAutorizacion.Controls.Add(this.chkAutorizacionEstado);
            this.grpAutorizacion.Controls.Add(this.chkAutorizacionDxAsociado);
            this.grpAutorizacion.Controls.Add(this.chkAutorizacionAdicional);
            this.grpAutorizacion.Controls.Add(this.cboAutorizacionModalidad);
            this.grpAutorizacion.Controls.Add(this.chkAutorizacionControlaCantidad);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionFecha);
            this.grpAutorizacion.Controls.Add(this.dtpAutorizacionFecha);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionFechaVigencia);
            this.grpAutorizacion.Controls.Add(this.lblAutorizacionModalidad);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionFechaVigencia);
            this.grpAutorizacion.Controls.Add(this.txtAutorizacionFecha);
            this.grpAutorizacion.Location = new System.Drawing.Point(12, 79);
            this.grpAutorizacion.Name = "grpAutorizacion";
            this.grpAutorizacion.Size = new System.Drawing.Size(600, 215);
            this.grpAutorizacion.TabIndex = 1;
            this.grpAutorizacion.TabStop = false;
            this.grpAutorizacion.Text = "Autorizacion";
            // 
            // btnAutorizacionLimpiarFechaSolicitud
            // 
            this.btnAutorizacionLimpiarFechaSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizacionLimpiarFechaSolicitud.Image")));
            this.btnAutorizacionLimpiarFechaSolicitud.Location = new System.Drawing.Point(399, 137);
            this.btnAutorizacionLimpiarFechaSolicitud.Name = "btnAutorizacionLimpiarFechaSolicitud";
            this.btnAutorizacionLimpiarFechaSolicitud.Size = new System.Drawing.Size(22, 22);
            this.btnAutorizacionLimpiarFechaSolicitud.TabIndex = 125;
            this.btnAutorizacionLimpiarFechaSolicitud.TabStop = false;
            this.btnAutorizacionLimpiarFechaSolicitud.UseVisualStyleBackColor = true;
            this.btnAutorizacionLimpiarFechaSolicitud.Click += new System.EventHandler(this.btnAutorizacionLimpiarFechaSolicitud_Click);
            // 
            // btnAutorizacionLimpiarFecha
            // 
            this.btnAutorizacionLimpiarFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizacionLimpiarFecha.Image")));
            this.btnAutorizacionLimpiarFecha.Location = new System.Drawing.Point(170, 62);
            this.btnAutorizacionLimpiarFecha.Name = "btnAutorizacionLimpiarFecha";
            this.btnAutorizacionLimpiarFecha.Size = new System.Drawing.Size(22, 22);
            this.btnAutorizacionLimpiarFecha.TabIndex = 124;
            this.btnAutorizacionLimpiarFecha.TabStop = false;
            this.btnAutorizacionLimpiarFecha.UseVisualStyleBackColor = true;
            this.btnAutorizacionLimpiarFecha.Click += new System.EventHandler(this.btnLimpiarAutorizacionFecha_Click);
            // 
            // lblAutorizacionNumeroSolicitud
            // 
            this.lblAutorizacionNumeroSolicitud.AutoSize = true;
            this.lblAutorizacionNumeroSolicitud.Location = new System.Drawing.Point(433, 141);
            this.lblAutorizacionNumeroSolicitud.Name = "lblAutorizacionNumeroSolicitud";
            this.lblAutorizacionNumeroSolicitud.Size = new System.Drawing.Size(62, 13);
            this.lblAutorizacionNumeroSolicitud.TabIndex = 123;
            this.lblAutorizacionNumeroSolicitud.Text = "N° Solicitud";
            // 
            // txtAutorizacionNumeroSolicitud
            // 
            this.txtAutorizacionNumeroSolicitud.Location = new System.Drawing.Point(504, 138);
            this.txtAutorizacionNumeroSolicitud.Name = "txtAutorizacionNumeroSolicitud";
            this.txtAutorizacionNumeroSolicitud.Size = new System.Drawing.Size(80, 20);
            this.txtAutorizacionNumeroSolicitud.TabIndex = 13;
            // 
            // lblAutorizacionCodigo
            // 
            this.lblAutorizacionCodigo.AutoSize = true;
            this.lblAutorizacionCodigo.Location = new System.Drawing.Point(17, 41);
            this.lblAutorizacionCodigo.Name = "lblAutorizacionCodigo";
            this.lblAutorizacionCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblAutorizacionCodigo.TabIndex = 121;
            this.lblAutorizacionCodigo.Text = "Codigo";
            // 
            // txtAutorizacionCodigo
            // 
            this.txtAutorizacionCodigo.Location = new System.Drawing.Point(72, 38);
            this.txtAutorizacionCodigo.Name = "txtAutorizacionCodigo";
            this.txtAutorizacionCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtAutorizacionCodigo.TabIndex = 1;
            // 
            // dtpAutorizacionFechaSolicitud
            // 
            this.dtpAutorizacionFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAutorizacionFechaSolicitud.Location = new System.Drawing.Point(374, 138);
            this.dtpAutorizacionFechaSolicitud.Name = "dtpAutorizacionFechaSolicitud";
            this.dtpAutorizacionFechaSolicitud.Size = new System.Drawing.Size(20, 20);
            this.dtpAutorizacionFechaSolicitud.TabIndex = 12;
            this.dtpAutorizacionFechaSolicitud.ValueChanged += new System.EventHandler(this.dtpAutorizacionFechaSolicitud_ValueChanged);
            // 
            // lblAutorizacionFechaSolicitud
            // 
            this.lblAutorizacionFechaSolicitud.AutoSize = true;
            this.lblAutorizacionFechaSolicitud.Location = new System.Drawing.Point(211, 141);
            this.lblAutorizacionFechaSolicitud.Name = "lblAutorizacionFechaSolicitud";
            this.lblAutorizacionFechaSolicitud.Size = new System.Drawing.Size(80, 13);
            this.lblAutorizacionFechaSolicitud.TabIndex = 118;
            this.lblAutorizacionFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // txtAutorizacionFechaSolicitud
            // 
            this.txtAutorizacionFechaSolicitud.Location = new System.Drawing.Point(298, 138);
            this.txtAutorizacionFechaSolicitud.Name = "txtAutorizacionFechaSolicitud";
            this.txtAutorizacionFechaSolicitud.Size = new System.Drawing.Size(70, 20);
            this.txtAutorizacionFechaSolicitud.TabIndex = 11;
            this.txtAutorizacionFechaSolicitud.TabStop = false;
            this.txtAutorizacionFechaSolicitud.Validating += new System.ComponentModel.CancelEventHandler(this.txtAutorizacionFechaSolicitud_Validating);
            this.txtAutorizacionFechaSolicitud.Validated += new System.EventHandler(this.txtAutorizacionFechaSolicitud_Validated);
            // 
            // chkAutorizacionAnulado
            // 
            this.chkAutorizacionAnulado.AutoSize = true;
            this.chkAutorizacionAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizacionAnulado.Location = new System.Drawing.Point(504, 191);
            this.chkAutorizacionAnulado.Name = "chkAutorizacionAnulado";
            this.chkAutorizacionAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAutorizacionAnulado.TabIndex = 17;
            this.chkAutorizacionAnulado.Text = "Anulado";
            this.chkAutorizacionAnulado.UseVisualStyleBackColor = true;
            // 
            // lblAutorizacionUsuarioCreacion
            // 
            this.lblAutorizacionUsuarioCreacion.AutoSize = true;
            this.lblAutorizacionUsuarioCreacion.Location = new System.Drawing.Point(413, 166);
            this.lblAutorizacionUsuarioCreacion.Name = "lblAutorizacionUsuarioCreacion";
            this.lblAutorizacionUsuarioCreacion.Size = new System.Drawing.Size(88, 13);
            this.lblAutorizacionUsuarioCreacion.TabIndex = 112;
            this.lblAutorizacionUsuarioCreacion.Text = "Usuario Creacion";
            // 
            // txtAutorizacionUsuarioCreacion
            // 
            this.txtAutorizacionUsuarioCreacion.Location = new System.Drawing.Point(504, 163);
            this.txtAutorizacionUsuarioCreacion.Name = "txtAutorizacionUsuarioCreacion";
            this.txtAutorizacionUsuarioCreacion.Size = new System.Drawing.Size(80, 20);
            this.txtAutorizacionUsuarioCreacion.TabIndex = 15;
            // 
            // lblAutorizacionObservacion
            // 
            this.lblAutorizacionObservacion.AutoSize = true;
            this.lblAutorizacionObservacion.Location = new System.Drawing.Point(211, 91);
            this.lblAutorizacionObservacion.Name = "lblAutorizacionObservacion";
            this.lblAutorizacionObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblAutorizacionObservacion.TabIndex = 110;
            this.lblAutorizacionObservacion.Text = "Observacion";
            // 
            // txtAutorizacionObservacion
            // 
            this.txtAutorizacionObservacion.Location = new System.Drawing.Point(298, 88);
            this.txtAutorizacionObservacion.Multiline = true;
            this.txtAutorizacionObservacion.Name = "txtAutorizacionObservacion";
            this.txtAutorizacionObservacion.Size = new System.Drawing.Size(286, 45);
            this.txtAutorizacionObservacion.TabIndex = 10;
            // 
            // lblAutorizacionDescripcion
            // 
            this.lblAutorizacionDescripcion.AutoSize = true;
            this.lblAutorizacionDescripcion.Location = new System.Drawing.Point(211, 41);
            this.lblAutorizacionDescripcion.Name = "lblAutorizacionDescripcion";
            this.lblAutorizacionDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblAutorizacionDescripcion.TabIndex = 108;
            this.lblAutorizacionDescripcion.Text = "Descripcion";
            // 
            // txtAutorizacionDescripcion
            // 
            this.txtAutorizacionDescripcion.Location = new System.Drawing.Point(298, 38);
            this.txtAutorizacionDescripcion.Multiline = true;
            this.txtAutorizacionDescripcion.Name = "txtAutorizacionDescripcion";
            this.txtAutorizacionDescripcion.Size = new System.Drawing.Size(286, 45);
            this.txtAutorizacionDescripcion.TabIndex = 9;
            // 
            // lblAutorizacionFechaCreacion
            // 
            this.lblAutorizacionFechaCreacion.AutoSize = true;
            this.lblAutorizacionFechaCreacion.Location = new System.Drawing.Point(211, 166);
            this.lblAutorizacionFechaCreacion.Name = "lblAutorizacionFechaCreacion";
            this.lblAutorizacionFechaCreacion.Size = new System.Drawing.Size(82, 13);
            this.lblAutorizacionFechaCreacion.TabIndex = 106;
            this.lblAutorizacionFechaCreacion.Text = "Fecha Creacion";
            // 
            // txtAutorizacionFechaCreacion
            // 
            this.txtAutorizacionFechaCreacion.Location = new System.Drawing.Point(298, 163);
            this.txtAutorizacionFechaCreacion.Name = "txtAutorizacionFechaCreacion";
            this.txtAutorizacionFechaCreacion.Size = new System.Drawing.Size(70, 20);
            this.txtAutorizacionFechaCreacion.TabIndex = 14;
            // 
            // chkAutorizacionEstado
            // 
            this.chkAutorizacionEstado.AutoSize = true;
            this.chkAutorizacionEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizacionEstado.Location = new System.Drawing.Point(298, 191);
            this.chkAutorizacionEstado.Name = "chkAutorizacionEstado";
            this.chkAutorizacionEstado.Size = new System.Drawing.Size(56, 17);
            this.chkAutorizacionEstado.TabIndex = 16;
            this.chkAutorizacionEstado.Text = "Activo";
            this.chkAutorizacionEstado.UseVisualStyleBackColor = true;
            // 
            // chkAutorizacionDxAsociado
            // 
            this.chkAutorizacionDxAsociado.AutoSize = true;
            this.chkAutorizacionDxAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizacionDxAsociado.Location = new System.Drawing.Point(72, 166);
            this.chkAutorizacionDxAsociado.Name = "chkAutorizacionDxAsociado";
            this.chkAutorizacionDxAsociado.Size = new System.Drawing.Size(89, 17);
            this.chkAutorizacionDxAsociado.TabIndex = 7;
            this.chkAutorizacionDxAsociado.Text = "Dx. Asociado";
            this.chkAutorizacionDxAsociado.UseVisualStyleBackColor = true;
            // 
            // chkAutorizacionAdicional
            // 
            this.chkAutorizacionAdicional.AutoSize = true;
            this.chkAutorizacionAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizacionAdicional.Location = new System.Drawing.Point(72, 141);
            this.chkAutorizacionAdicional.Name = "chkAutorizacionAdicional";
            this.chkAutorizacionAdicional.Size = new System.Drawing.Size(69, 17);
            this.chkAutorizacionAdicional.TabIndex = 6;
            this.chkAutorizacionAdicional.Text = "Adicional";
            this.chkAutorizacionAdicional.UseVisualStyleBackColor = true;
            // 
            // chkAutorizacionControlaCantidad
            // 
            this.chkAutorizacionControlaCantidad.AutoSize = true;
            this.chkAutorizacionControlaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutorizacionControlaCantidad.Location = new System.Drawing.Point(72, 191);
            this.chkAutorizacionControlaCantidad.Name = "chkAutorizacionControlaCantidad";
            this.chkAutorizacionControlaCantidad.Size = new System.Drawing.Size(110, 17);
            this.chkAutorizacionControlaCantidad.TabIndex = 8;
            this.chkAutorizacionControlaCantidad.Text = "Controla Cantidad";
            this.chkAutorizacionControlaCantidad.UseVisualStyleBackColor = true;
            // 
            // txtAutorizacionFecha
            // 
            this.txtAutorizacionFecha.Location = new System.Drawing.Point(72, 63);
            this.txtAutorizacionFecha.Name = "txtAutorizacionFecha";
            this.txtAutorizacionFecha.Size = new System.Drawing.Size(70, 20);
            this.txtAutorizacionFecha.TabIndex = 3;
            this.txtAutorizacionFecha.TabStop = false;
            this.txtAutorizacionFecha.TextChanged += new System.EventHandler(this.txtAutorizacionFecha_TextChanged);
            this.txtAutorizacionFecha.Validating += new System.ComponentModel.CancelEventHandler(this.txtAutorizacionFecha_Validating);
            this.txtAutorizacionFecha.Validated += new System.EventHandler(this.txtAutorizacionFecha_Validated);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.toolStripSeparator1,
            this.tsBtnLimpiar,
            this.toolStripSeparator2,
            this.tsBtnRechazar,
            this.toolStripSeparator3,
            this.tsBtnAnular});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGuardar.Image")));
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsBtnGuardar.Text = "Guardar";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
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
            // tsBtnRechazar
            // 
            this.tsBtnRechazar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRechazar.Image")));
            this.tsBtnRechazar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRechazar.Name = "tsBtnRechazar";
            this.tsBtnRechazar.Size = new System.Drawing.Size(74, 22);
            this.tsBtnRechazar.Text = "Rechazar";
            this.tsBtnRechazar.Click += new System.EventHandler(this.tsBtnRechazar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnAnular
            // 
            this.tsBtnAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAnular.Image")));
            this.tsBtnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAnular.Name = "tsBtnAnular";
            this.tsBtnAnular.Size = new System.Drawing.Size(62, 22);
            this.tsBtnAnular.Text = "Anular";
            this.tsBtnAnular.Click += new System.EventHandler(this.tsBtnAnular_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmGestionarAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpAutorizacion);
            this.Controls.Add(this.grpTratamiento);
            this.Controls.Add(this.grpPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarAutorizaciones";
            this.Text = "Gestión de Autorizaciones";
            this.Load += new System.EventHandler(this.FrmGestionarAutorizaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGestionarAutorizaciones_KeyDown);
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpTratamiento.ResumeLayout(false);
            this.grpTratamiento.PerformLayout();
            this.grpAutorizacion.ResumeLayout(false);
            this.grpAutorizacion.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.TextBox txtPacienteId;
        private System.Windows.Forms.TextBox txtPacienteNombres;
        private System.Windows.Forms.Label lblPacienteNombres;
        private System.Windows.Forms.GroupBox grpTratamiento;
        private System.Windows.Forms.Label lblTratamientoCategoria;
        private System.Windows.Forms.Label lblTratamientoFase;
        private System.Windows.Forms.Label lblTratamientoEstadio;
        private System.Windows.Forms.TextBox txtAutorizacionFechaVigencia;
        private System.Windows.Forms.Label lblAutorizacionModalidad;
        private System.Windows.Forms.Label lblAutorizacionFechaVigencia;
        private System.Windows.Forms.DateTimePicker dtpAutorizacionFecha;
        private System.Windows.Forms.Label lblAutorizacionFecha;
        private System.Windows.Forms.Label lblAutorizacionTipo;
        private System.Windows.Forms.ComboBox cboAutorizacionModalidad;
        private System.Windows.Forms.ComboBox cboTratamientoTipo;
        private System.Windows.Forms.Label lblAutorizacionEstablecimiento;
        private System.Windows.Forms.ComboBox cboAutorizacionEstablecimiento;
        private System.Windows.Forms.GroupBox grpAutorizacion;
        private System.Windows.Forms.Label lblAutorizacionFechaCreacion;
        private System.Windows.Forms.TextBox txtAutorizacionFechaCreacion;
        private System.Windows.Forms.CheckBox chkAutorizacionDxAsociado;
        private System.Windows.Forms.CheckBox chkAutorizacionAdicional;
        private System.Windows.Forms.CheckBox chkAutorizacionControlaCantidad;
        private System.Windows.Forms.Label lblAutorizacionDescripcion;
        private System.Windows.Forms.TextBox txtAutorizacionDescripcion;
        private System.Windows.Forms.CheckBox chkAutorizacionEstado;
        private System.Windows.Forms.Button btnAbrirSelectorTratamiento;
        private System.Windows.Forms.Label lblTratamientoId;
        private System.Windows.Forms.TextBox txtTratamientoId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnAnular;
        private System.Windows.Forms.TextBox txtTratamientoVersion;
        private System.Windows.Forms.Label lblTratamientoVersion;
        private System.Windows.Forms.Button btnAbrirSelectorPaciente;
        private System.Windows.Forms.CheckBox chkAutorizacionAnulado;
        private System.Windows.Forms.Label lblAutorizacionUsuarioCreacion;
        private System.Windows.Forms.TextBox txtAutorizacionUsuarioCreacion;
        private System.Windows.Forms.Label lblAutorizacionObservacion;
        private System.Windows.Forms.TextBox txtAutorizacionObservacion;
        private System.Windows.Forms.Label lblAutorizacionFechaSolicitud;
        private System.Windows.Forms.TextBox txtAutorizacionFechaSolicitud;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpAutorizacionFechaSolicitud;
        private System.Windows.Forms.TextBox txtAutorizacionFecha;
        private System.Windows.Forms.ComboBox cboTratamientoEstadio;
        private System.Windows.Forms.ComboBox cboTratamientoFase;
        private System.Windows.Forms.ComboBox cboTratamientoCategoria;
        private System.Windows.Forms.TextBox txtTratamientoVigencia;
        private System.Windows.Forms.Label lblTratamientoVigencia;
        private System.Windows.Forms.Label lblAutorizacionCodigo;
        private System.Windows.Forms.TextBox txtAutorizacionCodigo;
        private System.Windows.Forms.Label lblAutorizacionNumeroSolicitud;
        private System.Windows.Forms.TextBox txtAutorizacionNumeroSolicitud;
        private System.Windows.Forms.ToolStripButton tsBtnRechazar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblPacienteId;
        private System.Windows.Forms.Label lblTratamientoMonto;
        private System.Windows.Forms.TextBox txtTratamientoMonto;
        private System.Windows.Forms.Button btnAutorizacionLimpiarFecha;
        private System.Windows.Forms.Button btnAutorizacionLimpiarFechaSolicitud;
    }
}