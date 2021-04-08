namespace FissalWinForm
{
    partial class FrmValorizacionPreliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValorizacionPreliminar));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.dgvValorizacion = new System.Windows.Forms.DataGridView();
            this.label74 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tbpIpress = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tsBtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorizacion)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tbpIpress.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.ForeColor = System.Drawing.Color.Blue;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(125, 21);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(450, 21);
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
            // dgvValorizacion
            // 
            this.dgvValorizacion.AllowUserToAddRows = false;
            this.dgvValorizacion.AllowUserToDeleteRows = false;
            this.dgvValorizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvValorizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValorizacion.Location = new System.Drawing.Point(13, 75);
            this.dgvValorizacion.Name = "dgvValorizacion";
            this.dgvValorizacion.ReadOnly = true;
            this.dgvValorizacion.Size = new System.Drawing.Size(1326, 436);
            this.dgvValorizacion.TabIndex = 428;
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
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cboEstablecimiento);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(13, 9);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(600, 57);
            this.groupBox13.TabIndex = 429;
            this.groupBox13.TabStop = false;
            // 
            // tbpIpress
            // 
            this.tbpIpress.Controls.Add(this.groupBox13);
            this.tbpIpress.Controls.Add(this.dgvValorizacion);
            this.tbpIpress.Controls.Add(this.lblMensaje);
            this.tbpIpress.Location = new System.Drawing.Point(4, 22);
            this.tbpIpress.Name = "tbpIpress";
            this.tbpIpress.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIpress.Size = new System.Drawing.Size(1352, 524);
            this.tbpIpress.TabIndex = 0;
            this.tbpIpress.Text = "Ipress";
            this.tbpIpress.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tbpIpress);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1360, 550);
            this.tabControl.TabIndex = 437;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1225, 11);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 20);
            this.progressBar.TabIndex = 436;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnExportar,
            this.toolStripSeparator1,
            this.tsBtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip1.TabIndex = 435;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmValorizacionPreliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 602);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValorizacionPreliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valorizacion Preliminar";
            this.Load += new System.EventHandler(this.FrmValorizacionPreliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorizacion)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tbpIpress.ResumeLayout(false);
            this.tbpIpress.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.DataGridView dgvValorizacion;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TabPage tbpIpress;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripButton tsBtnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}