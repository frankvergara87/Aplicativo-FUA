namespace FissalWinForm
{
    partial class FrmProcesoWS
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
            this.dgvAutorizacion = new System.Windows.Forms.DataGridView();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.btnValidarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutorizacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAutorizacion
            // 
            this.dgvAutorizacion.AllowUserToAddRows = false;
            this.dgvAutorizacion.AllowUserToDeleteRows = false;
            this.dgvAutorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizacion.Location = new System.Drawing.Point(22, 226);
            this.dgvAutorizacion.Name = "dgvAutorizacion";
            this.dgvAutorizacion.ReadOnly = true;
            this.dgvAutorizacion.Size = new System.Drawing.Size(882, 108);
            this.dgvAutorizacion.TabIndex = 1;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(22, 64);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.Size = new System.Drawing.Size(882, 101);
            this.dgvPaciente.TabIndex = 2;
            // 
            // btnValidarAuto
            // 
            this.btnValidarAuto.Location = new System.Drawing.Point(759, 19);
            this.btnValidarAuto.Name = "btnValidarAuto";
            this.btnValidarAuto.Size = new System.Drawing.Size(145, 23);
            this.btnValidarAuto.TabIndex = 3;
            this.btnValidarAuto.Text = "Actualizar Pacientes";
            this.btnValidarAuto.UseVisualStyleBackColor = true;
            this.btnValidarAuto.Click += new System.EventHandler(this.btnValidarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // btnAutorizacion
            // 
            this.btnAutorizacion.Enabled = false;
            this.btnAutorizacion.Location = new System.Drawing.Point(759, 185);
            this.btnAutorizacion.Name = "btnAutorizacion";
            this.btnAutorizacion.Size = new System.Drawing.Size(145, 23);
            this.btnAutorizacion.TabIndex = 6;
            this.btnAutorizacion.Text = "Actualizar Autorizaciones";
            this.btnAutorizacion.UseVisualStyleBackColor = true;
            this.btnAutorizacion.Click += new System.EventHandler(this.btnAutorizacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAutorizacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvAutorizacion);
            this.groupBox1.Controls.Add(this.btnValidarAuto);
            this.groupBox1.Controls.Add(this.dgvPaciente);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 363);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obtener Actualizaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nro. de Pacientes Nuevos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nro. de Autorizaciones Nuevas:";
            // 
            // FrmProcesoWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 417);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcesoWS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Pacientes y Autorizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutorizacion;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Button btnValidarAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutorizacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}