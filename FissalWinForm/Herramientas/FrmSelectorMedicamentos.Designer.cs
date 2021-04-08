namespace FissalWinForm
{
    partial class FrmSelectorMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorMedicamentos));
            this.dgvMedicamentosSeleccionados = new System.Windows.Forms.DataGridView();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
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
            this.MedicamentoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DigemidId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentoId_seleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DigemidIdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSiga_seleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicamentosSeleccionados
            // 
            this.dgvMedicamentosSeleccionados.AllowUserToAddRows = false;
            this.dgvMedicamentosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvMedicamentosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicamentosSeleccionados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMedicamentosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicamentoId_seleccionado,
            this.DigemidIdSeleccionado,
            this.DescripcionSiga_seleccionado});
            this.dgvMedicamentosSeleccionados.Location = new System.Drawing.Point(10, 19);
            this.dgvMedicamentosSeleccionados.Name = "dgvMedicamentosSeleccionados";
            this.dgvMedicamentosSeleccionados.ReadOnly = true;
            this.dgvMedicamentosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMedicamentosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentosSeleccionados.Size = new System.Drawing.Size(740, 200);
            this.dgvMedicamentosSeleccionados.TabIndex = 0;
            this.dgvMedicamentosSeleccionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentosSeleccionados_CellDoubleClick);
            this.dgvMedicamentosSeleccionados.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMedicamentosSeleccionados_CurrentCellDirtyStateChanged);
            this.dgvMedicamentosSeleccionados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMedicamentosSeleccionados_KeyDown);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicamentos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicamentoId,
            this.DigemidId,
            this.DescripcionSiga});
            this.dgvMedicamentos.Location = new System.Drawing.Point(10, 19);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(740, 200);
            this.dgvMedicamentos.TabIndex = 0;
            this.dgvMedicamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellDoubleClick);
            this.dgvMedicamentos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMedicamentos_CurrentCellDirtyStateChanged);
            this.dgvMedicamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMedicamentos_KeyDown);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamento.Location = new System.Drawing.Point(10, 19);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(740, 20);
            this.txtMedicamento.TabIndex = 0;
            this.txtMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_medicamento_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMedicamentos);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMedicamentosSeleccionados);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamentos Seleccionados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMedicamento);
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
            // MedicamentoId
            // 
            this.MedicamentoId.DataPropertyName = "MedicamentoId";
            this.MedicamentoId.HeaderText = "Id";
            this.MedicamentoId.Name = "MedicamentoId";
            this.MedicamentoId.ReadOnly = true;
            this.MedicamentoId.Visible = false;
            this.MedicamentoId.Width = 60;
            // 
            // DigemidId
            // 
            this.DigemidId.DataPropertyName = "DigemidId";
            this.DigemidId.HeaderText = "SISMED";
            this.DigemidId.Name = "DigemidId";
            this.DigemidId.ReadOnly = true;
            // 
            // DescripcionSiga
            // 
            this.DescripcionSiga.DataPropertyName = "DescripcionSiga";
            this.DescripcionSiga.HeaderText = "Descripcion";
            this.DescripcionSiga.Name = "DescripcionSiga";
            this.DescripcionSiga.ReadOnly = true;
            this.DescripcionSiga.Width = 610;
            // 
            // MedicamentoId_seleccionado
            // 
            this.MedicamentoId_seleccionado.HeaderText = "Id";
            this.MedicamentoId_seleccionado.Name = "MedicamentoId_seleccionado";
            this.MedicamentoId_seleccionado.ReadOnly = true;
            this.MedicamentoId_seleccionado.Visible = false;
            this.MedicamentoId_seleccionado.Width = 60;
            // 
            // DigemidIdSeleccionado
            // 
            this.DigemidIdSeleccionado.HeaderText = "SISMED";
            this.DigemidIdSeleccionado.Name = "DigemidIdSeleccionado";
            this.DigemidIdSeleccionado.ReadOnly = true;
            // 
            // DescripcionSiga_seleccionado
            // 
            this.DescripcionSiga_seleccionado.HeaderText = "Descripcion";
            this.DescripcionSiga_seleccionado.Name = "DescripcionSiga_seleccionado";
            this.DescripcionSiga_seleccionado.ReadOnly = true;
            this.DescripcionSiga_seleccionado.Width = 610;
            // 
            // FrmSelectorMedicamentos
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
            this.Name = "FrmSelectorMedicamentos";
            this.Text = "Selector de Medicamentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscadorMedicamentos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvMedicamentosSeleccionados;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtMedicamento;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentoId_seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DigemidIdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSiga_seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DigemidId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSiga;
    }
}