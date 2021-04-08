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
    public partial class FrmRegistrarConciliacion : Form
    {
        Produccion objProduccion = new Produccion();
        ProduccionBL objProduccionBL = new ProduccionBL();
        ProduccionEstablecimiento objProduccionEstablecimiento = new ProduccionEstablecimiento();
        ProduccionEstablecimientoBL objProduccionEstablecimientoBL = new ProduccionEstablecimientoBL();
        DataTable dtProducciones;
        DataView dvProducciones;
        StringBuilder filtro = new StringBuilder();

        DataTable dt;
        int n;

        public FrmRegistrarConciliacion()
        {
            InitializeComponent();
            dgvProducciones.AutoGenerateColumns = false;
            dgvProduccionesSeleccionadas.AutoGenerateColumns = false;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void FrmConciliacionProduccionIpress_Load(object sender, EventArgs e)
        {
            //dgvProducciones.DataSource = objProduccionBL.Produccion_ListarPeriodoConciliacion();
            CargarDgvProducciones();
            FuncionesBases.CargarComboProduccionCN(cboProduccion);
            FuncionesBases.CargarComboEstablecimientoCN(cboEstablecimiento);
        }

        private void CargarDgvProducciones()
        {
            dtProducciones = objProduccionEstablecimientoBL.GetAllProduccionEstablecimiento_CN();
            dvProducciones = dtProducciones.DefaultView;
            dgvProducciones.DataSource = dvProducciones;
        }

        //public bool ValidarProduccionSeleccionada()
        //{
        //    bool error;
        //    error = false;

        //    List<DataGridViewRow> rowSelectedX = new List<DataGridViewRow>();
        //    foreach (DataGridViewRow rowX in dgvProducciones.Rows)
        //    {
        //        DataGridViewCheckBoxCell cellSelecionX = rowX.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
        //        if (!Convert.ToBoolean(cellSelecionX.Value))
        //            rowSelectedX.Add(rowX);
        //    }

        //    foreach (DataGridViewRow row in rowSelectedX)
        //    {
        //        int Periodo = int.Parse(row.Cells["Codigo"].Value.ToString());                
                
        //        foreach (DataGridViewRow reg in dgvProducciones.Rows)
        //        {
        //            if (Convert.ToBoolean(reg.Cells["Seleccionar"].Value)) 
        //            {
        //                if (int.Parse(reg.Cells["Codigo"].Value.ToString()) > Periodo)
        //                {
        //                    MessageBox.Show("¡Advertencia..., Producciones Pendientes sin Seleccionar!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    error = true;
        //                    break;
        //                }
        //            }                    
        //        }
        //    }
            
        //    return error;
        //}

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (MessageBox.Show("¿Iniciar Proceso de Conciliacion?", "FISSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvProduccionesSeleccionadas.RowCount > 0)
                {
                    //if (objProduccionEstablecimientoBL.ProduccionEstablecimientoConciliacion_Verificar().Rows.Count > 0)
                    //{
                    //    MessageBox.Show("No se puede iniciar la conciliacion, hay una conciliacion pendiente", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    //else
                    //{
                        //if (ValidarProduccionSeleccionada() == true) return;

                        int CodigoConciliacion = int.Parse(objProduccionEstablecimientoBL.ProduccionEstablecimientoConciliacion_Nuevo().Rows[0][0].ToString());
                        objProduccionEstablecimiento.CodigoConciliacion = CodigoConciliacion;
                        objProduccionEstablecimiento.UsuarioIniciaConciliacion = VariablesGlobales.Login;

                        lblLoading.Visible = true;
                        Application.DoEvents();
                        foreach (DataGridViewRow row in dgvProduccionesSeleccionadas.Rows)
                        {
                            #region 'ETIQUETANDO FUAS'

                            objProduccionEstablecimiento.ProduccionId = int.Parse(row.Cells["ProduccionIdSeleccionada"].Value.ToString());
                            objProduccionEstablecimiento.EstablecimientoId = int.Parse(row.Cells["RenaesSeleccionada"].Value.ToString());
                            objProduccionEstablecimientoBL.MovimientoPaciente_UpdateCodigoConciliacion(objProduccionEstablecimiento);

                            #endregion

                            #region 'ETIQUETANDO ABONOS'

                            objProduccionEstablecimientoBL.MovimientoCuentaConciliacion_UpdateAbono(objProduccionEstablecimiento);

                            #endregion

                            #region 'REGISTRANDO CONCILIACION'

                            objProduccionEstablecimientoBL.ProduccionEstablecimientoConciliacion_Update(objProduccionEstablecimiento);

                            #endregion

                        }

                        #region 'REGISTRO DE DEBITOS'

                        objProduccionEstablecimientoBL.MovimientoCuentaConciliacion_InsertDebito(objProduccionEstablecimiento);

                        #endregion

                        #region 'REGISTRO DE CUENTAS'

                        objProduccionEstablecimientoBL.EstadoCuentaConciliacion_Insert(objProduccionEstablecimiento);

                        #endregion

                        lblLoading.Visible = false;
                        this.DialogResult = DialogResult.OK;
                        Salir();
                    //}
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una produccion", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Buscar()
        {
            filtro.Clear();
            string produccionId = Convert.ToString(cboProduccion.SelectedValue);
            if (!string.Equals(produccionId, string.Empty))
                filtro.AppendFormat(" ProduccionId={0}", produccionId);
            string establecimientoId = Convert.ToString(cboEstablecimiento.SelectedValue);
            if (!string.Equals(establecimientoId, string.Empty))
            {
                if (string.Equals(filtro.ToString(), string.Empty))
                    filtro.AppendFormat(" Renaes={0}", establecimientoId);
                else
                    filtro.AppendFormat(" and Renaes={0}", establecimientoId);
            }
            dvProducciones.RowFilter = filtro.ToString();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
            this.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            n++;
            if (n == 1)
            {
                lblLoading.ForeColor = Color.Blue;
            }
            else
            {
                if (n == 2)
                {
                    lblLoading.ForeColor = Color.Red;
                }
                else
                {
                    if (n == 3)
                    {
                        lblLoading.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (n == 4)
                        {
                            n = 0;
                        }
                    }
                }
            }
        }

        private void dgvProducciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AgregarProducciones();
        }

        private void dgvProducciones_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AgregarProducciones();
                    break;
            }
        }

        private void dgvProduccion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProducciones.IsCurrentCellDirty)
                dgvProducciones.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }        

        private void AgregarProducciones()
        {
            if (!(dgvProducciones.RowCount > 0))
                return;
            DataGridViewRow row = dgvProducciones.CurrentRow;
            string codigoProduccion = row.Cells["Codigo"].Value.ToString();
            int establecimientoId = Convert.ToInt32(row.Cells["Renaes"].Value);
            //validacion 1
            DataTable dtProduccionesSinConciliar = objProduccionEstablecimientoBL.GetProduccionesAnterioresSinConciliarPorProduccionIpress(codigoProduccion, establecimientoId);
            if (dtProduccionesSinConciliar.Rows.Count > 0)
            {
                bool esCorrecto = false;
                //validacion 2
                int length = dtProduccionesSinConciliar.Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    DataRow dataRow = dtProduccionesSinConciliar.Rows[i]; 
                    int length2 = dgvProduccionesSeleccionadas.RowCount;
                    for (int j = 0; j < length2; j++)
                    {
                        DataGridViewRow row2 = dgvProduccionesSeleccionadas.Rows[j];
                        if (dataRow["ProduccionEstablecimientoId"].Equals(row2.Cells["ProduccionEstablecimientoIdSeleccionada"].Value))
                        {
                            esCorrecto = true;
                            break;
                        }
                        else
                            esCorrecto = false;
                    }
                    //
                    if (!esCorrecto)
                    {
                        MessageBox.Show("No se puede seleccionar, hay producciones anteriores sin conciliar", "FISSAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                
            }
            dgvProduccionesSeleccionadas.Rows.Add(new object[] { row.Cells["ProduccionEstablecimientoId"].Value, 
                row.Cells["ProduccionId"].Value, row.Cells["Codigo"].Value, row.Cells["Renaes"].Value, row.Cells["Ipress"].Value, row.Cells["AtencionesProduccion"].Value});
            dgvProducciones.Rows.Remove(row);
            //
        }

        private void dgvProduccionesSeleccionadas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    QuitarProducciones();
                    break;
            }
        }
        private void QuitarProducciones()
        {
            if (!(dgvProduccionesSeleccionadas.Rows.Count > 0))
                return;
            DataGridViewRow row2 = dgvProduccionesSeleccionadas.CurrentRow;
            List<DataGridViewRow> produccionesEliminar = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvProduccionesSeleccionadas.Rows)
            {
                if ((Convert.ToInt32(row.Cells["CodigoSeleccionada"].Value) >= Convert.ToInt32(row2.Cells["CodigoSeleccionada"].Value)) && row.Cells["RenaesSeleccionada"].Value.Equals(row2.Cells["RenaesSeleccionada"].Value))
                {
                    DataRow datarow = dtProducciones.NewRow();
                    datarow["ProduccionEstablecimientoId"] = Convert.ToString(row.Cells["ProduccionEstablecimientoIdSeleccionada"].Value);
                    datarow["ProduccionId"] = Convert.ToString(row.Cells["ProduccionIdSeleccionada"].Value);
                    datarow["Codigo"] = Convert.ToString(row.Cells["CodigoSeleccionada"].Value);
                    datarow["Renaes"] = Convert.ToString(row.Cells["RenaesSeleccionada"].Value);
                    datarow["Ipress"] = Convert.ToString(row.Cells["IpressSeleccionada"].Value);
                    datarow["AtencionesProduccion"] = Convert.ToString(row.Cells["AtencionesProduccionSeleccionada"].Value);
                    dtProducciones.Rows.Add(datarow);
                    produccionesEliminar.Add(row);
                }
            }
            foreach (DataGridViewRow produccion in produccionesEliminar)
            {
                dgvProduccionesSeleccionadas.Rows.Remove(produccion);
            }
            dgvProducciones.DataSource = dtProducciones;
            dvProducciones.Sort = string.Format("Codigo asc");
        }

        private void dgvProduccionesSeleccionadas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProduccionesSeleccionadas.IsCurrentCellDirty)
                dgvProduccionesSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvProducciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FuncionesBases.ImprimirFilasDataGridView(dgvProducciones, tsslTotalRegistros);
        }

        private void dgvProduccionesSeleccionadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            QuitarProducciones();
        }

        private void cboProduccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cboEstablecimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
