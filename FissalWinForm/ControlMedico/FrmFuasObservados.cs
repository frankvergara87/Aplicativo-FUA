using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FissalBE;
using FissalBL;


namespace FissalWinForm
{
    public partial class FrmFuasObservados : Form
    {
        ControlMedicoLogBL objControlMedicoBL = new ControlMedicoLogBL();   

        public FrmFuasObservados()
        {
            InitializeComponent();
        } 

        private void FrmFuasObservados_Load(object sender, EventArgs e)
        {
            dgvListadoFuas.AutoGenerateColumns = false;
                        
            /** Carga de Filtros **/
            FuncionesBases.Filtro_CboCMedico(cbFiltroCMedico);
            FuncionesBases.Filtro_CboEstablecimiento(cbFiltroEstablecimiento);
            /*********************/

            /** Carga Contadores **/
            TFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(1,Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue),Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            EFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(2,Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue),Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            OFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(3,Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue),Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            /*********************/

            Cargar_ListadoFuas(Convert.ToInt32(cbFiltroCMedico.SelectedValue), Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue));

            this.cbFiltroEstablecimiento.SelectedIndexChanged += new System.EventHandler(this.cbFiltroEstablecimiento_SelectedIndexChanged);
            this.cbFiltroCMedico.SelectedIndexChanged += new System.EventHandler(this.cbFiltroCMedico_SelectedIndexChanged);


         }
        
        #region 'METODOS'

        void Cargar_ListadoFuas(int ControlMedico, int EstablecimientoId) 
        {
            if (objControlMedicoBL.Filtrar_ControlMedico() != null)
            {
                dgvListadoFuas.DataSource = objControlMedicoBL.Listado_Fuas(ControlMedico, EstablecimientoId); ;
            }
            else
            {
                MessageBox.Show("El Listado no contiene datos..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ExportarFuas(int Valor) 
        {
            DataTable dtListadoFuas = new DataTable();
            DataTable dtListadoTotalFuas = new DataTable();
            string Correlativo = String.Empty;

            //Paramentros
            DataTable dtParam = new DataTable();
            dtParam.Columns.Add("Clave");
            dtParam.Columns.Add("Valor");

            if ((Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue)) == 0)
                dtParam.Rows.Add(new object[] { "Establecimiento: ", "Todos" });
            else
                dtParam.Rows.Add(new object[] { "Establecimiento: ", cbFiltroEstablecimiento.Text });


            if (Valor == 1) // Exportar Listado en Grilla
            {
                dtListadoFuas = objControlMedicoBL.Exportar_ListadoFuas(Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue), Convert.ToInt32(cbFiltroCMedico.SelectedValue));

                if (dtListadoFuas.Rows.Count > 0)
                {
                    //Anchos Columnas           
                    Int32[] anchosColumnas = new Int32[] { 130, 150, 150, 100, 300, 100, 100, 100 };

                    FuncionesBases.ObtenerArchivoExcel(dtListadoFuas, "Reporte Control Médico", "Listado_Fuas", dtParam, anchosColumnas);  
                }    
                else
                {
                    MessageBox.Show("No existe datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Valor == 2) // Exportar Todo
            {
                dtListadoTotalFuas = objControlMedicoBL.Exportar_ListadoTotalFuas(Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue), Convert.ToInt32(cbFiltroCMedico.SelectedValue));

                if (dtListadoTotalFuas.Rows.Count > 0)
                {
                   //Anchos Columnas           
                    Int32[] anchosColumnas = new Int32[] { 250, 100, 130, 130, 80, 280, 80, 100, 120, 120, 100, 120, 120, 120, 60, 120, 120, 80, 380, 80, 150, 150, 80, 150, 150, 150};

                    FuncionesBases.ObtenerArchivoExcel(dtListadoTotalFuas, "Reporte Control Médico", "Listado_FuasDet", dtParam, anchosColumnas);

                }
                else
                {
                    MessageBox.Show("No existe datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        #endregion

        #region 'BOTONES'

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cargar_ListadoFuas(Convert.ToInt32(cbFiltroCMedico.SelectedValue), Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarFuas(1);
        }

        private void btnExportarTodo_Click(object sender, EventArgs e)
        {
            ExportarFuas(2);
        }

        #endregion

        #region 'EVENTOS'

        private void dgvListadoFuas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvListadoFuas.Columns[e.ColumnIndex].Name == "VerDetalle")
            {
                DataGridViewRow row = dgvListadoFuas.Rows[e.RowIndex];
                Int64 fua = Convert.ToInt64(row.Cells["CodFua"].Value);
                Int64[] listaIdAtenciones = new Int64[1];
                listaIdAtenciones[0] = fua;
                FrmFua frmFua = new FrmFua(listaIdAtenciones,0);
                frmFua.ShowDialog();
            }
        }

        #endregion

        private void cbFiltroEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            /** Carga Contadores **/
            TFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(1, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue.ToString()), Convert.ToInt32(cbFiltroCMedico.SelectedValue.ToString())));
            EFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(2, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue.ToString()), Convert.ToInt32(cbFiltroCMedico.SelectedValue.ToString())));
            OFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(3, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue.ToString()), Convert.ToInt32(cbFiltroCMedico.SelectedValue.ToString())));
            /*********************/
        }

        private void cbFiltroCMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            /** Carga de Filtros **/
            FuncionesBases.Filtro_CboEstablecimiento(cbFiltroEstablecimiento);
            /*********************/

            /** Carga Contadores **/
            TFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(1, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue), Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            EFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(2, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue), Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            OFuas.Text = Convert.ToString(objControlMedicoBL.Contador_Fuas(3, Convert.ToInt32(cbFiltroEstablecimiento.SelectedValue), Convert.ToInt32(cbFiltroCMedico.SelectedValue)));
            /*********************/
        }

        

    }
}
