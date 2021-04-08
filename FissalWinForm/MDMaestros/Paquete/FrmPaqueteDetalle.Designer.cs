namespace FissalWinForm
{
    partial class FrmPaqueteDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaqueteDetalle));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpMedicamento = new System.Windows.Forms.TabPage();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.tbpProcedimiento = new System.Windows.Forms.TabPage();
            this.dgvProcedimiento = new System.Windows.Forms.DataGridView();
            this.lblMensaje02 = new System.Windows.Forms.Label();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dgvVersion = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnVerDetalle = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFase = new System.Windows.Forms.Label();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.lblAutorizacion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tbpMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.tbpProcedimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).BeginInit();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpMedicamento);
            this.tabControl.Controls.Add(this.tbpProcedimiento);
            this.tabControl.Location = new System.Drawing.Point(12, 262);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(850, 412);
            this.tabControl.TabIndex = 410;
            // 
            // tbpMedicamento
            // 
            this.tbpMedicamento.Controls.Add(this.lblMensaje);
            this.tbpMedicamento.Controls.Add(this.dgvMedicamento);
            this.tbpMedicamento.Location = new System.Drawing.Point(4, 22);
            this.tbpMedicamento.Name = "tbpMedicamento";
            this.tbpMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMedicamento.Size = new System.Drawing.Size(842, 386);
            this.tbpMedicamento.TabIndex = 0;
            this.tbpMedicamento.Text = "Medicamento";
            this.tbpMedicamento.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje.Location = new System.Drawing.Point(10, 360);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 427;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.AllowUserToDeleteRows = false;
            this.dgvMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(6, 6);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(830, 350);
            this.dgvMedicamento.TabIndex = 1;
            // 
            // tbpProcedimiento
            // 
            this.tbpProcedimiento.Controls.Add(this.dgvProcedimiento);
            this.tbpProcedimiento.Controls.Add(this.lblMensaje02);
            this.tbpProcedimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpProcedimiento.Name = "tbpProcedimiento";
            this.tbpProcedimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcedimiento.Size = new System.Drawing.Size(842, 386);
            this.tbpProcedimiento.TabIndex = 1;
            this.tbpProcedimiento.Text = "Procedimiento";
            this.tbpProcedimiento.UseVisualStyleBackColor = true;
            // 
            // dgvProcedimiento
            // 
            this.dgvProcedimiento.AllowUserToAddRows = false;
            this.dgvProcedimiento.AllowUserToDeleteRows = false;
            this.dgvProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimiento.Location = new System.Drawing.Point(6, 6);
            this.dgvProcedimiento.Name = "dgvProcedimiento";
            this.dgvProcedimiento.ReadOnly = true;
            this.dgvProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimiento.Size = new System.Drawing.Size(830, 350);
            this.dgvProcedimiento.TabIndex = 427;
            // 
            // lblMensaje02
            // 
            this.lblMensaje02.AutoSize = true;
            this.lblMensaje02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje02.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje02.Location = new System.Drawing.Point(10, 360);
            this.lblMensaje02.Name = "lblMensaje02";
            this.lblMensaje02.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje02.TabIndex = 426;
            // 
            // grbData
            // 
            this.grbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbData.Controls.Add(this.dgvVersion);
            this.grbData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.Blue;
            this.grbData.Location = new System.Drawing.Point(12, 116);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(850, 140);
            this.grbData.TabIndex = 409;
            this.grbData.TabStop = false;
            // 
            // dgvVersion
            // 
            this.dgvVersion.AllowUserToAddRows = false;
            this.dgvVersion.AllowUserToDeleteRows = false;
            this.dgvVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVersion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersion.Location = new System.Drawing.Point(16, 20);
            this.dgvVersion.Name = "dgvVersion";
            this.dgvVersion.ReadOnly = true;
            this.dgvVersion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVersion.Size = new System.Drawing.Size(820, 106);
            this.dgvVersion.TabIndex = 0;
            this.dgvVersion.Click += new System.EventHandler(this.dgvVersion_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNuevo,
            this.toolStripSeparator1,
            this.tsBtnGrabar,
            this.toolStripSeparator3,
            this.tsBtnEditar,
            this.toolStripSeparator2,
            this.tsBtnEliminar,
            this.toolStripSeparator4,
            this.tsBtnVerDetalle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 411;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnGrabar
            // 
            this.tsBtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGrabar.Image")));
            this.tsBtnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGrabar.Name = "tsBtnGrabar";
            this.tsBtnGrabar.Size = new System.Drawing.Size(62, 22);
            this.tsBtnGrabar.Text = "Grabar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnEditar
            // 
            this.tsBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEditar.Image")));
            this.tsBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditar.Name = "tsBtnEditar";
            this.tsBtnEditar.Size = new System.Drawing.Size(57, 22);
            this.tsBtnEditar.Text = "Editar";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblEstablecimiento);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblFase);
            this.groupBox1.Controls.Add(this.lblEstadio);
            this.groupBox1.Controls.Add(this.lblAutorizacion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 82);
            this.groupBox1.TabIndex = 412;
            this.groupBox1.TabStop = false;
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.ForeColor = System.Drawing.Color.Black;
            this.lblEstablecimiento.Location = new System.Drawing.Point(120, 21);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(250, 32);
            this.lblEstablecimiento.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(120, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblCategoria.TabIndex = 13;
            // 
            // lblFase
            // 
            this.lblFase.ForeColor = System.Drawing.Color.Black;
            this.lblFase.Location = new System.Drawing.Point(433, 21);
            this.lblFase.Name = "lblFase";
            this.lblFase.Size = new System.Drawing.Size(197, 32);
            this.lblFase.TabIndex = 12;
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.ForeColor = System.Drawing.Color.Black;
            this.lblEstadio.Location = new System.Drawing.Point(433, 53);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(0, 13);
            this.lblEstadio.TabIndex = 11;
            // 
            // lblAutorizacion
            // 
            this.lblAutorizacion.AutoSize = true;
            this.lblAutorizacion.ForeColor = System.Drawing.Color.Black;
            this.lblAutorizacion.Location = new System.Drawing.Point(733, 21);
            this.lblAutorizacion.Name = "lblAutorizacion";
            this.lblAutorizacion.Size = new System.Drawing.Size(0, 13);
            this.lblAutorizacion.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(720, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AUTORIZACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTABLECIMIENTO";
            // 
            // FrmPaqueteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.grbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paquete x Tratamiento";
            this.Load += new System.EventHandler(this.FrmPaqueteDetalle_Load);
            this.tabControl.ResumeLayout(false);
            this.tbpMedicamento.ResumeLayout(false);
            this.tbpMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.tbpProcedimiento.ResumeLayout(false);
            this.tbpProcedimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).EndInit();
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpMedicamento;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.TabPage tbpProcedimiento;
        private System.Windows.Forms.DataGridView dgvProcedimiento;
        private System.Windows.Forms.Label lblMensaje02;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.DataGridView dgvVersion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnVerDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFase;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.Label lblAutorizacion;
    }
}