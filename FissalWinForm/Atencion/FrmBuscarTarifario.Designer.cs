namespace FissalWinForm
{
    partial class FrmBuscarTarifario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarTarifario));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dgvVersion = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpMedicamento = new System.Windows.Forms.TabPage();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.tbpProcedimiento = new System.Windows.Forms.TabPage();
            this.dgvProcedimiento = new System.Windows.Forms.DataGridView();
            this.lblMensaje02 = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox13.SuspendLayout();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersion)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tbpMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.tbpProcedimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cboEstablecimiento);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(12, 27);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(480, 42);
            this.groupBox13.TabIndex = 407;
            this.groupBox13.TabStop = false;
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.ForeColor = System.Drawing.Color.Blue;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(111, 14);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(350, 21);
            this.cboEstablecimiento.TabIndex = 39;
            this.cboEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cboEstablecimiento_SelectedIndexChanged);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(95, 14);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 38;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(14, 14);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(81, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Establecimiento";
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.dgvVersion);
            this.grbData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.Blue;
            this.grbData.Location = new System.Drawing.Point(12, 72);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(730, 148);
            this.grbData.TabIndex = 406;
            this.grbData.TabStop = false;
            // 
            // dgvVersion
            // 
            this.dgvVersion.AllowUserToAddRows = false;
            this.dgvVersion.AllowUserToDeleteRows = false;
            this.dgvVersion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersion.Location = new System.Drawing.Point(16, 20);
            this.dgvVersion.Name = "dgvVersion";
            this.dgvVersion.ReadOnly = true;
            this.dgvVersion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVersion.Size = new System.Drawing.Size(700, 114);
            this.dgvVersion.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpMedicamento);
            this.tabControl.Controls.Add(this.tbpProcedimiento);
            this.tabControl.Location = new System.Drawing.Point(12, 255);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(730, 458);
            this.tabControl.TabIndex = 408;
            // 
            // tbpMedicamento
            // 
            this.tbpMedicamento.Controls.Add(this.lblMensaje);
            this.tbpMedicamento.Controls.Add(this.dgvMedicamento);
            this.tbpMedicamento.Location = new System.Drawing.Point(4, 22);
            this.tbpMedicamento.Name = "tbpMedicamento";
            this.tbpMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMedicamento.Size = new System.Drawing.Size(722, 432);
            this.tbpMedicamento.TabIndex = 0;
            this.tbpMedicamento.Text = "Medicamento";
            this.tbpMedicamento.UseVisualStyleBackColor = true;
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
            this.dgvMedicamento.Size = new System.Drawing.Size(710, 397);
            this.dgvMedicamento.TabIndex = 1;
            // 
            // tbpProcedimiento
            // 
            this.tbpProcedimiento.Controls.Add(this.dgvProcedimiento);
            this.tbpProcedimiento.Controls.Add(this.lblMensaje02);
            this.tbpProcedimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpProcedimiento.Name = "tbpProcedimiento";
            this.tbpProcedimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcedimiento.Size = new System.Drawing.Size(722, 432);
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
            this.dgvProcedimiento.Size = new System.Drawing.Size(710, 397);
            this.dgvProcedimiento.TabIndex = 427;
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
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.BackgroundImage")));
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarExcel.Location = new System.Drawing.Point(498, 33);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(35, 35);
            this.btnExportarExcel.TabIndex = 434;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(539, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(189, 21);
            this.progressBar.TabIndex = 449;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 452;
            this.label4.Text = "Ingresar Codigo y/o Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Blue;
            this.txtDescripcion.Location = new System.Drawing.Point(188, 229);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 20);
            this.txtDescripcion.TabIndex = 450;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(136, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 451;
            this.label3.Text = ":";
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
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 453;
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
            // FrmBuscarTarifario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 722);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.grbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarTarifario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Tarifarios por Establecimiento";
            this.Load += new System.EventHandler(this.FrmBuscarTarifario_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersion)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tbpMedicamento.ResumeLayout(false);
            this.tbpMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.tbpProcedimiento.ResumeLayout(false);
            this.tbpProcedimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvVersion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpMedicamento;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.TabPage tbpProcedimiento;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMensaje02;
        private System.Windows.Forms.DataGridView dgvProcedimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnCerrar;
    }
}