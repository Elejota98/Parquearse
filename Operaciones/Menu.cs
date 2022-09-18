﻿using System;
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
using Operaciones.Reportes;

namespace Operaciones
{
    public partial class Menu : Form
    {
        //private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

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
            PanelTitulo.Visible = false;


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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmResolucion());
            hideSubmenu();
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

        }


        private void BtnReporteDatafonos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFacManuales());
            hideSubmenu();
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
            lblTitulo.Text = BtnAnulaciones.Text;
        }

        private void BtnResoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmResolucion());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = BtnResoluciones.Text;
        }

        private void BtnFacManuales_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFacManuales());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = BtnFacManuales.Text;
        }

        private void BtnReportes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu2);
        }

        private void BtnSaldoEnLinea_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSaldoEnLinea());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = BtnSaldoEnLinea.Text;
        }

        private void BtnReportePatios_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new FrmReportePatios());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = BtnReportePatios.Text;
        }

        private void BtnReporteDatafonos_Click_1(object sender, EventArgs e)
        {
            lblTitulo.Text = BtnReporteDatafonos.Text;
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
            lblTitulo.Text = BtnActualizarFechaCorte.Text;
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
            else if ((this.Cargo.ToString() == "AUXILIAR DE SERVICIOS"))
            {
                BtnFacturacion.Enabled = false;
                BtnResoluciones.Enabled = false;
                BtnAnulaciones.Enabled = false;
                BtnReportes.Enabled = true;
                BtnSaldoEnLinea.Enabled = true;
                BtnReportePatios.Enabled = true;
                BtnReporteDatafonos.Enabled = true;
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
            lblTitulo.Text = BtnConsignaciones.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu5);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmCobiaBd());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = btnCopiaBd.Text;
        }

        

        private void PanelLogo_MouseClick(object sender, MouseEventArgs e)
        {
            activeform.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmActualizarMac());
            hideSubmenu();
            PanelTitulo.Visible = true;
            lblTitulo.Text = btnActualizarMac.Text;
        }
        
    }
}
