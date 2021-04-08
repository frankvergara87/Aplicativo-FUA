namespace FissalWinForm
{
    partial class FrmFuasObservados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuasObservados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFiltroEstablecimiento = new System.Windows.Forms.ComboBox();
            this.cbFiltroCMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.btnExportarTodo = new System.Windows.Forms.ToolStripButton();
            this.dgvListadoFuas = new System.Windows.Forms.DataGridView();
            this.CodFua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionFissal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dx_Fissal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsFua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ObsDx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ObsConsumo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VerDetalle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TFuas = new System.Windows.Forms.Label();
            this.EFuas = new System.Windows.Forms.Label();
            this.OFuas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFuas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFiltroEstablecimiento);
            this.groupBox1.Controls.Add(this.cbFiltroCMedico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbFiltroEstablecimiento
            // 
            this.cbFiltroEstablecimiento.FormattingEnabled = true;
            this.cbFiltroEstablecimiento.Location = new System.Drawing.Point(346, 23);
            this.cbFiltroEstablecimiento.Name = "cbFiltroEstablecimiento";
            this.cbFiltroEstablecimiento.Size = new System.Drawing.Size(219, 21);
            this.cbFiltroEstablecimiento.TabIndex = 7;
            // 
            // cbFiltroCMedico
            // 
            this.cbFiltroCMedico.FormattingEnabled = true;
            this.cbFiltroCMedico.Location = new System.Drawing.Point(102, 23);
            this.cbFiltroCMedico.Name = "cbFiltroCMedico";
            this.cbFiltroCMedico.Size = new System.Drawing.Size(126, 21);
            this.cbFiltroCMedico.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Establecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Control Médico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Total de Fuas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Fuas Evaluados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "# Fuas Observadas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultar,
            this.btnExportar,
            this.btnExportarTodo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1041, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.ToolTipText = "Seleccionar para PCPP";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(70, 22);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.ToolTipText = "Seleccionar para PCPP";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarTodo.Image")));
            this.btnExportarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(101, 22);
            this.btnExportarTodo.Text = "Exportar Todo";
            this.btnExportarTodo.ToolTipText = "Seleccionar para PCPP";
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportarTodo_Click);
            // 
            // dgvListadoFuas
            // 
            this.dgvListadoFuas.AllowUserToAddRows = false;
            this.dgvListadoFuas.AllowUserToDeleteRows = false;
            this.dgvListadoFuas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListadoFuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoFuas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFua,
            this.Fua,
            this.FechaAtencion,
            this.ProduccionFissal,
            this.Dni,
            this.Paciente,
            this.Dx_Fissal,
            this.ObsFua,
            this.ObsDx,
            this.ObsConsumo,
            this.VerDetalle});
            this.dgvListadoFuas.Location = new System.Drawing.Point(13, 148);
            this.dgvListadoFuas.Name = "dgvListadoFuas";
            this.dgvListadoFuas.ReadOnly = true;
            this.dgvListadoFuas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoFuas.Size = new System.Drawing.Size(1016, 288);
            this.dgvListadoFuas.TabIndex = 6;
            this.dgvListadoFuas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoFuas_CellClick);
            // 
            // CodFua
            // 
            this.CodFua.DataPropertyName = "Fua";
            this.CodFua.Frozen = true;
            this.CodFua.HeaderText = "CodFua";
            this.CodFua.Name = "CodFua";
            this.CodFua.ReadOnly = true;
            this.CodFua.Visible = false;
            // 
            // Fua
            // 
            this.Fua.DataPropertyName = "correlativo";
            this.Fua.Frozen = true;
            this.Fua.HeaderText = "Fua";
            this.Fua.Name = "Fua";
            this.Fua.ReadOnly = true;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.DataPropertyName = "FechaAtencion";
            this.FechaAtencion.Frozen = true;
            this.FechaAtencion.HeaderText = "Fecha Atención ";
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.ReadOnly = true;
            this.FechaAtencion.Width = 80;
            // 
            // ProduccionFissal
            // 
            this.ProduccionFissal.DataPropertyName = "ProduccionFissal";
            this.ProduccionFissal.Frozen = true;
            this.ProduccionFissal.HeaderText = "Fecha Produccion";
            this.ProduccionFissal.Name = "ProduccionFissal";
            this.ProduccionFissal.ReadOnly = true;
            this.ProduccionFissal.Width = 80;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.Frozen = true;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 60;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.Frozen = true;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 270;
            // 
            // Dx_Fissal
            // 
            this.Dx_Fissal.DataPropertyName = "Dx_Fissal";
            this.Dx_Fissal.Frozen = true;
            this.Dx_Fissal.HeaderText = "Dx Fissal";
            this.Dx_Fissal.Name = "Dx_Fissal";
            this.Dx_Fissal.ReadOnly = true;
            this.Dx_Fissal.Width = 120;
            // 
            // ObsFua
            // 
            this.ObsFua.DataPropertyName = "CMObs";
            this.ObsFua.Frozen = true;
            this.ObsFua.HeaderText = "Obs Fua";
            this.ObsFua.Name = "ObsFua";
            this.ObsFua.ReadOnly = true;
            this.ObsFua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ObsFua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ObsFua.Width = 65;
            // 
            // ObsDx
            // 
            this.ObsDx.DataPropertyName = "CMObsDx";
            this.ObsDx.Frozen = true;
            this.ObsDx.HeaderText = "Obs Dx";
            this.ObsDx.Name = "ObsDx";
            this.ObsDx.ReadOnly = true;
            this.ObsDx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ObsDx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ObsDx.Width = 65;
            // 
            // ObsConsumo
            // 
            this.ObsConsumo.DataPropertyName = "CMObsConsumo";
            this.ObsConsumo.Frozen = true;
            this.ObsConsumo.HeaderText = "Obs Consumo";
            this.ObsConsumo.Name = "ObsConsumo";
            this.ObsConsumo.ReadOnly = true;
            this.ObsConsumo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ObsConsumo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ObsConsumo.Width = 65;
            // 
            // VerDetalle
            // 
            this.VerDetalle.HeaderText = "Ver Detalle";
            this.VerDetalle.Name = "VerDetalle";
            this.VerDetalle.ReadOnly = true;
            this.VerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VerDetalle.Text = "Ver Detalle";
            this.VerDetalle.UseColumnTextForLinkValue = true;
            this.VerDetalle.Width = 80;
            // 
            // TFuas
            // 
            this.TFuas.AutoSize = true;
            this.TFuas.Location = new System.Drawing.Point(115, 117);
            this.TFuas.Name = "TFuas";
            this.TFuas.Size = new System.Drawing.Size(37, 13);
            this.TFuas.TabIndex = 7;
            this.TFuas.Text = "TFuas";
            // 
            // EFuas
            // 
            this.EFuas.AutoSize = true;
            this.EFuas.Location = new System.Drawing.Point(296, 117);
            this.EFuas.Name = "EFuas";
            this.EFuas.Size = new System.Drawing.Size(37, 13);
            this.EFuas.TabIndex = 8;
            this.EFuas.Text = "EFuas";
            // 
            // OFuas
            // 
            this.OFuas.AutoSize = true;
            this.OFuas.Location = new System.Drawing.Point(482, 117);
            this.OFuas.Name = "OFuas";
            this.OFuas.Size = new System.Drawing.Size(38, 13);
            this.OFuas.TabIndex = 9;
            this.OFuas.Text = "OFuas";
            // 
            // FrmFuasObservados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 448);
            this.Controls.Add(this.OFuas);
            this.Controls.Add(this.EFuas);
            this.Controls.Add(this.TFuas);
            this.Controls.Add(this.dgvListadoFuas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFuasObservados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Control Médico";
            this.Load += new System.EventHandler(this.FrmFuasObservados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFuas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbFiltroEstablecimiento;
        private System.Windows.Forms.ComboBox cbFiltroCMedico;
        private System.Windows.Forms.DataGridView dgvListadoFuas;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.ToolStripButton btnExportarTodo;
        private System.Windows.Forms.Label TFuas;
        private System.Windows.Forms.Label EFuas;
        private System.Windows.Forms.Label OFuas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fua;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionFissal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dx_Fissal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ObsFua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ObsDx;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ObsConsumo;
        private System.Windows.Forms.DataGridViewLinkColumn VerDetalle;
    }
}