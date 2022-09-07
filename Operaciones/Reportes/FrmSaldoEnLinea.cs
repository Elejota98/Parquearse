using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones.Reportes
{
    public partial class FrmSaldoEnLinea : Form
    {
        public FrmSaldoEnLinea()
        {
            InitializeComponent();
        }

        private void FrmSaldoEnLinea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSaldo.P_DetalleSaldos' Puede moverla o quitarla según sea necesario.
            this.P_DetalleSaldosTableAdapter.Fill(this.DataSaldo.P_DetalleSaldos);
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            this.reportViewer1.RefreshReport();
        }
    }
}
