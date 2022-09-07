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
    public partial class FrmAnularFactura : Form
{
    public FrmAnularFactura()
    {
        InitializeComponent();
    }

    #region CargarEstacionamiento
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
    #endregion

    private void FrmAnularFactura_Load(object sender, EventArgs e)
    {
        this.ListarEstacionamiento();
    }

    private void BtnConsultar_Click(object sender, EventArgs e)
    {
        this.Buscar();
    }

    private void Buscar()
    {
        if (TxtNumeroFactura.Text == string.Empty)
        {
            MessageBox.Show("Es necesario que ingrese un numero de factura");
            TxtNumeroFactura.Focus();
        }
        else
        {
            DgvListado.DataSource = MFacturacion.ListarFactura(Convert.ToInt32(TxtNumeroFactura.Text), Convert.ToInt32(CboEstacionamiento.SelectedValue));
            if (DgvListado.Rows.Count < 1)
            {
                MessageBox.Show("No se encontró el número de la factura, verifique la sede o el número de factura ingresado");
                TxtNumeroFactura.Focus();

            }
            else
            {
                DgvListado.DataSource = MFacturacion.ListarFactura(Convert.ToInt32(TxtNumeroFactura.Text), Convert.ToInt32(CboEstacionamiento.SelectedValue));
            }
        }
    }

    private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea anular la factura?", "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                int NumeroFac;
                string Rta = "";
                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[7].Value))
                    {

                        NumeroFac = Convert.ToInt32(row.Cells[0].Value);
                        Rta = MFacturacion.Anular(NumeroFac);
                        if (Rta.Equals("OK"))
                        {
                            this.MensajeOk("Se anuló la factura :" + Convert.ToString(row.Cells[1].Value));
                        }
                        else
                        {
                            this.MensajeError(Rta);
                        }
                    }


                }
                this.Buscar();
            }

        }
        catch (Exception ex)
        {

            MessageBox.Show("Error al momento de anular la factura", ex.Message + ex.StackTrace);
        }
    }


    private void MensajeOk(string Mensaje)
    {
        MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void MensajeError(string Mensaje)
    {
        MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }        

        private void CboEstacionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAnularFactura_Load_1(object sender, EventArgs e)
        {
            this.ListarEstacionamiento();
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea anular la factura?", "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int NumeroFac;
                    string Rta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[7].Value))
                        {

                            NumeroFac = Convert.ToInt32(row.Cells[0].Value);
                            Rta = MFacturacion.Anular(NumeroFac);
                            if (Rta.Equals("OK"))
                            {
                                this.MensajeOk("Se anuló la factura :" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rta);
                            }
                        }


                    }
                    this.Buscar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al momento de anular la factura", ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea cancelar la anulación de la factura?", "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int NumeroFac;
                    string Rta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[7].Value))
                        {

                            NumeroFac = Convert.ToInt32(row.Cells[0].Value);
                            Rta = MFacturacion.DesAnular(NumeroFac);
                            if (Rta.Equals("OK"))
                            {
                                this.MensajeOk("Se cancelo la anulación de la factura: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rta);
                            }
                        }


                    }
                    this.Buscar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al momento de  cancelar la anulación de la factura", ex.Message + ex.StackTrace);
            }
        }
    }
}
