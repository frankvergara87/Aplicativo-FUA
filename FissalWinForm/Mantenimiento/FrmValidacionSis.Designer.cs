namespace FissalWinForm
{
    partial class FrmValidacionSis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidacionSis));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnValidar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnValidados = new System.Windows.Forms.ToolStripButton();
            this.tsLblPaginacion = new System.Windows.Forms.ToolStripLabel();
            this.dgvListadoPacientesSis = new System.Windows.Forms.DataGridView();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Validacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientesSis)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnValidar,
            this.toolStripSeparator1,
            this.tsBtnValidados,
            this.tsLblPaginacion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnValidar
            // 
            this.tsBtnValidar.Image = global::FissalWinForm.Properties.Resources.User_answer;
            this.tsBtnValidar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnValidar.Name = "tsBtnValidar";
            this.tsBtnValidar.Size = new System.Drawing.Size(63, 22);
            this.tsBtnValidar.Text = "Validar";
            this.tsBtnValidar.ToolTipText = "Guardar";
            this.tsBtnValidar.Click += new System.EventHandler(this.tsBtnValidar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnValidados
            // 
            this.tsBtnValidados.Enabled = false;
            this.tsBtnValidados.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnValidados.Image")));
            this.tsBtnValidados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnValidados.Name = "tsBtnValidados";
            this.tsBtnValidados.Size = new System.Drawing.Size(78, 22);
            this.tsBtnValidados.Text = "Validados";
            this.tsBtnValidados.ToolTipText = "Seleccionar para PCPP";
            // 
            // tsLblPaginacion
            // 
            this.tsLblPaginacion.Name = "tsLblPaginacion";
            this.tsLblPaginacion.Size = new System.Drawing.Size(0, 22);
            // 
            // dgvListadoPacientesSis
            // 
            this.dgvListadoPacientesSis.AllowUserToAddRows = false;
            this.dgvListadoPacientesSis.AllowUserToDeleteRows = false;
            this.dgvListadoPacientesSis.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoPacientesSis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPacientesSis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacienteId,
            this.Dni,
            this.Nombres,
            this.Apellidos,
            this.Estado,
            this.Obs,
            this.Fecha_Validacion});
            this.dgvListadoPacientesSis.Location = new System.Drawing.Point(12, 47);
            this.dgvListadoPacientesSis.Name = "dgvListadoPacientesSis";
            this.dgvListadoPacientesSis.ReadOnly = true;
            this.dgvListadoPacientesSis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoPacientesSis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPacientesSis.Size = new System.Drawing.Size(903, 326);
            this.dgvListadoPacientesSis.TabIndex = 3;
            // 
            // PacienteId
            // 
            this.PacienteId.DataPropertyName = "PacienteId";
            this.PacienteId.HeaderText = "PacienteId";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.ReadOnly = true;
            this.PacienteId.Width = 80;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 80;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 220;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "ESTADO";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.Width = 80;
            // 
            // Obs
            // 
            this.Obs.DataPropertyName = "entrega_estado";
            this.Obs.HeaderText = "Obs.";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            this.Obs.Width = 140;
            // 
            // Fecha_Validacion
            // 
            this.Fecha_Validacion.DataPropertyName = "FEC_VALIDACION";
            this.Fecha_Validacion.HeaderText = "Fecha Validacion";
            this.Fecha_Validacion.Name = "Fecha_Validacion";
            this.Fecha_Validacion.ReadOnly = true;
            // 
            // FrmValidacionSis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(924, 377);
            this.Controls.Add(this.dgvListadoPacientesSis);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmValidacionSis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidacionSis";
            this.Load += new System.EventHandler(this.FrmValidacionSis_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientesSis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnValidar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnValidados;
        private System.Windows.Forms.ToolStripLabel tsLblPaginacion;
        private System.Windows.Forms.DataGridView dgvListadoPacientesSis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Validacion;
    }
}