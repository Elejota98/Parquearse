using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Operaciones.Consignaciones
{
    public partial class FrmConsignaciones : Form
    {
        public FrmConsignaciones()
        {
            InitializeComponent();
        }

        #region FUNCIONES
      
        private void ListarEstacionamiento()
        {
            try
            {
                cboSede.DataSource = MConsignacion.ListarEstacionamiento();
                cboSede.ValueMember = "IdEstacionamiento";
                cboSede.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar los estacionamientos", ex.StackTrace);
            }
        }
   
        private void ListarTipoDeposito()
        {
            try
            {
                cboTipoDeposito.DataSource = MConsignacion.ListarTipoConsignacion();
                cboTipoDeposito.ValueMember = "IdDeposito";
                cboTipoDeposito.DisplayMember = "Consignacion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar los estacionamientos", ex.StackTrace);
            }
        }
        private void FrmConsignaciones_Load(object sender, EventArgs e)
        {
            ListarEstacionamiento();
            ListarTipoDeposito();
            txtIdConsignacion.Enabled = false;
            txtFechaConsignacion.Enabled = false;
            txtUsuario.Enabled = false;
            txtReferencia.Enabled = false;
            txtValor.Enabled = false;
            cboTipoDeposito.Enabled = false;
            cboSede.Enabled = true ;
            BtnActualizar.Enabled = false;
        }

        public void BuscarConsignacion()
        {

            DgvListado.DataSource = MConsignacion.BuscarConsignacion(DtmFechaInicio.Text, DtmFechaFin.Text, Convert.ToInt32(cboSede.SelectedValue));
                if (DgvListado.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontraron datos del autorizado", "Parquearse Tecnología");
                }
                else
                {
                    DgvListado.DataSource = MConsignacion.BuscarConsignacion(DtmFechaInicio.Text, DtmFechaFin.Text, Convert.ToInt32(cboSede.SelectedValue));
                
                }
            }

        public void ActualizarConsignacion()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de actualizar la consignación?" + "\n" + "Desea continuar con la modificación?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    if (MessageBox.Show("¿El valor de la consignación es correcto?" + "\n" + "Desea continuar con la modificación?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("¿La sede seleccionada (" + cboSede.SelectedText + ") es correcto?" + "\n" + "Desea continuar con la modificación?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            if (MessageBox.Show("¿El tipo de depósito es correcto?" + "\n" + "Desea continuar con la modificación?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int idConsignacion;
                                bool sincronizacion;
                                sincronizacion = true;
                                string rtdo = "";
                                rtdo = MConsignacion.ActualizarConsignacion(Convert.ToInt32(txtIdConsignacion.Text), Convert.ToInt32(cboSede.SelectedValue), txtFechaConsignacion.Text, Convert.ToInt32(txtValor.Text), txtReferencia.Text, txtUsuario.Text, Convert.ToInt32(cboTipoDeposito.SelectedValue), sincronizacion);
                                if (rtdo.Equals("OK"))
                                {
                                    this.MensajeOk("Se actualizó de manera correcta la consignación :" + Convert.ToInt32(txtIdConsignacion.Text));
                                    BuscarConsignacion();
                                    Limpiar();
                                }
                                else
                                {
                                    this.MensajeError(rtdo);
                                }


                            }
                            else
                            {
                                cboTipoDeposito.Focus();
                            }
                        }
                        else
                        {
                            cboSede.Focus();
                        }
                    }
                    else
                    {
                        txtValor.Focus();
                    }

                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo actualizar la consignación", ex.Message + ex.StackTrace);
            }
        }

        public void Limpiar()
        {
            txtIdConsignacion.Text = "";
            txtUsuario.Text = "";
            txtValor.Text = "";
            txtFechaConsignacion.Text = "";
            txtReferencia.Text = "";
            txtIdConsignacion.Enabled = false;
            txtFechaConsignacion.Enabled = false;
            txtUsuario.Enabled = false;
            txtReferencia.Enabled = false;
            txtValor.Enabled = false;
            cboTipoDeposito.Enabled = false;
            cboSede.Enabled = false;
            BtnActualizar.Enabled = false;
        }
        #endregion

        #region MENSAJES
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarConsignacion();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdConsignacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["IdConsignacion"].Value);            
            txtFechaConsignacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaConsignacion"].Value);
            txtValor.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Valor"].Value);
            txtReferencia.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Referencia"].Value);
            txtUsuario.Text = Convert.ToString(DgvListado.CurrentRow.Cells["DocumentoUsuario"].Value);
            cboSede.Enabled = true;
            cboTipoDeposito.Enabled = true;
            txtValor.Enabled = true;
            BtnActualizar.Enabled = true;
            txtReferencia.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarConsignacion();
        }
    }
    }

