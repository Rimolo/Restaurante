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
    public partial class frm_listaMarcas : Form
    {
        Marcas obj_marcas = new Marcas();

        public frm_listaMarcas()
        {
            InitializeComponent();
        }

        private void frm_listaMarcas_Load(object sender, EventArgs e)
        {
            this.carga_lista_marcas();
        }
        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_marcas();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoMarca.Text = "";
            txt_nombreMarca.Text = "";
            txt_nacionalidad.Text = "";
            txt_empresa.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_marcas.codMarca = null;
            obj_marcas.nombreMarca = null;
            obj_marcas.codPais = null;
            obj_marcas.nombreEmp = null;

            if (txt_codigoMarca.Text != "")
            {
                obj_marcas.codMarca = txt_codigoMarca.Text;
            }
            else if (txt_nombreMarca.Text != "")
            {
                obj_marcas.nombreMarca = txt_nombreMarca.Text;
            }
            else if (txt_nacionalidad.Text != "")
            {
                obj_marcas.codPais = txt_nacionalidad.Text;
            }
            else if (txt_empresa.Text != "")
            {
                obj_marcas.nombreEmp = txt_empresa.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_marcas.carga_Marcas_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_marcas marcas = new frm_marcas();
            marcas.accion = "Insertar";
            marcas.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_marcas.eliminar_Marca(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_marcas.carga_Marca().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void carga_lista_marcas()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_marcas.carga_Marca().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_listaMarcas_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_marcas marcas = new frm_marcas();
                marcas.accion = "Editar";
                marcas.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                marcas.ShowDialog();
            }
        }
    }
}
