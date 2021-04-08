namespace FissalWinForm
{
    partial class FrmConsumoValorizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsumoValorizado));
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dgvEstablecimiento = new System.Windows.Forms.DataGridView();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lblConsumoGlobal = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.grb02 = new System.Windows.Forms.GroupBox();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.grb03 = new System.Windows.Forms.GroupBox();
            this.dgvFua = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensaje02 = new System.Windows.Forms.Label();
            this.lblMensaje03 = new System.Windows.Forms.Label();
            this.btnExportar03 = new System.Windows.Forms.Button();
            this.btnExportar02 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimiento)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.grb02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.grb03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFua)).BeginInit();
            this.SuspendLayout();
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.dgvEstablecimiento);
            this.grbData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.Blue;
            this.grbData.Location = new System.Drawing.Point(12, 75);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(810, 200);
            this.grbData.TabIndex = 92;
            this.grbData.TabStop = false;
            this.grbData.Text = "Consumo por Establecimientos";
            // 
            // dgvEstablecimiento
            // 
            this.dgvEstablecimiento.AllowUserToAddRows = false;
            this.dgvEstablecimiento.AllowUserToDeleteRows = false;
            this.dgvEstablecimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstablecimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablecimiento.Location = new System.Drawing.Point(16, 20);
            this.dgvEstablecimiento.Name = "dgvEstablecimiento";
            this.dgvEstablecimiento.ReadOnly = true;
            this.dgvEstablecimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstablecimiento.Size = new System.Drawing.Size(780, 166);
            this.dgvEstablecimiento.TabIndex = 0;
            this.dgvEstablecimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstablecimiento_CellClick);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lblConsumoGlobal);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(12, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(321, 57);
            this.groupBox13.TabIndex = 404;
            this.groupBox13.TabStop = false;
            // 
            // lblConsumoGlobal
            // 
            this.lblConsumoGlobal.BackColor = System.Drawing.Color.White;
            this.lblConsumoGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsumoGlobal.ForeColor = System.Drawing.Color.Blue;
            this.lblConsumoGlobal.Location = new System.Drawing.Point(135, 21);
            this.lblConsumoGlobal.Name = "lblConsumoGlobal";
            this.lblConsumoGlobal.Size = new System.Drawing.Size(168, 20);
            this.lblConsumoGlobal.TabIndex = 41;
            this.lblConsumoGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(114, 21);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 38;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(14, 21);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(84, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Consumo Global";
            // 
            // grb02
            // 
            this.grb02.Controls.Add(this.dgvPaciente);
            this.grb02.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb02.ForeColor = System.Drawing.Color.Blue;
            this.grb02.Location = new System.Drawing.Point(12, 281);
            this.grb02.Name = "grb02";
            this.grb02.Size = new System.Drawing.Size(810, 200);
            this.grb02.TabIndex = 405;
            this.grb02.TabStop = false;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(16, 20);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaciente.Size = new System.Drawing.Size(780, 166);
            this.dgvPaciente.TabIndex = 0;
            this.dgvPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellClick);
            // 
            // grb03
            // 
            this.grb03.Controls.Add(this.dgvFua);
            this.grb03.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb03.ForeColor = System.Drawing.Color.Blue;
            this.grb03.Location = new System.Drawing.Point(12, 487);
            this.grb03.Name = "grb03";
            this.grb03.Size = new System.Drawing.Size(810, 200);
            this.grb03.TabIndex = 406;
            this.grb03.TabStop = false;
            // 
            // dgvFua
            // 
            this.dgvFua.AllowUserToAddRows = false;
            this.dgvFua.AllowUserToDeleteRows = false;
            this.dgvFua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFua.Location = new System.Drawing.Point(16, 20);
            this.dgvFua.Name = "dgvFua";
            this.dgvFua.ReadOnly = true;
            this.dgvFua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFua.Size = new System.Drawing.Size(780, 166);
            this.dgvFua.TabIndex = 0;
            this.dgvFua.DoubleClick += new System.EventHandler(this.dgvFua_DoubleClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(828, 133);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 416;
            // 
            // lblMensaje02
            // 
            this.lblMensaje02.AutoSize = true;
            this.lblMensaje02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje02.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje02.Location = new System.Drawing.Point(828, 339);
            this.lblMensaje02.Name = "lblMensaje02";
            this.lblMensaje02.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje02.TabIndex = 417;
            // 
            // lblMensaje03
            // 
            this.lblMensaje03.AutoSize = true;
            this.lblMensaje03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje03.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje03.Location = new System.Drawing.Point(828, 545);
            this.lblMensaje03.Name = "lblMensaje03";
            this.lblMensaje03.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje03.TabIndex = 418;
            // 
            // btnExportar03
            // 
            this.btnExportar03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar03.BackgroundImage")));
            this.btnExportar03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar03.FlatAppearance.BorderSize = 0;
            this.btnExportar03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar03.Location = new System.Drawing.Point(828, 507);
            this.btnExportar03.Name = "btnExportar03";
            this.btnExportar03.Size = new System.Drawing.Size(35, 35);
            this.btnExportar03.TabIndex = 434;
            this.btnExportar03.UseVisualStyleBackColor = false;
            this.btnExportar03.Click += new System.EventHandler(this.btnExportar03_Click);
            // 
            // btnExportar02
            // 
            this.btnExportar02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar02.BackgroundImage")));
            this.btnExportar02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar02.FlatAppearance.BorderSize = 0;
            this.btnExportar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar02.Location = new System.Drawing.Point(828, 301);
            this.btnExportar02.Name = "btnExportar02";
            this.btnExportar02.Size = new System.Drawing.Size(35, 35);
            this.btnExportar02.TabIndex = 435;
            this.btnExportar02.UseVisualStyleBackColor = false;
            this.btnExportar02.Click += new System.EventHandler(this.btnExportar02_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Location = new System.Drawing.Point(828, 95);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(35, 35);
            this.btnExportar.TabIndex = 436;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(339, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(469, 26);
            this.progressBar.TabIndex = 444;
            // 
            // FrmConsumoValorizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 697);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnExportar02);
            this.Controls.Add(this.btnExportar03);
            this.Controls.Add(this.lblMensaje03);
            this.Controls.Add(this.lblMensaje02);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grb03);
            this.Controls.Add(this.grb02);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.grbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsumoValorizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo Valorizado";
            this.Load += new System.EventHandler(this.FrmConsumoValorizado_Load);
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablecimiento)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.grb02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.grb03.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.DataGridView dgvEstablecimiento;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label lblConsumoGlobal;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox grb02;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.GroupBox grb03;
        private System.Windows.Forms.DataGridView dgvFua;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMensaje02;
        private System.Windows.Forms.Label lblMensaje03;
        private System.Windows.Forms.Button btnExportar03;
        private System.Windows.Forms.Button btnExportar02;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}