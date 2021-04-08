namespace FissalWinForm
{
    partial class FrmControlCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlCalidad));
            this.lstDataSD = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDataFAE = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDataFD = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstDataSC = new System.Windows.Forms.ListBox();
            this.label90 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEESS = new System.Windows.Forms.Button();
            this.txtEESS = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDataSD
            // 
            this.lstDataSD.FormattingEnabled = true;
            this.lstDataSD.Location = new System.Drawing.Point(16, 19);
            this.lstDataSD.Name = "lstDataSD";
            this.lstDataSD.Size = new System.Drawing.Size(160, 134);
            this.lstDataSD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDataSD);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 168);
            this.groupBox3.TabIndex = 404;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fuas Sin Diagnostico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDataFAE);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(228, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 168);
            this.groupBox1.TabIndex = 405;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuas con F. Atencion Erronea";
            // 
            // lstDataFAE
            // 
            this.lstDataFAE.FormattingEnabled = true;
            this.lstDataFAE.Location = new System.Drawing.Point(16, 19);
            this.lstDataFAE.Name = "lstDataFAE";
            this.lstDataFAE.Size = new System.Drawing.Size(160, 134);
            this.lstDataFAE.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDataFD);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 168);
            this.groupBox2.TabIndex = 405;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuas Duplicados";
            // 
            // lstDataFD
            // 
            this.lstDataFD.FormattingEnabled = true;
            this.lstDataFD.Location = new System.Drawing.Point(16, 19);
            this.lstDataFD.Name = "lstDataFD";
            this.lstDataFD.Size = new System.Drawing.Size(160, 134);
            this.lstDataFD.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstDataSC);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(228, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 168);
            this.groupBox4.TabIndex = 405;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fuas Sin Consumo";
            // 
            // lstDataSC
            // 
            this.lstDataSC.FormattingEnabled = true;
            this.lstDataSC.Location = new System.Drawing.Point(16, 19);
            this.lstDataSC.Name = "lstDataSC";
            this.lstDataSC.Size = new System.Drawing.Size(160, 134);
            this.lstDataSC.TabIndex = 0;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.Teal;
            this.label90.Location = new System.Drawing.Point(331, 95);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(201, 13);
            this.label90.TabIndex = 423;
            this.label90.Text = "Resultado : FUA | LOTE | CORRELATIVO";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(140, 37);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaFin.TabIndex = 450;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(16, 37);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaInicio.TabIndex = 449;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 448;
            this.label10.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 447;
            this.label1.Text = "Inicio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarEESS);
            this.groupBox5.Controls.Add(this.txtEESS);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 56);
            this.groupBox5.TabIndex = 446;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selecionar Establecimiento";
            // 
            // btnBuscarEESS
            // 
            this.btnBuscarEESS.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarEESS.Location = new System.Drawing.Point(322, 21);
            this.btnBuscarEESS.Name = "btnBuscarEESS";
            this.btnBuscarEESS.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarEESS.TabIndex = 413;
            this.btnBuscarEESS.Text = "...";
            this.btnBuscarEESS.UseVisualStyleBackColor = true;
            this.btnBuscarEESS.Click += new System.EventHandler(this.btnBuscarEESS_Click);
            // 
            // txtEESS
            // 
            this.txtEESS.ForeColor = System.Drawing.Color.Black;
            this.txtEESS.Location = new System.Drawing.Point(16, 22);
            this.txtEESS.MaxLength = 100;
            this.txtEESS.Name = "txtEESS";
            this.txtEESS.Size = new System.Drawing.Size(300, 21);
            this.txtEESS.TabIndex = 411;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpFechaFin);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.dtpFechaInicio);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(12, 74);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 74);
            this.groupBox6.TabIndex = 452;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fecha de Registro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(382, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 451;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmControlCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 506);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmControlCalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Calidad";
            this.Load += new System.EventHandler(this.FrmControlCalidad_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDataSD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDataFAE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDataFD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstDataSC;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarEESS;
        private System.Windows.Forms.TextBox txtEESS;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBuscar;
    }
}