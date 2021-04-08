namespace FissalWinForm
{
    partial class FrmListaMedProcNoValorizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaMedProcNoValorizado));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tbpGlobal = new System.Windows.Forms.TabPage();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPgRegNoVal = new System.Windows.Forms.Label();
            this.lblRegNoVal = new System.Windows.Forms.Label();
            this.lblPgProcNoVal = new System.Windows.Forms.Label();
            this.lblProcNoVal = new System.Windows.Forms.Label();
            this.lblPgMedNoVal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedNoVal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEESS = new System.Windows.Forms.Button();
            this.txtEESS = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbcEstadistica = new System.Windows.Forms.TabControl();
            this.tbgData = new System.Windows.Forms.TabControl();
            this.tbgMedicamento = new System.Windows.Forms.TabPage();
            this.lblMsjMed = new System.Windows.Forms.Label();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.tbgMedGroup = new System.Windows.Forms.TabPage();
            this.lblMsjMedGroup = new System.Windows.Forms.Label();
            this.dgvMedGroup = new System.Windows.Forms.DataGridView();
            this.tbgProcedimiento = new System.Windows.Forms.TabPage();
            this.lblMsjProc = new System.Windows.Forms.Label();
            this.dgvProcedimiento = new System.Windows.Forms.DataGridView();
            this.tbgProcGroup = new System.Windows.Forms.TabPage();
            this.lblMsjProcGroup = new System.Windows.Forms.Label();
            this.dgvProcGroup = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tbpGlobal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tbcEstadistica.SuspendLayout();
            this.tbgData.SuspendLayout();
            this.tbgMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.tbgMedGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedGroup)).BeginInit();
            this.tbgProcedimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).BeginInit();
            this.tbgProcGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje.Location = new System.Drawing.Point(532, 349);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 415;
            // 
            // tbpGlobal
            // 
            this.tbpGlobal.Controls.Add(this.lblLoading);
            this.tbpGlobal.Controls.Add(this.progressBar);
            this.tbpGlobal.Controls.Add(this.btnExportarExcel);
            this.tbpGlobal.Controls.Add(this.lblMensaje);
            this.tbpGlobal.Controls.Add(this.btnBuscar);
            this.tbpGlobal.Controls.Add(this.txtFechaFin);
            this.tbpGlobal.Controls.Add(this.dtpFechaFin);
            this.tbpGlobal.Controls.Add(this.txtFechaInicio);
            this.tbpGlobal.Controls.Add(this.dtpFechaInicio);
            this.tbpGlobal.Controls.Add(this.groupBox1);
            this.tbpGlobal.Controls.Add(this.label10);
            this.tbpGlobal.Controls.Add(this.label1);
            this.tbpGlobal.Controls.Add(this.groupBox4);
            this.tbpGlobal.Controls.Add(this.dgvData);
            this.tbpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tbpGlobal.Name = "tbpGlobal";
            this.tbpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGlobal.Size = new System.Drawing.Size(1051, 314);
            this.tbpGlobal.TabIndex = 1;
            this.tbpGlobal.Text = "Global";
            this.tbpGlobal.UseVisualStyleBackColor = true;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(519, 243);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 19);
            this.lblLoading.TabIndex = 444;
            this.lblLoading.Text = "Espere un Momento...";
            this.lblLoading.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(519, 271);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(512, 26);
            this.progressBar.TabIndex = 443;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.BackgroundImage")));
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarExcel.Location = new System.Drawing.Point(893, 32);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(35, 35);
            this.btnExportarExcel.TabIndex = 442;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(934, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 441;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(663, 92);
            this.txtFechaFin.MaxLength = 10;
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(70, 20);
            this.txtFechaFin.TabIndex = 440;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(663, 92);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaFin.TabIndex = 439;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(539, 92);
            this.txtFechaInicio.MaxLength = 10;
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(70, 20);
            this.txtFechaInicio.TabIndex = 438;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(539, 92);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaInicio.TabIndex = 437;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPgRegNoVal);
            this.groupBox1.Controls.Add(this.lblRegNoVal);
            this.groupBox1.Controls.Add(this.lblPgProcNoVal);
            this.groupBox1.Controls.Add(this.lblProcNoVal);
            this.groupBox1.Controls.Add(this.lblPgMedNoVal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMedNoVal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(523, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 102);
            this.groupBox1.TabIndex = 435;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(198, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 426;
            this.label4.Text = "Procedimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(293, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 425;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(103, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 424;
            this.label3.Text = "Medicamentos";
            // 
            // lblPgRegNoVal
            // 
            this.lblPgRegNoVal.BackColor = System.Drawing.Color.Blue;
            this.lblPgRegNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPgRegNoVal.ForeColor = System.Drawing.Color.White;
            this.lblPgRegNoVal.Location = new System.Drawing.Point(293, 65);
            this.lblPgRegNoVal.Name = "lblPgRegNoVal";
            this.lblPgRegNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblPgRegNoVal.TabIndex = 423;
            this.lblPgRegNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegNoVal
            // 
            this.lblRegNoVal.BackColor = System.Drawing.Color.Blue;
            this.lblRegNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegNoVal.ForeColor = System.Drawing.Color.White;
            this.lblRegNoVal.Location = new System.Drawing.Point(293, 36);
            this.lblRegNoVal.Name = "lblRegNoVal";
            this.lblRegNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblRegNoVal.TabIndex = 422;
            this.lblRegNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgProcNoVal
            // 
            this.lblPgProcNoVal.BackColor = System.Drawing.Color.Green;
            this.lblPgProcNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPgProcNoVal.ForeColor = System.Drawing.Color.White;
            this.lblPgProcNoVal.Location = new System.Drawing.Point(198, 65);
            this.lblPgProcNoVal.Name = "lblPgProcNoVal";
            this.lblPgProcNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblPgProcNoVal.TabIndex = 421;
            this.lblPgProcNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcNoVal
            // 
            this.lblProcNoVal.BackColor = System.Drawing.Color.Green;
            this.lblProcNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProcNoVal.ForeColor = System.Drawing.Color.White;
            this.lblProcNoVal.Location = new System.Drawing.Point(198, 36);
            this.lblProcNoVal.Name = "lblProcNoVal";
            this.lblProcNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblProcNoVal.TabIndex = 420;
            this.lblProcNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPgMedNoVal
            // 
            this.lblPgMedNoVal.BackColor = System.Drawing.Color.White;
            this.lblPgMedNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPgMedNoVal.ForeColor = System.Drawing.Color.Blue;
            this.lblPgMedNoVal.Location = new System.Drawing.Point(103, 65);
            this.lblPgMedNoVal.Name = "lblPgMedNoVal";
            this.lblPgMedNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblPgMedNoVal.TabIndex = 419;
            this.lblPgMedNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 417;
            this.label6.Text = "%";
            // 
            // lblMedNoVal
            // 
            this.lblMedNoVal.BackColor = System.Drawing.Color.White;
            this.lblMedNoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedNoVal.ForeColor = System.Drawing.Color.Blue;
            this.lblMedNoVal.Location = new System.Drawing.Point(103, 36);
            this.lblMedNoVal.Name = "lblMedNoVal";
            this.lblMedNoVal.Size = new System.Drawing.Size(80, 20);
            this.lblMedNoVal.TabIndex = 416;
            this.lblMedNoVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 414;
            this.label12.Text = "# Registros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(660, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 433;
            this.label10.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 431;
            this.label1.Text = "Fecha Inicio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarEESS);
            this.groupBox4.Controls.Add(this.txtEESS);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(523, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 56);
            this.groupBox4.TabIndex = 429;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selecionar Establecimiento";
            // 
            // btnBuscarEESS
            // 
            this.btnBuscarEESS.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarEESS.Location = new System.Drawing.Point(322, 21);
            this.btnBuscarEESS.Name = "btnBuscarEESS";
            this.btnBuscarEESS.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarEESS.TabIndex = 413;
            this.btnBuscarEESS.Text = "...";
            this.btnBuscarEESS.UseVisualStyleBackColor = true;
            this.btnBuscarEESS.Click += new System.EventHandler(this.btnBuscarEESS_Click);
            // 
            // txtEESS
            // 
            this.txtEESS.ForeColor = System.Drawing.Color.Black;
            this.txtEESS.Location = new System.Drawing.Point(16, 22);
            this.txtEESS.MaxLength = 100;
            this.txtEESS.Name = "txtEESS";
            this.txtEESS.Size = new System.Drawing.Size(300, 21);
            this.txtEESS.TabIndex = 411;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(13, 17);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(500, 280);
            this.dgvData.TabIndex = 32;
            // 
            // tbcEstadistica
            // 
            this.tbcEstadistica.Controls.Add(this.tbpGlobal);
            this.tbcEstadistica.Location = new System.Drawing.Point(12, 12);
            this.tbcEstadistica.Name = "tbcEstadistica";
            this.tbcEstadistica.SelectedIndex = 0;
            this.tbcEstadistica.Size = new System.Drawing.Size(1059, 340);
            this.tbcEstadistica.TabIndex = 416;
            // 
            // tbgData
            // 
            this.tbgData.Controls.Add(this.tbgMedicamento);
            this.tbgData.Controls.Add(this.tbgMedGroup);
            this.tbgData.Controls.Add(this.tbgProcedimiento);
            this.tbgData.Controls.Add(this.tbgProcGroup);
            this.tbgData.Location = new System.Drawing.Point(12, 358);
            this.tbgData.Name = "tbgData";
            this.tbgData.SelectedIndex = 0;
            this.tbgData.Size = new System.Drawing.Size(1063, 360);
            this.tbgData.TabIndex = 433;
            // 
            // tbgMedicamento
            // 
            this.tbgMedicamento.Controls.Add(this.lblMsjMed);
            this.tbgMedicamento.Controls.Add(this.dgvMedicamento);
            this.tbgMedicamento.ForeColor = System.Drawing.Color.Blue;
            this.tbgMedicamento.Location = new System.Drawing.Point(4, 22);
            this.tbgMedicamento.Name = "tbgMedicamento";
            this.tbgMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbgMedicamento.Size = new System.Drawing.Size(1055, 334);
            this.tbgMedicamento.TabIndex = 1;
            this.tbgMedicamento.Text = "Medicamentos";
            this.tbgMedicamento.UseVisualStyleBackColor = true;
            // 
            // lblMsjMed
            // 
            this.lblMsjMed.AutoSize = true;
            this.lblMsjMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjMed.ForeColor = System.Drawing.Color.Blue;
            this.lblMsjMed.Location = new System.Drawing.Point(14, 298);
            this.lblMsjMed.Name = "lblMsjMed";
            this.lblMsjMed.Size = new System.Drawing.Size(0, 16);
            this.lblMsjMed.TabIndex = 416;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.AllowUserToDeleteRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(17, 15);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(1022, 280);
            this.dgvMedicamento.TabIndex = 32;
            // 
            // tbgMedGroup
            // 
            this.tbgMedGroup.Controls.Add(this.lblMsjMedGroup);
            this.tbgMedGroup.Controls.Add(this.dgvMedGroup);
            this.tbgMedGroup.ForeColor = System.Drawing.Color.Blue;
            this.tbgMedGroup.Location = new System.Drawing.Point(4, 22);
            this.tbgMedGroup.Name = "tbgMedGroup";
            this.tbgMedGroup.Size = new System.Drawing.Size(1055, 334);
            this.tbgMedGroup.TabIndex = 3;
            this.tbgMedGroup.Text = "# Medicamentos";
            this.tbgMedGroup.UseVisualStyleBackColor = true;
            // 
            // lblMsjMedGroup
            // 
            this.lblMsjMedGroup.AutoSize = true;
            this.lblMsjMedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjMedGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblMsjMedGroup.Location = new System.Drawing.Point(14, 298);
            this.lblMsjMedGroup.Name = "lblMsjMedGroup";
            this.lblMsjMedGroup.Size = new System.Drawing.Size(0, 16);
            this.lblMsjMedGroup.TabIndex = 418;
            // 
            // dgvMedGroup
            // 
            this.dgvMedGroup.AllowUserToAddRows = false;
            this.dgvMedGroup.AllowUserToDeleteRows = false;
            this.dgvMedGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedGroup.Location = new System.Drawing.Point(17, 15);
            this.dgvMedGroup.Name = "dgvMedGroup";
            this.dgvMedGroup.ReadOnly = true;
            this.dgvMedGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedGroup.Size = new System.Drawing.Size(1022, 280);
            this.dgvMedGroup.TabIndex = 417;
            // 
            // tbgProcedimiento
            // 
            this.tbgProcedimiento.Controls.Add(this.lblMsjProc);
            this.tbgProcedimiento.Controls.Add(this.dgvProcedimiento);
            this.tbgProcedimiento.ForeColor = System.Drawing.Color.Blue;
            this.tbgProcedimiento.Location = new System.Drawing.Point(4, 22);
            this.tbgProcedimiento.Name = "tbgProcedimiento";
            this.tbgProcedimiento.Size = new System.Drawing.Size(1055, 334);
            this.tbgProcedimiento.TabIndex = 2;
            this.tbgProcedimiento.Text = "Procedimientos";
            this.tbgProcedimiento.UseVisualStyleBackColor = true;
            // 
            // lblMsjProc
            // 
            this.lblMsjProc.AutoSize = true;
            this.lblMsjProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjProc.ForeColor = System.Drawing.Color.Blue;
            this.lblMsjProc.Location = new System.Drawing.Point(14, 298);
            this.lblMsjProc.Name = "lblMsjProc";
            this.lblMsjProc.Size = new System.Drawing.Size(0, 16);
            this.lblMsjProc.TabIndex = 417;
            // 
            // dgvProcedimiento
            // 
            this.dgvProcedimiento.AllowUserToAddRows = false;
            this.dgvProcedimiento.AllowUserToDeleteRows = false;
            this.dgvProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimiento.Location = new System.Drawing.Point(17, 15);
            this.dgvProcedimiento.Name = "dgvProcedimiento";
            this.dgvProcedimiento.ReadOnly = true;
            this.dgvProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimiento.Size = new System.Drawing.Size(1022, 280);
            this.dgvProcedimiento.TabIndex = 33;
            // 
            // tbgProcGroup
            // 
            this.tbgProcGroup.Controls.Add(this.lblMsjProcGroup);
            this.tbgProcGroup.Controls.Add(this.dgvProcGroup);
            this.tbgProcGroup.ForeColor = System.Drawing.Color.Blue;
            this.tbgProcGroup.Location = new System.Drawing.Point(4, 22);
            this.tbgProcGroup.Name = "tbgProcGroup";
            this.tbgProcGroup.Size = new System.Drawing.Size(1055, 334);
            this.tbgProcGroup.TabIndex = 4;
            this.tbgProcGroup.Text = "# Procedimientos";
            this.tbgProcGroup.UseVisualStyleBackColor = true;
            // 
            // lblMsjProcGroup
            // 
            this.lblMsjProcGroup.AutoSize = true;
            this.lblMsjProcGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjProcGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblMsjProcGroup.Location = new System.Drawing.Point(14, 298);
            this.lblMsjProcGroup.Name = "lblMsjProcGroup";
            this.lblMsjProcGroup.Size = new System.Drawing.Size(0, 16);
            this.lblMsjProcGroup.TabIndex = 419;
            // 
            // dgvProcGroup
            // 
            this.dgvProcGroup.AllowUserToAddRows = false;
            this.dgvProcGroup.AllowUserToDeleteRows = false;
            this.dgvProcGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcGroup.Location = new System.Drawing.Point(17, 15);
            this.dgvProcGroup.Name = "dgvProcGroup";
            this.dgvProcGroup.ReadOnly = true;
            this.dgvProcGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcGroup.Size = new System.Drawing.Size(1022, 280);
            this.dgvProcGroup.TabIndex = 418;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmListaMedProcNoValorizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 730);
            this.Controls.Add(this.tbgData);
            this.Controls.Add(this.tbcEstadistica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaMedProcNoValorizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Medicamentos y Procedimientos No Valorizados";
            this.Load += new System.EventHandler(this.FrmListaMedProcNoValorizado_Load);
            this.tbpGlobal.ResumeLayout(false);
            this.tbpGlobal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tbcEstadistica.ResumeLayout(false);
            this.tbgData.ResumeLayout(false);
            this.tbgMedicamento.ResumeLayout(false);
            this.tbgMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.tbgMedGroup.ResumeLayout(false);
            this.tbgMedGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedGroup)).EndInit();
            this.tbgProcedimiento.ResumeLayout(false);
            this.tbgProcedimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).EndInit();
            this.tbgProcGroup.ResumeLayout(false);
            this.tbgProcGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TabPage tbpGlobal;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabControl tbcEstadistica;
        private System.Windows.Forms.TabControl tbgData;
        private System.Windows.Forms.TabPage tbgMedicamento;
        private System.Windows.Forms.TabPage tbgProcedimiento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarEESS;
        private System.Windows.Forms.TextBox txtEESS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPgMedNoVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedNoVal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvProcedimiento;
        private System.Windows.Forms.Label lblMsjMed;
        private System.Windows.Forms.Label lblMsjProc;
        private System.Windows.Forms.Label lblPgProcNoVal;
        private System.Windows.Forms.Label lblProcNoVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPgRegNoVal;
        private System.Windows.Forms.Label lblRegNoVal;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.TabPage tbgMedGroup;
        private System.Windows.Forms.Label lblMsjMedGroup;
        private System.Windows.Forms.DataGridView dgvMedGroup;
        private System.Windows.Forms.TabPage tbgProcGroup;
        private System.Windows.Forms.Label lblMsjProcGroup;
        private System.Windows.Forms.DataGridView dgvProcGroup;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblLoading;
    }
}