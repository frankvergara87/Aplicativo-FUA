namespace FissalWinForm
{
    partial class FrmEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadoCuenta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCuentaCadenaId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuentaPacienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuentaEstablecimientoId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPacienteActivoFissal = new System.Windows.Forms.ComboBox();
            this.cboPacienteActivoSis = new System.Windows.Forms.ComboBox();
            this.cboPacienteVivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.toolStripSeparator2,
            this.tsBtnCancelar,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGuardar.Image")));
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsBtnGuardar.Text = "Guardar";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsBtnCancelar
            // 
            this.tsBtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancelar.Image")));
            this.tsBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancelar.Name = "tsBtnCancelar";
            this.tsBtnCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsBtnCancelar.Text = "Cancelar";
            this.tsBtnCancelar.Click += new System.EventHandler(this.tsBtnCancelar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCuentaCadenaId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCuentaPacienteId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCuentaEstablecimientoId);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 45);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // txtCuentaCadenaId
            // 
            this.txtCuentaCadenaId.Location = new System.Drawing.Point(364, 16);
            this.txtCuentaCadenaId.Name = "txtCuentaCadenaId";
            this.txtCuentaCadenaId.Size = new System.Drawing.Size(60, 20);
            this.txtCuentaCadenaId.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "CadenaId";
            // 
            // txtCuentaPacienteId
            // 
            this.txtCuentaPacienteId.Location = new System.Drawing.Point(233, 16);
            this.txtCuentaPacienteId.Name = "txtCuentaPacienteId";
            this.txtCuentaPacienteId.Size = new System.Drawing.Size(60, 20);
            this.txtCuentaPacienteId.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "PacienteId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "EstablecimientoId";
            // 
            // txtCuentaEstablecimientoId
            // 
            this.txtCuentaEstablecimientoId.Location = new System.Drawing.Point(105, 16);
            this.txtCuentaEstablecimientoId.Name = "txtCuentaEstablecimientoId";
            this.txtCuentaEstablecimientoId.Size = new System.Drawing.Size(50, 20);
            this.txtCuentaEstablecimientoId.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPacienteActivoFissal);
            this.groupBox2.Controls.Add(this.cboPacienteActivoSis);
            this.groupBox2.Controls.Add(this.cboPacienteVivo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 95);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // cboPacienteActivoFissal
            // 
            this.cboPacienteActivoFissal.FormattingEnabled = true;
            this.cboPacienteActivoFissal.Location = new System.Drawing.Point(105, 66);
            this.cboPacienteActivoFissal.Name = "cboPacienteActivoFissal";
            this.cboPacienteActivoFissal.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteActivoFissal.TabIndex = 41;
            // 
            // cboPacienteActivoSis
            // 
            this.cboPacienteActivoSis.FormattingEnabled = true;
            this.cboPacienteActivoSis.Location = new System.Drawing.Point(105, 41);
            this.cboPacienteActivoSis.Name = "cboPacienteActivoSis";
            this.cboPacienteActivoSis.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteActivoSis.TabIndex = 40;
            this.cboPacienteActivoSis.Validating += new System.ComponentModel.CancelEventHandler(this.cboPacienteActivoSis_Validating);
            // 
            // cboPacienteVivo
            // 
            this.cboPacienteVivo.FormattingEnabled = true;
            this.cboPacienteVivo.Location = new System.Drawing.Point(105, 16);
            this.cboPacienteVivo.Name = "cboPacienteVivo";
            this.cboPacienteVivo.Size = new System.Drawing.Size(121, 21);
            this.cboPacienteVivo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Activo Fissal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Activo SIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Vivo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 182);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadoCuenta";
            this.Text = "FrmEstadoCuenta";
            this.Load += new System.EventHandler(this.FrmEstadoCuenta_Load);
            this.Validated += new System.EventHandler(this.FrmEstadoCuenta_Validated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCuentaCadenaId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuentaPacienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuentaEstablecimientoId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPacienteActivoFissal;
        private System.Windows.Forms.ComboBox cboPacienteActivoSis;
        private System.Windows.Forms.ComboBox cboPacienteVivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsBtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}