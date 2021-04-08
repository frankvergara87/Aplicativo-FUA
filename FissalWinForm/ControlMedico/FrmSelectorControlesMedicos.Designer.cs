namespace FissalWinForm
{
    partial class FrmSelectorControlesMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorControlesMedicos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.grpBoxControlesMedicos = new System.Windows.Forms.GroupBox();
            this.dgvControlesMedicos = new System.Windows.Forms.DataGridView();
            this.lblMensajeControlesMedicos = new System.Windows.Forms.Label();
            this.grpBoxProduccionesSupervision = new System.Windows.Forms.GroupBox();
            this.dgvDetalleControlesMedicos = new System.Windows.Forms.DataGridView();
            this.CodigoProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renaes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesValorizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtencionesSupervisadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.grpBoxControlesMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlesMedicos)).BeginInit();
            this.grpBoxProduccionesSupervision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleControlesMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAceptar,
            this.toolStripSeparator3,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // grpBoxControlesMedicos
            // 
            this.grpBoxControlesMedicos.Controls.Add(this.dgvControlesMedicos);
            this.grpBoxControlesMedicos.Controls.Add(this.lblMensajeControlesMedicos);
            this.grpBoxControlesMedicos.Location = new System.Drawing.Point(12, 28);
            this.grpBoxControlesMedicos.Name = "grpBoxControlesMedicos";
            this.grpBoxControlesMedicos.Size = new System.Drawing.Size(760, 170);
            this.grpBoxControlesMedicos.TabIndex = 5;
            this.grpBoxControlesMedicos.TabStop = false;
            this.grpBoxControlesMedicos.Text = "Controles Medicos";
            // 
            // dgvControlesMedicos
            // 
            this.dgvControlesMedicos.AllowUserToAddRows = false;
            this.dgvControlesMedicos.AllowUserToDeleteRows = false;
            this.dgvControlesMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlesMedicos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvControlesMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlesMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.FechaInicio,
            this.FechaFin});
            this.dgvControlesMedicos.Location = new System.Drawing.Point(10, 19);
            this.dgvControlesMedicos.Name = "dgvControlesMedicos";
            this.dgvControlesMedicos.ReadOnly = true;
            this.dgvControlesMedicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvControlesMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlesMedicos.Size = new System.Drawing.Size(740, 140);
            this.dgvControlesMedicos.TabIndex = 3;
            this.dgvControlesMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlesMedicos_CellClick);
            this.dgvControlesMedicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlesMedicos_CellDoubleClick);
            this.dgvControlesMedicos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvControlesMedicos_KeyDown);
            // 
            // lblMensajeControlesMedicos
            // 
            this.lblMensajeControlesMedicos.Location = new System.Drawing.Point(27, 34);
            this.lblMensajeControlesMedicos.Name = "lblMensajeControlesMedicos";
            this.lblMensajeControlesMedicos.Size = new System.Drawing.Size(415, 27);
            this.lblMensajeControlesMedicos.TabIndex = 0;
            this.lblMensajeControlesMedicos.Text = "No hay controles medicos en ejecucion";
            // 
            // grpBoxProduccionesSupervision
            // 
            this.grpBoxProduccionesSupervision.Controls.Add(this.dgvDetalleControlesMedicos);
            this.grpBoxProduccionesSupervision.Location = new System.Drawing.Point(12, 204);
            this.grpBoxProduccionesSupervision.Name = "grpBoxProduccionesSupervision";
            this.grpBoxProduccionesSupervision.Size = new System.Drawing.Size(760, 346);
            this.grpBoxProduccionesSupervision.TabIndex = 6;
            this.grpBoxProduccionesSupervision.TabStop = false;
            this.grpBoxProduccionesSupervision.Text = "Producciones Control Medico";
            // 
            // dgvDetalleControlesMedicos
            // 
            this.dgvDetalleControlesMedicos.AllowUserToAddRows = false;
            this.dgvDetalleControlesMedicos.AllowUserToDeleteRows = false;
            this.dgvDetalleControlesMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleControlesMedicos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDetalleControlesMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleControlesMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduccion,
            this.Renaes,
            this.Ipress,
            this.AtencionesValorizadas,
            this.AtencionesSupervisadas});
            this.dgvDetalleControlesMedicos.Location = new System.Drawing.Point(10, 19);
            this.dgvDetalleControlesMedicos.Name = "dgvDetalleControlesMedicos";
            this.dgvDetalleControlesMedicos.ReadOnly = true;
            this.dgvDetalleControlesMedicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDetalleControlesMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleControlesMedicos.Size = new System.Drawing.Size(740, 316);
            this.dgvDetalleControlesMedicos.TabIndex = 0;
            // 
            // CodigoProduccion
            // 
            this.CodigoProduccion.DataPropertyName = "Codigo";
            this.CodigoProduccion.HeaderText = "Produccion";
            this.CodigoProduccion.Name = "CodigoProduccion";
            this.CodigoProduccion.ReadOnly = true;
            this.CodigoProduccion.Width = 70;
            // 
            // Renaes
            // 
            this.Renaes.DataPropertyName = "Renaes";
            this.Renaes.HeaderText = "Renaes";
            this.Renaes.Name = "Renaes";
            this.Renaes.ReadOnly = true;
            this.Renaes.Width = 70;
            // 
            // Ipress
            // 
            this.Ipress.DataPropertyName = "Ipress";
            this.Ipress.HeaderText = "Ipress";
            this.Ipress.Name = "Ipress";
            this.Ipress.ReadOnly = true;
            this.Ipress.Width = 300;
            // 
            // AtencionesValorizadas
            // 
            this.AtencionesValorizadas.DataPropertyName = "AtencionesValorizadas";
            this.AtencionesValorizadas.HeaderText = "AtencionesValorizadas";
            this.AtencionesValorizadas.Name = "AtencionesValorizadas";
            this.AtencionesValorizadas.ReadOnly = true;
            this.AtencionesValorizadas.Width = 120;
            // 
            // AtencionesSupervisadas
            // 
            this.AtencionesSupervisadas.DataPropertyName = "AtencionesSupervisadas";
            this.AtencionesSupervisadas.HeaderText = "AtencionesSupervisadas";
            this.AtencionesSupervisadas.Name = "AtencionesSupervisadas";
            this.AtencionesSupervisadas.ReadOnly = true;
            this.AtencionesSupervisadas.Width = 130;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // FrmSelectorControlesMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpBoxProduccionesSupervision);
            this.Controls.Add(this.grpBoxControlesMedicos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorControlesMedicos";
            this.Text = "Selector Controles Medicos";
            this.Load += new System.EventHandler(this.FrmSelectorControlesMedicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelectorControlesMedicos_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBoxControlesMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlesMedicos)).EndInit();
            this.grpBoxProduccionesSupervision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleControlesMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAceptar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox grpBoxControlesMedicos;
        private System.Windows.Forms.GroupBox grpBoxProduccionesSupervision;
        private System.Windows.Forms.DataGridView dgvDetalleControlesMedicos;
        private System.Windows.Forms.Label lblMensajeControlesMedicos;
        private System.Windows.Forms.DataGridView dgvControlesMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renaes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesValorizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtencionesSupervisadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}