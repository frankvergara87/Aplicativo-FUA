namespace FissalWinForm
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPpal = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUsuarioLogueado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUsuarioLogueado
            // 
            this.tssUsuarioLogueado.AutoSize = false;
            this.tssUsuarioLogueado.BackColor = System.Drawing.SystemColors.Control;
            this.tssUsuarioLogueado.Name = "tssUsuarioLogueado";
            this.tssUsuarioLogueado.Size = new System.Drawing.Size(700, 17);
            this.tssUsuarioLogueado.Text = "Usuario Logueado :";
            this.tssUsuarioLogueado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPpal
            // 
            this.MenuPpal.BackColor = System.Drawing.Color.White;
            this.MenuPpal.Location = new System.Drawing.Point(0, 0);
            this.MenuPpal.Name = "MenuPpal";
            this.MenuPpal.Size = new System.Drawing.Size(1013, 24);
            this.MenuPpal.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1013, 495);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuPpal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPpal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fissal - Fondo Intangible Solidario de Salud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuarioLogueado;
        private System.Windows.Forms.MenuStrip MenuPpal;
    }
}