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
    public partial class frm_listaTecnologia : Form
    {
        Tecnologia obj_tecnologia = new Tecnologia();

        public frm_listaTecnologia()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_tecnologia tecnologia = new frm_tecnologia();
                tecnologia.accion = "Editar";
                tecnologia.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                tecnologia.ShowDialog();
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_tecnologia tecnologia = new frm_tecnologia();
            tecnologia.accion = "Insertar";
            tecnologia.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_tecnologia.eliminar_Tecno(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_tecnologia.carga_Tecno().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_tecnologia.codTecnologia = null;
            obj_tecnologia.nombre = null;
            obj_tecnologia.codRestaurante = null;

            if (txt_codigoArticulo.Text != "")
            {
                obj_tecnologia.codTecnologia = txt_codigoArticulo.Text;
            }
            else if (txt_nombreArticulo.Text != "")
            {
                obj_tecnologia.nombre = txt_nombreArticulo.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                obj_tecnologia.codRestaurante = txt_restaurante.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_tecnologia.carga_Tecno_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Comestibles();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoArticulo.Text = "";
            txt_nombreArticulo.Text = "";
            txt_restaurante.Text = "";
        }

        private void frm_listaTecnologia_Load(object sender, EventArgs e)
        {
            this.carga_lista_Comestibles();
        }

        private void carga_lista_Comestibles()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_tecnologia.carga_Tecno().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
