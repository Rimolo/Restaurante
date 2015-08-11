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
    public partial class frm_listaEspecialidades : Form
    {
        Especiales obj_especiales = new Especiales();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_listaEspecialidades()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_especiales especiales = new frm_especiales();
                especiales.accion = "Editar";
                especiales.nick = _nick;
                especiales.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                especiales.ShowDialog();
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_calientes();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoComida.Text = "";
            txt_nombreComida.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_especiales.codEspeciales = null;
            obj_especiales.nombre = null;
            if (txt_codigoComida.Text != "")
            {
                obj_especiales.codEspeciales = txt_codigoComida.Text;

            }
            else if (txt_nombreComida.Text != "")
            {
                obj_especiales.nombre = txt_nombreComida.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_especiales.carga_especiales_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_especiales especiales = new frm_especiales();
            especiales.accion = "Insertar";
            especiales.nick = _nick;
            especiales.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_especiales.eliminar_Especiales(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_especiales.carga_Especiales().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_listaEspecialidades_Load(object sender, EventArgs e)
        {
            this.carga_lista_calientes();
        }

        private void carga_lista_calientes()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_especiales.carga_Especiales().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
