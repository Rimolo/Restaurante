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
    public partial class frm_listaMesas : Form
    {
        Mesas obj_mesas = new Mesas();

        public frm_listaMesas()
        {
            InitializeComponent();
        }

        private void frm_listaMesas_Load(object sender, EventArgs e)
        {
            this.carga_lista_Mesas();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Mesas();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoMesa.Text = "";
            txt_nombreMesa.Text = "";
            txt_restaurante.Text = "";
            txt_sillas.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_mesas.codMesa = null;
            obj_mesas.nombre = null;
            obj_mesas.cantSillas = 0;
            obj_mesas.codRestaurante = null;

            if (txt_codigoMesa.Text != "")
            {
                obj_mesas.codMesa = txt_codigoMesa.Text;
            }
            else if (txt_nombreMesa.Text != "")
            {
                obj_mesas.nombre = txt_nombreMesa.Text;
            }
            else if (txt_sillas.Text != "")
            {
                obj_mesas.cantSillas = Convert.ToInt32(txt_sillas.Text);
            }
            else if (txt_restaurante.Text != "")
            {
                obj_mesas.codRestaurante = txt_restaurante.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_mesas.carga_Mesas_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_mesas mesas = new frm_mesas();
            mesas.accion = "Insertar";
            mesas.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_mesas.eliminar_Mesas(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_mesas.carga_Mesas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_mesas mesas = new frm_mesas();
                mesas.accion = "Editar";
                mesas.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                mesas.ShowDialog();
            }
        }

        private void carga_lista_Mesas()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_mesas.carga_Mesas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
