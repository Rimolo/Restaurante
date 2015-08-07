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
    public partial class frm_ListaPaises : Form
    {
        Paises objPaises = new Paises();
        public frm_ListaPaises()
        {
            InitializeComponent();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.cargar_lista_paises();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoPais.Text = "";
            txt_nombrePais.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_codigoPais.Text != "")
            {
                objPaises.codigo = txt_codigoPais.Text;

            }
            else if (txt_nombrePais.Text != "")
            {
                objPaises.nombre = txt_codigoPais.Text;
            }

            try
            {
                dgv_paises.AutoGenerateColumns = false;
                dgv_paises.DataSource = objPaises.carga_pais_especifico().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_paises pais = new frm_paises();
            pais.accion = "Insertar";
            pais.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_paises.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objPaises.eliminar_pais(codigo);
                try
                {
                    dgv_paises.AutoGenerateColumns = false;
                    dgv_paises.DataSource = objPaises.carga_pais().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void dgv_paises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_paises pais = new frm_paises();
                pais.accion = "Editar";
                pais.codigo = dgv_paises.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                pais.ShowDialog();
            }
        }

        private void frm_ListaPaises_Load(object sender, EventArgs e)
        {
            this.cargar_lista_paises();
        }

        private void cargar_lista_paises()
        {
            try
            {
                dgv_paises.AutoGenerateColumns = false;
                dgv_paises.DataSource = objPaises.carga_pais().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
