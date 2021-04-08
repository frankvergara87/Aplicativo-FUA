namespace FissalWinForm
{
    partial class FrmListaFuaNoValorizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaFuaNoValorizado));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnBuscarEESS = new System.Windows.Forms.Button();
            this.txtEESS = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lblPorcentage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.opc01 = new System.Windows.Forms.RadioButton();
            this.opc04 = new System.Windows.Forms.RadioButton();
            this.opc03 = new System.Windows.Forms.RadioButton();
            this.opc02 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje.Location = new System.Drawing.Point(430, 81);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 425;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 555);
            this.groupBox1.TabIndex = 419;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Fuas";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(16, 20);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1215, 520);
            this.dgvData.TabIndex = 0;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
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
            this.txtEESS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEESS_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarEESS);
            this.groupBox4.Controls.Add(this.txtEESS);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(417, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 56);
            this.groupBox4.TabIndex = 418;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selecionar Establecimiento";
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.lblTotal);
            this.grbData.Controls.Add(this.label5);
            this.grbData.Controls.Add(this.label6);
            this.grbData.Controls.Add(this.lblConsumo);
            this.grbData.Controls.Add(this.label63);
            this.grbData.Controls.Add(this.label74);
            this.grbData.Controls.Add(this.lblPorcentage);
            this.grbData.Controls.Add(this.label7);
            this.grbData.Controls.Add(this.label8);
            this.grbData.Controls.Add(this.lblFua);
            this.grbData.Controls.Add(this.label2);
            this.grbData.Controls.Add(this.label3);
            this.grbData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.Blue;
            this.grbData.Location = new System.Drawing.Point(166, 13);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(244, 116);
            this.grbData.TabIndex = 428;
            this.grbData.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(117, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 20);
            this.lblTotal.TabIndex = 425;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(102, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 424;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 423;
            this.label6.Text = "Total Procesadas";
            // 
            // lblConsumo
            // 
            this.lblConsumo.BackColor = System.Drawing.Color.White;
            this.lblConsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsumo.ForeColor = System.Drawing.Color.Blue;
            this.lblConsumo.Location = new System.Drawing.Point(117, 61);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(110, 20);
            this.lblConsumo.TabIndex = 422;
            this.lblConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(102, 61);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 421;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(13, 61);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(51, 13);
            this.label74.TabIndex = 420;
            this.label74.Text = "Consumo";
            // 
            // lblPorcentage
            // 
            this.lblPorcentage.BackColor = System.Drawing.Color.White;
            this.lblPorcentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorcentage.ForeColor = System.Drawing.Color.Blue;
            this.lblPorcentage.Location = new System.Drawing.Point(117, 38);
            this.lblPorcentage.Name = "lblPorcentage";
            this.lblPorcentage.Size = new System.Drawing.Size(110, 20);
            this.lblPorcentage.TabIndex = 419;
            this.lblPorcentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(102, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 418;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 417;
            this.label8.Text = "%";
            // 
            // lblFua
            // 
            this.lblFua.BackColor = System.Drawing.Color.White;
            this.lblFua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFua.ForeColor = System.Drawing.Color.Blue;
            this.lblFua.Location = new System.Drawing.Point(117, 15);
            this.lblFua.Name = "lblFua";
            this.lblFua.Size = new System.Drawing.Size(110, 20);
            this.lblFua.TabIndex = 416;
            this.lblFua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 415;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 414;
            this.label3.Text = "Fuas";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.BackgroundImage")));
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarExcel.Location = new System.Drawing.Point(787, 34);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(35, 35);
            this.btnExportarExcel.TabIndex = 430;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(828, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 429;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 696);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1215, 26);
            this.progressBar.TabIndex = 431;
            // 
            // opc01
            // 
            this.opc01.AutoSize = true;
            this.opc01.Location = new System.Drawing.Point(15, 14);
            this.opc01.Name = "opc01";
            this.opc01.Size = new System.Drawing.Size(90, 17);
            this.opc01.TabIndex = 434;
            this.opc01.TabStop = true;
            this.opc01.Text = "No Valorizado";
            this.opc01.UseVisualStyleBackColor = true;
            this.opc01.CheckedChanged += new System.EventHandler(this.opc01_CheckedChanged);
            // 
            // opc04
            // 
            this.opc04.AutoSize = true;
            this.opc04.Location = new System.Drawing.Point(15, 89);
            this.opc04.Name = "opc04";
            this.opc04.Size = new System.Drawing.Size(101, 17);
            this.opc04.TabIndex = 435;
            this.opc04.TabStop = true;
            this.opc04.Text = "Valorizado Total";
            this.opc04.UseVisualStyleBackColor = true;
            this.opc04.CheckedChanged += new System.EventHandler(this.opc04_CheckedChanged);
            // 
            // opc03
            // 
            this.opc03.AutoSize = true;
            this.opc03.Location = new System.Drawing.Point(15, 64);
            this.opc03.Name = "opc03";
            this.opc03.Size = new System.Drawing.Size(117, 17);
            this.opc03.TabIndex = 436;
            this.opc03.TabStop = true;
            this.opc03.Text = "Valorizado al 100%";
            this.opc03.UseVisualStyleBackColor = true;
            this.opc03.CheckedChanged += new System.EventHandler(this.opc03_CheckedChanged);
            // 
            // opc02
            // 
            this.opc02.AutoSize = true;
            this.opc02.Location = new System.Drawing.Point(15, 39);
            this.opc02.Name = "opc02";
            this.opc02.Size = new System.Drawing.Size(108, 17);
            this.opc02.TabIndex = 437;
            this.opc02.TabStop = true;
            this.opc02.Text = "Valorizado Parcial";
            this.opc02.UseVisualStyleBackColor = true;
            this.opc02.CheckedChanged += new System.EventHandler(this.opc02_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opc01);
            this.groupBox2.Controls.Add(this.opc02);
            this.groupBox2.Controls.Add(this.opc03);
            this.groupBox2.Controls.Add(this.opc04);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 116);
            this.groupBox2.TabIndex = 438;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 439;
            this.label1.Text = "Valorizado Total = Valorizado Parcial + Valorizado al 100%";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(1058, 34);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 19);
            this.lblLoading.TabIndex = 445;
            this.lblLoading.Text = "Espere un Momento...";
            this.lblLoading.Visible = false;
            // 
            // FrmListaFuaNoValorizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 730);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaFuaNoValorizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Fuas Valorizadas y No Valorizadas";
            this.Load += new System.EventHandler(this.FrmListaFuaNoValorizado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbData.ResumeLayout(false);
            this.grbData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnBuscarEESS;
        private System.Windows.Forms.TextBox txtEESS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.Label lblPorcentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.RadioButton opc01;
        private System.Windows.Forms.RadioButton opc04;
        private System.Windows.Forms.RadioButton opc03;
        private System.Windows.Forms.RadioButton opc02;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblLoading;
    }
}