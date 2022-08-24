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
    public partial class FrmFacManuales : Form
    {
        public FrmFacManuales()
        {
            InitializeComponent();
        }

        #region Listar Informacion
        private void ListarEstacionamiento()
        {
            try
            {
                CboEstacionamiento.DataSource = MFacturasManuales.ListarEstacionamiento();
                CboEstacionamiento.ValueMember = "IdEstacionamiento";
                CboEstacionamiento.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar los estacionamientos", ex.StackTrace);
            }
        }


        private void ListarTipoCobro()
        {
            try
            {
                CboTipoCobro.DataSource = MFacturasManuales.ListarTipoCobro();
                CboTipoCobro.ValueMember = "IdTipoVehiculo";
                CboTipoCobro.DisplayMember = "TipoVehiculo";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar el tipo de vehiculo", ex.StackTrace);
            }

        }


        private void ListarEstacionamientoBusqueda()
        {
            try
            {
                CboEstacionamientoBuscar.DataSource = MFacturasManuales.ListarEstacionamiento();
                CboEstacionamientoBuscar.ValueMember = "IdEstacionamiento";
                CboEstacionamientoBuscar.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo cargar los estacionamientos", ex.StackTrace);
            }
        }


        private void ListarUsuario()
        {

            try
            {
                CboUsuario.DataSource = MFacturasManuales.ListarUsuario();
                CboUsuario.ValueMember = "Documento";
                CboUsuario.DisplayMember = "Nombres";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error al intentar cargar los usuarios", ex.StackTrace);


            }
        }

        private void ListarFacturasManuales()
        {

            if (CboEstacionamientoBuscar.SelectedItem == "")
            {
                MessageBox.Show("Seleccione una sede ", "Parquearse Tecnología");
                CboEstacionamientoBuscar.Focus();
            }
            else if ((TxtFechaDesde.Text == "") && (TxtFechaHasta.Text == ""))
            {
                MessageBox.Show("Seleccione un rango de fecha", "Parquearse Tecnología");
                TxtFechaHasta.Focus();
                TxtFechaDesde.Focus();
            }
            else
            {
                DgvListado.DataSource = MFacturasManuales.ListarFacManuales(Convert.ToInt32(CboEstacionamientoBuscar.SelectedValue), TxtFechaDesde.Text, TxtFechaHasta.Text);
                if (DgvListado.Rows.Count < 1)
                {
                    MessageBox.Show("No se posible consultar la información, verifique por favor", "Parquearse Tecnología");
                }
                else
                {
                    DgvListado.DataSource = MFacturasManuales.ListarFacManuales(Convert.ToInt32(CboEstacionamientoBuscar.SelectedValue), TxtFechaDesde.Text, TxtFechaHasta.Text);
                    BtnInsertar.Visible = false;
                    BtnGuardar.Visible = false;
                    BtnModificar.Visible = true;
                }

            }

        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmFacManuales_Load(object sender, EventArgs e)
        {
            BtnInsertar.Visible = true;
            BtnGuardar.Visible = false;
            PnelInformacion.Visible = false;
            PnelInformacionModificar.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            ListarFacturasManuales();
        }
        public void FormatoTabla()
        {
            DgvListado.Columns[0].Width = 10;
            DgvListado.Columns[0].HeaderText = "Modulo";
            DgvListado.Columns[1].Width = 190;
            DgvListado.Columns[1].HeaderText = "Autorizado";
            DgvListado.Columns[4].Width = 80;
            DgvListado.Columns[4].HeaderText = "Placa 1";
            DgvListado.Columns[5].Width = 80;
            DgvListado.Columns[5].HeaderText = "Placa 2";
            DgvListado.Columns[6].Width = 80;
            DgvListado.Columns[6].HeaderText = "Placa 3";
            DgvListado.Columns[7].Width = 190;
            DgvListado.Columns[7].HeaderText = "Tipo Autorización";
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Limpiar()
        {
            CboEstacionamiento.SelectedValue = string.Empty;
            cboCarril.SelectedText = string.Empty;
            CboTipoCobro.SelectedText = string.Empty;
            CboUsuario.SelectedText = string.Empty;
            txtPrefijo.Text = "";
            txtNumeroFactura.Text = "";


        }

        private void CboEstacionamientoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarEstacionamiento();
        }

        private void cboCarrilM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoCobroM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarTipoCobro();
        }

        private void CboUsuarioM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void CboEstacionamientoM_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmFacManuales_Load_1(object sender, EventArgs e)
        {
            PnelInformacionModificar.Enabled = false;
            ListarEstacionamiento();
            BtnGuardar.Visible = false;
            BtnInsertar.Visible = true;
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmFacManuales_Load_2(object sender, EventArgs e)
        {
            PnelInformacion.Visible = false;
            PnelInformacionModificar.Visible = false;
            BtnGuardar.Visible = false;
            BtnInsertar.Visible = true;
            ListarEstacionamiento();
            ListarTipoCobro();
            ListarEstacionamientoBusqueda();
            ListarUsuario();
            
        }

        private void BtnBuscar_Click_2(object sender, EventArgs e)
        {
            ListarFacturasManuales();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            //PnelInformacion.Visible = true;
            //BtnInsertar.Enabled = false;
            //BtnInsertar.Visible = false;
            //BtnGuardar.Visible = true;
            
        }

        private void DgvListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CboUsuarioM.Text = "";
            CboEstacionamientoM.Text = "";
            PnelInformacion.Visible = false;
            PnelInformacionModificar.Visible = true;
            cboCarrilM.Text = Convert.ToString(DgvListado.CurrentRow.Cells["IdModulo"].Value);
            txtPrefijoM.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Prefijo"].Value);
            string numeroFactura = txtNumeroFacturaM.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NumeroFactura"].Value);
            txtTotalM.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Total"].Value);
            string docUsuario = CboUsuarioM.SelectedText = Convert.ToString(DgvListado.CurrentRow.Cells["DocumentoUsuario"].Value);
            string idEstacionamiento = CboEstacionamientoM.SelectedText = Convert.ToString(DgvListado.CurrentRow.Cells["IdEstacionamiento"].Value);
            TxtFechaPagoM.Text= Convert.ToString(DgvListado.CurrentRow.Cells["FechaPago"].Value);
            //Listando Usuario

            CboUsuarioM.DataSource = MFacturasManuales.ListarUsuarioModificar(docUsuario);
            CboUsuarioM.ValueMember = "Documento";
            CboUsuarioM.DisplayMember = "Nombres";

            //Listando Estacionamiento
            CboEstacionamientoM.DataSource = MFacturasManuales.ListarEstacionamientoModificar(idEstacionamiento);
            CboEstacionamientoM.ValueMember = "IdEstacionamiento";
            CboEstacionamientoM.DisplayMember = "Nombre";

            //Listar Tipo Cobro
            CboTipoCobroM.DataSource= MFacturasManuales.ListarTipoCobroModificar();
            CboTipoCobroM.ValueMember = "IdTipoVehiculo";
            CboTipoCobroM.DisplayMember = "TipoVehiculo";

            CboEstacionamientoM.Enabled = false;
            TxtFechaPagoM.Enabled = false;
            cboCarrilM.Enabled = false;
            CboUsuarioM.Enabled = false;
            txtPrefijoM.Enabled = false;


        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {

                double total = Convert.ToInt32(txtTotal.Text.ToString());
                double subtotal = Math.Round((total) / 1.19, 0);
                double iva = Convert.ToInt32(total - subtotal);

                byte sincronizacion = 1;

                string rta = "";
                if (cboCarril.SelectedItem == "")
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    cboCarril.Focus();

                }
                else if ((CboEstacionamiento.Text == "") && (TxtFechaPago.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    CboEstacionamiento.Focus();
                    TxtFechaPago.Focus();
                }
                else if ((txtPrefijo.Text == "") && (txtNumeroFactura.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    txtPrefijo.Focus();
                    txtNumeroFactura.Focus();
                }
                else if ((CboTipoCobro.Text == "") && (CboUsuario.Text == "") || (txtTotal.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    txtPrefijo.Focus();
                    txtNumeroFactura.Focus();
                    txtTotal.Focus();
                }
                else
                {

                    rta = MFacturasManuales.InsertarFactura(Convert.ToString(cboCarril.SelectedItem), Convert.ToInt32(CboEstacionamiento.SelectedValue), TxtFechaPago.Text, subtotal, iva, total, txtPrefijo.Text, Convert.ToInt32(txtNumeroFactura.Text), Convert.ToInt32(CboTipoCobro.SelectedValue.ToString()), Convert.ToInt32(CboUsuario.SelectedValue.ToString()));

                    if (rta.Equals("OK"))
                    {
                        this.MensajeOk("¡Factura guardada con exito!");
                        BtnGuardar.Visible = false;
                        PnelInformacion.Visible = false;
                        BtnInsertar.Visible = true;
                        BtnInsertar.Enabled = true;
                        txtPrefijo.Text = "";
                        txtNumeroFactura.Text = "";
                        txtTotal.Text = "";

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToInt32(txtTotalM.Text.ToString());
                double subtotal = Math.Round((total) / 1.19, 0);
                double iva = Convert.ToInt32(total - subtotal);

                byte sincronizacion = 1;
                string rta = "";
                if (cboCarrilM.Text == "")
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    cboCarril.Focus();

                }
                else if ((CboEstacionamientoM.Text == "") && (TxtFechaPagoM.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    CboEstacionamiento.Focus();
                    TxtFechaPago.Focus();
                }
                else if ((txtPrefijoM.Text == "") && (txtNumeroFacturaM.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    txtPrefijo.Focus();
                    txtNumeroFactura.Focus();
                }
                else if ((CboTipoCobroM.Text == "") && (CboUsuarioM.Text == "") || (txtTotalM.Text == ""))
                {
                    MessageBox.Show("Falta datos por ingresar", "Parquearse Tecnología");
                    txtPrefijoM.Focus();
                    txtNumeroFacturaM.Focus();
                    txtTotalM.Focus();
                }
                else
                {
                    if (MessageBox.Show("Por favor verifique si el tipo de cobro es correcto" + "\n" + "Desea continuar con la moficicación?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        rta = MFacturasManuales.ModificarFactura(Convert.ToString(cboCarrilM.SelectedValue), Convert.ToInt32(CboEstacionamientoM.SelectedValue), TxtFechaPagoM.Text, subtotal, iva, total, txtPrefijoM.Text, Convert.ToInt32(txtNumeroFacturaM.Text), Convert.ToInt32(CboTipoCobroM.SelectedValue.ToString()), Convert.ToInt32(CboUsuarioM.SelectedValue.ToString()));

                        if (rta.Equals("OK"))
                        {
                            this.MensajeOk("¡Factura modificada con exito!");
                            BtnGuardar.Visible = false;
                            PnelInformacion.Visible = false;
                            BtnInsertar.Visible = true;
                            BtnInsertar.Enabled = true;
                            txtPrefijo.Text = "";
                            txtNumeroFactura.Text = "";
                            txtTotal.Text = "";
                            ListarFacturasManuales();

                        }
                    }

                    else

                    {
                        CboTipoCobroM.Focus();
                    }
                   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
