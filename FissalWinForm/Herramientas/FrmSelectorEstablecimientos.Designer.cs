namespace FissalWinForm
{
    partial class FrmSelectorEstablecimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorEstablecimientos));
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.grpBoxSeleccionados = new System.Windows.Forms.GroupBox();
            this.dgvEstablecimientosSeleccionados = new System.Windows.Forms.DataGridView();
            this.EstablecimientoIdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SisIdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstablecimientos = new System.Windows.Forms.DataGridView();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.grpBoxSeleccionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientosSeleccionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstablecimiento.Location = new System.Drawing.Point(10, 19);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(740, 20);
            this.txtEstablecimiento.TabIndex = 41;
            this.txtEstablecimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstablecimiento_KeyDown);
            // 
            // grpBoxSeleccionados
            // 
            this.grpBoxSeleccionados.Controls.Add(this.dgvEstablecimientosSeleccionados);
            this.grpBoxSeleccionados.Location = new System.Drawing.Point(12, 323);
            this.grpBoxSeleccionados.Name = "grpBoxSeleccionados";
            this.grpBoxSeleccionados.Size = new System.Drawing.Size(760, 230);
            this.grpBoxSeleccionados.TabIndex = 2;
            this.grpBoxSeleccionados.TabStop = false;
            this.grpBoxSeleccionados.Text = "Establecimientos Seleccionados";
            // 
            // dgvEstablecimientosSeleccionados
            // 
            this.dgvEstablecimientosSeleccionados.AllowUserToAddRows = false;
            this.dgvEstablecimientosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvEstablecimientosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstablecimientosSeleccionados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEstablecimientosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimientosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstablecimientoIdSeleccionado,
            this.DescripcionSeleccionada,
            this.SisIdSeleccionado});
            this.dgvEstablecimientosSeleccionados.Location = new System.Drawing.Point(10, 19);
            this.dgvEstablecimientosSeleccionados.Name = "dgvEstablecimientosSeleccionados";
            this.dgvEstablecimientosSeleccionados.ReadOnly = true;
            this.dgvEstablecimientosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEstablecimientosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimientosSeleccionados.Size = new System.Drawing.Size(740, 200);
            this.dgvEstablecimientosSeleccionados.TabIndex = 0;
            this.dgvEstablecimientosSeleccionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstablecimientosSeleccionados_CellDoubleClick);
            this.dgvEstablecimientosSeleccionados.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstablecimientosSeleccionados_CurrentCellDirtyStateChanged);
            this.dgvEstablecimientosSeleccionados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEstablecimientosSeleccionados_KeyDown);
            // 
            // EstablecimientoIdSeleccionado
            // 
            this.EstablecimientoIdSeleccionado.HeaderText = "Id";
            this.EstablecimientoIdSeleccionado.Name = "EstablecimientoIdSeleccionado";
            this.EstablecimientoIdSeleccionado.ReadOnly = true;
            this.EstablecimientoIdSeleccionado.Width = 60;
            // 
            // DescripcionSeleccionada
            // 
            this.DescripcionSeleccionada.HeaderText = "Descripcion";
            this.DescripcionSeleccionada.Name = "DescripcionSeleccionada";
            this.DescripcionSeleccionada.ReadOnly = true;
            this.DescripcionSeleccionada.Width = 520;
            // 
            // SisIdSeleccionado
            // 
            this.SisIdSeleccionado.HeaderText = "SisId";
            this.SisIdSeleccionado.Name = "SisIdSeleccionado";
            this.SisIdSeleccionado.ReadOnly = true;
            this.SisIdSeleccionado.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstablecimientos);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de Busqueda";
            // 
            // dgvEstablecimientos
            // 
            this.dgvEstablecimientos.AllowUserToAddRows = false;
            this.dgvEstablecimientos.AllowUserToDeleteRows = false;
            this.dgvEstablecimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstablecimientos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEstablecimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstablecimientoId,
            this.Descripcion,
            this.SisId});
            this.dgvEstablecimientos.Location = new System.Drawing.Point(10, 19);
            this.dgvEstablecimientos.Name = "dgvEstablecimientos";
            this.dgvEstablecimientos.ReadOnly = true;
            this.dgvEstablecimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEstablecimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimientos.Size = new System.Drawing.Size(740, 200);
            this.dgvEstablecimientos.TabIndex = 0;
            this.dgvEstablecimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstablecimientos_CellDoubleClick);
            this.dgvEstablecimientos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstablecimientos_CurrentCellDirtyStateChanged);
            this.dgvEstablecimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEstablecimientos_KeyDown);
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.HeaderText = "Id";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            this.EstablecimientoId.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 520;
            // 
            // SisId
            // 
            this.SisId.DataPropertyName = "SisId";
            this.SisId.HeaderText = "SisId";
            this.SisId.Name = "SisId";
            this.SisId.ReadOnly = true;
            this.SisId.Width = 90;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEstablecimiento);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 53);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnLimpiar,
            this.toolStripSeparator2,
            this.tsBtnBuscar,
            this.toolStripSeparator1,
            this.tsBtnAceptar,
            this.toolStripSeparator3,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnAceptar
            // 
            this.tsBtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAceptar.Image")));
            this.tsBtnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAceptar.Name = "tsBtnAceptar";
            this.tsBtnAceptar.Size = new System.Drawing.Size(68, 22);
            this.tsBtnAceptar.Text = "Aceptar";
            this.tsBtnAceptar.Click += new System.EventHandler(this.tsBtnAceptar_Click);
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
            // FrmSelectorEstablecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBoxSeleccionados);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorEstablecimientos";
            this.Text = "Selector de Establecimientos";
            this.Load += new System.EventHandler(this.FrmSelectorEstablecimientos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelectorEstablecimientos_KeyDown);
            this.grpBoxSeleccionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientosSeleccionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstablecimiento;
        private System.Windows.Forms.GroupBox grpBoxSeleccionados;
        private System.Windows.Forms.DataGridView dgvEstablecimientosSeleccionados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEstablecimientos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnAceptar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoIdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn SisIdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SisId;
    }
}