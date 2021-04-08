namespace FissalWinForm
{
    partial class FrmBuscarPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarPaquete));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dgvPaquete = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnVerDetalle = new System.Windows.Forms.ToolStripButton();
            this.groupBox13.SuspendLayout();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquete)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cboEstablecimiento);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(12, 28);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(600, 57);
            this.groupBox13.TabIndex = 409;
            this.groupBox13.TabStop = false;
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.ForeColor = System.Drawing.Color.Blue;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(111, 21);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(470, 21);
            this.cboEstablecimiento.TabIndex = 39;
            this.cboEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cboEstablecimiento_SelectedIndexChanged);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(95, 21);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 38;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(14, 21);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(81, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Establecimiento";
            // 
            // grbData
            // 
            this.grbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbData.Controls.Add(this.dgvPaquete);
            this.grbData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.Blue;
            this.grbData.Location = new System.Drawing.Point(12, 91);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(1160, 459);
            this.grbData.TabIndex = 408;
            this.grbData.TabStop = false;
            // 
            // dgvPaquete
            // 
            this.dgvPaquete.AllowUserToAddRows = false;
            this.dgvPaquete.AllowUserToDeleteRows = false;
            this.dgvPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaquete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquete.Location = new System.Drawing.Point(16, 20);
            this.dgvPaquete.Name = "dgvPaquete";
            this.dgvPaquete.ReadOnly = true;
            this.dgvPaquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquete.Size = new System.Drawing.Size(1130, 425);
            this.dgvPaquete.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNuevo,
            this.toolStripSeparator1,
            this.tsBtnEditar,
            this.toolStripSeparator2,
            this.tsBtnEliminar,
            this.toolStripSeparator4,
            this.tsBtnVerDetalle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 410;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnNuevo
            // 
            this.tsBtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevo.Image")));
            this.tsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevo.Name = "tsBtnNuevo";
            this.tsBtnNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsBtnNuevo.Text = "Nuevo";
            this.tsBtnNuevo.Click += new System.EventHandler(this.tsBtnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnEditar
            // 
            this.tsBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEditar.Image")));
            this.tsBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditar.Name = "tsBtnEditar";
            this.tsBtnEditar.Size = new System.Drawing.Size(57, 22);
            this.tsBtnEditar.Text = "Editar";
            this.tsBtnEditar.Click += new System.EventHandler(this.tsBtnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnEliminar
            // 
            this.tsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEliminar.Image")));
            this.tsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEliminar.Name = "tsBtnEliminar";
            this.tsBtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsBtnEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnVerDetalle
            // 
            this.tsBtnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnVerDetalle.Image")));
            this.tsBtnVerDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVerDetalle.Name = "tsBtnVerDetalle";
            this.tsBtnVerDetalle.Size = new System.Drawing.Size(83, 22);
            this.tsBtnVerDetalle.Text = "Ver Detalle";
            this.tsBtnVerDetalle.Click += new System.EventHandler(this.tsBtnVerDetalle_Click);
            // 
            // FrmBuscarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.grbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Paquetes por Establecimiento";
            this.Load += new System.EventHandler(this.FrmBuscarPaquete_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquete)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.DataGridView dgvPaquete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnVerDetalle;
    }
}