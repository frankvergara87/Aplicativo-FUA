namespace FissalWinForm
{
    partial class FrmRegistrarControlMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarControlMedico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProduccionesSeleccionadas = new System.Windows.Forms.DataGridView();
            this.ProduccionEstablecimientoIdSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionIdSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenaesSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpressSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesProduccionSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducciones = new System.Windows.Forms.DataGridView();
            this.ProduccionEstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renaes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProduccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionesSeleccionadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).BeginInit();
            this.stsStpBuscador.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.toolStripSeparator3,
            this.tsBtnSalir,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = " ";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSalir.Image")));
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(73, 22);
            this.tsBtnSalir.Text = "Cancelar";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProduccionesSeleccionadas);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 246);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produccion Seleccionadas";
            // 
            // dgvProduccionesSeleccionadas
            // 
            this.dgvProduccionesSeleccionadas.AllowUserToAddRows = false;
            this.dgvProduccionesSeleccionadas.AllowUserToDeleteRows = false;
            this.dgvProduccionesSeleccionadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduccionesSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccionesSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduccionEstablecimientoIdSeleccionada,
            this.ProduccionIdSeleccionada,
            this.CodigoSeleccionada,
            this.RenaesSeleccionada,
            this.IpressSeleccionada,
            this.AtencionesProduccionSeleccionada});
            this.dgvProduccionesSeleccionadas.Location = new System.Drawing.Point(20, 19);
            this.dgvProduccionesSeleccionadas.Name = "dgvProduccionesSeleccionadas";
            this.dgvProduccionesSeleccionadas.ReadOnly = true;
            this.dgvProduccionesSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduccionesSeleccionadas.Size = new System.Drawing.Size(774, 208);
            this.dgvProduccionesSeleccionadas.TabIndex = 0;
            this.dgvProduccionesSeleccionadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduccionesSeleccionadas_CellDoubleClick);
            this.dgvProduccionesSeleccionadas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvIpressProduccion_CurrentCellDirtyStateChanged);
            this.dgvProduccionesSeleccionadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduccionesSeleccionadas_KeyDown);
            // 
            // ProduccionEstablecimientoIdSeleccionada
            // 
            this.ProduccionEstablecimientoIdSeleccionada.HeaderText = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoIdSeleccionada.Name = "ProduccionEstablecimientoIdSeleccionada";
            this.ProduccionEstablecimientoIdSeleccionada.ReadOnly = true;
            this.ProduccionEstablecimientoIdSeleccionada.Visible = false;
            // 
            // ProduccionIdSeleccionada
            // 
            this.ProduccionIdSeleccionada.HeaderText = "ProduccionId";
            this.ProduccionIdSeleccionada.Name = "ProduccionIdSeleccionada";
            this.ProduccionIdSeleccionada.ReadOnly = true;
            this.ProduccionIdSeleccionada.Visible = false;
            // 
            // CodigoSeleccionada
            // 
            this.CodigoSeleccionada.HeaderText = "Produccion";
            this.CodigoSeleccionada.Name = "CodigoSeleccionada";
            this.CodigoSeleccionada.ReadOnly = true;
            this.CodigoSeleccionada.Width = 80;
            // 
            // RenaesSeleccionada
            // 
            this.RenaesSeleccionada.HeaderText = "Renaes";
            this.RenaesSeleccionada.Name = "RenaesSeleccionada";
            this.RenaesSeleccionada.ReadOnly = true;
            // 
            // IpressSeleccionada
            // 
            this.IpressSeleccionada.HeaderText = "Ipress";
            this.IpressSeleccionada.Name = "IpressSeleccionada";
            this.IpressSeleccionada.ReadOnly = true;
            this.IpressSeleccionada.Width = 440;
            // 
            // AtencionesProduccionSeleccionada
            // 
            this.AtencionesProduccionSeleccionada.HeaderText = "Atenciones";
            this.AtencionesProduccionSeleccionada.Name = "AtencionesProduccionSeleccionada";
            this.AtencionesProduccionSeleccionada.ReadOnly = true;
            this.AtencionesProduccionSeleccionada.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducciones);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 297);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producciones";
            // 
            // dgvProducciones
            // 
            this.dgvProducciones.AllowUserToAddRows = false;
            this.dgvProducciones.AllowUserToDeleteRows = false;
            this.dgvProducciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduccionEstablecimientoId,
            this.ProduccionId,
            this.Codigo,
            this.Renaes,
            this.Ipress,
            this.AtencionesProduccion});
            this.dgvProducciones.Location = new System.Drawing.Point(19, 22);
            this.dgvProducciones.Name = "dgvProducciones";
            this.dgvProducciones.ReadOnly = true;
            this.dgvProducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducciones.Size = new System.Drawing.Size(776, 259);
            this.dgvProducciones.TabIndex = 0;
            this.dgvProducciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducciones_CellDoubleClick);
            this.dgvProducciones.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProducciones_CurrentCellDirtyStateChanged);
            this.dgvProducciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProducciones_DataBindingComplete);
            this.dgvProducciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProducciones_KeyDown);
            // 
            // ProduccionEstablecimientoId
            // 
            this.ProduccionEstablecimientoId.DataPropertyName = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.HeaderText = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.Name = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.ReadOnly = true;
            this.ProduccionEstablecimientoId.Visible = false;
            // 
            // ProduccionId
            // 
            this.ProduccionId.DataPropertyName = "ProduccionId";
            this.ProduccionId.HeaderText = "ProduccionId";
            this.ProduccionId.Name = "ProduccionId";
            this.ProduccionId.ReadOnly = true;
            this.ProduccionId.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Produccion";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Renaes
            // 
            this.Renaes.DataPropertyName = "Renaes";
            this.Renaes.HeaderText = "Renaes";
            this.Renaes.Name = "Renaes";
            this.Renaes.ReadOnly = true;
            // 
            // Ipress
            // 
            this.Ipress.DataPropertyName = "Ipress";
            this.Ipress.HeaderText = "Ipress";
            this.Ipress.Name = "Ipress";
            this.Ipress.ReadOnly = true;
            this.Ipress.Width = 440;
            // 
            // AtencionesProduccion
            // 
            this.AtencionesProduccion.DataPropertyName = "AtencionesProduccion";
            this.AtencionesProduccion.HeaderText = "Atenciones";
            this.AtencionesProduccion.Name = "AtencionesProduccion";
            this.AtencionesProduccion.ReadOnly = true;
            this.AtencionesProduccion.Width = 80;
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 660);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(836, 22);
            this.stsStpBuscador.TabIndex = 463;
            this.stsStpBuscador.Text = "statusStrip1";
            // 
            // tsslTotalRegistros
            // 
            this.tsslTotalRegistros.Name = "tsslTotalRegistros";
            this.tsslTotalRegistros.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboEstablecimiento);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboProduccion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 46);
            this.groupBox3.TabIndex = 464;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(324, 18);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(471, 21);
            this.cboEstablecimiento.TabIndex = 3;
            this.cboEstablecimiento.SelectionChangeCommitted += new System.EventHandler(this.cboEstablecimiento_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Establecimiento";
            // 
            // cboProduccion
            // 
            this.cboProduccion.FormattingEnabled = true;
            this.cboProduccion.Location = new System.Drawing.Point(88, 18);
            this.cboProduccion.Name = "cboProduccion";
            this.cboProduccion.Size = new System.Drawing.Size(121, 21);
            this.cboProduccion.TabIndex = 1;
            this.cboProduccion.SelectionChangeCommitted += new System.EventHandler(this.cboProduccion_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produccion";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(787, 388);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(20, 20);
            this.dtpFechaFin.TabIndex = 468;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(651, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 466;
            this.label10.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(494, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 465;
            this.label1.Text = "Fecha Inicio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(711, 387);
            this.txtFechaFin.MaxLength = 10;
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = true;
            this.txtFechaFin.Size = new System.Drawing.Size(70, 20);
            this.txtFechaFin.TabIndex = 469;
            this.txtFechaFin.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaFin_Validating);
            this.txtFechaFin.Validated += new System.EventHandler(this.txtFechaFin_Validated);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(565, 387);
            this.txtFechaInicio.MaxLength = 10;
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(70, 20);
            this.txtFechaInicio.TabIndex = 470;
            this.txtFechaInicio.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaInicio_Validating);
            this.txtFechaInicio.Validated += new System.EventHandler(this.txtFechaInicio_Validated);
            // 
            // FrmRegistrarControlMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 682);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarControlMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Control Medico";
            this.Load += new System.EventHandler(this.FrmSeleccionarProduccionIpress_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionesSeleccionadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).EndInit();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduccionesSeleccionadas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducciones;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboProduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionEstablecimientoIdSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionIdSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenaesSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpressSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesProduccionSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionEstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renaes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesProduccion;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
    }
}