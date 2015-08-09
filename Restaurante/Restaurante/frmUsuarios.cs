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
    public partial class frmUsuarios : Form
    {
        Usuarios objUsuarios = new Usuarios();

        private string _accion;

        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_login.Text = "";
            txt_contraseña.Text = "";
            txt_confirmarContraseña.Text = "";
            txt_codigo.Text = "";
            txt_apellido2.Text = "";
            txt_apellido1.Text = "";
            msk_telefonocelular.Text = "";
            msk_telfFijo.Text = "";
            if (chk_administradorCuentas.Checked)
            {
                chk_administradorCuentas.Checked = false;
            }
            if (chk_administradorRestaurante.Checked)
            {
                chk_administradorRestaurante.Checked = false;
                rb_nf.Visible = false;
                rb_ps.Visible = false;
                rb_ta.Visible = false;
                rb_ps.Checked = false;
                rb_ps.Checked = false;
                rb_ta.Checked = false;
            }
            if (chk_administradorSeguridad.Checked)
            {
                chk_administradorSeguridad.Checked = false;
            }
            if (chk_administradorSistema.Checked)
            {
                chk_administradorSistema.Checked = false;
            }
            if (chk_cambiarContraseña.Checked)
            {
                chk_cambiarContraseña.Checked = false;
                b_cambioContraseña.Enabled = false;
            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba un nombre al Usuario", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_apellido1))
            {
                MessageBox.Show("Por favor escriba el apellido", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido1.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_apellido2))
            {
                MessageBox.Show("Por favor escriba el apellido", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido2.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_login))
            {
                MessageBox.Show("Por favor escriba un nombre al Login", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (!cls_validacion.validar(chk_administradorCuentas) && !cls_validacion.validar(chk_administradorSistema) && !cls_validacion.validar(chk_administradorSeguridad) && !cls_validacion.validar(chk_administradorRestaurante))
            {
                MessageBox.Show("Seleccione al menos un privilegio", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_accion == "Insertar") {
                if (!cls_validacion.validar(txt_contraseña))
                {
                    MessageBox.Show("Por favor escriba una contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contraseña.Focus();
                    return;
                }
                if (!cls_validacion.validar(txt_confirmarContraseña))
                {
                    MessageBox.Show("Por favor confirme la contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_confirmarContraseña.Focus();
                    return;
                }

            }

            if (!txt_contraseña.Text.Equals(txt_confirmarContraseña.Text)) {
                MessageBox.Show("Las contraseñas no coinciden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmarContraseña.Focus();
                return;
            }
            if (accion.Equals("Insertar")) {
                objUsuarios.codigoR = "";
            }
            
            if (rb_nf.Checked) {
                objUsuarios.codigoR = objUsuarios.cargar_cod_res("Notte di Fuoco");
            }
            if (rb_ps.Checked)
            {
                objUsuarios.codigoR = objUsuarios.cargar_cod_res("Piccola Stella");
            }
            if (rb_ta.Checked)
            {
                objUsuarios.codigoR = objUsuarios.cargar_cod_res("Turin Anivo");
            }
            objUsuarios.codigo = txt_codigo.Text.Replace(" ", "");
            objUsuarios.nombre = txt_nombre.Text;
            objUsuarios.apellido1 = txt_apellido1.Text;
            objUsuarios.apellido2 = txt_apellido2.Text;
            objUsuarios.login = txt_login.Text;
            if (chk_cambiarContraseña.Checked || accion.Equals("Insertar")) {
                objUsuarios.contraseña = txt_contraseña.Text;
            }

            if (chk_administradorCuentas.Checked)
            {
                objUsuarios.adminCuentas = true;

            }
            else {
                objUsuarios.adminCuentas = false;
            }
            if (chk_administradorRestaurante.Checked)
            {
                objUsuarios.adminRestaurante = true;
            }
            else
            {
                objUsuarios.adminRestaurante = false;
            }
            if (chk_administradorSeguridad.Checked)
            {
                objUsuarios.adminSeguridad = true;
            }
            else
            {
                objUsuarios.adminSeguridad = false;
            }
            if (chk_administradorSistema.Checked)
            {
                objUsuarios.adminSistema = true;
            }
            else
            {
                objUsuarios.adminSistema = false;
            }
            int tel = 0;
            string text = msk_telfFijo.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                objUsuarios.telfijo = 0;
            }
            else {
                objUsuarios.telfijo = tel;
            }
            text = msk_telefonocelular.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                objUsuarios.celular = 0;
            }
            else
            {
                objUsuarios.celular = tel;
            }
           
            if (objUsuarios.guardar_usuario(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objUsuarios.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objUsuarios.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Usuario insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
        }

        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objUsuarios.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objUsuarios.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }
        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_cambioContraseña_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_contraseña))
            {
                MessageBox.Show("Por favor escriba una contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contraseña.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_confirmarContraseña))
            {
                MessageBox.Show("Por favor confirme la contraseña", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmarContraseña.Focus();
                return;
            }
            if (!txt_contraseña.Text.Equals(txt_confirmarContraseña.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmarContraseña.Focus();
                return;
            }
            objUsuarios.contraseña = txt_contraseña.Text;
            objUsuarios.codigo = txt_codigo.Text.Replace(" ", "");
            if (objUsuarios.guardar_usuario(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objUsuarios.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objUsuarios.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Contraseña cambiada con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }

        }

        private void chk_cambiarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cambiarContraseña.Checked && _accion.Equals("Editar"))
            {
                b_cambioContraseña.Enabled = true;
                txt_contraseña.Enabled = true;
                txt_confirmarContraseña.Enabled = true;
            }
            else {
                b_cambioContraseña.Enabled = false;
                txt_contraseña.Enabled = false;
                txt_confirmarContraseña.Enabled = false;
            }
        }

        private void carga_info()
        {
            objUsuarios.carga_info_usuario(_codigo);
            if (objUsuarios.nombre != "Error")
            {
                txt_codigo.Text =_codigo;
                txt_nombre.Text = objUsuarios.nombre;
                txt_apellido1.Text = objUsuarios.apellido1;
                txt_apellido2.Text = objUsuarios.apellido2;
                txt_login.Text = objUsuarios.login;
                msk_telfFijo.Text = objUsuarios.telfijo.ToString();
                msk_telefonocelular.Text = objUsuarios.celular.ToString();
                if (objUsuarios.adminCuentas)
                {
                    chk_administradorCuentas.Checked = true;

                }
                if (objUsuarios.adminSistema)
                {
                    chk_administradorSistema.Checked = true;

                }
                if (objUsuarios.adminRestaurante)
                {
                    chk_administradorRestaurante.Checked = true;
                }

                if (objUsuarios.adminSeguridad)
                {
                    chk_administradorSeguridad.Checked = true;

                }
                
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            b_cambioContraseña.Enabled = false;
            if (_accion == "Editar")
            {
                txt_contraseña.Enabled = false;
                txt_confirmarContraseña.Enabled = false;
                carga_info();
            }
        }

        private void chk_administradorRestaurante_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_administradorRestaurante.Checked)
            {
                rb_nf.Visible = true;
                rb_ps.Visible = true;
                rb_ta.Visible = true;
                rb_ps.Checked = true;
            }
            else {
                rb_nf.Visible = false;
                rb_ps.Visible = false;
                rb_ta.Visible = false;
                rb_ps.Checked = false;
                rb_ps.Checked = false;
                rb_ta.Checked = false;
            }
        }
    }
}
