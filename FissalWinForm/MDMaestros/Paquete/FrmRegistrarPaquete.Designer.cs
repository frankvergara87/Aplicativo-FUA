namespace FissalWinForm
{
    partial class FrmRegistrarPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarPaquete));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTratamientoId = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboAutorizacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEstadio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGrabar,
            this.toolStripSeparator3,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 412;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGrabar
            // 
            this.tsBtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGrabar.Image")));
            this.tsBtnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGrabar.Name = "tsBtnGrabar";
            this.tsBtnGrabar.Size = new System.Drawing.Size(62, 22);
            this.tsBtnGrabar.Text = "Grabar";
            this.tsBtnGrabar.Click += new System.EventHandler(this.tsBtnGrabar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label17);
            this.groupBox13.Controls.Add(this.label18);
            this.groupBox13.Controls.Add(this.lblTratamientoId);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Controls.Add(this.label14);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.label12);
            this.groupBox13.Controls.Add(this.lblVersion);
            this.groupBox13.Controls.Add(this.lblFechaCreacion);
            this.groupBox13.Controls.Add(this.lblUsuario);
            this.groupBox13.Controls.Add(this.cboAutorizacion);
            this.groupBox13.Controls.Add(this.label7);
            this.groupBox13.Controls.Add(this.label8);
            this.groupBox13.Controls.Add(this.cboEstadio);
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.label6);
            this.groupBox13.Controls.Add(this.cboCategoria);
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Controls.Add(this.label4);
            this.groupBox13.Controls.Add(this.cboFase);
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.cboEstablecimiento);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Location = new System.Drawing.Point(12, 28);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(564, 359);
            this.groupBox13.TabIndex = 411;
            this.groupBox13.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(96, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 426;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(14, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 425;
            this.label18.Text = "Tratamiento ID";
            // 
            // lblTratamientoId
            // 
            this.lblTratamientoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTratamientoId.ForeColor = System.Drawing.Color.Black;
            this.lblTratamientoId.Location = new System.Drawing.Point(114, 18);
            this.lblTratamientoId.Name = "lblTratamientoId";
            this.lblTratamientoId.Size = new System.Drawing.Size(77, 20);
            this.lblTratamientoId.TabIndex = 424;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(96, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 423;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(14, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 422;
            this.label16.Text = "Usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(96, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 421;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 420;
            this.label14.Text = "Fecha Creacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 419;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 418;
            this.label12.Text = "Version";
            // 
            // lblVersion
            // 
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(114, 250);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(77, 20);
            this.lblVersion.TabIndex = 417;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCreacion.Location = new System.Drawing.Point(114, 288);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(77, 20);
            this.lblFechaCreacion.TabIndex = 416;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(114, 326);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 20);
            this.lblUsuario.TabIndex = 415;
            // 
            // cboAutorizacion
            // 
            this.cboAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutorizacion.ForeColor = System.Drawing.Color.Blue;
            this.cboAutorizacion.FormattingEnabled = true;
            this.cboAutorizacion.Location = new System.Drawing.Point(114, 94);
            this.cboAutorizacion.Name = "cboAutorizacion";
            this.cboAutorizacion.Size = new System.Drawing.Size(140, 21);
            this.cboAutorizacion.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Autorizacion";
            // 
            // cboEstadio
            // 
            this.cboEstadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadio.ForeColor = System.Drawing.Color.Blue;
            this.cboEstadio.FormattingEnabled = true;
            this.cboEstadio.Location = new System.Drawing.Point(114, 172);
            this.cboEstadio.Name = "cboEstadio";
            this.cboEstadio.Size = new System.Drawing.Size(140, 21);
            this.cboEstadio.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.ForeColor = System.Drawing.Color.Blue;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(114, 133);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(430, 21);
            this.cboCategoria.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fase";
            // 
            // cboFase
            // 
            this.cboFase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFase.ForeColor = System.Drawing.Color.Blue;
            this.cboFase.FormattingEnabled = true;
            this.cboFase.Location = new System.Drawing.Point(114, 211);
            this.cboFase.Name = "cboFase";
            this.cboFase.Size = new System.Drawing.Size(280, 21);
            this.cboFase.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Estadio";
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimiento.ForeColor = System.Drawing.Color.Blue;
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(114, 55);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(430, 21);
            this.cboEstablecimiento.TabIndex = 39;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(96, 55);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(10, 13);
            this.label63.TabIndex = 38;
            this.label63.Text = ":";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(14, 55);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(81, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Establecimiento";
            // 
            // FrmRegistrarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 396);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Paquete";
            this.Load += new System.EventHandler(this.FrmRegistrarPaquete_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox cboAutorizacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEstadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTratamientoId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblUsuario;
    }
}