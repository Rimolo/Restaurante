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
    public partial class frm_listaUnidadesMedida : Form
    {
        Unidades objUnidades = new Unidades();
        public frm_listaUnidadesMedida()
        {
            InitializeComponent();
        }

        private void frm_listaUnidadesMedida_Load(object sender, EventArgs e)
        {
            carga_lista_unidades();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            carga_lista_unidades();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoUnidadMedida.Text = "";
            txt_detalleUnidadMedida.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objUnidades.codigo = null;
            objUnidades.detalle = null;
            if (txt_codigoUnidadMedida.Text != "")
            {
                objUnidades.codigo = txt_codigoUnidadMedida.Text;

            }
            else if (txt_detalleUnidadMedida.Text != "")
            {
                objUnidades.detalle = txt_detalleUnidadMedida.Text;
            }

            try
            {
                dgv_unidadesMedida.AutoGenerateColumns = false;
                dgv_unidadesMedida.DataSource = objUnidades.carga_unidades_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_unidadesMedida unidades = new frm_unidadesMedida();
            unidades.accion = "Insertar";
            unidades.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_unidadesMedida.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            objUnidades.eliminar_unidades(codigo);
            try
            {
                dgv_unidadesMedida.AutoGenerateColumns = false;
                dgv_unidadesMedida.DataSource = objUnidades.carga_unidades().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_unidadesMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_unidadesMedida unidades = new frm_unidadesMedida();
            unidades.accion = "Editar";
            unidades.codigo = dgv_unidadesMedida.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            unidades.ShowDialog();
        }

        private void carga_lista_unidades()
        {
            try
            {
                dgv_unidadesMedida.AutoGenerateColumns = false;
                dgv_unidadesMedida.DataSource = objUnidades.carga_unidades().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
