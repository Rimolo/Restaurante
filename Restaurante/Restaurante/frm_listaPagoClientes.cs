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
    public partial class frm_listaPagoClientes : Form
    {
        Clientes objClientes = new Clientes();

        private string _codR;
        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
        }
                
        public frm_listaPagoClientes()
        {
            InitializeComponent();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            cargar_lista_clientes();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoCliente.Text = "";
            txt_nombreCliente.Text = "";
            rb_reservacion.Checked = false;
            dt_reservacion.Value = DateTime.Today;
            dt_reservacion.Enabled = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objClientes.codigo = null;
            objClientes.fechaE = dt_reservacion.Value.ToString("dd/MM/yyyy");
            objClientes.nombre = null;
            if (txt_codigoCliente.Text != "")
            {
                objClientes.codigo = txt_codigoCliente.Text;

            }
            if (txt_nombreCliente.Text != "")
            {
                objClientes.nombre = txt_nombreCliente.Text;
            }
            if (rb_reservacion.Checked)
            {
                objClientes.reservo = true;
                objClientes.fechaR = dt_reservacion.Value.ToString("dd/MM/yyyy").Replace("/","-");
            }
            else
            {
                objClientes.reservo = false;
                
            }
            try
            {
                dgv_pagoClientes.AutoGenerateColumns = false;
                dgv_pagoClientes.DataSource = objClientes.carga_cliente_especifico().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_listaPagoClientes_Load(object sender, EventArgs e)
        {
            objClientes.codR = _codR;
            dt_reservacion.Value = DateTime.Today;
            cargar_lista_clientes();
        }

        private void dgv_pagoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_clientes clientes = new frm_clientes();
                clientes.accion = "Editar";
                clientes.nombreR = "Piccola Stella";
                clientes.codR = _codR;
                clientes.codigo = dgv_pagoClientes.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                clientes.ShowDialog();
            }
        }

        private void cargar_lista_clientes()
        {
            try
            {
                dgv_pagoClientes.AutoGenerateColumns = false;
                dgv_pagoClientes.DataSource = objClientes.carga_clientes().Tables[0];
                

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void rb_reservacion_CheckedChanged(object sender, EventArgs e)
        {
            dt_reservacion.Enabled = false;
        }
    }
}
