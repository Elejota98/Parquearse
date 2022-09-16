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
using EGlobalT.Device.SmartCardReaders.Entities;
using EGlobalT.Device.SmartCardReaders;
using LectorDevice;

namespace Operaciones.Autorizaciones
{
    public partial class FrmAutorizado : Form
    {
        PCSCReader reader = new PCSCReader();
        Lectora oLectora = new Lectora();

        public int DocumentoUsuario;
        public FrmAutorizado()
        {
            InitializeComponent();
        }

        private void FrmAutorizado_Load(object sender, EventArgs e)
        {
            PanelAutorizados.Visible = false;

        }

        #region BuscarAutorizado
        public void ListarAutorizado()
        {
            if (TxtDocumento.Text == string.Empty && TxtPlaca1.Text == string.Empty && TxtPlaca2.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos", "Parquearse Tecnología");

            }
            else
            {
                DgvListado.DataSource = MAutorizado.BuscarAutorizado(TxtDocumento.Text, TxtPlaca1.Text, TxtPlaca2.Text);
                if (DgvListado.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontraron datos del autorizado", "Parquearse Tecnología");


                }
                else
                {
                    DgvListado.DataSource = MAutorizado.BuscarAutorizado(TxtDocumento.Text, TxtPlaca1.Text, TxtPlaca2.Text);
                    this.Formato();
                }
            }

        }
        #endregion


        #region FormatoTabla
        public void Formato()
        {
            DgvListado.Columns[0].Width = 90;
            DgvListado.Columns[0].HeaderText = "Documento";
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


        #endregion

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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

        private void DtmFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }


        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rta = "";


                Rta = MAutorizado.ActualizarFecha(TxtDocumentoP.Text.Trim(), DtmFechaFin.Text.Trim());

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Fecha Actualizada Correctamente");
                    this.ListarAutorizado();

                }
                else
                {
                    this.MensajeError(Rta);
                }
            }




            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en el momento de actualizar el registro" + ex.Message);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DocumentoUsuario = 1;
            Rspsta_Conexion_LECTOR RespCin = new Rspsta_Conexion_LECTOR();
            Lectora_ACR122U Lector = new Lectora_ACR122U();
            Rspsta_LecturaTarjeta_SectorBloque_LECTOR RspLect = new Rspsta_LecturaTarjeta_SectorBloque_LECTOR();
            Rspsta_CheckPassword_Tarjeta_LECTOR res = new Rspsta_CheckPassword_Tarjeta_LECTOR();
            Rspsta_CodigoTarjeta_LECTOR RspId = new Rspsta_CodigoTarjeta_LECTOR();
            RespCin = Lector.Conectar(true);
            if (RespCin.Conectado)
            {
                RspId = Lector.ObtenerIDTarjeta();

                if (RspId.CodigoTarjeta != string.Empty)
                {
                    string CARD = RspId.CodigoTarjeta;
                    txtIdTarjeta.Text = CARD;
                }
            }
            else
            {
                MessageBox.Show(Owner, "No se encontro ningun lector conectado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtDocumentoP.Text == string.Empty || TxtNombresP.Text == string.Empty || txtPlaca1p.Text == string.Empty || txtIdTarjeta.Text == string.Empty)
            {
                MessageBox.Show(Owner, "Faltan algunos datos por ingresar, verifique el Documento, Nombres, Placa1 o Tarjeta", "INFO");
            }
            else if (TxtDocumento.Text != string.Empty || TxtNombresP.Text != string.Empty || TxtPlaca1.Text != string.Empty)
            {
                string Rta = "";
                Rta = MAutorizado.InsertarAutorizado(TxtDocumentoP.Text.Trim(), Convert.ToInt32(cboAutorizaciones.SelectedValue.ToString()), TxtNombresP.Text.Trim(), txtIdTarjeta.Text.Trim(), TxtnombreEmpresa.Text.Trim(), TxtNit.Text.Trim(), fechaactual.ToString(), this.DocumentoUsuario.ToString(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), txtPlaca1p.Text.Trim(), TxtPlaca2.Text.Trim(), TxtPlaca3P.Text.Trim(), txtPlaca4.Text.Trim());
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Registro Guardado Correctamente");
                    TxtDocumentoP.Text = "";
                    TxtNombresP.Text = "";
                    txtPlaca1p.Text = "";
                    TxtnombreEmpresa.Text = "";
                    TxtNit.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    TxtPlaca2.Text = "";
                    txtPlaca2p.Text = "";
                    TxtPlaca3P.Text = "";
                    txtPlaca4.Text = "";
                    txtIdTarjeta.Text = "";

                }
                else
                {
                    this.MensajeError(Rta);
                }
            }
        }

        private void DgvListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Reposicion"].Index)
            {
                DataGridViewCheckBoxCell ChkReponer = (DataGridViewCheckBoxCell)(DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Reposicion"];
                ChkReponer.Value = !Convert.ToBoolean(ChkReponer.Value);
            }
            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    try
                    {
                        if (MessageBox.Show("¿Esta seguro de realizar la reposición?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string Rta = "";
                            string claveTarjeta = "ADDAADDAADDA";


                            ResultadoOperacion oResultadoOperacion = new ResultadoOperacion();

                            oResultadoOperacion = oLectora.LeerTI(claveTarjeta);
                            if (oResultadoOperacion.oEstado == TipoRespuesta.Exito)
                            {
                                oResultadoOperacion = oLectora.BorrarTI(claveTarjeta);
                                oResultadoOperacion = oLectora.EscribirReposicion(claveTarjeta);


                                if (oResultadoOperacion.oEstado == TipoRespuesta.Exito)
                                {
                                    oResultadoOperacion = oLectora.ObtenerID();
                                    if (oResultadoOperacion.oEstado == TipoRespuesta.Exito)
                                    {

                                        Rta = MAutorizado.ActualizarTarjeta(oResultadoOperacion.EntidadDatos.ToString(), row.Cells[5].Value.ToString(), row.Cells[1].Value.ToString());
                                        if (Rta.Equals("OK"))
                                        {
                                            this.MensajeOk("Reposición aplicada correctamente");

                                        }
                                        else
                                        {
                                            this.MensajeError("Ocurrio un error en el momento de aplicar la reposición");
                                        }

                                    }
                                    else
                                    {
                                        this.MensajeError("No fue posible leer el id de la tarjeta");
                                    }
                                }
                                else
                                {
                                    this.MensajeError("No fue posible aplicar la reposición a la tarjeta");
                                }
                            }
                            else
                            {
                                this.MensajeError("No fue posible escribir en la tarjeta");
                            }
                        }
                        else
                        {
                            this.MensajeError("No fue posible leer la tarjeta");
                        }
                    }

                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnBuscar_Click_2(object sender, EventArgs e)
        {
            ListarAutorizado();
        }

        private void DgvListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PanelAutorizados.Visible = true;
            TxtDocumentoP.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Documento"].Value);
            TxtNombresP.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NombreApellidos"].Value);
            TxtnombreEmpresa.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NombreEmpresa"].Value);
            TxtNit.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nit"].Value);
            txtPlaca1p.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Placa1"].Value);
            DtmFechaInicio.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaInicio"].Value);
            DtmFechaFin.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaFin"].Value);
            txtPlaca2p.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Placa2"].Value);
            TxtPlaca3P.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Placa3"].Value);
            cboAutorizaciones.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NombreAutorizacion"].Value);
            ////TxtAutorizacionP.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NombreAutorizacion"].Value);
            TxtDocumentoP.Enabled = false;
            //TxtNombresP.Enabled = false;
            //TxtnombreEmpresa.Enabled = false;
            //TxtNit.Enabled = false;
            //TxtPlaca3P.Enabled = false;
            ////DtmFechaInicio.Enabled = false;
            ////TxtAutorizacionP.Enabled = false;
        }

        private void BtnActualizar_Click_2(object sender, EventArgs e)
        {
            try
            {
                string Rta = "";


                Rta = MAutorizado.ActualizarAutorizado(TxtDocumentoP.Text.Trim(), Convert.ToInt32(cboAutorizaciones.SelectedValue.ToString()), TxtNombresP.Text, TxtnombreEmpresa.Text, TxtNit.Text, DtmFechaInicio.Text, DtmFechaFin.Text, txtTelefono.Text, txtCorreo.Text, txtPlaca1p.Text, txtPlaca2p.Text, TxtPlaca3P.Text, txtPlaca4.Text);

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Datos Actualizados Correctamente");
                    ListarAutorizado();

                }
                else
                {
                    this.MensajeError(Rta);
                }
            }




            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en el momento de actualizar el registro" + ex.Message);
            }
        }
    }
}
