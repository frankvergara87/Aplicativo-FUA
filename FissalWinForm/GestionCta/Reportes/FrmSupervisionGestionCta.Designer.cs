namespace FissalWinForm
{
    partial class FrmSupervisionGestionCta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupervisionGestionCta));
            this.dgvProduccionEstablecimiento = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnVerReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstablecimientoDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEstablecimientoDetalleFuas = new System.Windows.Forms.DataGridView();
            this.EstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFuas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoControlMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuasSupervisadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvanceSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionEstablecimiento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientoDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientoDetalleFuas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduccionEstablecimiento
            // 
            this.dgvProduccionEstablecimiento.AllowUserToAddRows = false;
            this.dgvProduccionEstablecimiento.AllowUserToDeleteRows = false;
            this.dgvProduccionEstablecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduccionEstablecimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccionEstablecimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstablecimientoId,
            this.Descripcion,
            this.NumFuas,
            this.CodSM,
            this.CodigoControlMedico,
            this.FuasSupervisadas,
            this.AvanceSM});
            this.dgvProduccionEstablecimiento.Location = new System.Drawing.Point(19, 22);
            this.dgvProduccionEstablecimiento.Name = "dgvProduccionEstablecimiento";
            this.dgvProduccionEstablecimiento.ReadOnly = true;
            this.dgvProduccionEstablecimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduccionEstablecimiento.Size = new System.Drawing.Size(1424, 231);
            this.dgvProduccionEstablecimiento.TabIndex = 0;
            this.dgvProduccionEstablecimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduccionEstablecimiento_CellClick);
            this.dgvProduccionEstablecimiento.CurrentCellChanged += new System.EventHandler(this.dgvProduccionEstablecimiento_CurrentCellChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvProduccionEstablecimiento);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1460, 270);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producciones";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnVerReporte
            // 
            this.tsBtnVerReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnVerReporte.Image")));
            this.tsBtnVerReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVerReporte.Name = "tsBtnVerReporte";
            this.tsBtnVerReporte.Size = new System.Drawing.Size(88, 22);
            this.tsBtnVerReporte.Text = "Ver Reporte";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnVerReporte,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1484, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvEstablecimientoDetalle);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1460, 270);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producciones x Ipress";
            // 
            // dgvEstablecimientoDetalle
            // 
            this.dgvEstablecimientoDetalle.AllowUserToAddRows = false;
            this.dgvEstablecimientoDetalle.AllowUserToDeleteRows = false;
            this.dgvEstablecimientoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstablecimientoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimientoDetalle.Location = new System.Drawing.Point(19, 22);
            this.dgvEstablecimientoDetalle.Name = "dgvEstablecimientoDetalle";
            this.dgvEstablecimientoDetalle.ReadOnly = true;
            this.dgvEstablecimientoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimientoDetalle.Size = new System.Drawing.Size(1424, 231);
            this.dgvEstablecimientoDetalle.TabIndex = 1;
            this.dgvEstablecimientoDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstablecimientoDetalle_CellClick);
            this.dgvEstablecimientoDetalle.CurrentCellChanged += new System.EventHandler(this.dgvEstablecimientoDetalle_CurrentCellChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvEstablecimientoDetalleFuas);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1460, 270);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fuas x Ipress";
            // 
            // dgvEstablecimientoDetalleFuas
            // 
            this.dgvEstablecimientoDetalleFuas.AllowUserToAddRows = false;
            this.dgvEstablecimientoDetalleFuas.AllowUserToDeleteRows = false;
            this.dgvEstablecimientoDetalleFuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimientoDetalleFuas.Location = new System.Drawing.Point(18, 22);
            this.dgvEstablecimientoDetalleFuas.Name = "dgvEstablecimientoDetalleFuas";
            this.dgvEstablecimientoDetalleFuas.ReadOnly = true;
            this.dgvEstablecimientoDetalleFuas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimientoDetalleFuas.Size = new System.Drawing.Size(1424, 231);
            this.dgvEstablecimientoDetalleFuas.TabIndex = 2;
            // 
            // EstablecimientoId
            // 
            this.EstablecimientoId.DataPropertyName = "EstablecimientoId";
            this.EstablecimientoId.FillWeight = 228.4264F;
            this.EstablecimientoId.HeaderText = "Establecimiento";
            this.EstablecimientoId.Name = "EstablecimientoId";
            this.EstablecimientoId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 83.94671F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 380;
            // 
            // NumFuas
            // 
            this.NumFuas.DataPropertyName = "NumFuas";
            this.NumFuas.FillWeight = 83.94671F;
            this.NumFuas.HeaderText = "NumFuas";
            this.NumFuas.Name = "NumFuas";
            this.NumFuas.ReadOnly = true;
            // 
            // CodSM
            // 
            this.CodSM.DataPropertyName = "CodSM";
            this.CodSM.HeaderText = "CodSM";
            this.CodSM.Name = "CodSM";
            this.CodSM.ReadOnly = true;
            // 
            // CodigoControlMedico
            // 
            this.CodigoControlMedico.DataPropertyName = "CodigoControlMedico";
            this.CodigoControlMedico.HeaderText = "CodigoControlMedico";
            this.CodigoControlMedico.Name = "CodigoControlMedico";
            this.CodigoControlMedico.ReadOnly = true;
            this.CodigoControlMedico.Visible = false;
            // 
            // FuasSupervisadas
            // 
            this.FuasSupervisadas.DataPropertyName = "FuasSupervisadas";
            this.FuasSupervisadas.FillWeight = 83.94671F;
            this.FuasSupervisadas.HeaderText = "FuasSupervisadas";
            this.FuasSupervisadas.Name = "FuasSupervisadas";
            this.FuasSupervisadas.ReadOnly = true;
            // 
            // AvanceSM
            // 
            this.AvanceSM.DataPropertyName = "%AvanceSM";
            this.AvanceSM.FillWeight = 83.94671F;
            this.AvanceSM.HeaderText = "%AvanceSM";
            this.AvanceSM.Name = "AvanceSM";
            this.AvanceSM.ReadOnly = true;
            this.AvanceSM.Width = 80;
            // 
            // FrmSupervisionGestionCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 862);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSupervisionGestionCta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervision Avances de Gestion Cuenta";
            this.Load += new System.EventHandler(this.FrmSupervisionGestionCta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionEstablecimiento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientoDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimientoDetalleFuas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduccionEstablecimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnVerReporte;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEstablecimientoDetalle;
        private System.Windows.Forms.DataGridView dgvEstablecimientoDetalleFuas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFuas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoControlMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuasSupervisadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvanceSM;
    }
}