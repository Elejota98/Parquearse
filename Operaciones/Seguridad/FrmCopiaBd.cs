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

namespace Operaciones.Seguridad
{
    public partial class FrmCobiaBd : Form
    {
        public FrmCobiaBd()
        {
            InitializeComponent();
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRutaArchivo.Text == string.Empty)
            {
               this.MensajeError("Falta establecer la ruta del archivo");
            }
            else if (txtNombreCopia.Text == string.Empty)
            {
                this.MensajeError("Falta establecer el nombre del archivo");
            }
            else
            {
                string Rta = "";
                Rta = MSeguridad.GenerarCopiaBd(txtRutaArchivo.Text, txtNombreCopia.Text,txtBasededatos.Text);
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Copia realizada correctamente");
                }
            }
        }

        private void ListadoBaseDeDatos()
        {

            dtListadoBd.DataSource = MSeguridad.ListarBaseDeDatos();
            if (dtListadoBd.Rows.Count < 1)
            {
                MessageBox.Show("No se pudo obtener la lista de las base de datos");
            }
            else
            {
                dtListadoBd.DataSource = MSeguridad.ListarBaseDeDatos();
            }
        }

        private void txtRuta_Load(object sender, EventArgs e)
        {
            ListadoBaseDeDatos();
        }

        private void dtListadoBd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBasededatos.Text = Convert.ToString(dtListadoBd.CurrentRow.Cells["BASE DE DATOS"].Value);
        }
    }
}
