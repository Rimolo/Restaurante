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
    public partial class frm_listaRoles : Form
    {
        Roles objRoles = new Roles();

        public frm_listaRoles()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_roles roles = new frm_roles();
            roles.accion = "Insertar";
            roles.Show();
           
        }

        private void frm_listaRoles_Load(object sender, EventArgs e)
        {
            this.carga_lista_roles();
        }

        private void carga_lista_roles()
        {
            try
            {
                dgv_roles.AutoGenerateColumns = false;
                dgv_roles.DataSource = objRoles.carga_roles().Tables[0];
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_roles();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoRol.Text = "";
            txt_nombreRol.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objRoles.codigo = null;
            objRoles.nombre = null;
            if (txt_codigoRol.Text != "")
            {
                objRoles.codigo = txt_codigoRol.Text;
                   
            }
            else if(txt_nombreRol.Text != "")
            {
                objRoles.nombre = txt_nombreRol.Text;
            }
            
            try
            {
                dgv_roles.AutoGenerateColumns = false;
                dgv_roles.DataSource = objRoles.carga_roles_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_roles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_roles roles = new frm_roles();
                roles.accion = "Editar";
                roles.codigo = dgv_roles.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                roles.ShowDialog();
            }
           
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_roles.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            objRoles.eliminar_Rol(codigo);
            try
            {
                dgv_roles.AutoGenerateColumns = false;
                dgv_roles.DataSource = objRoles.carga_roles().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
