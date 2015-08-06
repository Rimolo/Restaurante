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
    public partial class frm_listaPuestos : Form
    {
        Puestos objPuestos = new Puestos();
        public frm_listaPuestos()
        {
            InitializeComponent();
        }

        private void frm_listaPuestos_Load(object sender, EventArgs e)
        {
            this.carga_lista_puestos();
        }

        private void carga_lista_puestos()
        {
            try
            {
                dgv_puestos.AutoGenerateColumns = false;
                dgv_puestos.DataSource = objPuestos.carga_puestos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_puestos puestos = new frm_puestos();
            puestos.accion = "Insertar";
            puestos.Show();
           

        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_puestos();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoRestaurante.Text = "";
            txt_nombreRestaurante.Text = "";
            if (rb_externo.Checked)
            {
                rb_externo.Checked = false;
                
            }
            if (rb_interno.Checked)
            {
                rb_interno.Checked = false;
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            string nombreRest = "ninguno";
            string codRest = "ninguno";
            if (txt_codigoRestaurante.Text != "")
            {
                objPuestos.codigo = txt_codigoRestaurante.Text;

            }
            else if (txt_nombreRestaurante.Text != "")
            {
                objPuestos.nombre = txt_nombreRestaurante.Text;
            }
            if (rb_interno.Checked)
            {
                objPuestos.interno = true;
                objPuestos.externo = false;
            }
            if (rb_externo.Checked) {
                objPuestos.interno = false;
                objPuestos.externo = true;
            }
            try
            {
                dgv_puestos.AutoGenerateColumns = false;
                dgv_puestos.DataSource = objPuestos.carga_puestos_especificos(nombreRest,codRest).Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_puestos.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objPuestos.eliminar_Puesto(codigo);
                try
                {
                    dgv_puestos.AutoGenerateColumns = false;
                    dgv_puestos.DataSource = objPuestos.carga_puestos().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void dgv_puestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_puestos puestos = new frm_puestos();
                puestos.accion = "Editar";
                puestos.codigo = dgv_puestos.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                puestos.ShowDialog();
            }
        }
    }
}
