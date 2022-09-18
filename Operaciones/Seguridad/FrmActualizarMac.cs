using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones.Seguridad
{
    public partial class FrmActualizarMac : Form
    {
        public FrmActualizarMac()
        {
            InitializeComponent();
        }

        # region Funciones

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 



        public void ListadoModulosConfiguracion()
        {
            dtListadoModulos.DataSource = MSeguridad.ListarConfiguracion();
            if (dtListadoModulos.Rows.Count < 1)
            {
                MessageBox.Show("No se pudo obtener la lista de las base de datos");
            }
            else
            {
                dtListadoModulos.DataSource = MSeguridad.ListarConfiguracion();
            }
        }

        public void ActualizarDatosConfiguracion()
        {
            if (txtMac.Text == string.Empty)
            {
                this.MensajeError("Es necesario que ingrese la nueva Mac");
                txtMac.Focus();
            }
            else
            {
                string Rta = MSeguridad.ActualizarDatosConfiguracion(txtModulo.Text, txtIp.Text, txtMac.Text, txtCarril.Text, txtTipoModulo.Text);
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Datos Actualizados Correctamente");
                    ListadoModulosConfiguracion();
                }
                else
                {
                    MensajeError("Ocurrió un error en el momento de actualizar los datos");
                }
                
            }
        }
        #endregion


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmActualizarMac_Load(object sender, EventArgs e)
        {
            ListadoModulosConfiguracion();
        }

        private void dtListadoModulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txtModulo.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["IdModulo"].Value);
            txtIdEstacionamiento.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["IdEstacionamiento"].Value);
            txtIp.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["IP"].Value);
            txtMac.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["Mac"].Value);
            txtCarril.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["Carril"].Value);
            txtTipoModulo.Text = Convert.ToString(dtListadoModulos.CurrentRow.Cells["IdTipoModulo"].Value);
            cboEstado.SelectedText = Convert.ToString(dtListadoModulos.CurrentRow.Cells["Estado"].Value);
            txtModulo.Enabled = false;
            txtIdEstacionamiento.Enabled = false;
            cboEstado.Enabled = false;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatosConfiguracion();
        }


    }
}
