namespace FissalWinForm
{
    partial class FrmResumenConciliacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumenConciliacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpIpress = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.dgvResumenConciliacion = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tbpPaciente = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.dgvResumenConciliacionPaciente = new System.Windows.Forms.DataGridView();
            this.lblMensaje02 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tbpIpress.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenConciliacion)).BeginInit();
            this.tbpPaciente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenConciliacionPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnExportar,
            this.toolStripSeparator1,
            this.tsBtnBuscar,
            this.toolStripSeparator3,
            this.tsBtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip1.TabIndex = 108;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnExportar
            // 
            this.tsBtnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportar.Image")));
            this.tsBtnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportar.Name = "tsBtnExportar";
            this.tsBtnExportar.Size = new System.Drawing.Size(108, 22);
            this.tsBtnExportar.Text = "Exportar a Excel";
            this.tsBtnExportar.Click += new System.EventHandler(this.tsBtnExportar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnCerrar
            // 
            this.tsBtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCerrar.Image")));
            this.tsBtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCerrar.Name = "tsBtnCerrar";
            this.tsBtnCerrar.Size = new System.Drawing.Size(59, 22);
            this.tsBtnCerrar.Text = "Cerrar";
            this.tsBtnCerrar.Click += new System.EventHandler(this.tsBtnCerrar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1225, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 20);
            this.progressBar.TabIndex = 432;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tbpIpress);
            this.tabControl.Controls.Add(this.tbpPaciente);
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1360, 672);
            this.tabControl.TabIndex = 434;
            // 
            // tbpIpress
            // 
            this.tbpIpress.Controls.Add(this.groupBox13);
            this.tbpIpress.Controls.Add(this.dgvResumenConciliacion);
            this.tbpIpress.Controls.Add(this.lblMensaje);
            this.tbpIpress.Location = new System.Drawing.Point(4, 22);
            this.tbpIpress.Name = "tbpIpress";
            this.tbpIpress.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIpress.Size = new System.Drawing.Size(1352, 646);
            this.tbpIpress.TabIndex = 0;
            this.tbpIpress.Text = "Ipress";
            this.tbpIpress.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cboEstablecimiento);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(13, 9);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(510, 57);
            this.groupBox13.TabIndex = 429;
            this.groupBox13.TabStop = false;
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.ForeColor = System.Drawing.Color.Blue;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(125, 21);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(350, 21);
            this.cboEstablecimiento.TabIndex = 39;
            this.cboEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cboEstablecimiento_SelectedIndexChanged);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(109, 21);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 38;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(28, 21);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(81, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Establecimiento";
            // 
            // dgvResumenConciliacion
            // 
            this.dgvResumenConciliacion.AllowUserToAddRows = false;
            this.dgvResumenConciliacion.AllowUserToDeleteRows = false;
            this.dgvResumenConciliacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResumenConciliacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumenConciliacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenConciliacion.Location = new System.Drawing.Point(13, 75);
            this.dgvResumenConciliacion.Name = "dgvResumenConciliacion";
            this.dgvResumenConciliacion.ReadOnly = true;
            this.dgvResumenConciliacion.Size = new System.Drawing.Size(1326, 558);
            this.dgvResumenConciliacion.TabIndex = 428;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje.Location = new System.Drawing.Point(10, 406);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 427;
            // 
            // tbpPaciente
            // 
            this.tbpPaciente.Controls.Add(this.groupBox4);
            this.tbpPaciente.Controls.Add(this.dgvResumenConciliacionPaciente);
            this.tbpPaciente.Controls.Add(this.lblMensaje02);
            this.tbpPaciente.Location = new System.Drawing.Point(4, 22);
            this.tbpPaciente.Name = "tbpPaciente";
            this.tbpPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPaciente.Size = new System.Drawing.Size(1352, 646);
            this.tbpPaciente.TabIndex = 1;
            this.tbpPaciente.Text = "Paciente";
            this.tbpPaciente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cboTipoDoc);
            this.groupBox4.Controls.Add(this.txtDNI);
            this.groupBox4.Controls.Add(this.txtPaciente);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(13, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(963, 63);
            this.groupBox4.TabIndex = 428;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(257, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 411;
            this.label5.Text = "Nro Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 410;
            this.label4.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(520, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 409;
            this.label3.Text = "Nombres";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.ForeColor = System.Drawing.Color.Black;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(135, 24);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.cboTipoDoc.TabIndex = 408;
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.Color.Blue;
            this.txtDNI.Location = new System.Drawing.Point(344, 24);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(124, 21);
            this.txtDNI.TabIndex = 1;
            // 
            // txtPaciente
            // 
            this.txtPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaciente.ForeColor = System.Drawing.Color.Blue;
            this.txtPaciente.Location = new System.Drawing.Point(575, 24);
            this.txtPaciente.MaxLength = 50;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(350, 21);
            this.txtPaciente.TabIndex = 2;
            // 
            // dgvResumenConciliacionPaciente
            // 
            this.dgvResumenConciliacionPaciente.AllowUserToAddRows = false;
            this.dgvResumenConciliacionPaciente.AllowUserToDeleteRows = false;
            this.dgvResumenConciliacionPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResumenConciliacionPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumenConciliacionPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenConciliacionPaciente.Location = new System.Drawing.Point(13, 75);
            this.dgvResumenConciliacionPaciente.Name = "dgvResumenConciliacionPaciente";
            this.dgvResumenConciliacionPaciente.ReadOnly = true;
            this.dgvResumenConciliacionPaciente.Size = new System.Drawing.Size(1326, 558);
            this.dgvResumenConciliacionPaciente.TabIndex = 427;
            // 
            // lblMensaje02
            // 
            this.lblMensaje02.AutoSize = true;
            this.lblMensaje02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje02.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje02.Location = new System.Drawing.Point(10, 406);
            this.lblMensaje02.Name = "lblMensaje02";
            this.lblMensaje02.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje02.TabIndex = 426;
            // 
            // FrmResumenConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 712);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResumenConciliacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen Conciliacion";
            this.Load += new System.EventHandler(this.FrmResumenConciliacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tbpIpress.ResumeLayout(false);
            this.tbpIpress.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenConciliacion)).EndInit();
            this.tbpPaciente.ResumeLayout(false);
            this.tbpPaciente.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenConciliacionPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpIpress;
        private System.Windows.Forms.DataGridView dgvResumenConciliacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TabPage tbpPaciente;
        private System.Windows.Forms.DataGridView dgvResumenConciliacionPaciente;
        private System.Windows.Forms.Label lblMensaje02;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.Label label5;
    }
}