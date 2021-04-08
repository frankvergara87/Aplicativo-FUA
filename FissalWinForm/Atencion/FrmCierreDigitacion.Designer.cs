namespace FissalWinForm
{
    partial class FrmCierreDigitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierreDigitacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnEjecutar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblLoading = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblIpress = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFuasxCerrar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblFechaCierreLarga = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnEjecutar,
            this.toolStripSeparator2,
            this.tsBtnExportar,
            this.toolStripSeparator1,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 457;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnEjecutar
            // 
            this.tsBtnEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEjecutar.Image")));
            this.tsBtnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEjecutar.Name = "tsBtnEjecutar";
            this.tsBtnEjecutar.Size = new System.Drawing.Size(69, 22);
            this.tsBtnEjecutar.Text = "Ejecutar";
            this.tsBtnEjecutar.ToolTipText = "Ejecutar";
            this.tsBtnEjecutar.Click += new System.EventHandler(this.tsBtnEjecutar_Click);
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
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(28, 136);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 19);
            this.lblLoading.TabIndex = 456;
            this.lblLoading.Text = "Espere un Momento...";
            this.lblLoading.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(583, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 20);
            this.progressBar.TabIndex = 461;
            this.progressBar.Visible = false;
            // 
            // lblIpress
            // 
            this.lblIpress.AutoSize = true;
            this.lblIpress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpress.ForeColor = System.Drawing.Color.Black;
            this.lblIpress.Location = new System.Drawing.Point(369, 44);
            this.lblIpress.Name = "lblIpress";
            this.lblIpress.Size = new System.Drawing.Size(63, 16);
            this.lblIpress.TabIndex = 462;
            this.lblIpress.Text = "lblIpress";
            this.lblIpress.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(77, 25);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 16);
            this.lblDescripcion.TabIndex = 463;
            this.lblDescripcion.Text = "lblDescripcion";
            // 
            // lblFuasxCerrar
            // 
            this.lblFuasxCerrar.AutoSize = true;
            this.lblFuasxCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuasxCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblFuasxCerrar.Location = new System.Drawing.Point(137, 60);
            this.lblFuasxCerrar.Name = "lblFuasxCerrar";
            this.lblFuasxCerrar.Size = new System.Drawing.Size(100, 16);
            this.lblFuasxCerrar.TabIndex = 464;
            this.lblFuasxCerrar.Text = "lblFuasxCerrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFuasxCerrar);
            this.groupBox1.Controls.Add(this.lblIpress);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 96);
            this.groupBox1.TabIndex = 460;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 466;
            this.label2.Text = "Fuas por Cerrar - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 465;
            this.label1.Text = "Ipress - ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFechaCierreLarga);
            this.groupBox3.Controls.Add(this.lblFechaCierre);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(456, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 71);
            this.groupBox3.TabIndex = 462;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha Cierre Hasta";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCierre.Location = new System.Drawing.Point(17, 32);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(46, 16);
            this.lblFechaCierre.TabIndex = 465;
            this.lblFechaCierre.Text = "label3";
            // 
            // lblFechaCierreLarga
            // 
            this.lblFechaCierreLarga.AutoSize = true;
            this.lblFechaCierreLarga.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierreLarga.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCierreLarga.Location = new System.Drawing.Point(124, 32);
            this.lblFechaCierreLarga.Name = "lblFechaCierreLarga";
            this.lblFechaCierreLarga.Size = new System.Drawing.Size(46, 16);
            this.lblFechaCierreLarga.TabIndex = 466;
            this.lblFechaCierreLarga.Text = "label4";
            // 
            // FrmCierreDigitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 167);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCierreDigitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCierreDigitacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripButton tsBtnEjecutar;
        private System.Windows.Forms.ToolStripButton tsBtnExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblIpress;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFuasxCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFechaCierreLarga;
        private System.Windows.Forms.Label lblFechaCierre;

    }
}