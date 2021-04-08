namespace FissalWinForm
{
    partial class frmReporteAutorizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.Reportes = new System.Windows.Forms.GroupBox();
            this.rbtAutorizacionPorCIE = new System.Windows.Forms.RadioButton();
            this.rbtAutorizacionPorPaciente = new System.Windows.Forms.RadioButton();
            this.rbtAutorizacionPorFechaCreacion = new System.Windows.Forms.RadioButton();
            this.grbParametros = new System.Windows.Forms.GroupBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.crvAutorizaciones = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Reportes.SuspendLayout();
            this.grbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Establecimiento :";
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.rbtAutorizacionPorCIE);
            this.Reportes.Controls.Add(this.rbtAutorizacionPorPaciente);
            this.Reportes.Controls.Add(this.rbtAutorizacionPorFechaCreacion);
            this.Reportes.Location = new System.Drawing.Point(12, 12);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(524, 117);
            this.Reportes.TabIndex = 2;
            this.Reportes.TabStop = false;
            this.Reportes.Text = "Reportes";
            // 
            // rbtAutorizacionPorCIE
            // 
            this.rbtAutorizacionPorCIE.AutoSize = true;
            this.rbtAutorizacionPorCIE.Location = new System.Drawing.Point(23, 77);
            this.rbtAutorizacionPorCIE.Name = "rbtAutorizacionPorCIE";
            this.rbtAutorizacionPorCIE.Size = new System.Drawing.Size(132, 17);
            this.rbtAutorizacionPorCIE.TabIndex = 2;
            this.rbtAutorizacionPorCIE.Text = "Autorizaciones por CIE";
            this.rbtAutorizacionPorCIE.UseVisualStyleBackColor = true;
            // 
            // rbtAutorizacionPorPaciente
            // 
            this.rbtAutorizacionPorPaciente.AutoSize = true;
            this.rbtAutorizacionPorPaciente.Location = new System.Drawing.Point(23, 54);
            this.rbtAutorizacionPorPaciente.Name = "rbtAutorizacionPorPaciente";
            this.rbtAutorizacionPorPaciente.Size = new System.Drawing.Size(157, 17);
            this.rbtAutorizacionPorPaciente.TabIndex = 1;
            this.rbtAutorizacionPorPaciente.Text = "Autorizaciones por Paciente";
            this.rbtAutorizacionPorPaciente.UseVisualStyleBackColor = true;
            // 
            // rbtAutorizacionPorFechaCreacion
            // 
            this.rbtAutorizacionPorFechaCreacion.AutoSize = true;
            this.rbtAutorizacionPorFechaCreacion.Checked = true;
            this.rbtAutorizacionPorFechaCreacion.Location = new System.Drawing.Point(23, 31);
            this.rbtAutorizacionPorFechaCreacion.Name = "rbtAutorizacionPorFechaCreacion";
            this.rbtAutorizacionPorFechaCreacion.Size = new System.Drawing.Size(205, 17);
            this.rbtAutorizacionPorFechaCreacion.TabIndex = 0;
            this.rbtAutorizacionPorFechaCreacion.TabStop = true;
            this.rbtAutorizacionPorFechaCreacion.Text = "Autorizaciones por Fecha de Creación";
            this.rbtAutorizacionPorFechaCreacion.UseVisualStyleBackColor = true;
            // 
            // grbParametros
            // 
            this.grbParametros.Controls.Add(this.cboEstablecimiento);
            this.grbParametros.Controls.Add(this.label1);
            this.grbParametros.Location = new System.Drawing.Point(542, 12);
            this.grbParametros.Name = "grbParametros";
            this.grbParametros.Size = new System.Drawing.Size(560, 117);
            this.grbParametros.TabIndex = 3;
            this.grbParametros.TabStop = false;
            this.grbParametros.Text = "Parametros";
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(116, 27);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(413, 21);
            this.cboEstablecimiento.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(1192, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // crvAutorizaciones
            // 
            this.crvAutorizaciones.ActiveViewIndex = -1;
            this.crvAutorizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvAutorizaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crvAutorizaciones.CachedPageNumberPerDoc = 10;
            this.crvAutorizaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAutorizaciones.Location = new System.Drawing.Point(12, 135);
            this.crvAutorizaciones.Name = "crvAutorizaciones";
            this.crvAutorizaciones.Size = new System.Drawing.Size(1259, 379);
            this.crvAutorizaciones.TabIndex = 6;
            // 
            // frmReporteAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 526);
            this.Controls.Add(this.crvAutorizaciones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grbParametros);
            this.Controls.Add(this.Reportes);
            this.Name = "frmReporteAutorizacion";
            this.ShowIcon = false;
            this.Text = "Reporte Autorización";
            this.Load += new System.EventHandler(this.frmReporteAutorizacion_Load);
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.grbParametros.ResumeLayout(false);
            this.grbParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Reportes;
        private System.Windows.Forms.RadioButton rbtAutorizacionPorCIE;
        private System.Windows.Forms.RadioButton rbtAutorizacionPorPaciente;
        private System.Windows.Forms.RadioButton rbtAutorizacionPorFechaCreacion;
        private System.Windows.Forms.GroupBox grbParametros;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        
        private System.Windows.Forms.Button btnBuscar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAutorizaciones;
    }
}