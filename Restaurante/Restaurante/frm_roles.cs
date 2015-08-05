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

        public frm_roles()
        {
            InitializeComponent();
        }

        private void frm_roles_Load_1(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (accion.Equals("Editar"))
            {

            }
        }
        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objRoles.codigo = txt_codigoRol.Text;
            objRoles.nombre = txt_nombreRol.Text;
            objRoles.descripcion = txt_descripcionRol.Text;
            if (objRoles.guardar_rol(_accion))
            {
                MessageBox.Show("Producto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var listaRoles = (frm_listaRoles)Tag;
                listaRoles.Show();
                this.Close();
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
            var listaRoles = (frm_listaRoles)Tag;
            listaRoles.Show();
            this.Close();
        }

        
    }
}
