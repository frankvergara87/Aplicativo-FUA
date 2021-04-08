namespace FissalWinForm
{
    partial class FrmBuscarAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarAtencion));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.opcFec02 = new System.Windows.Forms.RadioButton();
            this.opcFec01 = new System.Windows.Forms.RadioButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumCorrelativo = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNumLote = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opc02 = new System.Windows.Forms.RadioButton();
            this.opc03 = new System.Windows.Forms.RadioButton();
            this.opc01 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAtencion = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.grpFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblLoading);
            this.groupBox4.Controls.Add(this.cboTipoDoc);
            this.groupBox4.Controls.Add(this.grpFecha);
            this.groupBox4.Controls.Add(this.txtNumCorrelativo);
            this.groupBox4.Controls.Add(this.txtDNI);
            this.groupBox4.Controls.Add(this.txtNumLote);
            this.groupBox4.Controls.Add(this.txtPaciente);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.opc02);
            this.groupBox4.Controls.Add(this.opc03);
            this.groupBox4.Controls.Add(this.opc01);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1084, 111);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar Opcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 439;
            this.label4.Text = "0 - ";
            this.label4.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(440, 49);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 19);
            this.lblLoading.TabIndex = 409;
            this.lblLoading.Text = "Espere un Momento...";
            this.lblLoading.Visible = false;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.Enabled = false;
            this.cboTipoDoc.ForeColor = System.Drawing.Color.Black;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(197, 49);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(92, 21);
            this.cboTipoDoc.TabIndex = 2;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboTipoDoc_SelectedIndexChanged);
            // 
            // grpFecha
            // 
            this.grpFecha.Controls.Add(this.opcFec02);
            this.grpFecha.Controls.Add(this.opcFec01);
            this.grpFecha.Controls.Add(this.dtpFechaFin);
            this.grpFecha.Controls.Add(this.label10);
            this.grpFecha.Controls.Add(this.dtpFechaInicio);
            this.grpFecha.Controls.Add(this.label7);
            this.grpFecha.Location = new System.Drawing.Point(631, 16);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Size = new System.Drawing.Size(438, 79);
            this.grpFecha.TabIndex = 407;
            this.grpFecha.TabStop = false;
            // 
            // opcFec02
            // 
            this.opcFec02.AutoSize = true;
            this.opcFec02.ForeColor = System.Drawing.Color.Black;
            this.opcFec02.Location = new System.Drawing.Point(29, 41);
            this.opcFec02.Name = "opcFec02";
            this.opcFec02.Size = new System.Drawing.Size(112, 17);
            this.opcFec02.TabIndex = 1;
            this.opcFec02.TabStop = true;
            this.opcFec02.Text = "Fecha de Registro";
            this.opcFec02.UseVisualStyleBackColor = true;
            this.opcFec02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion);
            // 
            // opcFec01
            // 
            this.opcFec01.AutoSize = true;
            this.opcFec01.ForeColor = System.Drawing.Color.Black;
            this.opcFec01.Location = new System.Drawing.Point(29, 23);
            this.opcFec01.Name = "opcFec01";
            this.opcFec01.Size = new System.Drawing.Size(114, 17);
            this.opcFec01.TabIndex = 0;
            this.opcFec01.TabStop = true;
            this.opcFec01.Text = "Fecha de Atencion";
            this.opcFec01.UseVisualStyleBackColor = true;
            this.opcFec01.Visible = false;
            this.opcFec01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(290, 41);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 21);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            this.dtpFechaFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 408;
            this.label10.Text = "Fin";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(166, 41);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 21);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            this.dtpFechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 406;
            this.label7.Text = "Inicio";
            // 
            // txtNumCorrelativo
            // 
            this.txtNumCorrelativo.Enabled = false;
            this.txtNumCorrelativo.ForeColor = System.Drawing.Color.Blue;
            this.txtNumCorrelativo.Location = new System.Drawing.Point(233, 20);
            this.txtNumCorrelativo.MaxLength = 8;
            this.txtNumCorrelativo.Name = "txtNumCorrelativo";
            this.txtNumCorrelativo.Size = new System.Drawing.Size(124, 21);
            this.txtNumCorrelativo.TabIndex = 1;
            this.txtNumCorrelativo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion);
            this.txtNumCorrelativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            this.txtNumCorrelativo.Leave += new System.EventHandler(this.txtNumCorrelativo_Leave);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.ForeColor = System.Drawing.Color.Blue;
            this.txtDNI.Location = new System.Drawing.Point(316, 49);
            this.txtDNI.MaxLength = 12;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(103, 21);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion2);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // txtNumLote
            // 
            this.txtNumLote.Enabled = false;
            this.txtNumLote.ForeColor = System.Drawing.Color.Blue;
            this.txtNumLote.Location = new System.Drawing.Point(197, 20);
            this.txtNumLote.MaxLength = 2;
            this.txtNumLote.Name = "txtNumLote";
            this.txtNumLote.Size = new System.Drawing.Size(30, 21);
            this.txtNumLote.TabIndex = 0;
            this.txtNumLote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumLote_KeyDown);
            this.txtNumLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // txtPaciente
            // 
            this.txtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaciente.Enabled = false;
            this.txtPaciente.ForeColor = System.Drawing.Color.Blue;
            this.txtPaciente.Location = new System.Drawing.Point(197, 78);
            this.txtPaciente.MaxLength = 50;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(350, 21);
            this.txtPaciente.TabIndex = 4;
            this.txtPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiltrarAtencion3);
            this.txtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaciente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(180, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 389;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 388;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 387;
            this.label1.Text = ":";
            // 
            // opc02
            // 
            this.opc02.AutoSize = true;
            this.opc02.Location = new System.Drawing.Point(16, 49);
            this.opc02.Name = "opc02";
            this.opc02.Size = new System.Drawing.Size(118, 17);
            this.opc02.TabIndex = 386;
            this.opc02.TabStop = true;
            this.opc02.Text = "Por Nro Documento";
            this.opc02.UseVisualStyleBackColor = true;
            this.opc02.CheckedChanged += new System.EventHandler(this.opc02_CheckedChanged);
            // 
            // opc03
            // 
            this.opc03.AutoSize = true;
            this.opc03.Location = new System.Drawing.Point(16, 78);
            this.opc03.Name = "opc03";
            this.opc03.Size = new System.Drawing.Size(140, 17);
            this.opc03.TabIndex = 385;
            this.opc03.TabStop = true;
            this.opc03.Text = "Por Apellidos y Nombres";
            this.opc03.UseVisualStyleBackColor = true;
            this.opc03.CheckedChanged += new System.EventHandler(this.opc03_CheckedChanged);
            // 
            // opc01
            // 
            this.opc01.AutoSize = true;
            this.opc01.Location = new System.Drawing.Point(16, 20);
            this.opc01.Name = "opc01";
            this.opc01.Size = new System.Drawing.Size(128, 17);
            this.opc01.TabIndex = 384;
            this.opc01.TabStop = true;
            this.opc01.Text = "Por Lote - Correlativo";
            this.opc01.UseVisualStyleBackColor = true;
            this.opc01.CheckedChanged += new System.EventHandler(this.opc01_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAtencion);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 257);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Atenciones";
            // 
            // dgvAtencion
            // 
            this.dgvAtencion.AllowUserToAddRows = false;
            this.dgvAtencion.AllowUserToDeleteRows = false;
            this.dgvAtencion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtencion.Location = new System.Drawing.Point(16, 20);
            this.dgvAtencion.Name = "dgvAtencion";
            this.dgvAtencion.ReadOnly = true;
            this.dgvAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtencion.Size = new System.Drawing.Size(1053, 222);
            this.dgvAtencion.TabIndex = 0;
            this.dgvAtencion.DoubleClick += new System.EventHandler(this.dgvAtencion_DoubleClick);
            this.dgvAtencion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAtencion_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(335, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 400;
            this.label9.Text = "[F4] : Por DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(901, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 13);
            this.label11.TabIndex = 402;
            this.label11.Text = "[ESC] : Regresar a Pantalla Principal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(579, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 403;
            this.label12.Text = "[F6] : Por Apellidos y Nombres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(25, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 404;
            this.label13.Text = "[F2] : Por Lote - Correlativo";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmBuscarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1108, 412);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Atencion";
            this.Load += new System.EventHandler(this.FrmBuscarAtencion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpFecha.ResumeLayout(false);
            this.grpFecha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton opc02;
        private System.Windows.Forms.RadioButton opc03;
        private System.Windows.Forms.RadioButton opc01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNumLote;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAtencion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer;
        private System.Windows.Forms.TextBox txtNumCorrelativo;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton opcFec02;
        private System.Windows.Forms.RadioButton opcFec01;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label4;
    }
}