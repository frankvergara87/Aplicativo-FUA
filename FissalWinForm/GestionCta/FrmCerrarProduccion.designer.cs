namespace FissalWinForm
{
    partial class FrmCerrarProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCerrarProduccion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnVerReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecCierre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduccionId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCierreProduccion = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierreProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFinalizar,
            this.toolStripSeparator2,
            this.tsBtnVerReporte,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnFinalizar
            // 
            this.tsBtnFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFinalizar.Image")));
            this.tsBtnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFinalizar.Name = "tsBtnFinalizar";
            this.tsBtnFinalizar.Size = new System.Drawing.Size(54, 22);
            this.tsBtnFinalizar.Text = "Finalizar";
            this.tsBtnFinalizar.Visible = false;
            this.tsBtnFinalizar.Click += new System.EventHandler(this.tsBtnFinalizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsBtnVerReporte
            // 
            this.tsBtnVerReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnVerReporte.Image")));
            this.tsBtnVerReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVerReporte.Name = "tsBtnVerReporte";
            this.tsBtnVerReporte.Size = new System.Drawing.Size(88, 22);
            this.tsBtnVerReporte.Text = "Ver Reporte";
            this.tsBtnVerReporte.Click += new System.EventHandler(this.tsBtnVerReporte_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecCierre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProduccionId);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 52);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produccion";
            // 
            // txtFecCierre
            // 
            this.txtFecCierre.Enabled = false;
            this.txtFecCierre.ForeColor = System.Drawing.Color.Blue;
            this.txtFecCierre.Location = new System.Drawing.Point(760, 20);
            this.txtFecCierre.Name = "txtFecCierre";
            this.txtFecCierre.Size = new System.Drawing.Size(70, 20);
            this.txtFecCierre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(672, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha de Cierre";
            // 
            // txtFecInicio
            // 
            this.txtFecInicio.Enabled = false;
            this.txtFecInicio.ForeColor = System.Drawing.Color.Blue;
            this.txtFecInicio.Location = new System.Drawing.Point(575, 20);
            this.txtFecInicio.Name = "txtFecInicio";
            this.txtFecInicio.Size = new System.Drawing.Size(70, 20);
            this.txtFecInicio.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(489, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha de Inicio";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.ForeColor = System.Drawing.Color.Blue;
            this.txtMes.Location = new System.Drawing.Point(360, 20);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(70, 20);
            this.txtMes.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mes";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.ForeColor = System.Drawing.Color.Blue;
            this.txtPeriodo.Location = new System.Drawing.Point(223, 20);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(70, 20);
            this.txtPeriodo.TabIndex = 24;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.Color.Blue;
            this.txtCodigo.Location = new System.Drawing.Point(70, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Periodo";
            // 
            // txtProduccionId
            // 
            this.txtProduccionId.Enabled = false;
            this.txtProduccionId.ForeColor = System.Drawing.Color.Blue;
            this.txtProduccionId.Location = new System.Drawing.Point(70, 20);
            this.txtProduccionId.Name = "txtProduccionId";
            this.txtProduccionId.Size = new System.Drawing.Size(70, 20);
            this.txtProduccionId.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvCierreProduccion);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 298);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producciones x Ipress";
            // 
            // dgvCierreProduccion
            // 
            this.dgvCierreProduccion.AllowUserToAddRows = false;
            this.dgvCierreProduccion.AllowUserToDeleteRows = false;
            this.dgvCierreProduccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCierreProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCierreProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierreProduccion.Location = new System.Drawing.Point(19, 22);
            this.dgvCierreProduccion.Name = "dgvCierreProduccion";
            this.dgvCierreProduccion.ReadOnly = true;
            this.dgvCierreProduccion.Size = new System.Drawing.Size(814, 260);
            this.dgvCierreProduccion.TabIndex = 0;
            // 
            // FrmCerrarProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCerrarProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Produccion";
            this.Load += new System.EventHandler(this.FrmCerrarProduccion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierreProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnFinalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecCierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCierreProduccion;
        private System.Windows.Forms.TextBox txtProduccionId;
        private System.Windows.Forms.ToolStripButton tsBtnVerReporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}