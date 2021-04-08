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
    public partial class FrmBuscadorAtencionesSis : Form, IFrmSelectorCategorias, IFrmSelectorProcedimientos, IFrmSelectorMedicamentos, IFrmSelectorEstablecimientos
    {

        #region 'VARIABLES Y CONSTANTES'

        AutorizacionBL objAutorizacionBL = new AutorizacionBL();
        StringBuilder filtroBusquedaAtenciones = new StringBuilder();
        StringBuilder filtroEstablecimientos = new StringBuilder();
        StringBuilder filtroRegiones = new StringBuilder();
        StringBuilder filtroDetallesAtenciones = new StringBuilder();
        StringBuilder filtroCategorias = new StringBuilder();
        StringBuilder filtroProcedimientos = new StringBuilder();
        StringBuilder filtroMedicamentos = new StringBuilder();
        DataTable dtAtencionesSis;
        string numeroDocPaciente;
        string establecimientos;
        string regiones;
        string categorias;
        string procedimientos;
        string medicamentos;
        string observado;
        string sexoPaciente;
        string edadPacienteDesde;
        string edadPacienteHasta;
        string periodoTransferenciaDesde;
        string periodoTransferenciaHasta;
        string periodoProduccionDesde;
        string periodoProduccionHasta;
        string mesProduccionDesde;
        string mesProduccionHasta;
        string fechaAtencionDesde;
        string fechaAtencionHasta;
        string datosIngresadosBuscador;

        public struct Observado { public string clave { get; set; } public string valor { get; set; } }

        #endregion

        #region 'CONSTRUCTORES'

        public FrmBuscadorAtencionesSis()
        {
            InitializeComponent();
            tsPgsBarBuscador.Visible = Convert.ToBoolean(bool.FalseString);
            this.WindowState = FormWindowState.Maximized;//maximizar formulario
        }
        
        #endregion

        #region 'CARGA DE DATOS'

        private void CargarCboObservado()
        {
            List<Observado> lista = new List<Observado>(3);
            Observado opcion0 = new Observado();
            opcion0.clave = string.Empty;
            opcion0.valor = "-SELECCIONE-";
            Observado opcion1 = new Observado();
            opcion1.clave = "SiObs";
            opcion1.valor = "SI";
            Observado opcion2 = new Observado();
            opcion2.clave = "NoObs";
            opcion2.valor = "NO";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            cboObservado.DataSource = lista;
            cboObservado.ValueMember = "clave";
            cboObservado.DisplayMember = "valor";
        }

        #endregion

        #region 'LOGICA DEL PROCESO'

        private void Buscar()
        {
            if (IngresaronDatosBuscador())
            {
                string campos = string.Format("*");
                string tabla = "AtencionCierre";
                string filtro = FormarFiltroDeBusqueda();
                string order = "ate_fecatencion";
                string consultaSql = string.Format("select {0} from {1} where {2} order by {3}", campos, tabla, filtro, order);
                if (filtro != string.Empty)
                {
                    dtAtencionesSis = objAutorizacionBL.GetAllAutorizacionPorConsultaSql(consultaSql);
                    dgvAtencionesSis.DataSource = dtAtencionesSis;
                    if ((dtAtencionesSis.Rows.Count > 0))
                        MessageBox.Show("No se han encontrado resultados para tu busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Ingrese datos validos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese al menos un dato de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool IngresaronDatosBuscador()
        {
            numeroDocPaciente = txtNumeroDocumentoPaciente.Text.Trim();
            establecimientos = txtEstablecimientos.Text.Trim();
            regiones = txtRegiones.Text.Trim();
            categorias = txtDiagnosticos.Text.Trim();
            procedimientos = txtProcedimientos.Text.Trim();
            medicamentos = txtMedicamentos.Text.Trim();
            observado = cboObservado.SelectedValue.ToString();
            sexoPaciente = cboSexoPaciente.SelectedValue.ToString();
            edadPacienteDesde = txtEdadPacienteDesde.Text.Trim();
            edadPacienteHasta = txtEdadPacienteHasta.Text.Trim();
            periodoTransferenciaDesde = txtTransferenciaDesde.Text.Trim();
            periodoTransferenciaHasta = txtTransferenciaHasta.Text.Trim();
            periodoProduccionDesde = txtPeriodoProduccionDesde.Text.Trim();
            periodoProduccionHasta = txtPeriodoProduccionHasta.Text.Trim();
            mesProduccionDesde = txtMesProduccionDesde.Text.Trim();
            mesProduccionHasta = txtMesProduccionHasta.Text.Trim();
            fechaAtencionDesde = txtFechaAtencionDesde.Text.Trim();
            fechaAtencionHasta = txtFechaAtencionHasta.Text.Trim();
            datosIngresadosBuscador = string.Concat(numeroDocPaciente,establecimientos,regiones,categorias,procedimientos,medicamentos,observado,sexoPaciente,edadPacienteDesde,edadPacienteHasta,periodoTransferenciaDesde,periodoTransferenciaHasta,periodoProduccionDesde,periodoProduccionHasta,mesProduccionDesde,mesProduccionHasta,fechaAtencionDesde,fechaAtencionHasta);
            bool respuesta = Convert.ToBoolean(bool.FalseString);
            if (datosIngresadosBuscador != string.Empty)
                respuesta = Convert.ToBoolean(bool.TrueString);
            return respuesta;
        }

        private string FormarFiltroDeBusqueda()
        {
            filtroBusquedaAtenciones.Clear();
            filtroEstablecimientos.Clear();
            filtroRegiones.Clear();
            filtroDetallesAtenciones.Clear();
            filtroCategorias.Clear();
            filtroProcedimientos.Clear();
            filtroMedicamentos.Clear();
            if(categorias != string.Empty || procedimientos != string.Empty || medicamentos != string.Empty)
            {
                if (categorias != string.Empty)
                {
                    string[] result = categorias.Split(',');
                    foreach (string categoriaId in result)
                    {
                        if (filtroCategorias.ToString() != string.Empty)
                            filtroCategorias.AppendFormat(" or Codigo like '{0}%'", categoriaId.Trim());
                        else
                            filtroCategorias.AppendFormat("SELECT IdNumRegAte FROM AtencionCierre_Diagnosticos where Codigo like '{0}%'", categoriaId.Trim());
                    }
                    filtroCategorias.AppendFormat(" group by IdNumRegAte");
                    filtroDetallesAtenciones.AppendFormat("{0}", filtroCategorias.ToString());
                }
                if (procedimientos != string.Empty)
                {
                    string[] result = procedimientos.Split(',');
                    foreach (string procedimientoId in result)
                    {
                        if (filtroProcedimientos.ToString() != string.Empty)
                            filtroProcedimientos.AppendFormat(" or Codigo like '{0}%'", procedimientoId);
                        else
                            filtroProcedimientos.AppendFormat("SELECT IdNumRegAte FROM AtencionCierre_Consumos where TipoConsumo = 'p' and (Codigo like '{0}%'", procedimientoId);
                    }
                    filtroProcedimientos.AppendFormat(") group by IdNumRegAte");
                    if (filtroDetallesAtenciones.ToString() != string.Empty)
                        filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroProcedimientos.ToString());
                    else
                        filtroDetallesAtenciones.AppendFormat("{0}", filtroProcedimientos.ToString());
                }
                if (medicamentos != string.Empty)
                {
                    string[] result = medicamentos.Split(',');
                    foreach (string medicamentoId in result)
                    {
                        if (filtroMedicamentos.ToString() != string.Empty)
                            filtroMedicamentos.AppendFormat(" or Codigo like '{0}%'", medicamentoId);
                        else
                            filtroMedicamentos.AppendFormat("SELECT IdNumRegAte  FROM AtencionCierre_Consumos where TipoConsumo in ('i','m') and (Codigo like '{0}%'", medicamentoId);
                    }
                    filtroMedicamentos.AppendFormat(") group by IdNumRegAte");
                    if (filtroDetallesAtenciones.ToString() != string.Empty)
                        filtroDetallesAtenciones.AppendFormat(" intersect {0}", filtroMedicamentos.ToString());
                    else
                        filtroDetallesAtenciones.AppendFormat("{0}", filtroMedicamentos.ToString());
                }
                filtroBusquedaAtenciones.AppendFormat("ate_idnumreg in ({0})", filtroDetallesAtenciones.ToString());
            }
            if (numeroDocPaciente != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and ate_dni like '%{0}%'", numeroDocPaciente);
                else
                    filtroBusquedaAtenciones.AppendFormat("ate_dni like '%{0}%'", numeroDocPaciente);
            }
            if (establecimientos != string.Empty)
            {
                string[] result = establecimientos.Split(',');
                foreach (string establecimientoId in result)
                {
                    if (filtroEstablecimientos.ToString() != string.Empty)
                        filtroEstablecimientos.AppendFormat(" or CodigoEESS = '{0}'", establecimientoId.Trim());
                    else
                        filtroEstablecimientos.AppendFormat("CodigoEESS = '{0}'", establecimientoId.Trim());
                }
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and ({0})", filtroEstablecimientos.ToString());
                else
                    filtroBusquedaAtenciones.AppendFormat("({0})", filtroEstablecimientos.ToString());
            }
            if (regiones != string.Empty)
            {
                string[] result = regiones.Split(',');
                foreach (string region in result)
                {
                    if (filtroRegiones.ToString() != string.Empty)
                        filtroRegiones.AppendFormat(" or region = '{0}'", region.Trim());
                    else
                        filtroRegiones.AppendFormat("region = '{0}'", region.Trim());
                }
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and ({0})", filtroRegiones.ToString());
                else
                    filtroBusquedaAtenciones.AppendFormat("({0})", filtroRegiones.ToString());
            }
            if (observado != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and Observado = '{0}'", observado);
                else
                    filtroBusquedaAtenciones.AppendFormat("Observado = '{0}'", observado);
            }

            if (sexoPaciente != string.Empty)
            {
                if (filtroBusquedaAtenciones.ToString() != string.Empty)
                    filtroBusquedaAtenciones.AppendFormat(" and ate_idsexo = '{0}'", sexoPaciente);
                else
                    filtroBusquedaAtenciones.AppendFormat("ate_idsexo = '{0}'", sexoPaciente);
            }
            if (edadPacienteDesde != string.Empty || edadPacienteHasta != string.Empty)
            {
                if (edadPacienteDesde != string.Empty && edadPacienteHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_edad >= {0} and ate_edad <= {1}", edadPacienteDesde, edadPacienteHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_edad >= {0} and ate_edad <= {1}", edadPacienteDesde, edadPacienteHasta);
                }
                else if (edadPacienteDesde != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_edad >= {0}", edadPacienteDesde);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_edad >= {0}", edadPacienteDesde);
                }
                else if (edadPacienteHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_edad <= {0}", edadPacienteHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_edad <= {0}", edadPacienteHasta);
                }
            }

            if (periodoTransferenciaDesde != string.Empty || periodoTransferenciaHasta != string.Empty)
            {
                if (periodoTransferenciaDesde != string.Empty && periodoTransferenciaHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and PeriodoTransferencia >= {0} and PeriodoTransferencia <= {1}", periodoTransferenciaDesde, periodoTransferenciaHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("PeriodoTransferencia >= {0} and PeriodoTransferencia <= {1}", periodoTransferenciaDesde, periodoTransferenciaHasta);
                }
                else if (periodoTransferenciaDesde != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and PeriodoTransferencia >= {0}", periodoTransferenciaDesde);
                    else
                        filtroBusquedaAtenciones.AppendFormat("PeriodoTransferencia >= {0}", periodoTransferenciaDesde);
                }
                else if (periodoTransferenciaHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and PeriodoTransferencia <= {0}", periodoTransferenciaHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("PeriodoTransferencia <= {0}", periodoTransferenciaHasta);
                }
            }
            
            if (periodoProduccionDesde != string.Empty || periodoProduccionHasta != string.Empty)
            {
                if (periodoProduccionDesde != string.Empty && periodoProduccionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Periodo >= {0} and Periodo <= {1}", periodoProduccionDesde, periodoProduccionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Periodo >= {0} and Periodo <= {1}", periodoProduccionDesde, periodoProduccionHasta);
                }
                else if (periodoProduccionDesde != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Periodo >= {0}", periodoProduccionDesde);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Periodo >= {0}", periodoProduccionDesde);
                }
                else if (periodoProduccionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Periodo <= {0}", periodoProduccionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Periodo <= {0}", periodoProduccionHasta);
                }
            }

            if (mesProduccionDesde != string.Empty || mesProduccionHasta != string.Empty)
            {
                if (mesProduccionDesde != string.Empty && mesProduccionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Mes >= {0} and Mes <= {1}", mesProduccionDesde, mesProduccionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Mes >= {0} and Mes <= {1}", mesProduccionDesde, mesProduccionHasta);
                }
                else if (mesProduccionDesde != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Mes >= {0}", mesProduccionDesde);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Mes >= {0}", mesProduccionDesde);
                }
                else if (mesProduccionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and Mes <= {0}", mesProduccionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("Mes <= {0}", mesProduccionHasta);
                }
            }

            if (fechaAtencionDesde != string.Empty || fechaAtencionHasta != string.Empty)
            {
                if (fechaAtencionDesde != string.Empty && fechaAtencionHasta != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_fecatencion >= convert(smalldatetime,'{0}',103) and ate_fecatencion <= convert(smalldatetime,'{1}',103)", fechaAtencionDesde, fechaAtencionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_fecatencion >= convert(smalldatetime,'{0}',103) and ate_fecatencion <= convert(smalldatetime,'{1}',103)", fechaAtencionDesde, fechaAtencionHasta);
                }
                else if (fechaAtencionDesde.ToString() != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_fecatencion >= convert(smalldatetime,'{0}',103)", fechaAtencionDesde);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_fecatencion >= convert(smalldatetime,'{0}',103)", fechaAtencionDesde);
                }
                else if (fechaAtencionHasta.ToString() != string.Empty)
                {
                    if (filtroBusquedaAtenciones.ToString() != string.Empty)
                        filtroBusquedaAtenciones.AppendFormat(" and ate_fecatencion <= convert(smalldatetime,'{0}',103)", fechaAtencionHasta);
                    else
                        filtroBusquedaAtenciones.AppendFormat("ate_fecatencion <= convert(smalldatetime,'{0}',103)", fechaAtencionHasta);
                }
            }
            return filtroBusquedaAtenciones.ToString();
        }

        #endregion

        private void Limpiar()
        {
            dtpFechaAtencionDesde.Value = DateTime.Now;
            dtpFechaAtencionHasta.Value = DateTime.Now;
            dtpTransferenciaDesde.Value = DateTime.Now;
            dtpTransferenciaHasta.Value = DateTime.Now;
            FuncionesBases.LimpiarTextBox(this);
            FuncionesBases.LimpiarComboBox(this);
            if (dtAtencionesSis != null)
            {
                dtAtencionesSis.Clear();
                dgvAtencionesSis.DataSource = dtAtencionesSis;
            }
        }

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
            FuncionesBases.ExportarExcel(dgvAtencionesSis, tsPgsBarBuscador, tsslMensajePgsBarBuscador);
        }

        private void dtpFechaAtencionDesde_ValueChanged(object sender, EventArgs e)
        {
            txtFechaAtencionDesde.Text = dtpFechaAtencionDesde.Value.ToShortDateString();
        }

        private void dtpFechaAtencionHasta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaAtencionHasta.Text = dtpFechaAtencionHasta.Value.ToShortDateString();
        }

        private void dgvAtencionesSis_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvAtencionesSis, tsslTotalRegistros);
        }

        private void txtRegiones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void FrmBuscadorAtencionesSis_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboSexo(cboSexoPaciente);
            CargarCboObservado();
        }

        private void txtEstablecimientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void cboObservado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtFechaAtencionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtFechaAtencionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtTransferenciaDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtTransferenciaHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtNumeroDocumentoPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void cboSexoPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtEdadPacienteDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtEdadPacienteHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtPeriodoProduccionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtPeriodoProduccionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtMesProduccionDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtMesProduccionHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtDiagnosticos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtProcedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void dtpTransferenciaDesde_ValueChanged(object sender, EventArgs e)
        {
            txtTransferenciaDesde.Text = dtpTransferenciaDesde.Value.ToString("yyyyMM");
        }

        private void dtpTransferenciaHasta_ValueChanged(object sender, EventArgs e)
        {
            txtTransferenciaHasta.Text = dtpTransferenciaHasta.Value.ToString("yyyyMM");
        }

        private void btnAbrirSelectorCategorias_Click(object sender, EventArgs e)
        {
            FrmSelectorCategorias objFrmSelectorCategorias = new FrmSelectorCategorias();
            objFrmSelectorCategorias.Owner = this;
            objFrmSelectorCategorias.ShowDialog();
        }

        private void btnAbrirSelectorProcedimientos_Click(object sender, EventArgs e)
        {
            FrmSelectorProcedimientos objFrmSelectorProcedimientos = new FrmSelectorProcedimientos();
            objFrmSelectorProcedimientos.Owner = this;
            objFrmSelectorProcedimientos.ShowDialog();
        }

        private void btnAbrirSelectorMedicamentos_Click(object sender, EventArgs e)
        {
            FrmSelectorMedicamentos objFrmSelectorMedicamentos = new FrmSelectorMedicamentos();
            objFrmSelectorMedicamentos.Owner = this;
            objFrmSelectorMedicamentos.ShowDialog();
        }

        private void btnAbrirSelectorEstablecimiento_Click(object sender, EventArgs e)
        {
            FrmSelectorEstablecimientos objFrmSelectorEstablecimientos = new FrmSelectorEstablecimientos(Convert.ToBoolean(bool.FalseString), Convert.ToBoolean(bool.TrueString), Convert.ToBoolean(bool.TrueString));
            objFrmSelectorEstablecimientos.Owner = this;
            objFrmSelectorEstablecimientos.ShowDialog();
        }

        #region 'IMPLEMENTACION DE MIEMBROS DE INTERFACES'

        #region 'IFrmSelectorCategorias MEMBERS'

        public void ObtenerCategorias(string texto)
        {
            if (txtDiagnosticos.Text != string.Empty)
            {
                txtDiagnosticos.Text = txtDiagnosticos.Text + string.Format(", {0}", texto);
            }
            else
            {
                txtDiagnosticos.Text = texto;
            }
            txtDiagnosticos.Focus();
        }

        #endregion

        #region 'IFrmSelectorProcedimientos MEMBERS'

        public void ObtenerProcedimientos(string texto)
        {
            if (txtProcedimientos.Text != string.Empty)
            {
                txtProcedimientos.Text = txtProcedimientos.Text + string.Format(", {0}", texto);
            }
            else
            {
                txtProcedimientos.Text = texto;
            }
            txtProcedimientos.Focus();
        }

        #endregion

        #region 'IFrmSelectorMedicamentos MEMBERS'

        public void ObtenerMedicamentos(string texto)
        {
            if (txtMedicamentos.Text != string.Empty)
            {
                txtMedicamentos.Text = txtMedicamentos.Text + string.Format(", {0}", texto);
            }
            else
            {
                txtMedicamentos.Text = texto;
            }
            txtMedicamentos.Focus();
        }

        #endregion

        #region 'IFrmSelectorEstablecimientos MEMBERS'

        public void ObtenerEstablecimientos(string texto)
        {
            if (txtEstablecimientos.Text != string.Empty)
            {
                txtEstablecimientos.Text = txtEstablecimientos.Text + string.Format(", {0}", texto);
            }
            else
            {
                txtEstablecimientos.Text = texto;
            }
            txtEstablecimientos.Focus();
        }

        #endregion

        #endregion

    }
}
