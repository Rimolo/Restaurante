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
    public partial class frm_puestos : Form
    {
        Puestos objPuestos = new Puestos();
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

        public frm_puestos()
        {
            InitializeComponent();
        }

        private void frm_puestos_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            cb_rol.Enabled = false;
            if(_accion == "Editar")
            {
                carga_info();
            }

        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba un nombre al Puesto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(rb_externo) && !cls_validacion.validar(rb_interno))
            {
                MessageBox.Show("Por favor seleccione un puesto interno o externo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!cls_validacion.validar(cb_rol))
            {
                MessageBox.Show("Por favor selecccione un rol", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_rol.Focus();
                return;
            }

            objPuestos.codigo = txt_codigo.Text.Replace(" ", "");
            objPuestos.nombre = txt_nombre.Text;
            objPuestos.rol = cb_rol.SelectedValue.ToString();
            
            if (objPuestos.guardar_puesto(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objPuestos.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objPuestos.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Puesto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ds1 = objPuestos.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objPuestos.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_interno_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_interno.Checked) {
                objPuestos.interno = true;
                objPuestos.externo = false;
                if(cb_rol.Items.Count > 0)
                {
                    cb_rol.DataSource = null;
                    //cb_rol.Items.Clear();
                }
                cargar_roles();
                cb_rol.Enabled = true;
            }
        }

        private void rb_externo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_externo.Checked)
            {

                objPuestos.interno = false;
                objPuestos.externo = true;
                if (cb_rol.Items.Count > 0)
                {
                    cb_rol.DataSource = null;
                    //cb_rol.Items.Clear();
                }
                cargar_roles();
                cb_rol.Enabled = true;
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            
            if (rb_externo.Checked)
            {
                rb_externo.Checked = false;
            }
            else {
                rb_interno.Checked = false;
            }
            cb_rol.Enabled = false;
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carga_info()
        {
            objPuestos.carga_info_Puesto(_codigo);
            if (objPuestos.nombre != "Error")
            {
                txt_codigo.Text =_codigo;
                txt_nombre.Text = objPuestos.nombre;
                if (objPuestos.interno)
                {
                    rb_interno.Checked = true;
                    
                }
                else {
                    rb_externo.Checked = true;
                }
                cargar_roles();
                cb_rol.SelectedValue = objPuestos.rol;
            }
        }

        private void cargar_roles()
        {
            try
            {
                DataSet ds;
                ds = objPuestos.cargar_lista_roles();
                cb_rol.DataSource = ds.Tables[0];
                cb_rol.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_rol.ValueMember = ds.Tables[0].Columns["CodRol"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
