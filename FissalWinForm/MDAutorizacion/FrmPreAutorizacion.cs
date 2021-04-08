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
    public partial class FrmPreAutorizacion : Form
    {
        private int autorizacionId;
        private string numeroSolicitud;
        private int detalleId;
        private string pacienteActivoSis;
        private string pacienteRegimenSis;
        private string pacienteVivo;
        private string pacienteId;
        private string categoriaId;
        AutorizacionBL objAutorizacionBL = new AutorizacionBL();

        
        public struct Observado { public string clave { get; set; } public string valor { get; set; } }

        public FrmPreAutorizacion()
        {
            InitializeComponent();
            //dgvDetallesSolicitudes.AutoGenerateColumns = false;
            this.CenterToParent();
        }

        public    FrmPreAutorizacion(int autorizacionId,string numeroSolicitud,int detalleId,string pacienteActivoSis,string pacienteRegimenSis,string pacienteVivo,string pacienteId, string categoriaId):this()
        {
            // TODO: Complete member initialization
            this.autorizacionId = autorizacionId;
            this.numeroSolicitud = numeroSolicitud;
            this.detalleId = detalleId;
            this.pacienteActivoSis = pacienteActivoSis;
            this.pacienteRegimenSis = pacienteRegimenSis;
            this.pacienteVivo = pacienteVivo;
            this.pacienteId = pacienteId;
            this.categoriaId = categoriaId;
        }

        private void FrmPreAutorizacion_Load(object sender, EventArgs e)
        {
            CargarCboPacienteActivoSis();
            CargarCboPacienteRegimenSis();
            CargarCboPacienteVivo();
            CargarCboModalidad();
            CargarInformacionPreAutorizacion();
        }

        private void CargarInformacionPreAutorizacion()
        {
            dgvPreAutorizacion.DataSource = objAutorizacionBL.GetVwAutorizacionPorId(autorizacionId);
            
            #region 'Cargando Cbo PacienteActivoSis'

            if (!string.Equals(pacienteActivoSis, "3"))
            {
                cboPacienteActivoSis.SelectedValue = pacienteActivoSis;
                cboPacienteActivoSis.Enabled = false;
            }

            #endregion

            #region 'Cargando Cbo PacienteRegimenSis'

            if (!string.Equals(pacienteRegimenSis, "3"))
            {
                cboPacienteRegimenSis.SelectedValue = pacienteRegimenSis;
                cboPacienteRegimenSis.Enabled = false;
            }

            #endregion

            #region 'Cargando Cbo PacienteVivo'

            if (!string.Equals(pacienteVivo, "3"))
            {
                cboPacienteVivo.SelectedValue = pacienteVivo;
                cboPacienteVivo.Enabled = false;
            }

            #endregion

            dgvAutorizacionesPrevias.DataSource = objAutorizacionBL.GetAutorizacionesPreviasPorPacienteCategoria(pacienteId,categoriaId);

        }

        #region 'CARGA DE DATOS'

        private void CargarCboPacienteActivoSis()
        {
            List<Observado> lista = new List<Observado>(3);
            Observado opcion0 = new Observado();
            opcion0.clave = string.Empty;
            opcion0.valor = "-PENDIENTE-";
            Observado opcion1 = new Observado();
            opcion1.clave = "1";
            opcion1.valor = "SI";
            Observado opcion2 = new Observado();
            opcion2.clave = "0";
            opcion2.valor = "NO";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            cboPacienteActivoSis.DataSource = lista;
            cboPacienteActivoSis.ValueMember = "clave";
            cboPacienteActivoSis.DisplayMember = "valor";
        }

        private void CargarCboPacienteRegimenSis()
        {
            List<Observado> lista = new List<Observado>(3);
            Observado opcion0 = new Observado();
            opcion0.clave = string.Empty;
            opcion0.valor = "-PENDIENTE-";
            Observado opcion1 = new Observado();
            opcion1.clave = "1";
            opcion1.valor = "Subsidiado";
            Observado opcion2 = new Observado();
            opcion2.clave = "2";
            opcion2.valor = "NRUS";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            cboPacienteRegimenSis.DataSource = lista;
            cboPacienteRegimenSis.ValueMember = "clave";
            cboPacienteRegimenSis.DisplayMember = "valor";
        }

        private void CargarCboPacienteVivo()
        {
            List<Observado> lista = new List<Observado>(3);
            Observado opcion0 = new Observado();
            opcion0.clave = string.Empty;
            opcion0.valor = "-PENDIENTE-";
            Observado opcion1 = new Observado();
            opcion1.clave = "1";
            opcion1.valor = "SI";
            Observado opcion2 = new Observado();
            opcion2.clave = "0";
            opcion2.valor = "NO";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            cboPacienteVivo.DataSource = lista;
            cboPacienteVivo.ValueMember = "clave";
            cboPacienteVivo.DisplayMember = "valor";
        }

        private void CargarCboModalidad()
        {
            List<Observado> lista = new List<Observado>(3);
            Observado opcion0 = new Observado();
            opcion0.clave = "S";
            opcion0.valor = "-PENDIENTE-";
            Observado opcion1 = new Observado();
            opcion1.clave = "P";
            opcion1.valor = "Prospectivo";
            Observado opcion2 = new Observado();
            opcion2.clave = "R";
            opcion2.valor = "Retrospectivo";
            lista.Add(opcion0);
            lista.Add(opcion1);
            lista.Add(opcion2);
            cboModalidad.DataSource = lista;
            cboModalidad.ValueMember = "clave";
            cboModalidad.DisplayMember = "valor";
        }

        #endregion

    }
}
