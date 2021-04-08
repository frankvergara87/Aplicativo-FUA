namespace FissalWinForm
{
    partial class FrmProfesional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesional));
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCMP = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.groupBox10.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtNombre);
            this.groupBox10.Controls.Add(this.txtCMP);
            this.groupBox10.Controls.Add(this.label86);
            this.groupBox10.Controls.Add(this.label85);
            this.groupBox10.Controls.Add(this.label88);
            this.groupBox10.Controls.Add(this.label89);
            this.groupBox10.Controls.Add(this.label82);
            this.groupBox10.Controls.Add(this.label83);
            this.groupBox10.Controls.Add(this.label40);
            this.groupBox10.Controls.Add(this.cboEspecialidad);
            this.groupBox10.Controls.Add(this.txtDNI);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.ForeColor = System.Drawing.Color.Blue;
            this.groupBox10.Location = new System.Drawing.Point(12, 28);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(488, 180);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(94, 62);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCMP
            // 
            this.txtCMP.ForeColor = System.Drawing.Color.Black;
            this.txtCMP.Location = new System.Drawing.Point(94, 101);
            this.txtCMP.MaxLength = 8;
            this.txtCMP.Name = "txtCMP";
            this.txtCMP.Size = new System.Drawing.Size(84, 20);
            this.txtCMP.TabIndex = 2;
            this.txtCMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMP_KeyDown);
            this.txtCMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.Black;
            this.label86.Location = new System.Drawing.Point(78, 62);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(10, 13);
            this.label86.TabIndex = 420;
            this.label86.Text = ":";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.ForeColor = System.Drawing.Color.Black;
            this.label85.Location = new System.Drawing.Point(14, 62);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(44, 13);
            this.label85.TabIndex = 419;
            this.label85.Text = "Nombre";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.Black;
            this.label88.Location = new System.Drawing.Point(78, 140);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(10, 13);
            this.label88.TabIndex = 417;
            this.label88.Text = ":";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.Color.Black;
            this.label89.Location = new System.Drawing.Point(14, 140);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(67, 13);
            this.label89.TabIndex = 416;
            this.label89.Text = "Especialidad";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.Black;
            this.label82.Location = new System.Drawing.Point(78, 101);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(10, 13);
            this.label82.TabIndex = 411;
            this.label82.Text = ":";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.Color.Black;
            this.label83.Location = new System.Drawing.Point(14, 101);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(30, 13);
            this.label83.TabIndex = 410;
            this.label83.Text = "CMP";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(78, 23);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(10, 13);
            this.label40.TabIndex = 38;
            this.label40.Text = ":";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(94, 140);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(250, 21);
            this.cboEspecialidad.TabIndex = 3;
            this.cboEspecialidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEspecialidad_KeyDown);
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.Location = new System.Drawing.Point(94, 23);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(84, 20);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyDown);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumero);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(14, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "DNI";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGrabar,
            this.toolStripSeparator1,
            this.tsBtnActualizar,
            this.toolStripSeparator2,
            this.tsBtnEliminar,
            this.tsBtnCancelar,
            this.tsBtnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 25);
            this.toolStrip1.TabIndex = 404;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGrabar
            // 
            this.tsBtnGrabar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGrabar.Image")));
            this.tsBtnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGrabar.Name = "tsBtnGrabar";
            this.tsBtnGrabar.Size = new System.Drawing.Size(62, 22);
            this.tsBtnGrabar.Text = "Grabar";
            this.tsBtnGrabar.Click += new System.EventHandler(this.tsBtnExportarExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnActualizar
            // 
            this.tsBtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnActualizar.Image")));
            this.tsBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnActualizar.Name = "tsBtnActualizar";
            this.tsBtnActualizar.Size = new System.Drawing.Size(79, 22);
            this.tsBtnActualizar.Text = "Actualizar";
            this.tsBtnActualizar.Click += new System.EventHandler(this.tsBtnLimpiar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnEliminar
            // 
            this.tsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEliminar.Image")));
            this.tsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEliminar.Name = "tsBtnEliminar";
            this.tsBtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsBtnEliminar.Text = "Eliminar";
            this.tsBtnEliminar.Click += new System.EventHandler(this.tsBtnEliminar_Click);
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
            // tsBtnBuscar
            // 
            this.tsBtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscar.Image")));
            this.tsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscar.Name = "tsBtnBuscar";
            this.tsBtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsBtnBuscar.Text = "Buscar";
            this.tsBtnBuscar.Click += new System.EventHandler(this.tsBtnBuscar_Click);
            // 
            // FrmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 219);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Profesional";
            this.Load += new System.EventHandler(this.FrmProfesional_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCMP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripButton tsBtnCancelar;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
    }
}