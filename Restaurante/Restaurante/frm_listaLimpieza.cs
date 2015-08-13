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
    public partial class frm_listaLimpieza : Form
    {
        Limpieza objLimpieza = new Limpieza();

        public frm_listaLimpieza()
        {
            InitializeComponent();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            objLimpieza.eliminar_limpieza(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = objLimpieza.carga_limpieza().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_limpiezaHigiene limpieza = new frm_limpiezaHigiene();
                limpieza.accion = "Editar";
                limpieza.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                limpieza.ShowDialog();
            }
        }

        private void frm_listaLimpieza_Load(object sender, EventArgs e)
        {
            carga_lista_Limpieza();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            carga_lista_Limpieza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoArticulo.Text = "";
            txt_nombreArticulo.Text = "";
            txt_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objLimpieza.codLimpieza = null;
            objLimpieza.nombre = null;
            objLimpieza.codRestaurante = null;

            if (txt_codigoArticulo.Text != "")
            {
                objLimpieza.codLimpieza = txt_codigoArticulo.Text;
            }
            else if (txt_nombreArticulo.Text != "")
            {
                objLimpieza.nombre = txt_nombreArticulo.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                objLimpieza.codRestaurante = txt_restaurante.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = objLimpieza.carga_limpieza_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_limpiezaHigiene comestibles = new frm_limpiezaHigiene();
            comestibles.accion = "Insertar";
            comestibles.Show();
        }
        private void carga_lista_Limpieza()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = objLimpieza.carga_limpieza().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
