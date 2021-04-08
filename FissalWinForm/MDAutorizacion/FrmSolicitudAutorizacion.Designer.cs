namespace FissalWinForm
{
    partial class FrmSolicitudAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudAutorizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPacienteNumeroDocumento = new System.Windows.Forms.Label();
            this.txtPacienteNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtPacienteApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblPacienteApellidoPaterno = new System.Windows.Forms.Label();
            this.txtPacienteApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblPacienteApellidoMaterno = new System.Windows.Forms.Label();
            this.txtPacienteNombres = new System.Windows.Forms.TextBox();
            this.lblPacienteNombres = new System.Windows.Forms.Label();
            this.txtPacienteOtrosNombres = new System.Windows.Forms.TextBox();
            this.lblPacienteOtrosNombres = new System.Windows.Forms.Label();
            this.lblPacienteTipoRegimen = new System.Windows.Forms.Label();
            this.cboPacienteTipoRegimen = new System.Windows.Forms.ComboBox();
            this.cboPacienteTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblPacienteTipoDocumento = new System.Windows.Forms.Label();
            this.lblPacienteFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpPacienteFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPacienteFechaNacimiento = new System.Windows.Forms.TextBox();
            this.cboPacienteSexo = new System.Windows.Forms.ComboBox();
            this.lblPacienteSexo = new System.Windows.Forms.Label();
            this.txtPacienteHistoria = new System.Windows.Forms.TextBox();
            this.lblPacienteHistoria = new System.Windows.Forms.Label();
            this.lblPacienteFechaDefuncion = new System.Windows.Forms.Label();
            this.dtpPacienteFechaDefuncion = new System.Windows.Forms.DateTimePicker();
            this.txtPacienteFechaDefuncion = new System.Windows.Forms.TextBox();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.txtFechaSolicitud = new System.Windows.Forms.TextBox();
            this.txtUsuarioSolicitante = new System.Windows.Forms.TextBox();
            this.lblUsuarioSolicitante = new System.Windows.Forms.Label();
            this.grpBoxPaciente = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFechaDefuncion = new System.Windows.Forms.Button();
            this.btnLimpiarFechaNacimiento = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkAsegurado = new System.Windows.Forms.CheckBox();
            this.chkValidadoFissal = new System.Windows.Forms.CheckBox();
            this.chkValidadoSis = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnRechazar = new System.Windows.Forms.ToolStripButton();
            this.grpBoxDatosSolicitud = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUsuarioProcesa = new System.Windows.Forms.TextBox();
            this.lblUsuarioProcesa = new System.Windows.Forms.Label();
            this.lblNumeroSolicitud = new System.Windows.Forms.Label();
            this.txtNumeroSolicitud = new System.Windows.Forms.TextBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.grpBoxTratamientos = new System.Windows.Forms.GroupBox();
            this.dgvDetallesSolicitudes = new System.Windows.Forms.DataGridView();
            this.DetalleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Procesado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha_Procesado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDgvDetalleSolicitudes = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxPaciente.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpBoxDatosSolicitud.SuspendLayout();
            this.grpBoxTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacienteNumeroDocumento
            // 
            this.lblPacienteNumeroDocumento.AutoSize = true;
            this.lblPacienteNumeroDocumento.Location = new System.Drawing.Point(12, 44);
            this.lblPacienteNumeroDocumento.Name = "lblPacienteNumeroDocumento";
            this.lblPacienteNumeroDocumento.Size = new System.Drawing.Size(84, 13);
            this.lblPacienteNumeroDocumento.TabIndex = 0;
            this.lblPacienteNumeroDocumento.Text = "* N° Documento";
            // 
            // txtPacienteNumeroDocumento
            // 
            this.txtPacienteNumeroDocumento.Location = new System.Drawing.Point(97, 41);
            this.txtPacienteNumeroDocumento.Name = "txtPacienteNumeroDocumento";
            this.txtPacienteNumeroDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtPacienteNumeroDocumento.TabIndex = 1;
            this.txtPacienteNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteNumeroDocumento_KeyPress);
            this.txtPacienteNumeroDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteNumeroDocumento_Validating);
            this.txtPacienteNumeroDocumento.Validated += new System.EventHandler(this.txtPacienteNumeroDocumento_Validated);
            // 
            // txtPacienteApellidoPaterno
            // 
            this.txtPacienteApellidoPaterno.Location = new System.Drawing.Point(352, 16);
            this.txtPacienteApellidoPaterno.Name = "txtPacienteApellidoPaterno";
            this.txtPacienteApellidoPaterno.Size = new System.Drawing.Size(180, 20);
            this.txtPacienteApellidoPaterno.TabIndex = 5;
            this.txtPacienteApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteApellidoPaterno_KeyPress);
            this.txtPacienteApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteApellidoPaterno_Validating);
            this.txtPacienteApellidoPaterno.Validated += new System.EventHandler(this.txtPacienteApellidoPaterno_Validated);
            // 
            // lblPacienteApellidoPaterno
            // 
            this.lblPacienteApellidoPaterno.AutoSize = true;
            this.lblPacienteApellidoPaterno.Location = new System.Drawing.Point(258, 19);
            this.lblPacienteApellidoPaterno.Name = "lblPacienteApellidoPaterno";
            this.lblPacienteApellidoPaterno.Size = new System.Drawing.Size(91, 13);
            this.lblPacienteApellidoPaterno.TabIndex = 2;
            this.lblPacienteApellidoPaterno.Text = "* Apellido Paterno";
            // 
            // txtPacienteApellidoMaterno
            // 
            this.txtPacienteApellidoMaterno.Location = new System.Drawing.Point(352, 41);
            this.txtPacienteApellidoMaterno.Name = "txtPacienteApellidoMaterno";
            this.txtPacienteApellidoMaterno.Size = new System.Drawing.Size(180, 20);
            this.txtPacienteApellidoMaterno.TabIndex = 6;
            this.txtPacienteApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteApellidoMaterno_KeyPress);
            this.txtPacienteApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteApellidoMaterno_Validating);
            this.txtPacienteApellidoMaterno.Validated += new System.EventHandler(this.txtPacienteApellidoMaterno_Validated);
            // 
            // lblPacienteApellidoMaterno
            // 
            this.lblPacienteApellidoMaterno.AutoSize = true;
            this.lblPacienteApellidoMaterno.Location = new System.Drawing.Point(258, 44);
            this.lblPacienteApellidoMaterno.Name = "lblPacienteApellidoMaterno";
            this.lblPacienteApellidoMaterno.Size = new System.Drawing.Size(93, 13);
            this.lblPacienteApellidoMaterno.TabIndex = 4;
            this.lblPacienteApellidoMaterno.Text = "* Apellido Materno";
            // 
            // txtPacienteNombres
            // 
            this.txtPacienteNombres.Location = new System.Drawing.Point(352, 66);
            this.txtPacienteNombres.Name = "txtPacienteNombres";
            this.txtPacienteNombres.Size = new System.Drawing.Size(180, 20);
            this.txtPacienteNombres.TabIndex = 7;
            this.txtPacienteNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteNombres_KeyPress);
            this.txtPacienteNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteNombres_Validating);
            this.txtPacienteNombres.Validated += new System.EventHandler(this.txtPacienteNombres_Validated);
            // 
            // lblPacienteNombres
            // 
            this.lblPacienteNombres.AutoSize = true;
            this.lblPacienteNombres.Location = new System.Drawing.Point(258, 69);
            this.lblPacienteNombres.Name = "lblPacienteNombres";
            this.lblPacienteNombres.Size = new System.Drawing.Size(56, 13);
            this.lblPacienteNombres.TabIndex = 6;
            this.lblPacienteNombres.Text = "* Nombres";
            // 
            // txtPacienteOtrosNombres
            // 
            this.txtPacienteOtrosNombres.Location = new System.Drawing.Point(352, 91);
            this.txtPacienteOtrosNombres.Name = "txtPacienteOtrosNombres";
            this.txtPacienteOtrosNombres.Size = new System.Drawing.Size(180, 20);
            this.txtPacienteOtrosNombres.TabIndex = 8;
            this.txtPacienteOtrosNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteOtrosNombres_KeyPress);
            // 
            // lblPacienteOtrosNombres
            // 
            this.lblPacienteOtrosNombres.AutoSize = true;
            this.lblPacienteOtrosNombres.Location = new System.Drawing.Point(264, 94);
            this.lblPacienteOtrosNombres.Name = "lblPacienteOtrosNombres";
            this.lblPacienteOtrosNombres.Size = new System.Drawing.Size(77, 13);
            this.lblPacienteOtrosNombres.TabIndex = 8;
            this.lblPacienteOtrosNombres.Text = "Otros Nombres";
            // 
            // lblPacienteTipoRegimen
            // 
            this.lblPacienteTipoRegimen.AutoSize = true;
            this.lblPacienteTipoRegimen.Location = new System.Drawing.Point(573, 19);
            this.lblPacienteTipoRegimen.Name = "lblPacienteTipoRegimen";
            this.lblPacienteTipoRegimen.Size = new System.Drawing.Size(80, 13);
            this.lblPacienteTipoRegimen.TabIndex = 10;
            this.lblPacienteTipoRegimen.Text = "* Tipo Regimen";
            // 
            // cboPacienteTipoRegimen
            // 
            this.cboPacienteTipoRegimen.FormattingEnabled = true;
            this.cboPacienteTipoRegimen.Location = new System.Drawing.Point(657, 16);
            this.cboPacienteTipoRegimen.Name = "cboPacienteTipoRegimen";
            this.cboPacienteTipoRegimen.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteTipoRegimen.TabIndex = 9;
            this.cboPacienteTipoRegimen.Validating += new System.ComponentModel.CancelEventHandler(this.cboPacienteTipoRegimen_Validating);
            this.cboPacienteTipoRegimen.Validated += new System.EventHandler(this.cboPacienteTipoRegimen_Validated);
            // 
            // cboPacienteTipoDocumento
            // 
            this.cboPacienteTipoDocumento.FormattingEnabled = true;
            this.cboPacienteTipoDocumento.Location = new System.Drawing.Point(97, 16);
            this.cboPacienteTipoDocumento.Name = "cboPacienteTipoDocumento";
            this.cboPacienteTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteTipoDocumento.TabIndex = 0;
            this.cboPacienteTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.cboPacienteTipoDocumento_Validating);
            this.cboPacienteTipoDocumento.Validated += new System.EventHandler(this.cboPacienteTipoDocumento_Validated);
            // 
            // lblPacienteTipoDocumento
            // 
            this.lblPacienteTipoDocumento.AutoSize = true;
            this.lblPacienteTipoDocumento.Location = new System.Drawing.Point(12, 19);
            this.lblPacienteTipoDocumento.Name = "lblPacienteTipoDocumento";
            this.lblPacienteTipoDocumento.Size = new System.Drawing.Size(82, 13);
            this.lblPacienteTipoDocumento.TabIndex = 12;
            this.lblPacienteTipoDocumento.Text = "* T. Documento";
            // 
            // lblPacienteFechaNacimiento
            // 
            this.lblPacienteFechaNacimiento.AutoSize = true;
            this.lblPacienteFechaNacimiento.Location = new System.Drawing.Point(12, 94);
            this.lblPacienteFechaNacimiento.Name = "lblPacienteFechaNacimiento";
            this.lblPacienteFechaNacimiento.Size = new System.Drawing.Size(79, 13);
            this.lblPacienteFechaNacimiento.TabIndex = 89;
            this.lblPacienteFechaNacimiento.Text = "* F. Nacimiento";
            // 
            // dtpPacienteFechaNacimiento
            // 
            this.dtpPacienteFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPacienteFechaNacimiento.Location = new System.Drawing.Point(171, 91);
            this.dtpPacienteFechaNacimiento.Name = "dtpPacienteFechaNacimiento";
            this.dtpPacienteFechaNacimiento.Size = new System.Drawing.Size(20, 20);
            this.dtpPacienteFechaNacimiento.TabIndex = 3;
            this.dtpPacienteFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpPacienteFechaNacimiento_ValueChanged);
            // 
            // txtPacienteFechaNacimiento
            // 
            this.txtPacienteFechaNacimiento.Location = new System.Drawing.Point(97, 91);
            this.txtPacienteFechaNacimiento.Name = "txtPacienteFechaNacimiento";
            this.txtPacienteFechaNacimiento.Size = new System.Drawing.Size(70, 20);
            this.txtPacienteFechaNacimiento.TabIndex = 4;
            this.txtPacienteFechaNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteFechaNacimiento_Validating);
            this.txtPacienteFechaNacimiento.Validated += new System.EventHandler(this.txtPacienteFechaNacimiento_Validated);
            // 
            // cboPacienteSexo
            // 
            this.cboPacienteSexo.FormattingEnabled = true;
            this.cboPacienteSexo.Location = new System.Drawing.Point(97, 66);
            this.cboPacienteSexo.Name = "cboPacienteSexo";
            this.cboPacienteSexo.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteSexo.TabIndex = 2;
            this.cboPacienteSexo.Validating += new System.ComponentModel.CancelEventHandler(this.cboPacienteSexo_Validating);
            this.cboPacienteSexo.Validated += new System.EventHandler(this.cboPacienteSexo_Validated);
            // 
            // lblPacienteSexo
            // 
            this.lblPacienteSexo.AutoSize = true;
            this.lblPacienteSexo.Location = new System.Drawing.Point(12, 69);
            this.lblPacienteSexo.Name = "lblPacienteSexo";
            this.lblPacienteSexo.Size = new System.Drawing.Size(38, 13);
            this.lblPacienteSexo.TabIndex = 90;
            this.lblPacienteSexo.Text = "* Sexo";
            // 
            // txtPacienteHistoria
            // 
            this.txtPacienteHistoria.Location = new System.Drawing.Point(657, 41);
            this.txtPacienteHistoria.Name = "txtPacienteHistoria";
            this.txtPacienteHistoria.Size = new System.Drawing.Size(121, 20);
            this.txtPacienteHistoria.TabIndex = 10;
            this.txtPacienteHistoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteHistoria_KeyPress);
            this.txtPacienteHistoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteHistoria_Validating);
            this.txtPacienteHistoria.Validated += new System.EventHandler(this.txtPacienteHistoria_Validated);
            // 
            // lblPacienteHistoria
            // 
            this.lblPacienteHistoria.AutoSize = true;
            this.lblPacienteHistoria.Location = new System.Drawing.Point(573, 44);
            this.lblPacienteHistoria.Name = "lblPacienteHistoria";
            this.lblPacienteHistoria.Size = new System.Drawing.Size(49, 13);
            this.lblPacienteHistoria.TabIndex = 92;
            this.lblPacienteHistoria.Text = "* Historia";
            // 
            // lblPacienteFechaDefuncion
            // 
            this.lblPacienteFechaDefuncion.AutoSize = true;
            this.lblPacienteFechaDefuncion.Location = new System.Drawing.Point(573, 69);
            this.lblPacienteFechaDefuncion.Name = "lblPacienteFechaDefuncion";
            this.lblPacienteFechaDefuncion.Size = new System.Drawing.Size(68, 13);
            this.lblPacienteFechaDefuncion.TabIndex = 96;
            this.lblPacienteFechaDefuncion.Text = "F. Defuncion";
            // 
            // dtpPacienteFechaDefuncion
            // 
            this.dtpPacienteFechaDefuncion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPacienteFechaDefuncion.Location = new System.Drawing.Point(733, 66);
            this.dtpPacienteFechaDefuncion.Name = "dtpPacienteFechaDefuncion";
            this.dtpPacienteFechaDefuncion.Size = new System.Drawing.Size(20, 20);
            this.dtpPacienteFechaDefuncion.TabIndex = 11;
            this.dtpPacienteFechaDefuncion.ValueChanged += new System.EventHandler(this.dtpPacienteFechaDefuncion_ValueChanged);
            // 
            // txtPacienteFechaDefuncion
            // 
            this.txtPacienteFechaDefuncion.Location = new System.Drawing.Point(657, 66);
            this.txtPacienteFechaDefuncion.Name = "txtPacienteFechaDefuncion";
            this.txtPacienteFechaDefuncion.Size = new System.Drawing.Size(70, 20);
            this.txtPacienteFechaDefuncion.TabIndex = 12;
            this.txtPacienteFechaDefuncion.Validating += new System.ComponentModel.CancelEventHandler(this.txtPacienteFechaDefuncion_Validating);
            this.txtPacienteFechaDefuncion.Validated += new System.EventHandler(this.txtPacienteFechaDefuncion_Validated);
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(281, 19);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(81, 13);
            this.lblEstablecimiento.TabIndex = 97;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(12, 19);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(59, 13);
            this.lblFechaSolicitud.TabIndex = 101;
            this.lblFechaSolicitud.Text = "F. Solicitud";
            // 
            // txtFechaSolicitud
            // 
            this.txtFechaSolicitud.Location = new System.Drawing.Point(74, 16);
            this.txtFechaSolicitud.Name = "txtFechaSolicitud";
            this.txtFechaSolicitud.Size = new System.Drawing.Size(70, 20);
            this.txtFechaSolicitud.TabIndex = 0;
            // 
            // txtUsuarioSolicitante
            // 
            this.txtUsuarioSolicitante.Location = new System.Drawing.Point(74, 41);
            this.txtUsuarioSolicitante.Name = "txtUsuarioSolicitante";
            this.txtUsuarioSolicitante.Size = new System.Drawing.Size(70, 20);
            this.txtUsuarioSolicitante.TabIndex = 1;
            // 
            // lblUsuarioSolicitante
            // 
            this.lblUsuarioSolicitante.AutoSize = true;
            this.lblUsuarioSolicitante.Location = new System.Drawing.Point(12, 44);
            this.lblUsuarioSolicitante.Name = "lblUsuarioSolicitante";
            this.lblUsuarioSolicitante.Size = new System.Drawing.Size(56, 13);
            this.lblUsuarioSolicitante.TabIndex = 102;
            this.lblUsuarioSolicitante.Text = "Solicitante";
            // 
            // grpBoxPaciente
            // 
            this.grpBoxPaciente.Controls.Add(this.btnLimpiarFechaDefuncion);
            this.grpBoxPaciente.Controls.Add(this.btnLimpiarFechaNacimiento);
            this.grpBoxPaciente.Controls.Add(this.chkActivo);
            this.grpBoxPaciente.Controls.Add(this.chkAsegurado);
            this.grpBoxPaciente.Controls.Add(this.chkValidadoFissal);
            this.grpBoxPaciente.Controls.Add(this.chkValidadoSis);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteNumeroDocumento);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteNumeroDocumento);
            this.grpBoxPaciente.Controls.Add(this.cboPacienteTipoDocumento);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteTipoDocumento);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteApellidoPaterno);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteApellidoPaterno);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteApellidoMaterno);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteApellidoMaterno);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteNombres);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteNombres);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteOtrosNombres);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteOtrosNombres);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteFechaNacimiento);
            this.grpBoxPaciente.Controls.Add(this.dtpPacienteFechaDefuncion);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteFechaDefuncion);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteFechaDefuncion);
            this.grpBoxPaciente.Controls.Add(this.dtpPacienteFechaNacimiento);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteFechaNacimiento);
            this.grpBoxPaciente.Controls.Add(this.cboPacienteSexo);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteSexo);
            this.grpBoxPaciente.Controls.Add(this.txtPacienteHistoria);
            this.grpBoxPaciente.Controls.Add(this.cboPacienteTipoRegimen);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteHistoria);
            this.grpBoxPaciente.Controls.Add(this.lblPacienteTipoRegimen);
            this.grpBoxPaciente.Location = new System.Drawing.Point(12, 108);
            this.grpBoxPaciente.Name = "grpBoxPaciente";
            this.grpBoxPaciente.Size = new System.Drawing.Size(984, 122);
            this.grpBoxPaciente.TabIndex = 1;
            this.grpBoxPaciente.TabStop = false;
            this.grpBoxPaciente.Text = "Paciente";
            // 
            // btnLimpiarFechaDefuncion
            // 
            this.btnLimpiarFechaDefuncion.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFechaDefuncion.Image")));
            this.btnLimpiarFechaDefuncion.Location = new System.Drawing.Point(756, 65);
            this.btnLimpiarFechaDefuncion.Name = "btnLimpiarFechaDefuncion";
            this.btnLimpiarFechaDefuncion.Size = new System.Drawing.Size(22, 22);
            this.btnLimpiarFechaDefuncion.TabIndex = 98;
            this.btnLimpiarFechaDefuncion.UseVisualStyleBackColor = true;
            this.btnLimpiarFechaDefuncion.Click += new System.EventHandler(this.btnLimpiarFechaDefuncion_Click);
            // 
            // btnLimpiarFechaNacimiento
            // 
            this.btnLimpiarFechaNacimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFechaNacimiento.Image")));
            this.btnLimpiarFechaNacimiento.Location = new System.Drawing.Point(197, 90);
            this.btnLimpiarFechaNacimiento.Name = "btnLimpiarFechaNacimiento";
            this.btnLimpiarFechaNacimiento.Size = new System.Drawing.Size(22, 22);
            this.btnLimpiarFechaNacimiento.TabIndex = 97;
            this.btnLimpiarFechaNacimiento.UseVisualStyleBackColor = true;
            this.btnLimpiarFechaNacimiento.Click += new System.EventHandler(this.btnLimpiarFechaNacimiento_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(702, 94);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(76, 17);
            this.chkActivo.TabIndex = 14;
            this.chkActivo.Text = "Activo SIS";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // chkAsegurado
            // 
            this.chkAsegurado.AutoSize = true;
            this.chkAsegurado.Location = new System.Drawing.Point(576, 94);
            this.chkAsegurado.Name = "chkAsegurado";
            this.chkAsegurado.Size = new System.Drawing.Size(97, 17);
            this.chkAsegurado.TabIndex = 13;
            this.chkAsegurado.Text = "Asegurado SIS";
            this.chkAsegurado.UseVisualStyleBackColor = true;
            this.chkAsegurado.Validating += new System.ComponentModel.CancelEventHandler(this.chkAsegurado_Validating);
            this.chkAsegurado.Validated += new System.EventHandler(this.chkAsegurado_Validated);
            // 
            // chkValidadoFissal
            // 
            this.chkValidadoFissal.AutoSize = true;
            this.chkValidadoFissal.Location = new System.Drawing.Point(830, 44);
            this.chkValidadoFissal.Name = "chkValidadoFissal";
            this.chkValidadoFissal.Size = new System.Drawing.Size(106, 17);
            this.chkValidadoFissal.TabIndex = 14;
            this.chkValidadoFissal.Text = "Validado FISSAL";
            this.chkValidadoFissal.UseVisualStyleBackColor = true;
            // 
            // chkValidadoSis
            // 
            this.chkValidadoSis.AutoSize = true;
            this.chkValidadoSis.Location = new System.Drawing.Point(830, 20);
            this.chkValidadoSis.Name = "chkValidadoSis";
            this.chkValidadoSis.Size = new System.Drawing.Size(87, 17);
            this.chkValidadoSis.TabIndex = 13;
            this.chkValidadoSis.Text = "Validado SIS";
            this.chkValidadoSis.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.toolStripSeparator1,
            this.tsBtnRechazar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
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
            // tsBtnRechazar
            // 
            this.tsBtnRechazar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRechazar.Image")));
            this.tsBtnRechazar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRechazar.Name = "tsBtnRechazar";
            this.tsBtnRechazar.Size = new System.Drawing.Size(74, 22);
            this.tsBtnRechazar.Text = "Rechazar";
            this.tsBtnRechazar.Click += new System.EventHandler(this.tsBtnRechazar_Click);
            // 
            // grpBoxDatosSolicitud
            // 
            this.grpBoxDatosSolicitud.Controls.Add(this.lblDescripcion);
            this.grpBoxDatosSolicitud.Controls.Add(this.txtDescripcion);
            this.grpBoxDatosSolicitud.Controls.Add(this.txtUsuarioProcesa);
            this.grpBoxDatosSolicitud.Controls.Add(this.lblUsuarioProcesa);
            this.grpBoxDatosSolicitud.Controls.Add(this.lblNumeroSolicitud);
            this.grpBoxDatosSolicitud.Controls.Add(this.txtNumeroSolicitud);
            this.grpBoxDatosSolicitud.Controls.Add(this.cboEstablecimiento);
            this.grpBoxDatosSolicitud.Controls.Add(this.lblEstablecimiento);
            this.grpBoxDatosSolicitud.Controls.Add(this.txtUsuarioSolicitante);
            this.grpBoxDatosSolicitud.Controls.Add(this.lblFechaSolicitud);
            this.grpBoxDatosSolicitud.Controls.Add(this.txtFechaSolicitud);
            this.grpBoxDatosSolicitud.Controls.Add(this.lblUsuarioSolicitante);
            this.grpBoxDatosSolicitud.Location = new System.Drawing.Point(12, 28);
            this.grpBoxDatosSolicitud.Name = "grpBoxDatosSolicitud";
            this.grpBoxDatosSolicitud.Size = new System.Drawing.Size(984, 74);
            this.grpBoxDatosSolicitud.TabIndex = 0;
            this.grpBoxDatosSolicitud.TabStop = false;
            this.grpBoxDatosSolicitud.Text = "Datos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(281, 44);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 114;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(365, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(600, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtUsuarioProcesa
            // 
            this.txtUsuarioProcesa.Location = new System.Drawing.Point(202, 41);
            this.txtUsuarioProcesa.Name = "txtUsuarioProcesa";
            this.txtUsuarioProcesa.Size = new System.Drawing.Size(70, 20);
            this.txtUsuarioProcesa.TabIndex = 3;
            // 
            // lblUsuarioProcesa
            // 
            this.lblUsuarioProcesa.AutoSize = true;
            this.lblUsuarioProcesa.Location = new System.Drawing.Point(155, 44);
            this.lblUsuarioProcesa.Name = "lblUsuarioProcesa";
            this.lblUsuarioProcesa.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioProcesa.TabIndex = 111;
            this.lblUsuarioProcesa.Text = "Atiende";
            // 
            // lblNumeroSolicitud
            // 
            this.lblNumeroSolicitud.AutoSize = true;
            this.lblNumeroSolicitud.Location = new System.Drawing.Point(155, 19);
            this.lblNumeroSolicitud.Name = "lblNumeroSolicitud";
            this.lblNumeroSolicitud.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroSolicitud.TabIndex = 108;
            this.lblNumeroSolicitud.Text = "Numero";
            // 
            // txtNumeroSolicitud
            // 
            this.txtNumeroSolicitud.Location = new System.Drawing.Point(202, 16);
            this.txtNumeroSolicitud.Name = "txtNumeroSolicitud";
            this.txtNumeroSolicitud.Size = new System.Drawing.Size(70, 20);
            this.txtNumeroSolicitud.TabIndex = 2;
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(365, 16);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(600, 21);
            this.cboEstablecimiento.TabIndex = 4;
            // 
            // grpBoxTratamientos
            // 
            this.grpBoxTratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTratamientos.Controls.Add(this.dgvDetallesSolicitudes);
            this.grpBoxTratamientos.Controls.Add(this.lblDgvDetalleSolicitudes);
            this.grpBoxTratamientos.Location = new System.Drawing.Point(12, 236);
            this.grpBoxTratamientos.Name = "grpBoxTratamientos";
            this.grpBoxTratamientos.Size = new System.Drawing.Size(984, 314);
            this.grpBoxTratamientos.TabIndex = 2;
            this.grpBoxTratamientos.TabStop = false;
            this.grpBoxTratamientos.Text = "Tratamientos";
            // 
            // dgvDetallesSolicitudes
            // 
            this.dgvDetallesSolicitudes.AllowUserToAddRows = false;
            this.dgvDetallesSolicitudes.AllowUserToDeleteRows = false;
            this.dgvDetallesSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleId,
            this.DescripcionTipoAutorizacion,
            this.DescripcionCategoria,
            this.DescripcionEstadio,
            this.DescripcionFase,
            this.Aprobado,
            this.Procesado,
            this.Fecha_Procesado,
            this.Observaciones});
            this.dgvDetallesSolicitudes.Location = new System.Drawing.Point(15, 19);
            this.dgvDetallesSolicitudes.Name = "dgvDetallesSolicitudes";
            this.dgvDetallesSolicitudes.ReadOnly = true;
            this.dgvDetallesSolicitudes.RowHeadersVisible = false;
            this.dgvDetallesSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesSolicitudes.Size = new System.Drawing.Size(950, 289);
            this.dgvDetallesSolicitudes.TabIndex = 0;
            this.dgvDetallesSolicitudes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesSolicitudes_CellDoubleClick);
            this.dgvDetallesSolicitudes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetallesSolicitudes_KeyDown);
            // 
            // DetalleId
            // 
            this.DetalleId.DataPropertyName = "DetalleId";
            this.DetalleId.HeaderText = "Nro";
            this.DetalleId.Name = "DetalleId";
            this.DetalleId.ReadOnly = true;
            this.DetalleId.Width = 30;
            // 
            // DescripcionTipoAutorizacion
            // 
            this.DescripcionTipoAutorizacion.DataPropertyName = "DescripcionTipoAutorizacion";
            this.DescripcionTipoAutorizacion.HeaderText = "T. Autorizacion";
            this.DescripcionTipoAutorizacion.Name = "DescripcionTipoAutorizacion";
            this.DescripcionTipoAutorizacion.ReadOnly = true;
            this.DescripcionTipoAutorizacion.Width = 105;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.DataPropertyName = "DescripcionCategoria";
            this.DescripcionCategoria.HeaderText = "Categoria";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            this.DescripcionCategoria.Width = 270;
            // 
            // DescripcionEstadio
            // 
            this.DescripcionEstadio.DataPropertyName = "DescripcionEstadio";
            this.DescripcionEstadio.HeaderText = "Estadio";
            this.DescripcionEstadio.Name = "DescripcionEstadio";
            this.DescripcionEstadio.ReadOnly = true;
            this.DescripcionEstadio.Width = 80;
            // 
            // DescripcionFase
            // 
            this.DescripcionFase.DataPropertyName = "DescripcionFase";
            this.DescripcionFase.HeaderText = "Fase";
            this.DescripcionFase.Name = "DescripcionFase";
            this.DescripcionFase.ReadOnly = true;
            this.DescripcionFase.Width = 150;
            // 
            // Aprobado
            // 
            this.Aprobado.DataPropertyName = "Aprobado";
            this.Aprobado.HeaderText = "Aprobado";
            this.Aprobado.Name = "Aprobado";
            this.Aprobado.ReadOnly = true;
            this.Aprobado.Width = 60;
            // 
            // Procesado
            // 
            this.Procesado.DataPropertyName = "Procesado";
            this.Procesado.HeaderText = "Procesado";
            this.Procesado.Name = "Procesado";
            this.Procesado.ReadOnly = true;
            this.Procesado.Width = 60;
            // 
            // Fecha_Procesado
            // 
            this.Fecha_Procesado.DataPropertyName = "Fecha_Procesado";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha_Procesado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Procesado.HeaderText = "Fecha Proc.";
            this.Fecha_Procesado.Name = "Fecha_Procesado";
            this.Fecha_Procesado.ReadOnly = true;
            this.Fecha_Procesado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha_Procesado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_Procesado.Width = 70;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 120;
            // 
            // lblDgvDetalleSolicitudes
            // 
            this.lblDgvDetalleSolicitudes.AutoSize = true;
            this.lblDgvDetalleSolicitudes.Location = new System.Drawing.Point(92, 45);
            this.lblDgvDetalleSolicitudes.Name = "lblDgvDetalleSolicitudes";
            this.lblDgvDetalleSolicitudes.Size = new System.Drawing.Size(155, 13);
            this.lblDgvDetalleSolicitudes.TabIndex = 0;
            this.lblDgvDetalleSolicitudes.Text = "No hay tratamientos registrados";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSolicitudAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.grpBoxTratamientos);
            this.Controls.Add(this.grpBoxDatosSolicitud);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpBoxPaciente);
            this.Name = "FrmSolicitudAutorizacion";
            this.Text = "Solicitud de Autorizacion";
            this.Load += new System.EventHandler(this.FrmSolicitudAutorizacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSolicitudAutorizacion_KeyDown);
            this.grpBoxPaciente.ResumeLayout(false);
            this.grpBoxPaciente.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBoxDatosSolicitud.ResumeLayout(false);
            this.grpBoxDatosSolicitud.PerformLayout();
            this.grpBoxTratamientos.ResumeLayout(false);
            this.grpBoxTratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacienteNumeroDocumento;
        private System.Windows.Forms.TextBox txtPacienteNumeroDocumento;
        private System.Windows.Forms.TextBox txtPacienteApellidoPaterno;
        private System.Windows.Forms.Label lblPacienteApellidoPaterno;
        private System.Windows.Forms.TextBox txtPacienteApellidoMaterno;
        private System.Windows.Forms.Label lblPacienteApellidoMaterno;
        private System.Windows.Forms.TextBox txtPacienteNombres;
        private System.Windows.Forms.Label lblPacienteNombres;
        private System.Windows.Forms.TextBox txtPacienteOtrosNombres;
        private System.Windows.Forms.Label lblPacienteOtrosNombres;
        private System.Windows.Forms.Label lblPacienteTipoRegimen;
        private System.Windows.Forms.ComboBox cboPacienteTipoRegimen;
        private System.Windows.Forms.ComboBox cboPacienteTipoDocumento;
        private System.Windows.Forms.Label lblPacienteTipoDocumento;
        private System.Windows.Forms.Label lblPacienteFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpPacienteFechaNacimiento;
        private System.Windows.Forms.TextBox txtPacienteFechaNacimiento;
        private System.Windows.Forms.ComboBox cboPacienteSexo;
        private System.Windows.Forms.Label lblPacienteSexo;
        private System.Windows.Forms.TextBox txtPacienteHistoria;
        private System.Windows.Forms.Label lblPacienteHistoria;
        private System.Windows.Forms.Label lblPacienteFechaDefuncion;
        private System.Windows.Forms.DateTimePicker dtpPacienteFechaDefuncion;
        private System.Windows.Forms.TextBox txtPacienteFechaDefuncion;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.TextBox txtFechaSolicitud;
        private System.Windows.Forms.TextBox txtUsuarioSolicitante;
        private System.Windows.Forms.Label lblUsuarioSolicitante;
        private System.Windows.Forms.GroupBox grpBoxPaciente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnRechazar;
        private System.Windows.Forms.GroupBox grpBoxDatosSolicitud;
        private System.Windows.Forms.GroupBox grpBoxTratamientos;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.DataGridView dgvDetallesSolicitudes;
        private System.Windows.Forms.Label lblDgvDetalleSolicitudes;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkAsegurado;
        private System.Windows.Forms.CheckBox chkValidadoFissal;
        private System.Windows.Forms.CheckBox chkValidadoSis;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNumeroSolicitud;
        private System.Windows.Forms.TextBox txtNumeroSolicitud;
        private System.Windows.Forms.TextBox txtUsuarioProcesa;
        private System.Windows.Forms.Label lblUsuarioProcesa;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionFase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aprobado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Procesado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Procesado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Button btnLimpiarFechaDefuncion;
        private System.Windows.Forms.Button btnLimpiarFechaNacimiento;
    }
}