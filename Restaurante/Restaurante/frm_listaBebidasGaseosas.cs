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
    public partial class frm_listaBebidasGaseosas : Form
    {
        Gaseosas obj_gaseosas = new Gaseosas();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_listaBebidasGaseosas()
        {
            InitializeComponent();
        }

        private void dgv_bebidaGaseosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmBebidasGaseosas gaseosas = new frmBebidasGaseosas();
                gaseosas.accion = "Editar";
                gaseosas.nick = _nick;
                gaseosas.codigo = dgv_bebidaGaseosa.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                gaseosas.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_listaBebidasGaseosas_Load(object sender, EventArgs e)
        {
            this.carga_lista_Gaseosas();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Gaseosas();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoBebidaG.Text = "";
            txt_nombreBebidaG.Text = "";
            txt_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_gaseosas.codBebidaGas = null;
            obj_gaseosas.nombre = null;
            obj_gaseosas.codRestaurante = null;

            if (txt_codigoBebidaG.Text != "")
            {
                obj_gaseosas.codBebidaGas = txt_codigoBebidaG.Text;
            }
            else if (txt_nombreBebidaG.Text != "")
            {
                obj_gaseosas.nombre = txt_nombreBebidaG.Text;
            }
            else if (txt_restaurante.Text != "")
            {
                obj_gaseosas.codRestaurante = txt_restaurante.Text;
            }

            try
            {
                dgv_bebidaGaseosa.AutoGenerateColumns = false;
                dgv_bebidaGaseosa.DataSource = obj_gaseosas.carga_Gaseosas_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frmBebidasGaseosas gaseosas = new frmBebidasGaseosas();
            gaseosas.accion = "Insertar";
            gaseosas.nick = _nick;
            gaseosas.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_bebidaGaseosa.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_gaseosas.eliminar_Gaseosas(codigo);
            try
            {
                dgv_bebidaGaseosa.AutoGenerateColumns = false;
                dgv_bebidaGaseosa.DataSource = obj_gaseosas.carga_Gaseosas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void carga_lista_Gaseosas()
        {
            try
            {
                dgv_bebidaGaseosa.AutoGenerateColumns = false;
                dgv_bebidaGaseosa.DataSource = obj_gaseosas.carga_Gaseosas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
