namespace FissalWinForm
{
    partial class FrmBuscadorAutorizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscadorAutorizaciones));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.grpAutorizacion = new System.Windows.Forms.GroupBox();
            this.chkAnuladoNo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDiagnosticoAsociadoNo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDiagnosticoAsociadoSi = new System.Windows.Forms.CheckBox();
            this.chkAnuladoSi = new System.Windows.Forms.CheckBox();
            this.cboModalidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaVigenciaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVigenciaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCreacionHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacionDesde = new System.Windows.Forms.Label();
            this.txtFechaVigenciaHasta = new System.Windows.Forms.TextBox();
            this.lblFechaVigenciaHasta = new System.Windows.Forms.Label();
            this.dtpFechaCreacionDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVigenciaDesde = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.txtFechaVigenciaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaCreacionDesde = new System.Windows.Forms.TextBox();
            this.lblFechaCreacionHasta = new System.Windows.Forms.Label();
            this.txtFechaCreacionHasta = new System.Windows.Forms.TextBox();
            this.lblTipoAutorizacion = new System.Windows.Forms.Label();
            this.txtTipoAutorizacion = new System.Windows.Forms.TextBox();
            this.btnAbrirSelectorTipoAutorizacion = new System.Windows.Forms.Button();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblNumeroDocumentoPaciente = new System.Windows.Forms.Label();
            this.cboTipoDocPaciente = new System.Windows.Forms.ComboBox();
            this.txtNumeroDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.grpDiagnostico = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorEstadio = new System.Windows.Forms.Button();
            this.btnAbrirSelectorFase = new System.Windows.Forms.Button();
            this.btnAbrirSelectorCategoria = new System.Windows.Forms.Button();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.lblFase = new System.Windows.Forms.Label();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.btnAbrirSelectorEstablecimiento = new System.Windows.Forms.Button();
            this.grpEstablecimiento = new System.Windows.Forms.GroupBox();
            this.grpResultadosBuscador = new System.Windows.Forms.GroupBox();
            this.dgvAutorizaciones = new System.Windows.Forms.DataGridView();
            this.CodigoAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionlarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientenombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAutorizacion.SuspendLayout();
            this.grpPaciente.SuspendLayout();
            this.grpDiagnostico.SuspendLayout();
            this.grpEstablecimiento.SuspendLayout();
            this.grpResultadosBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizaciones)).BeginInit();
            this.stsStpBuscador.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 22);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 69;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(80, 19);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(150, 20);
            this.txtCategoria.TabIndex = 0;
            this.txtCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategoria_KeyDown);
            // 
            // grpAutorizacion
            // 
            this.grpAutorizacion.Controls.Add(this.chkAnuladoNo);
            this.grpAutorizacion.Controls.Add(this.label2);
            this.grpAutorizacion.Controls.Add(this.chkDiagnosticoAsociadoNo);
            this.grpAutorizacion.Controls.Add(this.label1);
            this.grpAutorizacion.Controls.Add(this.chkDiagnosticoAsociadoSi);
            this.grpAutorizacion.Controls.Add(this.chkAnuladoSi);
            this.grpAutorizacion.Controls.Add(this.cboModalidad);
            this.grpAutorizacion.Controls.Add(this.dtpFechaVigenciaHasta);
            this.grpAutorizacion.Controls.Add(this.dtpFechaVigenciaDesde);
            this.grpAutorizacion.Controls.Add(this.dtpFechaCreacionHasta);
            this.grpAutorizacion.Controls.Add(this.lblFechaCreacionDesde);
            this.grpAutorizacion.Controls.Add(this.txtFechaVigenciaHasta);
            this.grpAutorizacion.Controls.Add(this.lblFechaVigenciaHasta);
            this.grpAutorizacion.Controls.Add(this.dtpFechaCreacionDesde);
            this.grpAutorizacion.Controls.Add(this.lblFechaVigenciaDesde);
            this.grpAutorizacion.Controls.Add(this.lblModalidad);
            this.grpAutorizacion.Controls.Add(this.txtFechaVigenciaDesde);
            this.grpAutorizacion.Controls.Add(this.txtFechaCreacionDesde);
            this.grpAutorizacion.Controls.Add(this.lblFechaCreacionHasta);
            this.grpAutorizacion.Controls.Add(this.txtFechaCreacionHasta);
            this.grpAutorizacion.Location = new System.Drawing.Point(343, 28);
            this.grpAutorizacion.Name = "grpAutorizacion";
            this.grpAutorizacion.Size = new System.Drawing.Size(365, 130);
            this.grpAutorizacion.TabIndex = 2;
            this.grpAutorizacion.TabStop = false;
            this.grpAutorizacion.Text = "Autorizacion";
            // 
            // chkAnuladoNo
            // 
            this.chkAnuladoNo.AutoSize = true;
            this.chkAnuladoNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnuladoNo.Location = new System.Drawing.Point(303, 96);
            this.chkAnuladoNo.Name = "chkAnuladoNo";
            this.chkAnuladoNo.Size = new System.Drawing.Size(40, 17);
            this.chkAnuladoNo.TabIndex = 12;
            this.chkAnuladoNo.Text = "No";
            this.chkAnuladoNo.UseVisualStyleBackColor = true;
            this.chkAnuladoNo.CheckedChanged += new System.EventHandler(this.chkAnuladoNo_CheckedChanged);
            this.chkAnuladoNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAnuladoNo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Anulado";
            // 
            // chkDiagnosticoAsociadoNo
            // 
            this.chkDiagnosticoAsociadoNo.AutoSize = true;
            this.chkDiagnosticoAsociadoNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDiagnosticoAsociadoNo.Location = new System.Drawing.Point(161, 96);
            this.chkDiagnosticoAsociadoNo.Name = "chkDiagnosticoAsociadoNo";
            this.chkDiagnosticoAsociadoNo.Size = new System.Drawing.Size(40, 17);
            this.chkDiagnosticoAsociadoNo.TabIndex = 10;
            this.chkDiagnosticoAsociadoNo.Text = "No";
            this.chkDiagnosticoAsociadoNo.UseVisualStyleBackColor = true;
            this.chkDiagnosticoAsociadoNo.CheckedChanged += new System.EventHandler(this.chkDiagnosticoAsociadoNo_CheckedChanged);
            this.chkDiagnosticoAsociadoNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkDiagnosticoAsociadoNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Dx. Asociado";
            // 
            // chkDiagnosticoAsociadoSi
            // 
            this.chkDiagnosticoAsociadoSi.AutoSize = true;
            this.chkDiagnosticoAsociadoSi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDiagnosticoAsociadoSi.Location = new System.Drawing.Point(121, 96);
            this.chkDiagnosticoAsociadoSi.Name = "chkDiagnosticoAsociadoSi";
            this.chkDiagnosticoAsociadoSi.Size = new System.Drawing.Size(35, 17);
            this.chkDiagnosticoAsociadoSi.TabIndex = 9;
            this.chkDiagnosticoAsociadoSi.Text = "Si";
            this.chkDiagnosticoAsociadoSi.UseVisualStyleBackColor = true;
            this.chkDiagnosticoAsociadoSi.CheckedChanged += new System.EventHandler(this.chkDiagnosticoAsociadoSi_CheckedChanged);
            this.chkDiagnosticoAsociadoSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkDiagnosticoAsociadoSi_KeyDown);
            // 
            // chkAnuladoSi
            // 
            this.chkAnuladoSi.AutoSize = true;
            this.chkAnuladoSi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnuladoSi.Location = new System.Drawing.Point(262, 96);
            this.chkAnuladoSi.Name = "chkAnuladoSi";
            this.chkAnuladoSi.Size = new System.Drawing.Size(35, 17);
            this.chkAnuladoSi.TabIndex = 11;
            this.chkAnuladoSi.Text = "Si";
            this.chkAnuladoSi.UseVisualStyleBackColor = true;
            this.chkAnuladoSi.CheckedChanged += new System.EventHandler(this.chkAnuladoSi_CheckedChanged);
            this.chkAnuladoSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAnuladoSi_KeyDown);
            // 
            // cboModalidad
            // 
            this.cboModalidad.FormattingEnabled = true;
            this.cboModalidad.Location = new System.Drawing.Point(118, 19);
            this.cboModalidad.Name = "cboModalidad";
            this.cboModalidad.Size = new System.Drawing.Size(230, 21);
            this.cboModalidad.TabIndex = 0;
            this.cboModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboModalidad_KeyDown);
            // 
            // dtpFechaVigenciaHasta
            // 
            this.dtpFechaVigenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVigenciaHasta.Location = new System.Drawing.Point(328, 69);
            this.dtpFechaVigenciaHasta.Name = "dtpFechaVigenciaHasta";
            this.dtpFechaVigenciaHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaVigenciaHasta.TabIndex = 7;
            this.dtpFechaVigenciaHasta.ValueChanged += new System.EventHandler(this.dtpFechaVigenciaHasta_ValueChanged);
            // 
            // dtpFechaVigenciaDesde
            // 
            this.dtpFechaVigenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVigenciaDesde.Location = new System.Drawing.Point(191, 69);
            this.dtpFechaVigenciaDesde.Name = "dtpFechaVigenciaDesde";
            this.dtpFechaVigenciaDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaVigenciaDesde.TabIndex = 5;
            this.dtpFechaVigenciaDesde.ValueChanged += new System.EventHandler(this.dtpFechaVigenciaDesde_ValueChanged);
            // 
            // dtpFechaCreacionHasta
            // 
            this.dtpFechaCreacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacionHasta.Location = new System.Drawing.Point(328, 44);
            this.dtpFechaCreacionHasta.Name = "dtpFechaCreacionHasta";
            this.dtpFechaCreacionHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaCreacionHasta.TabIndex = 3;
            this.dtpFechaCreacionHasta.ValueChanged += new System.EventHandler(this.dtpFechaCreacionHasta_ValueChanged);
            // 
            // lblFechaCreacionDesde
            // 
            this.lblFechaCreacionDesde.AutoSize = true;
            this.lblFechaCreacionDesde.Location = new System.Drawing.Point(17, 47);
            this.lblFechaCreacionDesde.Name = "lblFechaCreacionDesde";
            this.lblFechaCreacionDesde.Size = new System.Drawing.Size(93, 13);
            this.lblFechaCreacionDesde.TabIndex = 86;
            this.lblFechaCreacionDesde.Text = "F. Creacion desde";
            // 
            // txtFechaVigenciaHasta
            // 
            this.txtFechaVigenciaHasta.Location = new System.Drawing.Point(255, 69);
            this.txtFechaVigenciaHasta.Name = "txtFechaVigenciaHasta";
            this.txtFechaVigenciaHasta.Size = new System.Drawing.Size(70, 20);
            this.txtFechaVigenciaHasta.TabIndex = 8;
            this.txtFechaVigenciaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaVigenciaHasta_KeyDown);
            this.txtFechaVigenciaHasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaVigenciaHasta_Validating);
            this.txtFechaVigenciaHasta.Validated += new System.EventHandler(this.txtFechaVigenciaHasta_Validated);
            // 
            // lblFechaVigenciaHasta
            // 
            this.lblFechaVigenciaHasta.AutoSize = true;
            this.lblFechaVigenciaHasta.Location = new System.Drawing.Point(215, 72);
            this.lblFechaVigenciaHasta.Name = "lblFechaVigenciaHasta";
            this.lblFechaVigenciaHasta.Size = new System.Drawing.Size(33, 13);
            this.lblFechaVigenciaHasta.TabIndex = 92;
            this.lblFechaVigenciaHasta.Text = "hasta";
            // 
            // dtpFechaCreacionDesde
            // 
            this.dtpFechaCreacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacionDesde.Location = new System.Drawing.Point(191, 44);
            this.dtpFechaCreacionDesde.Name = "dtpFechaCreacionDesde";
            this.dtpFechaCreacionDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaCreacionDesde.TabIndex = 1;
            this.dtpFechaCreacionDesde.ValueChanged += new System.EventHandler(this.dtpFechaCreacionDesde_ValueChanged);
            // 
            // lblFechaVigenciaDesde
            // 
            this.lblFechaVigenciaDesde.AutoSize = true;
            this.lblFechaVigenciaDesde.Location = new System.Drawing.Point(17, 72);
            this.lblFechaVigenciaDesde.Name = "lblFechaVigenciaDesde";
            this.lblFechaVigenciaDesde.Size = new System.Drawing.Size(92, 13);
            this.lblFechaVigenciaDesde.TabIndex = 90;
            this.lblFechaVigenciaDesde.Text = "F. Vigencia desde";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(17, 22);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 94;
            this.lblModalidad.Text = "Modalidad";
            // 
            // txtFechaVigenciaDesde
            // 
            this.txtFechaVigenciaDesde.Location = new System.Drawing.Point(118, 69);
            this.txtFechaVigenciaDesde.Name = "txtFechaVigenciaDesde";
            this.txtFechaVigenciaDesde.Size = new System.Drawing.Size(70, 20);
            this.txtFechaVigenciaDesde.TabIndex = 6;
            this.txtFechaVigenciaDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaVigenciaDesde_KeyDown);
            this.txtFechaVigenciaDesde.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaVigenciaDesde_Validating);
            this.txtFechaVigenciaDesde.Validated += new System.EventHandler(this.txtFechaVigenciaDesde_Validated);
            // 
            // txtFechaCreacionDesde
            // 
            this.txtFechaCreacionDesde.Location = new System.Drawing.Point(118, 44);
            this.txtFechaCreacionDesde.Name = "txtFechaCreacionDesde";
            this.txtFechaCreacionDesde.Size = new System.Drawing.Size(70, 20);
            this.txtFechaCreacionDesde.TabIndex = 2;
            this.txtFechaCreacionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaCreacionDesde_KeyDown);
            this.txtFechaCreacionDesde.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaCreacionDesde_Validating);
            this.txtFechaCreacionDesde.Validated += new System.EventHandler(this.txtFechaCreacionDesde_Validated);
            // 
            // lblFechaCreacionHasta
            // 
            this.lblFechaCreacionHasta.AutoSize = true;
            this.lblFechaCreacionHasta.Location = new System.Drawing.Point(215, 47);
            this.lblFechaCreacionHasta.Name = "lblFechaCreacionHasta";
            this.lblFechaCreacionHasta.Size = new System.Drawing.Size(33, 13);
            this.lblFechaCreacionHasta.TabIndex = 88;
            this.lblFechaCreacionHasta.Text = "hasta";
            // 
            // txtFechaCreacionHasta
            // 
            this.txtFechaCreacionHasta.Location = new System.Drawing.Point(255, 44);
            this.txtFechaCreacionHasta.Name = "txtFechaCreacionHasta";
            this.txtFechaCreacionHasta.Size = new System.Drawing.Size(70, 20);
            this.txtFechaCreacionHasta.TabIndex = 4;
            this.txtFechaCreacionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaCreacionHasta_KeyDown);
            this.txtFechaCreacionHasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaCreacionHasta_Validating);
            this.txtFechaCreacionHasta.Validated += new System.EventHandler(this.txtFechaCreacionHasta_Validated);
            // 
            // lblTipoAutorizacion
            // 
            this.lblTipoAutorizacion.AutoSize = true;
            this.lblTipoAutorizacion.Location = new System.Drawing.Point(17, 97);
            this.lblTipoAutorizacion.Name = "lblTipoAutorizacion";
            this.lblTipoAutorizacion.Size = new System.Drawing.Size(66, 13);
            this.lblTipoAutorizacion.TabIndex = 78;
            this.lblTipoAutorizacion.Text = "Tipo Autoriz.";
            // 
            // txtTipoAutorizacion
            // 
            this.txtTipoAutorizacion.Location = new System.Drawing.Point(80, 94);
            this.txtTipoAutorizacion.Name = "txtTipoAutorizacion";
            this.txtTipoAutorizacion.Size = new System.Drawing.Size(150, 20);
            this.txtTipoAutorizacion.TabIndex = 6;
            this.txtTipoAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoAutorizacion_KeyDown);
            this.txtTipoAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoAutorizacion_KeyPress);
            // 
            // btnAbrirSelectorTipoAutorizacion
            // 
            this.btnAbrirSelectorTipoAutorizacion.Location = new System.Drawing.Point(236, 94);
            this.btnAbrirSelectorTipoAutorizacion.Name = "btnAbrirSelectorTipoAutorizacion";
            this.btnAbrirSelectorTipoAutorizacion.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorTipoAutorizacion.TabIndex = 7;
            this.btnAbrirSelectorTipoAutorizacion.Text = "...";
            this.btnAbrirSelectorTipoAutorizacion.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorTipoAutorizacion.Click += new System.EventHandler(this.btnAbrirSelectorTipoAutorizacion_Click);
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.lbl_);
            this.grpPaciente.Controls.Add(this.lblNumeroDocumentoPaciente);
            this.grpPaciente.Controls.Add(this.cboTipoDocPaciente);
            this.grpPaciente.Controls.Add(this.txtNumeroDocumentoPaciente);
            this.grpPaciente.Controls.Add(this.txtNombrePaciente);
            this.grpPaciente.Controls.Add(this.lblNombrePaciente);
            this.grpPaciente.Location = new System.Drawing.Point(12, 78);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(325, 79);
            this.grpPaciente.TabIndex = 1;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Paciente";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(166, 22);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(58, 13);
            this.lbl_.TabIndex = 86;
            this.lbl_.Text = "T. de Doc.";
            // 
            // lblNumeroDocumentoPaciente
            // 
            this.lblNumeroDocumentoPaciente.AutoSize = true;
            this.lblNumeroDocumentoPaciente.Location = new System.Drawing.Point(17, 22);
            this.lblNumeroDocumentoPaciente.Name = "lblNumeroDocumentoPaciente";
            this.lblNumeroDocumentoPaciente.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroDocumentoPaciente.TabIndex = 82;
            this.lblNumeroDocumentoPaciente.Text = "N° Documento";
            // 
            // cboTipoDocPaciente
            // 
            this.cboTipoDocPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocPaciente.FormattingEnabled = true;
            this.cboTipoDocPaciente.Location = new System.Drawing.Point(230, 19);
            this.cboTipoDocPaciente.Name = "cboTipoDocPaciente";
            this.cboTipoDocPaciente.Size = new System.Drawing.Size(80, 21);
            this.cboTipoDocPaciente.TabIndex = 1;
            // 
            // txtNumeroDocumentoPaciente
            // 
            this.txtNumeroDocumentoPaciente.Location = new System.Drawing.Point(100, 19);
            this.txtNumeroDocumentoPaciente.Name = "txtNumeroDocumentoPaciente";
            this.txtNumeroDocumentoPaciente.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroDocumentoPaciente.TabIndex = 0;
            this.txtNumeroDocumentoPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumentoPaciente_KeyDown);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(100, 45);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(210, 20);
            this.txtNombrePaciente.TabIndex = 2;
            this.txtNombrePaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombrePaciente_KeyDown);
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(17, 48);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePaciente.TabIndex = 84;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // grpDiagnostico
            // 
            this.grpDiagnostico.Controls.Add(this.lblCategoria);
            this.grpDiagnostico.Controls.Add(this.btnAbrirSelectorEstadio);
            this.grpDiagnostico.Controls.Add(this.lblTipoAutorizacion);
            this.grpDiagnostico.Controls.Add(this.txtCategoria);
            this.grpDiagnostico.Controls.Add(this.btnAbrirSelectorFase);
            this.grpDiagnostico.Controls.Add(this.txtTipoAutorizacion);
            this.grpDiagnostico.Controls.Add(this.btnAbrirSelectorCategoria);
            this.grpDiagnostico.Controls.Add(this.txtEstadio);
            this.grpDiagnostico.Controls.Add(this.lblFase);
            this.grpDiagnostico.Controls.Add(this.btnAbrirSelectorTipoAutorizacion);
            this.grpDiagnostico.Controls.Add(this.lblEstadio);
            this.grpDiagnostico.Controls.Add(this.txtFase);
            this.grpDiagnostico.Location = new System.Drawing.Point(714, 28);
            this.grpDiagnostico.Name = "grpDiagnostico";
            this.grpDiagnostico.Size = new System.Drawing.Size(280, 130);
            this.grpDiagnostico.TabIndex = 3;
            this.grpDiagnostico.TabStop = false;
            this.grpDiagnostico.Text = "Tratamiento";
            // 
            // btnAbrirSelectorEstadio
            // 
            this.btnAbrirSelectorEstadio.Location = new System.Drawing.Point(236, 69);
            this.btnAbrirSelectorEstadio.Name = "btnAbrirSelectorEstadio";
            this.btnAbrirSelectorEstadio.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorEstadio.TabIndex = 5;
            this.btnAbrirSelectorEstadio.Text = "...";
            this.btnAbrirSelectorEstadio.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorEstadio.Click += new System.EventHandler(this.btnAbrirSelectorEstadio_Click);
            // 
            // btnAbrirSelectorFase
            // 
            this.btnAbrirSelectorFase.Location = new System.Drawing.Point(236, 44);
            this.btnAbrirSelectorFase.Name = "btnAbrirSelectorFase";
            this.btnAbrirSelectorFase.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorFase.TabIndex = 3;
            this.btnAbrirSelectorFase.Text = "...";
            this.btnAbrirSelectorFase.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorFase.Click += new System.EventHandler(this.btnAbrirSelectorFase_Click);
            // 
            // btnAbrirSelectorCategoria
            // 
            this.btnAbrirSelectorCategoria.Location = new System.Drawing.Point(236, 19);
            this.btnAbrirSelectorCategoria.Name = "btnAbrirSelectorCategoria";
            this.btnAbrirSelectorCategoria.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorCategoria.TabIndex = 1;
            this.btnAbrirSelectorCategoria.Text = "...";
            this.btnAbrirSelectorCategoria.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorCategoria.Click += new System.EventHandler(this.btnAbrirSelectorCategoria_Click);
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(80, 69);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(150, 20);
            this.txtEstadio.TabIndex = 4;
            this.txtEstadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstadio_KeyDown);
            this.txtEstadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadio_KeyPress);
            // 
            // lblFase
            // 
            this.lblFase.AutoSize = true;
            this.lblFase.Location = new System.Drawing.Point(17, 47);
            this.lblFase.Name = "lblFase";
            this.lblFase.Size = new System.Drawing.Size(30, 13);
            this.lblFase.TabIndex = 76;
            this.lblFase.Text = "Fase";
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Location = new System.Drawing.Point(17, 72);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(42, 13);
            this.lblEstadio.TabIndex = 74;
            this.lblEstadio.Text = "Estadio";
            // 
            // txtFase
            // 
            this.txtFase.Location = new System.Drawing.Point(80, 44);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(150, 20);
            this.txtFase.TabIndex = 2;
            this.txtFase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFase_KeyDown);
            this.txtFase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFase_KeyPress);
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(100, 19);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(175, 20);
            this.txtEstablecimiento.TabIndex = 0;
            this.txtEstablecimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstablecimiento_KeyDown);
            this.txtEstablecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstablecimiento_KeyPress);
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(17, 22);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(81, 13);
            this.lblEstablecimiento.TabIndex = 80;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // btnAbrirSelectorEstablecimiento
            // 
            this.btnAbrirSelectorEstablecimiento.Location = new System.Drawing.Point(280, 19);
            this.btnAbrirSelectorEstablecimiento.Name = "btnAbrirSelectorEstablecimiento";
            this.btnAbrirSelectorEstablecimiento.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorEstablecimiento.TabIndex = 1;
            this.btnAbrirSelectorEstablecimiento.Text = "...";
            this.btnAbrirSelectorEstablecimiento.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorEstablecimiento.Click += new System.EventHandler(this.btnAbrirSelectorEstablecimiento_Click);
            // 
            // grpEstablecimiento
            // 
            this.grpEstablecimiento.Controls.Add(this.lblEstablecimiento);
            this.grpEstablecimiento.Controls.Add(this.btnAbrirSelectorEstablecimiento);
            this.grpEstablecimiento.Controls.Add(this.txtEstablecimiento);
            this.grpEstablecimiento.Location = new System.Drawing.Point(12, 28);
            this.grpEstablecimiento.Name = "grpEstablecimiento";
            this.grpEstablecimiento.Size = new System.Drawing.Size(325, 45);
            this.grpEstablecimiento.TabIndex = 0;
            this.grpEstablecimiento.TabStop = false;
            this.grpEstablecimiento.Text = "Establecimiento";
            // 
            // grpResultadosBuscador
            // 
            this.grpResultadosBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultadosBuscador.Controls.Add(this.dgvAutorizaciones);
            this.grpResultadosBuscador.Location = new System.Drawing.Point(12, 163);
            this.grpResultadosBuscador.Name = "grpResultadosBuscador";
            this.grpResultadosBuscador.Size = new System.Drawing.Size(982, 542);
            this.grpResultadosBuscador.TabIndex = 4;
            this.grpResultadosBuscador.TabStop = false;
            this.grpResultadosBuscador.Text = "Resultados de la Busqueda";
            // 
            // dgvAutorizaciones
            // 
            this.dgvAutorizaciones.AllowUserToAddRows = false;
            this.dgvAutorizaciones.AllowUserToDeleteRows = false;
            this.dgvAutorizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutorizaciones.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAutorizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAutorizacion,
            this.Fecha,
            this.descripcionlarga,
            this.EstablecimientoId,
            this.Descripcion,
            this.IdPaciente,
            this.pacientenombre,
            this.TipoModalidad,
            this.FechaCreacion,
            this.Vigencia,
            this.Monto});
            this.dgvAutorizaciones.Location = new System.Drawing.Point(17, 19);
            this.dgvAutorizaciones.Name = "dgvAutorizaciones";
            this.dgvAutorizaciones.ReadOnly = true;
            this.dgvAutorizaciones.Size = new System.Drawing.Size(951, 507);
            this.dgvAutorizaciones.TabIndex = 0;
            this.dgvAutorizaciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAutorizaciones_DataBindingComplete);
            // 
            // CodigoAutorizacion
            // 
            this.CodigoAutorizacion.DataPropertyName = "CodigoAutorizacion";
            this.CodigoAutorizacion.HeaderText = "Codigo";
            this.CodigoAutorizacion.Name = "CodigoAutorizacion";
            this.CodigoAutorizacion.ReadOnly = true;
            this.CodigoAutorizacion.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle25.Format = "d";
            dataGridViewCellStyle25.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle25;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 70;
            // 
            // descripcionlarga
            // 
            this.descripcionlarga.DataPropertyName = "descripcionlarga";
            this.descripcionlarga.HeaderText = "Descripcion";
            this.descripcionlarga.Name = "descripcionlarga";
            this.descripcionlarga.ReadOnly = true;
            this.descripcionlarga.Width = 360;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "RENAES";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            this.EstablecimientoId.Width = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Establecimiento";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 360;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "PacienteId";
            this.IdPaciente.HeaderText = "Doc. Pac.";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Width = 80;
            // 
            // pacientenombre
            // 
            this.pacientenombre.DataPropertyName = "pacientenombre";
            this.pacientenombre.HeaderText = "Paciente";
            this.pacientenombre.Name = "pacientenombre";
            this.pacientenombre.ReadOnly = true;
            this.pacientenombre.Width = 240;
            // 
            // TipoModalidad
            // 
            this.TipoModalidad.DataPropertyName = "Modalidad";
            this.TipoModalidad.HeaderText = "Modalidad";
            this.TipoModalidad.Name = "TipoModalidad";
            this.TipoModalidad.ReadOnly = true;
            this.TipoModalidad.Width = 60;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            dataGridViewCellStyle26.Format = "d";
            dataGridViewCellStyle26.NullValue = null;
            this.FechaCreacion.DefaultCellStyle = dataGridViewCellStyle26;
            this.FechaCreacion.HeaderText = "Registro";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 70;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "Vigencia";
            dataGridViewCellStyle27.Format = "d";
            dataGridViewCellStyle27.NullValue = null;
            this.Vigencia.DefaultCellStyle = dataGridViewCellStyle27;
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
            this.Monto.Width = 80;
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
            this.stsStpBuscador.TabIndex = 103;
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
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 5;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscadorAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.grpResultadosBuscador);
            this.Controls.Add(this.grpEstablecimiento);
            this.Controls.Add(this.grpDiagnostico);
            this.Controls.Add(this.grpPaciente);
            this.Controls.Add(this.grpAutorizacion);
            this.Name = "FrmBuscadorAutorizaciones";
            this.Text = "Buscador de Autorizaciones";
            this.Load += new System.EventHandler(this.FrmBuscadorAutorizaciones_Load);
            this.grpAutorizacion.ResumeLayout(false);
            this.grpAutorizacion.PerformLayout();
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpDiagnostico.ResumeLayout(false);
            this.grpDiagnostico.PerformLayout();
            this.grpEstablecimiento.ResumeLayout(false);
            this.grpEstablecimiento.PerformLayout();
            this.grpResultadosBuscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizaciones)).EndInit();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox grpAutorizacion;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.GroupBox grpDiagnostico;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.TextBox txtTipoAutorizacion;
        private System.Windows.Forms.Label lblTipoAutorizacion;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.Label lblFase;
        private System.Windows.Forms.TextBox txtEstablecimiento;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.TextBox txtNumeroDocumentoPaciente;
        private System.Windows.Forms.Label lblNumeroDocumentoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtFechaCreacionDesde;
        private System.Windows.Forms.Label lblFechaCreacionDesde;
        private System.Windows.Forms.TextBox txtFechaCreacionHasta;
        private System.Windows.Forms.Label lblFechaCreacionHasta;
        private System.Windows.Forms.TextBox txtFechaVigenciaHasta;
        private System.Windows.Forms.Label lblFechaVigenciaHasta;
        private System.Windows.Forms.TextBox txtFechaVigenciaDesde;
        private System.Windows.Forms.Label lblFechaVigenciaDesde;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Button btnAbrirSelectorCategoria;
        private System.Windows.Forms.Button btnAbrirSelectorFase;
        private System.Windows.Forms.DateTimePicker dtpFechaVigenciaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaVigenciaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacionHasta;
        private System.Windows.Forms.Button btnAbrirSelectorTipoAutorizacion;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacionDesde;
        private System.Windows.Forms.Button btnAbrirSelectorEstadio;
        private System.Windows.Forms.Button btnAbrirSelectorEstablecimiento;
        private System.Windows.Forms.GroupBox grpEstablecimiento;
        private System.Windows.Forms.GroupBox grpResultadosBuscador;
        private System.Windows.Forms.DataGridView dgvAutorizaciones;
        private System.Windows.Forms.ComboBox cboModalidad;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.ComboBox cboTipoDocPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionlarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientenombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.CheckBox chkDiagnosticoAsociadoSi;
        private System.Windows.Forms.CheckBox chkAnuladoSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDiagnosticoAsociadoNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAnuladoNo;
    }
}