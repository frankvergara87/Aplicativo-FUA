namespace FissalWinForm
{
    partial class FrmBuscadorAtencionesSis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscadorAtencionesSis));
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAbrirSelectorEstablecimiento = new System.Windows.Forms.Button();
            this.txtEstablecimientos = new System.Windows.Forms.TextBox();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.lblEdadPacienteDesde = new System.Windows.Forms.Label();
            this.txtEdadPacienteDesde = new System.Windows.Forms.TextBox();
            this.lblEdadPacienteHasta = new System.Windows.Forms.Label();
            this.txtEdadPacienteHasta = new System.Windows.Forms.TextBox();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.cboSexoPaciente = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumentoPaciente = new System.Windows.Forms.Label();
            this.txtNumeroDocumentoPaciente = new System.Windows.Forms.TextBox();
            this.grpbxMedicamentos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorMedicamentos = new System.Windows.Forms.Button();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.grpbxProcedimientos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorProcedimientos = new System.Windows.Forms.Button();
            this.txtProcedimientos = new System.Windows.Forms.TextBox();
            this.grpbxDiagnosticos = new System.Windows.Forms.GroupBox();
            this.btnAbrirSelectorCategorias = new System.Windows.Forms.Button();
            this.txtDiagnosticos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMesProduccionHasta = new System.Windows.Forms.Label();
            this.txtMesProduccionHasta = new System.Windows.Forms.TextBox();
            this.lblPeriodoProduccionHasta = new System.Windows.Forms.Label();
            this.txtPeriodoProduccionHasta = new System.Windows.Forms.TextBox();
            this.lblPeriodoProduccionDesde = new System.Windows.Forms.Label();
            this.txtPeriodoProduccionDesde = new System.Windows.Forms.TextBox();
            this.txtMesProduccionDesde = new System.Windows.Forms.TextBox();
            this.lblMesProduccionDesde = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboObservado = new System.Windows.Forms.ComboBox();
            this.lblObservado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTransferenciaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTransferenciaDesde = new System.Windows.Forms.Label();
            this.dtpTransferenciaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtTransferenciaDesde = new System.Windows.Forms.TextBox();
            this.lblTransferenciaHasta = new System.Windows.Forms.Label();
            this.txtTransferenciaHasta = new System.Windows.Forms.TextBox();
            this.dtpFechaAtencionHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAtencionDesde = new System.Windows.Forms.Label();
            this.dtpFechaAtencionDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFechaAtencionDesde = new System.Windows.Forms.TextBox();
            this.lblFechaAtencionHasta = new System.Windows.Forms.Label();
            this.txtFechaAtencionHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegiones = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAtencionesSis = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.stsStpBuscador.SuspendLayout();
            this.grpPaciente.SuspendLayout();
            this.grpbxMedicamentos.SuspendLayout();
            this.grpbxProcedimientos.SuspendLayout();
            this.grpbxDiagnosticos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencionesSis)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.stsStpBuscador.TabIndex = 117;
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
            // btnAbrirSelectorEstablecimiento
            // 
            this.btnAbrirSelectorEstablecimiento.Location = new System.Drawing.Point(298, 44);
            this.btnAbrirSelectorEstablecimiento.Name = "btnAbrirSelectorEstablecimiento";
            this.btnAbrirSelectorEstablecimiento.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorEstablecimiento.TabIndex = 3;
            this.btnAbrirSelectorEstablecimiento.Text = "...";
            this.btnAbrirSelectorEstablecimiento.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorEstablecimiento.Click += new System.EventHandler(this.btnAbrirSelectorEstablecimiento_Click);
            // 
            // txtEstablecimientos
            // 
            this.txtEstablecimientos.Location = new System.Drawing.Point(112, 44);
            this.txtEstablecimientos.Name = "txtEstablecimientos";
            this.txtEstablecimientos.Size = new System.Drawing.Size(180, 20);
            this.txtEstablecimientos.TabIndex = 2;
            this.txtEstablecimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstablecimientos_KeyDown);
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoPaciente.Location = new System.Drawing.Point(209, 23);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(31, 13);
            this.lblSexoPaciente.TabIndex = 132;
            this.lblSexoPaciente.Text = "Sexo";
            // 
            // lblEdadPacienteDesde
            // 
            this.lblEdadPacienteDesde.AutoSize = true;
            this.lblEdadPacienteDesde.Location = new System.Drawing.Point(17, 48);
            this.lblEdadPacienteDesde.Name = "lblEdadPacienteDesde";
            this.lblEdadPacienteDesde.Size = new System.Drawing.Size(66, 13);
            this.lblEdadPacienteDesde.TabIndex = 137;
            this.lblEdadPacienteDesde.Text = "Edad Desde";
            // 
            // txtEdadPacienteDesde
            // 
            this.txtEdadPacienteDesde.Location = new System.Drawing.Point(112, 45);
            this.txtEdadPacienteDesde.Name = "txtEdadPacienteDesde";
            this.txtEdadPacienteDesde.Size = new System.Drawing.Size(90, 20);
            this.txtEdadPacienteDesde.TabIndex = 2;
            this.txtEdadPacienteDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdadPacienteDesde_KeyDown);
            // 
            // lblEdadPacienteHasta
            // 
            this.lblEdadPacienteHasta.AutoSize = true;
            this.lblEdadPacienteHasta.Location = new System.Drawing.Point(209, 48);
            this.lblEdadPacienteHasta.Name = "lblEdadPacienteHasta";
            this.lblEdadPacienteHasta.Size = new System.Drawing.Size(35, 13);
            this.lblEdadPacienteHasta.TabIndex = 138;
            this.lblEdadPacienteHasta.Text = "Hasta";
            // 
            // txtEdadPacienteHasta
            // 
            this.txtEdadPacienteHasta.Location = new System.Drawing.Point(257, 45);
            this.txtEdadPacienteHasta.Name = "txtEdadPacienteHasta";
            this.txtEdadPacienteHasta.Size = new System.Drawing.Size(90, 20);
            this.txtEdadPacienteHasta.TabIndex = 3;
            this.txtEdadPacienteHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdadPacienteHasta_KeyDown);
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.cboSexoPaciente);
            this.grpPaciente.Controls.Add(this.lblNumeroDocumentoPaciente);
            this.grpPaciente.Controls.Add(this.lblSexoPaciente);
            this.grpPaciente.Controls.Add(this.lblEdadPacienteDesde);
            this.grpPaciente.Controls.Add(this.txtNumeroDocumentoPaciente);
            this.grpPaciente.Controls.Add(this.txtEdadPacienteDesde);
            this.grpPaciente.Controls.Add(this.txtEdadPacienteHasta);
            this.grpPaciente.Controls.Add(this.lblEdadPacienteHasta);
            this.grpPaciente.Location = new System.Drawing.Point(381, 32);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(364, 76);
            this.grpPaciente.TabIndex = 1;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Paciente";
            // 
            // cboSexoPaciente
            // 
            this.cboSexoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoPaciente.FormattingEnabled = true;
            this.cboSexoPaciente.Location = new System.Drawing.Point(257, 19);
            this.cboSexoPaciente.Name = "cboSexoPaciente";
            this.cboSexoPaciente.Size = new System.Drawing.Size(90, 21);
            this.cboSexoPaciente.TabIndex = 1;
            this.cboSexoPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSexoPaciente_KeyDown);
            // 
            // lblNumeroDocumentoPaciente
            // 
            this.lblNumeroDocumentoPaciente.AutoSize = true;
            this.lblNumeroDocumentoPaciente.Location = new System.Drawing.Point(17, 23);
            this.lblNumeroDocumentoPaciente.Name = "lblNumeroDocumentoPaciente";
            this.lblNumeroDocumentoPaciente.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroDocumentoPaciente.TabIndex = 82;
            this.lblNumeroDocumentoPaciente.Text = "N° Documento";
            // 
            // txtNumeroDocumentoPaciente
            // 
            this.txtNumeroDocumentoPaciente.Location = new System.Drawing.Point(112, 19);
            this.txtNumeroDocumentoPaciente.Name = "txtNumeroDocumentoPaciente";
            this.txtNumeroDocumentoPaciente.Size = new System.Drawing.Size(90, 20);
            this.txtNumeroDocumentoPaciente.TabIndex = 0;
            this.txtNumeroDocumentoPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumentoPaciente_KeyDown);
            // 
            // grpbxMedicamentos
            // 
            this.grpbxMedicamentos.Controls.Add(this.btnAbrirSelectorMedicamentos);
            this.grpbxMedicamentos.Controls.Add(this.txtMedicamentos);
            this.grpbxMedicamentos.Location = new System.Drawing.Point(751, 140);
            this.grpbxMedicamentos.Name = "grpbxMedicamentos";
            this.grpbxMedicamentos.Size = new System.Drawing.Size(245, 49);
            this.grpbxMedicamentos.TabIndex = 5;
            this.grpbxMedicamentos.TabStop = false;
            this.grpbxMedicamentos.Text = "Medicamentos";
            // 
            // btnAbrirSelectorMedicamentos
            // 
            this.btnAbrirSelectorMedicamentos.Location = new System.Drawing.Point(204, 19);
            this.btnAbrirSelectorMedicamentos.Name = "btnAbrirSelectorMedicamentos";
            this.btnAbrirSelectorMedicamentos.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorMedicamentos.TabIndex = 1;
            this.btnAbrirSelectorMedicamentos.Text = "...";
            this.btnAbrirSelectorMedicamentos.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorMedicamentos.Click += new System.EventHandler(this.btnAbrirSelectorMedicamentos_Click);
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Location = new System.Drawing.Point(18, 20);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(180, 20);
            this.txtMedicamentos.TabIndex = 0;
            this.txtMedicamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedicamentos_KeyDown);
            // 
            // grpbxProcedimientos
            // 
            this.grpbxProcedimientos.Controls.Add(this.btnAbrirSelectorProcedimientos);
            this.grpbxProcedimientos.Controls.Add(this.txtProcedimientos);
            this.grpbxProcedimientos.Location = new System.Drawing.Point(751, 86);
            this.grpbxProcedimientos.Name = "grpbxProcedimientos";
            this.grpbxProcedimientos.Size = new System.Drawing.Size(245, 48);
            this.grpbxProcedimientos.TabIndex = 4;
            this.grpbxProcedimientos.TabStop = false;
            this.grpbxProcedimientos.Text = "Procedimientos";
            // 
            // btnAbrirSelectorProcedimientos
            // 
            this.btnAbrirSelectorProcedimientos.Location = new System.Drawing.Point(204, 19);
            this.btnAbrirSelectorProcedimientos.Name = "btnAbrirSelectorProcedimientos";
            this.btnAbrirSelectorProcedimientos.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorProcedimientos.TabIndex = 1;
            this.btnAbrirSelectorProcedimientos.Text = "...";
            this.btnAbrirSelectorProcedimientos.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorProcedimientos.Click += new System.EventHandler(this.btnAbrirSelectorProcedimientos_Click);
            // 
            // txtProcedimientos
            // 
            this.txtProcedimientos.Location = new System.Drawing.Point(18, 20);
            this.txtProcedimientos.Name = "txtProcedimientos";
            this.txtProcedimientos.Size = new System.Drawing.Size(180, 20);
            this.txtProcedimientos.TabIndex = 0;
            this.txtProcedimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcedimientos_KeyDown);
            // 
            // grpbxDiagnosticos
            // 
            this.grpbxDiagnosticos.Controls.Add(this.btnAbrirSelectorCategorias);
            this.grpbxDiagnosticos.Controls.Add(this.txtDiagnosticos);
            this.grpbxDiagnosticos.Location = new System.Drawing.Point(751, 32);
            this.grpbxDiagnosticos.Name = "grpbxDiagnosticos";
            this.grpbxDiagnosticos.Size = new System.Drawing.Size(245, 48);
            this.grpbxDiagnosticos.TabIndex = 3;
            this.grpbxDiagnosticos.TabStop = false;
            this.grpbxDiagnosticos.Text = "Diagnosticos";
            // 
            // btnAbrirSelectorCategorias
            // 
            this.btnAbrirSelectorCategorias.Location = new System.Drawing.Point(204, 19);
            this.btnAbrirSelectorCategorias.Name = "btnAbrirSelectorCategorias";
            this.btnAbrirSelectorCategorias.Size = new System.Drawing.Size(30, 20);
            this.btnAbrirSelectorCategorias.TabIndex = 1;
            this.btnAbrirSelectorCategorias.Text = "...";
            this.btnAbrirSelectorCategorias.UseVisualStyleBackColor = true;
            this.btnAbrirSelectorCategorias.Click += new System.EventHandler(this.btnAbrirSelectorCategorias_Click);
            // 
            // txtDiagnosticos
            // 
            this.txtDiagnosticos.Location = new System.Drawing.Point(18, 20);
            this.txtDiagnosticos.Name = "txtDiagnosticos";
            this.txtDiagnosticos.Size = new System.Drawing.Size(180, 20);
            this.txtDiagnosticos.TabIndex = 0;
            this.txtDiagnosticos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiagnosticos_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMesProduccionHasta);
            this.groupBox1.Controls.Add(this.txtMesProduccionHasta);
            this.groupBox1.Controls.Add(this.lblPeriodoProduccionHasta);
            this.groupBox1.Controls.Add(this.txtPeriodoProduccionHasta);
            this.groupBox1.Controls.Add(this.lblPeriodoProduccionDesde);
            this.groupBox1.Controls.Add(this.txtPeriodoProduccionDesde);
            this.groupBox1.Controls.Add(this.txtMesProduccionDesde);
            this.groupBox1.Controls.Add(this.lblMesProduccionDesde);
            this.groupBox1.Location = new System.Drawing.Point(381, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produccion";
            // 
            // lblMesProduccionHasta
            // 
            this.lblMesProduccionHasta.AutoSize = true;
            this.lblMesProduccionHasta.Location = new System.Drawing.Point(209, 48);
            this.lblMesProduccionHasta.Name = "lblMesProduccionHasta";
            this.lblMesProduccionHasta.Size = new System.Drawing.Size(35, 13);
            this.lblMesProduccionHasta.TabIndex = 88;
            this.lblMesProduccionHasta.Text = "Hasta";
            // 
            // txtMesProduccionHasta
            // 
            this.txtMesProduccionHasta.Location = new System.Drawing.Point(257, 45);
            this.txtMesProduccionHasta.Name = "txtMesProduccionHasta";
            this.txtMesProduccionHasta.Size = new System.Drawing.Size(90, 20);
            this.txtMesProduccionHasta.TabIndex = 3;
            this.txtMesProduccionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMesProduccionHasta_KeyDown);
            // 
            // lblPeriodoProduccionHasta
            // 
            this.lblPeriodoProduccionHasta.AutoSize = true;
            this.lblPeriodoProduccionHasta.Location = new System.Drawing.Point(209, 23);
            this.lblPeriodoProduccionHasta.Name = "lblPeriodoProduccionHasta";
            this.lblPeriodoProduccionHasta.Size = new System.Drawing.Size(35, 13);
            this.lblPeriodoProduccionHasta.TabIndex = 86;
            this.lblPeriodoProduccionHasta.Text = "Hasta";
            // 
            // txtPeriodoProduccionHasta
            // 
            this.txtPeriodoProduccionHasta.Location = new System.Drawing.Point(257, 19);
            this.txtPeriodoProduccionHasta.Name = "txtPeriodoProduccionHasta";
            this.txtPeriodoProduccionHasta.Size = new System.Drawing.Size(90, 20);
            this.txtPeriodoProduccionHasta.TabIndex = 1;
            this.txtPeriodoProduccionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPeriodoProduccionHasta_KeyDown);
            // 
            // lblPeriodoProduccionDesde
            // 
            this.lblPeriodoProduccionDesde.AutoSize = true;
            this.lblPeriodoProduccionDesde.Location = new System.Drawing.Point(17, 23);
            this.lblPeriodoProduccionDesde.Name = "lblPeriodoProduccionDesde";
            this.lblPeriodoProduccionDesde.Size = new System.Drawing.Size(77, 13);
            this.lblPeriodoProduccionDesde.TabIndex = 82;
            this.lblPeriodoProduccionDesde.Text = "Periodo Desde";
            // 
            // txtPeriodoProduccionDesde
            // 
            this.txtPeriodoProduccionDesde.Location = new System.Drawing.Point(112, 19);
            this.txtPeriodoProduccionDesde.Name = "txtPeriodoProduccionDesde";
            this.txtPeriodoProduccionDesde.Size = new System.Drawing.Size(90, 20);
            this.txtPeriodoProduccionDesde.TabIndex = 0;
            this.txtPeriodoProduccionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPeriodoProduccionDesde_KeyDown);
            // 
            // txtMesProduccionDesde
            // 
            this.txtMesProduccionDesde.Location = new System.Drawing.Point(112, 45);
            this.txtMesProduccionDesde.Name = "txtMesProduccionDesde";
            this.txtMesProduccionDesde.Size = new System.Drawing.Size(90, 20);
            this.txtMesProduccionDesde.TabIndex = 2;
            this.txtMesProduccionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMesProduccionDesde_KeyDown);
            // 
            // lblMesProduccionDesde
            // 
            this.lblMesProduccionDesde.AutoSize = true;
            this.lblMesProduccionDesde.Location = new System.Drawing.Point(17, 48);
            this.lblMesProduccionDesde.Name = "lblMesProduccionDesde";
            this.lblMesProduccionDesde.Size = new System.Drawing.Size(27, 13);
            this.lblMesProduccionDesde.TabIndex = 84;
            this.lblMesProduccionDesde.Text = "Mes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cboObservado);
            this.groupBox2.Controls.Add(this.btnAbrirSelectorEstablecimiento);
            this.groupBox2.Controls.Add(this.lblObservado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEstablecimientos);
            this.groupBox2.Controls.Add(this.dtpTransferenciaHasta);
            this.groupBox2.Controls.Add(this.lblTransferenciaDesde);
            this.groupBox2.Controls.Add(this.dtpTransferenciaDesde);
            this.groupBox2.Controls.Add(this.txtTransferenciaDesde);
            this.groupBox2.Controls.Add(this.lblTransferenciaHasta);
            this.groupBox2.Controls.Add(this.txtTransferenciaHasta);
            this.groupBox2.Controls.Add(this.dtpFechaAtencionHasta);
            this.groupBox2.Controls.Add(this.lblFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.dtpFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.txtFechaAtencionDesde);
            this.groupBox2.Controls.Add(this.lblFechaAtencionHasta);
            this.groupBox2.Controls.Add(this.txtFechaAtencionHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRegiones);
            this.groupBox2.Location = new System.Drawing.Point(8, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Atencion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // cboObservado
            // 
            this.cboObservado.FormattingEnabled = true;
            this.cboObservado.Location = new System.Drawing.Point(112, 69);
            this.cboObservado.Name = "cboObservado";
            this.cboObservado.Size = new System.Drawing.Size(180, 21);
            this.cboObservado.TabIndex = 4;
            this.cboObservado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboObservado_KeyDown);
            // 
            // lblObservado
            // 
            this.lblObservado.AutoSize = true;
            this.lblObservado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservado.Location = new System.Drawing.Point(17, 73);
            this.lblObservado.Name = "lblObservado";
            this.lblObservado.Size = new System.Drawing.Size(64, 13);
            this.lblObservado.TabIndex = 168;
            this.lblObservado.Text = "Observados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Establecimientos";
            // 
            // dtpTransferenciaHasta
            // 
            this.dtpTransferenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransferenciaHasta.Location = new System.Drawing.Point(341, 119);
            this.dtpTransferenciaHasta.Name = "dtpTransferenciaHasta";
            this.dtpTransferenciaHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpTransferenciaHasta.TabIndex = 11;
            this.dtpTransferenciaHasta.ValueChanged += new System.EventHandler(this.dtpTransferenciaHasta_ValueChanged);
            // 
            // lblTransferenciaDesde
            // 
            this.lblTransferenciaDesde.AutoSize = true;
            this.lblTransferenciaDesde.Location = new System.Drawing.Point(17, 123);
            this.lblTransferenciaDesde.Name = "lblTransferenciaDesde";
            this.lblTransferenciaDesde.Size = new System.Drawing.Size(96, 13);
            this.lblTransferenciaDesde.TabIndex = 165;
            this.lblTransferenciaDesde.Text = "Per. Transf. Desde";
            // 
            // dtpTransferenciaDesde
            // 
            this.dtpTransferenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransferenciaDesde.Location = new System.Drawing.Point(188, 119);
            this.dtpTransferenciaDesde.Name = "dtpTransferenciaDesde";
            this.dtpTransferenciaDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpTransferenciaDesde.TabIndex = 9;
            this.dtpTransferenciaDesde.ValueChanged += new System.EventHandler(this.dtpTransferenciaDesde_ValueChanged);
            // 
            // txtTransferenciaDesde
            // 
            this.txtTransferenciaDesde.Location = new System.Drawing.Point(112, 119);
            this.txtTransferenciaDesde.Name = "txtTransferenciaDesde";
            this.txtTransferenciaDesde.Size = new System.Drawing.Size(70, 20);
            this.txtTransferenciaDesde.TabIndex = 10;
            this.txtTransferenciaDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransferenciaDesde_KeyDown);
            // 
            // lblTransferenciaHasta
            // 
            this.lblTransferenciaHasta.AutoSize = true;
            this.lblTransferenciaHasta.Location = new System.Drawing.Point(219, 123);
            this.lblTransferenciaHasta.Name = "lblTransferenciaHasta";
            this.lblTransferenciaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblTransferenciaHasta.TabIndex = 166;
            this.lblTransferenciaHasta.Text = "Hasta";
            // 
            // txtTransferenciaHasta
            // 
            this.txtTransferenciaHasta.Location = new System.Drawing.Point(265, 119);
            this.txtTransferenciaHasta.Name = "txtTransferenciaHasta";
            this.txtTransferenciaHasta.Size = new System.Drawing.Size(70, 20);
            this.txtTransferenciaHasta.TabIndex = 12;
            this.txtTransferenciaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransferenciaHasta_KeyDown);
            // 
            // dtpFechaAtencionHasta
            // 
            this.dtpFechaAtencionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAtencionHasta.Location = new System.Drawing.Point(341, 94);
            this.dtpFechaAtencionHasta.Name = "dtpFechaAtencionHasta";
            this.dtpFechaAtencionHasta.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaAtencionHasta.TabIndex = 7;
            this.dtpFechaAtencionHasta.ValueChanged += new System.EventHandler(this.dtpFechaAtencionHasta_ValueChanged);
            // 
            // lblFechaAtencionDesde
            // 
            this.lblFechaAtencionDesde.AutoSize = true;
            this.lblFechaAtencionDesde.Location = new System.Drawing.Point(17, 98);
            this.lblFechaAtencionDesde.Name = "lblFechaAtencionDesde";
            this.lblFechaAtencionDesde.Size = new System.Drawing.Size(95, 13);
            this.lblFechaAtencionDesde.TabIndex = 156;
            this.lblFechaAtencionDesde.Text = "F. Atencion Desde";
            // 
            // dtpFechaAtencionDesde
            // 
            this.dtpFechaAtencionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAtencionDesde.Location = new System.Drawing.Point(188, 94);
            this.dtpFechaAtencionDesde.Name = "dtpFechaAtencionDesde";
            this.dtpFechaAtencionDesde.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaAtencionDesde.TabIndex = 5;
            this.dtpFechaAtencionDesde.ValueChanged += new System.EventHandler(this.dtpFechaAtencionDesde_ValueChanged);
            // 
            // txtFechaAtencionDesde
            // 
            this.txtFechaAtencionDesde.Location = new System.Drawing.Point(112, 94);
            this.txtFechaAtencionDesde.Name = "txtFechaAtencionDesde";
            this.txtFechaAtencionDesde.Size = new System.Drawing.Size(70, 20);
            this.txtFechaAtencionDesde.TabIndex = 6;
            this.txtFechaAtencionDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaAtencionDesde_KeyDown);
            // 
            // lblFechaAtencionHasta
            // 
            this.lblFechaAtencionHasta.AutoSize = true;
            this.lblFechaAtencionHasta.Location = new System.Drawing.Point(219, 98);
            this.lblFechaAtencionHasta.Name = "lblFechaAtencionHasta";
            this.lblFechaAtencionHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaAtencionHasta.TabIndex = 157;
            this.lblFechaAtencionHasta.Text = "Hasta";
            // 
            // txtFechaAtencionHasta
            // 
            this.txtFechaAtencionHasta.Location = new System.Drawing.Point(265, 94);
            this.txtFechaAtencionHasta.Name = "txtFechaAtencionHasta";
            this.txtFechaAtencionHasta.Size = new System.Drawing.Size(70, 20);
            this.txtFechaAtencionHasta.TabIndex = 8;
            this.txtFechaAtencionHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaAtencionHasta_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 150;
            this.label1.Text = "Regiones";
            // 
            // txtRegiones
            // 
            this.txtRegiones.Location = new System.Drawing.Point(112, 19);
            this.txtRegiones.Name = "txtRegiones";
            this.txtRegiones.Size = new System.Drawing.Size(180, 20);
            this.txtRegiones.TabIndex = 0;
            this.txtRegiones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegiones_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvAtencionesSis);
            this.groupBox3.Location = new System.Drawing.Point(8, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 510);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados de la busqueda";
            // 
            // dgvAtencionesSis
            // 
            this.dgvAtencionesSis.AllowUserToAddRows = false;
            this.dgvAtencionesSis.AllowUserToDeleteRows = false;
            this.dgvAtencionesSis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtencionesSis.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAtencionesSis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtencionesSis.Location = new System.Drawing.Point(20, 19);
            this.dgvAtencionesSis.Name = "dgvAtencionesSis";
            this.dgvAtencionesSis.ReadOnly = true;
            this.dgvAtencionesSis.Size = new System.Drawing.Size(957, 485);
            this.dgvAtencionesSis.TabIndex = 0;
            this.dgvAtencionesSis.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAtencionesSis_DataBindingComplete_1);
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
            this.toolStrip1.TabIndex = 118;
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
            // FrmBuscadorAtencionesSis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxMedicamentos);
            this.Controls.Add(this.grpbxProcedimientos);
            this.Controls.Add(this.grpbxDiagnosticos);
            this.Controls.Add(this.grpPaciente);
            this.Controls.Add(this.stsStpBuscador);
            this.Name = "FrmBuscadorAtencionesSis";
            this.Text = "Buscador de Atenciones SIS";
            this.Load += new System.EventHandler(this.FrmBuscadorAtencionesSis_Load);
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpbxMedicamentos.ResumeLayout(false);
            this.grpbxMedicamentos.PerformLayout();
            this.grpbxProcedimientos.ResumeLayout(false);
            this.grpbxProcedimientos.PerformLayout();
            this.grpbxDiagnosticos.ResumeLayout(false);
            this.grpbxDiagnosticos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencionesSis)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.Button btnAbrirSelectorEstablecimiento;
        private System.Windows.Forms.TextBox txtEstablecimientos;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.Label lblEdadPacienteDesde;
        private System.Windows.Forms.TextBox txtEdadPacienteDesde;
        private System.Windows.Forms.Label lblEdadPacienteHasta;
        private System.Windows.Forms.TextBox txtEdadPacienteHasta;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Label lblNumeroDocumentoPaciente;
        private System.Windows.Forms.TextBox txtNumeroDocumentoPaciente;
        private System.Windows.Forms.GroupBox grpbxMedicamentos;
        private System.Windows.Forms.Button btnAbrirSelectorMedicamentos;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.GroupBox grpbxProcedimientos;
        private System.Windows.Forms.Button btnAbrirSelectorProcedimientos;
        private System.Windows.Forms.TextBox txtProcedimientos;
        private System.Windows.Forms.GroupBox grpbxDiagnosticos;
        private System.Windows.Forms.Button btnAbrirSelectorCategorias;
        private System.Windows.Forms.TextBox txtDiagnosticos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPeriodoProduccionDesde;
        private System.Windows.Forms.TextBox txtPeriodoProduccionDesde;
        private System.Windows.Forms.TextBox txtMesProduccionDesde;
        private System.Windows.Forms.Label lblMesProduccionDesde;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTransferenciaHasta;
        private System.Windows.Forms.Label lblTransferenciaDesde;
        private System.Windows.Forms.DateTimePicker dtpTransferenciaDesde;
        private System.Windows.Forms.TextBox txtTransferenciaDesde;
        private System.Windows.Forms.Label lblTransferenciaHasta;
        private System.Windows.Forms.TextBox txtTransferenciaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencionHasta;
        private System.Windows.Forms.Label lblFechaAtencionDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencionDesde;
        private System.Windows.Forms.TextBox txtFechaAtencionDesde;
        private System.Windows.Forms.Label lblFechaAtencionHasta;
        private System.Windows.Forms.TextBox txtFechaAtencionHasta;
        private System.Windows.Forms.TextBox txtRegiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSexoPaciente;
        private System.Windows.Forms.TextBox txtPeriodoProduccionHasta;
        private System.Windows.Forms.Label lblPeriodoProduccionHasta;
        private System.Windows.Forms.Label lblMesProduccionHasta;
        private System.Windows.Forms.TextBox txtMesProduccionHasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboObservado;
        private System.Windows.Forms.Label lblObservado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAtencionesSis;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
    }
}