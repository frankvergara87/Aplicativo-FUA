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
    public partial class FrmRegistrarPaquete : Form
    {
        public FrmRegistrarPaquete()
        {
            InitializeComponent();
        }

        Paquete objPaquete = new Paquete();
        PaqueteBL objPaqueteBL = new PaqueteBL();

        DataTable dt;

        private void FrmRegistrarPaquete_Load(object sender, EventArgs e)
        {
            FuncionesBases.CargarCboEstablecimiento_Listar(cboEstablecimiento);
            FuncionesBases.CargarCboTipoAutorizacion(cboAutorizacion);
            FuncionesBases.CargarCboCategoria(cboCategoria);
            FuncionesBases.CargarCboEstadio(cboEstadio);
            FuncionesBases.CargarCboFase(cboFase);

            if (VariablesGlobales.NroX == 1)
            {
                LimpiarData();
            }
            else
            {
                if (VariablesGlobales.NroX == 2)
                {
                    Paquete_ListarxTratamientoId(VariablesGlobales.TratamientoIdX);
                }
            }    
        }

        private void tsBtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDuplicadoPaquete() == true) return;

                if (VariablesGlobales.NroX == 1)
                {
                    objPaquete.EstablecimientoId = int.Parse(cboEstablecimiento.SelectedValue.ToString());
                    objPaquete.FaseId = int.Parse(cboFase.SelectedValue.ToString());
                    objPaquete.CategoriaId = cboCategoria.SelectedValue.ToString();
                    objPaquete.EstadioId = byte.Parse(cboEstadio.SelectedValue.ToString());
                    objPaquete.TipoAutorizacionId = byte.Parse(cboAutorizacion.SelectedValue.ToString());
                    objPaquete.UsuarioCreacion = VariablesGlobales.UsuarioId.ToString();
                    objPaqueteBL.Paquete_Insert(objPaquete);
                    MessageBox.Show("¡Paquete Registrado!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarData();
                }
                else
                {
                    if (VariablesGlobales.NroX == 2)
                    {
                        objPaquete.TratamientoId = VariablesGlobales.TratamientoIdX;
                        objPaquete.EstablecimientoId = int.Parse(cboEstablecimiento.SelectedValue.ToString());
                        objPaquete.FaseId = int.Parse(cboFase.SelectedValue.ToString());
                        objPaquete.CategoriaId = cboCategoria.SelectedValue.ToString();
                        objPaquete.EstadioId = byte.Parse(cboEstadio.SelectedValue.ToString());
                        objPaquete.TipoAutorizacionId = byte.Parse(cboAutorizacion.SelectedValue.ToString());                        
                        objPaqueteBL.Paquete_Update(objPaquete);
                        MessageBox.Show("¡Paquete Actualizado!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarData();
                    } 
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        void Paquete_ListarxTratamientoId(int TratamientoId)
        {
            try
            {                
                dt = objPaqueteBL.Paquete_ListarxTratamientoId(TratamientoId);
                lblTratamientoId.Text = dt.Rows[0][0].ToString();
                cboEstablecimiento.SelectedValue = dt.Rows[0][1].ToString();
                cboFase.SelectedValue = dt.Rows[0][2].ToString();
                cboCategoria.SelectedValue = dt.Rows[0][3].ToString();
                cboEstadio.SelectedValue = dt.Rows[0][4].ToString();
                cboAutorizacion.SelectedValue = dt.Rows[0][5].ToString();
                lblVersion.Text = dt.Rows[0][6].ToString();
                lblFechaCreacion.Text = dt.Rows[0][7].ToString();
                lblUsuario.Text = dt.Rows[0][8].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        void LimpiarData()
        {
            lblTratamientoId.Text = "";
            cboEstablecimiento.SelectedValue = 0;
            cboFase.SelectedValue = 0;
            cboCategoria.SelectedValue = 0;
            cboEstadio.SelectedValue = 0;
            cboAutorizacion.SelectedValue = 0;
            lblVersion.Text = "";
            lblFechaCreacion.Text = "";
            lblUsuario.Text = "";
        }

        public bool ValidarDuplicadoPaquete()
        {
            bool error;
            error = false;

            objPaquete.EstablecimientoId = int.Parse(cboEstablecimiento.SelectedValue.ToString());            
            objPaquete.CategoriaId = cboCategoria.SelectedValue.ToString();
            objPaquete.EstadioId = byte.Parse(cboEstadio.SelectedValue.ToString());
            objPaquete.FaseId = int.Parse(cboFase.SelectedValue.ToString());
            objPaquete.TipoAutorizacionId = byte.Parse(cboAutorizacion.SelectedValue.ToString());             

            if (objPaqueteBL.Paquete_VerificarDuplicadoPaquete(objPaquete).Rows.Count > 0) 
            {
                MessageBox.Show("¡Ya existe Paquete para Ipress!", "Fissal", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                error = true;
            }           

            return error;
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
