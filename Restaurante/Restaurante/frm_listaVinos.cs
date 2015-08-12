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
    public partial class frm_listaVinos : Form
    {
        Vinos obj_vinos = new Vinos();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }
        public frm_listaVinos()
        {
            InitializeComponent();
        }

        private void frm_listaVinos_Load(object sender, EventArgs e)
        {
            this.carga_lista_Vinos();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Vinos();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoBebidaV.Text = "";
            txt_nombreBebidaV.Text = "";
            txt_año.Text = "";
            txt_precio.Text = "";
            txt_nacionalidad.Text = "";
            txt_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_vinos.codVino = null;
            obj_vinos.nombre = null;
            obj_vinos.codRestaurante = null;
            obj_vinos.precioU = 0;
            obj_vinos.precioB = 0;
            obj_vinos.cosecha = 0;
            obj_vinos.codPais = null;

            if (txt_codigoBebidaV.Text != "")
            {
                obj_vinos.codVino = txt_codigoBebidaV.Text;
            }
            else if (txt_nombreBebidaV.Text != "")
            {
                obj_vinos.nombre = txt_nombreBebidaV.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                obj_vinos.codRestaurante = txt_restaurante.Text;
            }
            else if (txt_año.Text != "")
            {
                obj_vinos.cosecha = Convert.ToInt32(txt_año.Text);
            }
            else if (txt_nacionalidad.Text != "")
            {
                obj_vinos.codPais = txt_nacionalidad.Text;
            }
            else if (txt_precio.Text != "")
            {
                obj_vinos.precioU = Convert.ToDecimal(txt_precio.Text);
                obj_vinos.precioB = Convert.ToDecimal(txt_precio.Text);
            }           

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_vinos.carga_Vinos_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_vinos vinos = new frm_vinos();
            vinos.accion = "Insertar";
            vinos.nick = _nick;
            vinos.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_vinos.eliminar_Vinos(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_vinos.carga_Vinos().Tables[0];
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
                frm_vinos vinos = new frm_vinos();
                vinos.accion = "Editar";
                vinos.nick = _nick;
                vinos.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                vinos.ShowDialog();
            }
        }

        private void carga_lista_Vinos()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_vinos.carga_Vinos().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
