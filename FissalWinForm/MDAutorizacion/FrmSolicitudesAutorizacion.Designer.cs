namespace FissalWinForm
{
    partial class FrmSolicitudesAutorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudesAutorizacion));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.Nro_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstablecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Procesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.stsStpBuscador.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboEstablecimiento);
            this.groupBox3.Controls.Add(this.lblEstablecimiento);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(104, 16);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(480, 21);
            this.cboEstablecimiento.TabIndex = 0;
            this.cboEstablecimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEstablecimiento_KeyDown);
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(17, 19);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(81, 13);
            this.lblEstablecimiento.TabIndex = 104;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvSolicitudes);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de Busqueda";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Solicitud,
            this.Fecha_Solicitud,
            this.DescripcionEstablecimiento,
            this.NumeroDocumento,
            this.DescripcionTipoDocumento,
            this.DescripcionPaciente,
            this.Usuario_Solicitante,
            this.Usuario_Procesa,
            this.Descripcion});
            this.dgvSolicitudes.Location = new System.Drawing.Point(10, 19);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(740, 427);
            this.dgvSolicitudes.TabIndex = 0;
            this.dgvSolicitudes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellDoubleClick);
            this.dgvSolicitudes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSolicitudes_DataBindingComplete);
            this.dgvSolicitudes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSolicitudes_KeyDown);
            // 
            // Nro_Solicitud
            // 
            this.Nro_Solicitud.DataPropertyName = "Nro_Solicitud";
            this.Nro_Solicitud.HeaderText = "Nro";
            this.Nro_Solicitud.Name = "Nro_Solicitud";
            this.Nro_Solicitud.ReadOnly = true;
            this.Nro_Solicitud.Width = 60;
            // 
            // Fecha_Solicitud
            // 
            this.Fecha_Solicitud.DataPropertyName = "Fecha_Solicitud";
            this.Fecha_Solicitud.HeaderText = "Fecha";
            this.Fecha_Solicitud.Name = "Fecha_Solicitud";
            this.Fecha_Solicitud.ReadOnly = true;
            this.Fecha_Solicitud.Width = 80;
            // 
            // DescripcionEstablecimiento
            // 
            this.DescripcionEstablecimiento.DataPropertyName = "DescripcionEstablecimiento";
            this.DescripcionEstablecimiento.HeaderText = "Establecimiento";
            this.DescripcionEstablecimiento.Name = "DescripcionEstablecimiento";
            this.DescripcionEstablecimiento.ReadOnly = true;
            this.DescripcionEstablecimiento.Width = 420;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Doc. Pac.";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // DescripcionTipoDocumento
            // 
            this.DescripcionTipoDocumento.DataPropertyName = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.HeaderText = "Tipo Doc.";
            this.DescripcionTipoDocumento.Name = "DescripcionTipoDocumento";
            this.DescripcionTipoDocumento.ReadOnly = true;
            // 
            // DescripcionPaciente
            // 
            this.DescripcionPaciente.DataPropertyName = "DescripcionPaciente";
            this.DescripcionPaciente.HeaderText = "Paciente";
            this.DescripcionPaciente.Name = "DescripcionPaciente";
            this.DescripcionPaciente.ReadOnly = true;
            this.DescripcionPaciente.Width = 240;
            // 
            // Usuario_Solicitante
            // 
            this.Usuario_Solicitante.DataPropertyName = "Usuario_Solicitante";
            this.Usuario_Solicitante.HeaderText = "Solicitante";
            this.Usuario_Solicitante.Name = "Usuario_Solicitante";
            this.Usuario_Solicitante.ReadOnly = true;
            // 
            // Usuario_Procesa
            // 
            this.Usuario_Procesa.DataPropertyName = "Usuario_Procesa";
            this.Usuario_Procesa.HeaderText = "Atiende";
            this.Usuario_Procesa.Name = "Usuario_Procesa";
            this.Usuario_Procesa.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion Solicitud";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMensajePgsBarBuscador,
            this.tsPgsBarBuscador,
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 540);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(784, 22);
            this.stsStpBuscador.TabIndex = 118;
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
            this.tsBtnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // FrmSolicitudesAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSolicitudesAutorizacion";
            this.Text = "Autorizacion: Solicitudes Pendientes";
            this.Load += new System.EventHandler(this.FrmSolicitudesAutorizacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstablecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Procesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
    }
}