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
    public partial class frmListaLicores : Form
    {
        Licores obj_licores = new Licores();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frmListaLicores()
        {
            InitializeComponent();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Licores();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoBebidaL.Text = "";
            txt_nombreBebidaL.Text = "";
            txt_restaurante.Text = "";
            txt_nacionalidad.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_licores.codLicor = null;
            obj_licores.nombre = null;
            obj_licores.codRestaurante = null;
            obj_licores.codPais = null;

            if (txt_codigoBebidaL.Text != "")
            {
                obj_licores.codLicor = txt_codigoBebidaL.Text;
            }
            else if (txt_nombreBebidaL.Text != "")
            {
                obj_licores.nombre = txt_nombreBebidaL.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                obj_licores.codRestaurante = txt_restaurante.Text;
            }
            else if (txt_nacionalidad.Text != "")
            {
                obj_licores.codPais = txt_nacionalidad.Text;
            }

            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_licores.carga_Licores_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frmLicores licores = new frmLicores();
            licores.accion = "Insertar";
            licores.nick = _nick;
            licores.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_licores.eliminar_Licores(codigo);
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_licores.carga_Licores().Tables[0];

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
                frmLicores licores = new frmLicores();
                licores.accion = "Editar";
                licores.nick = _nick;
                licores.codigo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                licores.ShowDialog();
            }
        }

        private void frmListaLicores_Load(object sender, EventArgs e)
        {
            this.carga_lista_Licores();
        }

        private void carga_lista_Licores()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = obj_licores.carga_Licores().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
