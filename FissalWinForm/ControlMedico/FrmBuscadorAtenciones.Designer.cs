namespace FissalWinForm
{
    partial class FrmBuscadorAtenciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscadorAtenciones));
            this.grpbx_consultar_control_medico = new System.Windows.Forms.GroupBox();
            this.chkCmReconsideradosNo = new System.Windows.Forms.CheckBox();
            this.lblCmReconsiderados = new System.Windows.Forms.Label();
            this.lblCmPcpp = new System.Windows.Forms.Label();
            this.chkCmPcppNo = new System.Windows.Forms.CheckBox();
            this.lblCmObs = new System.Windows.Forms.Label();
            this.chkCmObsNo = new System.Windows.Forms.CheckBox();
            this.lblCm = new System.Windows.Forms.Label();
            this.chkCmSi = new System.Windows.Forms.CheckBox();
            this.chkCmNo = new System.Windows.Forms.CheckBox();
            this.chkCmReconsideradosSi = new System.Windows.Forms.CheckBox();
            this.chkCmObsSi = new System.Windows.Forms.CheckBox();
            this.chkCmPcppSi = new System.Windows.Forms.CheckBox();
            this.chkProcedimientoFpNo = new System.Windows.Forms.CheckBox();
            this.chkProcedimientoFpSi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbx_diagnosticos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorCategorias = new System.Windows.Forms.Button();
            this.txtDiagnosticos = new System.Windows.Forms.TextBox();
            this.grpbx_procedimientos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorProcedimientos = new System.Windows.Forms.Button();
            this.txtProcedimientos = new System.Windows.Forms.TextBox();
            this.grpbx_medicamentos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorMedicamentos = new System.Windows.Forms.Button();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.chkMedicamentoFpNo = new System.Windows.Forms.CheckBox();
            this.chkMedicamentoFpSi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMontoTotalFuaHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoTotalFuaDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarResponsableAtencion = new System.Windows.Forms.Button();
            this.lblDniResponsableAtencion = new System.Windows.Forms.Label();
            this.txtDniResponsableAtencion = new System.Windows.Forms.TextBox();
            this.lblAnno = new System.Windows.Forms.Label();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lbl_ = new System.Windows.Forms.Label();
            this.cboTipoDocPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDocPaciente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFechaDigitacionHasta = new System.Windows.Forms.TextBox();
            this.txtFechaDigitacionDesde = new System.Windows.Forms.TextBox();
            this.txtFechaAtencionHasta = new System.Windows.Forms.TextBox();
            this.txtFechaAtencionDesde = new System.Windows.Forms.TextBox();
            this.dtpFechaAtencionDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDigitacionDesde = new System.Windows.Forms.Label();
            this.dtpFechaDigitacionHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAtencionDesde = new System.Windows.Forms.Label();
            this.lblFechaDigitacionHasta = new System.Windows.Forms.Label();
            this.dtpFechaDigitacionDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAtencionHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAtencionHasta = new System.Windows.Forms.Label();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEstablecimiento = new System.Windows.Forms.Button();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.btnSeleccionarControlMedico = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvMovimientoPaciente = new System.Windows.Forms.DataGridView();
            this.Fua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoFua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.cboCantidadSupervision = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtCodigoControlMedico = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtFechaFinControlMedico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaInicioControlMedico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cboProduccion = new System.Windows.Forms.ComboBox();
            this.grpbx_consultar_control_medico.SuspendLayout();
            this.grpbx_diagnosticos.SuspendLayout();
            this.grpbx_procedimientos.SuspendLayout();
            this.grpbx_medicamentos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.stsStpBuscador.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoPaciente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_consultar_control_medico
            // 
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmReconsideradosNo);
            this.grpbx_consultar_control_medico.Controls.Add(this.lblCmReconsiderados);
            this.grpbx_consultar_control_medico.Controls.Add(this.lblCmPcpp);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmPcppNo);
            this.grpbx_consultar_control_medico.Controls.Add(this.lblCmObs);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmObsNo);
            this.grpbx_consultar_control_medico.Controls.Add(this.lblCm);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmSi);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmNo);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmReconsideradosSi);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmObsSi);
            this.grpbx_consultar_control_medico.Controls.Add(this.chkCmPcppSi);
            this.grpbx_consultar_control_medico.Location = new System.Drawing.Point(731, 25);
            this.grpbx_consultar_control_medico.Name = "grpbx_consultar_control_medico";
            this.grpbx_consultar_control_medico.Size = new System.Drawing.Size(265, 113);
            this.grpbx_consultar_control_medico.TabIndex = 9;
            this.grpbx_consultar_control_medico.TabStop = false;
            this.grpbx_consultar_control_medico.Text = "Estado Control Medico";
            // 
            // chkCmReconsideradosNo
            // 
            this.chkCmReconsideradosNo.AutoSize = true;
            this.chkCmReconsideradosNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmReconsideradosNo.Location = new System.Drawing.Point(212, 89);
            this.chkCmReconsideradosNo.Name = "chkCmReconsideradosNo";
            this.chkCmReconsideradosNo.Size = new System.Drawing.Size(40, 17);
            this.chkCmReconsideradosNo.TabIndex = 7;
            this.chkCmReconsideradosNo.Text = "No";
            this.chkCmReconsideradosNo.UseVisualStyleBackColor = true;
            this.chkCmReconsideradosNo.CheckedChanged += new System.EventHandler(this.chckbx_cm_reconsiderados_no_CheckedChanged);
            this.chkCmReconsideradosNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmReconsideradosNo_KeyDown);
            // 
            // lblCmReconsiderados
            // 
            this.lblCmReconsiderados.AutoSize = true;
            this.lblCmReconsiderados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmReconsiderados.Location = new System.Drawing.Point(20, 90);
            this.lblCmReconsiderados.Name = "lblCmReconsiderados";
            this.lblCmReconsiderados.Size = new System.Drawing.Size(84, 13);
            this.lblCmReconsiderados.TabIndex = 7;
            this.lblCmReconsiderados.Text = "Reconsiderados";
            // 
            // lblCmPcpp
            // 
            this.lblCmPcpp.AutoSize = true;
            this.lblCmPcpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmPcpp.Location = new System.Drawing.Point(20, 65);
            this.lblCmPcpp.Name = "lblCmPcpp";
            this.lblCmPcpp.Size = new System.Drawing.Size(132, 13);
            this.lblCmPcpp.TabIndex = 6;
            this.lblCmPcpp.Text = "Seleccionados para PCPP";
            // 
            // chkCmPcppNo
            // 
            this.chkCmPcppNo.AutoSize = true;
            this.chkCmPcppNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmPcppNo.Location = new System.Drawing.Point(212, 64);
            this.chkCmPcppNo.Name = "chkCmPcppNo";
            this.chkCmPcppNo.Size = new System.Drawing.Size(40, 17);
            this.chkCmPcppNo.TabIndex = 5;
            this.chkCmPcppNo.Text = "No";
            this.chkCmPcppNo.UseVisualStyleBackColor = true;
            this.chkCmPcppNo.CheckedChanged += new System.EventHandler(this.chckbx_cm_pcpp_no_CheckedChanged);
            this.chkCmPcppNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmPcppNo_KeyDown);
            // 
            // lblCmObs
            // 
            this.lblCmObs.AutoSize = true;
            this.lblCmObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmObs.Location = new System.Drawing.Point(20, 41);
            this.lblCmObs.Name = "lblCmObs";
            this.lblCmObs.Size = new System.Drawing.Size(64, 13);
            this.lblCmObs.TabIndex = 5;
            this.lblCmObs.Text = "Observados";
            // 
            // chkCmObsNo
            // 
            this.chkCmObsNo.AutoSize = true;
            this.chkCmObsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmObsNo.Location = new System.Drawing.Point(212, 40);
            this.chkCmObsNo.Name = "chkCmObsNo";
            this.chkCmObsNo.Size = new System.Drawing.Size(40, 17);
            this.chkCmObsNo.TabIndex = 3;
            this.chkCmObsNo.Text = "No";
            this.chkCmObsNo.UseVisualStyleBackColor = true;
            this.chkCmObsNo.CheckedChanged += new System.EventHandler(this.chckbx_cm_obs_no_CheckedChanged);
            this.chkCmObsNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmObsNo_KeyDown);
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.Location = new System.Drawing.Point(20, 18);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(120, 13);
            this.lblCm.TabIndex = 4;
            this.lblCm.Text = "Pasaron Control Medico";
            // 
            // chkCmSi
            // 
            this.chkCmSi.AutoSize = true;
            this.chkCmSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmSi.Location = new System.Drawing.Point(165, 17);
            this.chkCmSi.Name = "chkCmSi";
            this.chkCmSi.Size = new System.Drawing.Size(36, 17);
            this.chkCmSi.TabIndex = 0;
            this.chkCmSi.Text = "SI";
            this.chkCmSi.UseVisualStyleBackColor = true;
            this.chkCmSi.CheckedChanged += new System.EventHandler(this.chckbx_cm_si_CheckedChanged);
            this.chkCmSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmSi_KeyDown);
            // 
            // chkCmNo
            // 
            this.chkCmNo.AutoSize = true;
            this.chkCmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmNo.Location = new System.Drawing.Point(212, 17);
            this.chkCmNo.Name = "chkCmNo";
            this.chkCmNo.Size = new System.Drawing.Size(40, 17);
            this.chkCmNo.TabIndex = 1;
            this.chkCmNo.Text = "No";
            this.chkCmNo.UseVisualStyleBackColor = true;
            this.chkCmNo.CheckedChanged += new System.EventHandler(this.chckbx_cm_no_CheckedChanged);
            this.chkCmNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmNo_KeyDown);
            // 
            // chkCmReconsideradosSi
            // 
            this.chkCmReconsideradosSi.AutoSize = true;
            this.chkCmReconsideradosSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmReconsideradosSi.Location = new System.Drawing.Point(165, 89);
            this.chkCmReconsideradosSi.Name = "chkCmReconsideradosSi";
            this.chkCmReconsideradosSi.Size = new System.Drawing.Size(35, 17);
            this.chkCmReconsideradosSi.TabIndex = 6;
            this.chkCmReconsideradosSi.Text = "Si";
            this.chkCmReconsideradosSi.UseVisualStyleBackColor = true;
            this.chkCmReconsideradosSi.CheckedChanged += new System.EventHandler(this.chckbx_cm_reconsiderados_si_CheckedChanged);
            this.chkCmReconsideradosSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmReconsideradosSi_KeyDown);
            // 
            // chkCmObsSi
            // 
            this.chkCmObsSi.AutoSize = true;
            this.chkCmObsSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmObsSi.Location = new System.Drawing.Point(165, 40);
            this.chkCmObsSi.Name = "chkCmObsSi";
            this.chkCmObsSi.Size = new System.Drawing.Size(35, 17);
            this.chkCmObsSi.TabIndex = 2;
            this.chkCmObsSi.Text = "Si";
            this.chkCmObsSi.UseVisualStyleBackColor = true;
            this.chkCmObsSi.CheckedChanged += new System.EventHandler(this.chckbx_cm_obs_si_CheckedChanged);
            this.chkCmObsSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmObsSi_KeyDown);
            // 
            // chkCmPcppSi
            // 
            this.chkCmPcppSi.AutoSize = true;
            this.chkCmPcppSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCmPcppSi.Location = new System.Drawing.Point(165, 64);
            this.chkCmPcppSi.Name = "chkCmPcppSi";
            this.chkCmPcppSi.Size = new System.Drawing.Size(35, 17);
            this.chkCmPcppSi.TabIndex = 4;
            this.chkCmPcppSi.Text = "Si";
            this.chkCmPcppSi.UseVisualStyleBackColor = true;
            this.chkCmPcppSi.CheckedChanged += new System.EventHandler(this.chckbx_cm_pcpp_si_CheckedChanged);
            this.chkCmPcppSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCmPcppSi_KeyDown);
            // 
            // chkProcedimientoFpNo
            // 
            this.chkProcedimientoFpNo.AutoSize = true;
            this.chkProcedimientoFpNo.Location = new System.Drawing.Point(94, 18);
            this.chkProcedimientoFpNo.Name = "chkProcedimientoFpNo";
            this.chkProcedimientoFpNo.Size = new System.Drawing.Size(40, 17);
            this.chkProcedimientoFpNo.TabIndex = 17;
            this.chkProcedimientoFpNo.Text = "No";
            this.chkProcedimientoFpNo.UseVisualStyleBackColor = true;
            this.chkProcedimientoFpNo.Visible = false;
            this.chkProcedimientoFpNo.CheckedChanged += new System.EventHandler(this.chckbx_procedimiento_fp_no_CheckedChanged);
            // 
            // chkProcedimientoFpSi
            // 
            this.chkProcedimientoFpSi.AutoSize = true;
            this.chkProcedimientoFpSi.Location = new System.Drawing.Point(51, 18);
            this.chkProcedimientoFpSi.Name = "chkProcedimientoFpSi";
            this.chkProcedimientoFpSi.Size = new System.Drawing.Size(35, 17);
            this.chkProcedimientoFpSi.TabIndex = 0;
            this.chkProcedimientoFpSi.Text = "Si";
            this.chkProcedimientoFpSi.UseVisualStyleBackColor = true;
            this.chkProcedimientoFpSi.CheckedChanged += new System.EventHandler(this.chckbx_procedimiento_fp_si_CheckedChanged);
            this.chkProcedimientoFpSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkProcedimientoFpSi_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "P";
            // 
            // grpbx_diagnosticos
            // 
            this.grpbx_diagnosticos.Controls.Add(this.btnAbrirSelectorCategorias);
            this.grpbx_diagnosticos.Controls.Add(this.txtDiagnosticos);
            this.grpbx_diagnosticos.Location = new System.Drawing.Point(506, 25);
            this.grpbx_diagnosticos.Name = "grpbx_diagnosticos";
            this.grpbx_diagnosticos.Size = new System.Drawing.Size(220, 48);
            this.grpbx_diagnosticos.TabIndex = 6;
            this.grpbx_diagnosticos.TabStop = false;
            this.grpbx_diagnosticos.Text = "Diagnosticos";
            // 
            // btnAbrirSelectorCategorias
            // 
            this.btnAbrirSelectorCategorias.Location = new System.Drawing.Point(174, 19);
            this.btnAbrirSelectorCategorias.Name = "btnAbrirSelectorCategorias";
            this.btnAbrirSelectorCategorias.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorCategorias.TabIndex = 1;
            this.btnAbrirSelectorCategorias.Text = "...";
            this.btnAbrirSelectorCategorias.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorCategorias.Click += new System.EventHandler(this.btn_buscar_diagnosticos_Click);
            // 
            // txtDiagnosticos
            // 
            this.txtDiagnosticos.Location = new System.Drawing.Point(18, 20);
            this.txtDiagnosticos.Name = "txtDiagnosticos";
            this.txtDiagnosticos.Size = new System.Drawing.Size(150, 20);
            this.txtDiagnosticos.TabIndex = 0;
            this.txtDiagnosticos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_diagnosticos_KeyDown);
            // 
            // grpbx_procedimientos
            // 
            this.grpbx_procedimientos.Controls.Add(this.btnAbrirSelectorProcedimientos);
            this.grpbx_procedimientos.Controls.Add(this.txtProcedimientos);
            this.grpbx_procedimientos.Location = new System.Drawing.Point(506, 74);
            this.grpbx_procedimientos.Name = "grpbx_procedimientos";
            this.grpbx_procedimientos.Size = new System.Drawing.Size(220, 64);
            this.grpbx_procedimientos.TabIndex = 7;
            this.grpbx_procedimientos.TabStop = false;
            this.grpbx_procedimientos.Text = "Procedimientos";
            // 
            // btnAbrirSelectorProcedimientos
            // 
            this.btnAbrirSelectorProcedimientos.Location = new System.Drawing.Point(174, 26);
            this.btnAbrirSelectorProcedimientos.Name = "btnAbrirSelectorProcedimientos";
            this.btnAbrirSelectorProcedimientos.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorProcedimientos.TabIndex = 1;
            this.btnAbrirSelectorProcedimientos.Text = "...";
            this.btnAbrirSelectorProcedimientos.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorProcedimientos.Click += new System.EventHandler(this.btn_buscar_procedimientos_Click);
            // 
            // txtProcedimientos
            // 
            this.txtProcedimientos.Location = new System.Drawing.Point(18, 26);
            this.txtProcedimientos.Name = "txtProcedimientos";
            this.txtProcedimientos.Size = new System.Drawing.Size(150, 20);
            this.txtProcedimientos.TabIndex = 0;
            this.txtProcedimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_procedimientos_KeyDown);
            this.txtProcedimientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedimientos_KeyPress);
            // 
            // grpbx_medicamentos
            // 
            this.grpbx_medicamentos.Controls.Add(this.btnAbrirSelectorMedicamentos);
            this.grpbx_medicamentos.Controls.Add(this.txtMedicamentos);
            this.grpbx_medicamentos.Location = new System.Drawing.Point(506, 141);
            this.grpbx_medicamentos.Name = "grpbx_medicamentos";
            this.grpbx_medicamentos.Size = new System.Drawing.Size(220, 70);
            this.grpbx_medicamentos.TabIndex = 8;
            this.grpbx_medicamentos.TabStop = false;
            this.grpbx_medicamentos.Text = "Medicamentos";
            // 
            // btnAbrirSelectorMedicamentos
            // 
            this.btnAbrirSelectorMedicamentos.Location = new System.Drawing.Point(174, 26);
            this.btnAbrirSelectorMedicamentos.Name = "btnAbrirSelectorMedicamentos";
            this.btnAbrirSelectorMedicamentos.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorMedicamentos.TabIndex = 1;
            this.btnAbrirSelectorMedicamentos.Text = "...";
            this.btnAbrirSelectorMedicamentos.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorMedicamentos.Click += new System.EventHandler(this.btn_buscarmedicamentos_Click);
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Location = new System.Drawing.Point(18, 26);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(150, 20);
            this.txtMedicamentos.TabIndex = 0;
            this.txtMedicamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_medicamentos_KeyDown);
            this.txtMedicamentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicamentos_KeyPress);
            // 
            // chkMedicamentoFpNo
            // 
            this.chkMedicamentoFpNo.AutoSize = true;
            this.chkMedicamentoFpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMedicamentoFpNo.Location = new System.Drawing.Point(94, 43);
            this.chkMedicamentoFpNo.Name = "chkMedicamentoFpNo";
            this.chkMedicamentoFpNo.Size = new System.Drawing.Size(40, 17);
            this.chkMedicamentoFpNo.TabIndex = 20;
            this.chkMedicamentoFpNo.Text = "No";
            this.chkMedicamentoFpNo.UseVisualStyleBackColor = true;
            this.chkMedicamentoFpNo.Visible = false;
            this.chkMedicamentoFpNo.CheckedChanged += new System.EventHandler(this.chckbx_medicamento_fp_no_CheckedChanged);
            // 
            // chkMedicamentoFpSi
            // 
            this.chkMedicamentoFpSi.AutoSize = true;
            this.chkMedicamentoFpSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMedicamentoFpSi.Location = new System.Drawing.Point(51, 43);
            this.chkMedicamentoFpSi.Name = "chkMedicamentoFpSi";
            this.chkMedicamentoFpSi.Size = new System.Drawing.Size(35, 17);
            this.chkMedicamentoFpSi.TabIndex = 1;
            this.chkMedicamentoFpSi.Text = "Si";
            this.chkMedicamentoFpSi.UseVisualStyleBackColor = true;
            this.chkMedicamentoFpSi.CheckedChanged += new System.EventHandler(this.chckbx_medicamento_fp_si_CheckedChanged);
            this.chkMedicamentoFpSi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkMedicamentoFpSi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "M";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMedicamentoFpNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkMedicamentoFpSi);
            this.groupBox1.Controls.Add(this.chkProcedimientoFpSi);
            this.groupBox1.Controls.Add(this.chkProcedimientoFpNo);
            this.groupBox1.Location = new System.Drawing.Point(362, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuera de Paquete";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMontoTotalFuaHasta);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtMontoTotalFuaDesde);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(731, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(265, 46);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Montos";
            // 
            // txtMontoTotalFuaHasta
            // 
            this.txtMontoTotalFuaHasta.Location = new System.Drawing.Point(199, 16);
            this.txtMontoTotalFuaHasta.Name = "txtMontoTotalFuaHasta";
            this.txtMontoTotalFuaHasta.Size = new System.Drawing.Size(60, 20);
            this.txtMontoTotalFuaHasta.TabIndex = 1;
            this.txtMontoTotalFuaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_totalfua_hasta_KeyDown);
            this.txtMontoTotalFuaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_totalfua_hasta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "hasta";
            // 
            // txtMontoTotalFuaDesde
            // 
            this.txtMontoTotalFuaDesde.Location = new System.Drawing.Point(99, 16);
            this.txtMontoTotalFuaDesde.Name = "txtMontoTotalFuaDesde";
            this.txtMontoTotalFuaDesde.Size = new System.Drawing.Size(60, 20);
            this.txtMontoTotalFuaDesde.TabIndex = 0;
            this.txtMontoTotalFuaDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_totalfua_desde_KeyDown);
            this.txtMontoTotalFuaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_totalfua_desde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Fua desde";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarResponsableAtencion);
            this.groupBox4.Controls.Add(this.lblDniResponsableAtencion);
            this.groupBox4.Controls.Add(this.txtDniResponsableAtencion);
            this.groupBox4.Location = new System.Drawing.Point(362, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 40);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Responsable";
            // 
            // btnBuscarResponsableAtencion
            // 
            this.btnBuscarResponsableAtencion.Location = new System.Drawing.Point(104, 17);
            this.btnBuscarResponsableAtencion.Name = "btnBuscarResponsableAtencion";
            this.btnBuscarResponsableAtencion.Size = new System.Drawing.Size(30, 20);
            this.btnBuscarResponsableAtencion.TabIndex = 1;
            this.btnBuscarResponsableAtencion.Text = "...";
            this.btnBuscarResponsableAtencion.UseVisualStyleBackColor = true;
            this.btnBuscarResponsableAtencion.Visible = false;
            // 
            // lblDniResponsableAtencion
            // 
            this.lblDniResponsableAtencion.AutoSize = true;
            this.lblDniResponsableAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniResponsableAtencion.Location = new System.Drawing.Point(7, 21);
            this.lblDniResponsableAtencion.Name = "lblDniResponsableAtencion";
            this.lblDniResponsableAtencion.Size = new System.Drawing.Size(26, 13);
            this.lblDniResponsableAtencion.TabIndex = 35;
            this.lblDniResponsableAtencion.Text = "DNI";
            // 
            // txtDniResponsableAtencion
            // 
            this.txtDniResponsableAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniResponsableAtencion.Location = new System.Drawing.Point(37, 17);
            this.txtDniResponsableAtencion.Name = "txtDniResponsableAtencion";
            this.txtDniResponsableAtencion.Size = new System.Drawing.Size(60, 20);
            this.txtDniResponsableAtencion.TabIndex = 0;
            this.txtDniResponsableAtencion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_dni_responsable_atencion_KeyDown);
            this.txtDniResponsableAtencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_dni_responsable_atencion_keyPress);
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnno.Location = new System.Drawing.Point(150, 17);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(28, 13);
            this.lblAnno.TabIndex = 62;
            this.lblAnno.Text = "Lote";
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstablecimiento.Location = new System.Drawing.Point(9, 17);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(44, 13);
            this.lblEstablecimiento.TabIndex = 60;
            this.lblEstablecimiento.Text = "Renaes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarPaciente);
            this.groupBox3.Controls.Add(this.lbl_);
            this.groupBox3.Controls.Add(this.cboTipoDocPaciente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNumeroDocPaciente);
            this.groupBox3.Location = new System.Drawing.Point(12, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 40);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paciente";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(302, 15);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(30, 20);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.Text = "...";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Visible = false;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(9, 19);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(69, 13);
            this.lbl_.TabIndex = 23;
            this.lbl_.Text = "Tipo de Doc.";
            // 
            // cboTipoDocPaciente
            // 
            this.cboTipoDocPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocPaciente.FormattingEnabled = true;
            this.cboTipoDocPaciente.Location = new System.Drawing.Point(79, 15);
            this.cboTipoDocPaciente.Name = "cboTipoDocPaciente";
            this.cboTipoDocPaciente.Size = new System.Drawing.Size(90, 21);
            this.cboTipoDocPaciente.TabIndex = 0;
            this.cboTipoDocPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbx_tipo_doc_paciente_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nº Doc.";
            // 
            // txtNumeroDocPaciente
            // 
            this.txtNumeroDocPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocPaciente.Location = new System.Drawing.Point(238, 15);
            this.txtNumeroDocPaciente.Name = "txtNumeroDocPaciente";
            this.txtNumeroDocPaciente.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroDocPaciente.TabIndex = 1;
            this.txtNumeroDocPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_numero_doc_paciente_KeyDown);
            this.txtNumeroDocPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_numero_doc_paciente_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaDigitacionHasta);
            this.groupBox2.Controls.Add(this.txtFechaDigitacionDesde);
            this.groupBox2.Controls.Add(this.txtFechaAtencionHasta);
            this.groupBox2.Controls.Add(this.txtFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.dtpFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.lblFechaDigitacionDesde);
            this.groupBox2.Controls.Add(this.dtpFechaDigitacionHasta);
            this.groupBox2.Controls.Add(this.lblFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.lblFechaDigitacionHasta);
            this.groupBox2.Controls.Add(this.dtpFechaDigitacionDesde);
            this.groupBox2.Controls.Add(this.dtpFechaAtencionHasta);
            this.groupBox2.Controls.Add(this.lblFechaAtencionHasta);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // txtFechaDigitacionHasta
            // 
            this.txtFechaDigitacionHasta.Location = new System.Drawing.Point(235, 41);
            this.txtFechaDigitacionHasta.Name = "txtFechaDigitacionHasta";
            this.txtFechaDigitacionHasta.Size = new System.Drawing.Size(70, 20);
            this.txtFechaDigitacionHasta.TabIndex = 7;
            this.txtFechaDigitacionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaDigitacionHasta_KeyDown);
            this.txtFechaDigitacionHasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaDigitacionHasta_Validating);
            this.txtFechaDigitacionHasta.Validated += new System.EventHandler(this.txtFechaDigitacionHasta_Validated);
            // 
            // txtFechaDigitacionDesde
            // 
            this.txtFechaDigitacionDesde.Location = new System.Drawing.Point(95, 41);
            this.txtFechaDigitacionDesde.Name = "txtFechaDigitacionDesde";
            this.txtFechaDigitacionDesde.Size = new System.Drawing.Size(70, 20);
            this.txtFechaDigitacionDesde.TabIndex = 5;
            this.txtFechaDigitacionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaDigitacionDesde_KeyDown);
            this.txtFechaDigitacionDesde.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaDigitacionDesde_Validating);
            this.txtFechaDigitacionDesde.Validated += new System.EventHandler(this.txtFechaDigitacionDesde_Validated);
            // 
            // txtFechaAtencionHasta
            // 
            this.txtFechaAtencionHasta.Location = new System.Drawing.Point(235, 16);
            this.txtFechaAtencionHasta.Name = "txtFechaAtencionHasta";
            this.txtFechaAtencionHasta.Size = new System.Drawing.Size(70, 20);
            this.txtFechaAtencionHasta.TabIndex = 3;
            this.txtFechaAtencionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaAtencionHasta_KeyDown);
            this.txtFechaAtencionHasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaAtencionHasta_Validating);
            this.txtFechaAtencionHasta.Validated += new System.EventHandler(this.txtFechaAtencionHasta_Validated);
            // 
            // txtFechaAtencionDesde
            // 
            this.txtFechaAtencionDesde.Location = new System.Drawing.Point(95, 16);
            this.txtFechaAtencionDesde.Name = "txtFechaAtencionDesde";
            this.txtFechaAtencionDesde.Size = new System.Drawing.Size(70, 20);
            this.txtFechaAtencionDesde.TabIndex = 1;
            this.txtFechaAtencionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaAtencionDesde_KeyDown);
            this.txtFechaAtencionDesde.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaAtencionDesde_Validating);
            this.txtFechaAtencionDesde.Validated += new System.EventHandler(this.txtFechaAtencionDesde_Validated);
            // 
            // dtpFechaAtencionDesde
            // 
            this.dtpFechaAtencionDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAtencionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAtencionDesde.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.dtpFechaAtencionDesde.Location = new System.Drawing.Point(171, 16);
            this.dtpFechaAtencionDesde.Name = "dtpFechaAtencionDesde";
            this.dtpFechaAtencionDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaAtencionDesde.TabIndex = 0;
            this.dtpFechaAtencionDesde.ValueChanged += new System.EventHandler(this.dtpckr_fecha_atencion_desde_ValueChanged);
            // 
            // lblFechaDigitacionDesde
            // 
            this.lblFechaDigitacionDesde.AutoSize = true;
            this.lblFechaDigitacionDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDigitacionDesde.Location = new System.Drawing.Point(9, 44);
            this.lblFechaDigitacionDesde.Name = "lblFechaDigitacionDesde";
            this.lblFechaDigitacionDesde.Size = new System.Drawing.Size(86, 13);
            this.lblFechaDigitacionDesde.TabIndex = 26;
            this.lblFechaDigitacionDesde.Text = "Digitación desde";
            // 
            // dtpFechaDigitacionHasta
            // 
            this.dtpFechaDigitacionHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDigitacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDigitacionHasta.Location = new System.Drawing.Point(311, 41);
            this.dtpFechaDigitacionHasta.Name = "dtpFechaDigitacionHasta";
            this.dtpFechaDigitacionHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaDigitacionHasta.TabIndex = 6;
            this.dtpFechaDigitacionHasta.ValueChanged += new System.EventHandler(this.dtpckr_fecha_digitacion_hasta_ValueChanged);
            // 
            // lblFechaAtencionDesde
            // 
            this.lblFechaAtencionDesde.AutoSize = true;
            this.lblFechaAtencionDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAtencionDesde.Location = new System.Drawing.Point(9, 19);
            this.lblFechaAtencionDesde.Name = "lblFechaAtencionDesde";
            this.lblFechaAtencionDesde.Size = new System.Drawing.Size(81, 13);
            this.lblFechaAtencionDesde.TabIndex = 10;
            this.lblFechaAtencionDesde.Text = "Atención desde";
            // 
            // lblFechaDigitacionHasta
            // 
            this.lblFechaDigitacionHasta.AutoSize = true;
            this.lblFechaDigitacionHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDigitacionHasta.Location = new System.Drawing.Point(200, 44);
            this.lblFechaDigitacionHasta.Name = "lblFechaDigitacionHasta";
            this.lblFechaDigitacionHasta.Size = new System.Drawing.Size(33, 13);
            this.lblFechaDigitacionHasta.TabIndex = 17;
            this.lblFechaDigitacionHasta.Text = "hasta";
            // 
            // dtpFechaDigitacionDesde
            // 
            this.dtpFechaDigitacionDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDigitacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDigitacionDesde.Location = new System.Drawing.Point(171, 41);
            this.dtpFechaDigitacionDesde.Name = "dtpFechaDigitacionDesde";
            this.dtpFechaDigitacionDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaDigitacionDesde.TabIndex = 4;
            this.dtpFechaDigitacionDesde.ValueChanged += new System.EventHandler(this.dtpckr_fecha_digitacion_desde_ValueChanged);
            // 
            // dtpFechaAtencionHasta
            // 
            this.dtpFechaAtencionHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAtencionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAtencionHasta.Location = new System.Drawing.Point(311, 16);
            this.dtpFechaAtencionHasta.Name = "dtpFechaAtencionHasta";
            this.dtpFechaAtencionHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaAtencionHasta.TabIndex = 2;
            this.dtpFechaAtencionHasta.ValueChanged += new System.EventHandler(this.dtpckr_fecha_atencion_hasta_ValueChanged);
            // 
            // lblFechaAtencionHasta
            // 
            this.lblFechaAtencionHasta.AutoSize = true;
            this.lblFechaAtencionHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAtencionHasta.Location = new System.Drawing.Point(200, 19);
            this.lblFechaAtencionHasta.Name = "lblFechaAtencionHasta";
            this.lblFechaAtencionHasta.Size = new System.Drawing.Size(33, 13);
            this.lblFechaAtencionHasta.TabIndex = 14;
            this.lblFechaAtencionHasta.Text = "hasta";
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AutoSize = true;
            this.lblCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(220, 17);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(57, 13);
            this.lblCorrelativo.TabIndex = 59;
            this.lblCorrelativo.Text = "Correlativo";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(281, 15);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(50, 20);
            this.txtCorrelativo.TabIndex = 3;
            this.txtCorrelativo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_correlativo_KeyDown);
            this.txtCorrelativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_correlativo_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarEstablecimiento);
            this.groupBox5.Controls.Add(this.txtAnno);
            this.groupBox5.Controls.Add(this.txtEstablecimiento);
            this.groupBox5.Controls.Add(this.lblEstablecimiento);
            this.groupBox5.Controls.Add(this.lblAnno);
            this.groupBox5.Controls.Add(this.lblCorrelativo);
            this.groupBox5.Controls.Add(this.txtCorrelativo);
            this.groupBox5.Location = new System.Drawing.Point(12, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 40);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numero de Atencion";
            // 
            // btnBuscarEstablecimiento
            // 
            this.btnBuscarEstablecimiento.Location = new System.Drawing.Point(113, 15);
            this.btnBuscarEstablecimiento.Name = "btnBuscarEstablecimiento";
            this.btnBuscarEstablecimiento.Size = new System.Drawing.Size(30, 20);
            this.btnBuscarEstablecimiento.TabIndex = 1;
            this.btnBuscarEstablecimiento.Text = "...";
            this.btnBuscarEstablecimiento.UseVisualStyleBackColor = true;
            this.btnBuscarEstablecimiento.Click += new System.EventHandler(this.btnBuscarEstablecimiento_Click);
            // 
            // txtAnno
            // 
            this.txtAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnno.Location = new System.Drawing.Point(182, 15);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(30, 20);
            this.txtAnno.TabIndex = 2;
            this.txtAnno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_anno_KeyDown);
            this.txtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_anno_KeyPress);
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstablecimiento.Location = new System.Drawing.Point(57, 15);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(50, 20);
            this.txtEstablecimiento.TabIndex = 0;
            this.txtEstablecimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_establecimiento_KeyDown);
            this.txtEstablecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_establecimiento_KeyPress);
            // 
            // btnSeleccionarControlMedico
            // 
            this.btnSeleccionarControlMedico.Location = new System.Drawing.Point(98, 15);
            this.btnSeleccionarControlMedico.Name = "btnSeleccionarControlMedico";
            this.btnSeleccionarControlMedico.Size = new System.Drawing.Size(30, 20);
            this.btnSeleccionarControlMedico.TabIndex = 0;
            this.btnSeleccionarControlMedico.Text = "...";
            this.btnSeleccionarControlMedico.UseVisualStyleBackColor = true;
            this.btnSeleccionarControlMedico.Click += new System.EventHandler(this.btnSeleccionarControlMedico_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.stsStpBuscador.Size = new System.Drawing.Size(1434, 22);
            this.stsStpBuscador.TabIndex = 70;
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
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvMovimientoPaciente);
            this.groupBox7.Location = new System.Drawing.Point(12, 217);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1410, 488);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultados de Búsqueda";
            // 
            // dgvMovimientoPaciente
            // 
            this.dgvMovimientoPaciente.AllowUserToAddRows = false;
            this.dgvMovimientoPaciente.AllowUserToDeleteRows = false;
            this.dgvMovimientoPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimientoPaciente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMovimientoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientoPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fua,
            this.EstablecimientoId,
            this.anno,
            this.correlativo,
            this.Descripcion,
            this.FechaAtencion,
            this.FechaRegistro,
            this.DescripcionTipoDocumento,
            this.NumeroDocumento,
            this.NombrePaciente,
            this.DNIResponsable,
            this.NombreDoctor,
            this.Especialidad,
            this.MontoFua});
            this.dgvMovimientoPaciente.Location = new System.Drawing.Point(12, 19);
            this.dgvMovimientoPaciente.Name = "dgvMovimientoPaciente";
            this.dgvMovimientoPaciente.ReadOnly = true;
            this.dgvMovimientoPaciente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMovimientoPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientoPaciente.Size = new System.Drawing.Size(1384, 463);
            this.dgvMovimientoPaciente.TabIndex = 0;
            this.dgvMovimientoPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientoPaciente_CellDoubleClick);
            this.dgvMovimientoPaciente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMovimientoPaciente_DataBindingComplete);
            this.dgvMovimientoPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMovimientoPaciente_KeyDown);
            // 
            // Fua
            // 
            this.Fua.DataPropertyName = "Fua";
            this.Fua.HeaderText = "Fua";
            this.Fua.Name = "Fua";
            this.Fua.ReadOnly = true;
            this.Fua.Visible = false;
            this.Fua.Width = 60;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "RENAES";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            this.EstablecimientoId.Width = 60;
            // 
            // anno
            // 
            this.anno.DataPropertyName = "anno";
            this.anno.HeaderText = "Lote";
            this.anno.Name = "anno";
            this.anno.ReadOnly = true;
            this.anno.Width = 30;
            // 
            // correlativo
            // 
            this.correlativo.DataPropertyName = "correlativo";
            this.correlativo.HeaderText = "Correlativo";
            this.correlativo.Name = "correlativo";
            this.correlativo.ReadOnly = true;
            this.correlativo.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "IPRESS";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 420;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.DataPropertyName = "FechaAtencion";
            this.FechaAtencion.HeaderText = "F. Atencion";
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.ReadOnly = true;
            this.FechaAtencion.Width = 90;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "F. Digitacion";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 90;
            // 
            // DescripcionTipoDocumento
            // 
            this.DescripcionTipoDocumento.DataPropertyName = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.HeaderText = "T. Doc.";
            this.DescripcionTipoDocumento.Name = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.ReadOnly = true;
            this.DescripcionTipoDocumento.Width = 70;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Doc. Pac.";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 80;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.DataPropertyName = "NombrePaciente";
            this.NombrePaciente.HeaderText = "Paciente";
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.ReadOnly = true;
            this.NombrePaciente.Width = 240;
            // 
            // DNIResponsable
            // 
            this.DNIResponsable.DataPropertyName = "DNIResponsable";
            this.DNIResponsable.HeaderText = "DNI Resp.";
            this.DNIResponsable.Name = "DNIResponsable";
            this.DNIResponsable.ReadOnly = true;
            this.DNIResponsable.Width = 80;
            // 
            // NombreDoctor
            // 
            this.NombreDoctor.DataPropertyName = "NombreDoctor";
            this.NombreDoctor.HeaderText = "Responsable";
            this.NombreDoctor.Name = "NombreDoctor";
            this.NombreDoctor.ReadOnly = true;
            this.NombreDoctor.Width = 240;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 180;
            // 
            // MontoFua
            // 
            this.MontoFua.DataPropertyName = "MontoFua";
            this.MontoFua.HeaderText = "Monto";
            this.MontoFua.Name = "MontoFua";
            this.MontoFua.ReadOnly = true;
            this.MontoFua.Width = 80;
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
            this.toolStrip1.Size = new System.Drawing.Size(1434, 25);
            this.toolStrip1.TabIndex = 12;
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
            // cboCantidadSupervision
            // 
            this.cboCantidadSupervision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCantidadSupervision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCantidadSupervision.FormattingEnabled = true;
            this.cboCantidadSupervision.Location = new System.Drawing.Point(424, 15);
            this.cboCantidadSupervision.Name = "cboCantidadSupervision";
            this.cboCantidadSupervision.Size = new System.Drawing.Size(58, 21);
            this.cboCantidadSupervision.TabIndex = 1;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.Blue;
            this.lblNota.Location = new System.Drawing.Point(743, 191);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(186, 13);
            this.lblNota.TabIndex = 116;
            this.lblNota.Text = "Nota: Atenciones Valorizadas hasta el";
            // 
            // txtCodigoControlMedico
            // 
            this.txtCodigoControlMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoControlMedico.Location = new System.Drawing.Point(51, 15);
            this.txtCodigoControlMedico.Name = "txtCodigoControlMedico";
            this.txtCodigoControlMedico.ReadOnly = true;
            this.txtCodigoControlMedico.Size = new System.Drawing.Size(40, 20);
            this.txtCodigoControlMedico.TabIndex = 117;
            this.txtCodigoControlMedico.TextChanged += new System.EventHandler(this.txtCodigoControlMedico_TextChanged);
            this.txtCodigoControlMedico.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoControlMedico_Validating);
            this.txtCodigoControlMedico.Validated += new System.EventHandler(this.txtCodigoControlMedico_Validated);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtFechaFinControlMedico);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.txtFechaInicioControlMedico);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.cboCantidadSupervision);
            this.groupBox9.Controls.Add(this.btnSeleccionarControlMedico);
            this.groupBox9.Controls.Add(this.txtCodigoControlMedico);
            this.groupBox9.Location = new System.Drawing.Point(14, 23);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(488, 40);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Proceso Control Medico";
            // 
            // txtFechaFinControlMedico
            // 
            this.txtFechaFinControlMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinControlMedico.Location = new System.Drawing.Point(277, 15);
            this.txtFechaFinControlMedico.Name = "txtFechaFinControlMedico";
            this.txtFechaFinControlMedico.ReadOnly = true;
            this.txtFechaFinControlMedico.Size = new System.Drawing.Size(65, 20);
            this.txtFechaFinControlMedico.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "Inicio";
            // 
            // txtFechaInicioControlMedico
            // 
            this.txtFechaInicioControlMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicioControlMedico.Location = new System.Drawing.Point(179, 15);
            this.txtFechaInicioControlMedico.Name = "txtFechaInicioControlMedico";
            this.txtFechaInicioControlMedico.ReadOnly = true;
            this.txtFechaInicioControlMedico.Size = new System.Drawing.Size(65, 20);
            this.txtFechaInicioControlMedico.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Supervisar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Codigo";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cboProduccion);
            this.groupBox8.Location = new System.Drawing.Point(362, 63);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 40);
            this.groupBox8.TabIndex = 117;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Producciones";
            // 
            // cboProduccion
            // 
            this.cboProduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduccion.FormattingEnabled = true;
            this.cboProduccion.Location = new System.Drawing.Point(10, 15);
            this.cboProduccion.Name = "cboProduccion";
            this.cboProduccion.Size = new System.Drawing.Size(124, 21);
            this.cboProduccion.TabIndex = 122;
            // 
            // FrmBuscadorAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1434, 730);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbx_medicamentos);
            this.Controls.Add(this.grpbx_procedimientos);
            this.Controls.Add(this.grpbx_diagnosticos);
            this.Controls.Add(this.grpbx_consultar_control_medico);
            this.Name = "FrmBuscadorAtenciones";
            this.Text = "FISSAL - Buscador de Atenciones";
            this.Load += new System.EventHandler(this.Frm_buscador_fuas_Load);
            this.grpbx_consultar_control_medico.ResumeLayout(false);
            this.grpbx_consultar_control_medico.PerformLayout();
            this.grpbx_diagnosticos.ResumeLayout(false);
            this.grpbx_diagnosticos.PerformLayout();
            this.grpbx_procedimientos.ResumeLayout(false);
            this.grpbx_procedimientos.PerformLayout();
            this.grpbx_medicamentos.ResumeLayout(false);
            this.grpbx_medicamentos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoPaciente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_consultar_control_medico;
        private System.Windows.Forms.CheckBox chkCmReconsideradosSi;
        private System.Windows.Forms.CheckBox chkCmPcppSi;
        private System.Windows.Forms.CheckBox chkCmObsSi;
        private System.Windows.Forms.CheckBox chkCmSi;
        private System.Windows.Forms.Label lblCmReconsiderados;
        private System.Windows.Forms.Label lblCmPcpp;
        private System.Windows.Forms.Label lblCmObs;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.CheckBox chkCmObsNo;
        private System.Windows.Forms.CheckBox chkCmNo;
        private System.Windows.Forms.CheckBox chkCmPcppNo;
        private System.Windows.Forms.CheckBox chkCmReconsideradosNo;
        private System.Windows.Forms.CheckBox chkProcedimientoFpNo;
        private System.Windows.Forms.CheckBox chkProcedimientoFpSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpbx_diagnosticos;
        private System.Windows.Forms.GroupBox grpbx_procedimientos;
        private System.Windows.Forms.GroupBox grpbx_medicamentos;
        private System.Windows.Forms.CheckBox chkMedicamentoFpNo;
        private System.Windows.Forms.CheckBox chkMedicamentoFpSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiagnosticos;
        private System.Windows.Forms.Button btnAbrirSelectorProcedimientos;
        private System.Windows.Forms.TextBox txtProcedimientos;
        private System.Windows.Forms.Button btnAbrirSelectorMedicamentos;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirSelectorCategorias;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMontoTotalFuaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoTotalFuaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarResponsableAtencion;
        private System.Windows.Forms.Label lblDniResponsableAtencion;
        private System.Windows.Forms.TextBox txtDniResponsableAtencion;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.ComboBox cboTipoDocPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDocPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencionDesde;
        private System.Windows.Forms.Label lblFechaDigitacionDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDigitacionHasta;
        private System.Windows.Forms.Label lblFechaAtencionDesde;
        private System.Windows.Forms.Label lblFechaDigitacionHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDigitacionDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencionHasta;
        private System.Windows.Forms.Label lblFechaAtencionHasta;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Button btnSeleccionarControlMedico;
        private System.Windows.Forms.TextBox txtEstablecimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtFechaDigitacionHasta;
        private System.Windows.Forms.TextBox txtFechaDigitacionDesde;
        private System.Windows.Forms.TextBox txtFechaAtencionHasta;
        private System.Windows.Forms.TextBox txtFechaAtencionDesde;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvMovimientoPaciente;
        private System.Windows.Forms.ComboBox cboCantidadSupervision;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fua;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoFua;
        private System.Windows.Forms.TextBox txtCodigoControlMedico;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnBuscarEstablecimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaFinControlMedico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaInicioControlMedico;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cboProduccion;
    }
}

