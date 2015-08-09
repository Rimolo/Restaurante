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
    public partial class frm_listaEmpleados : Form
    {
        Empleados objEmpleados = new Empleados();
        public frm_listaEmpleados()
        {
            InitializeComponent();
        }

        private void frm_listaEmpleados_Load(object sender, EventArgs e)
        {
            cargar_lista_empleados();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            cargar_lista_empleados();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_administracion)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoEmpleado.Text = "";
            txt_nombreEmpleado.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_codigoEmpleado.Text != "")
            {
                objEmpleados.codigo = txt_codigoEmpleado.Text;

            }
            else if (txt_nombreEmpleado.Text != "")
            {
                objEmpleados.nombre = txt_nombreEmpleado.Text;
            }

            try
            {
                dgv_empleados.AutoGenerateColumns = false;
                dgv_empleados.DataSource = objEmpleados.carga_empleado_especifico().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            frm_empleados emp = new frm_empleados();
            emp.accion = "Insertar";
            emp.Show();
        }

        private void b_menos_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_empleados.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objEmpleados.eliminar_empleado(codigo);
                try
                {
                    dgv_empleados.AutoGenerateColumns = false;
                    dgv_empleados.DataSource = objEmpleados.carga_empleados().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_empleados emp = new frm_empleados();
                emp.accion = "Editar";
                emp.codigo = dgv_empleados.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                emp.ShowDialog();
            }
        }
        private void cargar_lista_empleados()
        {
            try
            {
                dgv_empleados.AutoGenerateColumns = false;
                dgv_empleados.DataSource = objEmpleados.carga_empleados().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
