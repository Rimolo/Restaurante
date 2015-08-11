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
    public partial class frm_listaConsecutivos : Form
    {
        Consecutivos obj_consecutivos = new Consecutivos();

        public frm_listaConsecutivos()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_consecutivos consecutivos = new frm_consecutivos();
            consecutivos.accion = "Insertar";
            consecutivos.Show();
        }

        private void frm_listaConsecutivos_Load(object sender, EventArgs e)
        {
            this.carga_lista_consecutivos();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoConsecutivo.Text = "";
            txt_descripcionConsecutivo.Text = "";
        }

        private void dgv_consecutivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_consecutivos consecutivos = new frm_consecutivos();
                consecutivos.accion = "Editar";
                consecutivos.codigo = dgv_consecutivos.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                consecutivos.ShowDialog();
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_consecutivos();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_consecutivos.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_consecutivos.eliminar_consecutivos(codigo);
            try
            {
                dgv_consecutivos.AutoGenerateColumns = false;
                dgv_consecutivos.DataSource = obj_consecutivos.carga_consecutivos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }        

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_consecutivos.codConsecutivo = null;
            obj_consecutivos.tipo = null;
            if (txt_codigoConsecutivo.Text != "")
            {
                obj_consecutivos.codConsecutivo = txt_codigoConsecutivo.Text;

            }
            else if (txt_descripcionConsecutivo.Text != "")
            {
                obj_consecutivos.tipo = txt_descripcionConsecutivo.Text;
            }

            try
            {
                dgv_consecutivos.AutoGenerateColumns = false;
                dgv_consecutivos.DataSource = obj_consecutivos.carga_consecutivos_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void carga_lista_consecutivos()
        {
            try
            {
                dgv_consecutivos.AutoGenerateColumns = false;
                dgv_consecutivos.DataSource = obj_consecutivos.carga_consecutivos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
