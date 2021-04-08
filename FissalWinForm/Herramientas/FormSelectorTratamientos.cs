using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FissalBL;

namespace FissalWinForm
{
    public partial class FormSelectorTratamientos : Form
    {
        StringBuilder filtro = new StringBuilder();
        PaqueteBL objPaqueteBL = new PaqueteBL();
        DataTable dtPaquetes;
        DataView dvPaquetes;
        int establecimientoId;
        
        public FormSelectorTratamientos()
        {
            InitializeComponent();
        }

        private void CargarConfiguracion()
        {
            this.CenterToParent();
            this.KeyPreview = true;
            toolStrip1.TabStop = true;
            dgvTratamientos.AutoGenerateColumns = false;
            cboEstablecimiento.Enabled = false;
        }

        public FormSelectorTratamientos(int establecimientoId): this()
        {
            this.establecimientoId = establecimientoId;
        }

        private void FormSelectorTratamientos_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimientoConConvenio(cboEstablecimiento);
            cboEstablecimiento.SelectedValue = establecimientoId;
            CargarConfiguracion();
            CargarDgvTratamientos();

        }

        private void CargarDgvTratamientos()
        {
            dtPaquetes = objPaqueteBL.GetVWPaquetePorEstablecimientoId(Convert.ToInt32(cboEstablecimiento.SelectedValue));
            dvPaquetes = dtPaquetes.DefaultView;
            dgvTratamientos.DataSource = dvPaquetes;
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();      // Cerramos el formulario.
            this.Dispose();
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            filtro.Clear();
            dvPaquetes.RowFilter = string.Empty;
            if (!string.Equals(txtCategoria.Text.Trim(), string.Empty))
                filtro.AppendFormat("CategoriaId like '%{0}%' or Descripcion like '%{0}%'", txtCategoria.Text.Trim());
            if (!string.Equals(txtFase.Text.Trim(), string.Empty))
            {
                if(string.Equals(filtro.ToString(), string.Empty))
                    filtro.AppendFormat("Convert(FaseId,'System.String') like '%{0}%' or DescripcionFase like '%{0}%'", txtFase.Text.Trim());
                else
                    filtro.AppendFormat(" and (Convert(FaseId,'System.String') like '%{0}%' or DescripcionFase like '%{0}%')", txtFase.Text.Trim());
            }
            if (!string.Equals(txtEstadio.Text.Trim(), string.Empty))
            {
                if(string.Equals(filtro.ToString(), string.Empty))
                    filtro.AppendFormat("Convert(EstadioId,'System.String') like '%{0}%' or DescripcionEstadio like '%{0}%'", txtEstadio.Text.Trim());
                else
                    filtro.AppendFormat(" and (Convert(EstadioId,'System.String') like '%{0}%' or DescripcionEstadio like '%{0}%')", txtEstadio.Text.Trim());
            }
            dvPaquetes.RowFilter = filtro.ToString();
            if (dvPaquetes.Count > 0)
                dgvTratamientos.Visible = true;
            else
                dgvTratamientos.Visible = false;
        }

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtFase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtEstadio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void Aceptar()
        {
            if (!(dgvTratamientos.RowCount > 0))
                return;
            string tratamientoId = dgvTratamientos.CurrentRow.Cells[0].Value.ToString();
            IFormSelectorTratamientos iFormSelectorTratamientos = this.Owner as IFormSelectorTratamientos;
            if (iFormSelectorTratamientos != null)
            {
                iFormSelectorTratamientos.ObtenerTratamiento(tratamientoId);
                this.DialogResult = DialogResult.OK;
            }
            Salir();
        }

        private void FormSelectorTratamientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Salir();
                    break;
            }
        }

        private void dgvTratamientos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvTratamientos, tsslTotalRegistros);
        }

        private void dgvTratamientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1)
                 return;
            Aceptar();
        }

        private void dgvTratamientos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Aceptar();
                    break;
            }
        }
    }
}
