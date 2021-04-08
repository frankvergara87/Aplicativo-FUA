namespace FissalWinForm
{
    partial class FrmSelectorProcedimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorProcedimientos));
            this.dgvProcedimientosSeleccionados = new System.Windows.Forms.DataGridView();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.ProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedimientoId_seleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SisIdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_seleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProcedimientosSeleccionados
            // 
            this.dgvProcedimientosSeleccionados.AllowUserToAddRows = false;
            this.dgvProcedimientosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvProcedimientosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcedimientosSeleccionados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProcedimientosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcedimientoId_seleccionado,
            this.SisIdSeleccionado,
            this.Descripcion_seleccionado});
            this.dgvProcedimientosSeleccionados.Location = new System.Drawing.Point(10, 19);
            this.dgvProcedimientosSeleccionados.Name = "dgvProcedimientosSeleccionados";
            this.dgvProcedimientosSeleccionados.ReadOnly = true;
            this.dgvProcedimientosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProcedimientosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimientosSeleccionados.Size = new System.Drawing.Size(740, 200);
            this.dgvProcedimientosSeleccionados.TabIndex = 0;
            this.dgvProcedimientosSeleccionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientosSeleccionados_CellDoubleClick);
            this.dgvProcedimientosSeleccionados.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProcedimientosSeleccionados_CurrentCellDirtyStateChanged);
            this.dgvProcedimientosSeleccionados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProcedimientosSeleccionados_KeyDown);
            // 
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.AllowUserToAddRows = false;
            this.dgvProcedimientos.AllowUserToDeleteRows = false;
            this.dgvProcedimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcedimientos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcedimientoId,
            this.SisId,
            this.Descripcion});
            this.dgvProcedimientos.Location = new System.Drawing.Point(10, 19);
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimientos.Size = new System.Drawing.Size(740, 200);
            this.dgvProcedimientos.TabIndex = 0;
            this.dgvProcedimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellDoubleClick);
            this.dgvProcedimientos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProcedimientos_CurrentCellDirtyStateChanged);
            this.dgvProcedimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProcedimientos_KeyDown);
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Location = new System.Drawing.Point(10, 19);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(740, 20);
            this.txtProcedimiento.TabIndex = 0;
            this.txtProcedimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_procedimiento_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProcedimientos);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvProcedimientosSeleccionados);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedimientos Seleccionados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProcedimiento);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 50);
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
            // ProcedimientoId
            // 
            this.ProcedimientoId.DataPropertyName = "ProcedimientoId";
            this.ProcedimientoId.HeaderText = "Id";
            this.ProcedimientoId.Name = "ProcedimientoId";
            this.ProcedimientoId.ReadOnly = true;
            this.ProcedimientoId.Visible = false;
            this.ProcedimientoId.Width = 60;
            // 
            // SisId
            // 
            this.SisId.DataPropertyName = "SisId";
            this.SisId.HeaderText = "CPT";
            this.SisId.Name = "SisId";
            this.SisId.ReadOnly = true;
            this.SisId.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 610;
            // 
            // ProcedimientoId_seleccionado
            // 
            this.ProcedimientoId_seleccionado.HeaderText = "Id";
            this.ProcedimientoId_seleccionado.Name = "ProcedimientoId_seleccionado";
            this.ProcedimientoId_seleccionado.ReadOnly = true;
            this.ProcedimientoId_seleccionado.Visible = false;
            this.ProcedimientoId_seleccionado.Width = 60;
            // 
            // SisIdSeleccionado
            // 
            this.SisIdSeleccionado.HeaderText = "CPT";
            this.SisIdSeleccionado.Name = "SisIdSeleccionado";
            this.SisIdSeleccionado.ReadOnly = true;
            this.SisIdSeleccionado.Width = 80;
            // 
            // Descripcion_seleccionado
            // 
            this.Descripcion_seleccionado.HeaderText = "Descripcion";
            this.Descripcion_seleccionado.Name = "Descripcion_seleccionado";
            this.Descripcion_seleccionado.ReadOnly = true;
            this.Descripcion_seleccionado.Width = 610;
            // 
            // FrmSelectorProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorProcedimientos";
            this.Text = "Selector de Procedimientos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscadorProcedimientos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcedimientosSeleccionados;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnAceptar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedimientoId_seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SisIdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}