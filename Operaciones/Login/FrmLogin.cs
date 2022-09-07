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

namespace Operaciones.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region Boton cerrar y minimizar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = MLogin.Login(TxtUsuario.Text.Trim(), TxtContraseña.Text.Trim());

                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o clave incorrecta", "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][7]) == false)
                    {
                        MessageBox.Show("Este usuario no se encuentra activo", "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Menu frm = new Menu();
                        frm.Nombre = Convert.ToString(Tabla.Rows[0][1]);
                        frm.Cargo = Convert.ToString(Tabla.Rows[0][4]);
                        frm.Estado = Convert.ToBoolean(Tabla.Rows[0][7]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }   
    }
    }

