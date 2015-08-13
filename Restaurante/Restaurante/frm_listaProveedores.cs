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
    public partial class frm_listaProveedores : Form
    {
        Proveedores obj_Proveedores = new Proveedores();
        
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_listaProveedores()
        {
            InitializeComponent();
        }

        private void frm_listaProveedores_Load(object sender, EventArgs e)
        {
            cargar_lista_Proveedores();
        }

        private void dgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_proveedores prov = new frm_proveedores();
                prov.accion = "Editar";
                prov.nick = _nick;
                prov.codigo = dgv_proveedores.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                prov.ShowDialog();
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_proveedores prov = new frm_proveedores();
            prov.nick = _nick;
            prov.accion = "Insertar";
            prov.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgv_proveedores.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
                obj_Proveedores.eliminar_Proveedor(codigo);
                try
                {
                    dgv_proveedores.AutoGenerateColumns = false;
                    dgv_proveedores.DataSource = obj_Proveedores.carga_Proveedores().Tables[0];

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) { }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoProveedor.Text = "";
            txt_nombreProveedor.Text = "";
            txt_direccion.Text = "";
            mtb_cedula.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_codigoProveedor.Text != "")
            {
                obj_Proveedores.codigo = txt_codigoProveedor.Text;
            }

            else if (txt_nombreProveedor.Text != "")
            {
                obj_Proveedores.nombreP = txt_nombreProveedor.Text;
            }

            if (txt_direccion.Text != "")
            {
                obj_Proveedores.direccionP = txt_direccion.Text;
            }

            else if (mtb_cedula.Text != "")
            {
                obj_Proveedores.cedula = mtb_cedula.Text;
            }

            try
            {
                dgv_proveedores.AutoGenerateColumns = false;
                dgv_proveedores.DataSource = obj_Proveedores.carga_Proveedor_especifico().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            cargar_lista_Proveedores();
        }

        private void cargar_lista_Proveedores()
        {
            try
            {
                dgv_proveedores.AutoGenerateColumns = false;
                dgv_proveedores.DataSource = obj_Proveedores.carga_Proveedores().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
