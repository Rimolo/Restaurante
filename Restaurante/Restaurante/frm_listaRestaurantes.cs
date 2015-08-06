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
    public partial class frm_listaRestaurantes : Form
    {
        Restaurantes objRestaurante = new Restaurantes();
        public frm_listaRestaurantes()
        {
            InitializeComponent();
        }

        private void frm_listaRestaurantes_Load(object sender, EventArgs e)
        {
            this.cargar_lista_restaurantes();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.cargar_lista_restaurantes();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoRestaurante.Text = "";
            txt_nombreRestaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            
            if (txt_codigoRestaurante.Text != "")
            {
                objRestaurante.codigo = txt_codigoRestaurante.Text;

            }
            else if (txt_nombreRestaurante.Text != "")
            {
                objRestaurante.nombre = txt_codigoRestaurante.Text;
            }
            
            try
            {
                dgv_restaurante.AutoGenerateColumns = false;
                dgv_restaurante.DataSource = objRestaurante.carga_rest_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_Restaurantes rest = new frm_Restaurantes();
            rest.accion = "Insertar";
            rest.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_restaurante.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objRestaurante.eliminar_rest(codigo);
                try
                {
                    dgv_restaurante.AutoGenerateColumns = false;
                    dgv_restaurante.DataSource = objRestaurante.carga_rest().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void dgv_restaurante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_Restaurantes rest = new frm_Restaurantes();
                rest.accion = "Editar";
                rest.codigo = dgv_restaurante.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                rest.ShowDialog();
            }
        }

        private void cargar_lista_restaurantes()
        {
            try
            {
                dgv_restaurante.AutoGenerateColumns = false;
                dgv_restaurante.DataSource = objRestaurante.carga_rest().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
