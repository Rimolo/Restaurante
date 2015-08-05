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
    public partial class frm_roles : Form
    {
        Roles objRoles = new Roles();

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

        public frm_roles()
        {
            InitializeComponent();
        }

        private void frm_roles_Load_1(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombreRol))
            {
                MessageBox.Show("Por favor escriba un nombre al Rol", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreRol.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcionRol))
            {
                MessageBox.Show("Por favor escriba una descripcion al Rol", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreRol.Focus();
                return;
            }
            objRoles.codigo = txt_codigoRol.Text;
            objRoles.nombre = txt_nombreRol.Text;
            objRoles.descripcion = txt_descripcionRol.Text;
            if (objRoles.guardar_rol(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objRoles.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objRoles.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Rol insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ds1 = objRoles.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objRoles.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigoRol.Text = pre+valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_descripcionRol.Text = "";
            txt_nombreRol.Text = "";
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carga_info()
        {
            objRoles.carga_info_Roles(_codigo);
            if (objRoles.nombre != "Error")
            {
                txt_nombreRol.Text = objRoles.nombre;
                txt_descripcionRol.Text = objRoles.descripcion.ToString();
                txt_codigoRol.Text= _codigo.ToString();
            }
        }

    }
}
