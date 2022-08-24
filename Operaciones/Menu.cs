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
using Operaciones.Autorizaciones;
using Operaciones.Consignaciones;
using Operaciones.Facturacion;
using Operaciones.Seguridad;

namespace Operaciones
{
    public partial class Menu : Form
    {

        public string Nombre;
        public string Cargo;
        public bool Estado;
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {

            PanelSubMenu.Visible = false;
            PanelSubMenu2.Visible = false;
            PanelSubMenu3.Visible = false;
            PanelSubMenu4.Visible = false;
            PanelSubMenu5.Visible = false;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            PanelTitulo.Visible = false;
            LblConsignaciones.Visible = false;


        }

        private void hideSubmenu()
        {
            if (PanelSubMenu.Visible == true)
                PanelSubMenu.Visible = false;
            if (PanelSubMenu2.Visible == true)
                PanelSubMenu2.Visible = false;
            if (PanelSubMenu3.Visible == true)
                PanelSubMenu3.Visible = false;
            if (PanelSubMenu4.Visible == true)
                PanelSubMenu4.Visible = false;
            if (PanelSubMenu5.Visible == true)
                PanelSubMenu5.Visible = false;

        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        private void AbrirFormularioHijo(Form FormularioHijo)
        {
            if (activeform != null)

            activeform.Close();
            activeform = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelFormulario.Controls.Add(FormularioHijo);
            PanelFormulario.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();


        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu);
        }
        private Form activeform = null;

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAnularFactura());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = true;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmResolucion());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = true;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmPrincipal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAutorizados_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAutorizado());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = true;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;

        }


        private void BtnReporteDatafonos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFacManuales());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = true;
            LblConsignaciones.Visible = false;
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            if (this.Cargo.ToString() == "AUXILIAR DE COORDINACION")
            {
                showSubMenu(PanelSubMenu);
                BtnFacturacion.Enabled = true;
                BtnAnulaciones.Enabled = false;
                BtnResoluciones.Enabled = false;
                BtnReportes.Enabled = false;
                BtnSaldoEnLinea.Enabled = false;
                BtnReportePatios.Enabled = false;
                BtnAutorizados.Enabled = false;
                BtnActualizarFechaCorte.Enabled = false;
                BtnConsignaciones.Enabled = true;
                
            }
            else if ((this.Cargo.ToString() != "ADMINISTRADOR") || (this.Cargo.ToString() != "CONTROL INTERNO"))
            {
                showSubMenu(PanelSubMenu);
                BtnFacturacion.Enabled = true;
                BtnAnulaciones.Enabled = true;
                BtnResoluciones.Enabled = true;
                BtnReportes.Enabled = true;
                BtnSaldoEnLinea.Enabled = true;
                BtnReportePatios.Enabled = true;
                BtnAutorizados.Enabled = true;
                BtnActualizarFechaCorte.Enabled = true;
                BtnConsignaciones.Enabled = true;
            }

            else
            {
                showSubMenu(PanelSubMenu);
                BtnFacturacion.Enabled = true;
                BtnAnulaciones.Enabled = true;
                BtnResoluciones.Enabled = true;
                BtnReportes.Enabled = true;
                BtnSaldoEnLinea.Enabled = true;
                BtnReportePatios.Enabled = true;
                BtnAutorizados.Enabled = true;
                BtnActualizarFechaCorte.Enabled = true;
                BtnConsignaciones.Enabled = true;
            }



        }

        private void BtnAnulaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAnularFactura());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = true;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;
            LblCopiaBd.Visible = false;
        }

        private void BtnResoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmResolucion());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = true;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;
            LblCopiaBd.Visible = false;
        }

        private void BtnFacManuales_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFacManuales());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = true;
            LblConsignaciones.Visible = false;
            LblCopiaBd.Visible = false;
        }

        private void BtnReportes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu2);
        }

        private void BtnSaldoEnLinea_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new FrmSaldoEnLinea());
            //hideSubmenu();
            //PanelTitulo.Visible = true;
            //LblAnulaciones.Visible = false;
            //LblAutorizados.Visible = false;
            //LblReportePatios.Visible = false;
            //LblResoluciones.Visible = false;
            //LblSaldoEnLinea.Visible = false;
            //LblSaldoEnLinea.Visible = true;
            //LblFacManuales.Visible = false;
        }

        private void BtnReportePatios_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new FrmReportePatios());
            //hideSubmenu();
            //PanelTitulo.Visible = true;
            //LblAnulaciones.Visible = false;
            //LblAutorizados.Visible = false;
            //LblReportePatios.Visible = true;
            //LblResoluciones.Visible = false;
            //LblSaldoEnLinea.Visible = false;
            //LblFacManuales.Visible = false;
        }

        private void BtnReporteDatafonos_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAutorizados_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu3);
        }

        private void BtnActualizarFechaCorte_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAutorizado());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = true;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;
            LblCopiaBd.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (this.Cargo.ToString() == "AUXILIAR DE COORDINACION")
            {
                BtnFacturacion.Enabled = true; 
                BtnAnulaciones.Enabled = false;
                BtnResoluciones.Enabled = false;
                BtnReportes.Enabled = false;
                BtnSaldoEnLinea.Enabled = false;
                BtnReportePatios.Enabled = false;
                BtnAutorizados.Enabled = false;
                BtnActualizarFechaCorte.Enabled = false;
                BtnConsignaciones.Enabled = true;
            }

            else if ((this.Cargo.ToString() != "ADMINISTRADOR") && (this.Cargo.ToString() != "CONTROL INTERNO"))
            {
                BtnFacturacion.Enabled = false;
                BtnResoluciones.Enabled = false;
                BtnAnulaciones.Enabled = false;
                BtnReportes.Enabled = true;
                BtnSaldoEnLinea.Enabled = false;
                BtnReportePatios.Enabled = true;
                BtnAutorizados.Enabled = false;
                BtnActualizarFechaCorte.Enabled = false;
            }

            else
            {
                BtnFacturacion.Enabled = true;
                BtnResoluciones.Enabled = true;
                BtnAnulaciones.Enabled = true;
                BtnReportes.Enabled = true;
                BtnSaldoEnLinea.Enabled = true;
                BtnReportePatios.Enabled = true;
                BtnAutorizados.Enabled = true;
                BtnActualizarFechaCorte.Enabled = true;
            }

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnConsignaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu4);
        }

        private void BtnActConsignaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsignaciones());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = true;
            LblCopiaBd.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu5);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new txtRuta());
            hideSubmenu();
            PanelTitulo.Visible = true;
            LblAnulaciones.Visible = false;
            LblAutorizados.Visible = false;
            LblReportePatios.Visible = false;
            LblResoluciones.Visible = false;
            LblSaldoEnLinea.Visible = false;
            LblFacManuales.Visible = false;
            LblConsignaciones.Visible = false;
            LblCopiaBd.Visible = true;
        }
    }
}
