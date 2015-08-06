using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Restaurante
{
    public partial class frm_login : Form
    {
        List<string> roles = new List<string>();
        Login objLogin = new Login();
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_contraseña.Text = "";
            txt_usuario.Text = "";
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_contraseña.Text = "";
            txt_usuario.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            frm_menuPrincipal menu = new frm_menuPrincipal();
            if (!cls_validacion.validar(txt_usuario))
            {
                MessageBox.Show("Por favor escriba un nombre al Usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_contraseña))
            {
                MessageBox.Show("Por favor escriba una contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contraseña.Focus();
                return;
            }
            objLogin.carga_info_usuario(txt_usuario.Text);
            if (txt_contraseña.Text.Equals(objLogin.contraseña))
            {
                roles.Clear();
                if (objLogin.adminCuentas)
                {
                    roles.Add("administrador de Cuentas");
                }
                if (objLogin.adminRestaurante)
                {
                    roles.Add("administrador de Restaurante");
                }
                if (objLogin.adminSeguridad)
                {
                    roles.Add("administrador de Seguridad");
                }
                if (objLogin.adminSistema)
                {
                    roles.Add("administrador de Sistema");
                }
                if (roles.Count == 1 && roles.Contains("adminRestaurante")) {
                    string nombreR = objLogin.nombre_rest();
                    if (nombreR.Equals("Piccola Stella")) {
                        frm_PiccollaStella ps = new frm_PiccollaStella();
                        ps.Tag = this;
                        ps.Show(this);
                        this.Hide();

                    }
                    else if (nombreR.Equals("Turin Anivo"))
                    {
                        frm_TurinAnivo ta = new frm_TurinAnivo();
                        ta.ShowDialog();
                        this.Hide();

                    }
                    else if (nombreR.Equals("Notte di Fuoco"))
                    {
                        frm_NotteDiFouco nf = new frm_NotteDiFouco();
                        nf.ShowDialog();
                        this.Hide();

                    }
                }

                menu.lista = this.roles;
                menu.Tag = this;
                menu.Show(this);
                txt_contraseña.Text = "";
                this.Hide();



            }
            else {
                MessageBox.Show("Usuario/contraseña incorrecta", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contraseña.Text = "";
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
