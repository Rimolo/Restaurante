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
    public partial class frm_listaComestibles : Form
    {
        Comestibles obj_comestibles = new Comestibles();

        public frm_listaComestibles()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_comestible comestible = new frm_comestible();
                comestible.accion = "Editar";
                comestible.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                comestible.ShowDialog();
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Comestibles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoComestible.Text = "";
            txt_nombreComestible.Text = "";
            txt_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_comestibles.codComestible = null;
            obj_comestibles.nombre = null;
            obj_comestibles.codRestaurante = null;

            if (txt_codigoComestible.Text != "")
            {
                obj_comestibles.codComestible = txt_codigoComestible.Text;
            }
            else if (txt_nombreComestible.Text != "")
            {
                obj_comestibles.nombre = txt_nombreComestible.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                obj_comestibles.codRestaurante = txt_restaurante.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_comestibles.carga_Comestibles_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_comestible comestibles = new frm_comestible();
            comestibles.accion = "Insertar";
            comestibles.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_comestibles.eliminar_Comestibles(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_comestibles.carga_Comestibles().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_listaComestibles_Load(object sender, EventArgs e)
        {
            this.carga_lista_Comestibles();
        }

        private void carga_lista_Comestibles()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_comestibles.carga_Comestibles().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
