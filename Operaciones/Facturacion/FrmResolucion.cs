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

namespace Operaciones.Facturacion
{
    public partial class FrmResolucion : Form
    {
        public FrmResolucion()
        {
            InitializeComponent();
            ListarEstacionamiento();

        }     
        private void ListarEstacionamiento()
        {
            try
            {
                CboEstacionamiento.DataSource = MFacturacion.ListarEstacionamiento();
                CboEstacionamiento.ValueMember = "IdEstacionamiento";
                CboEstacionamiento.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar los estacionamientos", ex.StackTrace);
            }
        }
     
        private void FrmResolucion_Load(object sender, EventArgs e)
        {
            ListarEstacionamiento();
            PanelResolucion.Visible = false;
        }    

        private void ListarDatosResolucion()
        {
            DgvListado.DataSource = MFacturacion.ListarResolucion(Convert.ToInt32(CboEstacionamiento.SelectedValue));
        }    

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelResolucion.Visible = false;
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void TxtFactuacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtmResolucion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            this.ListarDatosResolucion();
        }

        private void DgvListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PanelResolucion.Visible = true;
                TxtFacturacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Facturacion"].Value);
                TxtModulo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Modulo"].Value);
                TxtPrefijo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Prefijo"].Value);
                TxtResolucion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Resolucion"].Value);
                DtmResolucion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaResolucion"].Value);
                DtmFinResolucion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaFinResolucion"].Value);
                TxtFacInicial.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FacturaInicial"].Value);
                TxtFacFinal.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FacturaFinal"].Value);
                TxtFacActual.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FacturaActual"].Value);
                TxtPrefijo.Enabled = false;
                TxtModulo.Enabled = false;
                TxtFacturacion.Enabled = false;
                TxtFacActual.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos de la resolucion", ex.Message);
            }
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {

                string Rta = "";
                if (TxtResolucion.Text == string.Empty || TxtFacInicial.Text == string.Empty || TxtFacFinal.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar datos obligatorios");
                    ErrorIcono.SetError(TxtResolucion, "Ingrese una resolucion");
                    ErrorIcono.SetError(TxtFacInicial, "Ingrese el inicio de la facturación");
                    ErrorIcono.SetError(TxtFacFinal, "Ingrese el final de la resolución");

                }
                else
                {
                    Rta = MFacturacion.ActualizarResolucion(TxtFacInicial.Text.Trim(), TxtFacFinal.Text.Trim(), TxtResolucion.Text.Trim(), DtmResolucion.Text.Trim(), DtmFinResolucion.Text.Trim(), Convert.ToInt32(TxtFacturacion.Text.Trim()), TxtPrefijo.Text.Trim(), Convert.ToInt32(CboEstacionamiento.SelectedValue.ToString()));

                    if (Rta.Equals("OK"))
                    {
                        this.MensajeOk("Resolucion Actualizada Correctamente");
                        this.ListarDatosResolucion();

                    }
                    else
                    {
                        this.MensajeError(Rta);
                    }
                }
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en el momento de actualizar el registro" + ex.Message);
            }


        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
