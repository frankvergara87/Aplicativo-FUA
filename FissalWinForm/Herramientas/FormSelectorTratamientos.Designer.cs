namespace FissalWinForm
{
    partial class FormSelectorTratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectorTratamientos));
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.TratamientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAutorizacionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.stsStpBuscador.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(128, 24);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(575, 21);
            this.cboEstablecimiento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Establecimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTratamientos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstadio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboEstablecimiento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(594, 49);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(109, 20);
            this.txtEstadio.TabIndex = 3;
            this.txtEstadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstadio_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estadio";
            // 
            // txtFase
            // 
            this.txtFase.Location = new System.Drawing.Point(421, 49);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(109, 20);
            this.txtFase.TabIndex = 2;
            this.txtFase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFase_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fase";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(128, 49);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(240, 20);
            this.txtCategoria.TabIndex = 1;
            this.txtCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategoria_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 540);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(784, 22);
            this.stsStpBuscador.TabIndex = 71;
            this.stsStpBuscador.Text = "statusStrip1";
            // 
            // tsslTotalRegistros
            // 
            this.tsslTotalRegistros.Name = "tsslTotalRegistros";
            this.tsslTotalRegistros.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBuscar,
            this.toolStripSeparator1,
            this.tsBtnSalir,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "No se encontraron resultados para tu busqueda";
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AllowUserToAddRows = false;
            this.dgvTratamientos.AllowUserToDeleteRows = false;
            this.dgvTratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TratamientoId,
            this.Descripcion,
            this.DescripcionFase,
            this.DescripcionEstadio,
            this.TipoAutorizacionDescripcion,
            this.ultimaversion});
            this.dgvTratamientos.Location = new System.Drawing.Point(20, 30);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamientos.Size = new System.Drawing.Size(720, 353);
            this.dgvTratamientos.TabIndex = 2;
            this.dgvTratamientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTratamientos_CellDoubleClick);
            this.dgvTratamientos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTratamientos_DataBindingComplete);
            this.dgvTratamientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTratamientos_KeyDown);
            // 
            // TratamientoId
            // 
            this.TratamientoId.DataPropertyName = "TratamientoId";
            this.TratamientoId.HeaderText = "TratamientoId";
            this.TratamientoId.Name = "TratamientoId";
            this.TratamientoId.ReadOnly = true;
            this.TratamientoId.Visible = false;
            this.TratamientoId.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Categoria";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 270;
            // 
            // DescripcionFase
            // 
            this.DescripcionFase.DataPropertyName = "DescripcionFase";
            this.DescripcionFase.HeaderText = "Fase";
            this.DescripcionFase.Name = "DescripcionFase";
            this.DescripcionFase.ReadOnly = true;
            this.DescripcionFase.Width = 180;
            // 
            // DescripcionEstadio
            // 
            this.DescripcionEstadio.DataPropertyName = "DescripcionEstadio";
            this.DescripcionEstadio.HeaderText = "Estadio";
            this.DescripcionEstadio.Name = "DescripcionEstadio";
            this.DescripcionEstadio.ReadOnly = true;
            this.DescripcionEstadio.Width = 80;
            // 
            // TipoAutorizacionDescripcion
            // 
            this.TipoAutorizacionDescripcion.DataPropertyName = "TipoAutorizacionDescripcion";
            this.TipoAutorizacionDescripcion.HeaderText = "TipoAutoriz.";
            this.TipoAutorizacionDescripcion.Name = "TipoAutorizacionDescripcion";
            this.TipoAutorizacionDescripcion.ReadOnly = true;
            this.TipoAutorizacionDescripcion.Width = 80;
            // 
            // ultimaversion
            // 
            this.ultimaversion.DataPropertyName = "ultimaversion";
            this.ultimaversion.HeaderText = "Version";
            this.ultimaversion.Name = "ultimaversion";
            this.ultimaversion.ReadOnly = true;
            this.ultimaversion.Width = 50;
            // 
            // FormSelectorTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectorTratamientos";
            this.Text = "Selector Tratamientos";
            this.Load += new System.EventHandler(this.FormSelectorTratamientos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSelectorTratamientos_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAutorizacionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaversion;
        private System.Windows.Forms.Label label5;
    }
}