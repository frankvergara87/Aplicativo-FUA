namespace FissalWinForm
{
    partial class FrmPostConsistencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPostConsistencia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnValidar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFuas = new System.Windows.Forms.DataGridView();
            this.lblLoading = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleFuas = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblFuasObs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFuas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnValidar,
            this.toolStripSeparator2,
            this.tsBtnExportar,
            this.toolStripSeparator1,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 462;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnValidar
            // 
            this.tsBtnValidar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnValidar.Image")));
            this.tsBtnValidar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnValidar.Name = "tsBtnValidar";
            this.tsBtnValidar.Size = new System.Drawing.Size(63, 22);
            this.tsBtnValidar.Text = "Validar";
            this.tsBtnValidar.ToolTipText = "Validar";
            this.tsBtnValidar.Click += new System.EventHandler(this.tsBtnValidar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnExportar
            // 
            this.tsBtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportar.Image")));
            this.tsBtnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportar.Name = "tsBtnExportar";
            this.tsBtnExportar.Size = new System.Drawing.Size(70, 22);
            this.tsBtnExportar.Text = "Exportar";
            this.tsBtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsBtnExportar.Click += new System.EventHandler(this.tsBtnExportar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSalir.Image")));
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(49, 22);
            this.tsBtnSalir.Text = "Salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFuas);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 208);
            this.groupBox1.TabIndex = 464;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas de Fuas Observados";
            // 
            // dgvFuas
            // 
            this.dgvFuas.AllowUserToAddRows = false;
            this.dgvFuas.AllowUserToDeleteRows = false;
            this.dgvFuas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuas.Location = new System.Drawing.Point(20, 19);
            this.dgvFuas.Name = "dgvFuas";
            this.dgvFuas.ReadOnly = true;
            this.dgvFuas.Size = new System.Drawing.Size(761, 173);
            this.dgvFuas.TabIndex = 0;
            this.dgvFuas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuas_CellClick);
            this.dgvFuas.CurrentCellChanged += new System.EventHandler(this.dgvFuas_CurrentCellChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(627, 6);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 19);
            this.lblLoading.TabIndex = 461;
            this.lblLoading.Text = "Espere un Momento...";
            this.lblLoading.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalleFuas);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 258);
            this.groupBox2.TabIndex = 465;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Fuas Observados";
            // 
            // dgvDetalleFuas
            // 
            this.dgvDetalleFuas.AllowUserToAddRows = false;
            this.dgvDetalleFuas.AllowUserToDeleteRows = false;
            this.dgvDetalleFuas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleFuas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFuas.Location = new System.Drawing.Point(20, 19);
            this.dgvDetalleFuas.Name = "dgvDetalleFuas";
            this.dgvDetalleFuas.ReadOnly = true;
            this.dgvDetalleFuas.Size = new System.Drawing.Size(761, 222);
            this.dgvDetalleFuas.TabIndex = 0;
            this.dgvDetalleFuas.DoubleClick += new System.EventHandler(this.dgvDetalleFuas_DoubleClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(478, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 20);
            this.progressBar.TabIndex = 466;
            this.progressBar.Visible = false;
            // 
            // lblFuasObs
            // 
            this.lblFuasObs.AutoSize = true;
            this.lblFuasObs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuasObs.ForeColor = System.Drawing.Color.Black;
            this.lblFuasObs.Location = new System.Drawing.Point(696, 487);
            this.lblFuasObs.Name = "lblFuasObs";
            this.lblFuasObs.Size = new System.Drawing.Size(0, 16);
            this.lblFuasObs.TabIndex = 467;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(531, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 468;
            this.label1.Text = "Total Fuas Observadas - ";
            // 
            // FrmPostConsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFuasObs);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPostConsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPostConsistencia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFuas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnValidar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFuas;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalleFuas;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblFuasObs;
        private System.Windows.Forms.Label label1;
    }
}