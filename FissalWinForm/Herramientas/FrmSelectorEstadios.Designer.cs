namespace FissalWinForm
{
    partial class FrmSelectorEstadios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorEstadios));
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEstadiosSeleccionados = new System.Windows.Forms.DataGridView();
            this.EstadioIdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstadios = new System.Windows.Forms.DataGridView();
            this.EstadioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiosSeleccionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEstadio
            // 
            this.txtEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadio.Location = new System.Drawing.Point(10, 19);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(740, 20);
            this.txtEstadio.TabIndex = 35;
            this.txtEstadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstadio_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEstadiosSeleccionados);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadios Seleccionados";
            // 
            // dgvEstadiosSeleccionados
            // 
            this.dgvEstadiosSeleccionados.AllowUserToAddRows = false;
            this.dgvEstadiosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvEstadiosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadiosSeleccionados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEstadiosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadiosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadioIdSeleccionado,
            this.DescripcionSeleccionada});
            this.dgvEstadiosSeleccionados.Location = new System.Drawing.Point(10, 19);
            this.dgvEstadiosSeleccionados.Name = "dgvEstadiosSeleccionados";
            this.dgvEstadiosSeleccionados.ReadOnly = true;
            this.dgvEstadiosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEstadiosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadiosSeleccionados.Size = new System.Drawing.Size(740, 200);
            this.dgvEstadiosSeleccionados.TabIndex = 0;
            this.dgvEstadiosSeleccionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadiosSeleccionados_CellDoubleClick);
            this.dgvEstadiosSeleccionados.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstadiosSeleccionados_CurrentCellDirtyStateChanged);
            this.dgvEstadiosSeleccionados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEstadiosSeleccionados_KeyDown);
            // 
            // EstadioIdSeleccionado
            // 
            this.EstadioIdSeleccionado.HeaderText = "Id";
            this.EstadioIdSeleccionado.Name = "EstadioIdSeleccionado";
            this.EstadioIdSeleccionado.ReadOnly = true;
            this.EstadioIdSeleccionado.Width = 60;
            // 
            // DescripcionSeleccionada
            // 
            this.DescripcionSeleccionada.HeaderText = "Descripcion";
            this.DescripcionSeleccionada.Name = "DescripcionSeleccionada";
            this.DescripcionSeleccionada.ReadOnly = true;
            this.DescripcionSeleccionada.Width = 610;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstadios);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de Busqueda";
            // 
            // dgvEstadios
            // 
            this.dgvEstadios.AllowUserToAddRows = false;
            this.dgvEstadios.AllowUserToDeleteRows = false;
            this.dgvEstadios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstadios.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEstadios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadioId,
            this.Descripcion});
            this.dgvEstadios.Location = new System.Drawing.Point(10, 19);
            this.dgvEstadios.Name = "dgvEstadios";
            this.dgvEstadios.ReadOnly = true;
            this.dgvEstadios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEstadios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadios.Size = new System.Drawing.Size(740, 200);
            this.dgvEstadios.TabIndex = 0;
            this.dgvEstadios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadios_CellDoubleClick);
            this.dgvEstadios.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstadios_CurrentCellDirtyStateChanged);
            this.dgvEstadios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEstadios_KeyDown);
            // 
            // EstadioId
            // 
            this.EstadioId.DataPropertyName = "EstadioId";
            this.EstadioId.HeaderText = "Id";
            this.EstadioId.Name = "EstadioId";
            this.EstadioId.ReadOnly = true;
            this.EstadioId.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 610;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEstadio);
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
            // FrmSelectorEstadios
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
            this.Name = "FrmSelectorEstadios";
            this.Text = "Selector de Estadios";
            this.Load += new System.EventHandler(this.FrmSelectorEstadios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelectorEstadios_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadiosSeleccionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEstadiosSeleccionados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEstadios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnAceptar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadioIdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}