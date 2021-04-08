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
    public partial class FrmBuscadorAutorizaciones : Form, IFrmSelectorCategorias, IFrmSelectorTiposAutorizacion, IFrmSelectorFases, IFrmSelectorEstadios,IFrmSelectorEstablecimientos
    {
        #region 'VARIABLES Y CONSTANTES'

        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        StringBuilder filtroBusquedaAutorizaciones = new StringBuilder();
        StringBuilder filtroEstablecimientos = new StringBuilder();
        StringBuilder filtroCategorias = new StringBuilder();
        StringBuilder filtroFases = new StringBuilder();
        StringBuilder filtroEstadios = new StringBuilder();
        StringBuilder filtroTiposAutorizacion = new StringBuilder();
        DataTable dtAutorizaciones;
        string numeroDocumento;
        string tipoDocumentoPaciente;
        string nombrePaciente;
        string establecimientos;
        string categorias;
        string fases;
        string estadios;
        string tiposAutorizacion;
        string modalidad;
        string fechaCreacionDesde;
        string fechaCreacionHasta;
        string fechaVigenciaDesde;
        string fechaVigenciaHasta;
        string diagnosticoAsociadoSi;
        string diagnosticoAsociadoNo;
        string anuladoSi;
        string anuladoNo;
        string datosIngresadosBuscador;

        #endregion

        #region 'CONSTRUCTORES'

        public FrmBuscadorAutorizaciones()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        #endregion

        #region 'CONFIGURACION'

        private void InicializarComponentes()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = Convert.ToBoolean(bool.TrueString);
            this.AutoValidate = AutoValidate.Disable;
            toolStrip1.TabStop = Convert.ToBoolean(bool.TrueString);
            txtFechaCreacionDesde.ReadOnly = Convert.ToBoolean(bool.TrueString);
            txtFechaCreacionHasta.ReadOnly = Convert.ToBoolean(bool.TrueString);
            txtFechaVigenciaDesde.ReadOnly = Convert.ToBoolean(bool.TrueString);
            txtFechaVigenciaHasta.ReadOnly = Convert.ToBoolean(bool.TrueString);
            dgvAutorizaciones.AutoGenerateColumns = Convert.ToBoolean(bool.FalseString);
            tsPgsBarBuscador.Visible = Convert.ToBoolean(bool.FalseString);
        }

        #endregion

        #region 'CARGA DE DATOS'

        #endregion

        #region 'LOGICA DEL PROCESO'

        private string FormarFiltroDeBusqueda()
        {
            filtroBusquedaAutorizaciones.Clear();
            filtroEstablecimientos.Clear();
            filtroCategorias.Clear();
            filtroFases.Clear();
            filtroEstadios.Clear();
            filtroTiposAutorizacion.Clear();
            if (numeroDocumento != string.Empty)
                filtroBusquedaAutorizaciones.AppendFormat("NumeroDocumento like '%{0}%'", numeroDocumento);
            if (tipoDocumentoPaciente != string.Empty)
            {
                if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                    filtroBusquedaAutorizaciones.AppendFormat(" and TipoDocumentoId = '{0}'", tipoDocumentoPaciente);
                else
                    filtroBusquedaAutorizaciones.AppendFormat("TipoDocumentoId = '{0}'", tipoDocumentoPaciente);
            }
            if(nombrePaciente != string.Empty)
            {
                if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                    filtroBusquedaAutorizaciones.AppendFormat(" and pacientenombre like '%{0}%'", nombrePaciente);
                else
                    filtroBusquedaAutorizaciones.AppendFormat("pacientenombre like '%{0}%'", nombrePaciente);
            }
            if (establecimientos != string.Empty)
            {   
                string[] result = establecimientos.Split(',');
                foreach (string establecimientoId in result)
                {
                    if (establecimientoId.Trim() != string.Empty)
                    {
                        if (filtroEstablecimientos.ToString() != string.Empty)
                            filtroEstablecimientos.AppendFormat(" or EstablecimientoId = {0}", establecimientoId.Trim());
                        else
                            filtroEstablecimientos.AppendFormat("EstablecimientoId = {0}", establecimientoId.Trim());
                    }
                }
                if (filtroEstablecimientos.ToString() != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and ({0})", filtroEstablecimientos.ToString());
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("({0})", filtroEstablecimientos.ToString());
                }
            }
            if (categorias != string.Empty)
            {
                string[] result = categorias.Split(',');
                foreach (string categoriaId in result)
                {
                    if(categoriaId.Trim() != string.Empty)
                    {
                        if (filtroCategorias.ToString() != string.Empty)
                            filtroCategorias.AppendFormat(" or CategoriaId = '{0}'", categoriaId.Trim());
                        else
                            filtroCategorias.AppendFormat("CategoriaId = '{0}'", categoriaId.Trim());
                    }
                }
                if (filtroCategorias.ToString() != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and ({0})", filtroCategorias.ToString());
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("({0})", filtroCategorias.ToString());
                }
            }
            if (fases != string.Empty)
            {
                string[] result = fases.Split(',');
                foreach (string faseId in result)
                {
                    if(faseId.Trim() != string.Empty)
                    {
                        if (filtroFases.ToString() != string.Empty)
                            filtroFases.AppendFormat(" or FaseId = {0}", faseId.Trim());
                        else
                            filtroFases.AppendFormat("FaseId = {0}", faseId.Trim());
                    }
                }
                if (filtroFases.ToString() != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and ({0})", filtroFases.ToString());
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("({0})", filtroFases.ToString());
                }
            }
            if (estadios != string.Empty)
            {
                string[] result = estadios.Split(',');
                foreach (string estadioId in result)
                {
                    if (estadioId.Trim() != string.Empty)
                    {
                        if (filtroEstadios.ToString() != string.Empty)
                            filtroEstadios.AppendFormat(" or EstadioId = {0}", estadioId.Trim());
                        else
                            filtroEstadios.AppendFormat("EstadioId = {0}", estadioId.Trim());
                    }
                }
                if (filtroEstadios.ToString() != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and ({0})", filtroEstadios.ToString());
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("({0})", filtroEstadios.ToString());
                }
            }
            if (tiposAutorizacion != string.Empty)
            {
                string[] result = tiposAutorizacion.Split(',');
                foreach (string tipoAutorizacionId in result)
                {
                    if(tipoAutorizacionId.Trim() != string.Empty)
                    {
                        if (filtroTiposAutorizacion.ToString() != string.Empty)
                            filtroTiposAutorizacion.AppendFormat(" or TipoAutorizacionId = {0}", tipoAutorizacionId.Trim());
                        else
                            filtroTiposAutorizacion.AppendFormat("TipoAutorizacionId = {0}", tipoAutorizacionId.Trim());
                    }
                }
                if (filtroTiposAutorizacion.ToString() != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and ({0})", filtroTiposAutorizacion.ToString());
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("({0})", filtroTiposAutorizacion.ToString());
                }
            }
            if (modalidad != string.Empty)
            {
                if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                    filtroBusquedaAutorizaciones.AppendFormat(" and Modalidad = '{0}'", modalidad);
                else
                    filtroBusquedaAutorizaciones.AppendFormat("Modalidad = '{0}'", modalidad);
            }

            if (fechaCreacionDesde != string.Empty || fechaCreacionHasta != string.Empty)
            {
                if (fechaCreacionDesde != string.Empty && fechaCreacionHasta != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,FechaCreacion) >= convert(date,'{0}',103) and convert(date,FechaCreacion) <= convert(date,'{1}',103)", fechaCreacionDesde, fechaCreacionHasta);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("convert(date,FechaCreacion) >= convert(date,'{0}',103) and convert(date,FechaCreacion) <= convert(date,'{1}',103)", fechaCreacionDesde, fechaCreacionHasta);
                }
                else if (fechaCreacionDesde != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,FechaCreacion) >= convert(date,'{0}',103)", fechaCreacionDesde);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("convert(date,FechaCreacion) >= convert(date,'{0}',103)", fechaCreacionDesde);
                }
                else
                {
                    if (fechaCreacionHasta != string.Empty)
                    {
                        if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                            filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,FechaCreacion) <= convert(date,'{0}',103)", fechaCreacionHasta);
                        else
                            filtroBusquedaAutorizaciones.AppendFormat("convert(date,FechaCreacion) <= convert(date,'{0}',103)", fechaCreacionHasta);
                    }
                }
            }
            if (fechaVigenciaDesde != string.Empty || fechaVigenciaHasta != string.Empty)
            {
                if (fechaVigenciaDesde != string.Empty && fechaVigenciaHasta != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,Vigencia) >= convert(date,'{0}',103) and convert(date,Vigencia) <= convert(date,'{1}',103)", fechaVigenciaDesde, fechaVigenciaHasta);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("convert(date,Vigencia) >= convert(date,'{0}',103) and convert(date,Vigencia) <= convert(date,'{1}',103)", fechaVigenciaDesde, fechaVigenciaHasta);
                }
                else if (fechaVigenciaDesde != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,Vigencia) >= convert(date,'{0}',103)", fechaVigenciaDesde);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("convert(date,Vigencia) >= convert(date,'{0}',103)", fechaVigenciaDesde);
                }
                else
                {
                    if (fechaVigenciaHasta != string.Empty)
                    {
                        if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                            filtroBusquedaAutorizaciones.AppendFormat(" and convert(date,Vigencia) <= convert(date,'{0}',103)", fechaVigenciaHasta);
                        else
                            filtroBusquedaAutorizaciones.AppendFormat("convert(date,Vigencia) <= convert(date,'{0}',103)", fechaVigenciaHasta);
                    }
                }
            }
            if (diagnosticoAsociadoSi != string.Empty || diagnosticoAsociadoNo != string.Empty)
            {
                if (diagnosticoAsociadoSi != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and DiagnosticoAsociado = {0}", 1);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("DiagnosticoAsociado = {0}", 1);
                }
                else
                {
                    if (diagnosticoAsociadoNo != string.Empty)
                    {
                        if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                            filtroBusquedaAutorizaciones.AppendFormat(" and DiagnosticoAsociado = {0}", 0);
                        else
                            filtroBusquedaAutorizaciones.AppendFormat("DiagnosticoAsociado = {0}", 0);
                    }
                }
            }
            if (anuladoSi != string.Empty || anuladoNo != string.Empty)
            {
                if (anuladoSi != string.Empty)
                {
                    if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                        filtroBusquedaAutorizaciones.AppendFormat(" and Anulado = {0}", 1);
                    else
                        filtroBusquedaAutorizaciones.AppendFormat("Anulado = {0}", 1);
                }
                else
                {
                    if (anuladoNo != string.Empty)
                    {
                        if (filtroBusquedaAutorizaciones.ToString() != string.Empty)
                            filtroBusquedaAutorizaciones.AppendFormat(" and Anulado = {0}", 0);
                        else
                            filtroBusquedaAutorizaciones.AppendFormat("Anulado = {0}", 0);
                    }
                }
            }
            return filtroBusquedaAutorizaciones.ToString();
        }

        #endregion

        #region 'VALIDACIONES'

        private bool IngresaronDatosBuscador()
        {
            numeroDocumento = txtNumeroDocumentoPaciente.Text.Trim();
            tipoDocumentoPaciente = cboTipoDocPaciente.SelectedValue.ToString();
            nombrePaciente = txtNombrePaciente.Text.Trim();
            establecimientos = txtEstablecimiento.Text.Trim();
            categorias = txtCategoria.Text.Trim();
            fases = txtFase.Text.Trim();
            estadios = txtEstadio.Text.Trim();
            tiposAutorizacion = txtTipoAutorizacion.Text.Trim();
            modalidad = cboModalidad.SelectedValue.ToString();
            fechaCreacionDesde = txtFechaCreacionDesde.Text.Trim();
            fechaCreacionHasta = txtFechaCreacionHasta.Text.Trim();
            fechaVigenciaDesde = txtFechaVigenciaDesde.Text.Trim();
            fechaVigenciaHasta = txtFechaVigenciaHasta.Text.Trim();
            if (chkDiagnosticoAsociadoSi.Checked)
                diagnosticoAsociadoSi = chkDiagnosticoAsociadoSi.Checked.ToString();
            else
                diagnosticoAsociadoSi = string.Empty;
            if (chkDiagnosticoAsociadoNo.Checked)
                diagnosticoAsociadoNo = chkDiagnosticoAsociadoNo.Checked.ToString();
            else
                diagnosticoAsociadoNo = string.Empty;
            if (chkAnuladoSi.Checked)
                anuladoSi = chkAnuladoSi.Checked.ToString();
            else
                anuladoSi = string.Empty;
            if (chkAnuladoNo.Checked)
                anuladoNo = chkAnuladoNo.Checked.ToString();
            else
                anuladoNo = string.Empty;
            datosIngresadosBuscador = string.Concat(numeroDocumento, tipoDocumentoPaciente, nombrePaciente, establecimientos, categorias, fases, estadios, tiposAutorizacion, modalidad, fechaCreacionDesde, fechaCreacionHasta, fechaVigenciaDesde, fechaVigenciaHasta, diagnosticoAsociadoSi, diagnosticoAsociadoNo, anuladoSi, anuladoNo);
            bool respuesta = false;
            if (datosIngresadosBuscador != string.Empty)
                respuesta = true;
            return respuesta;
        }

        #endregion

        #region 'METODOS CONTROLES'

        private void Buscar()
        {
            if (IngresaronDatosBuscador())
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    string campos = "*";
                    string tabla = "vw_Autorizacion";
                    string filtro = FormarFiltroDeBusqueda();
                    string order = "FechaCreacion";
                    string consultaSql = string.Format("select {0} from {1} where {2} order by {3}", campos, tabla, filtro, order);
                    if (filtro != string.Empty)
                    {
                        dtAutorizaciones = objAutorizacionBL.GetAllAutorizacionPorConsultaSql(consultaSql);
                        dgvAutorizaciones.DataSource = dtAutorizaciones;
                        if (!(dtAutorizaciones.Rows.Count > 0))
                            MessageBox.Show("No se han encontrado resultados para tu busqueda", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Ingrese datos validos", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Hay datos no válidos en el formulario.", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese al menos un dato de busqueda", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        private void Limpiar()
        {
            dtpFechaCreacionDesde.Value = DateTime.Now;
            dtpFechaCreacionHasta.Value = DateTime.Now;
            dtpFechaVigenciaDesde.Value = DateTime.Now;
            dtpFechaVigenciaHasta.Value = DateTime.Now;
            FuncionesBases.LimpiarTextBox(this);
            FuncionesBases.LimpiarComboBox(this);
            FuncionesBases.LimpiarCheckBox(this);
            errorProvider1.Clear();
            if(dtAutorizaciones != null)
            {
                dtAutorizaciones.Clear();
                dgvAutorizaciones.DataSource = dtAutorizaciones;
            }
            txtEstablecimiento.Focus();
            if (VariablesGlobales.EstablecimientoId != 0)
            {
                txtEstablecimiento.Text = VariablesGlobales.EstablecimientoId.ToString();
                txtEstablecimiento.Enabled = false;
                btnAbrirSelectorEstablecimiento.Enabled = false;
                txtNumeroDocumentoPaciente.Focus();
            }
        }

        #endregion

        #region 'EVENTOS frm'

        private void FrmBuscadorAutorizaciones_Load(object sender, EventArgs e)
        {
            if (VariablesGlobales.EstablecimientoId != 0)
            {
                txtEstablecimiento.Text = VariablesGlobales.EstablecimientoId.ToString();
                txtEstablecimiento.Enabled = false;
                btnAbrirSelectorEstablecimiento.Enabled = false;
            }
            FuncionesBases.CargarCboModalidadAutorizacion(cboModalidad);
            FuncionesBases.CargarComboTipoDoc(cboTipoDocPaciente);
        }

        #endregion

        #region 'EVENTOS btn'

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsBtnExportarExcel_Click(object sender, EventArgs e)
        {
            FuncionesBases.ExportarExcel(dtAutorizaciones, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        private void btnAbrirSelectorCategoria_Click(object sender, EventArgs e)
        {
            FrmSelectorCategorias frmSelectorCategorias = new FrmSelectorCategorias();
            frmSelectorCategorias.Owner = this;
            frmSelectorCategorias.ShowDialog();
        }

        private void btnAbrirSelectorTipoAutorizacion_Click(object sender, EventArgs e)
        {
            FrmSelectorTiposAutorizacion frmSelectorTiposAutorizacion = new FrmSelectorTiposAutorizacion();
            frmSelectorTiposAutorizacion.Owner = this;
            frmSelectorTiposAutorizacion.ShowDialog();
        }

        private void btnAbrirSelectorFase_Click(object sender, EventArgs e)
        {
            FrmSelectorFases frmSelectorFases = new FrmSelectorFases();
            frmSelectorFases.Owner = this;
            frmSelectorFases.ShowDialog();
        }

        private void btnAbrirSelectorEstadio_Click(object sender, EventArgs e)
        {
            FrmSelectorEstadios frmSelectorEstadios = new FrmSelectorEstadios();
            frmSelectorEstadios.Owner = this;
            frmSelectorEstadios.ShowDialog();
        }

        private void btnAbrirSelectorEstablecimiento_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos frmSelectorEstablecimientos = new FrmSelectorEstablecimientos();
            frmSelectorEstablecimientos.Owner = this;
            frmSelectorEstablecimientos.ShowDialog();
        }

        #endregion

        #region 'EVENTOS dtp'

        private void dtpFechaCreacionDesde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacionDesde.Text = dtpFechaCreacionDesde.Value.ToShortDateString();
        }

        private void dtpFechaCreacionHasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacionHasta.Text = dtpFechaCreacionHasta.Value.ToShortDateString();
        }

        private void dtpFechaVigenciaDesde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVigenciaDesde.Text = dtpFechaVigenciaDesde.Value.ToShortDateString();
        }

        private void dtpFechaVigenciaHasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVigenciaHasta.Text = dtpFechaVigenciaHasta.Value.ToShortDateString();
        }

        #endregion

        #region 'EVENTOS txt'

        private void txtFechaCreacionDesde_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaCreacionDesde, txtFechaCreacionHasta, errorProvider1);
        }

        private void txtFechaCreacionDesde_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaCreacionDesde, string.Empty);
        }

        private void txtFechaCreacionHasta_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtFechaCreacionHasta, errorProvider1);
        }

        private void txtFechaCreacionHasta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaCreacionHasta, string.Empty);
        }

        private void txtFechaVigenciaDesde_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaInicio(txtFechaVigenciaDesde, txtFechaVigenciaHasta, errorProvider1);
        }

        private void txtFechaVigenciaDesde_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaVigenciaDesde, string.Empty);
        }

        private void txtFechaVigenciaHasta_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = FuncionesBases.ValidarFechaFin(txtFechaVigenciaHasta, errorProvider1);
        }

        private void txtFechaVigenciaHasta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFechaVigenciaHasta, string.Empty);
        }

        private void txtEstablecimiento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtEstadio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtTipoAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaCreacionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaCreacionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaVigenciaDesde_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtFechaVigenciaHasta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtNombrePaciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtNumeroDocumentoPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        private void txtEstablecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        private void txtFase_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        private void txtEstadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        private void txtTipoAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesBases.PermitirSoloNumerosConComa(e);
        }

        #endregion

        #region 'EVENTOS cbo'

        private void cboModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Buscar();
                    break;
            }
        }

        #endregion

        #region 'EVENTOS chk'

        private void chkDiagnosticoAsociadoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiagnosticoAsociadoSi.Checked)
                chkDiagnosticoAsociadoNo.Checked = false;
        }
        private void chkAnuladoSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnuladoSi.Checked)
                chkAnuladoNo.Checked = false;
        }
        private void chkDiagnosticoAsociadoSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkDiagnosticoAsociadoSi.Checked)
                        chkDiagnosticoAsociadoSi.Checked = false;
                    else
                        chkDiagnosticoAsociadoSi.Checked = true;
                    break;
            }
        }
        private void chkAnuladoSi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkAnuladoSi.Checked)
                        chkAnuladoSi.Checked = false;
                    else
                        chkAnuladoSi.Checked = true;
                    break;
            }
        }
        private void chkDiagnosticoAsociadoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiagnosticoAsociadoNo.Checked)
                chkDiagnosticoAsociadoSi.Checked = false;
        }
        private void chkDiagnosticoAsociadoNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkDiagnosticoAsociadoNo.Checked)
                        chkDiagnosticoAsociadoNo.Checked = false;
                    else
                        chkDiagnosticoAsociadoNo.Checked = true;
                    break;
            }
        }
        private void chkAnuladoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnuladoNo.Checked)
                chkAnuladoSi.Checked = false;
        }
        private void chkAnuladoNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (chkAnuladoNo.Checked)
                        chkAnuladoNo.Checked = false;
                    else
                        chkAnuladoNo.Checked = true;
                    break;
            }
        }

        #endregion

        #region 'EVENTOS dgv'

        private void dgvAutorizaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvAutorizaciones, tsslTotalRegistros);
        }

        #endregion

        #region 'IMPLEMENTACION DE MIEMBROS DE INTERFACES'

        #region 'IFrmSelectorCategorias MEMBERS'

        public void ObtenerCategorias(string texto)
        {
            if (txtCategoria.Text != string.Empty)
            {
                txtCategoria.Text = txtCategoria.Text + string.Format(",{0}", texto);
            }
            else
            {
                txtCategoria.Text = texto;
            }

            txtCategoria.Focus();
        }

        #endregion

        #region 'IFrmSelectorTiposAutorizacion MEMBERS'

        public void ObtenerTiposAutorizacion(string texto)
        {
            if (txtTipoAutorizacion.Text != string.Empty)
            {
                txtTipoAutorizacion.Text = txtTipoAutorizacion.Text + string.Format(",{0}", texto);
            }
            else
            {
                txtTipoAutorizacion.Text = texto;
            }
            txtTipoAutorizacion.Focus();
        }

        #endregion

        #region 'IFrmSelectorFases MEMBERS'

        public void ObtenerFases(string texto)
        {
            if (txtFase.Text != string.Empty)
            {
                txtFase.Text = txtFase.Text + string.Format(",{0}", texto);
            }
            else
            {
                txtFase.Text = texto;
            }
            txtFase.Focus();
        }

        #endregion

        #region 'IFrmSelectorEstadios MEMBERS'

        public void ObtenerEstadios(string texto)
        {
            if (txtEstadio.Text != string.Empty)
            {
                txtEstadio.Text = txtEstadio.Text + string.Format(",{0}", texto);
            }
            else
            {
                txtEstadio.Text = texto;
            }
            txtEstadio.Focus();
        }

        #endregion

        #region 'IFrmSelectorEstablecimientos MEMBERS'

        public void ObtenerEstablecimientos(string texto)
        {
            if (txtEstablecimiento.Text != string.Empty)
            {
                txtEstablecimiento.Text = txtEstablecimiento.Text + string.Format(",{0}", texto);
            }
            else
            {
                txtEstablecimiento.Text = texto;
            }
            txtEstablecimiento.Focus();
        }

        #endregion

        #endregion

    }
}
