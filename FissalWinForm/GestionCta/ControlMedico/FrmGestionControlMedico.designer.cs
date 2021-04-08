namespace FissalWinForm
{
    partial class FrmGestionControlMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionControlMedico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stsStpBuscador = new System.Windows.Forms.StatusStrip();
            this.tsslMensajePgsBarBuscador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPgsBarBuscador = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvControlMedicoDetalle = new System.Windows.Forms.DataGridView();
            this.ProduccionEstablecimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renaes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesValorizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesSupervisadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvControlMedico = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.stsStpBuscador.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMedicoDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNuevo,
            this.toolStripSeparator1,
            this.tsBtnFinalizar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 22;
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
            // tsBtnFinalizar
            // 
            this.tsBtnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFinalizar.Image")));
            this.tsBtnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFinalizar.Name = "tsBtnFinalizar";
            this.tsBtnFinalizar.Size = new System.Drawing.Size(69, 22);
            this.tsBtnFinalizar.Text = "Ejecutar";
            this.tsBtnFinalizar.Click += new System.EventHandler(this.tsBtnFinalizar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // stsStpBuscador
            // 
            this.stsStpBuscador.BackColor = System.Drawing.SystemColors.Info;
            this.stsStpBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMensajePgsBarBuscador,
            this.tsPgsBarBuscador,
            this.tsslTotalRegistros});
            this.stsStpBuscador.Location = new System.Drawing.Point(0, 630);
            this.stsStpBuscador.Name = "stsStpBuscador";
            this.stsStpBuscador.Size = new System.Drawing.Size(784, 22);
            this.stsStpBuscador.TabIndex = 105;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvControlMedicoDetalle);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 365);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producciones en Supervisión";
            // 
            // dgvControlMedicoDetalle
            // 
            this.dgvControlMedicoDetalle.AllowUserToAddRows = false;
            this.dgvControlMedicoDetalle.AllowUserToDeleteRows = false;
            this.dgvControlMedicoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlMedicoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlMedicoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduccionEstablecimientoId,
            this.ProduccionId,
            this.Renaes,
            this.Ipress,
            this.AtencionesValorizadas,
            this.AtencionesSupervisadas});
            this.dgvControlMedicoDetalle.Location = new System.Drawing.Point(20, 19);
            this.dgvControlMedicoDetalle.Name = "dgvControlMedicoDetalle";
            this.dgvControlMedicoDetalle.ReadOnly = true;
            this.dgvControlMedicoDetalle.Size = new System.Drawing.Size(722, 327);
            this.dgvControlMedicoDetalle.TabIndex = 0;
            // 
            // ProduccionEstablecimientoId
            // 
            this.ProduccionEstablecimientoId.DataPropertyName = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.Frozen = true;
            this.ProduccionEstablecimientoId.HeaderText = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.Name = "ProduccionEstablecimientoId";
            this.ProduccionEstablecimientoId.ReadOnly = true;
            this.ProduccionEstablecimientoId.Visible = false;
            // 
            // ProduccionId
            // 
            this.ProduccionId.DataPropertyName = "ProduccionId";
            this.ProduccionId.Frozen = true;
            this.ProduccionId.HeaderText = "Produccion";
            this.ProduccionId.Name = "ProduccionId";
            this.ProduccionId.ReadOnly = true;
            // 
            // Renaes
            // 
            this.Renaes.DataPropertyName = "Renaes";
            this.Renaes.Frozen = true;
            this.Renaes.HeaderText = "Renaes";
            this.Renaes.Name = "Renaes";
            this.Renaes.ReadOnly = true;
            this.Renaes.Width = 50;
            // 
            // Ipress
            // 
            this.Ipress.DataPropertyName = "Ipress";
            this.Ipress.Frozen = true;
            this.Ipress.HeaderText = "Ipress";
            this.Ipress.Name = "Ipress";
            this.Ipress.ReadOnly = true;
            this.Ipress.Width = 300;
            // 
            // AtencionesValorizadas
            // 
            this.AtencionesValorizadas.DataPropertyName = "AtencionesValorizadas";
            this.AtencionesValorizadas.Frozen = true;
            this.AtencionesValorizadas.HeaderText = "Atenciones Valorizadas";
            this.AtencionesValorizadas.Name = "AtencionesValorizadas";
            this.AtencionesValorizadas.ReadOnly = true;
            this.AtencionesValorizadas.Width = 70;
            // 
            // AtencionesSupervisadas
            // 
            this.AtencionesSupervisadas.DataPropertyName = "AtencionesSupervisadas";
            this.AtencionesSupervisadas.Frozen = true;
            this.AtencionesSupervisadas.HeaderText = "Atenciones Supervisadas";
            this.AtencionesSupervisadas.Name = "AtencionesSupervisadas";
            this.AtencionesSupervisadas.ReadOnly = true;
            this.AtencionesSupervisadas.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvControlMedico);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 228);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles Medicos";
            // 
            // dgvControlMedico
            // 
            this.dgvControlMedico.AllowUserToAddRows = false;
            this.dgvControlMedico.AllowUserToDeleteRows = false;
            this.dgvControlMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlMedico.Location = new System.Drawing.Point(19, 22);
            this.dgvControlMedico.Name = "dgvControlMedico";
            this.dgvControlMedico.ReadOnly = true;
            this.dgvControlMedico.Size = new System.Drawing.Size(724, 190);
            this.dgvControlMedico.TabIndex = 0;
            this.dgvControlMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlMedico_CellClick);
            // 
            // FrmGestionControlMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stsStpBuscador);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionControlMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Control Medico";
            this.Load += new System.EventHandler(this.FrmGestionControlMedico_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stsStpBuscador.ResumeLayout(false);
            this.stsStpBuscador.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMedicoDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip stsStpBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslMensajePgsBarBuscador;
        private System.Windows.Forms.ToolStripProgressBar tsPgsBarBuscador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRegistros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvControlMedicoDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvControlMedico;
        private System.Windows.Forms.ToolStripButton tsBtnFinalizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionEstablecimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renaes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesValorizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesSupervisadas;
    }
}