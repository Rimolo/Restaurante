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
    public partial class frmListaBarras : Form
    {
        ClientesBarra objClientes = new ClientesBarra();

        private string _codR;
        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
        }

        private string _nombreR;

        public string nombreR
        {
            get { return _nombreR; }
            set { _nombreR = value; }
        }


        public frmListaBarras()
        {
            InitializeComponent();
        }

        private void frmListaBarras_Load(object sender, EventArgs e)
        {
            cargar_lista_clientes();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            cargar_lista_clientes();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoCliente.Text = "";
            txt_nombreCliente.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_codigoCliente.Text != "")
            {
                objClientes.codigo = txt_codigoCliente.Text;

            }
            else if (txt_nombreCliente.Text != "")
            {
                objClientes.nombre = txt_nombreCliente.Text;
            }

            try
            {
                dgv_barras.AutoGenerateColumns = false;
                dgv_barras.DataSource = objClientes.carga_cliente_especifico().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_barra barra = new frm_barra();
            barra.accion = "Insertar";
            barra.nombreR = _nombreR;
            barra.codR = _codR;
            barra.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_barras.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                objClientes.eliminar_cliente(codigo);
                try
                {
                    dgv_barras.AutoGenerateColumns = false;
                    dgv_barras.DataSource = objClientes.carga_clientes().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void dgv_barras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                frm_barra barra = new frm_barra();
                barra.accion = "Editar";
                barra.nombreR = _nombreR;
                barra.codR = _codR;
                barra.codigo = dgv_barras.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                barra.ShowDialog();
            }
        }

        private void cargar_lista_clientes()
        {
            try
            {
                dgv_barras.AutoGenerateColumns = false;
                dgv_barras.DataSource = objClientes.carga_clientes().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
