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
    public partial class frm_listaUsuarios : Form
    {
        Usuarios objUsuarios = new Usuarios();
        public frm_listaUsuarios()
        {
            InitializeComponent();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Usuarios();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {

            txt_codigoUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_nickname.Text = "";
            txt_privilegios.Text = "";
            
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            string privilegio = "ninguno";
            if (txt_codigoUsuario.Text != "")
            {
                objUsuarios.codigo = txt_codigoUsuario.Text;

            }
            else if (txt_nombreUsuario.Text != "")
            {
                objUsuarios.nombre = txt_nombreUsuario.Text;
            }
            else if (txt_nickname.Text != "")
            {
                objUsuarios.login = txt_nickname.Text;
            }
            else if (txt_privilegios.Text != "")
            {
                privilegio = txt_privilegios.Text;
            }
           
            try
            {
                dgv_usuarios.AutoGenerateColumns = false;
                dgv_usuarios.DataSource = objUsuarios.carga_usuarios_especificos(privilegio).Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios  = new frmUsuarios();
            usuarios.accion = "Insertar";
            usuarios.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_usuarios.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objUsuarios.eliminar_usuario(codigo);
                try
                {
                    dgv_usuarios.AutoGenerateColumns = false;
                    dgv_usuarios.DataSource = objUsuarios.carga_usuarios().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void frm_listaUsuarios_Load(object sender, EventArgs e)
        {
            this.carga_lista_Usuarios();
        }

        private void carga_lista_Usuarios()
        {
            try
            {
                dgv_usuarios.AutoGenerateColumns = false;
                dgv_usuarios.DataSource = objUsuarios.carga_usuarios().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmUsuarios usuarios = new frmUsuarios();
                usuarios.accion = "Editar";
                usuarios.codigo = dgv_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                usuarios.ShowDialog();
            }
        }
    }
}

