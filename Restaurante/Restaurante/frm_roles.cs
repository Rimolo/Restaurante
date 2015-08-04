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
    }
}
