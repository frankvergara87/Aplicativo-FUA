namespace FissalWinForm
{
    partial class FrmRegistrarObservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarObservacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnObservar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnQuitarObservacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.grpObservacion = new System.Windows.Forms.GroupBox();
            this.lblCantidadObservada = new System.Windows.Forms.Label();
            this.lblDescripcionObservacion = new System.Windows.Forms.Label();
            this.lblTipoObservacion = new System.Windows.Forms.Label();
            this.txtCantidadObservada = new System.Windows.Forms.TextBox();
            this.txtDescripcionObservacion = new System.Windows.Forms.TextBox();
            this.cboTipoObservacion = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadDetalle = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.grpObservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnObservar,
            this.toolStripSeparator1,
            this.tsBtnQuitarObservacion,
            this.toolStripSeparator2,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnObservar
            // 
            this.tsBtnObservar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnObservar.Image")));
            this.tsBtnObservar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnObservar.Name = "tsBtnObservar";
            this.tsBtnObservar.Size = new System.Drawing.Size(74, 22);
            this.tsBtnObservar.Text = "Observar";
            this.tsBtnObservar.Click += new System.EventHandler(this.tsBtnAceptar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnQuitarObservacion
            // 
            this.tsBtnQuitarObservacion.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnQuitarObservacion.Image")));
            this.tsBtnQuitarObservacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnQuitarObservacion.Name = "tsBtnQuitarObservacion";
            this.tsBtnQuitarObservacion.Size = new System.Drawing.Size(129, 22);
            this.tsBtnQuitarObservacion.Text = "Quitar Observacion";
            this.tsBtnQuitarObservacion.Click += new System.EventHandler(this.tsBtnQuitarObservacion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSalir.Image")));
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(73, 22);
            this.tsBtnSalir.Text = "Cancelar";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // grpObservacion
            // 
            this.grpObservacion.Controls.Add(this.lblCantidadObservada);
            this.grpObservacion.Controls.Add(this.lblDescripcionObservacion);
            this.grpObservacion.Controls.Add(this.lblTipoObservacion);
            this.grpObservacion.Controls.Add(this.txtCantidadObservada);
            this.grpObservacion.Controls.Add(this.txtDescripcionObservacion);
            this.grpObservacion.Controls.Add(this.cboTipoObservacion);
            this.grpObservacion.Location = new System.Drawing.Point(12, 97);
            this.grpObservacion.Name = "grpObservacion";
            this.grpObservacion.Size = new System.Drawing.Size(440, 119);
            this.grpObservacion.TabIndex = 0;
            this.grpObservacion.TabStop = false;
            this.grpObservacion.Text = "Observacion";
            // 
            // lblCantidadObservada
            // 
            this.lblCantidadObservada.AutoSize = true;
            this.lblCantidadObservada.Location = new System.Drawing.Point(17, 46);
            this.lblCantidadObservada.Name = "lblCantidadObservada";
            this.lblCantidadObservada.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadObservada.TabIndex = 13;
            this.lblCantidadObservada.Text = "Cantidad";
            // 
            // lblDescripcionObservacion
            // 
            this.lblDescripcionObservacion.AutoSize = true;
            this.lblDescripcionObservacion.Location = new System.Drawing.Point(17, 71);
            this.lblDescripcionObservacion.Name = "lblDescripcionObservacion";
            this.lblDescripcionObservacion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionObservacion.TabIndex = 12;
            this.lblDescripcionObservacion.Text = "Descripcion";
            // 
            // lblTipoObservacion
            // 
            this.lblTipoObservacion.AutoSize = true;
            this.lblTipoObservacion.Location = new System.Drawing.Point(17, 21);
            this.lblTipoObservacion.Name = "lblTipoObservacion";
            this.lblTipoObservacion.Size = new System.Drawing.Size(28, 13);
            this.lblTipoObservacion.TabIndex = 11;
            this.lblTipoObservacion.Text = "Tipo";
            // 
            // txtCantidadObservada
            // 
            this.txtCantidadObservada.Location = new System.Drawing.Point(86, 43);
            this.txtCantidadObservada.Name = "txtCantidadObservada";
            this.txtCantidadObservada.Size = new System.Drawing.Size(90, 20);
            this.txtCantidadObservada.TabIndex = 1;
            this.txtCantidadObservada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadObservada_KeyDown);
            this.txtCantidadObservada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadObservada_KeyPress);
            this.txtCantidadObservada.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidadObservada_Validating);
            this.txtCantidadObservada.Validated += new System.EventHandler(this.txtCantidadObservada_Validated);
            // 
            // txtDescripcionObservacion
            // 
            this.txtDescripcionObservacion.Location = new System.Drawing.Point(86, 68);
            this.txtDescripcionObservacion.Multiline = true;
            this.txtDescripcionObservacion.Name = "txtDescripcionObservacion";
            this.txtDescripcionObservacion.Size = new System.Drawing.Size(346, 40);
            this.txtDescripcionObservacion.TabIndex = 2;
            this.txtDescripcionObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionObservacion_KeyDown);
            this.txtDescripcionObservacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcionObservacion_Validating);
            this.txtDescripcionObservacion.Validated += new System.EventHandler(this.txtDescripcionObservacion_Validated);
            // 
            // cboTipoObservacion
            // 
            this.cboTipoObservacion.FormattingEnabled = true;
            this.cboTipoObservacion.Location = new System.Drawing.Point(86, 18);
            this.cboTipoObservacion.Name = "cboTipoObservacion";
            this.cboTipoObservacion.Size = new System.Drawing.Size(240, 21);
            this.cboTipoObservacion.TabIndex = 0;
            this.cboTipoObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipoObservacion_KeyDown);
            this.cboTipoObservacion.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoObservacion_Validating);
            this.cboTipoObservacion.Validated += new System.EventHandler(this.cboTipoObservacion_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcionDetalle);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantidadDetalle);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 16);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(86, 13);
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(346, 20);
            this.txtDescripcionDetalle.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidadDetalle
            // 
            this.txtCantidadDetalle.Location = new System.Drawing.Point(86, 38);
            this.txtCantidadDetalle.Name = "txtCantidadDetalle";
            this.txtCantidadDetalle.Size = new System.Drawing.Size(90, 20);
            this.txtCantidadDetalle.TabIndex = 14;
            // 
            // FrmRegistrarObservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 222);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpObservacion);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarObservacion";
            this.Text = "Control Medico - Registrar Observacion";
            this.Load += new System.EventHandler(this.FrmRegistrarObservaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegistrarObservacion_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpObservacion.ResumeLayout(false);
            this.grpObservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnObservar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.GroupBox grpObservacion;
        private System.Windows.Forms.Label lblCantidadObservada;
        private System.Windows.Forms.Label lblDescripcionObservacion;
        private System.Windows.Forms.Label lblTipoObservacion;
        private System.Windows.Forms.TextBox txtCantidadObservada;
        private System.Windows.Forms.TextBox txtDescripcionObservacion;
        private System.Windows.Forms.ComboBox cboTipoObservacion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnQuitarObservacion;
    }
}