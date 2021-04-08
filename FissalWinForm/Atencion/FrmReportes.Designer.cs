namespace FissalWinForm
{
    partial class FrmReportes
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
            this.dgvListadoCierresDig = new System.Windows.Forms.DataGridView();
            this.Codigo_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Fuas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Diagnosticos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Procedimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cantidad_Procedimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cantidad_Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCierresDig)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoCierresDig
            // 
            this.dgvListadoCierresDig.AllowUserToAddRows = false;
            this.dgvListadoCierresDig.AllowUserToDeleteRows = false;
            this.dgvListadoCierresDig.AllowUserToOrderColumns = true;
            this.dgvListadoCierresDig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCierresDig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Cierre,
            this.Ipress,
            this.Total_Fuas,
            this.Total_Diagnosticos,
            this.Total_Procedimientos,
            this.Total_Medicamentos,
            this.Total_Cantidad_Procedimientos,
            this.Total_Cantidad_Medicamentos});
            this.dgvListadoCierresDig.Location = new System.Drawing.Point(28, 58);
            this.dgvListadoCierresDig.Name = "dgvListadoCierresDig";
            this.dgvListadoCierresDig.ReadOnly = true;
            this.dgvListadoCierresDig.Size = new System.Drawing.Size(736, 236);
            this.dgvListadoCierresDig.TabIndex = 0;
            // 
            // Codigo_Cierre
            // 
            this.Codigo_Cierre.DataPropertyName = "Código Cierre";
            this.Codigo_Cierre.HeaderText = "Código Cierre";
            this.Codigo_Cierre.Name = "Codigo_Cierre";
            this.Codigo_Cierre.ReadOnly = true;
            this.Codigo_Cierre.Width = 70;
            // 
            // Ipress
            // 
            this.Ipress.DataPropertyName = "Ipress";
            this.Ipress.HeaderText = "Ipress";
            this.Ipress.Name = "Ipress";
            this.Ipress.ReadOnly = true;
            this.Ipress.Width = 200;
            // 
            // Total_Fuas
            // 
            this.Total_Fuas.DataPropertyName = "Total Fuas";
            this.Total_Fuas.HeaderText = "Total Fuas";
            this.Total_Fuas.Name = "Total_Fuas";
            this.Total_Fuas.ReadOnly = true;
            this.Total_Fuas.Width = 70;
            // 
            // Total_Diagnosticos
            // 
            this.Total_Diagnosticos.DataPropertyName = "Total Diagnósticos";
            this.Total_Diagnosticos.HeaderText = "Total Diagnósticos";
            this.Total_Diagnosticos.Name = "Total_Diagnosticos";
            this.Total_Diagnosticos.ReadOnly = true;
            this.Total_Diagnosticos.Width = 70;
            // 
            // Total_Procedimientos
            // 
            this.Total_Procedimientos.DataPropertyName = "Total Procedimientos";
            this.Total_Procedimientos.HeaderText = "Total Procedimientos";
            this.Total_Procedimientos.Name = "Total_Procedimientos";
            this.Total_Procedimientos.ReadOnly = true;
            this.Total_Procedimientos.Width = 70;
            // 
            // Total_Medicamentos
            // 
            this.Total_Medicamentos.DataPropertyName = "Total Medicamentos";
            this.Total_Medicamentos.HeaderText = "Total Medicamentos";
            this.Total_Medicamentos.Name = "Total_Medicamentos";
            this.Total_Medicamentos.ReadOnly = true;
            this.Total_Medicamentos.Width = 70;
            // 
            // Total_Cantidad_Procedimientos
            // 
            this.Total_Cantidad_Procedimientos.DataPropertyName = "Total Cantidad Procedimientos";
            this.Total_Cantidad_Procedimientos.HeaderText = "Total Cantidad Procedimientos";
            this.Total_Cantidad_Procedimientos.Name = "Total_Cantidad_Procedimientos";
            this.Total_Cantidad_Procedimientos.ReadOnly = true;
            this.Total_Cantidad_Procedimientos.Width = 70;
            // 
            // Total_Cantidad_Medicamentos
            // 
            this.Total_Cantidad_Medicamentos.DataPropertyName = "Total Cantidad Medicamentos";
            this.Total_Cantidad_Medicamentos.HeaderText = "Total Cantidad Medicamentos";
            this.Total_Cantidad_Medicamentos.Name = "Total_Cantidad_Medicamentos";
            this.Total_Cantidad_Medicamentos.ReadOnly = true;
            this.Total_Cantidad_Medicamentos.Width = 70;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(689, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(352, 30);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(318, 21);
            this.cboEstablecimiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Establecimiento";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEstablecimiento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoCierresDig);
            this.Name = "FrmReportes";
            this.Text = "Resumen Cierres de Digitación";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCierresDig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoCierresDig;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Fuas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Diagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Procedimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cantidad_Procedimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cantidad_Medicamentos;
    }
}